using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal partial class ShaderContext
    {
        [Serializable]
        internal class ReflectionInfo
        {
            [NonSerialized]
            internal Type Type;

            internal string Namespace;

            internal Stack<string> NamespaceSegments { get; } = new Stack<string>();
        }
    }
}
