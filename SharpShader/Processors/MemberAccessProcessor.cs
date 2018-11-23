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
        internal override NodeProcessStageFlags Stages => NodeProcessStageFlags.Mapping | NodeProcessStageFlags.PostProcess;

        protected override void OnMap(ConversionContext context, MemberAccessExpressionSyntax syntax)
        {
            context.Map.AddMemberAccess(syntax);
        }

        protected override void OnPostprocess(ConversionContext context, MemberAccessExpressionSyntax syntax, StringBuilder source, ShaderComponent component)
        {
            if (context.Map.Fields.TryGetValue(syntax.Expression.ToString(), out FieldDeclarationSyntax fieldSyntax))
            {
                if (context.Map.ConstantBuffers.ContainsKey(fieldSyntax.Declaration.Type.ToString()))
                    source.Remove(syntax.Expression.SpanStart, syntax.Expression.Span.Length + syntax.OperatorToken.Span.Length);
            }
        }
    }
}
