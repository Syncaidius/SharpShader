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

        public override bool HasColumnMajorMatrices => true;

        internal GlslFoundation(OutputLanguage language) : base(language) { }

        internal override string TranslateNumber(ShaderTranslationContext context, string number)
        {
            throw new NotImplementedException();
        }

        internal override IEntryPointTranslator GetEntryPoinTranslator(EntryPointType type)
        {
            throw new NotImplementedException();
        }

        internal override void TranslateForLoopPrefix(ShaderTranslationContext sc, ForStatementSyntax syntax)
        {
            throw new NotImplementedException();
        }

        internal override void TranslateConstBufferHeader(ShaderTranslationContext sc, StructDeclarationSyntax syntax, ConstantBufferMap cBufferMap, IEnumerable<Attribute> attributes)
        {
            throw new NotImplementedException();
        }

        internal override void TranslateFieldPrefix(ShaderTranslationContext sc, VariableDeclaratorSyntax syntax, MappedField field, int fieldIndex, ConstantBufferMap cBufferMap)
        {
            throw new NotImplementedException();
        }

        internal override void TranslateFieldPostfix(ShaderTranslationContext sc, VariableDeclaratorSyntax syntax, MappedField field, int fieldIndex, ConstantBufferMap cBufferMap)
        {
            throw new NotImplementedException();
        }
    }
}
