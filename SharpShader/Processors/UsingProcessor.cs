using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class UsingProcessor : NodeProcessor<UsingDirectiveSyntax>
    {
        internal override NodeProcessStageFlags Stages => NodeProcessStageFlags.PreProcess;

        protected override void OnpPreprocess(ConversionContext context, UsingDirectiveSyntax node, StringBuilder source)
        {
            RemoveSyntax(node, source);
        }
    }
}
