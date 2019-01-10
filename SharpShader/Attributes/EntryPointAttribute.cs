using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    public abstract class EntryPointAttribute : SharpShaderAttribute
    {
        public abstract EntryPointType EntryType { get; }
    }
}
