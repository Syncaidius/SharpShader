using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Languages.HLSL.Translators
{
    internal class ComputeTranslator : DefaultEntryPointTranslator
    {
        public override void TranslatePrefix(ShaderContext sc, MethodInfo info, MethodDeclarationSyntax syntax, EntryPoint ep)
        {
            ComputeShaderAttribute attCompute = ep.Attribute as ComputeShaderAttribute;
            sc.Source.Append($"[numthreads({attCompute.ThreadsX}, {attCompute.ThreadsY}, {attCompute.ThreadsZ})]");
            sc.Source.AppendLineBreak();

            base.TranslatePrefix(sc, info, syntax, ep);
        }
    }
}
