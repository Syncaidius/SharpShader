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
        static List<Translator> _translators;

        static Converter()
        {
            _parsers = new Dictionary<Type, NodeParser>();
            _translators = new List<Translator>();

            Type pType = typeof(NodeParser);
            Assembly assembly = pType.Assembly;
            IEnumerable<Type> types = assembly.GetTypes().Where(t => t.IsSubclassOf(pType) && !t.IsAbstract);
            foreach(Type t in types)
            {
                NodeParser parser = Activator.CreateInstance(t) as NodeParser;
                _parsers.Add(parser.ParsedType, parser);
            }

            // Add the translators in the order they need to happen.
            AddTranslator<StructTranslator>();
            AddTranslator<TypeTranslator>();
        }

        private static void AddTranslator<T>() where T : Translator, new()
        {
            _translators.Add(new T());
        }

        public string Convert(string input, ShaderOutput output)
        {
            ConversionContext context = new ConversionContext();
            CSharpParseOptions parseOptions = new CSharpParseOptions(LanguageVersion.CSharp7_3, DocumentationMode.Parse, SourceCodeKind.Regular);

            SyntaxTree tree = CSharpSyntaxTree.ParseText(input, parseOptions);
            SyntaxNode node = tree.GetRoot();

            //CompilationUnitSyntax comUnit = node as CompilationUnitSyntax;
            ParseNodes(context, node, 0);

            foreach (Translator translator in _translators)
                translator.Translate(context);

            string result = context.GetResult();
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
