using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class VariableProcessor : NodeProcessor<VariableDeclarationSyntax>
    {
        internal override NodeProcessStageFlags Stages => NodeProcessStageFlags.PreProcess | NodeProcessStageFlags.Mapping | NodeProcessStageFlags.PostProcess;

        protected override void OnPreprocess(ShaderContext context, VariableDeclarationSyntax syntax, StringBuilder source)
        {
            // Separate the declaration into individual single-variable declarations.
            string strAttributes = "";
            AttributeSyntax regAttribute = null;
            uint? nextRegister = 0;
            string strRegAttName = nameof(RegisterAttribute).Replace("Attribute", "");

            (string translatedType, Type originalType) = GetTypeTranslation(context, syntax.Type);

            if (syntax.Parent is FieldDeclarationSyntax fieldSyntax)
            {
                foreach (AttributeListSyntax attList in fieldSyntax.AttributeLists)
                    strAttributes += attList.ToString() + Environment.NewLine;

                // TODO clean this up. Attributes should have their own parsers for situations like this.
                // Handle register increments.
                regAttribute = ShaderReflection.GetAttribute<RegisterAttribute>(fieldSyntax.AttributeLists);
                if (regAttribute != null)
                {
                    nextRegister = RegisterAttribute.Parse(regAttribute);
                    nextRegister++;
                }
            }

            string replacement = "";
            foreach (VariableDeclaratorSyntax vds in syntax.Variables)
            {
                // The first set of attributes already exist, so don't add them again.
                if (replacement.Length > 0)
                {
                    if (regAttribute != null)
                        replacement += strAttributes.Replace(regAttribute.ToString(), $"{strRegAttName}({nextRegister++})");
                    else
                        replacement += strAttributes;
                }

                replacement += $"{translatedType} {vds};{Environment.NewLine}";
            }

            if (syntax.Variables.Count == 1)
            {
                if (replacement.EndsWith(Environment.NewLine))
                    replacement = replacement.Substring(0, replacement.Length - Environment.NewLine.Length);
            }

            if (syntax.Parent is LocalDeclarationStatementSyntax parentDeclaration)
                source.Replace(parentDeclaration.ToString(), replacement, parentDeclaration.SpanStart, parentDeclaration.Span.Length);
            else
                source.Replace(syntax.ToString(), replacement, syntax.SpanStart, syntax.Span.Length);
        }

        protected override void OnMap(ShaderContext context, VariableDeclarationSyntax syntax)
        {
            context.Map.AddComponent(syntax, ShaderComponentType.Variable);
        }

        protected override void OnTranslate(ShaderContext context, VariableDeclarationSyntax syntax, StringBuilder source, ShaderElement element)
        {
            if (syntax.Type is ArrayTypeSyntax arraySyntax && syntax.Variables.Count > 0)
            {
                string strElementType = arraySyntax.ElementType.ToString();
                string strArrayDeclaration = context.Parent.Foundation.TranslateArrayDeclaration(context, strElementType, syntax.Variables[0]);
                string replacement = strArrayDeclaration;

                source.Replace(syntax.ToString(), replacement, syntax.SpanStart, syntax.Span.Length);
            }
        }
    }
}
