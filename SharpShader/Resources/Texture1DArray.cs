using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    public class Texture1DArray<T> : Texture1DBase<T, Vector2, UInt3>
        where T : struct
    {
        public void GetDimensions(
            out uint mipMapLevel,
            out uint width,
            out uint elements,
            out uint numberOfLevels)
        { mipMapLevel = width = elements = numberOfLevels = 0; }

        public void GetDimensions(out uint width, out uint elements)
        { width = elements = 0; }

        public void GetDimensions(out float mipMapLevel, out float width, out float elements, out float numberOfLevels)
        { mipMapLevel = width = elements = numberOfLevels = 0; }

        public void GetDimensions(out float width, out float elements)
        { width = elements = 0; }
    }
}
