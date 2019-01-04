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
                uid = context.Parent.GetNewVariableName(context.SanitizedName);
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

            (translation.TypeName, translation.OriginalType) = GetTypeTranslation(context, syntax.Type);
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
                            replacement += accessor.Body + Environment.NewLine;
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
                            replacement += accessor.Body + Environment.NewLine;
                        }
                    }
                }
            }

            return string.IsNullOrWhiteSpace(replacement) ? syntax.ToString() : replacement;
        }

        internal static void TranslateTypeSyntax(ShaderContext context, TypeSyntax syntax)
        {
            TypeSyntax typeSyntax = syntax is ArrayTypeSyntax arraySyntax ? arraySyntax.ElementType : syntax;
            (string replacement, Type t) = GetTypeTranslation(context, typeSyntax);
            context.ReplaceSource(typeSyntax, replacement);
        }

        internal static void TranslateModifiers(
            ShaderContext context, 
            SyntaxTokenList modifiers)
        {
            // Now translate any modifiers the field may have.
            if (modifiers.Count > 0)
            {
                string modifierTranslation = context.Parent.Foundation.TranslateModifiers(modifiers);
                context.ReplaceSource(modifiers.ToString(), modifierTranslation, modifiers.Span.Start, modifiers.Span.Length);
            }
        }

        internal static (string, Type) GetTypeTranslation(ShaderContext context, TypeSyntax syntax)
        {
            ArrayTypeSyntax arraySyntax = syntax as ArrayTypeSyntax;
            TypeSyntax typeSyntax = arraySyntax != null ? arraySyntax.ElementType : syntax;
            string originalName = typeSyntax.ToString();
            Type originalType = ShaderReflection.ResolveType(originalName);

            if (originalType != null)
            {
                // First attempt to directly translate the type. 
                // If we fail, check for any implemented interfaces we can translate instead.
                LanguageFoundation.Keyword translation = context.Parent.Foundation.GetKeyword(originalType);
                if (translation != null)
                {
                    context.TranslatedTypes[translation.NativeText] = originalType;

                    if (arraySyntax != null)
                        return ($"{translation.NativeText}{arraySyntax.RankSpecifiers}", originalType);
                    else
                        return (translation.NativeText, originalType);
                }
                else // See if the type can be translated based on the interface(s) it implements instead.
                {
                    Type[] iTypes = originalType.GetInterfaces();
                    foreach (Type implemented in iTypes)
                    {
                        translation = context.Parent.Foundation.GetKeyword(implemented);
                        if (translation != null)
                        {
                            string replacement = originalName;
                            for (int i = 0; i < ShaderReflection.IntrinsicPrefixes.Length; i++)
                                replacement = replacement.Replace(ShaderReflection.IntrinsicPrefixes[i], "");

                            if (translation.UniformSizeIsSingular)
                            {
                                if (typeof(UniformDimensions).IsAssignableFrom(originalType))
                                    replacement = replacement.Substring(0, replacement.Length - 2);
                            }

                            if (arraySyntax != null)
                                replacement = $"{translation.NativeText}{replacement}{arraySyntax.RankSpecifiers}";
                            else
                                replacement = translation.NativeText + replacement;

                            context.TranslatedTypes[replacement] = originalType;

                            return (replacement, originalType);
                        }
                    }
                }
            }

            return (originalName, originalType);
        }

        internal static string SanitizeString(string input)
        {
            StringBuilder sb = new StringBuilder(input.Length);
            foreach (char c in input)
            {
                if (char.IsLetter(c) || char.IsNumber(c) || c == '_')
                    sb.Append(c);
            }

            return sb.ToString();
        }
    }
}
