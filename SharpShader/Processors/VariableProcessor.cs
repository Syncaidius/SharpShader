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
        internal override NodeProcessStageFlags Stages => NodeProcessStageFlags.PreProcess;

        protected override void OnPreprocess(ShaderContext context, VariableDeclarationSyntax syntax, StringBuilder source)
        {
            // Separate the declaration into individual single-variable declarations.
            if (syntax.Variables.Count > 1)
            {
                string strAttributes = "";
                AttributeSyntax regAttribute = null;
                uint? nextRegister = 0;
                string strRegAttName = nameof(RegisterAttribute).Replace("Attribute", "");

                if (syntax.Parent is FieldDeclarationSyntax fieldSyntax)
                {
                    foreach (AttributeListSyntax attList in fieldSyntax.AttributeLists)
                        strAttributes += attList.ToString() + Environment.NewLine;

                    regAttribute = ShaderReflection.GetAttribute<RegisterAttribute>(fieldSyntax.AttributeLists);
                    if (regAttribute != null)
                    {
                        RegisterAttribute.Parse(regAttribute, out nextRegister);
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

                    replacement += $"{syntax.Type} {vds};{Environment.NewLine}";
                }

                if(syntax.Parent is LocalDeclarationStatementSyntax parentDeclaration)
                    source.Replace(parentDeclaration.ToString(), replacement, parentDeclaration.SpanStart, parentDeclaration.Span.Length);
                else
                    source.Replace(syntax.ToString(), replacement, syntax.SpanStart, syntax.Span.Length);
            }
        }
    }

    
    internal class VariableDeclaratorProcessor : NodeProcessor<VariableDeclaratorSyntax>
    {
        internal override NodeProcessStageFlags Stages => NodeProcessStageFlags.PreProcess;

        protected override void OnPreprocess(ShaderContext context, VariableDeclaratorSyntax syntax, StringBuilder source)
        {
            if (syntax.Initializer != null)
            {
                string initValue = syntax.Initializer.Value.ToString();
                if (char.IsNumber(initValue[0]))
                {
                    string translated = context.Parent.Foundation.TranslateNumber(context, initValue);
                    source.Replace(initValue, translated, syntax.Initializer.SpanStart, syntax.Initializer.Span.Length);
                }
            }
        }
    }
}
