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
        protected override void OnTranslate(ShaderContext context, MemberAccessExpressionSyntax syntax)
        {
            if (context.MainFields.TryGetValue(syntax.Expression.ToString(), out FieldDeclarationSyntax fieldSyntax))
            {
                if (!context.Parent.Foundation.InstancedConstantBuffers)
                {
                    if (context.ConstantBuffers.ContainsKey(fieldSyntax.Declaration.Type.ToString()))
                        context.RemoveSource(syntax.Expression.SpanStart, syntax.Expression.Span.Length + syntax.OperatorToken.Span.Length);
                }
            }
        }
    }
}
