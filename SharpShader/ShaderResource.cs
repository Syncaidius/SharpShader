﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// A base for all types of shader resource, such as textures, buffers and samplers.
    /// </summary>
    public abstract class ShaderResource
    {
        static Dictionary<Type, ShaderResourceType> _typeLookup = new Dictionary<Type, ShaderResourceType>()
        {
            [typeof(Texture2D)] = ShaderResourceType.Texture2D,
            [typeof(Texture2DArray)] = ShaderResourceType.Texture2DArray,
            [typeof(TextureSampler)] = ShaderResourceType.TextureSampler,
            [typeof(TextureComparisonSampler)] = ShaderResourceType.ComparisonSampler,
        };

        internal static ShaderResourceType GetResourceType(Type t)
        {
            Type curType = t;
            while (curType != null)
            {
                if (_typeLookup.TryGetValue(curType, out ShaderResourceType resourceType))
                    return resourceType;

                curType = curType.BaseType;
            }

            return ShaderResourceType.Unknown;
        }
    }
}
