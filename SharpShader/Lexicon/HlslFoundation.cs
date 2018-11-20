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
            string result = $"cbuffer {syntax.Identifier} : register(b{slot}){Environment.NewLine}";
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
            throw new NotImplementedException();
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
                            string comVal = argComponent.ToString();

                            if (Enum.TryParse(comVal, out PackOffsetComponent component))
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


            return $"{syntax.Declaration}";
        }
    }
}
