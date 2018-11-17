using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class VariableProcessor : NodeProcessor<VariableDeclarationSyntax>
    {
        internal override NodeProcessStageFlags Stages => NodeProcessStageFlags.Mapping | NodeProcessStageFlags.PreProcess;

        protected override void OnpPreprocess(ConversionContext context, VariableDeclarationSyntax syntax, StringBuilder source)
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

        protected override void OnMap(ConversionContext context, VariableDeclarationSyntax syntax)
        {
            if (syntax.Parent == context.Root)
                context.Map.AddVariable(syntax);
        }
    }
}
