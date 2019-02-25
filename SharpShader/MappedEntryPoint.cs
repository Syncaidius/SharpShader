﻿using Microsoft.CodeAnalysis.CSharp.Syntax;
using SharpShader.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    [Serializable]
    internal class MappedEntryPoint
    {
        internal EntryPointType EntryType;

        internal EntryPointAttribute Attribute;

        internal IEntryPointTranslator Translator;

        internal MappedEntryPoint(IEntryPointTranslator translator, EntryPointAttribute attribute)
        {
            Attribute = attribute;
            EntryType = attribute.EntryType;
            Translator = translator;
        }

        public override string ToString()
        {
            return EntryType.ToString();
        }
    }
}
