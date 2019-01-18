using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Processors
{
    internal class ParenthesizedExpressionProcessor : NodeProcessor<ParenthesizedExpressionSyntax>
    {
        protected override void OnTranslate(ShaderContext sc, ParenthesizedExpressionSyntax syntax, ScopeInfo scope)
        {
            ScopeInfo pScope = sc.Source.OpenScope(ScopeType.Parentheses);
        }
    }
}
