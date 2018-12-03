using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
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

        /// <summary>
        /// Strips and re-adds the correct amount of indentation to a code string.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="minIndent">The minimum level of indentation.</param>
        /// <returns></returns>
        public static string CorrectIndents(string input)
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

                bool blockStarted = lines[i].StartsWith(BlockOpen);
                bool blockEnded = lines[i].EndsWith(BlockClosed) || 
                    lines[i].EndsWith(BlockClosed + ";") || 
                    lines[i].StartsWith(BlockClosed + "//") || 
                    lines[i].StartsWith(BlockClosed + " //");

                if (lines[i].StartsWith(BlockClosed) && blockEnded)
                    indent = Math.Max(indent - 1, 0);

                lines[i] = new string('\t', indent) + lines[i];

                if (blockStarted && !blockEnded)
                    indent++;

                prevLineEmpty = curLineEmpty;
            }

            return string.Join(Environment.NewLine, lines, 0, newLineCount);
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
        /// <param name="outputLanguage"></param>
        /// <returns></returns>
        public ConversionResult Convert(string fileOrFriendlyName, string cSharpSource, ShaderLanguage outputLanguage)
        {
            return Convert(new Dictionary<string, string>()
            {
                [fileOrFriendlyName] = cSharpSource,
            }, 
            outputLanguage);
        }

        /// <summary>
        /// Converts the provided C# source code to the specified shader language.
        /// </summary>
        /// <param name="cSharpSources">A dictionary containing source code by file or friendly name.</param>
        /// <param name="outputLanguage">The language that the input source code should be translated to.</param>
        /// <returns></returns>
        public ConversionResult Convert(Dictionary<string, string> cSharpSources, ShaderLanguage outputLanguage)
        {
            LanguageFoundation foundation = LanguageFoundation.Get(outputLanguage);
            ConversionContext context = new ConversionContext(foundation);
            Stopwatch mainTimer = new Stopwatch();
            mainTimer.Start();

            foreach(KeyValuePair<string,string> kvp in cSharpSources)
            {
                Console.WriteLine($"Translating '{kvp.Key}'");
                Stopwatch timer = new Stopwatch();
                timer.Start();
                context.StartNewShader(kvp.Key);
                context.RegenerateTree(kvp.Value);

                Console.WriteLine("  Stage 1/3 (pre-process)...");
                List<SyntaxNode> nodesToProcess = new List<SyntaxNode>();
                foreach (Type t in _preprocessors.Keys)
                {
                    Console.WriteLine($"    Processing {t.Name} nodes");
                    GatherNodes(context, context.Root, t, nodesToProcess);
                    Preprocess(context, t, nodesToProcess);
                    nodesToProcess.Clear();
                }

                Console.WriteLine("  Stage 2/3 (mapping)...");
                Map(context, context.Root);

                Console.WriteLine("  Stage 3/3 (post-process)...");
                string strResult = PostProcess(context);
                context.CurrentShader.SourceCode = CorrectIndents(strResult);
                timer.Stop();
                Console.WriteLine($"  Finished '{kvp.Key}' in {timer.Elapsed.TotalMilliseconds:N2} milliseconds");
                context.Clear();
            }

            mainTimer.Stop();
            Console.WriteLine($"  Converted {cSharpSources.Count} source(s) in {mainTimer.Elapsed.TotalMilliseconds:N2} milliseconds");

            return context.Result;
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

        private void Preprocess(ConversionContext context, Type nodeType, List<SyntaxNode> nodes)
        {
            StringBuilder source = new StringBuilder(context.Tree.ToString());
            NodeProcessor processor = _preprocessors[nodeType];

            // Iterate backwards; Bottom to top. 
            // Iterating in this way ensures any changes made by preprocessors will not invalidate the locations of earlier nodes.
            for (int i = nodes.Count - 1; i >= 0; i--)
                processor.Preprocess(context, nodes[i], source);

            context.RegenerateTree(source.ToString());
        }

        private void Map(ConversionContext context, SyntaxNode node)
        {
            IEnumerable<SyntaxNode> stuff = node.ChildNodes();  
            foreach (SyntaxNode child in stuff)
            {
                Type t = child.GetType();

                if (_mappers.TryGetValue(t, out NodeProcessor mapper))
                {
                    SyntaxTree tree = context.Tree;
                    mapper.Map(context, child);
                    if (tree != context.Tree)
                        throw new Exception("The syntax tree was modified during mapping stage");
                }

                Map(context, child);
            }
        }

        private string PostProcess(ConversionContext context)
        {
            StringBuilder source = new StringBuilder(context.Tree.ToString());

            // Iterate backwards; Bottom to top. 
            // Iterating in this way ensures any changes made by post-processors will not invalidate the locations of earlier nodes.
            for (int i = context.Map.Components.Count - 1; i >= 0; i--)
            {
                ShaderComponent com = context.Map.Components[i];
                SyntaxNode node = com.Node;
                Type test = node.GetType();
                if (_postProcessors.TryGetValue(node.GetType(), out NodeProcessor proc))
                    proc.Postprocess(context, node, source, com);
            }

            return source.ToString();
        }
        #endregion
    }
}
