using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    [AttributeUsage(AttributeTargets.Method)]
    public class ComputeShaderAttribute : EntryPointAttribute
    {
        public override EntryPointType EntryType => EntryPointType.ComputeShader;
    }
}
