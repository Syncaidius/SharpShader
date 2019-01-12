using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Processors
{
    internal class PredefinedTypeProcessor : NodeProcessor<PredefinedTypeSyntax>
    {
        protected override bool OnTranslate(ShaderContext context, PredefinedTypeSyntax syntax, ScopeInfo scope)
        {
            string typeName = syntax.Keyword.ToString();
            Type t = ShaderReflection.ResolveType(typeName);
            context.Source.Append(t?.Name ?? typeName);
            return false;
        }
    }
}
