using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader.Foundations.HLSL
{
    internal class PixelEntryPointTranslator : IEntryPointTranslator
    {
        public string Translate(ShaderContext context, EntryPoint ep, ref string header)
        {
            SeparatedSyntaxList<AttributeArgumentSyntax> args = ep.AttributeSyntax.ArgumentList.Arguments;
            if (args.Count > 0)
            {
                string enumVal = args[0].ToString().Replace($"{nameof(SemanticFragmentOutputType)}.", "");

                if (Enum.TryParse(enumVal, out SemanticFragmentOutputType outputType))
                {
                    string result = $"{header.Replace(ep.MethodSyntax.AttributeLists.ToString(), "").Trim()} : {outputType.ToString().ToUpper()}{Environment.NewLine}";
                    // Second argument is always the semantic slot ID.
                    if (args.Count > 1)
                    {
                        string strSlot = args[1].ToString();
                        if (int.TryParse(strSlot, out int slot))
                            result += slot;
                        else
                            context.Parent.AddMessage($"Invalid FragmentShaderAttribute slot value. Expected value greater than, or equal to 0. Got: {strSlot}", 0, 0);
                    }

                    return result;
                }
                else
                {
                    context.Parent.AddMessage($"Invalid semantic name: {enumVal}", 0, 0);
                }
            }

            return header;
        }
    }
}
