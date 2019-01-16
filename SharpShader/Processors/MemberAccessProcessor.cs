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
            // TODO check if we're accessing a constant value on a static class. If so, we can use reflection to retrieve the value and output it directly into the shader source.
            if(syntax.Expression is IdentifierNameSyntax idSyntax)
            {
                Type targetType = ShaderReflection.ResolveType(idSyntax.Identifier.ValueText);
                if (targetType != null && targetType.IsClass && targetType.IsAbstract && targetType.IsSealed) // Static classes are abstract and sealed at IL level.
                {
                    FieldInfo fInfo = targetType.GetField(syntax.Name.Identifier.ValueText);
                    if(fInfo != null && (fInfo.Attributes & FieldAttributes.Literal) == FieldAttributes.Literal)
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
            }

            TranslationRunner.Translate(sc, syntax.Expression);
            sc.Source.Append(syntax.OperatorToken);
            TranslationRunner.Translate(sc, syntax.Name);
        }
    }
}
