using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// Respresents a resource binding within a shader. 
    /// </summary>
    public class ShaderResourceInfo
    {
        /// <summary>
        /// Gets the expected resource type.
        /// </summary>
        public ShaderResourceType ResourceType { get; }

        /// <summary>
        /// Gets the model-specific bind points (slots) for the constant buffer.
        /// </summary>
        public IReadOnlyList<BindPointInfo> BindPoints { get; }

        /// <summary>
        /// Gets the name of the resource variable.
        /// </summary>
        public string Name { get; }

        internal ShaderResourceInfo(string name, ShaderResourceType type, HashSet<BindPointInfo> bindPoints)
        {
            ResourceType = type;
            Name = name;

            var bSlots = new List<BindPointInfo>(bindPoints);
            BindPoints = bSlots.AsReadOnly();
        }
    }
}
