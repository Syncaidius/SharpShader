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
            if (scope.Type == ScopeType.Initializer)
            {
                if (syntax != scope.Items.Last())
                    sc.Source.OpenScope(ScopeType.InitializerMember);
            }

            string typeName = syntax.Type.ToString();
            (string translatedName, Type originalType, bool isArray) = ReflectionHelper.TranslateType(sc, typeName);

            sc.Complete(syntax.Type);
            sc.Source.Append(translatedName);
        }
    }
}
