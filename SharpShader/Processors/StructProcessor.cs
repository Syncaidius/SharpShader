using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Processors
{
    internal class structProcessor : NodeProcessor<StructDeclarationSyntax>
    {
        protected override void OnTranslate(ShaderContext sc, StructDeclarationSyntax syntax, ScopeInfo scope)
        {
            string typeName = syntax.Identifier.ToString();
            string headerTranslation = "";
            StructScopeType scopeType = StructScopeType.Struct;

            if (sc.ConstantBuffers.TryGetValue(typeName, out RegisteredMember<Type> cBufferInfo))
            {
                sc.Language.TranslateConstBufferHeader(sc, syntax, cBufferInfo);
                scopeType = StructScopeType.ConstantBuffer;
            }
            else if (sc.Structures.TryGetValue(typeName, out Type structInfo))
            {
                sc.Source.Append($"struct {syntax.Identifier}");
                scopeType = StructScopeType.Struct;
            }

            sc.Source.Append(headerTranslation);
            StructScope structScope = sc.Source.OpenScope<StructScope>();
            structScope.StructType = scopeType;
        }
    }
}
