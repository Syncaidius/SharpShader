using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Processors
{
    internal class ParameterListProcessor : NodeProcessor<ParameterListSyntax>
    {
        protected override void OnTranslate(ShaderContext sc, ParameterListSyntax syntax, ScopeInfo scope)
        {
            ParenthesesScope<ParameterSyntax> pScope = sc.Source.OpenScope<ParenthesesScope<ParameterSyntax>>();
            pScope.Items = syntax.Parameters; 
        }
    }

    internal class ParameterProcessor : NodeProcessor<ParameterSyntax>
    {
        protected override void OnTranslate(ShaderContext sc, ParameterSyntax syntax, ScopeInfo scope)
        {
            if (scope is ParenthesesScope<ParameterSyntax> pScope)
            {
                if (pScope.Items.Last() != syntax)
                    sc.Source.OpenScope<ParenthesesItemScope>();
            }

            // TODO pass to language variable translation, since parameters can have attributes
            (string typeName, Type originalType, bool isArray) = TranslationHelper.TranslateType(sc, syntax.Type.ToString());
            sc.Source.Append($"{typeName} {syntax.Identifier.ValueText}");
            sc.Complete(syntax.Type);
        }
    }
}
