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
        protected override void OnTranslate(ShaderTranslationContext sc, VariableDeclarationSyntax syntax, ScopeInfo scope)
        {
            string typeName = syntax.Type.ToString();
            ShaderType type = ShaderType.TranslateType(sc, typeName);

            ScopeInfo tScope = sc.Source.OpenScope(ScopeType.Typed, type);
            tScope.TypeInfo = type;
            tScope.IsLocal = syntax.Parent is LocalDeclarationStatementSyntax;
            tScope.Items = syntax.Variables;

            if (syntax.Parent is FieldDeclarationSyntax fieldSyntax)
                tScope.TranslatedModifiers = sc.Language.TranslateModifiers(fieldSyntax.Modifiers);

            sc.Complete(syntax.Type);
        }
    }

    internal class VariableDeclaratorProcessor : NodeProcessor<VariableDeclaratorSyntax>
    {
        protected override void OnTranslate(ShaderTranslationContext sc, VariableDeclaratorSyntax syntax, ScopeInfo scope)
        {
            if (scope.Type == ScopeType.Typed)
            {
                FieldInfo fInfo = null;
                MappedField mField = null;
                MappedConstantBuffer cBufferMap = null;

                if (scope.Parent.Type == ScopeType.Struct)
                {
                    fInfo = scope.Parent.TypeInfo.OriginalType.GetField(syntax.Identifier.ValueText);
                    sc.ConstantBuffers.TryGetValue(scope.Parent.TypeInfo.OriginalType.Name, out cBufferMap);
                }

                if (fInfo == null)
                    sc.Fields.TryGetValue(syntax.Identifier.ValueText, out fInfo);

                
                if (fInfo != null)
                { 
                    int fieldIndex = scope.Items.IndexOf(syntax);
                    mField = Pooling.MappedFields.Get();
                    mField.Initialize(scope.TypeInfo, fInfo);
                    cBufferMap?.AddField(mField);

                    sc.Language.TranslateFieldPrefix(sc, syntax, mField, fieldIndex, cBufferMap);
                    sc.Source.Append($"{scope.TranslatedModifiers} ");
                    sc.Source.Append(scope.TypeInfo.Translation);
                    sc.Source.Append($" {syntax.Identifier.ValueText}");
                    sc.Language.TranslateFieldPostfix(sc, syntax, mField, fieldIndex, cBufferMap);
                }
                else
                {
                    sc.Source.Append($"{scope.TranslatedModifiers} ");
                    sc.Source.Append(scope.TypeInfo.Translation);
                    sc.Source.Append($" {syntax.Identifier.ValueText}");
                }

                // Handle corner-cases for array initializers.
                if (scope.TypeInfo != null && syntax.Initializer != null)
                {
                    if (scope.TypeInfo.WasArrayType)
                    {
                        switch (syntax.Initializer.Value)
                        {
                            case InitializerExpressionSyntax initSyntax:
                                IEnumerable<SyntaxNode> initChildren = initSyntax.ChildNodes();
                                int arraySize = initChildren.Count();
                                sc.Source.Append($"[{arraySize}]");

                                if(mField != null)
                                {
                                    mField.ArrayDimensions.Add(arraySize);
                                }

                                // TODO multi-dimensional array support (e.g. [4][2]).
                                //     - For multi-dimensional arrays, we can simply take the dimensions directly.
                                //     - For jagged arrays, we need to find the largest sub-array and use that as the size for it's respective dimension.
                                break;

                            case ArrayCreationExpressionSyntax arraySyntax:
                                sc.Runner.Translate(sc, arraySyntax.Type);
                                break;
                        }
                    }
                }

                bool isForInitializer = (syntax.Parent is VariableDeclarationSyntax varDecSyntax && varDecSyntax.Parent is ForStatementSyntax forSyntax);
                if (!isForInitializer)
                {
                    if (syntax.Initializer != null && syntax.Initializer.Value is ObjectCreationExpressionSyntax objSyntax && objSyntax.Initializer != null)
                    {
                        ScopeInfo si = sc.Source.OpenScope(ScopeType.ExpandedInitializer);
                        si.Identifier = syntax.Identifier.ValueText;
                        sc.Source.Append(" = ");

                        // Are we instantiating a new struct value with no args?
                        if (objSyntax.ArgumentList.Arguments.Count == 0 && scope.TypeInfo.OriginalType.IsValueType)
                        {
                            sc.Source.Append($"({scope.TypeInfo.Translation})0;"); // TODO does GLSL allow this? Do we abstract or add a language property to check against?
                            sc.Source.AppendLineBreak();
                            sc.Complete(objSyntax.ArgumentList);
                            sc.Complete(objSyntax.Type);
                        }
                        else
                        {
                            sc.Source.Append(scope.TypeInfo.Translation);
                            sc.Runner.Translate(sc, objSyntax.ArgumentList);
                            sc.Source.Append(";");
                            sc.Source.AppendLineBreak();
                            sc.Runner.Translate(sc, objSyntax.Initializer);
                            sc.Complete(objSyntax.ArgumentList);
                            sc.Complete(objSyntax.Type);
                        }

                        // We no longer need to translate the object creation syntax, but we still want it's initializer.
                        sc.Complete(syntax.Initializer);
                        sc.Runner.Translate(sc, objSyntax.Initializer);
                    }
                    else
                    {
                        ScopeInfo si = sc.Source.OpenScope(ScopeType.Variable);
                        si.Identifier = syntax.Identifier.ValueText;
                    }
                }
            }
        }
    }
}
