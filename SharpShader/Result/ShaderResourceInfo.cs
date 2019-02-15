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
        internal ShaderResourceType ResourceType { get; }

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

    /// <summary>
    /// Defines the type of a shader resource binding.
    /// </summary>
    public enum ShaderResourceType
    {
        /// <summary>
        /// The resource type is not known.
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// A 1D texture.
        /// </summary>
        Texture1D = 1,

        /// <summary>
        /// A 1D texture array.
        /// </summary>
        Texture1DArray = 2,

        /// <summary>
        /// A 2D tetxure.
        /// </summary>
        Texture2D = 3,

        /// <summary>
        /// A2D texture array.
        /// </summary>
        Texture2DArray = 4,

        /// <summary>
        /// A multisampled 2D texture.
        /// </summary>
        Texture2DMS = 5,

        /// <summary>
        /// A multisampled 2D texture array.
        /// </summary>
        Texture2DArrayMS = 6,

        /// <summary>
        /// A 3D texture.
        /// </summary>
        Texture3D = 7,

        /// <summary>
        /// A 3D texture array.
        /// </summary>
        Texture3DArray = 8,

        /// <summary>
        /// A cubemap texture.s
        /// </summary>
        TextureCube = 9,

        /// <summary>
        /// An array of cubemap textures.
        /// </summary>
        TextureCubeArray = 10,

        /// <summary>
        /// A buffer.
        /// </summary>
        Buffer = 11,

        /// <summary>
        /// A constant/uniform buffer.
        /// </summary>
        ConstantBuffer = 12,
    }
}
