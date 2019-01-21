using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Processors
{
    internal class ReturnProcessor : NodeProcessor<ReturnStatementSyntax>
    {
        protected override void OnTranslate(ShaderContext sc, ReturnStatementSyntax syntax, ScopeInfo scope)
        {
            sc.Source.Append("return ");
            sc.Source.OpenScope(ScopeType.Variable);
        }
    }
}
