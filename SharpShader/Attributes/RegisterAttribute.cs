using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Field)]
    public class RegisterAttribute : SharpShaderAttribute
    {
        public uint Slot { get; }

        public RegisterAttribute(uint slot)
        {
            Slot = slot;
        }

        internal static void Parse(AttributeSyntax syntax, out uint? register)
        {
            register = null;
            if (syntax.ArgumentList.Arguments.Count > 0)
            {
                if (uint.TryParse(syntax.ArgumentList.Arguments[0].ToString(), out uint val))
                    register = val;
            }
        }
    }

    /// <summary>
    /// Used for tagging types as compatible with <see cref="RegisterAttribute"/>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    internal class RegisteredTypeAttribute : SharpShaderAttribute { }
}
