using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class SourceSegment : IPoolable
    {
        internal string Value { get; set; }

        internal SourceSegment Previous { get; set; }

        internal SourceSegment Next { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="SourceSegment"/> which was used in conjunction with the current <see cref="SourceSegment"/> to represent the start and end of a scope. 
        /// </summary>
        internal SourceSegment ScopePartner { get; set; }

        /// <summary>
        /// An optional tracker for tracing the start and end index of the current <see cref="SourceSegment"/>, once it is applied to the final result.
        /// </summary>
        internal ISegmentTracker Tracker { get; set; }

        internal IndentMode Indentation { get; set; } 

        internal ScopeMode Scope { get; set; }

        public void Clear()
        {
            Next = null;
            Previous = null;
            Value = null;
            Tracker = null;
            ScopePartner = null;
            Indentation = IndentMode.None;
        }
    }

    internal interface ISegmentTracker
    {
        int StartIndex { get; set; }

        int EndIndex { get; set; }
    }

    internal enum ScopeMode
    {
        None = 0,

        Opening = 1,

        Closing = 2,
    }

    internal enum IndentMode
    {
        None = 0,

        Increment = 1,

        Decrement = 2,
    }
}
