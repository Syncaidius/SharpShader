using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class HlslLanguage : ShaderLanguage
    {
        internal override bool InstancedConstantBuffers => false;

        internal HlslLanguage(OutputLanguage language) : base(language)
        {
            //AddEntryPointTranslator<VertexEntryPointTranslator>(EntryPointType.VertexShader);
            //AddEntryPointTranslator<GeometryEntryPointTranslator>(EntryPointType.GeometryShader);
            //AddEntryPointTranslator<DomainEntryPointTranslator>(EntryPointType.DomainShader);
            //AddEntryPointTranslator<PixelEntryPointTranslator>(EntryPointType.FragmentShader);
        }

        internal override string TranslateConstantBuffer(ShaderContext context, StructDeclarationSyntax syntax, uint? registerID)
        {
            string strRegister = registerID != null ? $" : register(b{registerID}" : "";
            string result = $"cbuffer {syntax.Identifier}{strRegister}){Environment.NewLine}";
            result += "{" + Environment.NewLine;
            foreach (MemberDeclarationSyntax m in syntax.Members)
            {
                if (m is FieldDeclarationSyntax field)
                {
                    string fieldTranslation = TranslateVariable(context, syntax, field.Declaration.Type, field.Declaration.Variables[0].Identifier, field.Modifiers, field.AttributeLists);
                    result += $"{fieldTranslation};{Environment.NewLine}";
                }
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
                {
                    string fieldTranslation = TranslateVariable(context, syntax, field.Declaration.Type, field.Declaration.Variables[0].Identifier, field.Modifiers, field.AttributeLists);
                    result += $"{fieldTranslation};{Environment.NewLine}";
                }
            }
            result += "};" + Environment.NewLine;

            return result;
        }

        internal override string TranslateRegisterField(ShaderContext context, FieldDeclarationSyntax syntax, Type fieldType, uint registerID)
        {
            char? registerChar = null;

            if (typeof(TextureSampler).IsAssignableFrom(fieldType))
                registerChar = 's';
            else if (typeof(TextureBase).IsAssignableFrom(fieldType))
                registerChar = 't';

            if (registerChar != null)
                return $"{syntax.Declaration} : register({registerChar}{registerID});";
            else
                return syntax.ToString();
        }

        internal override string TranslateVariable(ShaderContext context,
            SyntaxNode parent,
            TypeSyntax type,
            SyntaxToken identifier,
            SyntaxTokenList modifiers,
            SyntaxList<AttributeListSyntax> attributes = default)
        {
            string modifierTranslation = "";
            bool isInConstBuffer = false;

            if (parent is StructDeclarationSyntax structSyntax)
                isInConstBuffer = context.ConstantBuffers.ContainsKey(structSyntax.Identifier.ValueText);


            // PackOffset can only be used on constant buffer fields. Skip parsing of this entirely if we're not in a constant buffer.
            if (isInConstBuffer)
            {
                AttributeSyntax packAttribute = ShaderReflection.GetAttribute<PackOffsetAttribute>(attributes);
                if (packAttribute != null)
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
                                return $"{type} {identifier} : packoffset(c{register}.{component.ToString().ToLower()})";
                        }

                        return $"{type} {identifier} : packoffset(c{register})";
                    }
                }
            }
            else
            {
                AttributeSyntax semanticAttribute = ShaderReflection.GetAttribute<SemanticAttribute>(attributes);
                if (semanticAttribute != null)
                {
                    if (!isInConstBuffer)
                        modifierTranslation = context.Parent.Language.TranslateModifiers(modifiers);

                    int slot = -1;
                    SemanticType semType = SemanticType.Position;
                    AttributeArgumentSyntax argSemantic = semanticAttribute.ArgumentList.Arguments[0];

                    if (ShaderReflection.ParseEnum(argSemantic.ToString(), out semType))
                    {
                        string strSemType = semType.ToString().ToUpper();
                        if (semanticAttribute.ArgumentList.Arguments.Count > 1)
                        {
                            AttributeArgumentSyntax argSlot = semanticAttribute.ArgumentList.Arguments[1];
                            string strArgSlot = argSlot.ToString();
                            if (int.TryParse(strArgSlot, out slot))
                            {
                                if (slot > -1)
                                    return $"{modifierTranslation} {type} {identifier} : {strSemType}{slot}";
                                else
                                    context.AddMessage($"Invalid SemanticAttribute slot value. Must be greater than, or equal to 0", 0, 0);
                            }
                            else
                            {
                                context.AddMessage($"Invalid SemanticAttribute slot value. Expected value greater than, or equal to 0. Got: {strArgSlot}", 0, 0);
                            }
                        }

                        return $"{modifierTranslation} {type} {identifier} : {strSemType}";
                    }
                    else
                    {
                        context.AddMessage($"Invalid semantic name: {argSemantic}", 0, 0);
                    }
                }
            }

            return $"{modifiers} {type} {identifier}";
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
