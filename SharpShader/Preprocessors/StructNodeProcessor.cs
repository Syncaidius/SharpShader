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
        protected override void OnProcess(ConversionContext context, StructDeclarationSyntax node, StringBuilder source)
        {
            RemoveTokens(node.Modifiers, source);
        }
    }
}
