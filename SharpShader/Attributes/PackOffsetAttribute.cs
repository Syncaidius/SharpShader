using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    public class PackOffsetAttribute : SharpShaderAttribute
    {
        internal PackOffsetComponent OffsetComponent { get; }

        internal int OffsetRegister { get; }

        public PackOffsetAttribute(int offsetRegister, PackOffsetComponent offsetComponent = PackOffsetComponent.X)
        {
            OffsetRegister = offsetRegister;
            OffsetComponent = offsetComponent;
        }
    }

    public enum PackOffsetComponent
    {
        /// <summary>
        /// The field will be offset from the start of the register by 0 bytes.
        /// </summary>
        X = 0,

        /// <summary>
        /// The field will be offset from the start of the register by 4 bytes.
        /// </summary>
        Y = 1,

        /// <summary>
        /// The field will be offset from the start of the register by 8 bytes.
        /// </summary>
        Z = 2,

        /// <summary>
        /// The field will be offset from the start of the register by 12 bytes.
        /// </summary>
        W = 3,
    }
}
