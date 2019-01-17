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
            (string translatedName, Type originalType, bool isArray) = TranslationHelper.TranslateType(sc, typeName);

            TypedScope tScope = sc.Source.OpenScope<TypedScope>();
            tScope.OriginalType = originalType;
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
            if (scope is TypedScope tScope)
            {
                FieldInfo fInfo = null;
                if (tScope.Parent is StructScope sScope)
                    fInfo = sScope.TypeInfo.GetField(syntax.Identifier.ValueText);

                if (fInfo == null)
                    sc.AllFields.TryGetValue(syntax.Identifier.ValueText, out fInfo);

                if(fInfo != null)
                { 
                    IEnumerable<Attribute> fieldAttributes = fInfo.GetCustomAttributes();
                    sc.Language.TranslateFieldPrefix(sc, syntax, fInfo, fieldAttributes);
                    sc.Source.Append($"{tScope.TranslatedModifiers} ");
                    sc.Source.Append(tScope.TranslatedTypeName);
                    sc.Source.Append($" {syntax.Identifier.ValueText}");
                    sc.Language.TranslateFieldPostfix(sc, syntax, fInfo, fieldAttributes);
                }
                else
                {
                    sc.Source.Append($"{tScope.TranslatedModifiers} ");
                    sc.Source.Append(tScope.TranslatedTypeName);
                    sc.Source.Append($" {syntax.Identifier.ValueText}");
                }

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

                // TODO do we need to use a different scope if inside an initializer? (i.e. InitializerMemberScope).
                if(tScope.IsLocal)
                    sc.Source.OpenScope<LocalVariableScope>();
                else
                    sc.Source.OpenScope<VariableScope>();
            }
        }
    }
}
