using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// A base for all types of shader resource, such as textures, buffers and samplers.
    /// </summary>
    internal static class ShaderResource
    {
        static Dictionary<Type, ShaderResourceType> _typeLookup = new Dictionary<Type, ShaderResourceType>()
        {
            [typeof(Texture1D)] = ShaderResourceType.Texture1D,
            [typeof(Texture1D<>)] = ShaderResourceType.Texture1D,
            [typeof(Texture1DArray)] = ShaderResourceType.Texture1DArray,
            [typeof(Texture1DArray<>)] = ShaderResourceType.Texture1DArray,
            [typeof(Texture2DArray)] = ShaderResourceType.Texture2DArray,
            [typeof(Texture2DArray<>)] = ShaderResourceType.Texture2DArray,
            [typeof(Texture3D)] = ShaderResourceType.Texture3D,
            [typeof(Texture3D<>)] = ShaderResourceType.Texture3D,
            [typeof(TextureSampler)] = ShaderResourceType.TextureSampler,
            [typeof(TextureComparisonSampler)] = ShaderResourceType.ComparisonSampler,
            [typeof(Texture2D<>)] = ShaderResourceType.Texture2D,
            [typeof(RWTexture1D<>)] = ShaderResourceType.RWTexture1D,
            [typeof(RWTexture1DArray<>)] = ShaderResourceType.RWTexture1DArray,
            [typeof(RWTexture2D<>)] = ShaderResourceType.RWTexture2D,
            [typeof(RWTexture2DArray<>)] = ShaderResourceType.RWTexture2DArray,
            [typeof(StructuredBuffer<>)] = ShaderResourceType.StructuredBuffer,
            [typeof(RWStructuredBuffer<>)] = ShaderResourceType.RWStructuredBuffer,
            [typeof(RWBuffer<>)] = ShaderResourceType.RWBuffer,
            [typeof(RWByteAddressBuffer)] = ShaderResourceType.RWByteAddressBuffer,
        };

        internal static ShaderResourceType GetResourceType(Type t)
        {
            Type curType = t;
            if (curType.IsGenericType)
                curType = curType.GetGenericTypeDefinition();

            if (_typeLookup.TryGetValue(curType, out ShaderResourceType resourceType))
                return resourceType;

            return ShaderResourceType.Unknown;
        }
    }

    public interface IShaderResource { }
}
