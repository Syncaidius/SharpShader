using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>A base class for SharpShader's texture types.</summary>
    [RegisteredType]
    public interface ITextureBase : IShaderResource
    { }

    public interface ITextureBaseSampled<T, LOC, ILOC, OFFSET> : ITextureBase
        where T : struct
        where LOC : struct
        where ILOC : struct
        where OFFSET : struct
    {
        T Sample(TextureSampler sampler, LOC location) ;

        T Sample(TextureSampler sampler, LOC location, OFFSET offset) ;

        T Sample(TextureSampler sampler, LOC location, OFFSET offset, float clamp) ;

        T Sample(TextureSampler sampler, LOC location, OFFSET offset, float clamp, out uint status);

        T SampleBias(TextureSampler sampler, LOC location, float bias) ;

        T SampleBias(TextureSampler sampler, LOC location, float bias, OFFSET offset) ;

        T SampleBias(TextureSampler sampler, LOC location, float bias, OFFSET offset, float clamp) ;

        T SampleBias(TextureSampler sampler, LOC location, float bias, OFFSET offset, float clamp, out uint status);

        T SampleGrad(TextureSampler sampler, LOC location, float ddx, float ddy) ;

        T SampleGrad(TextureSampler sampler, LOC location, float ddx, float ddy, OFFSET offset) ;

        T SampleGrad(TextureSampler sampler, LOC location, float ddx, float ddy, OFFSET offset, float clamp) ;

        T SampleGrad(TextureSampler sampler, LOC location, float ddx, float ddy, OFFSET offset, float clamp, out uint status);

        T SampleLevel(TextureSampler sampler, LOC location, float lod) ;

        T SampleLevel(TextureSampler sampler, LOC location, float lod, OFFSET offset) ;

        T SampleLevel(TextureSampler sampler, LOC location, float lod, OFFSET offset, float clamp);

        T SampleLevel(TextureSampler sampler, LOC location, float lod, OFFSET offset, float clamp, out uint status);

        /// <summary>
        /// Reads texel data without any filtering or sampling.
        /// </summary>
        /// <param name="location">The first two components (X,Y) contain the location. The third component (Z) contains the mipmap level.</param>
        /// <returns></returns>
        T Load(ILOC location);

        /// <summary>
        /// Reads texel data without any filtering or sampling.
        /// </summary>
        /// <param name="location">Components are usually ordered by UV, array slice and mipmap level where each applicable.</param>
        /// <param name="offset">An offset applied to the texture coordinates before sampling.</param>
        /// <param name="status">The status of the operation. You can't access the status directly; instead, pass the status to the CheckAccessFullyMapped intrinsic function. 
        /// CheckAccessFullyMapped returns TRUE if all values from the corresponding Sample, Gather, or Load operation accessed mapped tiles in a tiled resource
        /// If any values were taken from an unmapped tile, CheckAccessFullyMapped returns FALSE.</param>
        /// <returns></returns>
        T Load(ILOC location, OFFSET offset, out uint status);

        /// <summary>
        /// 
        /// </summary>
        IMipMapReadOnlyAccessor<T, ILOC>[] Mips { get; }

        /// <summary>
        /// Returns a read-only value. Always accesses the first mipmap level (0).
        /// </summary>
        /// <param name="pos">The index position. The first component contains the x-coordinate. The second component indicates the desired array slice.</param>
        /// <returns></returns>
        T this[ILOC pos] { get; }
    }

    public interface IMipMapReadOnlyAccessor<T, LOC> where T : struct
        where LOC : struct
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pos">The index position. The first component contains the x-coordinate. The second component indicates the desired array slice.</param>
        /// <returns></returns>
        T this[LOC pos] { get; }
    }

    public interface IMipMapAccessor<T, LOC> 
        where T : struct
        where LOC : struct
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pos">The index position. The first component contains the x-coordinate. The second component indicates the desired array slice.</param>
        /// <returns></returns>
        T this[LOC pos] { get; set; }
    }
}
