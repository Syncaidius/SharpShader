using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    public interface ITexture1DBase<T, LOC, ILOC> : ITextureBaseSampled<T, LOC, ILOC, int>
        where T : struct
        where LOC : struct
        where ILOC : struct
    {
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
        T SampleCmp(TextureSampler sampler, LOC location, float compareValue, int offset);

        /// <summary>
        /// Samples a texture, using a comparison value to reject samples.
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="compareValue"></param>
        /// <param name="offset"></param>
        /// <param name="clamp"></param>
        /// <returns></returns>
        T SampleCmp(TextureSampler sampler, LOC location, float compareValue, int offset, float clamp);

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
        T SampleCmp(TextureSampler sampler, LOC location, float compareValue, int offset, float clamp, out uint status);

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
        T SampleCmpLevelZero(TextureSampler sampler, LOC location, float compareValue, int offset);

        /// <summary>
        /// Samples a texture (mipmap level 0 only), using a comparison value to reject samples.
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="compareValue"></param>
        /// <param name="offset"></param>
        /// <param name="clamp"></param>
        /// <returns></returns>
        T SampleCmpLevelZero(TextureSampler sampler, LOC location, float compareValue, int offset, float clamp);

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
        T SampleCmpLevelZero(TextureSampler sampler, LOC location, float compareValue, int offset, float clamp, out uint status);
    }
}
