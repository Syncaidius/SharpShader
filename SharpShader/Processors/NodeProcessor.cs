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
        /// <summary>
        /// Returns true 
        /// </summary>
        /// <param name="sc">The <see cref="ShaderContext"/>.</param>
        /// <param name="syntax">The <see cref="SyntaxNode"/> to be translated.</param>
        internal abstract bool Translate(ShaderContext sc, SyntaxNode syntax);

        internal abstract void CloseBlock(ShaderContext sc, SyntaxNode syntax);

        internal abstract Type ParsedType { get; }
    }

    internal abstract class NodeProcessor<T> : NodeProcessor
        where T : SyntaxNode
    {
        internal override sealed Type ParsedType => typeof(T);

        internal override sealed bool Translate(ShaderContext sc, SyntaxNode node)
        {
            return OnTranslate(sc, node as T);
        }

        internal override void CloseBlock(ShaderContext sc, SyntaxNode syntax)
        {
            OnCloseBlock(sc, syntax as T);
        }

        protected abstract bool OnTranslate(ShaderContext sc, T syntax);

        protected virtual void OnCloseBlock(ShaderContext sc, T syntax) { }
    }
}
