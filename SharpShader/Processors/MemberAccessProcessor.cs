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
        protected override void OnTranslate(ShaderTranslationContext sc, MemberAccessExpressionSyntax syntax, ScopeInfo scope)
        {
            switch (syntax.Expression)
            {
                case IdentifierNameSyntax idSyntax:
                    // Is this a static class identifier? 
                    // Static classes are abstract and sealed at IL level.
                    Type targetType = ShaderType.Resolve(sc, idSyntax.Identifier.ValueText);
                    if (targetType != null && targetType.IsClass && targetType.IsAbstract && targetType.IsSealed) 
                    {
                        // Is the member a constant value? If so, we can take it's value directly.
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
                    else
                    {
                        ScopeInfo cScope = scope.FindOfType(ScopeType.Class);
                        if(cScope == sc.Source.RootScope)
                        {
                            FieldInfo fInfo = cScope.TypeInfo.OriginalType.GetField(idSyntax.Identifier.ValueText);
                            if(fInfo != null && sc.ConstantBuffers.Values.Any(x => x.TypeInfo == fInfo.FieldType))
                            {
                                if (!sc.Language.InstancedConstantBuffers)
                                {
                                    sc.CompleteSelfAndChildren(syntax.Expression);
                                    TranslationRunner.Translate(sc, syntax.Name);
                                    return;
                                }
                            }
                        }
                    }
                    break;

                case ThisExpressionSyntax thisSyntax:
                case BaseExpressionSyntax baseSyntax:
                    ScopeInfo pScope = scope.FindOfType(ScopeType.Class);
                    if (pScope.TypeInfo.OriginalType == sc.ShaderType)
                    {
                        sc.Complete(syntax.Expression);

                        // Are we translating a shader intrinsic method/function?
                        if(syntax.Name is IdentifierNameSyntax idSyntax && syntax.Parent is InvocationExpressionSyntax)
                        {
                            string translatedIntrinsic = ShaderType.GetIntrinsicTranslation(sc, idSyntax.Identifier.ValueText);
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
