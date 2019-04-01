using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    [Flags]
    public enum TranslationFlags
    {
        /// <summary>
        /// No flags.
        /// </summary>
        None = 0,

        /// <summary>
        /// Avoids adding whitespace for formatting, to the translated shader code.
        /// </summary>
        NoWhitespace = 1,

        /// <summary>
        /// Strips code comments and summaries from the translated shader code.
        /// </summary>
        StripComments = 4,
    }
}
