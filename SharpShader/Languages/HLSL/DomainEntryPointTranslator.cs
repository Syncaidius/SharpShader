using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader.Foundations.HLSL
{
    internal class DomainEntryPointTranslator : IEntryPointTranslator
    {
        public string TranslateHeader(ShaderContext context, EntryPoint ep, MethodInformation info)
        {
            AttributeArgumentSyntax argPatch = ep.AttributeSyntax.ArgumentList.Arguments[DomainShaderAttribute.ARG_ID_PATCH_TYPE];

            string result = null;
            if (ShaderReflection.ParseEnum(argPatch.ToString(), out PatchType pType))
            {
                string strParameters = "";
                foreach(KeyValuePair<string, MethodParameterInformation> p in info.Parameters)
                {
                    if (strParameters.Length > 0)
                        strParameters += ", ";

                    if (p.Value.Attributes.TryGetAttribute<OutputPatchAttribute>(out AttributeSyntax attSyntax))
                    {
                        uint? patchSize = OutputPatchAttribute.Parse(attSyntax);
                        if (patchSize != null)
                        {
                            TypeSyntax tSyntax = p.Value.Type;
                            if (tSyntax is ArrayTypeSyntax arraySyntax)
                                tSyntax = arraySyntax.ElementType;

                            strParameters += $"OutputPatch<{tSyntax}, {patchSize}> {p.Value.Identifier}";
                            continue;
                        }
                    }

                    strParameters += $"{p.Value.Type} {p.Value.Identifier}";
                }

                result = $"[domain(\"{ pType.ToString().ToLower()}\")]{Environment.NewLine}";
                result += $"{info.ReturnType} {info.Identifier}({strParameters})";
            }

            return result;
        }
    }
}
