using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SharpShader.Foundations.HLSL;
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

        internal HlslFoundation(ShaderLanguage language) : base(language)
        {
            AddEntryPointTranslator<VertexEntryPointTranslator>(EntryPointType.VertexShader);
            AddEntryPointTranslator<GeometryEntryPointTranslator>(EntryPointType.GeometryShader);
            AddEntryPointTranslator<PixelEntryPointTranslator>(EntryPointType.FragmentShader);
        }

        internal override string TranslateConstantBuffer(ShaderContext context, StructDeclarationSyntax syntax, uint? registerID)
        {
            string strRegister = registerID != null ? $" : register(b{registerID}" : "";
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

        internal override string TranslateRegisterField(ShaderContext context, FieldDeclarationSyntax syntax, Type fieldType, uint registerID)
        {
            char? registerChar = null;

            if (typeof(TextureSampler).IsAssignableFrom(fieldType))
                registerChar = 's';

            if (typeof(TextureBase).IsAssignableFrom(fieldType))
                registerChar = 't';

            if (registerChar != null)
                return $"{syntax.Declaration} : register({registerChar}{registerID});";
            else
                return syntax.ToString();
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

        internal override string TranslateNumber(ShaderContext context, string number)
        {
            // NOTE: hexadecimal literals are supported in HLSL, binary literals are not, so we'll need to translate those.
            if (number.StartsWith("0b")) // Binary literal.
            {
                return TranslateBinaryLiteral(number);
            }
            else // Hexadecimal + everything else.
            {
                int newLength = number.Length;
                for(int i = number.Length - 1; i >= 0; i--)
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

        internal override string TranslateArrayDeclaration(ShaderContext context, string typeName, VariableDeclaratorSyntax varSyntax)
        {
            int arraySize = 0;
            string strInitializer = "";
            if(varSyntax.Initializer != null)
            {
                strInitializer = $" {varSyntax.Initializer.ToString()}";
                switch (varSyntax.Initializer.Value)
                {
                    case InitializerExpressionSyntax initSyntax:
                        IEnumerable<SyntaxNode> initChildren = initSyntax.ChildNodes();
                        arraySize = initChildren.Count();
                        break;
                }
            }

            return $"{typeName} {varSyntax.Identifier}[{arraySize}]{strInitializer}";
        }
    }
}
