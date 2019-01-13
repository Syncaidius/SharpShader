using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal abstract class ScopeInfo
    {
        internal readonly struct OpenCloseSyntax
        {
            internal readonly string Value;

            internal readonly NewLineLocation NewLine;

            internal OpenCloseSyntax(string value, NewLineLocation newLine)
            {
                Value = value;
                NewLine = newLine;
            }

            internal OpenCloseSyntax(NewLineLocation newLine)
            {
                Value = string.Empty;
                NewLine = newLine;
            }
        }

        internal ScopeInfo Parent;

        internal int IndentationDepth;

        internal int StartPosition;

        internal abstract OpenCloseSyntax OpeningSyntax { get; }

        internal abstract OpenCloseSyntax ClosingSyntax { get; }
    }

    internal enum NewLineLocation
    {
        None = 0,

        Before = 1,

        After = 2,
    }
}
