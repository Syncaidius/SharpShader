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
        static Dictionary<Type, NodePreprocessor> _preprocessors;
        static Dictionary<Type, NodeMapper> _mappers;

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

        private static IEnumerable<Type> FindOfType<T>() where T : class
        {
            Type pType = typeof(T);
            Assembly assembly = pType.Assembly;
            return assembly.GetTypes().Where(t => t.IsSubclassOf(pType) && !t.IsAbstract);
        }

        public string Convert(string cSharpSource, ShaderLanguage output)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            ShaderLexicon lex = ShaderLexicon.GetLexicon(output);
            ConversionContext context = new ConversionContext(lex);
            context.RegenerateTree(cSharpSource);

            int iterations = 1;
            while(Preprocess(context, context.Root, 0))
            {
                Console.WriteLine($"Completed iteration {iterations}");
                iterations++;
            }

            Map(context, context.Root, 0);

            string result = context.Root.ToString();
            result = ShaderFormatting.CorrectIndents(result);
            timer.Stop();
            Console.WriteLine($"Finished in {timer.Elapsed.TotalMilliseconds:N2} milliseconds");
            return result;
        }

        private bool Preprocess(ConversionContext context, SyntaxNode node, int depth)
        {
            IEnumerable<SyntaxNode> stuff = node.ChildNodes();
            foreach (SyntaxNode child in stuff)
            {
                Type t = child.GetType();

                if (_preprocessors.TryGetValue(t, out NodePreprocessor pp))
                {
                    SyntaxTree tree = context.Tree;
                    pp.Process(context, child);
                    if (tree != context.Tree || Preprocess(context, child, depth + 1))
                        return true;                    
                }
                else
                {
                    if (Preprocess(context, child, depth + 1))
                        return true;
                }
            }

            return false;
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
    }
}
