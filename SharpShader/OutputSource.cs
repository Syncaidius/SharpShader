using Microsoft.CodeAnalysis;
using SharpShader.Exceptions;
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
        enum NewLineLocation
        {
            None = 0,

            Before = 1,

            After = 2,
        }

        StringBuilder _sb = new StringBuilder();

        [NonSerialized]
        Stack<ScopeInfo> _blocks = new Stack<ScopeInfo>();

        [NonSerialized]
        ScopeInfo _currentScope = new ScopeInfo(null, OpenBlockType.None, 0);

        // TODO Cache all the currently-switched values and flags in a lookup table. The switches can then be removed to speed things up.

        internal void Append(SyntaxToken token)
        {
            _sb.Append(token.ValueText);
        }

        internal void Append(string src)
        {
            _sb.Append(src);
        }

        internal void OpenScope(OpenBlockType type)
        {
            ScopeInfo newScope = new ScopeInfo(_currentScope, type, _currentScope?.IndentationDepth + 1 ?? 1);
            _blocks.Push(newScope);

            NewLineLocation newLine = NewLineLocation.Before;
            char c = '{';

            switch (type)
            {
                case OpenBlockType.ArgumentParentheses:
                case OpenBlockType.InvocationParentheses:
                    newLine = NewLineLocation.None;
                    c = '(';
                    break;

                case OpenBlockType.InitializerAssignment:
                case OpenBlockType.InitializerMember:
                    newLine = NewLineLocation.None;
                    c = char.MinValue;
                    break;
            }

            _currentScope = newScope;
            if (newLine == NewLineLocation.Before)
                _sb.Append(Environment.NewLine);


            if (c != char.MinValue)
                _sb.Append(c);

            if (newLine == NewLineLocation.After)
                _sb.Append(Environment.NewLine);
        }

        internal void CloseScope()
        {
            if (_blocks.Count == 0)
                throw new ScopeException("Cannot close block. No blocks left to close.");

            ScopeInfo info = _blocks.Pop();
            if (info.Type == OpenBlockType.None)
                return;

            NewLineLocation newLine = NewLineLocation.Before;
            char c = '}';

            switch (info.Type)
            {
                case OpenBlockType.ArgumentParentheses:
                case OpenBlockType.InvocationParentheses:
                    newLine = NewLineLocation.None;
                    c = ')';
                    break;

                case OpenBlockType.InitializerMember:
                    newLine = NewLineLocation.After;
                    c = ',';
                    break;

                case OpenBlockType.InitializerAssignment:
                    newLine = NewLineLocation.After;
                    c = ',';
                    break;

                case OpenBlockType.MemberAssignment:
                    newLine = NewLineLocation.After;
                    c = ';';
                    break;
            }

            _currentScope = info.Parent;
            if (newLine == NewLineLocation.Before)
                _sb.Append(Environment.NewLine);

            if (c != char.MinValue)
                _sb.Append(c);

            if (newLine == NewLineLocation.After)
                _sb.Append(Environment.NewLine);
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
