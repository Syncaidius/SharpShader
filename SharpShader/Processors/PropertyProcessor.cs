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
        internal override NodeProcessStageFlags Stages => NodeProcessStageFlags.PreProcess;

        protected override void OnPreprocess(ShaderContext context, PropertyDeclarationSyntax syntax, StringBuilder source)
        {
            string identifier = syntax.Identifier.ToString();
            string uid = context.Parent.GetNewVariableName(identifier);
            PropertyTranslation translation = new PropertyTranslation()
            {
                GetterMethod = $"get{uid}",
                SetterMethod = $"set{uid}",
            };

            (translation.TypeName, translation.OriginalType) = GetTypeTranslation(context, syntax.Type);
            context.Map.Properties.Add(identifier, translation);

            string replacement = "";
            if (syntax.ExpressionBody != null)
            {
                replacement = TranslateArrowGetter(syntax.ExpressionBody, translation);
            }
            else
            {
                foreach (AccessorDeclarationSyntax accessor in syntax.AccessorList.Accessors)
                {
                    if (accessor.Keyword.ValueText == "get")
                    {
                        if (accessor.ExpressionBody != null)
                            replacement = TranslateArrowGetter(accessor.ExpressionBody, translation);
                    }
                }
            }

            if(replacement.Length > 0)
                source.Replace(syntax.ToString(), replacement, syntax.SpanStart, syntax.Span.Length);
        }

        private string TranslateArrowGetter(ArrowExpressionClauseSyntax arrowSyntax, PropertyTranslation translation)
        {
            string getterTranslation = $"{translation.TypeName} {translation.GetterMethod}(){Environment.NewLine}";
            getterTranslation += "{" + Environment.NewLine;
            getterTranslation += $"return {arrowSyntax.Expression.ToString()};{Environment.NewLine}";
            getterTranslation += "}";

            return getterTranslation;
        }
    }
}
