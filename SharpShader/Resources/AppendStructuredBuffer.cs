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
    public interface AppendStructuredBuffer<T> : IShaderResource
    {
        /// <summary>
        /// Gets the length of the buffer.
        /// </summary>
        /// <param name="numStructs">The number of structures.</param>
        /// <param name="stride">The number of bytes in each element.</param>
        void GetDimensions(out uint numStructs, out uint stride);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        void Append(T value);
    }
}
