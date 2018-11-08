using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class FieldProcessor : NodePreprocessor<FieldDeclarationSyntax>
    {
        internal override void Process(ConversionContext context, SyntaxNode node)
        {
            FieldDeclarationSyntax fieldSyntax = node as FieldDeclarationSyntax;
            VariableDeclarationSyntax declaration = fieldSyntax.Declaration;

            // Remove field modifiers (i.e. public, protected, etc).
            if (fieldSyntax.Modifiers.Count > 0)
            {
                FieldDeclarationSyntax temp = fieldSyntax;
                foreach(SyntaxToken token in fieldSyntax.Modifiers)
                    temp = temp.ReplaceToken(token, SyntaxFactory.Token(SyntaxKind.None));

                //fieldSyntax = temp;
                node = context.Root.ReplaceNode(fieldSyntax, temp);
                context.ReplaceTree(node.SyntaxTree);
                return;
            }

            // Translate type, if possible.
            TranslateType(context, node, declaration.Type);
        }
    }
}
