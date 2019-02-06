using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Processors
{
    internal class ForLoopProcessor : NodeProcessor<ForStatementSyntax>
    {
        protected override void OnTranslate(ShaderTranslationContext sc, ForStatementSyntax syntax, ScopeInfo scope)
        {
            sc.Language.TranslateForLoopPrefix(sc, syntax);
            sc.Source.AppendLineBreak();
            sc.Source.Append("for(");

            if (syntax.Declaration != null)
                TranslationRunner.Translate(sc, syntax.Declaration);

            TranslateList(sc, syntax.Initializers);
            sc.Source.Append("; ");
            TranslationRunner.Translate(sc, syntax.Condition);
            sc.Source.Append("; ");
            TranslateList(sc, syntax.Incrementors);
            sc.Source.Append(")");
        }

        private void TranslateList<T>(ShaderTranslationContext sc, SeparatedSyntaxList<T> list) where T : SyntaxNode
        {
            T firstIncrementor = list.FirstOrDefault();
            foreach (T es in list)
            {
                Type test = es.GetType();
                if (es != firstIncrementor)
                    sc.Source.Append(", ");

                TranslationRunner.Translate(sc, es);
            }
        }
    }
}
