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
                List<int> elementDimensions = new List<int>(mField.Type.Dimensions);

                ShaderMember e = new ShaderMember()
                {
                    ArrayDimensions = new List<int>(mField.ArrayDimensions).AsReadOnly(),
                    ElementCount = mField.GetTotalArrayElements(),
                    StartOffset = mField.PackOffsetBytes.Value,
                    ElementInfo = new ShaderElementInfo()
                    {
                        DataType = mField.Type.DataType,
                        Dimensions = elementDimensions.AsReadOnly(),
                        SizeOf = mField.Type.SizeOf,
                        SubElementCount = mField.Type.SubElementCount,
                        SubElementSizeOf = mField.Type.SubElementSizeOf,
                        StructureType = mField.StructureType,
                    },
                    SizeOf = mField.GetTotalSizeOf(),
                    Name = mField.Name,
                };

                variables.Add(e);
                SizeOf += e.SizeOf;
            }
        }
    }
}
