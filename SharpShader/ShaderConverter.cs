using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    public class ShaderConverter
    {
        public string Convert(string input, ShaderOutput output)
        {
            CSharpParseOptions parseOptions = new CSharpParseOptions(LanguageVersion.CSharp7_3, DocumentationMode.Parse, SourceCodeKind.Regular);
            SyntaxTree test = CSharpSyntaxTree.ParseText(input, parseOptions);
            SyntaxNode node = test.GetRoot();
            CompilationUnitSyntax comUnit = node as CompilationUnitSyntax;
            Iterate(node);
            return "";
        }

        private void Iterate(SyntaxNode node)
        {
            IEnumerable<SyntaxNode> stuff = node.ChildNodes();
            foreach (SyntaxNode child in stuff)
            {
                Type t = child.GetType();

                switch (child)
                {
                    case NamespaceDeclarationSyntax nsd:
                        Iterate(nsd);
                        break;

                    case ClassDeclarationSyntax cd:
                        Iterate(cd);
                        break;

                    case StructDeclarationSyntax strt:
                        break;
                }
            }
        }
    }
}
