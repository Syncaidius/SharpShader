using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Processors
{
    internal class BinaryExpressionProcessor : NodeProcessor<BinaryExpressionSyntax>
    {
        protected override void OnTranslate(ShaderContext sc, BinaryExpressionSyntax syntax, ScopeInfo scope)
        {
            TranslationRunner.Translate(sc, syntax.Left);
            sc.Source.Append($" {syntax.OperatorToken} ");
            TranslationRunner.Translate(sc, syntax.Right);
        }
    }
}
