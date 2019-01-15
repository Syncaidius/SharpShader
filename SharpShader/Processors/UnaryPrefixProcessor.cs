using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Processors
{
    internal class UnaryPrefixProcessor : NodeProcessor<PrefixUnaryExpressionSyntax>
    {
        protected override void OnTranslate(ShaderContext sc, PrefixUnaryExpressionSyntax syntax, ScopeInfo scope)
        {
            sc.Source.Append(syntax.OperatorToken);
        }
    }
}
