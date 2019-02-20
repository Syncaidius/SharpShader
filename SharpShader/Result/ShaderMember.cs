using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader.Result
{
    public class ShaderMember
    {
        /// <summary>
        /// Gets information about an individual element within the current <see cref="ShaderMember"/>.
        /// </summary>
        public ShaderElementInfo ElementInfo { get; private set; }

        /// <summary>
        /// Gets the total size of the member, in bytes.
        /// </summary>
        public int SizeOf { get; private set; }

        /// <summary>
        /// Gets the identifier or name of the element.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the offset of the expected value, from the start of it's parent type (e.g. struct, buffer, etc), in bytes.
        /// </summary>
        public int StartOffset { get; private set; }

        /// <summary>
        /// Gets the array size of the current <see cref="ShaderMember"/>. If the member is not an array, this list will be empty.
        /// </summary>
        public IReadOnlyList<int> ArrayDimensions { get; private set; }

        /// <summary>
        /// Gets the resource type of the current <see cref="ShaderMember"/>. <see cref="ShaderResourceType.Unknown"/> is returned if the member is not a resource binding.
        /// </summary>
        public ShaderResourceType ResourceType { get; private set; }

        /// <summary>
        /// Gets the base resource type of the current <see cref="ShaderMember"/>. <see cref="ShaderResourceBaseType.Unknown"/> is returned if the member is not a resource binding.
        /// </summary>
        public ShaderResourceBaseType ResourceBaseType { get; private set; }

        /// <summary>
        /// Gets the number of values expected by the current <see cref="ShaderMember"/>. This may be for example, the length of an array, or the number of components in a vector.
        /// </summary>
        public int ElementCount { get; internal set; }

        internal ShaderMember(MappedField mField)
        {
            List<int> elementDimensions = new List<int>(mField.Type.Dimensions);
            ArrayDimensions = new List<int>(mField.ArrayDimensions).AsReadOnly();

            ElementCount = mField.GetTotalArrayElements();
            StartOffset = mField.PackOffsetBytes.HasValue ? mField.PackOffsetBytes.Value : 0;
            ElementInfo = new ShaderElementInfo()
            {
                DataType = mField.Type.DataType,
                Dimensions = elementDimensions.AsReadOnly(),
                SizeOf = mField.Type.SizeOf,
                SubElementCount = mField.Type.SubElementCount,
                SubElementSizeOf = mField.Type.SubElementSizeOf,
                StructureType = mField.StructureType,
            };
            SizeOf = mField.GetTotalSizeOf();
            Name = mField.Name;
            ResourceType = mField.ResourceType;
            ResourceBaseType = mField.ResourceBaseType;
        }
    }
}
