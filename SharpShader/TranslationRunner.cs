using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Emit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    public class TranslationArgs : MarshalByRefObject
    {
        /// <summary>
        /// C# source strings, indexed by friendly name or file name.
        /// </summary>
        public Dictionary<string, string> CSharpSources;

        /// <summary>
        /// The output language.
        /// </summary>
        public OutputLanguage Language;
        
        /// <summary>
        /// The flags to apply to the conversion.
        /// </summary>
        public ConversionFlags Flags;
    }

    public class TranslationRunner : MarshalByRefObject
    {
        static Dictionary<Type, NodeProcessor> _processors;
        static readonly ConsoleColor[] MessageColors = { ConsoleColor.White, ConsoleColor.Red, ConsoleColor.Yellow };

        static TranslationRunner()
        {
            _processors = new Dictionary<Type, NodeProcessor>();

            ShaderLanguage.LoadEmbedded<HlslLanguage>("SharpShader.Languages.HLSL.lang.xml");
            ShaderLanguage.LoadEmbedded<GlslFoundation>("SharpShader.Languages.GLSL.lang.xml");

            // Preprocessors
            IEnumerable<Type> types = ReflectionHelper.FindOfType<NodeProcessor>();
            foreach (Type t in types)
            {
                NodeProcessor pp = Activator.CreateInstance(t) as NodeProcessor;
                _processors.Add(pp.ParsedType, pp);
            }
        }

        public ConversionContext Run(TranslationArgs args)
        {
            ShaderLanguage foundation = ShaderLanguage.Get(args.Language);
            ConversionContext context = new ConversionContext(foundation);
            Stopwatch mainTimer = new Stopwatch();
            mainTimer.Start();

            Message("Analyzing");
            AnalysisInfo analysis = Analyze(context, args.CSharpSources);
            Message($"Analysis completed");

            if (analysis.HasError)
            {
                foreach (ConversionMessage msg in context.Messages)
                    Message(msg.Text, msg.MessageType);

                Message($"Cannot proceed until errors are fixed. Aborting.");
                return context;
            }

            /* TODO RESTRUCTURE:
             *   -- Scrap the pre-process step. This is pointless.
             *   -- Mapping stage will use node processors to tie information together from syntax nodes and reflection.
             *   -- Translate stage will do mostly what it does now, but be cleaned up to make use of reflection whenever possible.
             *   -- New stage: Isolate. When parsing a tree, locate every CSharpShader sub-type and isolate each one into it's own tree.
             *      -- Track any namespace nodes while drilling into the tree. Any nested namespace declarations should be automatically caught and construction into a full namespace
             *              -- E.g. nested namespaces of "Chicken" and then "Wings" will form "Chicken.Wings" when tracked down the tree.
             *      -- This info will be stored in a ShaderContext.
             *    
             * NOTES:
             *  -- Method declarations and calls can use reflection info attached during mapping to aid translation.
             *  -- Resolving types will now be MUCH easier
             *  -- Detecting whether a SharpShader type implements certain interfaces will be a lot easier.
             *  -- Parsing attributes can be done directly using reflection, by retrieving the target member's Attribute reflection data.
             *  -- Detailed info about an attributes arguments will be useful in speeding-up attribute parsing.
             *  -- Mapping the fields of a shader will simple, via reflection
             */

            Message($"Isolating shader classes");
            List<ShaderContext> shaders = Isolate(context, analysis.Trees);
            Message($"Isolation completed. Found {shaders.Count} shader classes.");

            mainTimer.Stop();

            //foreach (ShaderContext shader in context.Shaders)
            //{
            //    Stopwatch timer = new Stopwatch();
            //    timer.Start();

            //    Message("  Stage 1/3 (pre-process)...");
            //    List<SyntaxNode> nodesToProcess = new List<SyntaxNode>();
            //    foreach (Type t in _processors.Keys)
            //    {
            //        Message($"    Processing {t.Name} nodes");
            //        CollectNodes(context, shader.Root, t, nodesToProcess);
            //        Preprocess(shader, t, nodesToProcess);
            //        nodesToProcess.Clear();
            //    }

            //    Message("  Stage 2/3 (mapping)...");
            //    List<NodeEntry> mappedEntries = new List<NodeEntry>();
            //    Map(shader, shader.Root, mappedEntries);

            //    Message("  Stage 3/3 (translation)...");
            //    Translate(shader, mappedEntries);

            //    timer.Stop();
            //    Message($"  Finished '{shader.Name}' in {timer.Elapsed.TotalMilliseconds:N2} milliseconds");
            //}

            //mainTimer.Stop();
            //int errors = context.Messages.Count(t => t.MessageType == ConversionMessageType.Error);
            //int warnings = context.Messages.Count(t => t.MessageType == ConversionMessageType.Warning);

            //foreach (ConversionMessage msg in context.Messages)
            //    Message(msg.Text, msg.MessageType);

            //Message($"Finished conversion of { args.CSharpSources.Count} source(s) with {errors} errors and {warnings} warnings. ");
            //Message($"Took {mainTimer.Elapsed.TotalMilliseconds:N2} milliseconds");

            return context;
        }

        private List<SyntaxTree> GenerateSyntaxTrees(ConversionContext context, Dictionary<string, string> cSharpSources)
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

        private AnalysisInfo Analyze(ConversionContext context, Dictionary<string, string> cSharpSources)
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
                            context.AddMessage(d.GetMessage(), d.Location, ConversionMessageType.Warning);
                            break;
                    }
                }

                if (!info.HasError)
                    context.Reflection.Assembly = Assembly.Load(ms.ToArray());
            }

            return info;
        }

        private List<ShaderContext> Isolate(ConversionContext context, List<SyntaxTree> trees)
        {
            List<ShaderContext> shaders = new List<ShaderContext>();

            foreach(SyntaxTree tree in trees)
            {
                SyntaxNode root = tree.GetRoot();
                IsolateShaderNodes(context, root, "", shaders);
            }

            return shaders;
        }

        private void IsolateShaderNodes(ConversionContext context, SyntaxNode node, string strNamespace, List<ShaderContext> shaders)
        {
            if (node is ClassDeclarationSyntax classNode)
            {
                string typeName = $"{strNamespace}.{classNode.Identifier}";
                Type t = context.Reflection.Assembly.GetType(typeName, false, false);
                if (t != null && context.Reflection.IsShaderType(t))
                {
                    shaders.Add(new ShaderContext(context, classNode, t));
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
                IsolateShaderNodes(context, child, strNamespace, shaders);
        }

        private void CollectNodes(ConversionContext context, SyntaxNode node, Type nodeType, List<SyntaxNode> nodesToProcess, int depth = 0)
        {
            Type t = node.GetType();
            if (t == nodeType)
                nodesToProcess.Add(node);

            IEnumerable<SyntaxNode> stuff = node.ChildNodes();
            foreach (SyntaxNode child in stuff)
                CollectNodes(context, child, nodeType, nodesToProcess, depth + 1);
        }

        private void Preprocess(ShaderContext context, Type nodeType, List<SyntaxNode> nodes)
        {
            StringBuilder source = new StringBuilder(context.Tree.ToString());
            NodeProcessor processor = _processors[nodeType];

            // Iterate backwards; Bottom to top. 
            // Iterating in this way ensures any changes made by preprocessors will not invalidate the locations of earlier nodes.
            for (int i = nodes.Count - 1; i >= 0; i--)
                processor.Preprocess(context, nodes[i]);

            context.RegenerateTree();
        }

        private void Map(ShaderContext shader, SyntaxNode node, List<NodeEntry> mappedEntries)
        {
            Type t = node.GetType();
            if (_processors.TryGetValue(t, out NodeProcessor processor))
            {
                mappedEntries.Add(new NodeEntry()
                {
                    Node = node,
                    Processor = processor
                });
                SyntaxTree tree = shader.Tree;
                processor.Map(shader, node);
                if (tree != shader.Tree)
                    throw new Exception($"The syntax tree was modified during mapping stage by a '{t.Name}'.");

                // TODO: Remove this return if nested shaders are ever supported.
                return;
            }

            IEnumerable<SyntaxNode> stuff = node.ChildNodes();
            foreach (SyntaxNode child in stuff)
                Map(shader, child, mappedEntries);
        }

        private string Translate(ShaderContext shader, List<NodeEntry> mappedEntries)
        {
            StringBuilder source = new StringBuilder(shader.Tree.ToString());

            // Iterate backwards to ensure preceeding nodes do not become mis-aligned with their spans.
            for (int i = mappedEntries.Count - 1; i >= 0; i--)
            {
                NodeEntry e = mappedEntries[i];
                e.Processor.Translate(shader, e.Node);
            }

            return source.ToString();
        }

        internal static void Message(string msg, ConversionMessageType type = ConversionMessageType.Message)
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.Write("[SharpShader] [");
            Console.ForegroundColor = MessageColors[(int)type];
            Console.Write(type);
            Console.ForegroundColor = prevColor;
            Console.WriteLine($"] {msg}");
        }
    }
}