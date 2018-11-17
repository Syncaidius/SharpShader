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
        internal override NodeProcessStageFlags Stages => NodeProcessStageFlags.Mapping;

        protected override void OnMap(ConversionContext context, VariableDeclarationSyntax syntax)
        {
            if (syntax.Parent == context.Root)
                context.Map.AddVariable(syntax);
        }
    }
}
