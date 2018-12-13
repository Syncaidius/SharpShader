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
        internal override bool InstancedConstantBuffers => true;

        internal GlslFoundation(ShaderLanguage language) : base(language) { }

        internal override string TranslateConstantBuffer(ShaderContext context, StructDeclarationSyntax node, int slot)
        {
            throw new NotImplementedException();
        }

        internal override string TranslateStruct(ShaderContext context, StructDeclarationSyntax node)
        {
            throw new NotImplementedException();
        }

        internal override string TranslateStructField(ShaderContext context, FieldDeclarationSyntax node)
        {
            throw new NotImplementedException();
        }

        internal override string TranslateEntryPointHeader(ShaderContext context, EntryPoint ep, ref string header)
        {
            throw new NotImplementedException();
        }

        internal override string TranslateNumber(ShaderContext context, string number)
        {
            throw new NotImplementedException();
        }
    }
}
