using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    public enum EntryPointType
    {
        AnyOrNone = 0,

        VertexShader = 1,

        FragmentShader = 2,

        GeometryShader = 3,

        HullShader = 4,

        DomainShader = 5,

        ComputeShader = 6,
    }
}
