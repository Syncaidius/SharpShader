using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class ShaderIntrinsicAttribute : SharpShaderAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="language">The shader language that the intrinsic belongs to.</param>
        /// <param name="name">The name of the intrinsic in it's native shader language.</param>
        internal ShaderIntrinsicAttribute(OutputLanguage language, string name)
        {
            Language = language;
            NativeName = name;
        }

        /// <summary>
        /// Gets the shader language that the intrinsic is part of.
        /// </summary>
        public OutputLanguage Language { get; }

        /// <summary>
        /// Gets the name of the intrinsic function in it's native shader language.
        /// </summary>
        public string NativeName { get; }
    }
}
