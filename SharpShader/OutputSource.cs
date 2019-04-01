using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpShader
{
    internal class OutputSource : MarshalByRefObject
    {
        Stack<ScopeInfo> _scopes = new Stack<ScopeInfo>();

        ScopeInfo _currentScope;
        ScopeInfo _rootScope;
        ShaderLanguage _language;
        TranslationFlags _flags;
        SourceSegment _firstSegment;
        SourceSegment _lastSegment;
        SourceSegment _curSegment;
        StringBuilder _sb = new StringBuilder();

        internal void Initialize(ShaderTranslationContext sc, TranslationFlags flags)
        {
            _flags = flags;
            _language = sc.Language;
            _currentScope = Pooling.Scopes.Get();
            _currentScope.Type = ScopeType.Class;
            _currentScope.TypeInfo = new ShaderType(_language, sc.ShaderType.Name, sc.ShaderType);
            _currentScope.Namespace = $"{sc.ShaderType.Namespace}.{sc.ShaderType.Name}";
            _rootScope = _currentScope;
            _firstSegment = Pooling.SourceSegments.Get();
            _firstSegment.Value = "";
            _curSegment = _firstSegment;
            _lastSegment = _curSegment;
        }

        internal void Clear()
        {
            SourceSegment seg = _lastSegment;
            SourceSegment prev = null;

            while(seg != null)
            {
                prev = seg.Previous;
                Pooling.SourceSegments.Put(seg);
                seg = prev;
            }

            _firstSegment = null;
            _lastSegment = null;
            _curSegment = null;

            foreach (ScopeInfo si in _scopes)
                Pooling.Scopes.Put(si);

            Pooling.Scopes.Put(_currentScope);

            _rootScope = null;
            _currentScope = null;
            _language = null;
        }

        internal SourceSegment Append(SyntaxToken token)
        {
            return Append(token.ValueText);
        }

        internal SourceSegment Append(string src)
        {
            SourceSegment seg = Pooling.SourceSegments.Get();
            seg.Previous = _curSegment;
            seg.Next = _curSegment.Next;
            seg.Value = src;

            if(_curSegment.Next != null)
                _curSegment.Next.Previous = seg;

            _curSegment.Next = seg;

            if (_curSegment == _lastSegment)
                _lastSegment = seg;

            _curSegment = seg;

            return seg;
        }

        internal SourceSegment AppendLineBreak()
        {
            return Append(Environment.NewLine);
        }

        internal void GoToSegment(SourceSegment seg)
        {
            _curSegment = seg;
        }

        internal void GoToEnd()
        {
            _curSegment = _lastSegment;
        }

        internal ScopeInfo OpenScope(ScopeType type, Type tInfo)
        {
            return OpenScope(type, new ShaderType(_language, tInfo.Name, tInfo));
        }

        internal ScopeInfo OpenScope(ScopeType type, ShaderType tInfo = null, ISegmentTracker tracker = null)
        {
            ScopeInfo newScope = Pooling.Scopes.Get();
            newScope.Parent = _currentScope;
            newScope.IndentationDepth = _currentScope.IndentationDepth + 1;
            newScope.Type = type;
            newScope.TypeInfo = tInfo;
            newScope.Settings = ScopeSettings.Settings[type];

            // Track namespace path
            if ((type == ScopeType.Class || type == ScopeType.Struct) && tInfo != null)
                newScope.Namespace = $"{_currentScope.Namespace}+{tInfo.OriginalType.Name}";
            else
                newScope.Namespace = _currentScope.Namespace;

            _scopes.Push(_currentScope); // Push old scope
            _currentScope = newScope; // Set new as current

            if ((_currentScope.Settings.OpeningSyntax.NewLine & NewLineFlags.Before) == NewLineFlags.Before)
                newScope.OpeningSegment = AppendLineBreak();

            if (!string.IsNullOrEmpty(_currentScope.Settings.OpeningSyntax.Value))
                newScope.OpeningSegment = Append(_currentScope.Settings.OpeningSyntax.Value);

            if ((_currentScope.Settings.OpeningSyntax.NewLine & NewLineFlags.After) == NewLineFlags.After)
                newScope.OpeningSegment = AppendLineBreak();

            newScope.OpeningSegment = newScope.OpeningSegment ?? Append("");
            newScope.OpeningSegment.Scope = ScopeMode.Opening;
            newScope.OpeningSegment.Tracker = tracker;

            if(tracker != null)
            tracker.StartIndex = 5;

            if (newScope.Settings.Indent)
                newScope.OpeningSegment.Indentation = IndentMode.Increment;

            return newScope;
        }

        internal void CloseScope()
        {
            if (_scopes.Count == 0)
                throw new ScopeException("Cannot close block. No blocks left to close.");

            SourceSegment closingSegment = null;

            if ((_currentScope.Settings.ClosingSyntax.NewLine & NewLineFlags.Before) == NewLineFlags.Before)
                AppendLineBreak();

            // We only take the actual closing syntax as a segment, we don't care about the line breaks for closing, when formatting.
            if (!string.IsNullOrEmpty(_currentScope.Settings.ClosingSyntax.Value))
                closingSegment = Append(_currentScope.Settings.ClosingSyntax.Value);

            if ((_currentScope.Settings.ClosingSyntax.NewLine & NewLineFlags.After) == NewLineFlags.After)
                AppendLineBreak();

            closingSegment = closingSegment ?? Append("");
            if(_currentScope.Settings.Indent)
                closingSegment.Indentation = IndentMode.Decrement;

            // Tie opening and closing segments together
            closingSegment.ScopePartner = _currentScope.OpeningSegment;
            closingSegment.Tracker = _currentScope.OpeningSegment.Tracker;
            closingSegment.Scope = ScopeMode.Closing;
            _currentScope.OpeningSegment.ScopePartner = closingSegment;

            Pooling.Scopes.Put(_currentScope);
            _currentScope = _scopes.Pop();
        }

        public override string ToString()
        {
            SourceSegment seg = _firstSegment;
            int indent = 0;
            bool lineEmpty = true;
            bool whitespaceAllowed = (_flags & TranslationFlags.NoWhitespace) != TranslationFlags.NoWhitespace;

            while (seg != null)
            {
                if (seg.Indentation == IndentMode.Decrement)
                    indent--;

                if (whitespaceAllowed && lineEmpty && indent > 0 && seg.Value.Length > 0)
                    _sb.Append(new string('\t', indent));

                if(seg.Tracker != null&& seg.Scope == ScopeMode.Opening)
                    seg.Tracker.StartIndex = _sb.Length;

                if (seg.Value == Environment.NewLine)
                {
                    if (whitespaceAllowed)
                        _sb.Append(seg.Value);
                    lineEmpty = true;
                }
                else
                {
                    _sb.Append(seg.Value);
                    if (seg.Value.Length > 0)
                        lineEmpty = false;
                }

                string test = _sb.Length.ToString();
                if (seg.Tracker != null && seg.Scope == ScopeMode.Closing)
                    seg.Tracker.EndIndex = _sb.Length;

                if (seg.Indentation == IndentMode.Increment)
                    indent++;


                seg = seg.Next;
            }

            string result = _sb.ToString();
            _sb.Clear();
            return result;
        }

        public int CurrentBlockDepth => _scopes.Count;

        internal ScopeInfo CurrentScope => _currentScope;

        internal ScopeInfo RootScope => _rootScope;
    }
}
