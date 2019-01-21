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
            if (syntax.Parent is InvocationExpressionSyntax invSyntax)
            {
                string translatedIntrinsic = ReflectionHelper.GetIntrinsicTranslation(sc, syntax.Identifier.ValueText);
                sc.Source.Append(translatedIntrinsic);
            }
            else
            {
                sc.Source.Append(syntax.Identifier);
            }
        }
    }
}
