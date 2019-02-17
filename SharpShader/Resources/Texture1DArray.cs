using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    public interface Texture1DArray : Texture1DArray<float> { }

    public interface Texture1DArray<T> : ITexture1DBase<T, Vector2, UInt3>
        where T : struct
    {
        void GetDimensions(out uint mipMapLevel, out uint width, out uint elements, out uint numberOfLevels);

        void GetDimensions(out uint width, out uint elements);

        void GetDimensions(out float mipMapLevel, out float width, out float elements, out float numberOfLevels);

        void GetDimensions(out float width, out float elements);
    }
}
