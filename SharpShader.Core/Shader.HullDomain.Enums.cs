using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// The patch type of a hull or domain shader.
    /// </summary>
    public enum PatchType
    {
        Triangle = 0,

        Quad = 1,

        Isoline = 2,
    }

    /// <summary>
    /// The partitioning of a hull shader.
    /// </summary>
    public enum HullPartitioning
    {
        Integer = 0,

        FractionalEven = 1,

        FractionalOdd = 2,

        PowerOfTwo = 3,
    }

    public enum HullOutputTopology
    {
        Point = 0,

        Line = 1,

        /// <summary>
        /// Clockwise triangle.
        /// </summary>
        TriangleCW = 2,

        /// <summary>
        /// Counter-clockwise triangle.
        /// </summary>
        TriangleCCW = 3,
    }
}
