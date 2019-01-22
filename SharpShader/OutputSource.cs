using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpShader
{
    [Serializable]
    internal class OutputSource
    {
        StringBuilder _sb = new StringBuilder();

        [NonSerialized]
        Stack<ScopeInfo> _blocks = new Stack<ScopeInfo>();

        [NonSerialized]
        ScopeInfo _currentScope;
        [NonSerialized]
        ScopeInfo _rootScope;

        [NonSerialized]
        ShaderContext _context;

        internal OutputSource(ShaderContext sc)
        {
            _context = sc;
            _currentScope = sc.Parent.ScopePool.Get();
            _currentScope.Type = ScopeType.Class;
            _currentScope.TypeInfo = sc.ShaderType;
            _currentScope.Namespace = $"{sc.ShaderType.Namespace}.{sc.ShaderType.Name}";
            _currentScope.IsDeclarative = true;
            _rootScope = _currentScope;
        }

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

        internal ScopeInfo OpenScope(ScopeType type, bool declarative = false, Type tInfo = null)
        {
            ScopeInfo newScope = _context.Parent.ScopePool.Get();
            newScope.Parent = _currentScope;
            newScope.IndentationDepth = _currentScope.IndentationDepth + 1;
            newScope.Type = type;
            newScope.TypeInfo = tInfo;
            newScope.IsDeclarative = declarative;
            newScope.Settings = ScopeSettings.Settings[type];

            // Track namespace path
            if ((type == ScopeType.Class || type == ScopeType.Struct) && tInfo != null)
                newScope.Namespace = $"{_currentScope.Namespace}+{tInfo.Name}";
            else
                newScope.Namespace = _currentScope.Namespace;

            _blocks.Push(_currentScope); // Push old scope
            _currentScope = newScope; // Set new as current

            if ((_currentScope.Settings.OpeningSyntax.NewLine & NewLineFlags.Before) == NewLineFlags.Before)
                _sb.Append(Environment.NewLine);

            if (!string.IsNullOrEmpty(_currentScope.Settings.OpeningSyntax.Value))
                _sb.Append(_currentScope.Settings.OpeningSyntax.Value);

            if ((_currentScope.Settings.OpeningSyntax.NewLine & NewLineFlags.After) == NewLineFlags.After)
                _sb.Append(Environment.NewLine);

            newScope.DeclarativeEntryPosition = _sb.Length;
            return newScope;
        }

        internal void CloseScope()
        {
            if (_blocks.Count == 0)
                throw new ScopeException("Cannot close block. No blocks left to close.");

            if ((_currentScope.Settings.ClosingSyntax.NewLine & NewLineFlags.Before) == NewLineFlags.Before)
                _sb.Append(Environment.NewLine);

            if (!string.IsNullOrEmpty(_currentScope.Settings.ClosingSyntax.Value))
                _sb.Append(_currentScope.Settings.ClosingSyntax.Value);

            if ((_currentScope.Settings.ClosingSyntax.NewLine & NewLineFlags.After) == NewLineFlags.After)
                _sb.Append(Environment.NewLine);

            _context.Parent.ScopePool.Put(_currentScope);
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

        internal ScopeInfo RootScope => _rootScope;
    }
}
