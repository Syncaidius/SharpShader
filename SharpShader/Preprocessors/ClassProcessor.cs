using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpShader
{
    internal class ClassProcessor : NodePreprocessor<ClassDeclarationSyntax>
    {
        protected override void OnProcess(ConversionContext context, ClassDeclarationSyntax syntax, StringBuilder source)
        {
            if(syntax.OpenBraceToken != null && syntax.CloseBraceToken != null)
            {
                int start = syntax.OpenBraceToken.SpanStart;
                int end = syntax.CloseBraceToken.Span.End;
                int len = end - start;
                start -= syntax.SpanStart;

                string memberString = syntax.ToString().Substring(start + 1, len - 2);
                source.Replace(syntax.ToString(), memberString, syntax.SpanStart, syntax.Span.Length);
            }
            else
            {
                // TODO implement
            }
        }
    }
}
