using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class UsingNodeParser : NodeParser<UsingDirectiveSyntax>
    {
        internal override void Parse(ConversionContext context, SyntaxNode node)
        {
            // Remove using statement from code by taking the node's children and adding them to the parent
            RemoveNode(context, node);
        }
    }
}
