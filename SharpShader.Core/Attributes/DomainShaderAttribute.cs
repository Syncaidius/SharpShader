using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    [AttributeUsage(AttributeTargets.Method)]
    public class DomainShaderAttribute : EntryPointAttribute
    {
        /// <summary>
        /// Creates a new instance of <see cref="DomainShaderAttribute"/>
        /// </summary>
        /// <param name="pType">The patch type.</param>
        public DomainShaderAttribute(PatchType pType)
        {
            PatchType = pType;
        }

        /// <summary>
        /// Gets the patch type.
        /// </summary>
        public PatchType PatchType { get; }

        public override EntryPointType EntryType => EntryPointType.DomainShader;
    }
}
