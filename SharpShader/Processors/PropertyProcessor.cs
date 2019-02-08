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
        protected override void OnTranslate(ShaderTranslationContext sc, PropertyDeclarationSyntax syntax, ScopeInfo scope)
        {
            ScopeInfo classScope = scope.FindOfType(ScopeType.Class);
            ScopeInfo pScope = sc.Source.OpenScope(ScopeType.Property);
            pScope.Identifier = syntax.Identifier.ValueText;

            sc.Complete(syntax.Type);

            pScope.TypeInfo = ShaderType.TranslateType(sc, syntax.Type.ToString());
        }
    }

    internal class AccessorProcessor : NodeProcessor<AccessorDeclarationSyntax>
    {
        protected override void OnTranslate(ShaderTranslationContext sc, AccessorDeclarationSyntax syntax, ScopeInfo scope)
        {
            if(scope.Type == ScopeType.Property)
            {
                switch (syntax.Keyword.ValueText)
                {
                    case "get":
                        sc.Source.Append($"{scope.TypeInfo.Translation} get{scope.Identifier}()");
                        break;

                    case "set":
                        sc.Source.Append($"void set{scope.Identifier}({scope.TypeInfo.Translation} value)");
                        break;
                }

                ScopeInfo mScope = sc.Source.OpenScope(ScopeType.Method);
                ScopeInfo classScope = scope.FindOfType(ScopeType.Class);
                mScope.Method = classScope.TypeInfo.OriginalType.GetMethod($"{syntax.Keyword.ValueText}_{scope.Identifier}");
            }
        }
    }
}
