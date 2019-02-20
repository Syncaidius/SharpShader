using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader.Result
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

        internal ConstantBufferInfo(string name, MappedConstantBuffer map) :
            base(name, ShaderResourceType.ConstantBuffer, map.BindSlots)
        {
            List<ShaderMember> variables = new List<ShaderMember>();
            Variables = variables.AsReadOnly();

            foreach(MappedField mField in map.Fields)
            {
                ShaderMember e = new ShaderMember(mField);
                variables.Add(e);
                SizeOf += e.SizeOf;
            }
        }
    }
}
