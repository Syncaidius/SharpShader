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
    internal class InvocationProcessor : NodeProcessor<InvocationExpressionSyntax>
    {
        protected override void OnPreprocess(ShaderContext context, InvocationExpressionSyntax syntax)
        {
            string cSharpName = syntax.Expression.ToString();
            string translation = ShaderReflection.GetIntrinsicTranslation(context, cSharpName);
            if (!string.IsNullOrEmpty(translation))
                context.ReplaceSource(syntax.Expression, translation);
        }
    }
}
