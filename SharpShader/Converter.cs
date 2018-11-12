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
        static Dictionary<Type, NodePreprocessor> _preprocessors;
        static Dictionary<Type, NodeMapper> _mappers;
        static readonly string[] _delimiters = { Environment.NewLine };
        const string BlockOpen = "{";
        const string BlockClosed = "}";

        static Converter()
        {
            _preprocessors = new Dictionary<Type, NodePreprocessor>();
            _mappers = new Dictionary<Type, NodeMapper>();

            ShaderLexicon.LoadeEmbeddedLexicon("SharpShader.Lexicon.hlsl.xml");
            ShaderLexicon.LoadeEmbeddedLexicon("SharpShader.Lexicon.glsl.xml");

            // Preprocessors
            IEnumerable<Type> types = FindOfType<NodePreprocessor>();
            foreach (Type t in types)
            {
                NodePreprocessor pp = Activator.CreateInstance(t) as NodePreprocessor;
                _preprocessors.Add(pp.ParsedType, pp);
            }

            // Mappers
            types = FindOfType<NodeMapper>();
            foreach (Type t in types)
            {
                NodeMapper mapper = Activator.CreateInstance(t) as NodeMapper;
                _mappers.Add(mapper.ParsedType, mapper);
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
            string[] lines = input.Split(_delimiters, StringSplitOptions.None);
            int indent = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Trim();

                bool blockStarted = lines[i].StartsWith(BlockOpen);
                bool blockEnded = lines[i].EndsWith(BlockClosed) || lines[i].EndsWith(BlockClosed + ";");

                if (lines[i].StartsWith(BlockClosed) && blockEnded)
                    indent = Math.Max(indent - 1, 0);

                lines[i] = new string('\t', indent) + lines[i];

                if (blockStarted && !blockEnded)
                    indent++;
            }

            return string.Join(Environment.NewLine, lines);
        }

        private static IEnumerable<Type> FindOfType<T>() where T : class
        {
            Type pType = typeof(T);
            Assembly assembly = pType.Assembly;
            return assembly.GetTypes().Where(t => t.IsSubclassOf(pType) && !t.IsAbstract);
        }

        #endregion

        #region Instance members
        public string Convert(string cSharpSource, ShaderLanguage output)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            ShaderLexicon lex = ShaderLexicon.GetLexicon(output);
            ConversionContext context = new ConversionContext(lex);
            context.RegenerateTree(cSharpSource);

            List<SyntaxNode> nodesToProcess = new List<SyntaxNode>();
            foreach(Type t in _preprocessors.Keys)
            {
                GatherNodes(context, context.Root, t, nodesToProcess);
                Preprocess(context, t, nodesToProcess);
                nodesToProcess.Clear();
            }
            
            Map(context, context.Root, 0);

            string result = context.Root.ToString();
            result = CorrectIndents(result);
            timer.Stop();
            Console.WriteLine($"Finished in {timer.Elapsed.TotalMilliseconds:N2} milliseconds");
            return result;
        }

        private void GatherNodes(ConversionContext context, SyntaxNode node, Type nodeType, List<SyntaxNode> nodesToProcess)
        {
            Type t = node.GetType();
            if (t == nodeType)
                nodesToProcess.Add(node);

            IEnumerable<SyntaxNode> stuff = node.ChildNodes();
            foreach (SyntaxNode child in stuff)
                GatherNodes(context, child, nodeType, nodesToProcess);
        }

        private void Preprocess(ConversionContext context, Type nodeType, List<SyntaxNode> nodes)
        {
            StringBuilder source = new StringBuilder(context.Tree.ToString());
            NodePreprocessor processor = _preprocessors[nodeType];

            // Iterate backwards; Bottom to top. 
            // Iterating in this way ensures any changes made by preprocessors will not invalidate the locations of earlier nodes.
            for (int i = nodes.Count - 1; i >= 0; i--)
                processor.Process(context, nodes[i], source);

            context.RegenerateTree(source.ToString());
        }

        private void Map(ConversionContext context, SyntaxNode node, int depth)
        {
            IEnumerable<SyntaxNode> stuff = node.ChildNodes();
            foreach (SyntaxNode child in stuff)
            {
                Type t = child.GetType();

                if (_mappers.TryGetValue(t, out NodeMapper mapper))
                {
                    SyntaxTree tree = context.Tree;
                    mapper.Map(context, child);
                    if (tree != context.Tree)
                        throw new Exception("The syntax tree was modified during mapping");
                }

                Map(context, child, depth + 1);
            }
        }
        #endregion
    }
}
