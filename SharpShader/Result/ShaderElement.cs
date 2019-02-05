using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader.Result
{
    public class ShaderElement
    {
        int _stride;
        int _indexCount;

        internal ShaderElement(List<int> dimensions = null)
        {
            Dimensions = (dimensions ?? new List<int>()).AsReadOnly();
        }

        /// <summary>
        /// Gets the total size of the element, in bytes. This is equal to <see cref="Stride"/> multiplied by <see cref="IndexCount"/>
        /// </summary>
        public int SizeOf { get; private set; }

        /// <summary>
        /// Gets the stride of the element. This will be different from <see cref="SizeOf"/> if any of <see cref="Dimensions"/> are greater than 1.
        /// </summary>
        public int Stride
        {
            get => _stride;
            internal set
            {
                _stride = value;
                SizeOf = _indexCount * _stride;
            }
        }

        /// <summary>
        /// Gets the offset of the expected value, from the start of it's parent data type, in bytes.
        /// </summary>
        public int StartOffset { get; internal set; }

        /// <summary>
        /// Gets the size of each dimension in the type. If the type was not a vector, matrix or array, <see cref="Dimensions"/> list will be empty. <para/>
        /// The list is ordered by dimension ID.
        /// </summary>
        public IReadOnlyList<int> Dimensions { get; }

        /// <summary>
        /// Gets the number of indices held by the element. e.g. the length of an array, or the number of components in a vector.
        /// </summary>
        public int IndexCount
        {
            get => _indexCount;
            internal set
            {
                _indexCount = value;
                SizeOf = _indexCount * _stride;
            }
        }

        /// <summary>
        /// Gets the full name of the shader type. e.g. float3x3[][].
        /// </summary>
        public ShaderElementType Type { get; internal set; }

        /// <summary>
        /// Gets the structure of the element. i.e. whether the element is a scalar, vector, matrix or array.
        /// </summary>
        public ShaderElementStructure Structure { get; internal set; }
    }

    /// <summary>
    /// The primitive type element's type.
    /// </summary>
    public enum ShaderElementType
    {
        Boolean = 0,

        /// <summary>
        /// A signed byte. 8-bit value.
        /// </summary>
        Int8 = 7,

        /// <summary>
        /// An unsigned byte. 8-bit value.
        /// </summary>
        UInt8 = 8,

        /// <summary>
        /// A signed 16-bit integer.
        /// </summary>
        Int16 = 9,

        /// <summary>
        /// An unsigned 16-bit integer.
        /// </summary>
        UInt16 = 10,

        /// <summary>
        /// A signed 32-bit integer.
        /// </summary>
        Int32 = 11,

        /// <summary>
        /// An unsigned 32-bit integer.
        /// </summary>
        UInt32 = 12,

        /// <summary>
        /// A signed, 64-bit integer.
        /// </summary>
        Int64 = 13,

        /// <summary>
        /// An unsigned 64-bit integer.
        /// </summary>
        UInt64 = 14,

        /// <summary>
        /// A 32-bit signed floating-point value.
        /// </summary>
        Float = 15,

        /// <summary>
        /// A 64-bit signed floating-point value.
        /// </summary>
        Double = 16,

        /// <summary>
        /// A 128-bit signed floating-point value.
        /// </summary>
        Decimal = 17,
    }

    public enum ShaderElementStructure
    {
        Scalar = 0,

        Vector = 1,

        MatrixRowMajor = 2,

        MatrixColumnMajor = 3,

        Array = 4,
    }
}
