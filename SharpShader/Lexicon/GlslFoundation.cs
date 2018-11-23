using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class GlslFoundation : LanguageFoundation
    {
        internal override string TranslateConstantBuffer(ConversionContext context, StructDeclarationSyntax node, int slot)
        {
            throw new NotImplementedException();
        }

        internal override string TranslateStruct(ConversionContext context, StructDeclarationSyntax node)
        {
            throw new NotImplementedException();
        }

        internal override string TranslateStructField(ConversionContext context, FieldDeclarationSyntax node)
        {
            throw new NotImplementedException();
        }

        internal override string TranslateEntryPointHeader(ConversionContext context, EntryPoint ep, ref string header)
        {
            throw new NotImplementedException();
        }

        internal override string TranslateNumber(ConversionContext context, string number)
        {
            throw new NotImplementedException();
        }
    }
}
