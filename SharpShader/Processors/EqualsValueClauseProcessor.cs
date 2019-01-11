using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Processors
{
    internal class EqualsValueClauseProcessor : NodeProcessor<EqualsValueClauseSyntax>
    {
        protected override bool OnTranslate(ShaderContext context, EqualsValueClauseSyntax syntax)
        {
            
            context.Source.Append($" {syntax.EqualsToken} ");
            return false;
        }
    }
}
