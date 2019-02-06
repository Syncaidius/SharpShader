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

        Array = 5,
    }
}
