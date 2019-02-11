using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    public enum ShaderStructureType
    {
        Unknown = 0,

        Scalar = 1,

        Vector = 2,

        MatrixRowMajor = 3,

        MatrixColumnMajor = 4,

        /// <summary>
        /// Uses the default matrix major layout. Both HLSL and GLSL uses column-major by default, but that can be inverted via '#pragmapack_matrix row_major' in HLSL.
        /// </summary>
        MatrixDefaultMajor = 5,

        Class = 6,
    }
}
