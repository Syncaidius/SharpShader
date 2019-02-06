using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader.Processors
{
    internal class GenericWhereProcessor : NodeProcessor<TypeParameterConstraintClauseSyntax>
    {
        protected override void OnTranslate(ShaderTranslationContext sc, TypeParameterConstraintClauseSyntax syntax, ScopeInfo scope)
        {
            sc.CompleteSelfAndChildren(syntax);
        }
    }
}
