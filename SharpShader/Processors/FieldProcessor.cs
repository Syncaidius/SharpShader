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
    internal class FieldProcessor : NodeProcessor<FieldDeclarationSyntax>
    {
        internal override NodeProcessStageFlags Stages => NodeProcessStageFlags.PreProcess;

        protected override void OnpPreprocess(ConversionContext context, FieldDeclarationSyntax syntax, StringBuilder source)
        {
            // Update the type first, this comes after the modifiers.
            TranslateTypeSyntax(context, syntax.Declaration.Type, source);

            // Remove field modifiers (i.e. public, protected, etc).
            RemoveTokens(syntax.Modifiers, source);
        }

        protected override void OnMap(ConversionContext context, FieldDeclarationSyntax syntax)
        {
            if (syntax.Parent == context.Root)
                context.Map.AddField(syntax.Declaration);
        }
    }
}
