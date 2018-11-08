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
    internal class StructNodeParser : NodePreprocessor<StructDeclarationSyntax>
    {
        internal override void Process(ConversionContext context, SyntaxNode node)
        {
            StructDeclarationSyntax structSyntax = node as StructDeclarationSyntax;

            // Remove field modifiers (i.e. public, protected, etc).
            if (structSyntax.Modifiers.Count > 0)
            {
                StructDeclarationSyntax temp = structSyntax;
                foreach (SyntaxToken token in structSyntax.Modifiers)
                    temp = temp.ReplaceToken(token, SyntaxFactory.Token(SyntaxKind.None));

                //fieldSyntax = temp;
                node = context.Root.ReplaceNode(structSyntax, temp);
                context.ReplaceTree(node.SyntaxTree);
            }
        }
    }
}
