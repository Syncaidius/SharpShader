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
        internal override string TranslateConstantBuffer(ConversionContext context, StructDeclarationSyntax node, int slot)
        {
            string result = $"cbuffer {node.Identifier} : register(b{slot}){Environment.NewLine}";
            result += "{" + Environment.NewLine;
            foreach(MemberDeclarationSyntax m in node.Members)
            {
                if (m is FieldDeclarationSyntax field)
                    result += $"{TranslateStructField(context, field)};{Environment.NewLine}";
            }
            result += "}" + Environment.NewLine;
            return result;
        }

        internal override string TranslateStruct(ConversionContext context, StructDeclarationSyntax node)
        {
            throw new NotImplementedException();
        }

        internal override string TranslateStructField(ConversionContext context, FieldDeclarationSyntax node)
        {
            return $"{node.Declaration}";
        }
    }
}
