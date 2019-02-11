using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    [Serializable]
    public struct TranslationMessage
    {
        /// <summary>
        /// The error message.
        /// </summary>
        public string Text { get; internal set; }

        /// <summary>
        /// The line number of the error.
        /// </summary>
        public int LineNumber { get; internal set; }

        /// <summary>
        /// The character position along the <see cref="LineNumber"/> at which the error is located.
        /// </summary>
        public int LinePosition { get; internal set; }

        public ConversionMessageType MessageType { get; internal set; }
    }

    public enum ConversionMessageType
    {
        Message = 0,

        Error = 1,

        Warning = 2,

        Status = 3,
    }
}
