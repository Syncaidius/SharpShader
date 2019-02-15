using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// Defines the type of a shader resource binding.
    /// </summary>
    public enum ShaderResourceType
    {
        /// <summary>
        /// The resource type is not known.
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// A 1D texture.
        /// </summary>
        Texture1D = 1,

        /// <summary>
        /// A 1D texture array.
        /// </summary>
        Texture1DArray = 2,

        /// <summary>
        /// A 2D tetxure.
        /// </summary>
        Texture2D = 3,

        /// <summary>
        /// A2D texture array.
        /// </summary>
        Texture2DArray = 4,

        /// <summary>
        /// A multisampled 2D texture.
        /// </summary>
        Texture2DMS = 5,

        /// <summary>
        /// A multisampled 2D texture array.
        /// </summary>
        Texture2DArrayMS = 6,

        /// <summary>
        /// A 3D texture.
        /// </summary>
        Texture3D = 7,

        /// <summary>
        /// A 3D texture array.
        /// </summary>
        Texture3DArray = 8,

        /// <summary>
        /// A cubemap texture.s
        /// </summary>
        TextureCube = 9,

        /// <summary>
        /// An array of cubemap textures.
        /// </summary>
        TextureCubeArray = 10,

        /// <summary>
        /// A buffer.
        /// </summary>
        Buffer = 11,

        /// <summary>
        /// A constant/uniform buffer.
        /// </summary>
        ConstantBuffer = 12,

        /// <summary>
        /// A texture sampler.
        /// </summary>
        TextureSampler = 13,

        /// <summary>
        /// A comparison texture sampler.
        /// </summary>
        ComparisonSampler = 14,

        RWTexture1D = 15,

        RWTexture1DArray = 16,

        RWTexture2D = 17,

        RWTexture2DArray = 18,

        RWTexture3D = 19,

        RWTexture3DArray = 20,

        StructuredBuffer = 21,

        ByteAddressBuffer = 22,

        RWBuffer = 23,

        RWStructuredBuffer = 24,

        RWByteAddressBuffer = 25
    }
}
