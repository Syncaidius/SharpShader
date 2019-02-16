using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    public class Texture1DBase<T, LOC, ILOC> : TextureBaseSampled<T, LOC, ILOC, int>
        where T : struct
        where LOC : struct
        where ILOC : struct
    {
        public T SampleBias(TextureSampler sampler, LOC location, float bias) { return default(T); }

        public T SampleBias(TextureSampler sampler, LOC location, float bias, int offset) { return default(T); }

        public T SampleBias(TextureSampler sampler, LOC location, float bias, int offset, float clamp) { return default(T); }

        public T SampleBias(TextureSampler sampler, LOC location, float bias, int offset, float clamp, out uint status) { status = 0; return default(T); }


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
        public T SampleCmp(TextureSampler sampler, LOC location, float compareValue, int offset) { return default(T); }

        /// <summary>
        /// Samples a texture, using a comparison value to reject samples.
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="compareValue"></param>
        /// <param name="offset"></param>
        /// <param name="clamp"></param>
        /// <returns></returns>
        public T SampleCmp(TextureSampler sampler, LOC location, float compareValue, int offset, float clamp) { return default(T); }

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
        public T SampleCmp(TextureSampler sampler, LOC location, float compareValue, int offset, float clamp, out uint status) { status = 0; return default(T); }

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
        public T SampleCmpLevelZero(TextureSampler sampler, LOC location, float compareValue, int offset) { return default(T); }

        /// <summary>
        /// Samples a texture (mipmap level 0 only), using a comparison value to reject samples.
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="compareValue"></param>
        /// <param name="offset"></param>
        /// <param name="clamp"></param>
        /// <returns></returns>
        public T SampleCmpLevelZero(TextureSampler sampler, LOC location, float compareValue, int offset, float clamp)
        { return default(T); }

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
        public T SampleCmpLevelZero(TextureSampler sampler, LOC location, float compareValue, int offset, float clamp, out uint status)
        { status = 0; return default(T); }

        public T SampleGrad(TextureSampler sampler, LOC location, float ddx, float ddy) { return default(T); }

        public T SampleGrad(TextureSampler sampler, LOC location, float ddx, float ddy, int offset) { return default(T); }

        public T SampleGrad(TextureSampler sampler, LOC location, float ddx, float ddy, int offset, float clamp) { return default(T); }

        public T SampleGrad(TextureSampler sampler, LOC location, float ddx, float ddy, int offset, float clamp, out uint status) { status = 0; return default(T); }

        public T SampleLevel(TextureSampler sampler, LOC location, float lod) { return default(T); }

        public T SampleLevel(TextureSampler sampler, LOC location, float lod, int offset) { return default(T); }

        public T SampleLevel(TextureSampler sampler, LOC location, float lod, int offset, float clamp) { return default(T); }

        public T SampleLevel(TextureSampler sampler, LOC location, float lod, int offset, float clamp, out uint status) { status = 0; return default(T); }
    }
}
