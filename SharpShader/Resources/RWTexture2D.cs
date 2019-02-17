using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// The base for read/write (RW) Texture2D objects.
    /// Based on HLSL syntax: https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/sm5-object-rwtexture2d
    /// </summary>
    [RegisteredType]
    public interface RWTexture2DBase<T> : IShaderResource { }

    /// <summary>
    /// A read/write (RW) Texture2D object.
    /// Based on HLSL syntax: https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/sm5-object-rwtexture2d
    /// </summary>
    [RegisteredType]
    [UnorderedAccessType]
    public interface RWTexture2D<T> : RWTexture2DBase<T>
        where T : struct
    {
        void GetDimensions(out uint width, out uint height);

        void GetDimensions(out float width, out float height);

        /// <summary>
        /// Reads texture data from a RWTexture2D.
        /// </summary>
        /// <param name="location">The texel to load. Contains the XY coordinate and mip map level (0 being the highest resolution mip-map).</param>
        /// <returns></returns>
        T Load(Int3 location);

        /// <summary>
        /// Reads texture data from a RWTexture2D.
        /// </summary>
        /// <param name="location">The texel to load. Contains the XY coordinate and mip map level (0 being the highest resolution mip-map).</param>
        /// <returns></returns>
        T Load(Int3 location, out uint status);

        /// <summary></summary>
        /// <param name="pos">The index position. Contains the (x, y) coordinates.</param>
        /// <returns></returns>
        T this[UInt2 pos] { get; set; }
    }
}
