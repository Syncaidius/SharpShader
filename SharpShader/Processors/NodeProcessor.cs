using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SharpShader
{
    internal delegate string TranslateCallbackDelegate(ref string source, ref string nodeSource);

    internal abstract class NodeProcessor
    {
        internal virtual void Preprocess(ShaderContext context, SyntaxNode node, StringBuilder source) { }

        internal virtual void Map(ShaderContext context, SyntaxNode node) { }

        internal virtual void Translate(ShaderContext context, SyntaxNode node, StringBuilder source) { }

        protected void TranslateTypeSyntax(ShaderContext context, TypeSyntax syntax, StringBuilder source)
        {
            TypeSyntax typeSyntax = syntax is ArrayTypeSyntax arraySyntax ? arraySyntax.ElementType : syntax;
            (string replacement, Type t) = GetTypeTranslation(context, typeSyntax);
            source = source.Replace(typeSyntax.ToString(), replacement, typeSyntax.SpanStart, typeSyntax.Span.Length);
        }

        protected void TranslateModifiers(ShaderContext context, int translatedSpanLength, SyntaxNode node, SyntaxTokenList modifiers, StringBuilder source)
        {
            // Now translate any modifiers the field may have.
            if (modifiers.Count > 0)
            {
                string modifierTranslation = context.Parent.Foundation.TranslateModifiers(modifiers, node);
                source.Replace(modifiers.ToString(), modifierTranslation, node.SpanStart, translatedSpanLength);
            }
        }

        protected (string, Type) GetTypeTranslation(ShaderContext context, TypeSyntax syntax)
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
                    context.Map.TranslatedTypes[translation.NativeText] = originalType;

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

                            if(arraySyntax != null)
                                replacement = $"{translation.NativeText}{replacement}{arraySyntax.RankSpecifiers}";
                            else
                                replacement = translation.NativeText + replacement;

                            context.Map.TranslatedTypes[replacement] = originalType;

                            return (replacement, originalType);
                        }
                    }
                }
            }

            return (originalName, originalType);
        }

        internal abstract Type ParsedType { get; }
    }

    internal abstract class NodeProcessor<T> : NodeProcessor
        where T : SyntaxNode
    {
        internal override sealed Type ParsedType => typeof(T);

        internal override sealed void Preprocess(ShaderContext context, SyntaxNode node, StringBuilder source)
        {
            OnPreprocess(context, node as T, source);
        }

        internal override sealed void Map(ShaderContext context, SyntaxNode node)
        {
            OnMap(context, node as T);
        }

        internal override sealed void Translate(ShaderContext context, SyntaxNode node, StringBuilder source)
        {
            OnTranslate(context, node as T, source);
        }

        protected virtual void OnPreprocess(ShaderContext context, T syntax, StringBuilder source) { }

        protected virtual void OnMap(ShaderContext context, T syntax) { }

        protected virtual void OnTranslate(ShaderContext context, T syntax, StringBuilder source) { }
    }
}
