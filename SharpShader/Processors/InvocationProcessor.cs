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
        internal override NodeProcessStageFlags Stages => NodeProcessStageFlags.PreProcess | NodeProcessStageFlags.Mapping;

        protected override void OnPreprocess(ConversionContext context, InvocationExpressionSyntax syntax, StringBuilder source)
        {
            string strName = syntax.Expression.ToString();
            string invocName = char.ToLowerInvariant(strName[0]) + strName.Substring(1);  
            if (context.Lexicon.IsIntrinsic(invocName))
                source.Replace(strName, invocName, syntax.Expression.SpanStart, syntax.Expression.Span.Length);
        }
    }
}
