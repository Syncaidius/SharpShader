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

    internal abstract class NodePreprocessor
    {
        internal abstract void Process(ConversionContext context, SyntaxNode node, StringBuilder source);

        protected void TranslateTypeSyntax(ConversionContext context, TypeSyntax syntax, StringBuilder source)
        {
            Type t = Type.GetType($"SharpShader.{syntax}") ?? Type.GetType($"System.{syntax}");
            if (t != null)
            {
                Type[] iTypes = t.GetInterfaces();
                foreach (Type implemented in iTypes)
                {
                    ShaderLexicon.Word translation = context.Lexicon.GetWord(implemented);
                    if (translation != null)
                    {
                        string original = syntax.ToString();
                        string replacement = null;
                        if (typeof(IVector).IsAssignableFrom(implemented))
                            replacement = original.Replace("Vector", "");
                        else if (typeof(IMatrix).IsAssignableFrom(implemented))
                            replacement = original.Replace("Matrix", "");

                        if (translation.UniformSizeIsSingular)
                        {
                            if (typeof(UniformDimensions).IsAssignableFrom(t))
                                replacement = replacement.Substring(0, replacement.Length - 2);
                        }

                        replacement = translation.Text + replacement;

                        // Replace the type across the whole source. This saves regenerating the syntax tree for each individual field declaration.
                        source = source.Replace(original, replacement, syntax.SpanStart, syntax.Span.Length);
                        break;
                    }
                }
            }
        }


        protected static void RemoveSyntax(SyntaxNode node, StringBuilder source)
        {
            source = source.Remove(node.SpanStart, node.Span.Length);
        }

        protected static void RemoveToken(SyntaxToken node, StringBuilder source)
        {
            source = source.Remove(node.SpanStart, node.Span.Length);
        }

        protected static void RemoveTokens(SyntaxTokenList list, StringBuilder source)
        {
            foreach (SyntaxToken token in list)
                RemoveToken(token, source);
        }

        internal abstract Type ParsedType { get; }
    }

    internal abstract class NodePreprocessor<T> : NodePreprocessor
        where T : SyntaxNode
    {
        internal override sealed Type ParsedType => typeof(T);

        internal override sealed void Process(ConversionContext context, SyntaxNode node, StringBuilder source)
        {
            OnProcess(context, node as T, source);
        }

        protected abstract void OnProcess(ConversionContext context, T node, StringBuilder source);
    }
}
