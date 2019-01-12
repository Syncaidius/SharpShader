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
        protected override bool OnTranslate(ShaderContext sc, FieldDeclarationSyntax syntax, ScopeInfo scope)
        {
            // TODO store field attributes in scope. Variable declarators will need them.
            sc.Source.OpenScope<FieldScope>();
            return true;
        }
    }
}
