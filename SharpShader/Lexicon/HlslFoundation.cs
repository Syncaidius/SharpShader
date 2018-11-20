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
            foreach(MemberDeclarationSyntax m in syntax.Members)
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
            result += "}" + Environment.NewLine;

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
            if(semanticAttribute != null)
            {
                if(semanticAttribute.ArgumentList.Arguments.Count > 0)
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
                                return $"{syntax.Declaration} : {strSemantic.ToUpper()}{slot}";
                            }
                            else
                            {
                                // TODO log incorrect semantic slot value.
                            }
                        }
                        else
                        {
                            return $"{syntax.Declaration} : {strSemantic.ToUpper()}";
                        }
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
    }
}
