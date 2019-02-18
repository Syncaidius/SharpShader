using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// A read-only buffer that indexes in bytes.
    /// </summary>
    /// <typeparam name="T">The type of data to store in the buffer.</typeparam>
    [RegisteredType]
    [UnorderedAccessType]
    public interface ByteAddressBuffer : IShaderResource
    {
        /// <summary>
        /// Gets the length of the buffer.
        /// </summary>
        /// <param name="dim">An output for the dimensions.</param>
        void GetDimensions(out uint dim);

        /// <summary>
        /// Reads buffer data and returns status of the operation
        /// </summary>
        /// <param name="address">The location (byte index) in the buffer.</param>
        /// <param name="status">An output for the status result.</param>
        /// <returns></returns>
        uint Load(int address, out uint status);

        /// <summary>
        /// Reads buffer data.
        /// </summary>
        /// <param name="address">The location (byte index) in the buffer.</param>
        /// <returns>One value</returns>
        uint Load(int address);

        /// <summary>
        /// Reads buffer data and returns status of the operation
        /// </summary>
        /// <param name="address">The location (byte index) in the buffer.</param>
        /// <param name="status">An output for the status result.</param>
        /// <returns>Two values.</returns>
        UInt2 Load2(uint address, out uint status);

        /// <summary>
        /// Reads buffer data.
        /// </summary>
        /// <param name="address">The location (byte index) in the buffer.</param>
        /// <returns>Two values.</returns>
        UInt2 Load2(uint address);

        /// <summary>
        /// Reads buffer data and returns status of the operation
        /// </summary>
        /// <param name="address">The location (byte index) in the buffer.</param>
        /// <param name="status">An output for the status result.</param>
        /// <returns>Three values.</returns>
        UInt3 Load3(uint address, out uint status);

        /// <summary>
        /// Reads buffer data.
        /// </summary>
        /// <param name="address">The location (byte index) in the buffer.</param>
        /// <returns>Three values.</returns>
        UInt3 Load3(uint address);

        /// <summary>
        /// Reads buffer data and returns status of the operation
        /// </summary>
        /// <param name="address">The location (byte index) in the buffer.</param>
        /// <param name="status">An output for the status result.</param>
        /// <returns>Three values.</returns>
        UInt4 Load4(uint address, out uint status);

        /// <summary>
        /// Reads buffer data.
        /// </summary>
        /// <param name="address">The location (byte index) in the buffer.</param>
        /// <returns>Three values.</returns>
        UInt4 Load4(uint address);
    }
}
