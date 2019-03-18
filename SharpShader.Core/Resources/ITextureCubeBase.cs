using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>A base class for SharpShader's 2D texture types.</summary>
    /// <typeparam name="T">The texture's template type (it's structural type).</typeparam>
    /// <typeparam name="LOC">The location data type.</typeparam>
    [RegisteredType]
    public interface ITextureCubeBase<T, LOC> : ITextureBase
        where T : struct
        where LOC : struct
    {
        T Gather(TextureSampler sampler, LOC location);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="status">The status of the operation. 
        /// You can't access the status directly; instead, pass the status to the CheckAccessFullyMapped intrinsic function. 
        /// CheckAccessFullyMapped returns TRUE if all values from the corresponding Sample, Gather, or Load operation accessed mapped tiles in a tiled resource. 
        /// If any values were taken from an unmapped tile, CheckAccessFullyMapped returns FALSE.</param>
        /// <returns></returns>
        T Gather(TextureSampler sampler, LOC location, out uint status);

        T GatherRed(TextureSampler sampler, LOC location);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="status">The status of the operation. 
        /// You can't access the status directly; instead, pass the status to the CheckAccessFullyMapped intrinsic function. 
        /// CheckAccessFullyMapped returns TRUE if all values from the corresponding Sample, Gather, or Load operation accessed mapped tiles in a tiled resource. 
        /// If any values were taken from an unmapped tile, CheckAccessFullyMapped returns FALSE.</param>
        /// <returns></returns>
        T GatherRed(TextureSampler sampler, LOC location, out uint status);

        T GatherGreen(TextureSampler sampler, LOC location);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="status">The status of the operation. 
        /// You can't access the status directly; instead, pass the status to the CheckAccessFullyMapped intrinsic function. 
        /// CheckAccessFullyMapped returns TRUE if all values from the corresponding Sample, Gather, or Load operation accessed mapped tiles in a tiled resource. 
        /// If any values were taken from an unmapped tile, CheckAccessFullyMapped returns FALSE.</param>
        /// <returns></returns>
        T GatherGreen(TextureSampler sampler, LOC location, out uint status);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="status">The status of the operation. 
        /// You can't access the status directly; instead, pass the status to the CheckAccessFullyMapped intrinsic function. 
        /// CheckAccessFullyMapped returns TRUE if all values from the corresponding Sample, Gather, or Load operation accessed mapped tiles in a tiled resource. 
        /// If any values were taken from an unmapped tile, CheckAccessFullyMapped returns FALSE.</param>
        /// <returns></returns>
        T GatherBlue(TextureSampler sampler, LOC location, out uint status);

        T GatherAlpha(TextureSampler sampler, LOC location);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="status">The status of the operation. 
        /// You can't access the status directly; instead, pass the status to the CheckAccessFullyMapped intrinsic function. 
        /// CheckAccessFullyMapped returns TRUE if all values from the corresponding Sample, Gather, or Load operation accessed mapped tiles in a tiled resource. 
        /// If any values were taken from an unmapped tile, CheckAccessFullyMapped returns FALSE.</param>
        /// <returns></returns>
        T GatherAlpha(TextureSampler sampler, LOC location, out uint status);

        Vector4 GatherCmp(TextureComparisonSampler sampler, LOC location, float compareValue, out uint status);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="compareValue">A value to compare each against each sampled value.</param>
        /// <param name="status">The status of the operation. 
        /// You can't access the status directly; instead, pass the status to the CheckAccessFullyMapped intrinsic function. 
        /// CheckAccessFullyMapped returns TRUE if all values from the corresponding Sample, Gather, or Load operation accessed mapped tiles in a tiled resource. 
        /// If any values were taken from an unmapped tile, CheckAccessFullyMapped returns FALSE.</param>
        /// <returns></returns>
        T GatherCmpRed(TextureSampler sampler, LOC location, float compareValue , out uint status);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="compareValue">A value to compare each against each sampled value.</param>
        /// <param name="status">The status of the operation. 
        /// You can't access the status directly; instead, pass the status to the CheckAccessFullyMapped intrinsic function. 
        /// CheckAccessFullyMapped returns TRUE if all values from the corresponding Sample, Gather, or Load operation accessed mapped tiles in a tiled resource. 
        /// If any values were taken from an unmapped tile, CheckAccessFullyMapped returns FALSE.</param>
        /// <returns></returns>
        T GatherCmpGreen(TextureSampler sampler, LOC location, float compareValue, out uint status);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="compareValue">A value to compare each against each sampled value.</param>
        /// <param name="status">The status of the operation. 
        /// You can't access the status directly; instead, pass the status to the CheckAccessFullyMapped intrinsic function. 
        /// CheckAccessFullyMapped returns TRUE if all values from the corresponding Sample, Gather, or Load operation accessed mapped tiles in a tiled resource. 
        /// If any values were taken from an unmapped tile, CheckAccessFullyMapped returns FALSE.</param>
        /// <returns></returns>
        T GatherCmpBlue(TextureSampler sampler, LOC location, float compareValue, out uint status);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="offset"></param>
        /// <param name="compareValue">A value to compare each against each sampled value.</param>
        /// <param name="status">The status of the operation. 
        /// You can't access the status directly; instead, pass the status to the CheckAccessFullyMapped intrinsic function. 
        /// CheckAccessFullyMapped returns TRUE if all values from the corresponding Sample, Gather, or Load operation accessed mapped tiles in a tiled resource. 
        /// If any values were taken from an unmapped tile, CheckAccessFullyMapped returns FALSE.</param>
        /// <returns></returns>
        T GatherCmpAlpha(TextureSampler sampler, LOC location, float compareValue, out uint status);

        /// <summary>
        /// Samples a texture, using a comparison value to reject samples.
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="compareValue"></param>
        /// <returns></returns>
        T SampleCmp(TextureSampler sampler, LOC location, float compareValue);

        /// <summary>
        /// Samples a texture, using a comparison value to reject samples.
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="compareValue"></param>
        /// <param name="clamp"></param>
        /// <returns></returns>
        T SampleCmp(TextureSampler sampler, LOC location, float compareValue, float clamp);

        /// <summary>
        /// Samples a texture, using a comparison value to reject samples.
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="compareValue"></param>
        /// <param name="clamp"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        T SampleCmp(TextureSampler sampler, LOC location, float compareValue, float clamp, out uint status);

        /// <summary>
        /// Samples a texture (mipmap level 0 only), using a comparison value to reject samples.
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="compareValue"></param>
        /// <returns></returns>
        T SampleCmpLevelZero(TextureSampler sampler, LOC location, float compareValue);

        /// <summary>
        /// Samples a texture (mipmap level 0 only), using a comparison value to reject samples.
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="compareValue"></param>
        /// <param name="clamp"></param>
        /// <returns></returns>
        T SampleCmpLevelZero(TextureSampler sampler, LOC location, float compareValue, float clamp);

        /// <summary>
        /// Samples a texture (mipmap level 0 only), using a comparison value to reject samples.
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="compareValue"></param>
        /// <param name="clamp"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        T SampleCmpLevelZero(TextureSampler sampler, LOC location, float compareValue, float clamp, out uint status);

        T Sample(TextureSampler sampler, LOC location);

        T Sample(TextureSampler sampler, LOC location, float clamp);

        T Sample(TextureSampler sampler, LOC location, float clamp, out uint status);

        T SampleBias(TextureSampler sampler, LOC location, float bias);

        T SampleBias(TextureSampler sampler, LOC location, float bias, float clamp);

        T SampleBias(TextureSampler sampler, LOC location, float bias, float clamp, out uint status);

        T SampleGrad(TextureSampler sampler, LOC location, float ddx, float ddy);

        T SampleGrad(TextureSampler sampler, LOC location, float ddx, float ddy, float clamp);

        T SampleGrad(TextureSampler sampler, LOC location, float ddx, float ddy, float clamp, out uint status);

        T SampleLevel(TextureSampler sampler, LOC location, float lod);

        T SampleLevel(TextureSampler sampler, LOC location, float lod, float clamp);

        T SampleLevel(TextureSampler sampler, LOC location, float lod, float clamp, out uint status);
    }
}
