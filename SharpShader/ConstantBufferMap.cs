using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class ConstantBufferMap : IPoolable
    {
        /// <summary>
        /// A list of mapped variables contained within the constant buffer.
        /// </summary>
        internal readonly List<MappedField> Fields = new List<MappedField>();

        /// <summary>
        /// Bind spots organised by shader model.
        /// </summary>
        internal readonly Dictionary<ShaderModel, int> BindSlots = new Dictionary<ShaderModel, int>();

        /// <summary>
        /// The type of the constant buffer.
        /// </summary>
        internal Type TypeInfo;

        internal int SizeOf { get; private set; }

        internal void AddField(MappedField field)
        {
            int size = field.GetTotalSizeOf();

            if (field.PackOffsetBytes.HasValue)
            {
                int minSize = field.PackOffsetBytes.Value + size;
                SizeOf = Math.Max(minSize, SizeOf);
            }
            else
            {
                field.PackOffsetBytes = SizeOf;
                SizeOf += size;
            }

            Fields.Add(field);
        }

        void IPoolable.Clear()
        {
            foreach (MappedField mField in Fields)
                Pooling.MappedFields.Put(mField);

            Fields.Clear();
            BindSlots.Clear();
        }
    }
}
