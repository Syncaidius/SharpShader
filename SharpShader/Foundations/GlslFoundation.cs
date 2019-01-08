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

        internal override string TranslateConstantBuffer(ShaderContext context, StructDeclarationSyntax node, uint? register)
        {
            throw new NotImplementedException();
        }

        internal override string TranslateStruct(ShaderContext context, StructDeclarationSyntax node)
        {
            throw new NotImplementedException();
        }

        internal override string TranslateVariable(ShaderContext context,
            SyntaxNode parent,
            TypeSyntax type,
            SyntaxToken identifier,
            SyntaxTokenList modifiers,
            SyntaxList<AttributeListSyntax> attributes)
        {
            throw new NotImplementedException();
        }

        internal override string TranslateNumber(ShaderContext context, string number)
        {
            throw new NotImplementedException();
        }

        internal override string TranslateRegisterField(ShaderContext context, FieldDeclarationSyntax syntax, Type fieldType, uint registerID)
        {
            throw new NotImplementedException();
        }

        internal override string TranslateArrayDeclaration(ShaderContext context, string typeName, VariableDeclaratorSyntax varSyntax)
        {
            throw new NotImplementedException();
        }
    }
}
