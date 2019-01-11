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
    internal abstract class NodeProcessor
    {
        internal abstract void Translate(ShaderContext context, SyntaxNode syntax);

        internal abstract bool OpenBlock(ShaderContext context, SyntaxNode syntax);

        internal abstract void CloseBlock(ShaderContext context, SyntaxNode syntax);

        internal abstract Type ParsedType { get; }
    }

    internal abstract class NodeProcessor<T> : NodeProcessor
        where T : SyntaxNode
    {
        internal override sealed Type ParsedType => typeof(T);

        internal override sealed void Translate(ShaderContext context, SyntaxNode node)
        {
            OnTranslate(context, node as T);
        }

        internal override sealed bool OpenBlock(ShaderContext context, SyntaxNode syntax)
        {
            return OnOpenBlock(context, syntax as T);
        }

        internal override void CloseBlock(ShaderContext context, SyntaxNode syntax)
        {
            OnCloseBlock(context, syntax as T);
        }

        protected abstract void OnTranslate(ShaderContext context, T syntax);

        protected abstract bool OnOpenBlock(ShaderContext context, T syntax);

        protected abstract bool OnCloseBlock(ShaderContext context, T syntax);
    }
}
