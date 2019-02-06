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
        /// <param name="sc">The <see cref="ShaderTranslationContext"/>.</param>
        /// <param name="syntax">The <see cref="SyntaxNode"/> to be translated.</param>
        internal abstract void Translate(ShaderTranslationContext sc, SyntaxNode syntax, ScopeInfo scope);

        internal abstract Type ParsedType { get; }
    }

    internal abstract class NodeProcessor<T> : NodeProcessor
        where T : SyntaxNode
    {
        internal override sealed Type ParsedType => typeof(T);

        internal override sealed void Translate(ShaderTranslationContext sc, SyntaxNode node, ScopeInfo scope)
        {
            OnTranslate(sc, node as T, scope);
        }

        protected abstract void OnTranslate(ShaderTranslationContext sc, T syntax, ScopeInfo scope);
    }
}
