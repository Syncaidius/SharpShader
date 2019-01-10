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
    [RegisteredType]
    public class StructuredBuffer<T> where T : struct
    {
        /// <summary>
        /// Gets the value at the specified index.
        /// </summary>
        /// <param name="index">The element index.</param>
        /// <returns></returns>
        public virtual T this[uint index] => new T();
    }

    /// <summary>
    /// A structured buffer which supports reading and writing (RW).
    /// </summary>
    /// <typeparam name="T">The type of data to store in the buffer.</typeparam>
    [RegisteredType]
    [UnorderedAccess]
    public class RWStructuredBuffer<T> : StructuredBuffer<T> where T : struct 
    {
        /// <summary>
        /// Gets or sets the value at the specified index.
        /// </summary>
        /// <param name="index">The element index.</param>
        /// <returns></returns>
        public new T this[uint index]
        {
            get => base[index];
            set { }
        }
    }
}
