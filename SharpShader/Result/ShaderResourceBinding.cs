using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader.Result
{
    public class ShaderResourceBinding
    {
        public readonly ShaderResourceType ResourceType;

        internal ShaderResourceBinding()
        {

        }
    }

    public enum ShaderResourceType
    {
        Unknown = 0,

        Buffer = 1,

        Texture1D = 2,

        Texture1DArray = 3,

        Texture2D = 4,

        Texture2DArray = 5,

        Texture2DMultisampled = 6,

        Texture2DMultisampledArray = 7,

        Texture3D = 8,

        TextureCube = 9,

        TextureCubeArray = 10,

        ExtendedBuffer = 11
    }
}
