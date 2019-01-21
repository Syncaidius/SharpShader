using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Processors
{
    internal class ClassProcessor : NodeProcessor<ClassDeclarationSyntax>
    {
        protected override void OnTranslate(ShaderContext sc, ClassDeclarationSyntax syntax, ScopeInfo scope)
        {            
            if (syntax.Identifier.ValueText != sc.Name)
            {
                // TODO does the shader language support classes?
                //      If not, we need a system to translate the class into another form of usable output source.
                Type t = sc.Parent.Reflection.Assembly.GetType($"{scope.Namespace}+{syntax.Identifier.ValueText}");
                ScopeInfo cScope = sc.Source.OpenScope(ScopeType.Class, t);
            }
            else
            {
                sc.Complete(syntax.BaseList);
            }
        }
    }
}
