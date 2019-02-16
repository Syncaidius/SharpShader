using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace SharpShader.Processors
{
    internal class ArrayRankProcessor : NodeProcessor<ArrayRankSpecifierSyntax>
    {
        protected override void OnTranslate(ShaderTranslationContext sc, ArrayRankSpecifierSyntax syntax, ScopeInfo scope)
        {
            sc.Source.OpenScope(ScopeType.Indexer);
        }
    }

    internal class OmittedArraySizeProcessor : NodeProcessor<OmittedArraySizeExpressionSyntax>
    {
        protected override void OnTranslate(ShaderTranslationContext sc, OmittedArraySizeExpressionSyntax syntax, ScopeInfo scope)
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