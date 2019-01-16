using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Processors
{
    internal class ArrowExpressionProcessor : NodeProcessor<ArrowExpressionClauseSyntax>
    {
        protected override void OnTranslate(ShaderContext sc, ArrowExpressionClauseSyntax syntax, ScopeInfo scope)
        {
            if(scope is MethodScope mScope)
            {
                sc.Source.OpenScope<BlockScope>();
                if (mScope.Info.ReturnType != typeof(void))
                    sc.Source.Append("return ");

                sc.Source.OpenScope<VariableScope>();
            }
        }
    }
}
