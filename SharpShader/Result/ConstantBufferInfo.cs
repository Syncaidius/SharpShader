using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader.Result
{
    public class ConstantBufferInfo
    {
        public readonly string Name;

        public readonly int TotalByteSize = 0;

        public readonly int BindSlot = 0;

        public readonly IReadOnlyList<ShaderLayoutElement> Variables;

        internal ConstantBufferInfo(ConstantBufferMap map)
        {
            
        }
    }
}
