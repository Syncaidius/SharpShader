using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class ConstantBufferStructure : ShaderStructure
    {
        /// <summary>
        /// The constant buffer slot. If -1, the slot will automatically be assigned to the first unassigned constant buffer slot during shader code generation.
        /// </summary>
        public int Slot;

        /// <summary>
        /// The name of the constant buffer.
        /// </summary>
        public string Name;

        public override string ToString()
        {
            return $"{Name} - Slot:{Slot}";
        }
    }
}
