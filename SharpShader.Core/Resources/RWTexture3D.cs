﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// A read/write (RW) Texture2D object.
    /// Based on HLSL syntax: https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/sm5-object-rwtexture2d
    /// </summary>
    [RegisteredType]
    [UnorderedAccessType]
    public interface RWTexture3D<T> : IRWTextureBase<T, Int4, UInt3>
        where T : struct
    {
        void GetDimensions(out uint width, out uint height, out uint depth);

        void GetDimensions(out float width, out float height, out float depth);
    }
}
