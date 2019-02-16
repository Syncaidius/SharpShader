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
    public abstract class Texture2DBase<T, LOC, ILOC> : TextureBaseSampled<T, LOC, ILOC, Int2>
        where T: struct
        where LOC : struct
        where ILOC : struct
    {
        internal Texture2DBase() { }

        public T Gather(TextureSampler sampler, LOC location, Int2 offset) { return default(T); }

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
        public T Gather(TextureSampler sampler, LOC location, Int2 offset, out uint status) { status = 0;  return default(T); }

        public T GatherRed(TextureSampler sampler, LOC location, Int2 offset) { return default(T); }

        public T GatherRed(TextureSampler sampler, LOC location, Int2 offset1, Int2 offset2, Int2 offset3, Int2 offset4) { return default(T); }

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
        public T GatherRed(TextureSampler sampler, LOC location, Int2 offset, out uint status) { status = 0; return default(T); }

        public T GatherRed(TextureSampler sampler, LOC location, Int2 offset1, Int2 offset2, Int2 offset3, Int2 offset4, out uint status) { status = 0; return default(T); }

        public T GatherGreen(TextureSampler sampler, LOC location, Int2 offset) { return default(T); }

        public T GatherGreen(TextureSampler sampler, LOC location, Int2 offset1, Int2 offset2, Int2 offset3, Int2 offset4) { return default(T); }

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
        public T GatherGreen(TextureSampler sampler, LOC location, Int2 offset, out uint status) { status = 0; return default(T); }

        public T GatherGreen(TextureSampler sampler, LOC location, Int2 offset1, Int2 offset2, Int2 offset3, Int2 offset4, out uint status) { status = 0; return default(T); }

        public T GatherBlue(TextureSampler sampler, LOC location, Int2 offset) { return default(T); }

        public T GatherBlue(TextureSampler sampler, LOC location, Int2 offset1, Int2 offset2, Int2 offset3, Int2 offset4) { return default(T); }

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
        public T GatherBlue(TextureSampler sampler, LOC location, Int2 offset, out uint status) { status = 0; return default(T); }

        public T GatherBlue(TextureSampler sampler, LOC location, Int2 offset1, Int2 offset2, Int2 offset3, Int2 offset4, out uint status) { status = 0; return default(T); }

        public T GatherAlpha(TextureSampler sampler, LOC location, Int2 offset) { return default(T); }

        public T GatherAlpha(TextureSampler sampler, LOC location, Int2 offset1, Int2 offset2, Int2 offset3, Int2 offset4) { return default(T); }

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
        public T GatherAlpha(TextureSampler sampler, LOC location, Int2 offset, out uint status) { status = 0; return default(T); }

        public T GatherAlpha(TextureSampler sampler, LOC location, Int2 offset1, Int2 offset2, Int2 offset3, Int2 offset4, out uint status) { status = 0; return default(T); }

        public Vector4 GatherCmp(TextureComparisonSampler sampler, LOC location, float compareValue, Int2 offset) { return new Vector4(); }

        public Vector4 GatherCmp(TextureComparisonSampler sampler, LOC location, float compareValue, Int2 offset, out uint status) { status = 0;  return new Vector4(); }

        public T GatherCmpRed(TextureSampler sampler, LOC location, float compareValue, Int2 offset) { return default(T); }

        public T GatherCmpRed(TextureSampler sampler, LOC location, float compareValue, Int2 offset1, Int2 offset2, Int2 offset3, Int2 offset4) { return default(T); }

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
        public T GatherCmpRed(TextureSampler sampler, LOC location, float compareValue, Int2 offset, out uint status) { status = 0; return default(T); }

        public T GatherCmpRed(TextureSampler sampler, LOC location, float compareValue, Int2 offset1, Int2 offset2, Int2 offset3, Int2 offset4, out uint status) { status = 0; return default(T); }

        public T GatherCmpGreen(TextureSampler sampler, LOC location, float compareValue, Int2 offset) { return default(T); }

        public T GatherCmpGreen(TextureSampler sampler, LOC location, float compareValue, Int2 offset1, Int2 offset2, Int2 offset3, Int2 offset4) { return default(T); }

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
        public T GatherCmpGreen(TextureSampler sampler, LOC location, float compareValue, Int2 offset, out uint status) { status = 0; return default(T); }

        public T GatherCmpGreen(TextureSampler sampler, LOC location, float compareValue, Int2 offset1, Int2 offset2, Int2 offset3, Int2 offset4, out uint status) { status = 0; return default(T); }

        public T GatherCmpBlue(TextureSampler sampler, LOC location, float compareValue, Int2 offset) { return default(T); }

        public T GatherCmpBlue(TextureSampler sampler, LOC location, float compareValue, Int2 offset1, Int2 offset2, Int2 offset3, Int2 offset4) { return default(T); }

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
        public T GatherCmpBlue(TextureSampler sampler, LOC location, float compareValue, Int2 offset, out uint status) { status = 0; return default(T); }

        public T GatherCmpBlue(TextureSampler sampler, LOC location, float compareValue, Int2 offset1, Int2 offset2, Int2 offset3, Int2 offset4, out uint status) { status = 0; return default(T); }

        public T GatherCmpAlpha(TextureSampler sampler, LOC location, float compareValue, Int2 offset) { return default(T); }

        public T GatherCmpAlpha(TextureSampler sampler, LOC location, float compareValue, Int2 offset1, Int2 offset2, Int2 offset3, Int2 offset4) { return default(T); }

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
        public T GatherCmpAlpha(TextureSampler sampler, LOC location, float compareValue, Int2 offset, out uint status) { status = 0; return default(T); }

        public T GatherCmpAlpha(TextureSampler sampler, LOC location, float compareValue, Int2 offset1, Int2 offset2, Int2 offset3, Int2 offset4, out uint status) { status = 0; return default(T); }

        public T SampleBias(TextureSampler sampler, LOC location, float bias) { return default(T); }

        public T SampleBias(TextureSampler sampler, LOC location, float bias, Int2 offset) { return default(T); }

        public T SampleBias(TextureSampler sampler, LOC location, float bias, Int2 offset, float clamp) { return default(T); }

        public T SampleBias(TextureSampler sampler, LOC location, float bias, Int2 offset, float clamp, out uint status) { status = 0; return default(T); }

        /// <summary>
        /// Samples a texture, using a comparison value to reject samples.
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="compareValue"></param>
        /// <returns></returns>
        public T SampleCmp(TextureSampler sampler, LOC location, float compareValue) { return default(T); }

        /// <summary>
        /// Samples a texture, using a comparison value to reject samples.
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="compareValue"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        public T SampleCmp(TextureSampler sampler, LOC location, float compareValue, Int2 offset) { return default(T); }

        /// <summary>
        /// Samples a texture, using a comparison value to reject samples.
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="compareValue"></param>
        /// <param name="offset"></param>
        /// <param name="clamp"></param>
        /// <returns></returns>
        public T SampleCmp(TextureSampler sampler, LOC location, float compareValue, Int2 offset, float clamp) { return default(T); }

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
        public T SampleCmp(TextureSampler sampler, LOC location, float compareValue, Int2 offset, float clamp, out uint status) { status = 0; return default(T); }

        /// <summary>
        /// Samples a texture (mipmap level 0 only), using a comparison value to reject samples.
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="compareValue"></param>
        /// <returns></returns>
        public T SampleCmpLevelZero(TextureSampler sampler, LOC location, float compareValue) { return default(T); }

        /// <summary>
        /// Samples a texture (mipmap level 0 only), using a comparison value to reject samples.
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="compareValue"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        public T SampleCmpLevelZero(TextureSampler sampler, LOC location, float compareValue, Int2 offset) { return default(T); }

        /// <summary>
        /// Samples a texture (mipmap level 0 only), using a comparison value to reject samples.
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="compareValue"></param>
        /// <param name="offset"></param>
        /// <param name="clamp"></param>
        /// <returns></returns>
        public T SampleCmpLevelZero(TextureSampler sampler, LOC location, float compareValue, Int2 offset, float clamp) { return default(T); }

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
        public T SampleCmpLevelZero(TextureSampler sampler, LOC location, float compareValue, Int2 offset, float clamp, out uint status) { status = 0; return default(T); }

        public T SampleGrad(TextureSampler sampler, LOC location, Vector2 ddx, Vector2 ddy) { return default(T); }

        public T SampleGrad(TextureSampler sampler, LOC location, Vector2 ddx, Vector2 ddy, Int2 offset) { return default(T); }

        public T SampleGrad(TextureSampler sampler, LOC location, Vector2 ddx, Vector2 ddy, Int2 offset, float clamp) { return default(T); }

        public T SampleGrad(TextureSampler sampler, LOC location, Vector2 ddx, Vector2 ddy, Int2 offset, float clamp, out uint status) { status = 0; return default(T); }

        public T SampleLevel(TextureSampler sampler, LOC location, float lod) { return default(T); }

        public T SampleLevel(TextureSampler sampler, LOC location, float lod, Int2 offset) { return default(T); }

        public T SampleLevel(TextureSampler sampler, LOC location, float lod, Int2 offset, float clamp) { return default(T); }

        public T SampleLevel(TextureSampler sampler, LOC location, float lod, Int2 offset, float clamp, out uint status) { status = 0; return default(T); }
    }
}
