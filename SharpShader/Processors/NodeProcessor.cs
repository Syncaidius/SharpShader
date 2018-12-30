﻿using Microsoft.CodeAnalysis;
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

        internal virtual void Translate(ShaderContext context, SyntaxNode node, StringBuilder source, ShaderElement component) { }

        protected void TranslateTypeSyntax(ShaderContext context, TypeSyntax syntax, StringBuilder source)
        {
            TypeSyntax typeSyntax = syntax is ArrayTypeSyntax arraySyntax ? arraySyntax.ElementType : syntax;

            string original = typeSyntax.ToString();
            (string replacement, Type t) = GetTypeTranslation(context, typeSyntax);
            source = source.Replace(original, replacement, typeSyntax.SpanStart, typeSyntax.Span.Length);

            if (t != null)
                context.Map.TranslatedTypes[replacement] = t;
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
            Type originalType = ShaderReflection.ResolveType(syntax.ToString());
            if (originalType != null)
            {
                // First attempt to directly translate the type. 
                // If we fail, check for any implemented interfaces we can translate instead.
                LanguageFoundation.Keyword translation = context.Parent.Foundation.GetKeyword(originalType);
                if (translation != null)
                {
                    return (translation.NativeText, originalType);
                }
                else
                {
                    Type[] iTypes = originalType.GetInterfaces();
                    foreach (Type implemented in iTypes)
                    {
                        translation = context.Parent.Foundation.GetKeyword(implemented);
                        if (translation != null)
                        {
                            string original = syntax.ToString();
                            string replacement = original;
                            for (int i = 0; i < ShaderReflection.IntrinsicPrefixes.Length; i++)
                                replacement = replacement.Replace(ShaderReflection.IntrinsicPrefixes[i], "");

                            if (translation.UniformSizeIsSingular)
                            {
                                if (typeof(UniformDimensions).IsAssignableFrom(originalType))
                                    replacement = replacement.Substring(0, replacement.Length - 2);
                            }

                            replacement = translation.NativeText + replacement;
                            return (replacement, originalType);
                        }
                    }
                }
            }

            return (syntax.ToString(), originalType);
        }

        internal bool HasStageFlags(NodeProcessStageFlags stage)
        {
            return (Stages & stage) == stage;
        }

        internal abstract Type ParsedType { get; }

        internal abstract NodeProcessStageFlags Stages { get; }
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

        internal override sealed void Translate(ShaderContext context, SyntaxNode node, StringBuilder source, ShaderElement element)
        {
            OnTranslate(context, node as T, source, element);
        }

        protected virtual void OnPreprocess(ShaderContext context, T syntax, StringBuilder source) { }

        protected virtual void OnMap(ShaderContext context, T syntax) { }

        protected virtual void OnTranslate(ShaderContext context, T syntax, StringBuilder source, ShaderElement element) { }
    }

    [Flags]
    internal enum NodeProcessStageFlags
    {
        None = 0,

        PreProcess = 1,

        Mapping = 2,

        PostProcess = 4
    }
}
