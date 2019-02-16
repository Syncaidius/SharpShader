using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    public class Texture1DArray<T> : Texture1DBase<T, Vector2>
        where T : struct
    {
        public void GetDimensions(
            out uint mipMapLevel,
            out uint width,
            out uint elements,
            out uint numberOfLevels)
        { mipMapLevel = width = elements = numberOfLevels = 0; }

        public void GetDimensions(out uint width, out uint elements)
        { width = elements = 0; }

        public void GetDimensions(out float mipMapLevel, out float width, out float elements, out float numberOfLevels)
        { mipMapLevel = width = elements = numberOfLevels = 0; }

        public void GetDimensions(out float width, out float elements)
        { width = elements = 0; }

        /// <summary>
        /// Reads texel data without any filtering or sampling.
        /// </summary>
        /// <param name="location">The first two components (X,Y) contain the location. The third component (Z) contains the mipmap level.</param>
        /// <returns></returns>
        public T Load(Int3 location) { return default; }

        /// <summary>
        /// Reads texel data without any filtering or sampling.
        /// </summary>
        /// <param name="location">The first two components (X,Y) contain the location. The third component (Z) contains the mipmap level.</param>
        /// <param name="offset">An offset applied to the texture coordinates before sampling.</param>
        /// <param name="status">The status of the operation. You can't access the status directly; instead, pass the status to the CheckAccessFullyMapped intrinsic function. 
        /// CheckAccessFullyMapped returns TRUE if all values from the corresponding Sample, Gather, or Load operation accessed mapped tiles in a tiled resource
        /// If any values were taken from an unmapped tile, CheckAccessFullyMapped returns FALSE.</param>
        /// <returns></returns>
        public T Load(Int3 location, Int2 offset, out uint status)
        {
            status = 0;
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public MipMapReadOnlyAccessor<T, Int2>[] Mips { get; }

        /// <summary>
        /// Returns a read-only value. Always accesses the first mipmap level (0).
        /// </summary>
        /// <param name="pos">The index position. The first component contains the x-coordinate. The second component indicates the desired array slice.</param>
        /// <returns></returns>
        public T this[Int2 pos] => Mips[0][pos];
    }
}
