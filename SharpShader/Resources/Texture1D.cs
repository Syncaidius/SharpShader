using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    public class Texture1D : Texture1D<float>{}

    public class Texture1D<T> : Texture1DBase<T, float, uint>
        where T : struct
    {
        public void GetDimensions(out uint mipMapLevel, out uint width, out uint numberOfLevels) { mipMapLevel = width = numberOfLevels = 0; }

        public void GetDimensions(out uint width) { width = 0; }

        public void GetDimensions(out float mipMapLevel, out float width, out float numberOfLevels) { mipMapLevel = width = numberOfLevels = 0; }

        public void GetDimensions(out float width) { width = 0; }
    }
}
