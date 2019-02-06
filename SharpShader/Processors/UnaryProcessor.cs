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
        protected override void OnTranslate(ShaderTranslationContext sc, PrefixUnaryExpressionSyntax syntax, ScopeInfo scope)
        {
            sc.Source.Append(syntax.OperatorToken);
            TranslationRunner.Translate(sc, syntax.Operand);
        }
    }

    internal class UnaryPostfixProcessor : NodeProcessor<PostfixUnaryExpressionSyntax>
    {
        protected override void OnTranslate(ShaderTranslationContext sc, PostfixUnaryExpressionSyntax syntax, ScopeInfo scope)
        {
            TranslationRunner.Translate(sc, syntax.Operand);
            sc.Source.Append(syntax.OperatorToken);
        }
    }
}
