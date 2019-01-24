using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    [AttributeUsage(AttributeTargets.Method)]
    public class FragmentShaderAttribute : EntryPointAttribute
    {
        public FragmentShaderAttribute(SemanticType type = SemanticType.None, int slotID = -1)
        {
            OutputSemantic = type;
            SemanticSlot = slotID;
        }

        public SemanticType OutputSemantic { get; }

        public int SemanticSlot { get; }

        public override EntryPointType EntryType => EntryPointType.FragmentShader;
    }
}
