using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Processors
{
    internal class ArrayCreationProcessor : NodeProcessor<ArrayCreationExpressionSyntax>
    {
        protected override void OnTranslate(ShaderContext sc, ArrayCreationExpressionSyntax syntax, ScopeInfo scope)
        {
            sc.Source.OpenScope<ArrayBlockScope>();
        }
    }
}
