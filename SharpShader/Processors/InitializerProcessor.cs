using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Processors
{
    internal class InitializerProcessor : NodeProcessor<InitializerExpressionSyntax>
    {
        protected override void OnTranslate(ShaderContext sc, InitializerExpressionSyntax syntax, ScopeInfo scope)
        {
            if (syntax.Parent is ArrayCreationExpressionSyntax arrayCreationSyntax || syntax.Parent is EqualsValueClauseSyntax equalsAssignmentSyntax)
            {
                ScopeInfo iScope = sc.Source.OpenScope(ScopeType.Initializer);
                iScope.Items = syntax.Expressions;
            }
        }
    }
}
