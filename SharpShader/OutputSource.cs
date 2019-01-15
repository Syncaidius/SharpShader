using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    [Serializable]
    internal class OutputSource
    {
        StringBuilder _sb = new StringBuilder();

        [NonSerialized]
        Stack<ScopeInfo> _blocks = new Stack<ScopeInfo>();

        [NonSerialized]
        ScopeInfo _currentScope = new InertScopeInfo();

        internal void Append(SyntaxTriviaList triviaList)
        {
            foreach(SyntaxTrivia trivia in triviaList)
                _sb.Append(trivia.Token.ValueText);
        }

        internal void Append(SyntaxToken token)
        {
            _sb.Append(token.ValueText);
        }

        internal void Append(string src)
        {
            _sb.Append(src);
        }

        internal void AppendLineBreak()
        {
            _sb.Append(Environment.NewLine);
        }

        internal T OpenScope<T>() where T : ScopeInfo, new()
        {
            T newScope = new T()
            {
                Parent = _currentScope,
                IndentationDepth = _currentScope.IndentationDepth + 1,
                StartPosition = _sb.Length,
            };

            _blocks.Push(_currentScope); // Push old scope
            _currentScope = newScope; // Set new as current

            if ((_currentScope.OpeningSyntax.NewLine & NewLineLocation.Before) == NewLineLocation.Before)
                _sb.Append(Environment.NewLine);

            if (!string.IsNullOrEmpty(_currentScope.OpeningSyntax.Value))
                _sb.Append(_currentScope.OpeningSyntax.Value);

            if ((_currentScope.OpeningSyntax.NewLine & NewLineLocation.After) == NewLineLocation.After)
                _sb.Append(Environment.NewLine);

            return newScope;
        }

        internal void CloseScope()
        {
            if (_blocks.Count == 0)
                throw new ScopeException("Cannot close block. No blocks left to close.");

            if ((_currentScope.ClosingSyntax.NewLine & NewLineLocation.Before) == NewLineLocation.Before)
                _sb.Append(Environment.NewLine);

            if (!string.IsNullOrEmpty(_currentScope.ClosingSyntax.Value))
                _sb.Append(_currentScope.ClosingSyntax.Value);

            if ((_currentScope.ClosingSyntax.NewLine & NewLineLocation.After) == NewLineLocation.After)
                _sb.Append(Environment.NewLine);

            _currentScope = _blocks.Pop();
        }

        internal void Insert(string src, int index)
        {
            _sb.Insert(index, src);
        }

        public override string ToString()
        {
            return _sb.ToString();
        }

        public int CurrentBlockDepth => _blocks.Count;

        internal ScopeInfo CurrentScope => _currentScope;
    }
}
