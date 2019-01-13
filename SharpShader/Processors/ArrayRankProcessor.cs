using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Processors
{
    internal class ArrayRankProcessor : NodeProcessor<ArrayRankSpecifierSyntax>
    {
        protected override void OnTranslate(ShaderContext sc, ArrayRankSpecifierSyntax syntax, ScopeInfo scope)
        {
            sc.Source.OpenScope<IndexerScope>();
        }
    }

    internal class OmittedArraySizeProcessor : NodeProcessor<OmittedArraySizeExpressionSyntax>
    {
        protected override void OnTranslate(ShaderContext sc, OmittedArraySizeExpressionSyntax syntax, ScopeInfo scope)
        {
            ArrayCreationExpressionSyntax arrayCreationSyntax = syntax.FirstAncestorOrSelf<ArrayCreationExpressionSyntax>();
            if (arrayCreationSyntax != null)
            {
                if (arrayCreationSyntax.Initializer != null)
                {
                    IEnumerable<SyntaxNode> initChildren = arrayCreationSyntax.Initializer.ChildNodes();
                    int arraySize = initChildren.Count();
                    sc.Source.Append(arraySize.ToString());
                }
            }
        }
    }
}
