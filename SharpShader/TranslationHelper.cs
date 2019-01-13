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
        internal static string TranslateProperty(ShaderContext context, 
            BasePropertyDeclarationSyntax syntax, 
            ArrowExpressionClauseSyntax expressionBody,
            string identifier = null,
            SeparatedSyntaxList<ParameterSyntax> parameters = default)
        {
            string uid = null;
            if (string.IsNullOrWhiteSpace(identifier))
            {
                identifier = parameters.ToString();
                uid = context.Parent.GetNewVariableName(context.Name);
            }
            else
            {
                uid = context.Parent.GetNewVariableName(identifier);
            }
            
            PropertyTranslation translation = new PropertyTranslation()
            {
                GetterMethod = $"get{uid}",
                SetterMethod = $"set{uid}",
            };

            (translation.TypeName, translation.OriginalType) = TranslateType(context, syntax.Type.ToString());
            context.TranslatedProperties.Add(identifier, translation);

            string replacement = "";

            if (expressionBody != null) // Arrow getter property?
            {
                replacement += translation.TranslateArrowGetter(expressionBody, parameters);
            }
            else
            {
                foreach (AccessorDeclarationSyntax accessor in syntax.AccessorList.Accessors)
                {
                    if (accessor.Keyword.ValueText == "get")
                    {
                        if (accessor.ExpressionBody != null)
                        {
                            replacement += translation.TranslateArrowGetter(accessor.ExpressionBody, parameters);
                        }
                        else
                        {
                            replacement += translation.GetGetterHeader(parameters) + Environment.NewLine;
                            replacement += (accessor.Body?.ToString() ?? "{ }") + Environment.NewLine;
                        }
                    }
                    else if (accessor.Keyword.ValueText == "set")
                    {
                        if (accessor.ExpressionBody != null)
                        {
                            replacement += translation.TranslateArrowSetter(accessor.ExpressionBody, parameters);
                        }
                        else
                        {
                            replacement += translation.GetSetterHeader(parameters) + Environment.NewLine;
                            replacement += (accessor.Body?.ToString() ?? "{ }") + Environment.NewLine;
                        }
                    }
                }
            }

            return string.IsNullOrWhiteSpace(replacement) ? syntax.ToString() : replacement;
        }

        internal static (string translation, Type originalType, bool isArray) TranslateType2(ShaderContext sc, string typeName)
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

                            // TODO Optimize replacement block?
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

            int openIndex = typeName.IndexOf("[");
            bool isArray = false;

            if (openIndex > -1 && typeName.EndsWith("]"))
            {
                typeName = typeName.Substring(0, openIndex);
                isArray = true;
            }

            return (typeName, type, isArray);
        }

        internal static (string translation, Type originalType) TranslateType(ShaderContext sc, string typeName)
        {
            Type type = ShaderReflection.ResolveType(typeName);
            if (type != null)
            {
                // First attempt to directly translate the type. 
                // If we fail, check for any implemented interfaces we can translate instead.
                ShaderLanguage.Keyword translation = sc.Parent.Language.GetKeyword(type);
                if (translation != null)
                {
                    if (type.IsArray)
                    {
                        string rankSeparators = new string(',', type.GetArrayRank() - 1);
                        return ($"{translation.NativeText}[{rankSeparators}]", type);
                    }
                    else
                    {
                        return (translation.NativeText, type);
                    }
                }
                else // See if the type can be translated based on the interface(s) it implements instead.
                {
                    Type[] iTypes;
                    if (type.IsArray)
                        iTypes = type.GetElementType().GetInterfaces();
                    else
                        iTypes = type.GetInterfaces();

                    foreach (Type implemented in iTypes)
                    {
                        translation = sc.Parent.Language.GetKeyword(implemented);
                        if (translation != null)
                        {
                            string replacement = type.Name;
                            for (int i = 0; i < ShaderReflection.IntrinsicPrefixes.Length; i++)
                                replacement = replacement.Replace(ShaderReflection.IntrinsicPrefixes[i], "");

                            if (translation.UniformSizeIsSingular)
                            {
                                if (typeof(UniformDimensions).IsAssignableFrom(type))
                                    replacement = replacement.Substring(0, replacement.Length - 2);
                            }

                            if (type.IsArray)
                            {
                                string rankSeparators = new string(',', type.GetArrayRank() - 1);
                                replacement = $"{translation.NativeText}{replacement}{rankSeparators}";
                            }
                            else
                            {
                                replacement = translation.NativeText + replacement;
                            }

                            return (replacement, type);
                        }
                    }
                }
            }

            return (typeName, type);
        }
    }
}
