using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Processors
{
    internal class IdentifierProcessor : NodeProcessor<IdentifierNameSyntax>
    {
        protected override void OnTranslate(ShaderContext sc, IdentifierNameSyntax syntax, ScopeInfo scope)
        {
            if (scope is ArgumentScope)
                sc.Source.Append(syntax.Identifier);
        }
    }
}
