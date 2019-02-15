﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader.Result
{
    /// <summary>
    /// Represents an element within a shader.
    /// </summary>
    public class ShaderElementInfo
    {
        /// <summary>
        /// Gets the total size of the element.
        /// </summary>
        public int SizeOf { get; internal set; }

        /// <summary>
        /// Gets the number of sub-elements within the current element.
        /// </summary>
        public int SubElementCount { get; internal set; }

        /// <summary>
        /// Gets the size of an individual sub-element, in bytes. 
        /// </summary>
        public int SubElementSizeOf { get; internal set; }

        /// <summary>
        /// Gets a read-only list containing the dimensions of the element.<para/>
        /// For vectors, this contains only the number of components.<para/>
        /// For matrices, this contains the number of rows followed by the number of columns.<para/>
        /// For arrays, this contains the length of each dimension in the order they were originally declared.
        /// </summary>
        public IReadOnlyList<int> Dimensions { get; internal set; }

        /// <summary>
        /// Gets the primitive data type of the current <see cref="ShaderMember"/>.
        /// </summary>
        public ShaderDataType DataType { get; internal set; }
    }
}
