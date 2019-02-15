using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Emit;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class TranslationRunner : MarshalByRefObject, IDisposable
    {
        static readonly ConsoleColor[] _messageColors = { ConsoleColor.White, ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Green };

        Dictionary<Type, NodeProcessor> _processors;

        internal TranslationRunner()
        {
            _processors = new Dictionary<Type, NodeProcessor>();

            ShaderLanguage.LoadEmbedded<HlslLanguage>("SharpShader.Languages.HLSL.lang.xml");
            ShaderLanguage.LoadEmbedded<GlslFoundation>("SharpShader.Languages.GLSL.lang.xml");

            // Preprocessors
            IEnumerable<Type> types = ShaderType.FindOfType<NodeProcessor>();
            foreach (Type t in types)
            {
                NodeProcessor pp = Activator.CreateInstance(t) as NodeProcessor;
                _processors.Add(pp.ParsedType, pp);
            }
        }

        internal TranslationContext Run(TranslationArgs args)
        {
            List<string> preprocessorSymbols = null;
            if (args.PreprocessorSymbols != null)
                preprocessorSymbols = new List<string>(args.PreprocessorSymbols);

            Stopwatch mainTimer = new Stopwatch();
            mainTimer.Start();

            ShaderLanguage foundation = ShaderLanguage.Get(args.Language);
            TranslationContext context = Pooling.Contexts.Get();
            context.Initialize(this, foundation, preprocessorSymbols);

            Message("Analyzing", TranslationMessageType.Status);
            AnalysisInfo analysis = Analyze(context, args.CSharpSources);
            Message($"Analysis completed");

            if (analysis.HasError)
            {
                foreach (TranslationMessage msg in context.Messages)
                    Message(msg.Text, msg.MessageType);

                Message($"Cannot proceed until errors are fixed. Aborting.");
            }
            else
            {
                Message($"Mapping shader classes", TranslationMessageType.Status);
                Map(context, analysis.Trees);
                Message($"Mapping completed. Found {context.Shaders.Count} shader classes.");

                foreach (ShaderTranslationContext sc in context.Shaders)
                {
                    Message($"Translating {sc.Name}", TranslationMessageType.Status);
                    Stopwatch timer = new Stopwatch();
                    timer.Start();

                    Message("Translating to {context.Language.Language}");
                    Translate(sc, sc.RootNode);

                    timer.Stop();
                    Message($"  Finished '{sc.Name}' in {timer.Elapsed.TotalMilliseconds:N2} milliseconds");
                }

                mainTimer.Stop();
                foreach (TranslationMessage msg in context.Messages)
                    Message(msg.Text, msg.MessageType);

                int errors = context.Messages.Count(t => t.MessageType == TranslationMessageType.Error);
                int warnings = context.Messages.Count(t => t.MessageType == TranslationMessageType.Warning);
                Message($"Finished conversion of { args.CSharpSources.Count} source(s) with {errors} errors and {warnings} warnings. ");
                Message($"Took {mainTimer.Elapsed.TotalMilliseconds:N2} milliseconds");
            }

            return context;
        }

        public void Dispose()
        {

        }

        private List<SyntaxTree> GenerateSyntaxTrees(TranslationContext context, Dictionary<string, string> cSharpSources)
        {
            Message($"Generating trees for {cSharpSources.Count} source(s)");
            List<SyntaxTree> sourceTrees = new List<SyntaxTree>();
            foreach (string sourceName in cSharpSources.Keys)
            {
                SyntaxTree tree = CSharpSyntaxTree.ParseText(cSharpSources[sourceName], context.ParseOptions);
                sourceTrees.Add(tree);
            }

            return sourceTrees;
        }

        private AnalysisInfo Analyze(TranslationContext context, Dictionary<string, string> cSharpSources)
        {
            AnalysisInfo info = new AnalysisInfo();
            info.Trees = GenerateSyntaxTrees(context, cSharpSources);

            List<MetadataReference> references = new List<MetadataReference>();
            references.Add(MetadataReference.CreateFromFile(typeof(Single).Assembly.Location));
            references.Add(MetadataReference.CreateFromFile(typeof(Vector4).Assembly.Location));

            CSharpCompilationOptions options = new CSharpCompilationOptions(
                OutputKind.DynamicallyLinkedLibrary,
                optimizationLevel: OptimizationLevel.Debug,
                allowUnsafe: true);

            CSharpCompilation compilation = CSharpCompilation.Create("sharp_shader_temp", info.Trees, references, options);

            using (MemoryStream ms = new MemoryStream())
            {
                EmitResult result = compilation.Emit(ms);

                foreach (Diagnostic d in result.Diagnostics)
                {
                    switch (d.Severity)
                    {
                        case DiagnosticSeverity.Error:
                            context.AddMessage(d.GetMessage(), d.Location);
                            info.HasError = true;
                            break;

                        case DiagnosticSeverity.Warning:
                            context.AddMessage(d.GetMessage(), d.Location, TranslationMessageType.Warning);
                            break;
                    }
                }

                if (!info.HasError)
                    context.Reflection.Assembly = Assembly.Load(ms.ToArray());
            }

            return info;
        }

        private void Map(TranslationContext context, List<SyntaxTree> trees)
        {
            foreach(SyntaxTree tree in trees)
            {
                SyntaxNode root = tree.GetRoot();
                MapShaderNodes(context, root, "");
            }
        }

        private void MapShaderNodes(TranslationContext context, SyntaxNode node, string strNamespace)
        {
            if (node is ClassDeclarationSyntax classNode)
            {
                string typeName = $"{strNamespace}.{classNode.Identifier}";
                Type t = context.Reflection.Assembly.GetType(typeName, false, false);
                if (t != null && context.Reflection.IsShaderType(t))
                {
                    ShaderTranslationContext sc = Pooling.ShaderContexts.Get();
                    sc.Initialize(context, classNode, t);
                    context.Shaders.Add(sc);
                    Message($"Mapped {t.FullName}");

                    // TODO: Remove this return if nested shaders are ever supported.
                    return;
                }
            }
            else if (node is NamespaceDeclarationSyntax nsNode)
            {
                if (strNamespace.Length > 0)
                    strNamespace += ".";

                strNamespace += nsNode.Name;
            }

            IEnumerable<SyntaxNode> stuff = node.ChildNodes();
            foreach (SyntaxNode child in stuff)
                MapShaderNodes(context, child, strNamespace);
        }

        internal void Translate(ShaderTranslationContext sc, SyntaxNode syntax, int depth = 0)
        {
            if (sc.IsCompleted(syntax))
                return;

            Type t = syntax.GetType();
            IEnumerable<SyntaxNode> children = syntax.ChildNodes();
            ScopeInfo lastScope = sc.Source.CurrentScope;

            if (_processors.TryGetValue(t, out NodeProcessor processor))
                processor.Translate(sc, syntax, sc.Source.CurrentScope);
            //else
             //   sc.Source.Append($"{Environment.NewLine}{new string('\t', depth)}// [[No translator for {t.Name}]] ");

            sc.Complete(syntax);

            foreach (SyntaxNode child in children)
                Translate(sc, child, depth + 1);

            while (lastScope != sc.Source.CurrentScope)
                sc.Source.CloseScope();
        }

        internal void Message(string msg, TranslationMessageType type = TranslationMessageType.Message)
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.Write("[SharpShader] [");
            Console.ForegroundColor = _messageColors[(int)type];
            Console.Write(type);
            Console.ForegroundColor = prevColor;
            Console.WriteLine($"] {msg}");
        }
    }
}