﻿using System;
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
        protected override void OnTranslate(ShaderTranslationContext sc, MethodDeclarationSyntax syntax, ScopeInfo scope)
        {
            MethodInfo info = sc.GetMethodInfo(syntax);
            if (info != null)
            {
                MappedEntryPoint ep = null;
                sc.EntryPointsByMethod.TryGetValue(info, out ep);

                sc.Source.AppendLineBreak();
                ScopeInfo mScope = sc.Source.OpenScope(ScopeType.Method, null, ep);
                mScope.Method = info;

                ShaderType returnType = ShaderType.TranslateType(sc, syntax.ReturnType.ToString());

                ep?.Translator?.TranslatePrefix(sc, info, syntax, ep);
                sc.Source.Append($"{returnType.Translation} {syntax.Identifier.ValueText}");

                sc.Complete(syntax.ReturnType);
                sc.Complete(syntax.ConstraintClauses);
                sc.Complete(syntax.AttributeLists);

                if (syntax.TypeParameterList != null)
                    sc.CompleteSelfAndChildren(syntax.TypeParameterList);

                // Translate parameters before method body.
                sc.Runner.Translate(sc, syntax.ParameterList, 0);
                ep?.Translator?.TranslatePostfix(sc, info, syntax, ep);
            }
        }
    }
}
