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
    /// <summary>
    /// Converts C# source code into shader language code.
    /// </summary>
    public class Converter
    {
        #region Static members
        static Dictionary<Type, NodeProcessor> _preprocessors;
        static Dictionary<Type, NodeProcessor> _mappers;
        static Dictionary<Type, NodeProcessor> _postProcessors;
        static readonly string[] _delimiters = { Environment.NewLine };
        const string BlockOpen = "{";
        const string BlockClosed = "}";

        static Converter()
        {
            _preprocessors = new Dictionary<Type, NodeProcessor>();
            _mappers = new Dictionary<Type, NodeProcessor>();
            _postProcessors = new Dictionary<Type, NodeProcessor>();

            LanguageFoundation.LoadEmbedded<HlslFoundation>("SharpShader.Foundations.hlsl.xml");
            LanguageFoundation.LoadEmbedded<GlslFoundation>("SharpShader.Foundations.glsl.xml");

            // Preprocessors
            IEnumerable<Type> types = FindOfType<NodeProcessor>();
            foreach (Type t in types)
            {
                NodeProcessor pp = Activator.CreateInstance(t) as NodeProcessor;

                if(pp.HasStageFlags(NodeProcessStageFlags.PreProcess))
                    _preprocessors.Add(pp.ParsedType, pp);

                if (pp.HasStageFlags(NodeProcessStageFlags.Mapping))
                    _mappers.Add(pp.ParsedType, pp);

                if (pp.HasStageFlags(NodeProcessStageFlags.PostProcess))
                    _postProcessors.Add(pp.ParsedType, pp);
            }
        }

        internal static void Message(string msg)
        {
            Console.WriteLine($"[SharpShader] {msg}");
        }

        /// <summary>
        /// Strips and re-adds the correct amount of indentation to a code string.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="minIndent">The minimum level of indentation.</param>
        /// <returns></returns>
        private static string CorrectIndents(string input, ConversionFlags flags)
        {
            string[] lines = input.Trim().Split(_delimiters, StringSplitOptions.None);
            int indent = 0;
            bool prevLineEmpty = false;
            int newLineCount = lines.Length;

            for (int i = 0; i < newLineCount; i++)
            {
                lines[i] = lines[i].Trim();


                // Remove consecutive empty lines.
                bool curLineEmpty = string.IsNullOrWhiteSpace(lines[i]);
                int cPos = i + 1;
                if (prevLineEmpty && curLineEmpty && cPos < lines.Length)
                {
                    Array.Copy(lines, cPos, lines, i, lines.Length - cPos);
                    i--;
                    newLineCount--;
                    continue;
                }

                // TODO improve this later. It's fugly!
                bool blockStarted = lines[i].StartsWith(BlockOpen);
                bool blockEnded = lines[i].EndsWith(BlockClosed) || 
                    lines[i].EndsWith(BlockClosed + ";") || 
                    lines[i].StartsWith(BlockClosed + "//") || 
                    lines[i].StartsWith(BlockClosed + " //");

                if (lines[i].StartsWith(BlockClosed) && blockEnded)
                    indent = Math.Max(indent - 1, 0);


                lines[i] = new string('\t', indent) + lines[i];
                if (lines[i].StartsWith("//"))
                {
                    if ((flags & ConversionFlags.StripComments) == ConversionFlags.StripComments)
                        lines[i] = "";
                }

                if (blockStarted && !blockEnded)
                    indent++;

                prevLineEmpty = curLineEmpty;
            }

            return string.Join(Environment.NewLine, lines, 0, newLineCount);
        }

        private static string RemoveWhitespace(string input, ConversionFlags flags)
        {
            string[] lines = input.Trim().Split(_delimiters, StringSplitOptions.None);
            for (int i = 0; i < lines.Length; i++)
            {
                // TODO check if the output language supports comment blocks. If not, add a line break to the end of the comment.
                lines[i] = lines[i].Trim();
                if (lines[i].StartsWith("//"))
                {
                    if ((flags & ConversionFlags.StripComments) == ConversionFlags.StripComments)
                        lines[i] = "";
                    else
                        lines[i] = $"/* {lines[i]} */";
                }
            }

            return string.Join("", lines);
        }

        private static IEnumerable<Type> FindOfType<T>() where T : class
        {
            Type pType = typeof(T);
            Assembly assembly = pType.Assembly;
            return assembly.GetTypes().Where(t => t.IsSubclassOf(pType) && !t.IsAbstract);
        }
        #endregion

        #region Instance members

        /// <summary>
        /// Converts the provided C# source code to the specified shader language.
        /// </summary>
        /// <param name="fileOrFriendlyName">The filename or friendly name to assign to the source code.</param>
        /// <param name="cSharpSource">The C# source code to be converted.</param>
        /// <param name="outputLanguage">The output shader language.</param>
        /// <param name="flags">A set of flags to change the default behaviour of the converter.</param>
        /// <returns></returns>
        public ConversionResult Convert(string fileOrFriendlyName, string cSharpSource, ShaderLanguage outputLanguage, ConversionFlags flags = ConversionFlags.None)
        {
            return Convert(new Dictionary<string, string>()
            {
                [fileOrFriendlyName] = cSharpSource,
            }, 
            outputLanguage, flags);
        }

        /// <summary>
        /// Converts the provided C# source code to the specified shader language.
        /// </summary>
        /// <param name="cSharpSources">A dictionary containing source code by file or friendly name.</param>
        /// <param name="outputLanguage">The language that the input source code should be translated to.</param>
        /// <param name="flags">A set of flags to change the default behaviour of the converter.</param>
        /// <returns></returns>
        public ConversionResult Convert(Dictionary<string, string> cSharpSources, ShaderLanguage outputLanguage, ConversionFlags flags = ConversionFlags.None)
        {
            LanguageFoundation foundation = LanguageFoundation.Get(outputLanguage);
            ConversionContext context = new ConversionContext(foundation);
            Stopwatch mainTimer = new Stopwatch();
            mainTimer.Start();

            if ((flags & ConversionFlags.SkipAnalysis) != ConversionFlags.SkipAnalysis)
            {
                Message("Analyzing...");
                Analyze(context, cSharpSources);
                int analysisErrors = context.Messages.Count(t => t.MessageType == ConversionMessageType.Error);
                Message($"Analysis completed");

                if (analysisErrors > 0)
                {
                    foreach (ConversionMessage msg in context.Messages)
                        Message($"[{msg.MessageType}] {msg.Text}");

                    Message($"Cannot proceed until {analysisErrors} errors are fixed. Aborting.");
                    return context.ToResult();
                }
            }
            else
            {
                Message($"Skipping analysis");
                GenerateSourceTrees(context, cSharpSources);
            }

            foreach(ShaderContext shader in context.Shaders)
            {
                Message($"Translating '{shader.Name}'...");
                Stopwatch timer = new Stopwatch();
                timer.Start();

                Message("  Stage 1/3 (pre-process)...");
                List<SyntaxNode> nodesToProcess = new List<SyntaxNode>();
                foreach (Type t in _preprocessors.Keys)
                {
                    Message($"    Processing {t.Name} nodes");
                    GatherNodes(context, shader.Root, t, nodesToProcess);
                    Preprocess(shader, t, nodesToProcess);
                    nodesToProcess.Clear();
                }

                Message("  Stage 2/3 (mapping)...");
                Map(shader, shader.Root);

                Message("  Stage 3/3 (translation)...");
                shader.Source = PostProcess(shader);

                if ((flags & ConversionFlags.SkipFormatting) != ConversionFlags.SkipFormatting)
                {
                    if ((flags & ConversionFlags.RemoveWhitespace) == ConversionFlags.RemoveWhitespace)
                    {
                        shader.Source = RemoveWhitespace(shader.Source, flags);
                        Message("  Stripped whitespace");
                    }
                    else
                    {
                        shader.Source = CorrectIndents(shader.Source, flags);
                        Message("  Corrected indentation");
                    }
                }
                else
                    Message($"  Skipped formatting step");

                timer.Stop();
                Message($"  Finished '{shader.Name}' in {timer.Elapsed.TotalMilliseconds:N2} milliseconds");
            }

            mainTimer.Stop();
            int errors = context.Messages.Count(t => t.MessageType == ConversionMessageType.Error);
            int warnings = context.Messages.Count(t => t.MessageType == ConversionMessageType.Warning);

            foreach (ConversionMessage msg in context.Messages)
                Message($"[{msg.MessageType}] {msg.Text}");

            Message($"Finished conversion of { cSharpSources.Count} source(s) with {errors} errors and {warnings} warnings. ");
            Message($"Took {mainTimer.Elapsed.TotalMilliseconds:N2} milliseconds");

            return context.ToResult();
        }

        private List<SyntaxTree> GenerateSourceTrees(ConversionContext context, Dictionary<string, string> cSharpSources)
        {
            Message($"Generating trees for {cSharpSources.Count} source(s)");
            List<SyntaxTree> sourceTrees = new List<SyntaxTree>();
            foreach (string sourceName in cSharpSources.Keys)
            {
                ShaderContext shaderContext = context.AddShader(sourceName);
                shaderContext.RegenerateTree(cSharpSources[sourceName]);
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
                concurrentBuild: true);

            CSharpCompilation compilation = CSharpCompilation.Create("sharp_shader_temp", sourceTrees, references, options);
            using (MemoryStream ms = new MemoryStream())
            {
                EmitResult result = compilation.Emit(ms);
                foreach(Diagnostic d in result.Diagnostics)
                {
                    FileLinePositionSpan pos = d.Location.GetLineSpan();
                    switch (d.Severity)
                    {
                        case DiagnosticSeverity.Error:
                            context.AddMessage(d.GetMessage(), pos.StartLinePosition.Line, pos.StartLinePosition.Character);
                            break;

                        case DiagnosticSeverity.Warning:
                            context.AddMessage(d.GetMessage(), pos.StartLinePosition.Line, pos.StartLinePosition.Character, ConversionMessageType.Warning);
                            break;
                    }
                }
            }
        }

        private void GatherNodes(ConversionContext context, SyntaxNode node, Type nodeType, List<SyntaxNode> nodesToProcess, int depth = 0)
        {
            Type t = node.GetType();
            if (t == nodeType)
                nodesToProcess.Add(node);

            IEnumerable<SyntaxNode> stuff = node.ChildNodes();
            foreach (SyntaxNode child in stuff)
                GatherNodes(context, child, nodeType, nodesToProcess, depth + 1);
        }

        private void Preprocess(ShaderContext context, Type nodeType, List<SyntaxNode> nodes)
        {
            StringBuilder source = new StringBuilder(context.Tree.ToString());
            NodeProcessor processor = _preprocessors[nodeType];

            // Iterate backwards; Bottom to top. 
            // Iterating in this way ensures any changes made by preprocessors will not invalidate the locations of earlier nodes.
            for (int i = nodes.Count - 1; i >= 0; i--)
                processor.Preprocess(context, nodes[i], source);

            context.RegenerateTree(source.ToString());
        }

        private void Map(ShaderContext shader, SyntaxNode node)
        {
            IEnumerable<SyntaxNode> stuff = node.ChildNodes();  
            foreach (SyntaxNode child in stuff)
            {
                Type t = child.GetType();

                if (_mappers.TryGetValue(t, out NodeProcessor mapper))
                {
                    SyntaxTree tree = shader.Tree;
                    mapper.Map(shader, child);
                    if (tree != shader.Tree)
                        throw new Exception("The syntax tree was modified during mapping stage");
                }

                Map(shader, child);
            }
        }

        private string PostProcess(ShaderContext shader)
        {
            StringBuilder source = new StringBuilder(shader.Tree.ToString());

            // Iterate backwards; Bottom to top. 
            // Iterating in this way ensures any changes made by post-processors will not invalidate the locations of earlier nodes.
            for (int i = shader.Map.Components.Count - 1; i >= 0; i--)
            {
                ShaderComponent com = shader.Map.Components[i];
                SyntaxNode node = com.Node;
                Type test = node.GetType();
                if (_postProcessors.TryGetValue(node.GetType(), out NodeProcessor proc))
                    proc.Translate(shader, node, source, com);
            }

            return source.ToString();
        }
        #endregion
    }
}
