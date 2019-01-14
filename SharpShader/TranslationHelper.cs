using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal static class TranslationHelper
    {
        internal static (string translation, Type originalType, bool isArray) TranslateType(ShaderContext sc, string typeName)
        {
            Type type = ShaderReflection.ResolveType(typeName);
            if (type != null)
            {
                Type elementType = type.GetElementType();
                ShaderLanguage.Keyword translation = sc.Parent.Language.GetKeyword(type);
                if (translation != null)
                {
                    return (translation.NativeText, type, type.IsArray);
                }
                else // Attempt to find any interfaces on the type which can be translated instead.
                {
                    Type[] iTypes;
                    if (elementType != null)
                        iTypes = elementType.GetInterfaces();
                    else
                        iTypes = type.GetInterfaces();


                    foreach (Type implemented in iTypes)
                    {
                        translation = sc.Parent.Language.GetKeyword(implemented);
                        if (translation != null)
                        {
                            string replacement = elementType?.Name ?? type.Name;

                            // TODO Does this need optimizing? Benchmark before changing.
                            for (int i = 0; i < ShaderReflection.IntrinsicPrefixes.Length; i++)
                                replacement = replacement.Replace(ShaderReflection.IntrinsicPrefixes[i], "");

                            if (translation.UniformSizeIsSingular)
                            {
                                if (typeof(UniformDimensions).IsAssignableFrom(type))
                                    replacement = replacement.Substring(0, replacement.Length - 2);
                            }

                            replacement = translation.NativeText + replacement;
                            return (replacement, type, type.IsArray);
                        }
                    }
                }
            }

            // We have no known Type instance to use, so try to figure out if it's an array or not, manually.
            int openIndex = typeName.IndexOf("[");
            bool isArray = false;

            if (openIndex > -1 && typeName.EndsWith("]"))
            {
                typeName = typeName.Substring(0, openIndex);
                isArray = true;
            }

            return (typeName, type, isArray);
        }
    }
}
