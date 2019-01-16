using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Processors
{
    internal class AssignmentPRocessor : NodeProcessor<AssignmentExpressionSyntax>
    {
        protected override void OnTranslate(ShaderContext sc, AssignmentExpressionSyntax syntax, ScopeInfo scope)
        {
            // TODO check if the assignment uses a valid operator. Does the language support operand assignments (e.g *= += or /=)
            TranslationRunner.Translate(sc, syntax.Left);
            sc.Source.Append($" {syntax.OperatorToken} ");
            TranslationRunner.Translate(sc, syntax.Right);
        }
    }
}
