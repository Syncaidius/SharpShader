using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    [RegisteredType]
    public interface TextureCubeArray : Texture2D<Vector4> { }

    /// <summary>
    /// An untyped texture object for backwards compatibility.
    /// Based on HLSL syntax: https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/sm5-object-texture2d
    /// </summary>
    [RegisteredType]
    public interface TextureCubeArray<T>  : ITextureCubeBase<T, Vector3>
        where T : struct
    {

    }
}
