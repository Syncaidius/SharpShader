using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader.Processors
{
    internal class LiteralExpressionProcessor : NodeProcessor<LiteralExpressionSyntax>
    {
        protected override void OnPreprocess(ShaderContext context, LiteralExpressionSyntax syntax, StringBuilder source)
        {
            string initValue = syntax.ToString();
            if (char.IsNumber(initValue[0]))
            {
                string translated = context.Parent.Foundation.TranslateNumber(context, initValue);
                source.Replace(initValue, translated, syntax.SpanStart, syntax.Span.Length);
            }
        }
    }
}
