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

            foreach(MappedVariable mVar in map.Variables)
            {
                ShaderMember e = new ShaderMember()
                {
                    Dimensions = new List<int>(mVar.Dimensions).AsReadOnly(),
                    ElementCount = mVar.ElementCount,
                    StartOffset = mVar.StartOffset,
                    ElementStride = mVar.ElementStride,
                    StructureType = mVar.StructureType,
                    DataType = mVar.DataType,
                };

                variables.Add(e);
                SizeOf += e.SizeOf;
            }
        }
    }
}
