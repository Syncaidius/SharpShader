using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Processors
{
    internal class IfStatementProcessor : NodeProcessor<IfStatementSyntax>
    {
        protected override void OnTranslate(ShaderContext sc, IfStatementSyntax syntax, ScopeInfo scope)
        {
            sc.Source.Append("if(");
            TranslationRunner.Translate(sc, syntax.Condition);
            sc.Source.Append(")");
            if (!(syntax.Statement is BlockSyntax))
                sc.Source.OpenScope(ScopeType.Block);
        }
    }

    internal class ElseStatementProcessor : NodeProcessor<ElseClauseSyntax>
    {
        protected override void OnTranslate(ShaderContext sc, ElseClauseSyntax syntax, ScopeInfo scope)
        {
            sc.Source.Append("else ");
            if (!(syntax.Statement is BlockSyntax || syntax.Statement is IfStatementSyntax))
                sc.Source.OpenScope(ScopeType.Block);
        }
    }

    /// <summary>
    /// A processor for inline if statements.
    /// </summary>
    internal class CondtionalProcessor : NodeProcessor<ConditionalExpressionSyntax>
    {
        protected override void OnTranslate(ShaderContext sc, ConditionalExpressionSyntax syntax, ScopeInfo scope)
        {
            TranslationRunner.Translate(sc, syntax.Condition);
            sc.Source.Append(" ? ");
            TranslationRunner.Translate(sc, syntax.WhenTrue);
            sc.Source.Append(" : ");
            TranslationRunner.Translate(sc, syntax.WhenFalse);
        }
    }
}
