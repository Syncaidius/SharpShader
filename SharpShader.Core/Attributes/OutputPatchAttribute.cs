using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    public class OutputPatchAttribute : SharpShaderAttribute
    {
        /// <summary>
        /// Gets the size.
        /// </summary>
        public uint Size { get; }

        public OutputPatchAttribute(uint size)
        {
            Size = size;
        }
    }
}
