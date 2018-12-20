using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader.Foundations.HLSL
{
    internal class VertexEntryPointTranslator : IEntryPointTranslator
    {
        public string Translate(ShaderContext context, EntryPoint ep, ref string header)
        {
            return header.Replace(ep.MethodSyntax.AttributeLists.ToString(), "");
        }
    }
}
