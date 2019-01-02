using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class MemberAccessProcessor : NodeProcessor<MemberAccessExpressionSyntax>
    {
        protected override void OnTranslate(ShaderContext context, MemberAccessExpressionSyntax syntax, StringBuilder source)
        {
            if (context.Map.MainFields.TryGetValue(syntax.Expression.ToString(), out FieldDeclarationSyntax fieldSyntax))
            {
                if (!context.Parent.Foundation.InstancedConstantBuffers)
                {
                    if (context.Map.ConstantBuffers.ContainsKey(fieldSyntax.Declaration.Type.ToString()))
                        source.Remove(syntax.Expression.SpanStart, syntax.Expression.Span.Length + syntax.OperatorToken.Span.Length);
                }
            }
        }
    }
}
