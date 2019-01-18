using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Processors
{
    internal class ArgumentListProcessor : NodeProcessor<ArgumentListSyntax>
    {
        protected override void OnTranslate(ShaderContext sc, ArgumentListSyntax syntax, ScopeInfo scope)
        {
            ScopeInfo pScope = sc.Source.OpenScope(ScopeType.Parentheses);
            pScope.Items = syntax.Arguments;
        }
    }

    internal class BracketedArgumentListProcessor : NodeProcessor<BracketedArgumentListSyntax>
    {
        protected override void OnTranslate(ShaderContext sc, BracketedArgumentListSyntax syntax, ScopeInfo scope)
        {
            sc.Source.OpenScope(ScopeType.Indexer);
        }
    }

    internal class ArgumentProcessor : NodeProcessor<ArgumentSyntax>
    {
        protected override void OnTranslate(ShaderContext sc, ArgumentSyntax syntax, ScopeInfo scope)
        {
            if(scope.Type == ScopeType.Parentheses)
            {
                if (scope.Items.Last() != syntax)
                    sc.Source.OpenScope(ScopeType.ParenthesesItem);
            }
        }
    }
}
