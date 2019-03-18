using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    public abstract class GeometryShaderOutStream<T> where T : struct
    {
        /// <summary>
        /// Appends geometry-shader-output data to an existing stream.
        /// </summary>
        /// <param name="value"></param>
        public void Append(T value) { }

        public void RestartStrip() { }
    }
    /// <summary>
    /// Represents a geometry shader line data output stream. 
    /// </summary>
    public class LineStream<T> : GeometryShaderOutStream<T> where T : struct { }

    /// <summary>
    /// Represents a geometry shader triangle data output stream. 
    /// </summary>
    public class TriangleStream<T> : GeometryShaderOutStream<T> where T : struct { }

    /// <summary>
    /// Represents a geometry shader point data output stream. 
    /// </summary>
    public class PointStream<T> : GeometryShaderOutStream<T> where T : struct { }
}
