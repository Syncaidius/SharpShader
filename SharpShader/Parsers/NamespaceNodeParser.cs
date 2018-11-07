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
    internal class NamespaceNodeParser : NodeParser<NamespaceDeclarationSyntax>
    {
        internal override void Parse(ConversionContext context, SyntaxNode node)
        {
            NamespaceDeclarationSyntax namespaceSyntax = node as NamespaceDeclarationSyntax;

            // Remove namespace block from code by taking the node's children and adding them to the parent
            ReplaceWithChildren(context, namespaceSyntax, namespaceSyntax.Name);
        }
    }
}
