﻿using Microsoft.CodeAnalysis;
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
        internal abstract string TranslateConstantBuffer(ConversionContext context, StructDeclarationSyntax syntax, int slot);

        internal abstract string TranslateStruct(ConversionContext context, StructDeclarationSyntax syntax);

        internal abstract string TranslateStructField(ConversionContext context, FieldDeclarationSyntax syntax);

        /// <summary>
        /// Occurs when the first line of an entry point method/function declaration requires translating. The content of the method should not be translated.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="ep"></param>
        /// <returns></returns>
        internal abstract string TranslateEntryPointHeader(ConversionContext context, EntryPoint ep, ref string header);
    }
}
