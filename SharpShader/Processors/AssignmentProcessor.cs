using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Processors
{
    internal class AssignmentProcessor : NodeProcessor<AssignmentExpressionSyntax>
    {
        protected override void OnTranslate(ShaderContext sc, AssignmentExpressionSyntax syntax, ScopeInfo scope)
        {
            if(scope.Type == ScopeType.ExpandedInitializer)
            {
                sc.Source.Append($"{scope.Identifier}.");
                sc.Source.OpenScope(ScopeType.Variable);
            }

            // TODO check if the assignment uses a valid operator. Does the language support operand assignments (e.g *= += or /=)
            TranslationRunner.Translate(sc, syntax.Left);
            if (sc.IsCompleted(syntax.Right)) // Property translation may have replaced the assignment with a set-method call.
                return;

            sc.Source.Append($" {syntax.OperatorToken} ");
            TranslationRunner.Translate(sc, syntax.Right);
        }
    }
}
