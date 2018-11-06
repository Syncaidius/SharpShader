using System;
using System.Collections.Generic;
using System.Reflection;

namespace SharpShader
{
    internal class TypeTranslator : Translator
    {
        internal override void Translate(ConversionContext context)
        {
            Assembly assembly = this.GetType().Assembly;
            IEnumerable<Type> types = assembly.GetTypes();

            // TODO Replace all IMatrix and IVector types with their HLSL counter-parts.
            // TODO a. Replace any instantiations with a plain myType(arg1, arg2, ..) constructor
            //      b. Also remove any instantiated specially-attributed types (e.g. constantbuffer structs/classes).

            //context.ReplaceInResult(@"[\w",)
        }
    }
}