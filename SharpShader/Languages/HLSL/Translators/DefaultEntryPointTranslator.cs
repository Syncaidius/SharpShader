using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Languages.HLSL.Translators
{
    internal class DefaultEntryPointTranslator : IEntryPointTranslator
    {
        private void TranslateSemantic(ShaderTranslationContext sc, SemanticAttribute attribute)
        {
            string semanticName = attribute.Semantic.ToString().ToUpper();
            sc.Source.Append($" : {semanticName}");

            if (attribute.Slot >= 0)
                sc.Source.Append(attribute.Slot.ToString());
        }

        public virtual void TranslateParameterPrefix(ShaderTranslationContext sc, ParameterSyntax syntax, MappedEntryPoint ep, ParameterInfo pInfo, IEnumerable<Attribute> attributes, int parameterIndex)
        {
            foreach (Attribute a in attributes)
                TranslateParameterAttributePrefix(sc, a, pInfo, ep);
        }

        public virtual void TranslateParameterPostfix(ShaderTranslationContext sc, ParameterSyntax syntax, MappedEntryPoint ep, ParameterInfo pInfo, IEnumerable<Attribute> attributes, int parameterIndex)
        {
            foreach (Attribute a in attributes)
            {
                switch (a)
                {
                    case SemanticAttribute attSemantic:
                        TranslateSemantic(sc, attSemantic);
                        break;

                    default:
                        TranslateParameterAttributePostfix(sc, a, pInfo, ep);
                        break;
                }
            }
        }

        public virtual void TranslatePostfix(ShaderTranslationContext sc, MethodInfo info, MethodDeclarationSyntax syntax, MappedEntryPoint ep)
        {
            SemanticAttribute attSemantic = info.GetCustomAttribute<SemanticAttribute>();
            if (attSemantic != null)
                TranslateSemantic(sc, attSemantic);
        }

        public virtual void TranslatePrefix(ShaderTranslationContext sc, MethodInfo info, MethodDeclarationSyntax syntax, MappedEntryPoint ep) { }

        protected virtual void TranslateParameterAttributePrefix(ShaderTranslationContext sc, Attribute attribute, ParameterInfo pInfo, MappedEntryPoint ep) { }

        protected virtual void TranslateParameterAttributePostfix(ShaderTranslationContext sc, Attribute attribute, ParameterInfo pInfo, MappedEntryPoint ep) { }
    }
}
