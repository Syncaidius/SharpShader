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
        internal override string TranslateConstantBuffer(ConversionContext context, StructDeclarationSyntax syntax, int slot)
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

        internal override string TranslateStruct(ConversionContext context, StructDeclarationSyntax syntax)
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

        internal override string TranslateStructField(ConversionContext context, FieldDeclarationSyntax syntax)
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

                            if (Enum.TryParse(argComponent.ToString(), out PackOffsetComponent component))
                            {
                                return $"{syntax.Declaration} : packoffset(c{register}.{component.ToString().ToLower()})";
                            }
                            else
                            {
                                // TODO log incorrect pack offset component name.
                            }
                        }

                        return $"{syntax.Declaration} : packoffset(c{register})";
                    }
                }
                else
                {
                    // TODO log output error here. PackOffsetAttribute does not take 0 arguments.
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
                            if (int.TryParse(argSlot.ToString(), out slot))
                            {
                                if (slot > -1)
                                    return $"{syntax.Declaration} : {strSemantic.ToUpper()}{slot}";

                                // TODO log invalid value if < 0.
                            }
                            else
                            {
                                // TODO log incorrect semantic slot value.
                            }
                        }

                        return $"{syntax.Declaration} : {strSemantic.ToUpper()}";
                    }
                    else
                    {
                        // TODO log incorrect semantic name.
                    }
                }
                else
                {
                    // TODO log output here here. SemanticAttribute always takes 2 arguments.
                }
            }

            return $"{syntax.Declaration}";
        }

        internal override string TranslateEntryPointHeader(ConversionContext context, EntryPoint ep, ref string header)
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
                            if (int.TryParse(args[1].ToString(), out int slot))
                                result += slot;

                            // TODO log invalid slot ID in 'else' clause.
                        }

                        return result;
                    }
                    else
                    {
                        // TODO log invalid output semantic value.
                    }
                }
            }

            // TODO parse geometry, hull, domain and compute shader attributes into shader-specific versions.
            return header;
        }

        internal override string TranslateNumber(ConversionContext context, string number)
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
