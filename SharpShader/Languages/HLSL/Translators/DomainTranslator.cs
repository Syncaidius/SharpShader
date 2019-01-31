using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Languages.HLSL.Translators
{
    internal class DomainTranslator : DefaultEntryPointTranslator
    {
        public override void TranslatePrefix(ShaderContext sc, MethodInfo info, MethodDeclarationSyntax syntax, EntryPoint ep)
        {
            DomainShaderAttribute attHull = ep.Attribute as DomainShaderAttribute;
            string patchType = attHull.PatchType.ToString().ToLower();
            sc.Source.Append($"[domain(\"{patchType}\")]");
            sc.Source.AppendLineBreak();

            base.TranslatePrefix(sc, info, syntax, ep);
        }
    }
}
