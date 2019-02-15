using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// Contains metadata for a shader resource bind point, also known as a resource slot.
    /// </summary>
    [Serializable]
    public readonly struct BindPointInfo
    {
        /// <summary>
        /// Gets the shader model with which the bind point should be used.
        /// </summary>
        public readonly ShaderModel Model;

        /// <summary>
        /// Gets the entry-point for which the bind point should be used.
        /// </summary>
        public readonly EntryPointType EntryPoint;

        /// <summary>
        /// Gets the bind point value.
        /// </summary>
        public readonly int BindPoint;

        internal BindPointInfo(ShaderModel model, EntryPointType epType, int bindPoint)
        {
            Model = model;
            EntryPoint = epType;
            BindPoint = bindPoint;
        }

        public override int GetHashCode()
        {
            return BindPoint | ((int)EntryPoint << 16) | ((int)Model << 24);
        }
    }
}
