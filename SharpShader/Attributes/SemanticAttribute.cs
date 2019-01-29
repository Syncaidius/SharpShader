using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Method)]
    public class SemanticAttribute : SharpShaderAttribute
    {
        internal SemanticType Semantic { get; }
        internal int Slot { get; }

        public SemanticAttribute(SemanticType semantic, int slot = -1)
        {
            Semantic = semantic;
            Slot = slot;
        }
    }
}
