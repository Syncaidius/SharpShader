using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal abstract class LanguageFoundation
    {
        internal abstract string TranslateConstantBuffer(ConversionContext context, StructDeclarationSyntax node, int slot);

        internal abstract string TranslateStruct(ConversionContext context, StructDeclarationSyntax node);

        internal abstract string TranslateStructField(ConversionContext context, FieldDeclarationSyntax node);
    }
}
