using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SharpShader.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class GlslFoundation : ShaderLanguage
    {
        internal override bool InstancedConstantBuffers => true;

        internal GlslFoundation(OutputLanguage language) : base(language) { }

        internal override string TranslateNumber(ShaderContext context, string number)
        {
            throw new NotImplementedException();
        }

        internal override void TranslateConstBufferHeader(ShaderContext sc, StructDeclarationSyntax syntax, Type info, IEnumerable<Attribute> attributes)
        {
            throw new NotImplementedException();
        }

        internal override void TranslateFieldPrefix(ShaderContext sc, VariableDeclaratorSyntax syntax, FieldInfo info, IEnumerable<Attribute> attributes, int fieldIndex)
        {
            throw new NotImplementedException();
        }

        internal override void TranslateFieldPostfix(ShaderContext sc, VariableDeclaratorSyntax syntax, FieldInfo info, IEnumerable<Attribute> attributes, int fieldIndex)
        {
            throw new NotImplementedException();
        }

        internal override IEntryPointTranslator GetEntryPoinTranslator(EntryPointType type)
        {
            throw new NotImplementedException();
        }

        internal override void TranslateForLoopPrefix(ShaderContext sc, ForStatementSyntax syntax)
        {
            throw new NotImplementedException();
        }
    }
}
