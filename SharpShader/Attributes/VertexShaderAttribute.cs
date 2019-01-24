using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    [AttributeUsage(AttributeTargets.Method)]
    public class VertexShaderAttribute : EntryPointAttribute
    {
        public VertexShaderAttribute(SemanticType type = SemanticType.None, int slotID = -1)
        {
            OutputSemantic = type;
            SemanticSlot = slotID;
        }

        public SemanticType OutputSemantic { get; }

        public int SemanticSlot { get; }

        public override EntryPointType EntryType => EntryPointType.VertexShader;
    }
}
