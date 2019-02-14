using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Processors
{
    internal class IdentifierProcessor : NodeProcessor<IdentifierNameSyntax>
    {
        protected override void OnTranslate(ShaderTranslationContext sc, IdentifierNameSyntax syntax, ScopeInfo scope)
        {
            if (syntax.Parent is InvocationExpressionSyntax invSyntax)
            {
                string translatedIntrinsic = ShaderType.GetIntrinsicTranslation(sc, syntax.Identifier.ValueText);
                sc.Source.Append(translatedIntrinsic);
            }
            else
            {
                ScopeInfo cScope = scope.FindOfType(ScopeType.Class);
                PropertyInfo pInfo = cScope?.TypeInfo.OriginalType.GetProperty(syntax.Identifier.ValueText);
                if (pInfo != null)
                {
                    if (syntax.Parent is AssignmentExpressionSyntax aSyntax)
                    {
                        if (aSyntax.Left == syntax)
                            TranslatePropertyAssignment(sc, syntax, aSyntax);
                    }
                    else if (syntax.Parent is MemberAccessExpressionSyntax mSyntax && 
                        mSyntax.Parent is AssignmentExpressionSyntax maSyntax &&
                        maSyntax.Left == mSyntax)
                    {
                        TranslatePropertyAssignment(sc, syntax, maSyntax);
                    }
                    else // Safe to assume it's a property get call.
                    {
                        sc.Source.Append($"get{syntax.Identifier}()");
                    }
                }
                else
                {
                    sc.Source.Append(syntax.Identifier);
                }
            }
        }

        private void TranslatePropertyAssignment(ShaderTranslationContext sc, IdentifierNameSyntax id, AssignmentExpressionSyntax aSyntax)
        {
            sc.Source.Append($"set{id.Identifier.ValueText}(");
            sc.Runner.Translate(sc, aSyntax.Right);
            sc.Source.Append(")");
        }
    }
}
