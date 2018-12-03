using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    public class ShaderIntrinsicAttribute : SharpShaderAttribute
    {
        internal ShaderIntrinsicAttribute(ShaderLanguage language)
        {
            Language = language;
        }

        public ShaderLanguage Language { get; }
    }
}
