using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal abstract partial class ShaderLanguage
    {
        internal class Keyword
        {
            /// <summary>
            /// If true, uniform, multi-dimensional type names will be translated to single-dimension names. For example, Matrix4x4 will translate into Matrix4, Mat4 or Float4.
            /// </summary>
            public bool UniformSizeIsSingular;

            /// <summary>
            /// The word in it's native language.
            /// </summary>
            public string NativeText;
        }
    }
}
