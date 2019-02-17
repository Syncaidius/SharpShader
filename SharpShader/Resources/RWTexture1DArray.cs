using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// A read/write (RW) Texture2D array.
    /// Based on HLSL syntax: https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/sm5-object-rwtexture1darray
    /// </summary>
    [RegisteredType]
    [UnorderedAccessType]
    public interface RWTexture1DArray<T> : IShaderResource
        where T : struct
    {
        void GetDimensions(out uint width, out uint height, out uint elements);

        void GetDimensions(out float width, out float height, out float elements);

        /// <summary>
        /// Reads texture data from a RWTexture2D.
        /// </summary>
        /// <param name="location">The texel to load. Contains the X coordinate. Y contains the mip map level and Z contains the slice index. 0 is the highest resolution mip-map.</param>
        /// <returns></returns>
        T Load(Int3 location);

        /// <summary>
        /// Reads texture data from a RWTexture2D.
        /// </summary>
        /// <param name="location">The texel to load. Contains the X coordinate, the element ID (Y) and mip map level (Z), where 0 is the highest resolution mip-map.</param>
        /// <returns></returns>
        T Load(Int3 location, out uint status);

        /// <summary></summary>
        /// <param name="pos">The index position. The first component contain the X coordinate. The second component indicates the desired array slice.</param>
        /// <returns></returns>
        T this[UInt2 pos] { get; set; }
    }
}
