using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    [RegisteredType]
    public interface Texture3D : Texture3D<Vector4> { }

    [RegisteredType]
    public interface Texture3D<T>  : ITextureBaseSampled<T, Vector3, UInt3, Int3>
        where T : struct
    {
        /// <summary>
        /// Samples a texture, using a comparison value to reject samples.
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="compareValue"></param>
        /// <returns></returns>
        T SampleCmp(TextureSampler sampler, Vector3 location, float compareValue);

        /// <summary>
        /// Samples a texture, using a comparison value to reject samples.
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="compareValue"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        T SampleCmp(TextureSampler sampler, Vector3 location, float compareValue, Int3 offset);

        /// <summary>
        /// Samples a texture, using a comparison value to reject samples.
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="compareValue"></param>
        /// <param name="offset"></param>
        /// <param name="clamp"></param>
        /// <returns></returns>
        T SampleCmp(TextureSampler sampler, Vector3 location, float compareValue, Int3 offset, float clamp);
    }
}
