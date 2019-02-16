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
    public abstract class RWTexture2DBase<T> : ShaderResource { }

    /// <summary>
    /// A read/write (RW) Texture2D object.
    /// Based on HLSL syntax: https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/sm5-object-rwtexture2d
    /// </summary>
    [RegisteredType]
    [UnorderedAccessType]
    public class RWTexture2D<T> : RWTexture2DBase<T>
        where T : struct
    {
        public void GetDimensions(out uint width, out uint height)
        {
            width = height = 0;
        }

        public void GetDimensions(out float width, out float height)
        {
            width = height = 0;
        }

        /// <summary>
        /// Reads texture data from a RWTexture2D.
        /// </summary>
        /// <param name="location">The texel to load. Contains the XY coordinate and mip map level (0 being the highest resolution mip-map).</param>
        /// <returns></returns>
        public T Load(Int3 location)
        {
            return default;
        }

        /// <summary>
        /// Reads texture data from a RWTexture2D.
        /// </summary>
        /// <param name="location">The texel to load. Contains the XY coordinate and mip map level (0 being the highest resolution mip-map).</param>
        /// <returns></returns>
        public T Load(Int3 location, out uint status)
        {
            status = 0;
            return default;
        }

        /// <summary></summary>
        /// <param name="pos">The index position. Contains the (x, y) coordinates.</param>
        /// <returns></returns>
        public T this[UInt2 pos]
        {
            get => default;
            set => pos = default;
        }
    }
}
