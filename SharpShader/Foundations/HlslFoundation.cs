using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class HlslFoundation : LanguageFoundation
    {
        internal override bool InstancedConstantBuffers => false;

        internal HlslFoundation(ShaderLanguage language) : base(language) { }

        internal override string TranslateConstantBuffer(ShaderContext context, StructDeclarationSyntax syntax, int slot)
        {
            string strRegister = slot > -1 ? $" : register(b{slot}" : "";
            string result = $"cbuffer {syntax.Identifier}{strRegister}){Environment.NewLine}";
            result += "{" + Environment.NewLine;
            foreach (MemberDeclarationSyntax m in syntax.Members)
            {
                if (m is FieldDeclarationSyntax field)
                    result += $"{TranslateStructField(context, field)};{Environment.NewLine}";
            }
            result += "}" + Environment.NewLine;
            return result;
        }

        internal override string TranslateStruct(ShaderContext context, StructDeclarationSyntax syntax)
        {
            string result = $"struct {syntax.Identifier}{Environment.NewLine}";
            result += "{" + Environment.NewLine;
            foreach (MemberDeclarationSyntax m in syntax.Members)
            {
                if (m is FieldDeclarationSyntax field)
                    result += $"{TranslateStructField(context, field)};{Environment.NewLine}";
            }
            result += "};" + Environment.NewLine;

            return result;
        }

        internal override string TranslateStructField(ShaderContext context, FieldDeclarationSyntax syntax)
        {
            AttributeSyntax packAttribute = ShaderReflection.GetAttribute<PackOffsetAttribute>(syntax.AttributeLists);
            if (packAttribute != null)
            {
                if (packAttribute.ArgumentList.Arguments.Count > 0)
                {
                    int register = -1;

                    // Pack offset attribute has either 1 or 2 arguments. Second argument is optional
                    AttributeArgumentSyntax argRegister = packAttribute.ArgumentList.Arguments[0];
                    if (int.TryParse(argRegister.ToString(), out register))
                    {
                        if (packAttribute.ArgumentList.Arguments.Count == 2)
                        {
                            AttributeArgumentSyntax argComponent = packAttribute.ArgumentList.Arguments[1];
                            string comName = argComponent.ToString();
                            if (Enum.TryParse(comName, out PackOffsetComponent component))
                                return $"{syntax.Declaration} : packoffset(c{register}.{component.ToString().ToLower()})";
                            else
                                context.AddMessage($"Incorrect pack offset component name: {comName}", 0, 0);
                        }

                        return $"{syntax.Declaration} : packoffset(c{register})";
                    }
                }
                else
                {
                    context.AddMessage($"Incorrect PackOffsetAttribute arguments. 1 or more expected arguments are missing.", 0, 0);
                }
            }

            AttributeSyntax semanticAttribute = ShaderReflection.GetAttribute<SemanticAttribute>(syntax.AttributeLists);
            if (semanticAttribute != null)
            {
                if (semanticAttribute.ArgumentList.Arguments.Count > 0)
                {
                    int slot = -1;
                    SemanticType type = SemanticType.Position;
                    AttributeArgumentSyntax argSemantic = semanticAttribute.ArgumentList.Arguments[0];
                    string strSemantic = argSemantic.ToString().Replace($"{typeof(SemanticType).Name}.", "");

                    if (Enum.TryParse(strSemantic, out type))
                    {
                        if (semanticAttribute.ArgumentList.Arguments.Count > 1)
                        {
                            AttributeArgumentSyntax argSlot = semanticAttribute.ArgumentList.Arguments[1];
                            string strArgSlot = argSlot.ToString();
                            if (int.TryParse(strArgSlot, out slot))
                            {
                                if (slot > -1)
                                    return $"{syntax.Declaration} : {strSemantic.ToUpper()}{slot}";
                                else
                                    context.AddMessage($"Invalid SemanticAttribute slot value. Must be greater than, or equal to 0", 0, 0);
                            }
                            else
                            {
                                context.AddMessage($"Invalid SemanticAttribute slot value. Expected value greater than, or equal to 0. Got: {strArgSlot}", 0, 0);
                            }
                        }

                        return $"{syntax.Declaration} : {strSemantic.ToUpper()}";
                    }
                    else
                    {
                        context.AddMessage($"Invalid semantic name: {strSemantic}", 0, 0);
                    }
                }
                else
                {
                    context.AddMessage($"Unexpected number of SemanticAttribute arguments ({semanticAttribute.ArgumentList.Arguments.Count}). Expected at least 1.", 0, 0);
                }
            }

            return $"{syntax.Declaration}";
        }

        internal override string TranslateEntryPointHeader(ShaderContext context, EntryPoint ep, ref string header)
        {
            if (ep.EntryType == EntryPointType.VertexShader)
            {
                return header.Replace(ep.MethodSyntax.AttributeLists.ToString(), "");
            }
            else if (ep.EntryType == EntryPointType.FragmentShader)
            {
                // Attribute is a FragmentShaderAttribute. First argument is always the output semantic, if present.
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
            }

            // TODO parse geometry, hull, domain and compute shader attributes into shader-specific versions.
            return header;
        }

        internal override string TranslateNumber(ShaderContext context, string number)
        {
            // NOTE: hexadecimal literals are supported, binary literals are not, so we'll need to translate those.
            if (number.StartsWith("0b")) // Binary literal.
            {
                return TranslateBinaryLiteral(number);
            }
            else // Hexadecimal + everything else.
            {
                int newLength = number.Length;
                for(int i = number.Length - 1; i >= 0; i++)
                {
                    if (!char.IsNumber(number[i]))
                    {
                        newLength = i;
                        break;
                    }
                }
                return number.Substring(0, newLength);
            }
        }
    }
}
