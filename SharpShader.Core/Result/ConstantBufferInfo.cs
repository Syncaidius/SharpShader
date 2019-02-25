using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    public class ConstantBufferInfo : ShaderResourceInfo
    {
        /// <summary>
        /// Gets the total size of the constant buffer, in bytes.
        /// </summary>
        public int SizeOf { get; }

        /// <summary>
        /// Gets a list containing all of the variables held in the constant buffer.
        /// </summary>
        public IReadOnlyList<ShaderMember> Variables { get; }

        public ConstantBufferInfo(string name, List<ShaderMember> variables, HashSet<BindPointInfo> bindPoints) :
            base(name, ShaderResourceType.ConstantBuffer, bindPoints)
        {
            Variables = variables.AsReadOnly();
            SizeOf = 0;

            foreach(ShaderMember m in variables)
                SizeOf += m.SizeOf;
        }
    }
}
