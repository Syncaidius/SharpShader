using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// A container class for shader entry-point information.
    /// </summary>
    public class EntryPointInfo
    {
        /// <summary>
        /// Gets the start index of the entry point function/method, within the source of a <see cref="ShaderTranslationResult"/>.
        /// </summary>
        public int StartIndex { get; }

        /// <summary>
        /// Gets the end index of the entry point function/method, within the source of a <see cref="ShaderTranslationResult"/>.
        /// </summary>
        public int EndIndex { get; }

        /// <summary>
        /// Gets the number of characters that make up the entry point function/method within the source of a <see cref="ShaderTranslationResult"/>.
        /// </summary>
        public int Length => EndIndex - StartIndex;

        /// <summary>
        /// Gets the name of the entry point function/method.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the type of the entry point.
        /// </summary>
        public EntryPointType Type { get; }

        /// <summary>
        /// Creates a new instance of <see cref="EntryPointInfo"/>.
        /// </summary>
        /// <param name="name">The name of the entry point function/method.</param>
        /// <param name="type">The type of entry point.</param>
        /// <param name="startIndex">The start index of the entry point function/method, within the translated source code.</param>
        /// <param name="endIndex">The end index of the entry point function/method, within the translated source code.</param>
        public EntryPointInfo(string name, EntryPointType type, int startIndex, int endIndex)
        {
            Name = name;
            Type = type;
            StartIndex = startIndex;
            EndIndex = endIndex;
        }
    }
}
