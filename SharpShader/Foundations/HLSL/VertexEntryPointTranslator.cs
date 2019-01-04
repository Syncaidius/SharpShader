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
        public string TranslateHeader(ShaderContext context, EntryPoint ep, MethodDeclarationSyntax syntax)
        {
            return $"{syntax.ReturnType} {syntax.Identifier}{syntax.ParameterList}";
        }
    }
}
