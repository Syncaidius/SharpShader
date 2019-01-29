using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Languages.HLSL.Translators
{
    internal class PixelTranslator : HlslTranslatorBase
    {
        public override void TranslatePrefix(ShaderContext sc, MethodInfo info, MethodDeclarationSyntax syntax, EntryPoint ep) { }

        protected override void TranslateParameterAttributePostfix(ShaderContext sc, Attribute attribute, ParameterInfo pInfo) { }

        protected override void TranslateParameterAttributePrefix(ShaderContext sc, Attribute attribute, ParameterInfo pInfo) { }
    }
}
