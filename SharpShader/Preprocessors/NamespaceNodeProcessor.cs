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
            IEnumerable<SyntaxNode> children = syntax.ChildNodes();
            string childSource = "";
            foreach (SyntaxNode n in children)
            {
                if (n == syntax.Name)
                    continue;

                childSource += n.ToString();
            }

            source.Replace(syntax.ToString(), childSource, syntax.SpanStart, syntax.Span.Length);
        }
    }
}
