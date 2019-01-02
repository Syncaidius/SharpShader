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
            context.Map.TranslatedProperties.Add(identifier, translation);

            string replacement = "";
            if (syntax.ExpressionBody != null) // Arrow getter property?
            {
                replacement += translation.TranslateArrowGetter(syntax.ExpressionBody);
            }
            else
            {
                foreach (AccessorDeclarationSyntax accessor in syntax.AccessorList.Accessors)
                {
                    if (accessor.Keyword.ValueText == "get")
                    {
                        if (accessor.ExpressionBody != null)
                        {
                            replacement += translation.TranslateArrowGetter(accessor.ExpressionBody);
                        }
                        else
                        {
                            replacement += translation.GetGetterHeader() + Environment.NewLine;
                            replacement += accessor.Body + Environment.NewLine;
                        }
                    }
                    else if (accessor.Keyword.ValueText == "set")
                    {
                        if (accessor.ExpressionBody != null)
                        {
                            replacement += translation.TranslateArrowSetter(accessor.ExpressionBody);
                        }
                        else
                        {
                            replacement += translation.GetSetterHeader() + Environment.NewLine;
                            replacement += accessor.Body + Environment.NewLine;
                        }
                    }
                }
            }

            if(replacement.Length > 0)
                source.Replace(syntax.ToString(), replacement, syntax.SpanStart, syntax.Span.Length);
        }
    }
}
