using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Processors
{
    internal class VariableProcessor : NodeProcessor<VariableDeclarationSyntax>
    {
        protected override bool OnTranslate(ShaderContext sc, VariableDeclarationSyntax syntax, ScopeInfo scope)
        {
            return false;
        }
    }

    internal class VariableDeclaratorProcessor : NodeProcessor<VariableDeclaratorSyntax>
    {
        protected override bool OnTranslate(ShaderContext sc, VariableDeclaratorSyntax syntax, ScopeInfo scope)
        {
            VariableDeclarationSyntax parent = syntax.Parent as VariableDeclarationSyntax;

            // TODO translate type
            // TODO scope modifiers in ScopeInfo (e.g. field modifiers/attributes for child variables, etc).


            sc.Source.Append($" {syntax.Identifier}");
            return false;
        }
    }
}
