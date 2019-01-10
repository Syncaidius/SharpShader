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
        public FragmentShaderAttribute(SemanticFragmentOutputType type = SemanticFragmentOutputType.None)
        {
            Semantic = type;
        }

        public SemanticFragmentOutputType Semantic { get; }

        public override EntryPointType EntryType => EntryPointType.FragmentShader;
    }
}
