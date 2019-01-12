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
        internal abstract bool Translate(ShaderContext sc, SyntaxNode syntax, ScopeInfo scope);

        internal abstract void CloseSclope(ShaderContext sc, SyntaxNode syntax, ScopeInfo scope);

        internal abstract Type ParsedType { get; }
    }

    internal abstract class NodeProcessor<T> : NodeProcessor
        where T : SyntaxNode
    {
        internal override sealed Type ParsedType => typeof(T);

        internal override sealed bool Translate(ShaderContext sc, SyntaxNode node, ScopeInfo scope)
        {
            return OnTranslate(sc, node as T, scope);
        }

        internal override sealed void CloseSclope(ShaderContext sc, SyntaxNode syntax, ScopeInfo scope)
        {
            OnCloseScope(sc, syntax as T, scope);
        }

        protected abstract bool OnTranslate(ShaderContext sc, T syntax, ScopeInfo scope);

        protected virtual void OnCloseScope(ShaderContext sc, T syntax, ScopeInfo scope) { }
    }
}
