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
        int _pos = 0;

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
            _rootScope = _currentScope;
        }

        internal void Append(SyntaxToken token)
        {
            if (_pos < _sb.Length)
                _sb.Insert(_pos, token.ValueText);
            else
                _sb.Append(token.ValueText);

            _pos += token.ValueText.Length;
        }

        internal void Append(string src)
        {
            if (_pos < _sb.Length)
                _sb.Insert(_pos, src);
            else
                _sb.Append(src);

            _pos += src.Length;
        }

        internal void AppendLineBreak()
        {
            if (_pos < _sb.Length)
                _sb.Insert(_pos, Environment.NewLine);
            else
                _sb.Append(Environment.NewLine);

            _pos += Environment.NewLine.Length;
        }

        internal void SetPosition(int pos)
        {
            _pos = pos;
        }

        internal void SetPositionToEnd()
        {
            _pos = _sb.Length;
        }

        internal ScopeInfo OpenScope(ScopeType type, Type tInfo = null)
        {
            ScopeInfo newScope = _context.Parent.ScopePool.Get();
            newScope.Parent = _currentScope;
            newScope.IndentationDepth = _currentScope.IndentationDepth + 1;
            newScope.Type = type;
            newScope.TypeInfo = tInfo;
            newScope.Settings = ScopeSettings.Settings[type];

            // Track namespace path
            if ((type == ScopeType.Class || type == ScopeType.Struct) && tInfo != null)
                newScope.Namespace = $"{_currentScope.Namespace}+{tInfo.Name}";
            else
                newScope.Namespace = _currentScope.Namespace;

            _blocks.Push(_currentScope); // Push old scope
            _currentScope = newScope; // Set new as current

            if ((_currentScope.Settings.OpeningSyntax.NewLine & NewLineFlags.Before) == NewLineFlags.Before)
                AppendLineBreak();

            if (!string.IsNullOrEmpty(_currentScope.Settings.OpeningSyntax.Value))
                Append(_currentScope.Settings.OpeningSyntax.Value);

            if ((_currentScope.Settings.OpeningSyntax.NewLine & NewLineFlags.After) == NewLineFlags.After)
                AppendLineBreak();

            if (type == ScopeType.Block && newScope.Parent.Type == ScopeType.Method)
                newScope.InsertionPoint = _sb.Length;

            return newScope;
        }

        internal void CloseScope()
        {
            if (_blocks.Count == 0)
                throw new ScopeException("Cannot close block. No blocks left to close.");

            if ((_currentScope.Settings.ClosingSyntax.NewLine & NewLineFlags.Before) == NewLineFlags.Before)
                AppendLineBreak();

            if (!string.IsNullOrEmpty(_currentScope.Settings.ClosingSyntax.Value))
                Append(_currentScope.Settings.ClosingSyntax.Value);

            if ((_currentScope.Settings.ClosingSyntax.NewLine & NewLineFlags.After) == NewLineFlags.After)
                AppendLineBreak();

            _context.Parent.ScopePool.Put(_currentScope);
            _currentScope = _blocks.Pop();
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
