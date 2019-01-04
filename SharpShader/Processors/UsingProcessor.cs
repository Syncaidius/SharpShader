using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class UsingProcessor : NodeProcessor<UsingDirectiveSyntax>
    {
        protected override void OnPreprocess(ShaderContext context, UsingDirectiveSyntax node)
        {
            context.RemoveSource(node);
        }
    }
}
