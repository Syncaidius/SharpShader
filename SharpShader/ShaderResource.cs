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
        static Dictionary<Type, (ShaderResourceType, ShaderResourceBaseType)> _typeLookup = new Dictionary<Type, (ShaderResourceType, ShaderResourceBaseType)>()
        {
            // Textures
            [typeof(Texture1D)] = (ShaderResourceType.Texture1D, ShaderResourceBaseType.Texture),
            [typeof(Texture1D<>)] = (ShaderResourceType.Texture1D, ShaderResourceBaseType.Texture),
            [typeof(Texture1DArray)] = (ShaderResourceType.Texture1DArray, ShaderResourceBaseType.Texture),
            [typeof(Texture1DArray<>)] = (ShaderResourceType.Texture1DArray, ShaderResourceBaseType.Texture),
            [typeof(Texture2D)] = (ShaderResourceType.Texture2D, ShaderResourceBaseType.Texture),
            [typeof(Texture2D<>)] = (ShaderResourceType.Texture2D, ShaderResourceBaseType.Texture),
            [typeof(Texture2DArray)] = (ShaderResourceType.Texture2DArray, ShaderResourceBaseType.Texture),
            [typeof(Texture2DArray<>)] = (ShaderResourceType.Texture2DArray, ShaderResourceBaseType.Texture),
            [typeof(Texture3D)] = (ShaderResourceType.Texture3D, ShaderResourceBaseType.Texture),
            [typeof(Texture3D<>)] = (ShaderResourceType.Texture3D, ShaderResourceBaseType.Texture),
            [typeof(TextureCube)] = (ShaderResourceType.TextureCube, ShaderResourceBaseType.Texture),
            [typeof(TextureCube<>)] = (ShaderResourceType.TextureCube, ShaderResourceBaseType.Texture),
            [typeof(TextureCubeArray)] = (ShaderResourceType.TextureCubeArray, ShaderResourceBaseType.Texture),
            [typeof(TextureCubeArray<>)] = (ShaderResourceType.TextureCubeArray, ShaderResourceBaseType.Texture),

            // Samplers
            [typeof(TextureSampler)] = (ShaderResourceType.TextureSampler, ShaderResourceBaseType.Sampler),
            [typeof(TextureComparisonSampler)] = (ShaderResourceType.ComparisonSampler, ShaderResourceBaseType.Sampler),

            // Read-Write Textures
            [typeof(RWTexture1D<>)] = (ShaderResourceType.RWTexture1D, ShaderResourceBaseType.RWTexture),
            [typeof(RWTexture1DArray<>)] = (ShaderResourceType.RWTexture1DArray, ShaderResourceBaseType.RWTexture),
            [typeof(RWTexture2D<>)] = (ShaderResourceType.RWTexture2D, ShaderResourceBaseType.RWTexture),
            [typeof(RWTexture2DArray<>)] = (ShaderResourceType.RWTexture2DArray, ShaderResourceBaseType.RWTexture),
            [typeof(RWTexture3D<>)] = (ShaderResourceType.RWTexture3D, ShaderResourceBaseType.RWTexture),

            // Buffers
            [typeof(StructuredBuffer<>)] = (ShaderResourceType.StructuredBuffer, ShaderResourceBaseType.Buffer),
            [typeof(RWStructuredBuffer<>)] = (ShaderResourceType.RWStructuredBuffer, ShaderResourceBaseType.RWBuffer),
            [typeof(Buffer<>)] = (ShaderResourceType.Buffer, ShaderResourceBaseType.Buffer),
            [typeof(RWBuffer<>)] = (ShaderResourceType.RWBuffer, ShaderResourceBaseType.RWBuffer),
            [typeof(ByteAddressBuffer)] = (ShaderResourceType.ByteAddressBuffer, ShaderResourceBaseType.Buffer),
            [typeof(RWByteAddressBuffer)] = (ShaderResourceType.RWByteAddressBuffer, ShaderResourceBaseType.RWBuffer),
            [typeof(AppendStructuredBuffer<>)] = (ShaderResourceType.AppendStructuredBuffer, ShaderResourceBaseType.Buffer)
        };

        internal static (ShaderResourceType type, ShaderResourceBaseType baseType) GetResourceType(Type t)
        {
            Type curType = t;
            if (curType.IsGenericType)
                curType = curType.GetGenericTypeDefinition();

            if (_typeLookup.TryGetValue(curType, out (ShaderResourceType, ShaderResourceBaseType) resourceType))
                return resourceType;

            return (ShaderResourceType.Unknown, ShaderResourceBaseType.Unknown);
        }
    }
}
