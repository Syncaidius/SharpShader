using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>A base class for SharpShader's texture types.</summary>
    [RegisteredType]
    public abstract class TextureBase : ShaderResource
    {
        internal TextureBase() { }
    }

    public abstract class TextureBaseSampled<T, LOC, ILOC, OFFSET>
        where T : struct
        where LOC : struct
        where ILOC : struct
        where OFFSET : struct
    {
        public T Sample(TextureSampler sampler, LOC location) { return default(T); }

        public T Sample(TextureSampler sampler, LOC location, OFFSET offset) { return default(T); }

        public T Sample(TextureSampler sampler, LOC location, OFFSET offset, float clamp) { return default(T); }

        public T Sample(TextureSampler sampler, LOC location, OFFSET offset, float clamp, out uint status) { status = 0; return default(T); }


        /// <summary>
        /// Reads texel data without any filtering or sampling.
        /// </summary>
        /// <param name="location">The first two components (X,Y) contain the location. The third component (Z) contains the mipmap level.</param>
        /// <returns></returns>
        public T Load(ILOC location) { return default; }

        /// <summary>
        /// Reads texel data without any filtering or sampling.
        /// </summary>
        /// <param name="location">Components are usually ordered by UV, array slice and mipmap level where each applicable.</param>
        /// <param name="offset">An offset applied to the texture coordinates before sampling.</param>
        /// <param name="status">The status of the operation. You can't access the status directly; instead, pass the status to the CheckAccessFullyMapped intrinsic function. 
        /// CheckAccessFullyMapped returns TRUE if all values from the corresponding Sample, Gather, or Load operation accessed mapped tiles in a tiled resource
        /// If any values were taken from an unmapped tile, CheckAccessFullyMapped returns FALSE.</param>
        /// <returns></returns>
        public T Load(ILOC location, OFFSET offset, out uint status)
        {
            status = 0;
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        public MipMapReadOnlyAccessor<T, ILOC>[] Mips { get; }

        /// <summary>
        /// Returns a read-only value. Always accesses the first mipmap level (0).
        /// </summary>
        /// <param name="pos">The index position. The first component contains the x-coordinate. The second component indicates the desired array slice.</param>
        /// <returns></returns>
        public T this[ILOC pos] => Mips[0][pos];
    }

    public class MipMapReadOnlyAccessor<T, LOC> where T : struct
        where LOC : struct
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pos">The index position. The first component contains the x-coordinate. The second component indicates the desired array slice.</param>
        /// <returns></returns>
        public T this[LOC pos] => default;
    }

    public class MipMapAccessor<T, LOC> 
        where T : struct
        where LOC : struct
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pos">The index position. The first component contains the x-coordinate. The second component indicates the desired array slice.</param>
        /// <returns></returns>
        public T this[LOC pos]
        {
            get => default;
            set { }
        }
    }
}
