using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// An element's primitive data type.
    /// </summary>
    public enum ShaderDataType
    {
        /// <summary>
        /// The data type is unknown.
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// A boolean value, usually equivilent to 1 byte in size.
        /// </summary>
        Boolean = 1,

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
}
