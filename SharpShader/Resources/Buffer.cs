using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// A read-only buffer.
    /// </summary>
    /// <typeparam name="T">The type of data to store in the buffer.</typeparam>
    [RegisteredType]
    [UnorderedAccessType]
    public interface Buffer<T> : IShaderResource where T : struct
    {
        /// <summary>
        /// Gets the length of the buffer.
        /// </summary>
        /// <param name="dim">An output for the dimensions.</param>
        void GetDimensions(out uint dim);

        /// <summary>
        /// Reads buffer data and returns status of the operation
        /// </summary>
        /// <param name="location">The location (index) in the buffer.</param>
        /// <param name="status">An output for the status result.</param>
        /// <returns></returns>
        T Load(int location, out uint status);

        /// <summary>
        /// Reads buffer data.
        /// </summary>
        /// <param name="location">The location (index) in the buffer.</param>
        /// <returns></returns>
        T Load(int location);

        /// <summary>
        /// Gets the value at the specified index.
        /// </summary>
        /// <param name="index">The element index.</param>
        /// <returns></returns>
        T this[uint index] { get; }
    }
}
