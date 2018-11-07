using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class ConversionContext
    {
        //List<string> _lines = new List<string>();

        internal SyntaxNode Root { get; private set; }
        internal SyntaxTree Tree { get; private set; }
        internal CodeMap Map { get; private set; }
        internal ShaderLexicon Lexicon { get; }

        internal ConversionContext(ShaderLexicon lexicon)
        {
            Lexicon = lexicon;
        }

        internal void RegenerateTree(string source)
        {
            CSharpParseOptions parseOptions = new CSharpParseOptions(LanguageVersion.CSharp7_3, DocumentationMode.Parse, SourceCodeKind.Regular);
            Tree = CSharpSyntaxTree.ParseText(source, parseOptions);
            Root = Tree.GetRoot();
            Map = new CodeMap();
        }

        internal void ReplaceTree(SyntaxTree tree)
        {
            Tree = tree;
            Root = tree.GetRoot();
            Map = new CodeMap();
        }



        internal string GetResult()
        {
            return Tree.ToString();
        }
    }
}
