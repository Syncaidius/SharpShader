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
    internal class MethodProcessor : NodePreprocessor<MethodDeclarationSyntax>
    {
        protected override void OnProcess(ConversionContext context, MethodDeclarationSyntax syntax, StringBuilder source)
        {
            // Translate (if any) types of every parameter of the method.
            SeparatedSyntaxList<ParameterSyntax> paramList = syntax.ParameterList.Parameters;
            for (int i = paramList.Count - 1; i >= 0; i--)
                TranslateTypeSyntax(context, paramList[i].Type, source);

            //syntax.TypeParameterList
            // Update the type first, this comes after the modifiers.
            TranslateTypeSyntax(context, syntax.ReturnType, source);

            // Remove field modifiers (i.e. public, protected, etc).
            RemoveTokens(syntax.Modifiers, source);
        }
    }
}
