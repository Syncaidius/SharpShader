using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    [RegisteredType]
    public interface Texture2D : Texture2D<Vector4> { }

    /// <summary>
    /// An untyped texture object for backwards compatibility.
    /// Based on HLSL syntax: https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/sm5-object-texture2d
    /// </summary>
    [RegisteredType]
    public interface Texture2D<T>  : ITexture2DBase<T, Vector2, UInt2>
        where T : struct
    {
        /// <summary>
        /// Gets the dimensions of a mipmap.
        /// </summary>
        /// <param name="mipLevel">The mip-map level to retrieve dimensions from.</param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="numberOfLevels">The number of mipmap levels (requires mipLevel also).</param>
        void GetDimensions(uint mipLevel, out uint width, out uint height, out uint numberOfLevels);

        /// <summary>
        /// Gets the dimensions of the texture's first mipmap (usually the highest-resolution mipmap).
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        void GetDimensions(out uint width, out uint height);

        /// <summary>
        /// Gets the dimensions of a mipmap.
        /// </summary>
        /// <param name="mipLevel">The mip-map level to retrieve dimensions from.</param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="numberOfLevels">The number of mipmap levels (requires mipLevel also).</param>
        void GetDimensions(uint mipLevel, out float width, out float height, out float numberOfLevels);

        /// <summary>
        /// Gets the dimensions of the texture's first mipmap (usually the highest-resolution mipmap).
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        void GetDimensions(out float width, out float height);
    }
}
