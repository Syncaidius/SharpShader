using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpShader
{
    internal class NamespaceNodeParser : NodePreprocessor<NamespaceDeclarationSyntax>
    {
        protected override void OnProcess(ConversionContext context, NamespaceDeclarationSyntax syntax, StringBuilder source)
        {
            IEnumerable<SyntaxNodeOrToken> children = syntax.ChildNodesAndTokens();
            string childSource = "";
            bool first = true;
            SyntaxNodeOrToken last = children.Last();

            foreach (SyntaxNodeOrToken n in children)
            {
                if (n == syntax.Name || n == syntax.NamespaceKeyword || n == syntax.CloseBraceToken || n == syntax.OpenBraceToken)
                    continue;

                childSource += $"{n.ToString()}{Environment.NewLine}";

                if (n != last)
                    childSource += Environment.NewLine;
            }

            source.Replace(syntax.ToString(), childSource, syntax.SpanStart, syntax.Span.Length);
        }
    }
}
