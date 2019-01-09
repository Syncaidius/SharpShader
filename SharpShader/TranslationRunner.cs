using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
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
        public Dictionary<string, string> CSharpSources;
        public OutputLanguage Language;
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
            IEnumerable<Type> types = FindOfType<NodeProcessor>();
            foreach (Type t in types)
            {
                NodeProcessor pp = Activator.CreateInstance(t) as NodeProcessor;
                _processors.Add(pp.ParsedType, pp);
            }
        }

        private static IEnumerable<Type> FindOfType<T>() where T : class
        {
            Type pType = typeof(T);
            Assembly assembly = pType.Assembly;
            return assembly.GetTypes().Where(t => t.IsSubclassOf(pType) && !t.IsAbstract);
        }

        public ConversionContext Run(TranslationArgs args)
        {
            ShaderLanguage foundation = ShaderLanguage.Get(args.Language);
            ConversionContext context = new ConversionContext(foundation);
            Stopwatch mainTimer = new Stopwatch();
            mainTimer.Start();

            Message("Analyzing...");
            Analyze(context, args.CSharpSources);
            int analysisErrors = context.Messages.Count(t => t.MessageType == ConversionMessageType.Error);
            Message($"Analysis completed");

            if (analysisErrors > 0)
            {
                foreach (ConversionMessage msg in context.Messages)
                    Message(msg.Text, msg.MessageType);

                Message($"Cannot proceed until {analysisErrors} errors are fixed. Aborting.");
                return context;
            }

            foreach (ShaderContext shader in context.Shaders)
            {
                Message($"Translating '{shader.Name}'...");
                Stopwatch timer = new Stopwatch();
                timer.Start();

                Message("  Stage 1/3 (pre-process)...");
                List<SyntaxNode> nodesToProcess = new List<SyntaxNode>();
                foreach (Type t in _processors.Keys)
                {
                    Message($"    Processing {t.Name} nodes");
                    CollectNodes(context, shader.Root, t, nodesToProcess);
                    Preprocess(shader, t, nodesToProcess);
                    nodesToProcess.Clear();
                }

                Message("  Stage 2/3 (mapping)...");
                List<NodeEntry> mappedEntries = new List<NodeEntry>();
                Map(shader, shader.Root, mappedEntries);

                Message("  Stage 3/3 (translation)...");
                Translate(shader, mappedEntries);

                timer.Stop();
                Message($"  Finished '{shader.Name}' in {timer.Elapsed.TotalMilliseconds:N2} milliseconds");
            }

            mainTimer.Stop();
            int errors = context.Messages.Count(t => t.MessageType == ConversionMessageType.Error);
            int warnings = context.Messages.Count(t => t.MessageType == ConversionMessageType.Warning);

            foreach (ConversionMessage msg in context.Messages)
                Message(msg.Text, msg.MessageType);

            Message($"Finished conversion of { args.CSharpSources.Count} source(s) with {errors} errors and {warnings} warnings. ");
            Message($"Took {mainTimer.Elapsed.TotalMilliseconds:N2} milliseconds");

            return context;
        }

        private List<SyntaxTree> GenerateSourceTrees(ConversionContext context, Dictionary<string, string> cSharpSources)
        {
            Message($"Generating trees for {cSharpSources.Count} source(s)");
            List<SyntaxTree> sourceTrees = new List<SyntaxTree>();
            foreach (string sourceName in cSharpSources.Keys)
            {
                ShaderContext shaderContext = context.AddShader(sourceName, cSharpSources[sourceName]);
                sourceTrees.Add(shaderContext.Tree);
            }

            return sourceTrees;
        }

        private void Analyze(ConversionContext context, Dictionary<string, string> cSharpSources)
        {
            List<SyntaxTree> sourceTrees = GenerateSourceTrees(context, cSharpSources);
            List<MetadataReference> references = new List<MetadataReference>();
            references.Add(MetadataReference.CreateFromFile(typeof(Single).Assembly.Location));
            references.Add(MetadataReference.CreateFromFile(typeof(Vector4).Assembly.Location));

            CSharpCompilationOptions options = new CSharpCompilationOptions(
                OutputKind.DynamicallyLinkedLibrary,
                optimizationLevel: OptimizationLevel.Release,
                allowUnsafe: true,
                concurrentBuild: true);

            CSharpCompilation compilation = CSharpCompilation.Create("sharp_shader_temp", sourceTrees, references, options);
            using (MemoryStream ms = new MemoryStream())
            {
                EmitResult result = compilation.Emit(ms);
                foreach (Diagnostic d in result.Diagnostics)
                {
                    switch (d.Severity)
                    {
                        case DiagnosticSeverity.Error:
                            context.AddMessage(d.GetMessage(), d.Location);
                            break;

                        case DiagnosticSeverity.Warning:
                            context.AddMessage(d.GetMessage(), d.Location, ConversionMessageType.Warning);
                            break;
                    }
                }
            }
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
