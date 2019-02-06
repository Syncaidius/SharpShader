using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader.Result
{
    public class ShaderMember
    {
        int _stride;
        int _elementCount;

        internal ShaderMember() { }

        /// <summary>
        /// Gets the total size of the member, in bytes. This is equal to <see cref="ElementStride"/> multiplied by <see cref="ElementCount"/>
        /// </summary>
        public int SizeOf { get; private set; }

        /// <summary>
        /// Gets the identifier or name of the element.
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// Gets the stride of the member's element(s), in bytes.
        /// </summary>
        public int ElementStride
        {
            get => _stride;
            internal set
            {
                _stride = value;
                SizeOf = _elementCount * _stride;
            }
        }

        /// <summary>
        /// Gets the offset of the expected value, from the start of it's parent type (e.g. struct, buffer, etc), in bytes.
        /// </summary>
        public int StartOffset { get; internal set; }

        /// <summary>
        /// Gets the size of each dimension in the type. If the type was not a vector, matrix or array, <see cref="Dimensions"/> list will be empty. <para/>
        /// The list is ordered by dimension ID.
        /// </summary>
        public IReadOnlyList<int> Dimensions { get; internal set; }

        /// <summary>
        /// Gets the number of values expected by the current <see cref="ShaderMember"/>. This may be for example, the length of an array, or the number of components in a vector.
        /// </summary>
        public int ElementCount
        {
            get => _elementCount;
            internal set
            {
                _elementCount = value;
                SizeOf = _elementCount * _stride;
            }
        }

        /// <summary>
        /// Gets the primitive data type of the current <see cref="ShaderMember"/>.
        /// </summary>
        public ShaderDataType DataType { get; internal set; }

        /// <summary>
        /// Gets the structure of the element. e.g. A scalar, vector, matrix or array.
        /// </summary>
        public ShaderStructureType StructureType { get; internal set; }
    }
}
