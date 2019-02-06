using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader.Languages
{
    internal interface IEntryPointTranslator
    {
        void TranslatePrefix(ShaderTranslationContext sc, MethodInfo info, MethodDeclarationSyntax syntax, MappedEntryPoint ep);

        void TranslatePostfix(ShaderTranslationContext sc, MethodInfo info, MethodDeclarationSyntax syntax, MappedEntryPoint ep);

        void TranslateParameterPrefix(ShaderTranslationContext sc, ParameterSyntax syntax, MappedEntryPoint ep, ParameterInfo pInfo, IEnumerable<Attribute> attributes, int parameterIndex);

        void TranslateParameterPostfix(ShaderTranslationContext sc, ParameterSyntax syntax, MappedEntryPoint ep, ParameterInfo pInfo, IEnumerable<Attribute> attributes, int parameterIndex);
    }
}
