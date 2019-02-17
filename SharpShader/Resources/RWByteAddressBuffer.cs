using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// A read/write buffer that indexes in bytes.
    /// </summary>
    /// <typeparam name="T">The type of data to store in the buffer.</typeparam>
    [RegisteredType]
    [UnorderedAccessType]
    public interface RWByteAddressBuffer : IShaderResource
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

        /// <summary>
        /// Adds the value, atomically.
        /// </summary>
        /// <param name="dest">The destination address.</param>
        /// <param name="value">The input value.</param>
        /// <param name="originalValue">The original value.</param>
        void InterlockedAdd(uint dest, uint value, out uint originalValue);

        /// <summary>
        /// Ands the value, atomically.
        /// </summary>
        /// <param name="dest">The destination address.</param>
        /// <param name="value">The input value.</param>
        /// <param name="originalValue">The original value.</param>
        void InterlockedAnd(uint dest, uint value, out uint originalValue);

        /// <summary>
        /// Compares the input to the comparison value and exchanges the result, atomically.
        /// </summary>
        /// <param name="dest">The destination address.</param>
        /// <param name="compareValue">The comparison value.</param>
        /// <param name="value">The input value.</param>
        /// <param name="originalValue">The original value.</param>
        void InterlockedCompareExchange(uint dest, uint compareValue, uint value, out uint originalValue);

        /// <summary>
        /// Compares the input to the comparison value, atomically.
        /// </summary>
        /// <param name="dest">The destination address.</param>
        /// <param name="compareValue">The comparison value.</param>
        /// <param name="value">The input value.</param>
        void InterlockedCompareStore(uint dest, uint compareValue, uint value);

        /// <summary>
        /// Exchanges a value, atomically.
        /// </summary>
        /// <param name="dest">The destination address.</param>
        /// <param name="value">The input value.</param>
        /// <param name="originalValue">The original value.</param>
        void InterlockedExchange(uint dest, uint value, out uint originalValue);

        /// <summary>
        /// Finds the maximum value, atomically.
        /// </summary>
        /// <param name="dest">The destination address.</param>
        /// <param name="value">The input value.</param>
        /// <param name="originalValue">The original value.</param>
        void InterlockedMax(uint dest, uint value, out uint originalValue);

        /// <summary>
        /// Finds the minimum value, atomically.
        /// </summary>
        /// <param name="dest">The destination address.</param>
        /// <param name="value">The input value.</param>
        /// <param name="originalValue">The original value.</param>
        void InterlockedMin(uint dest, uint value, out uint originalValue);

        /// <summary>
        /// Performs an atomic OR on the value.
        /// </summary>
        /// <param name="dest">The destination address.</param>
        /// <param name="value">The input value.</param>
        /// <param name="originalValue">The original value.</param>
        void InterlockedOr(uint dest, uint value, out uint originalValue);

        /// <summary>
        /// Performs an atomic XOR on the value.
        /// </summary>
        /// <param name="dest">The destination address.</param>
        /// <param name="value">The input value.</param>
        /// <param name="originalValue">The original value.</param>
        void InterlockedXor(uint dest, uint value, out uint originalValue);

        /// <summary>
        /// Sets one value.
        /// </summary>
        /// <param name="address">The input address in bytes, which must be a multiple of 4.</param>
        /// <param name="value">One input value.</param>
        void Store(uint address, uint value);


        /// <summary>
        /// Sets two values.
        /// </summary>
        /// <param name="address">The input address in bytes, which must be a multiple of 4.</param>
        /// <param name="value">Two input values.</param>
        void Store2(uint address, UInt2 value);

        /// <summary>
        /// Sets three values.
        /// </summary>
        /// <param name="address">The input address in bytes, which must be a multiple of 4.</param>
        /// <param name="value">Three input values.</param>
        void Store3(uint address, UInt3 value);

        /// <summary>
        /// Sets four values.
        /// </summary>
        /// <param name="address">The input address in bytes, which must be a multiple of 4.</param>
        /// <param name="value">Four input values.</param>
        void Store4(uint address, UInt4 value);
    }
}
