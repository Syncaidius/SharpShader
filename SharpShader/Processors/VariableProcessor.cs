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
    internal class VariableProcessor : NodeProcessor<VariableDeclarationSyntax>
    {
        protected override void OnTranslate(ShaderContext sc, VariableDeclarationSyntax syntax, ScopeInfo scope)
        {
            string typeName = syntax.Type.ToString();
            (string translatedName, Type originalType, bool isArray) = ReflectionHelper.TranslateType(sc, typeName);

            ScopeInfo tScope = sc.Source.OpenScope(ScopeType.Typed, false, originalType);
            tScope.TranslatedTypeName = translatedName;
            tScope.IsLocal = syntax.Parent is LocalDeclarationStatementSyntax;

            if (syntax.Parent is FieldDeclarationSyntax fieldSyntax)
                tScope.TranslatedModifiers = sc.Language.TranslateModifiers(fieldSyntax.Modifiers);

            sc.Complete(syntax.Type);
        }
    }

    internal class VariableDeclaratorProcessor : NodeProcessor<VariableDeclaratorSyntax>
    {
        protected override void OnTranslate(ShaderContext sc, VariableDeclaratorSyntax syntax, ScopeInfo scope)
        {
            if (scope.Type == ScopeType.Typed)
            {
                FieldInfo fInfo = null;
                if (scope.Parent.Type == ScopeType.Struct)
                    fInfo = scope.Parent.TypeInfo.GetField(syntax.Identifier.ValueText);

                if (fInfo == null)
                    sc.AllFields.TryGetValue(syntax.Identifier.ValueText, out fInfo);

                if(fInfo != null)
                { 
                    IEnumerable<Attribute> fieldAttributes = fInfo.GetCustomAttributes();
                    sc.Language.TranslateFieldPrefix(sc, syntax, fInfo, fieldAttributes);
                    sc.Source.Append($"{scope.TranslatedModifiers} ");
                    sc.Source.Append(scope.TranslatedTypeName);
                    sc.Source.Append($" {syntax.Identifier.ValueText}");
                    sc.Language.TranslateFieldPostfix(sc, syntax, fInfo, fieldAttributes);
                }
                else
                {
                    sc.Source.Append($"{scope.TranslatedModifiers} ");
                    sc.Source.Append(scope.TranslatedTypeName);
                    sc.Source.Append($" {syntax.Identifier.ValueText}");
                }

                if (scope.TypeInfo != null)
                {
                    if (scope.TypeInfo.IsArray)
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

                // TODO do we need to use a different scope if inside an initializer? (i.e. InitializerMemberScope).
                if(scope.IsLocal)
                    sc.Source.OpenScope(ScopeType.LocalVariable);
                else
                    sc.Source.OpenScope(ScopeType.Variable);
            }
        }
    }
}
