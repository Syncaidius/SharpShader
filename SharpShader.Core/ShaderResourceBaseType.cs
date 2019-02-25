using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    public enum ShaderResourceBaseType
    {
        Unknown = 0,

        Texture = 1,

        RWTexture = 2,

        Buffer = 3,

        RWBuffer = 4,

        Sampler = 5,
    }
}
