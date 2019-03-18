using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// Used for tagging types as compatible with <see cref="RegisterAttribute"/>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface, Inherited = true)]
    internal class RegisteredTypeAttribute : SharpShaderAttribute { }
}
