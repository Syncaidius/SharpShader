using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader.Result
{
    public class ConstantBufferInfo
    {
        /// <summary>
        /// Gets the name of the constant buffer.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the total size of the constant buffer, in bytes.
        /// </summary>
        public int SizeOf { get; }

        /// <summary>
        /// Gets the model-specific bind points (slots) for the constant buffer.
        /// </summary>
        public IReadOnlyList<BindPointInfo> BindPoints { get; }

        /// <summary>
        /// Gets a list containing all of the variables held in the constant buffer.
        /// </summary>
        public IReadOnlyList<ShaderMember> Variables { get; }

        internal ConstantBufferInfo(string name, ConstantBufferMap map)
        {
            Name = name;

            List<ShaderMember> variables = new List<ShaderMember>();
            Variables = variables.AsReadOnly();

            var bSlots = new List<BindPointInfo>(map.BindSlots);
            BindPoints = bSlots.AsReadOnly();

            foreach(MappedField mField in map.Fields)
            {
                List<int> elementDimensions = new List<int>(mField.Type.Dimensions);

                ShaderMember e = new ShaderMember()
                {
                    ArrayDimensions = new List<int>(mField.ArrayDimensions).AsReadOnly(),
                    ElementCount = mField.GetTotalArrayElements(),
                    StartOffset = mField.PackOffsetBytes.Value,
                    StructureType = mField.StructureType,
                    ElementInfo = new ShaderElementInfo()
                    {
                        DataType = mField.Type.DataType,
                        Dimensions = elementDimensions.AsReadOnly(),
                        SizeOf = mField.Type.SizeOf,
                        SubElementCount = mField.Type.SubElementCount,
                        SubElementSizeOf = mField.Type.SubElementSizeOf,                        
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
