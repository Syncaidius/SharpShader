using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Languages.HLSL.Translators
{
    internal abstract class HlslTranslatorBase : IEntryPointTranslator
    {
        private void TranslateSemantic(ShaderContext sc, SemanticAttribute attribute)
        {
            string semanticName = attribute.Semantic.ToString().ToUpper();
            sc.Source.Append($" : {semanticName}");

            if (attribute.Slot >= 0)
                sc.Source.Append(attribute.Slot.ToString());
        }

        public void TranslateParameterPrefix(ShaderContext sc, ParameterSyntax syntax, EntryPoint ep, ParameterInfo pInfo, IEnumerable<Attribute> attributes, int parameterIndex)
        {
            foreach (Attribute a in attributes)
                TranslateParameterAttributePrefix(sc, a, pInfo);
        }

        public void TranslateParameterPostfix(ShaderContext sc, ParameterSyntax syntax, EntryPoint ep, ParameterInfo pInfo, IEnumerable<Attribute> attributes, int parameterIndex)
        {
            foreach (Attribute a in attributes)
            {
                switch (a)
                {
                    case SemanticAttribute attSemantic:
                        TranslateSemantic(sc, attSemantic);
                        break;

                    default:
                        TranslateParameterAttributePostfix(sc, a, pInfo);
                        break;
                }
            }
        }

        public virtual void TranslatePostfix(ShaderContext sc, MethodInfo info, MethodDeclarationSyntax syntax, EntryPoint ep)
        {
            SemanticAttribute attSemantic = info.GetCustomAttribute<SemanticAttribute>();
            if (attSemantic != null)
                TranslateSemantic(sc, attSemantic);
        }

        public abstract void TranslatePrefix(ShaderContext sc, MethodInfo info, MethodDeclarationSyntax syntax, EntryPoint ep);

        protected abstract void TranslateParameterAttributePrefix(ShaderContext sc, Attribute attribute, ParameterInfo pInfo);

        protected abstract void TranslateParameterAttributePostfix(ShaderContext sc, Attribute attribute, ParameterInfo pInfo);
    }
}
