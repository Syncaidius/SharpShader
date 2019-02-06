using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class ConstantBufferMap
    {
        /// <summary>
        /// 
        /// </summary>
        internal readonly Dictionary<ShaderModel, int> BindSlots = new Dictionary<ShaderModel, int>();

        /// <summary>
        /// The type of the constant buffer.
        /// </summary>
        internal Type TypeInfo;

        internal readonly List<MappedVariable> Variables = new List<MappedVariable>();
    }
}
