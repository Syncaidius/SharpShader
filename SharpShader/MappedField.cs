using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class MappedField
    {
        internal List<int> ArrayDimensions = new List<int>();

        internal ShaderDataType DataType = ShaderDataType.Boolean;

        internal ShaderStructureType StructureType = ShaderStructureType.Unknown;

        internal ShaderType Type;

        internal int? PackOffsetBytes;

        internal FieldInfo Info;

        internal IEnumerable<Attribute> Attributes;

        /// <summary>
        /// Gets the total size of the field, in bytes. <para/>
        /// </summary>
        /// <returns></returns>
        internal int GetTotalSizeOf()
        {
            int elements = 1;
            for (int i = 0; i < ArrayDimensions.Count; i++)
                elements *= ArrayDimensions[i];

            return elements * Type.SizeOf;
        }

        /// <summary>
        /// Gets the total number of elements expected by the field. This is the total number of array elements multiplied by the total number of type elements.
        /// </summary>
        /// <returns></returns>
        internal int GetTotalElements()
        {
            int elements = 1;
            for (int i = 0; i < ArrayDimensions.Count; i++)
                elements *= ArrayDimensions[i];

            return elements * Type.GetTotalElements();
        }
    }
}
