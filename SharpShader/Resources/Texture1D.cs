using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    public class Texture1D : Texture1D<float>{}

    public class Texture1D<T> : Texture1DBase<T, float>
        where T : struct
    {
        public void GetDimensions(out uint mipMapLevel, out uint width, out uint numberOfLevels) { mipMapLevel = width = numberOfLevels = 0; }

        public void GetDimensions(out uint width) { width = 0; }

        public void GetDimensions(out float mipMapLevel, out float width, out float numberOfLevels) { mipMapLevel = width = numberOfLevels = 0; }

        public void GetDimensions(out float width) { width = 0; }

        /// <summary>
        /// Reads texel data without any filtering or sampling.
        /// </summary>
        /// <param name="location">The first component (X) contains the coordinate. The second component (Y) contains the mipmap level.</param>
        /// <returns></returns>
        public T Load(Int2 location) { return default; }

        /// <summary>
        /// Reads texel data without any filtering or sampling.
        /// </summary>
        /// <param name="location">The first component (X) contains the coordinate. The second component (Y) contains the mipmap level.</param>
        /// <param name="offset">An offset applied to the texture coordinates before sampling.</param>
        /// <param name="status">The status of the operation. You can't access the status directly; instead, pass the status to the CheckAccessFullyMapped intrinsic function. 
        /// CheckAccessFullyMapped returns TRUE if all values from the corresponding Sample, Gather, or Load operation accessed mapped tiles in a tiled resource
        /// If any values were taken from an unmapped tile, CheckAccessFullyMapped returns FALSE.</param>
        /// <returns></returns>
        public T Load(Int2 location, int offset, out uint status)
        {
            status = 0;
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public MipMapReadOnlyAccessor<T, int>[] Mips { get; }

        /// <summary>
        /// Returns a read-only value. Always accesses the first mipmap level (0).
        /// </summary>
        /// <param name="pos">The index position. Contains the x-coordinate.</param>
        /// <returns></returns>
        public T this[int pos] => Mips[0][pos];
    }
}
