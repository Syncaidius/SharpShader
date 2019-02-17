﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    public interface IStructuredBuffer { }

    /// <summary>
    /// A read-only structured buffer.
    /// </summary>
    /// <typeparam name="T">The type of data to store in the buffer.</typeparam>
    [RegisteredType]
    public interface StructuredBuffer<T> : IStructuredBuffer where T : struct
    {
        /// <summary>
        /// Gets the value at the specified index.
        /// </summary>
        /// <param name="index">The element index.</param>
        /// <returns></returns>
        T this[uint index] { get; }
    }
}