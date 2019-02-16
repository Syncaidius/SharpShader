using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    [RegisteredType]
    public class Texture2DArray : Texture2DArray<Vector4> { }

    /// <summary>
    /// An untyped texture object for backwards compatibility.
    /// Based on HLSL syntax: https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/sm5-object-texture2d
    /// </summary>
    [RegisteredType]
    public class Texture2DArray<T>  : Texture2DBase<T, Vector3, Int3>
        where T : struct
    {
        /// <summary>
        /// Gets the dimensions of a mipmap.
        /// </summary>
        /// <param name="mipLevel">The mip-map level to retrieve dimensions from.</param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="elements">An output for the number of elements.</param>
        /// <param name="numberOfLevels">The number of mipmap levels (requires mipLevel also).</param>
        public void GetDimensions(uint mipLevel, out uint width, out uint height, out uint elements, out uint numberOfLevels)
        { width = height = elements = numberOfLevels = 0; }

        /// <summary>
        /// Gets the dimensions of a mipmap.
        /// </summary>
        /// <param name="mipLevel">The mip-map level to retrieve dimensions from.</param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="elements">An output for the number of elements.</param>
        /// <param name="numberOfLevels">The number of mipmap levels (requires mipLevel also).</param>
        public void GetDimensions(uint mipLevel, out float width, out float height, out float elements, out float numberOfLevels)
        { width = height = elements = numberOfLevels = 0; }

        /// <summary>
        /// Gets the 
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="elements">An output for the number of elements.</param>
        public void GetDimensions(out uint width, out float height, out float elements)
        { width = 0; height = elements = 0f; }

        /// <summary>
        /// Gets the dimensions of the texture's first mipmap (usually the highest-resolution mipmap).
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="elements">An output for the number of elements.</param>
        public void GetDimensions(out float width, out float height, out float elements) { width = height = elements = 0f; }
    }
}
