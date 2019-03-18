using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// A read/write (RW) Texture2D object.
    /// Based on HLSL syntax: https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/sm5-object-rwtexture1d
    /// </summary>
    [RegisteredType]
    [UnorderedAccessType]
    public interface RWTexture1D<T> : IRWTextureBase<T, Int2, uint>
        where T : struct
    {
        void GetDimensions(out uint width);

        void GetDimensions(out float width);
    }
}
