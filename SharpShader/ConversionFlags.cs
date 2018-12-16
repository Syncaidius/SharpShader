using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    [Flags]
    public enum ConversionFlags
    {
        None = 0,

        /// <summary>
        /// Removes all whitespace from the translated shader code. This is ignored if the <see cref="SkipFormatting"/> flag is present.
        /// </summary>
        RemoveWhitespace = 1,

        /// <summary>
        /// Skips the formatting correction stage, which usually fixes indentation and trims excess whitespace from the start and end of translated shader code. <para/>
        /// This will also cause other formatting-related flags to be ignored, such as <see cref="RemoveWhitespace"/>.
        /// </summary>
        SkipFormatting = 2,

        /// <summary>
        /// Strips code comments and summaries from the translated shader code.
        /// </summary>
        StripComments = 4,

        /// <summary>
        /// Skips the analysis stage of conversion. Useful if you can guarantee that the input source code is already error-free.
        /// </summary>
        SkipAnalysis = 5,
    }
}
