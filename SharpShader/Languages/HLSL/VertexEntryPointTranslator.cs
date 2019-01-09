using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader.Foundations.HLSL
{
    internal class VertexEntryPointTranslator : IEntryPointTranslator
    {
        public string TranslateHeader(ShaderContext context, EntryPoint ep, MethodInformation info)
        {
            return $"{info.ReturnType} {info.Identifier}{info.GetParameterString()}";
        }
    }
}
