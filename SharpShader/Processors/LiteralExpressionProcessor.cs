using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Processors
{
    internal class LiteralExpressionProcessor : NodeProcessor<LiteralExpressionSyntax>
    {
        protected override void OnTranslate(ShaderContext context, LiteralExpressionSyntax syntax, ScopeInfo scope)
        {
            context.Source.Append(syntax.Token);
        }
    }
}
