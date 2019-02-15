using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader.Result
{
    public class ShaderMember
    {
        internal ShaderMember() { }

        /// <summary>
        /// Gets information about an individual element within the current <see cref="ShaderMember"/>.
        /// </summary>
        public ShaderElementInfo ElementInfo { get; internal set; }

        /// <summary>
        /// Gets the total size of the member, in bytes.
        /// </summary>
        public int SizeOf { get; internal set; }

        /// <summary>
        /// Gets the identifier or name of the element.
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// Gets the offset of the expected value, from the start of it's parent type (e.g. struct, buffer, etc), in bytes.
        /// </summary>
        public int StartOffset { get; internal set; }

        /// <summary>
        /// Gets the array size of the current <see cref="ShaderMember"/>. If the member is not an array, this list will be empty.
        /// </summary>
        public IReadOnlyList<int> ArrayDimensions { get; internal set; }

        /// <summary>
        /// Gets the number of values expected by the current <see cref="ShaderMember"/>. This may be for example, the length of an array, or the number of components in a vector.
        /// </summary>
        public int ElementCount { get; internal set; }

        /// <summary>
        /// Gets the structure of the element. e.g. A scalar, vector, matrix or array.
        /// </summary>
        public ShaderStructureType StructureType { get; internal set; }
    }
}
