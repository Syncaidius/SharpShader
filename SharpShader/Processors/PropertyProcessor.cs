using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Processors
{
    internal class PropertyProcessor : NodeProcessor<PropertyDeclarationSyntax>
    {
        protected override void OnTranslate(ShaderContext sc, PropertyDeclarationSyntax syntax, ScopeInfo scope)
        {
            ScopeInfo classScope = scope.FindOfType(ScopeType.Class);
            ScopeInfo pScope = sc.Source.OpenScope(ScopeType.Property);
            pScope.Identifier = syntax.Identifier.ValueText;

            sc.Complete(syntax.Type);

            (pScope.TranslatedTypeName, pScope.TypeInfo, _) = ReflectionHelper.TranslateType(sc, syntax.Type.ToString());
        }
    }

    internal class AccessorProcessor : NodeProcessor<AccessorDeclarationSyntax>
    {
        protected override void OnTranslate(ShaderContext sc, AccessorDeclarationSyntax syntax, ScopeInfo scope)
        {
            if(scope.Type == ScopeType.Property)
            {
                switch (syntax.Keyword.ValueText)
                {
                    case "get":
                        sc.Source.Append($"{scope.TranslatedTypeName} get{scope.Identifier}()");
                        break;

                    case "set":
                        sc.Source.Append($"void set{scope.Identifier}({scope.TranslatedTypeName} value)");
                        break;
                }

                ScopeInfo mScope = sc.Source.OpenScope(ScopeType.Method);
                ScopeInfo classScope = scope.FindOfType(ScopeType.Class);
                mScope.Method = classScope.TypeInfo.GetMethod($"{syntax.Keyword.ValueText}_{scope.Identifier}");
            }
        }
    }
}
