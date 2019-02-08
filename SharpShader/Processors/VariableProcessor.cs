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
                ConstantBufferMap cBufferMap = null;
                if (scope.Parent.Type == ScopeType.Struct)
                {
                    fInfo = scope.Parent.TypeInfo.OriginalType.GetField(syntax.Identifier.ValueText);
                    sc.ConstantBuffers.TryGetValue(scope.Parent.TypeInfo.OriginalType.Name, out cBufferMap);
                }

                if (fInfo == null)
                    sc.AllFields.TryGetValue(syntax.Identifier.ValueText, out fInfo);

                if(fInfo != null)
                { 
                    int fieldIndex = scope.Items.IndexOf(syntax);

                    MappedField mField = new MappedField()
                    {
                        Type = scope.TypeInfo,
                        Attributes = fInfo.GetCustomAttributes(),
                        Info = fInfo,
                    };

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
                    if (scope.TypeInfo.OriginalType.IsArray)
                    {
                        switch (syntax.Initializer.Value)
                        {
                            case InitializerExpressionSyntax initSyntax:
                                IEnumerable<SyntaxNode> initChildren = initSyntax.ChildNodes();
                                int arraySize = initChildren.Count();
                                sc.Source.Append($"[{arraySize}]");

                                // TODO multi-dimensional array support (e.g. [4][2]).
                                break;

                            case ArrayCreationExpressionSyntax arraySyntax:
                                TranslationRunner.Translate(sc, arraySyntax.Type);
                                break;
                        }
                    }
                }

                bool isForInitializer = (syntax.Parent is VariableDeclarationSyntax varDecSyntax && varDecSyntax.Parent is ForStatementSyntax forSyntax);
                if(!isForInitializer)
                    sc.Source.OpenScope(ScopeType.Variable);
            }
        }
    }
}
