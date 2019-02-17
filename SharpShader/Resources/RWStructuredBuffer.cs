using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// A structured buffer which supports reading and writing (RW).
    /// </summary>
    /// <typeparam name="T">The type of data to store in the buffer.</typeparam>
    [RegisteredType]
    [UnorderedAccessType]
    public interface RWStructuredBuffer<T> : IShaderResource where T : struct
    {
        /// <summary>
        /// Gets or sets the value at the specified index.
        /// </summary>
        /// <param name="index">The element index.</param>
        /// <returns></returns>
        T this[uint index] { get; set; }
    }
}
