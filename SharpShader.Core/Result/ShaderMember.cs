using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
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

        public ShaderMember(string name, List<int> arrayDimensions, int elementCount, int startOffset, ShaderElementInfo elementInfo, int sizeOf, ShaderResourceType resType, ShaderResourceBaseType resBaseType)
        {
            Name = name;
            ArrayDimensions = arrayDimensions.AsReadOnly();
            ElementCount = elementCount;
            StartOffset = startOffset;
            ElementInfo = elementInfo;
            SizeOf = sizeOf;
            ResourceType = resType;
            ResourceBaseType = resBaseType;
        }
    }
}
