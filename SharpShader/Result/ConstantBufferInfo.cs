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
        /// The name of the constant buffer.
        /// </summary>
        public readonly string Name;

        /// <summary>
        /// The total size of the constant buffer, in bytes.
        /// </summary>
        public readonly int SizeOf;

        /// <summary>
        /// model-specific bind slots for the constant buffer.
        /// </summary>
        public readonly ReadOnlyDictionary<ShaderModel, int> BindSlots;

        public readonly IReadOnlyList<ShaderMember> Variables;

        internal ConstantBufferInfo(string name, ConstantBufferMap map)
        {
            Name = name;

            List<ShaderMember> variables = new List<ShaderMember>();
            Variables = variables.AsReadOnly();

            var bSlots = new Dictionary<ShaderModel, int>(map.BindSlots);
            BindSlots = new ReadOnlyDictionary<ShaderModel, int>(bSlots);

            foreach(MappedField mField in map.Fields)
            {
                ShaderMember e = new ShaderMember()
                {
                    Dimensions = new List<int>(mField.Dimensions).AsReadOnly(),
                    ElementCount = mField.ElementCount,
                    StartOffset = mField.PackOffsetBytes.Value,
                    ElementStride = mField.Type.SizeOf,
                    StructureType = mField.StructureType,
                    DataType = mField.DataType,
                };

                variables.Add(e);
                SizeOf += e.SizeOf;
            }
        }
    }
}
