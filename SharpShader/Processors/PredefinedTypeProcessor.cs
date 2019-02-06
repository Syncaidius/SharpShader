using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Processors
{
    internal class PredefinedTypeProcessor : NodeProcessor<PredefinedTypeSyntax>
    {
        protected override void OnTranslate(ShaderTranslationContext sc, PredefinedTypeSyntax syntax, ScopeInfo scope)
        {
            string typeName = syntax.Keyword.ToString();
            (string translation, Type originalType, bool isArray) = ReflectionHelper.TranslateType(sc, typeName);
            sc.Source.Append(translation);
        }
    }
}
