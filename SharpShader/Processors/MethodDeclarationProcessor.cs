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
    internal class MethodDeclarationProcessor : NodeProcessor<MethodDeclarationSyntax>
    {
        protected override void OnTranslate(ShaderContext sc, MethodDeclarationSyntax syntax, ScopeInfo scope)
        {
            MethodInfo info = sc.GetMethodInfo(syntax);
            if (info != null)
            {
                sc.Source.AppendLineBreak();
                (string returnType, Type originalType, bool isArray) = TranslationHelper.TranslateType(sc, syntax.ReturnType.ToString());
                sc.Source.Append($"{returnType} {syntax.Identifier.ValueText}");

                sc.Complete(syntax.ReturnType);
                sc.Complete(syntax.ConstraintClauses);

                if(syntax.TypeParameterList != null)
                    sc.CompleteSelfAndChildren(syntax.TypeParameterList);

                TranslationRunner.Translate(sc, syntax.ParameterList, 0); // Translate parameters before method body.
                MethodScope mScope = sc.Source.OpenScope<MethodScope>();
                mScope.Info = info;
            }
        }
    }
}
