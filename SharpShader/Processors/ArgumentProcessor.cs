using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Processors
{
    internal class ArgumentProcessor : NodeProcessor<ArgumentSyntax>
    {
        protected override void OnTranslate(ShaderContext sc, ArgumentSyntax syntax, ScopeInfo scope)
        {
            sc.Source.OpenScope<ArgumentScope>();
        }
    }
}
