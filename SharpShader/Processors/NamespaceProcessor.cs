using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpShader
{
    internal class NamespaceProcessor : NodeProcessor<NamespaceDeclarationSyntax>
    {
        internal override NodeProcessStageFlags Stages => NodeProcessStageFlags.PreProcess;

        protected override void OnPreprocess(ConversionContext context, NamespaceDeclarationSyntax syntax, StringBuilder source)
        {
            IEnumerable<SyntaxNodeOrToken> children = syntax.ChildNodesAndTokens();
            SyntaxNodeOrToken last = children.Last();
            string childSource = "";

            foreach (SyntaxNodeOrToken n in children)
            {
                if (n == syntax.Name || n == syntax.NamespaceKeyword)
                    continue;

                if (n == syntax.CloseBraceToken || n == syntax.OpenBraceToken)
                    continue;

                string leadingTrivia = ProcessTrivia(n.GetLeadingTrivia());
                leadingTrivia += !string.IsNullOrWhiteSpace(leadingTrivia) ? Environment.NewLine : "";

                string trailingTrivia = ProcessTrivia(n.GetTrailingTrivia());
                childSource += $"{leadingTrivia}{n.ToString()}{trailingTrivia}{Environment.NewLine}";

                if (n != last)
                    childSource += Environment.NewLine;
            }

            source.Replace(syntax.ToString(), childSource, syntax.SpanStart, syntax.Span.Length);
        }

        private static string ProcessTrivia(SyntaxTriviaList trivia)
        {
            string result = "";
            foreach(SyntaxTrivia t in trivia)
            {
                if (t.IsKind(SyntaxKind.SingleLineCommentTrivia) || t.IsKind(SyntaxKind.MultiLineCommentTrivia))
                    result += t.ToString();
            }

            return result;
        }
    }
}
