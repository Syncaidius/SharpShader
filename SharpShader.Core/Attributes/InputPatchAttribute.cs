using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    public class InputPatchAttribute : SharpShaderAttribute
    {
        /// <summary>
        /// Gets the size.
        /// </summary>
        public uint Size { get; }

        public InputPatchAttribute(uint size)
        {
            Size = size;
        }
    }
}
