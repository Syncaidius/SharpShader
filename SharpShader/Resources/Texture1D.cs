using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    public interface Texture1D : Texture1D<float>{}

    public interface Texture1D<T> : ITexture1DBase<T, float, uint>
        where T : struct
    {
        void GetDimensions(out uint mipMapLevel, out uint width, out uint numberOfLevels);

        void GetDimensions(out uint width);

        void GetDimensions(out float mipMapLevel, out float width, out float numberOfLevels);

        void GetDimensions(out float width);
    }
}
