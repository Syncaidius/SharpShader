using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// A read-only structured buffer.
    /// </summary>
    /// <typeparam name="T">The type of data to store in the buffer.</typeparam>
    public interface StructuredBuffer<T> : IShaderResource where T : struct
    {
        /// <summary>
        /// Gets the value at the specified index.
        /// </summary>
        /// <param name="index">The element index.</param>
        /// <returns></returns>
        T this[uint index] { get; }
    }
}
