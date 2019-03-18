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
    public interface ITexture2DBase<T, LOC, ILOC> : ITextureBaseSampled<T, LOC, ILOC, Int2>
        where T : struct
        where LOC : struct
        where ILOC : struct
    {
        T Gather(TextureSampler sampler, LOC location, Int2 offset);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="offset"></param>
        /// <param name="status">The status of the operation. 
        /// You can't access the status directly; instead, pass the status to the CheckAccessFullyMapped intrinsic function. 
        /// CheckAccessFullyMapped returns TRUE if all values from the corresponding Sample, Gather, or Load operation accessed mapped tiles in a tiled resource. 
        /// If any values were taken from an unmapped tile, CheckAccessFullyMapped returns FALSE.</param>
        /// <returns></returns>
        T Gather(TextureSampler sampler, LOC location, Int2 offset, out uint status);

        T GatherRed(TextureSampler sampler, LOC location, Int2 offset);

        T GatherRed(TextureSampler sampler, LOC location, Int2 offset1, Int2 offset2, Int2 offset3, Int2 offset4);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="offset"></param>
        /// <param name="status">The status of the operation. 
        /// You can't access the status directly; instead, pass the status to the CheckAccessFullyMapped intrinsic function. 
        /// CheckAccessFullyMapped returns TRUE if all values from the corresponding Sample, Gather, or Load operation accessed mapped tiles in a tiled resource. 
        /// If any values were taken from an unmapped tile, CheckAccessFullyMapped returns FALSE.</param>
        /// <returns></returns>
        T GatherRed(TextureSampler sampler, LOC location, Int2 offset, out uint status);

        T GatherRed(TextureSampler sampler, LOC location, Int2 offset1, Int2 offset2, Int2 offset3, Int2 offset4, out uint status);

        T GatherGreen(TextureSampler sampler, LOC location, Int2 offset);

        T GatherGreen(TextureSampler sampler, LOC location, Int2 offset1, Int2 offset2, Int2 offset3, Int2 offset4);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="offset"></param>
        /// <param name="status">The status of the operation. 
        /// You can't access the status directly; instead, pass the status to the CheckAccessFullyMapped intrinsic function. 
        /// CheckAccessFullyMapped returns TRUE if all values from the corresponding Sample, Gather, or Load operation accessed mapped tiles in a tiled resource. 
        /// If any values were taken from an unmapped tile, CheckAccessFullyMapped returns FALSE.</param>
        /// <returns></returns>
        T GatherGreen(TextureSampler sampler, LOC location, Int2 offset, out uint status);

        T GatherGreen(TextureSampler sampler, LOC location, Int2 offset1, Int2 offset2, Int2 offset3, Int2 offset4, out uint status);

        T GatherBlue(TextureSampler sampler, LOC location, Int2 offset);

        T GatherBlue(TextureSampler sampler, LOC location, Int2 offset1, Int2 offset2, Int2 offset3, Int2 offset4);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="offset"></param>
        /// <param name="status">The status of the operation. 
        /// You can't access the status directly; instead, pass the status to the CheckAccessFullyMapped intrinsic function. 
        /// CheckAccessFullyMapped returns TRUE if all values from the corresponding Sample, Gather, or Load operation accessed mapped tiles in a tiled resource. 
        /// If any values were taken from an unmapped tile, CheckAccessFullyMapped returns FALSE.</param>
        /// <returns></returns>
        T GatherBlue(TextureSampler sampler, LOC location, Int2 offset, out uint status);

        T GatherBlue(TextureSampler sampler, LOC location, Int2 offset1, Int2 offset2, Int2 offset3, Int2 offset4, out uint status);

        T GatherAlpha(TextureSampler sampler, LOC location, Int2 offset);

        T GatherAlpha(TextureSampler sampler, LOC location, Int2 offset1, Int2 offset2, Int2 offset3, Int2 offset4);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="offset"></param>
        /// <param name="status">The status of the operation. 
        /// You can't access the status directly; instead, pass the status to the CheckAccessFullyMapped intrinsic function. 
        /// CheckAccessFullyMapped returns TRUE if all values from the corresponding Sample, Gather, or Load operation accessed mapped tiles in a tiled resource. 
        /// If any values were taken from an unmapped tile, CheckAccessFullyMapped returns FALSE.</param>
        /// <returns></returns>
        T GatherAlpha(TextureSampler sampler, LOC location, Int2 offset, out uint status);

        T GatherAlpha(TextureSampler sampler, LOC location, Int2 offset1, Int2 offset2, Int2 offset3, Int2 offset4, out uint status);

        Vector4 GatherCmp(TextureComparisonSampler sampler, LOC location, float compareValue, Int2 offset);

        Vector4 GatherCmp(TextureComparisonSampler sampler, LOC location, float compareValue, Int2 offset, out uint status);

        T GatherCmpRed(TextureSampler sampler, LOC location, float compareValue, Int2 offset);

        T GatherCmpRed(TextureSampler sampler, LOC location, float compareValue, Int2 offset1, Int2 offset2, Int2 offset3, Int2 offset4);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="offset"></param>
        /// <param name="status">The status of the operation. 
        /// You can't access the status directly; instead, pass the status to the CheckAccessFullyMapped intrinsic function. 
        /// CheckAccessFullyMapped returns TRUE if all values from the corresponding Sample, Gather, or Load operation accessed mapped tiles in a tiled resource. 
        /// If any values were taken from an unmapped tile, CheckAccessFullyMapped returns FALSE.</param>
        /// <returns></returns>
        T GatherCmpRed(TextureSampler sampler, LOC location, float compareValue, Int2 offset, out uint status);

        T GatherCmpRed(TextureSampler sampler, LOC location, float compareValue, Int2 offset1, Int2 offset2, Int2 offset3, Int2 offset4, out uint status);

        T GatherCmpGreen(TextureSampler sampler, LOC location, float compareValue, Int2 offset);

        T GatherCmpGreen(TextureSampler sampler, LOC location, float compareValue, Int2 offset1, Int2 offset2, Int2 offset3, Int2 offset4);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="offset"></param>
        /// <param name="status">The status of the operation. 
        /// You can't access the status directly; instead, pass the status to the CheckAccessFullyMapped intrinsic function. 
        /// CheckAccessFullyMapped returns TRUE if all values from the corresponding Sample, Gather, or Load operation accessed mapped tiles in a tiled resource. 
        /// If any values were taken from an unmapped tile, CheckAccessFullyMapped returns FALSE.</param>
        /// <returns></returns>
        T GatherCmpGreen(TextureSampler sampler, LOC location, float compareValue, Int2 offset, out uint status);

        T GatherCmpGreen(TextureSampler sampler, LOC location, float compareValue, Int2 offset1, Int2 offset2, Int2 offset3, Int2 offset4, out uint status);

        T GatherCmpBlue(TextureSampler sampler, LOC location, float compareValue, Int2 offset);

        T GatherCmpBlue(TextureSampler sampler, LOC location, float compareValue, Int2 offset1, Int2 offset2, Int2 offset3, Int2 offset4);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="offset"></param>
        /// <param name="status">The status of the operation. 
        /// You can't access the status directly; instead, pass the status to the CheckAccessFullyMapped intrinsic function. 
        /// CheckAccessFullyMapped returns TRUE if all values from the corresponding Sample, Gather, or Load operation accessed mapped tiles in a tiled resource. 
        /// If any values were taken from an unmapped tile, CheckAccessFullyMapped returns FALSE.</param>
        /// <returns></returns>
        T GatherCmpBlue(TextureSampler sampler, LOC location, float compareValue, Int2 offset, out uint status);

        T GatherCmpBlue(TextureSampler sampler, LOC location, float compareValue, Int2 offset1, Int2 offset2, Int2 offset3, Int2 offset4, out uint status);

        T GatherCmpAlpha(TextureSampler sampler, LOC location, float compareValue, Int2 offset);

        T GatherCmpAlpha(TextureSampler sampler, LOC location, float compareValue, Int2 offset1, Int2 offset2, Int2 offset3, Int2 offset4);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="offset"></param>
        /// <param name="status">The status of the operation. 
        /// You can't access the status directly; instead, pass the status to the CheckAccessFullyMapped intrinsic function. 
        /// CheckAccessFullyMapped returns TRUE if all values from the corresponding Sample, Gather, or Load operation accessed mapped tiles in a tiled resource. 
        /// If any values were taken from an unmapped tile, CheckAccessFullyMapped returns FALSE.</param>
        /// <returns></returns>
        T GatherCmpAlpha(TextureSampler sampler, LOC location, float compareValue, Int2 offset, out uint status);

        T GatherCmpAlpha(TextureSampler sampler, LOC location, float compareValue, Int2 offset1, Int2 offset2, Int2 offset3, Int2 offset4, out uint status);

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
        /// <param name="offset"></param>
        /// <returns></returns>
        T SampleCmp(TextureSampler sampler, LOC location, float compareValue, Int2 offset);

        /// <summary>
        /// Samples a texture, using a comparison value to reject samples.
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="compareValue"></param>
        /// <param name="offset"></param>
        /// <param name="clamp"></param>
        /// <returns></returns>
        T SampleCmp(TextureSampler sampler, LOC location, float compareValue, Int2 offset, float clamp);

        /// <summary>
        /// Samples a texture, using a comparison value to reject samples.
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="compareValue"></param>
        /// <param name="offset"></param>
        /// <param name="clamp"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        T SampleCmp(TextureSampler sampler, LOC location, float compareValue, Int2 offset, float clamp, out uint status);

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
        /// <param name="offset"></param>
        /// <returns></returns>
        T SampleCmpLevelZero(TextureSampler sampler, LOC location, float compareValue, Int2 offset);

        /// <summary>
        /// Samples a texture (mipmap level 0 only), using a comparison value to reject samples.
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="compareValue"></param>
        /// <param name="offset"></param>
        /// <param name="clamp"></param>
        /// <returns></returns>
        T SampleCmpLevelZero(TextureSampler sampler, LOC location, float compareValue, Int2 offset, float clamp);

        /// <summary>
        /// Samples a texture (mipmap level 0 only), using a comparison value to reject samples.
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="compareValue"></param>
        /// <param name="offset"></param>
        /// <param name="clamp"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        T SampleCmpLevelZero(TextureSampler sampler, LOC location, float compareValue, Int2 offset, float clamp, out uint status);
    }
}
