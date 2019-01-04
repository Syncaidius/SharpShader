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
        internal virtual void Preprocess(ShaderContext context, SyntaxNode node) { }

        internal virtual void Map(ShaderContext context, SyntaxNode node) { }

        internal virtual void Translate(ShaderContext context, SyntaxNode node) { }

        internal abstract Type ParsedType { get; }
    }

    internal abstract class NodeProcessor<T> : NodeProcessor
        where T : SyntaxNode
    {
        internal override sealed Type ParsedType => typeof(T);

        internal override sealed void Preprocess(ShaderContext context, SyntaxNode node)
        {
            OnPreprocess(context, node as T);
        }

        internal override sealed void Map(ShaderContext context, SyntaxNode node)
        {
            OnMap(context, node as T);
        }

        internal override sealed void Translate(ShaderContext context, SyntaxNode node)
        {
            OnTranslate(context, node as T);
        }

        protected virtual void OnPreprocess(ShaderContext context, T syntax) { }

        protected virtual void OnMap(ShaderContext context, T syntax) { }

        protected virtual void OnTranslate(ShaderContext context, T syntax) { }
    }
}
