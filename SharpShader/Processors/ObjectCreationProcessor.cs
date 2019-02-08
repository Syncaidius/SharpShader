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
        protected override void OnTranslate(ShaderTranslationContext sc, ObjectCreationExpressionSyntax syntax, ScopeInfo scope)
        {
            // Are we directly inside an initializer? (i.e. array initializer)
            if (scope.Type == ScopeType.ArrayInitializer)
            {
                if (syntax != scope.Items.Last())
                    sc.Source.OpenScope(ScopeType.ArrayElement);
            }

            string typeName = syntax.Type.ToString();
            ShaderType type = ShaderType.TranslateType(sc, typeName);

            sc.Complete(syntax.Type);

            // Handle initializers. These require declaring as a local variable above the current syntax node.
            if (syntax.Initializer != null)
            {
                switch (syntax.Parent)
                {
                    case ReturnStatementSyntax returnSyntax:
                    case AssignmentExpressionSyntax assignSyntax:
                        string strInit = type.Translation;
                        string varName = sc.Parent.GetNewVariableName("oc_init");

                        scope.DeclareLocal(sc, () =>
                        {
                            sc.Source.Append($"{type.Translation} {varName} = {type.Translation}");
                            TranslationRunner.Translate(sc, syntax.ArgumentList);
                            sc.Source.Append(";");
                            sc.Source.AppendLineBreak();

                            ScopeInfo iScope = sc.Source.OpenScope(ScopeType.ExpandedInitializer);
                            iScope.Identifier = varName;

                            TranslationRunner.Translate(sc, syntax.Initializer);
                        });

                        sc.Source.Append(varName);
                        break;

                    default:
                        sc.Source.Append(type.Translation);
                        break;
                }
            }
            else
            {
                sc.Source.Append(type.Translation);
            }
        }
    }
}
