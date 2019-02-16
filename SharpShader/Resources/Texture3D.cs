using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    [RegisteredType]
    public class Texture3D : Texture3D<Vector4> { }

    /// <summary>
    /// An untyped texture object for backwards compatibility.
    /// Based on HLSL syntax: https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/sm5-object-texture2d
    /// </summary>
    [RegisteredType]
    public class Texture3D<T>  : TextureBaseSampled<T, Vector3, UInt3, Int3>
        where T : struct
    {
        public T SampleBias(TextureSampler sampler, Vector3 location, float bias) { return default(T); }

        public T SampleBias(TextureSampler sampler, Vector3 location, float bias, Int3 offset) { return default(T); }

        public T SampleBias(TextureSampler sampler, Vector3 location, float bias, Int3 offset, float clamp) { return default(T); }

        public T SampleBias(TextureSampler sampler, Vector3 location, float bias, Int3 offset, float clamp, out uint status) { status = 0; return default(T); }


        /// <summary>
        /// Samples a texture, using a comparison value to reject samples.
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="compareValue"></param>
        /// <returns></returns>
        public T SampleCmp(TextureSampler sampler, Vector3 location, float compareValue) { return default(T); }

        /// <summary>
        /// Samples a texture, using a comparison value to reject samples.
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="compareValue"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        public T SampleCmp(TextureSampler sampler, Vector3 location, float compareValue, Int3 offset) { return default(T); }

        /// <summary>
        /// Samples a texture, using a comparison value to reject samples.
        /// </summary>
        /// <param name="sampler"></param>
        /// <param name="location"></param>
        /// <param name="compareValue"></param>
        /// <param name="offset"></param>
        /// <param name="clamp"></param>
        /// <returns></returns>
        public T SampleCmp(TextureSampler sampler, Vector3 location, float compareValue, Int3 offset, float clamp) { return default(T); }

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
        public T SampleCmp(TextureSampler sampler, Vector3 location, float compareValue, Int3 offset, float clamp, out uint status) { status = 0; return default(T); }

        public T SampleGrad(TextureSampler sampler, Vector3 location, float ddx, float ddy) { return default(T); }

        public T SampleGrad(TextureSampler sampler, Vector3 location, float ddx, float ddy, Int3 offset) { return default(T); }

        public T SampleGrad(TextureSampler sampler, Vector3 location, float ddx, float ddy, Int3 offset, float clamp) { return default(T); }

        public T SampleGrad(TextureSampler sampler, Vector3 location, float ddx, float ddy, Int3 offset, float clamp, out uint status) { status = 0; return default(T); }

        public T SampleLevel(TextureSampler sampler, Vector3 location, float lod) { return default(T); }

        public T SampleLevel(TextureSampler sampler, Vector3 location, float lod, Int3 offset) { return default(T); }

        public T SampleLevel(TextureSampler sampler, Vector3 location, float lod, Int3 offset, float clamp) { return default(T); }

        public T SampleLevel(TextureSampler sampler, Vector3 location, float lod, Int3 offset, float clamp, out uint status) { status = 0; return default(T); }
    }
}
