using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    [Serializable]
    internal class MappedConstantBuffer : IPoolable
    {
        /// <summary>
        /// A list of mapped variables contained within the constant buffer.
        /// </summary>
        internal readonly List<MappedField> Variables = new List<MappedField>();

        /// <summary>
        /// Bind spots organised by shader model.
        /// </summary>
        internal readonly HashSet<BindPointInfo> BindSlots = new HashSet<BindPointInfo>();

        /// <summary>
        /// The type of the constant buffer.
        /// </summary>
        [NonSerialized]
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

            Variables.Add(field);
        }

        void IPoolable.Clear()
        {
            foreach (MappedField mField in Variables)
                Pooling.MappedFields.Put(mField);

            Variables.Clear();
            BindSlots.Clear();
        }
    }
}
