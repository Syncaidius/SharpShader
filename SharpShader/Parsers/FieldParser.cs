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
    internal class FieldParser : NodeParser<FieldDeclarationSyntax>
    {
        internal override void Parse(ConversionContext context, SyntaxNode node)
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
            Type t = Type.GetType($"SharpShader.{declaration.Type}") ?? Type.GetType($"System.{declaration.Type}");
            if(t != null)
            {
                Type[] iTypes = t.GetInterfaces();
                foreach (Type implemented in iTypes)
                {
                    string translation = context.Lexicon.Translate(implemented);
                    if (translation != null)
                    {
                        //Translate(context, node, (ref string source, ref string nodeSource) =>
                        //{
                        //    return source.Replace(nodeSource, nodeSource);
                        //});
                    }
                }
            }
        }
    }
}
