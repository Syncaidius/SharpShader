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
    public class RWTexture1D<T> : ShaderResource
        where T : struct
    {
        public void GetDimensions(out uint width)
        {
            width = 0;
        }

        public void GetDimensions(out float width)
        {
            width = 0;
        }

        /// <summary>
        /// Reads texture data from a RWTexture2D.
        /// </summary>
        /// <param name="location">The texel to load. Contains the X coordinate and mip map level (0 being the highest resolution mip-map).</param>
        /// <returns></returns>
        public T Load(Int2 location)
        {
            return default;
        }

        /// <summary>
        /// Reads texture data from a RWTexture2D.
        /// </summary>
        /// <param name="location">The texel to load. Contains the X coordinate and mip map level (0 being the highest resolution mip-map).</param>
        /// <returns></returns>
        public T Load(Int2 location, out uint status)
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
