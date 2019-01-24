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

                ScopeInfo mScope = sc.Source.OpenScope(ScopeType.Method);
                mScope.Method = info;

                (string returnType, Type originalType, bool isArray) = ReflectionHelper.TranslateType(sc, syntax.ReturnType.ToString());

                EntryPoint ep = null;
                sc.EntryPoints.TryGetValue(info, out ep);

                if (ep != null)
                    sc.Language.TranslateEntryPointPrefix(sc, info, syntax, ep);

                sc.Source.Append($"{returnType} {syntax.Identifier.ValueText}");
                    

                sc.Complete(syntax.ReturnType);
                sc.Complete(syntax.ConstraintClauses);
                sc.Complete(syntax.AttributeLists);

                if(syntax.TypeParameterList != null)
                    sc.CompleteSelfAndChildren(syntax.TypeParameterList);

                // Translate parameters before method body.
                TranslationRunner.Translate(sc, syntax.ParameterList, 0);

                if(ep != null)
                    sc.Language.TranslateEntryPointPostfix(sc, info, syntax, ep);
            }
        }
    }
}
