using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// A read/write (RW) Texture2D array.
    /// Based on HLSL syntax: https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/sm5-object-rwtexture2darray
    /// </summary>
    [RegisteredType]
    [UnorderedAccessType]
    public class RWTexture2DArray<T> : RWTexture2DBase<T>
        where T : struct
    {
        public void GetDimensions(out uint width, out uint height, out uint elements)
        {
            width = height = elements = 0;
        }

        public void GetDimensions(out float width, out float height, out float elements)
        {
            width = height = elements = 0;
        }

        /// <summary>
        /// Reads texture data from a RWTexture2D.
        /// </summary>
        /// <param name="location">The texel to load. Contains the XY coordinate and mip map level (Z), where 0 is the highest resolution mip-map.</param>
        /// <returns></returns>
        public T Load(Int4 location)
        {
            return default;
        }

        /// <summary>
        /// Reads texture data from a RWTexture2D.
        /// </summary>
        /// <param name="location">The texel to load. Contains the XY coordinate, the element ID (Z) and mip map level (W), where 0 is the highest resolution mip-map.</param>
        /// <returns></returns>
        public T Load(Int4 location, out uint status)
        {
            status = 0;
            return default;
        }

        /// <summary></summary>
        /// <param name="pos">The index position. The first and second components contain the (x, y) coordinates. The third component indicates the desired array slice.</param>
        /// <returns></returns>
        public T this[UInt3 pos]
        {
            get => default;
            set => pos = default;
        }
    }
}
