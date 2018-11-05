using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
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
            Type pType = typeof(NodeParser);
            Assembly assembly = pType.Assembly;
            IEnumerable<Type> types = assembly.GetTypes().Where(t => t.IsSubclassOf(pType) && !t.IsAbstract);
            foreach(Type t in types)
            {
                NodeParser parser = Activator.CreateInstance(t) as NodeParser;
                _parsers.Add(parser.ParsedType, parser);
            }
        }

        public string Convert(string input, ShaderOutput output)
        {
            ConversionContext context = new ConversionContext();
            CSharpParseOptions parseOptions = new CSharpParseOptions(LanguageVersion.CSharp7_3, DocumentationMode.Parse, SourceCodeKind.Regular);

            SyntaxTree tree = CSharpSyntaxTree.ParseText(input, parseOptions);
            SyntaxNode node = tree.GetRoot();

            //CompilationUnitSyntax comUnit = node as CompilationUnitSyntax;
            ParseNodes(context, node, 0);

            string result = null;
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);

            result = BitConverter.ToString(stream.ToArray(), 0);

            writer.Close();
            stream.Dispose();
            return result;
        }

        private void ParseNodes(ConversionContext context, SyntaxNode node, int depth)
        {
            IEnumerable<SyntaxNode> stuff = node.ChildNodes();
            foreach (SyntaxNode child in stuff)
            {
                Type t = child.GetType();

                if (_parsers.TryGetValue(t, out NodeParser parser))
                    parser.Parse(context, child);
                else
                    ParseNodes(context, child, depth + 1);
            }
        }
    }
}
