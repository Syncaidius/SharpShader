using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Processors
{
    internal class FieldProcessor : NodeProcessor<FieldDeclarationSyntax>
    {
        protected override void OnTranslate(ShaderContext sc, FieldDeclarationSyntax syntax, ScopeInfo scope)
        {
            // Attribute info is retrieved via reflection, so we can completely skip processing of attribute syntax.
            sc.CompleteSelfAndChildren(syntax.AttributeLists);
        }
    }
}
