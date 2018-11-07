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
        static Dictionary<Type, NodeParser> _parsers;

        static Converter()
        {
            _parsers = new Dictionary<Type, NodeParser>();

            ShaderLexicon.LoadeEmbeddedLexicon("SharpShader.Lexicon.hlsl.xml");
            ShaderLexicon.LoadeEmbeddedLexicon("SharpShader.Lexicon.glsl.xml");

            Type pType = typeof(NodeParser);
            Assembly assembly = pType.Assembly;
            IEnumerable<Type> types = assembly.GetTypes().Where(t => t.IsSubclassOf(pType) && !t.IsAbstract);
            foreach (Type t in types)
            {
                NodeParser parser = Activator.CreateInstance(t) as NodeParser;
                _parsers.Add(parser.ParsedType, parser);
            }
        }

        public string Convert(string cSharpSource, ShaderLanguage output)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            ShaderLexicon lex = ShaderLexicon.GetLexicon(output);
            ConversionContext context = new ConversionContext(lex);
            context.RegenerateTree(cSharpSource);

            int iterations = 1;
            while(ParseNodes(context, context.Root, 0))
            {
                Console.WriteLine($"Completed iteration {iterations}");
                iterations++;
            }

            string result = context.Root.ToString();
            timer.Stop();
            Console.WriteLine($"Finished in {timer.Elapsed.TotalMilliseconds:N2} milliseconds");
            return result;
        }

        private bool ParseNodes(ConversionContext context, SyntaxNode node, int depth)
        {
            IEnumerable<SyntaxNode> stuff = node.ChildNodes();
            foreach (SyntaxNode child in stuff)
            {
                Type t = child.GetType();

                if (_parsers.TryGetValue(t, out NodeParser parser))
                {
                    SyntaxTree tree = context.Tree;
                    parser.Parse(context, child);
                    if (tree != context.Tree || ParseNodes(context, child, depth + 1))
                        return true;                    
                }
                else
                {
                    if (ParseNodes(context, child, depth + 1))
                        return true;
                }
            }

            return false;
        }
    }
}
