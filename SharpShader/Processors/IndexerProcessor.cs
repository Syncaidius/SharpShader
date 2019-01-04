using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpShader
{
    internal class IndexerProcessor : NodeProcessor<IndexerDeclarationSyntax>
    {
        protected override void OnPreprocess(ShaderContext context, IndexerDeclarationSyntax syntax)
        {
            string replacement = TranslationHelper.TranslateProperty(context,
                syntax,
                syntax.ExpressionBody,
                null, syntax.ParameterList.Parameters);

            context.ReplaceSource(syntax, replacement);
        }
    }
}
