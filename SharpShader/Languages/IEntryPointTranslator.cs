﻿using Microsoft.CodeAnalysis.CSharp.Syntax;
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
        void TranslatePrefix(ShaderContext sc, MethodInfo info, MethodDeclarationSyntax syntax, EntryPoint ep);

        void TranslatePostfix(ShaderContext sc, MethodInfo info, MethodDeclarationSyntax syntax, EntryPoint ep);

        void TranslateParameterPrefix(ShaderContext sc, ParameterSyntax syntax, EntryPoint ep, ParameterInfo pInfo, IEnumerable<Attribute> attributes, int parameterIndex);

        void TranslateParameterPostfix(ShaderContext sc, ParameterSyntax syntax, EntryPoint ep, ParameterInfo pInfo, IEnumerable<Attribute> attributes, int parameterIndex);
    }
}
