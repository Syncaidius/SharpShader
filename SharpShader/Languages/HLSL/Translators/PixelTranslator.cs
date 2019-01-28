using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Languages.HLSL.Translators
{
    internal class PixelTranslator : IEntryPointTranslator
    {
        public void TranslateParameterPostfix(ShaderContext sc, ParameterSyntax syntax, EntryPoint ep, ParameterInfo pInfo, IEnumerable<Attribute> attributes, int parameterIndex) { }

        public void TranslateParameterPrefix(ShaderContext sc, ParameterSyntax syntax, EntryPoint ep, ParameterInfo pInfo, IEnumerable<Attribute> attributes, int parameterIndex) { }

        public void TranslatePostfix(ShaderContext sc, MethodInfo info, MethodDeclarationSyntax syntax, EntryPoint ep)
        {
            FragmentShaderAttribute attFrag = ep.Attribute as FragmentShaderAttribute;

            if (attFrag.OutputSemantic != SemanticType.None)
            {
                sc.Source.Append($" : {attFrag.OutputSemantic.ToString().ToUpper()}");
                if (attFrag.SemanticSlot > -1)
                    sc.Source.Append(attFrag.SemanticSlot.ToString());
            }
        }

        public void TranslatePrefix(ShaderContext sc, MethodInfo info, MethodDeclarationSyntax syntax, EntryPoint ep) { }
    }
}
