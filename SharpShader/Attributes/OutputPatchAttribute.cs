using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    public class OutputPatchAttribute : SharpShaderAttribute
    {
        /// <summary>
        /// Gets the size.
        /// </summary>
        public uint Size { get; }

        public OutputPatchAttribute(uint size)
        {
            Size = size;
        }

        internal static uint? Parse(AttributeSyntax syntax)
        {
            uint? size = null;
            if (syntax.ArgumentList.Arguments.Count > 0)
            {
                if (uint.TryParse(syntax.ArgumentList.Arguments[0].ToString(), out uint s))
                    size = s;
            }

            return size;
        }
    }
}
