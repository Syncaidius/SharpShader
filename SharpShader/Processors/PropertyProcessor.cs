using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpShader
{
    internal class PropertyProcessor : NodeProcessor<PropertyDeclarationSyntax>
    {
        protected override void OnPreprocess(ShaderContext context, PropertyDeclarationSyntax syntax)
        {
            string identifier = syntax.Identifier.ToString();
            string replacement = TranslationHelper.TranslateProperty(
                context,
                syntax,
                syntax.ExpressionBody,
                identifier);

            context.ReplaceSource(syntax, replacement);
        }
    }
}
