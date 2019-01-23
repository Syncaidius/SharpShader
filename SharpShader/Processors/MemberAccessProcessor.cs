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
    internal class MemberAccessProcessor : NodeProcessor<MemberAccessExpressionSyntax>
    {
        protected override void OnTranslate(ShaderContext sc, MemberAccessExpressionSyntax syntax, ScopeInfo scope)
        {
            switch (syntax.Expression)
            {
                case IdentifierNameSyntax idSyntax:
                    Type targetType = ReflectionHelper.ResolveType(idSyntax.Identifier.ValueText);
                    if (targetType != null && targetType.IsClass && targetType.IsAbstract && targetType.IsSealed) // Static classes are abstract and sealed at IL level.
                    {
                        FieldInfo fInfo = targetType.GetField(syntax.Name.Identifier.ValueText);
                        if (fInfo != null && (fInfo.Attributes & FieldAttributes.Literal) == FieldAttributes.Literal)
                        {
                            object val = fInfo.GetValue(null);
                            if (val != null)
                            {
                                sc.Source.Append(val.ToString());
                                sc.CompleteChildren(syntax);
                                return;
                            }
                        }
                    }
                    break;

                case ThisExpressionSyntax thisSyntax:
                case BaseExpressionSyntax baseSyntax:
                    ScopeInfo pScope = scope.FindOfType(ScopeType.Class);
                    if (pScope.TypeInfo == sc.ShaderType)
                    {
                        sc.Complete(syntax.Expression);

                        // Are we translating a shader intrinsic method/function?
                        if(syntax.Name is IdentifierNameSyntax idSyntax && syntax.Parent is InvocationExpressionSyntax)
                        {
                            string translatedIntrinsic = ReflectionHelper.GetIntrinsicTranslation(sc, idSyntax.Identifier.ValueText);
                            sc.Source.Append(translatedIntrinsic);
                            sc.Complete(syntax.Name);
                        }
                        return;
                    }
                    break;
            }

            TranslationRunner.Translate(sc, syntax.Expression);
            sc.Source.Append(syntax.OperatorToken);
            TranslationRunner.Translate(sc, syntax.Name);
        }
    }
}
