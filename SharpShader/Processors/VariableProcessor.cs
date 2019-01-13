using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Processors
{
    internal class VariableProcessor : NodeProcessor<VariableDeclarationSyntax>
    {
        protected override void OnTranslate(ShaderContext sc, VariableDeclarationSyntax syntax, ScopeInfo scope)
        {
            string typeName = syntax.Type.ToString();
            (string translatedName, Type originalType, bool isArray) = TranslationHelper.TranslateType(sc, typeName);

            TypedScope tScope = sc.Source.OpenScope<TypedScope>();
            tScope.OriginalType = originalType;
            tScope.TranslatedTypeName = translatedName;

            if (syntax.Parent is FieldDeclarationSyntax fieldSyntax)
                tScope.TranslatedModifiers = sc.Language.TranslateModifiers(fieldSyntax.Modifiers);

            sc.CompletedNodes.Add(syntax.Type);
        }
    }

    internal class VariableDeclaratorProcessor : NodeProcessor<VariableDeclaratorSyntax>
    {
        protected override void OnTranslate(ShaderContext sc, VariableDeclaratorSyntax syntax, ScopeInfo scope)
        {
            if (scope is TypedScope tScope)
            {
                sc.Source.Append($"{tScope.TranslatedModifiers} ");
                sc.Source.Append(tScope.TranslatedTypeName);
                sc.Source.Append($" {syntax.Identifier}");


                if (tScope.OriginalType != null)
                {
                    if (tScope.OriginalType.IsArray)
                    {
                        if (syntax.Initializer != null)
                        {
                            switch (syntax.Initializer.Value)
                            {
                                case InitializerExpressionSyntax initSyntax:
                                    IEnumerable<SyntaxNode> initChildren = initSyntax.ChildNodes();
                                    int arraySize = initChildren.Count();
                                    sc.Source.Append($"[{arraySize}]");
                                    break;

                                case ArrayCreationExpressionSyntax arraySyntax:
                                    TranslationRunner.Translate(sc, arraySyntax.Type);
                                    break;
                            }
                        }
                    }
                }

                // TODO scope modifiers in ScopeInfo (e.g. field modifiers/attributes for child variables, etc).
                sc.Source.OpenScope<VariableScope>();
            }
        }
    }
}
