using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Processors
{
    internal class BlockProcessor : NodeProcessor<BlockSyntax>
    {
        protected override void OnTranslate(ShaderTranslationContext sc, BlockSyntax syntax, ScopeInfo scope)
        {
            if (syntax.Parent is UnsafeStatementSyntax || scope == sc.Source.RootScope)
                return;

            bool declarative = scope.Parent.Type == ScopeType.Method;
            sc.Source.OpenScope(ScopeType.Block);
        }
    }
}
