using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Languages.HLSL.Translators
{
    internal class VertexTranslator : IEntryPointTranslator
    {
        public void TranslateParameterPostfix(ShaderContext sc, ParameterSyntax syntax, EntryPoint ep, ParameterInfo pInfo, IEnumerable<Attribute> attributes, int parameterIndex) { }

        public void TranslateParameterPrefix(ShaderContext sc, ParameterSyntax syntax, EntryPoint ep, ParameterInfo pInfo, IEnumerable<Attribute> attributes, int parameterIndex) { }

        public void TranslatePostfix(ShaderContext sc, MethodInfo info, MethodDeclarationSyntax syntax, EntryPoint ep)
        {
            VertexShaderAttribute attVertex = ep.Attribute as VertexShaderAttribute;

            if (attVertex.OutputSemantic != SemanticType.None)
            {
                sc.Source.Append($" : {attVertex.OutputSemantic.ToString().ToUpper()}");
                if (attVertex.SemanticSlot > -1)
                    sc.Source.Append(attVertex.SemanticSlot.ToString());
            }
        }

        public void TranslatePrefix(ShaderContext sc, MethodInfo info, MethodDeclarationSyntax syntax, EntryPoint ep) { }
    }
}
