using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    public interface IRWTextureBase<T, LOC, INDEXER> : IShaderResource
    {
        /// <summary>
        /// Reads texture data from a RWTexture2D.
        /// </summary>
        /// <param name="location">The texel to load. Contains the XY coordinate and mip map level (0 being the highest resolution mip-map).</param>
        /// <returns></returns>
        T Load(LOC location);

        /// <summary>
        /// Reads texture data from a RWTexture2D.
        /// </summary>
        /// <param name="location">The texel to load. Contains the XY coordinate and mip map level (0 being the highest resolution mip-map).</param>
        /// <returns></returns>
        T Load(LOC location, out uint status);

        /// <summary></summary>
        /// <param name="pos">The index position. Contains the (x, y, z) coordinates.</param>
        /// <returns></returns>
        T this[INDEXER pos] { get; set; }
    }
}
