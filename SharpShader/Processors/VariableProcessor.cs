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

        protected override void OnPreprocess(ConversionContext context, VariableDeclarationSyntax syntax, StringBuilder source)
        {
            if (syntax.Variables.Count > 1)
            {
                string replacement = "";
                foreach (VariableDeclaratorSyntax vds in syntax.Variables)
                    replacement += $"{syntax.Type} {vds};{Environment.NewLine}";

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

        protected override void OnPreprocess(ConversionContext context, VariableDeclaratorSyntax syntax, StringBuilder source)
        {
            if (syntax.Initializer != null)
            {
                string initValue = syntax.Initializer.Value.ToString();
                if (char.IsNumber(initValue[0]))
                {
                    string translated = context.Lexicon.Foundation.TranslateNumber(context, initValue);
                    source.Replace(initValue, translated, syntax.Initializer.SpanStart, syntax.Initializer.Span.Length);
                }
            }
        }
    }
}
