using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// A read/write buffer that can take a T type that is a structure.
    /// </summary>
    /// <typeparam name="T">The type of data to store in the buffer.</typeparam>
    [RegisteredType]
    [UnorderedAccessType]
    public interface RWStructuredBuffer<T> : IShaderResource where T : struct
    {
        /// <summary>
        /// Decrements the object's hidden counter and the post-decremented counter value.
        /// </summary>
        /// <returns>The post-decremented counter value.</returns>
        /// <remarks>The bound unordered access view must have D3D11_BUFFER_UAV_FLAG_COUNTER set during creation for this method to work. <para/>
        /// A structured resource can be further indexed based on the component names of the structures.
        /// </remarks>
        uint DecrementCounter();

        /// <summary>
        /// Increments the object's hidden counter and the post-decremented counter value.
        /// </summary>
        /// <returns>The pre-incremented counter value.</returns>
        /// <remarks>The bound unordered access view must have D3D11_BUFFER_UAV_FLAG_COUNTER set during creation for this method to work. <para/>
        /// A structured resource can be further indexed based on the component names of the structures.
        /// </remarks>
        uint IncrementCounter();

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
        /// Gets or sets the value at the specified index.
        /// </summary>
        /// <param name="index">The element index.</param>
        /// <returns></returns>
        T this[uint index] { get; set; }
    }
}
