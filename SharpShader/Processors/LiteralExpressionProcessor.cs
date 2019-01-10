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
        protected override void OnPreprocess(ShaderContext context, LiteralExpressionSyntax syntax)
        {
            string initValue = syntax.ToString();
            if (char.IsNumber(initValue[0]))
            {
                string translated = context.Parent.Language.TranslateNumber(context, initValue);
                context.ReplaceSource(initValue, translated, syntax.SpanStart, syntax.Span.Length);
            }
        }
    }
}
