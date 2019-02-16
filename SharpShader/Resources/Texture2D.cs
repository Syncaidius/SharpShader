using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    [RegisteredType]
    public class Texture2D : Texture2D<Vector4> { }

    /// <summary>
    /// An untyped texture object for backwards compatibility.
    /// Based on HLSL syntax: https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/sm5-object-texture2d
    /// </summary>
    [RegisteredType]
    public class Texture2D<T>  : Texture2DBase<T, Vector2, Int2, Int2>
        where T : struct
    {
        /// <summary>Returns a read-only resource variable. <para/>
        /// Indexed as follows: [mip][x,y]</summary>
        public MipMapReadOnlyAccessor<T, UInt2>[] Mips;

        /// <summary>
        /// This method always accesses the first mip level. To specify other mip levels, use <see cref="Mips"/> method instead.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public T this[UInt2 pos]
        {
            get => Mips[0][pos];
        }

        internal Texture2D() { }

        /// <summary>
        /// Reads texel data without any filtering or sampling.
        /// </summary>
        /// <param name="location">The location of the texture to read. Location is comprised of U, V and mipLevel.</param>
        /// <returns></returns>
        public T Load(Int3 location) { return default(T); }

        /// <summary>
        /// Reads texel data without any filtering or sampling and returns status of the operation.
        /// </summary>
        /// <param name="location">The location of the texture to read. Location is comprised of U, V and mipLevel.</param>
        /// <param name="offset">An offset applied to the texture coordinates before sampling.</param>
        /// <param name="status"></param>
        /// <returns></returns>
        public T Load(Int3 location, int offset, uint status) { status = 0; return default(T); }
    }
}
