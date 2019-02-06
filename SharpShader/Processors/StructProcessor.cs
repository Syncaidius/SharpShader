using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Processors
{
    internal class StructProcessor : NodeProcessor<StructDeclarationSyntax>
    {
        protected override void OnTranslate(ShaderTranslationContext sc, StructDeclarationSyntax syntax, ScopeInfo scope)
        {
            string typeName = syntax.Identifier.ToString();
            string headerTranslation = "";
            StructScopeType scopeType = StructScopeType.Struct;
            Type sType = null;

            if (sc.ConstantBuffers.TryGetValue(typeName, out ConstantBufferMap cMap))
            {
                sType = cMap.TypeInfo;
                IEnumerable<Attribute> cBufferAttributes = sType.GetCustomAttributes(false).Cast<Attribute>();
                sc.Language.TranslateConstBufferHeader(sc, syntax, sType, cBufferAttributes);
                scopeType = StructScopeType.ConstantBuffer;
            }
            else if (sc.Structures.TryGetValue(typeName, out sType))
            {
                //IEnumerable<Attribute> cBufferAttributes = structInfo.GetCustomAttributes(false).Cast<Attribute>();
                // TODO Add translation of struct attributes (e.g. [InputStructure] or [OutputStructure]).

                sc.Source.Append($"{Environment.NewLine}struct {syntax.Identifier}");
                scopeType = StructScopeType.Struct;
            }

            sc.Source.Append(headerTranslation);
            ScopeInfo structScope = sc.Source.OpenScope(ScopeType.Struct, sType);
            structScope.StructType = scopeType;

            sc.CompleteSelfAndChildren(syntax.AttributeLists);
        }
    }
}
