using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Processors
{
    internal class FieldProcessor : NodeProcessor<FieldDeclarationSyntax>
    {
        protected override void OnTranslate(ShaderContext sc, FieldDeclarationSyntax syntax, ScopeInfo scope)
        {
            // Does the language allow instanced constant buffers and does the field use a constant buffer struct type?
            if (sc.ConstantBuffers.ContainsKey(syntax.Declaration.Type.ToString()))
            {
                if (!sc.Language.InstancedConstantBuffers)
                    sc.CompleteSelfAndChildren(syntax);
            }
            else
            {
                sc.CompleteSelfAndChildren(syntax.AttributeLists);
            }
        }
    }
}
