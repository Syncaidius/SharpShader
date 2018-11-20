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
        internal virtual void Preprocess(ConversionContext context, SyntaxNode node, StringBuilder source) { }

        internal virtual void Map(ConversionContext context, SyntaxNode node) { }

        internal virtual void Postprocess(ConversionContext context, SyntaxNode node, StringBuilder source, ShaderComponent component) { }

        protected void TranslateTypeSyntax(ConversionContext context, TypeSyntax syntax, StringBuilder source)
        {
            string original = syntax.ToString();
            string replacement = GetTypeTranslation(context, syntax);
            source = source.Replace(original, replacement, syntax.SpanStart, syntax.Span.Length);
        }

        protected string GetTypeTranslation(ConversionContext context, TypeSyntax syntax)
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
                        return replacement;
                    }
                }
            }

            return syntax.ToString();
        }

        internal bool HasStageFlags(NodeProcessStageFlags stage)
        {
            return (Stages & stage) == stage;
        }


        protected static void RemoveSyntax(SyntaxNode node, StringBuilder source)
        {
            source = source.Remove(node.SpanStart, node.Span.Length);
        }

        protected static void RemoveToken(SyntaxToken node, StringBuilder source)
        {
            source = source.Remove(node.SpanStart, node.Span.Length);
        }

        protected static void RemoveTokens(SyntaxTokenList tokens, StringBuilder source)
        {
            for (int i = tokens.Count - 1; i >= 0; i--)
                RemoveToken(tokens[i], source);
        }

        internal abstract Type ParsedType { get; }

        internal abstract NodeProcessStageFlags Stages { get; }
    }

    internal abstract class NodeProcessor<T> : NodeProcessor
        where T : SyntaxNode
    {
        internal override sealed Type ParsedType => typeof(T);

        internal override sealed void Preprocess(ConversionContext context, SyntaxNode node, StringBuilder source)
        {
            OnpPreprocess(context, node as T, source);
        }

        internal override sealed void Map(ConversionContext context, SyntaxNode node)
        {
            OnMap(context, node as T);
        }

        internal override sealed void Postprocess(ConversionContext context, SyntaxNode node, StringBuilder source, ShaderComponent component)
        {
            OnPostprocess(context, node as T, source, component);
        }

        protected virtual void OnpPreprocess(ConversionContext context, T syntax, StringBuilder source) { }

        protected virtual void OnMap(ConversionContext context, T syntax) { }

        protected virtual void OnPostprocess(ConversionContext context, T syntax, StringBuilder source, ShaderComponent component) { }
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
