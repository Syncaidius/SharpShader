﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class ScopeSettings
    {
        internal readonly struct OpenCloseSyntax
        {
            internal readonly string Value;

            internal readonly NewLineFlags NewLine;

            internal OpenCloseSyntax(string value, NewLineFlags newLine)
            {
                Value = value;
                NewLine = newLine;
            }

            internal OpenCloseSyntax(NewLineFlags newLine)
            {
                Value = string.Empty;
                NewLine = newLine;
            }
        }

        internal readonly OpenCloseSyntax OpeningSyntax;

        internal readonly OpenCloseSyntax ClosingSyntax;

        internal ScopeSettings() : this("", NewLineFlags.None, "", NewLineFlags.None) { }

        internal ScopeSettings(string openingString, NewLineFlags openingFlags, string closingString, NewLineFlags closingFlags)
        {
            OpeningSyntax = new OpenCloseSyntax(openingString, openingFlags);
            ClosingSyntax = new OpenCloseSyntax(closingString, closingFlags);
        }

        internal static readonly Dictionary<ScopeType, ScopeSettings> Settings = new Dictionary<ScopeType, ScopeSettings>()
        {
            [ScopeType.Class] = new ScopeSettings(),
            [ScopeType.Block] = new ScopeSettings("{", NewLineFlags.Before | NewLineFlags.After, "}", NewLineFlags.After),
            [ScopeType.Indexer] = new ScopeSettings("[", NewLineFlags.None, "]", NewLineFlags.None),
            [ScopeType.ArrayElement] = new ScopeSettings("", NewLineFlags.None, ",", NewLineFlags.After),
            [ScopeType.ArrayInitializer] = new ScopeSettings("{", NewLineFlags.Before | NewLineFlags.After, "}", NewLineFlags.Before),
            [ScopeType.ExpandedInitializer] = new ScopeSettings(),
            [ScopeType.Variable] = new ScopeSettings("", NewLineFlags.None, ";", NewLineFlags.After),
            [ScopeType.ParenthesesItem] = new ScopeSettings("", NewLineFlags.None, ", ", NewLineFlags.None),
            [ScopeType.Parentheses] = new ScopeSettings("(", NewLineFlags.None, ")", NewLineFlags.None),
            [ScopeType.Struct] = new ScopeSettings("{", NewLineFlags.Before | NewLineFlags.After, "};", NewLineFlags.After),
            [ScopeType.Typed] = new ScopeSettings(),
            [ScopeType.Method] = new ScopeSettings(),
            [ScopeType.Property] = new ScopeSettings(),
        };
    }

    [Flags]
    internal enum NewLineFlags
    {
        None = 0,

        Before = 1,

        After = 2,
    }

    internal enum ScopeType
    {
        Class = 0,

        Block = 1,

        Indexer = 2,

        ArrayElement = 3,

        ArrayInitializer = 4,

        Variable = 5,

        ParenthesesItem = 6,

        Parentheses = 7,

        Struct = 8,

        Typed = 9,

        Method = 10,

        Property = 11,

        ExpandedInitializer = 12,
    }
}
