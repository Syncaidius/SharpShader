using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Processors
{
    internal class ObjectCreationProcessor : NodeProcessor<ObjectCreationExpressionSyntax>
    {
        protected override void OnTranslate(ShaderContext sc, ObjectCreationExpressionSyntax syntax, ScopeInfo scope)
        {
            if (scope is InitializerScope iScope)
            {
                if (syntax != iScope.Items.Last())
                    sc.Source.OpenScope<InitializerMemberScope>();
            }

            string typeName = syntax.Type.ToString();
            (string translatedName, Type originalType, bool isArray) = TranslationHelper.TranslateType(sc, typeName);

            sc.Complete(syntax.Type);
            sc.Source.Append(translatedName);
        }
    }
}
