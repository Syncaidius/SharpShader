using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Processors
{
    internal class ArrayTypeProcessor : NodeProcessor<ArrayTypeSyntax>
    {
        protected override void OnTranslate(ShaderTranslationContext sc, ArrayTypeSyntax syntax, ScopeInfo scope)
        {
            sc.Complete(syntax.ElementType);
        }
    }
}
