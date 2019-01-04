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
        protected override void OnPreprocess(ShaderContext context, VariableDeclarationSyntax syntax)
        {
            // Separate the declaration into individual single-variable declarations.
            string strAttributes = "";
            AttributeSyntax regAttribute = null;
            uint? nextRegister = 0;
            string strRegAttName = nameof(RegisterAttribute).Replace("Attribute", "");

            (string translatedType, Type originalType) = TranslationHelper.GetTypeTranslation(context, syntax.Type);

            string strModifiers = "";

            if (syntax.Parent is FieldDeclarationSyntax fieldSyntax)
            {
                strModifiers = $"{fieldSyntax.Modifiers} ";
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

                if (syntax.Variables.Count > 1)
                    replacement += $"{strModifiers}{translatedType} {vds};{Environment.NewLine}";
                else
                    replacement += $"{translatedType} {vds};{Environment.NewLine}";
            }

            if (syntax.Variables.Count == 1)
            {
                if (replacement.EndsWith(Environment.NewLine))
                    replacement = replacement.Substring(0, replacement.Length - Environment.NewLine.Length);
            }

            if (syntax.Parent is LocalDeclarationStatementSyntax parentDeclaration)
                context.ReplaceSource(parentDeclaration, replacement);
            else
                context.ReplaceSource(syntax, replacement);
        }

        protected override void OnTranslate(ShaderContext context, VariableDeclarationSyntax syntax)
        {
            if (syntax.Type is ArrayTypeSyntax arraySyntax && syntax.Variables.Count > 0)
            {
                string strElementType = arraySyntax.ElementType.ToString();
                string strArrayDeclaration = context.Parent.Foundation.TranslateArrayDeclaration(context, strElementType, syntax.Variables[0]);
                string replacement = strArrayDeclaration;

                context.ReplaceSource(syntax, replacement);
            }
        }
    }
}
