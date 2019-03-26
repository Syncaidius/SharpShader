using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SharpShader.Languages;

namespace SharpShader.Processors
{
    internal class ParameterListProcessor : NodeProcessor<ParameterListSyntax>
    {
        protected override void OnTranslate(ShaderTranslationContext sc, ParameterListSyntax syntax, ScopeInfo scope)
        {
            ScopeInfo pScope = sc.Source.OpenScope(ScopeType.Parentheses);
            pScope.Items = syntax.Parameters; 
        }
    }

    internal class ParameterProcessor : NodeProcessor<ParameterSyntax>
    {
        protected override void OnTranslate(ShaderTranslationContext sc, ParameterSyntax syntax, ScopeInfo scope)
        {
            ScopeInfo methodScope = scope.FindOfType(ScopeType.Method);
            MethodInfo methodInfo = null;
            MappedEntryPoint ep = null;

            if (scope.Type == ScopeType.Parentheses)
            {
                if (scope.Items.Last() != syntax)
                    sc.Source.OpenScope(ScopeType.ParenthesesItem);
            }

            if (methodScope != null)
            {
                methodInfo = methodScope.Method;
                sc.EntryPointsByMethod.TryGetValue(methodInfo, out ep);
            }

            // TODO pass to language variable translation, since parameters can have attributes
            ShaderType type = ShaderType.TranslateType(sc, syntax.Type.ToString());
            bool wasAppended = false;

            if (ep != null)
            {
                (ParameterInfo pInfo, int pIndex) = sc.GetParameterInfo(methodInfo, syntax.Identifier.ValueText);
                IEnumerable<Attribute> pAttributes = pInfo.GetCustomAttributes();

                ep.Translator?.TranslateParameterPrefix(sc, syntax, ep, pInfo, pAttributes, pIndex);
                sc.Source.Append($"{type.Translation} {syntax.Identifier.ValueText}");
                ep.Translator?.TranslateParameterPostfix(sc, syntax, ep, pInfo, pAttributes, pIndex);
                wasAppended = true;
            }

            if (!wasAppended)
                sc.Source.Append($"{type.Translation} {syntax.Identifier.ValueText}");

            sc.Complete(syntax.Type);
            sc.Complete(syntax.AttributeLists);
        }
    }
}
