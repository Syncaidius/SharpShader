using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Field)]
    public class RegisterAttribute : SharpShaderAttribute
    {
        public RegisterAttribute(uint slot)
        {
            Slot = slot;
        }

        public uint Slot { get; }
    }
}
