using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    [Serializable]
    internal class MappedField : IPoolable
    {
        internal List<int> ArrayDimensions { get; } = new List<int>();

        internal ShaderStructureType StructureType { get; private set; }

        internal ShaderResourceType ResourceType { get; private set; }

        internal ShaderResourceBaseType ResourceBaseType { get; private set; }

        internal ShaderType Type { get; private set; }

        internal string Name { get; private set; }

        internal int? PackOffsetBytes;

        [field: NonSerialized]
        internal FieldInfo Info { get; private set; }

        [field: NonSerialized]
        internal IEnumerable<Attribute> Attributes { get; private set; }

        internal virtual void Initialize(ShaderType type, FieldInfo info)
        {
            Type = type;
            Attributes = info.GetCustomAttributes();
            Info = info;
            Name = info.Name;

            if (type.IsMatrix)
            {
                if (Attributes.Any(x => x is RowMajorAttribute))
                    StructureType = ShaderStructureType.MatrixRowMajor;
                else if (Attributes.Any(x => x is ColumnMajorAttribute))
                    StructureType = ShaderStructureType.MatrixColumnMajor;
                else
                    StructureType = ShaderStructureType.MatrixDefaultMajor;

            }
            else if (type.IsVector)
            {
                StructureType = ShaderStructureType.Vector;
            }
            else if (type.Dimensions.Count == 1 && type.Dimensions[0] == 1)
            {
                StructureType = ShaderStructureType.Scalar;
            }
            else if (type.OriginalType.IsValueType)
            {
                ConstantBufferAttribute attConstBuffer = type.OriginalType.GetCustomAttribute<ConstantBufferAttribute>();
                if (attConstBuffer != null)
                    ResourceType = ShaderResourceType.ConstantBuffer;
            }
            else if (!type.OriginalType.IsValueType)
            {
                // TODO Improve this
                StructureType = ShaderStructureType.Class;
                if (typeof(IShaderResource).IsAssignableFrom(type.OriginalType))
                    (ResourceType, ResourceBaseType) = ShaderResource.GetResourceType(type.OriginalType);
                else
                    return;
            }
        }

        public virtual void Clear()
        {
            ArrayDimensions.Clear();
            Type = null;
            Info = null;
            PackOffsetBytes = null;
            Attributes = null;
            Name = null;
        }

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
        internal int GetTotalArrayElements()
        {
            int elements = 1;
            for (int i = 0; i < ArrayDimensions.Count; i++)
                elements *= ArrayDimensions[i];

            return elements;
        }
    }
}
