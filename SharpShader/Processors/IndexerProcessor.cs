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
        internal override NodeProcessStageFlags Stages => NodeProcessStageFlags.PreProcess;

        protected override void OnPreprocess(ShaderContext context, IndexerDeclarationSyntax syntax, StringBuilder source)
        {
            string identifier = syntax.ParameterList.ToString();
            string uid = context.Parent.GetNewVariableName(context.Name);
            PropertyTranslation translation = new PropertyTranslation()
            {
                GetterMethod = $"get{uid}",
                SetterMethod = $"set{uid}",
            };

            (translation.TypeName, translation.OriginalType) = GetTypeTranslation(context, syntax.Type);
            context.Map.TranslatedProperties.Add(identifier, translation);

            string replacement = "";
            SeparatedSyntaxList<ParameterSyntax> parameters = syntax.ParameterList.Parameters;

            if (syntax.ExpressionBody != null) // Arrow getter property?
            {
                replacement += translation.TranslateArrowGetter(syntax.ExpressionBody, parameters);
            }
            else
            {
                foreach (AccessorDeclarationSyntax accessor in syntax.AccessorList.Accessors)
                {
                    if (accessor.Keyword.ValueText == "get")
                    {
                        if (accessor.ExpressionBody != null)
                        {
                            replacement += translation.TranslateArrowGetter(accessor.ExpressionBody, parameters);
                        }
                        else
                        {
                            replacement += translation.GetGetterHeader(parameters) + Environment.NewLine;
                            replacement += accessor.Body + Environment.NewLine;
                        }
                    }
                    else if (accessor.Keyword.ValueText == "set")
                    {
                        if (accessor.ExpressionBody != null)
                        {
                            replacement += translation.TranslateArrowSetter(accessor.ExpressionBody, parameters);
                        }
                        else
                        {
                            replacement += translation.GetSetterHeader(parameters) + Environment.NewLine;
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
