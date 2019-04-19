using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// A container class for shader entry-point information.
    /// </summary>
    [Serializable]
    public class EntryPointInfo
    {
        /// <summary>
        /// Gets the start index of the entry point function/method, within the source of a <see cref="ShaderTranslationResult"/>.
        /// </summary>
        public int StartIndex { get; set; }

        /// <summary>
        /// Gets the end index of the entry point function/method, within the source of a <see cref="ShaderTranslationResult"/>.
        /// </summary>
        public int EndIndex { get; set; }

        /// <summary>
        /// Gets the number of characters that make up the entry point function/method within the source of a <see cref="ShaderTranslationResult"/>.
        /// </summary>
        public int Length => EndIndex - StartIndex;

        /// <summary>
        /// Gets the name of the entry point function/method.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the type of the entry point.
        /// </summary>
        public EntryPointType Type { get; set; }

        /// <summary>
        /// Gets the compute shader thread-group (or local) size. <para/>
        /// This is only populated with a valid value if <see cref="Type"/> equals <see cref="EntryPointType.ComputeShader"/>.
        /// </summary>
        public Int3 ThreadGroupSize { get; set; }

        /// <summary>
        /// Gets the hull/domain shader patch type.
        /// </summary>
        public PatchType PatchType { get; set; }

        /// <summary>
        /// Gets the number of hull-shader output control points.
        /// </summary>
        public int HullControlPoints { get; set; }

        /// <summary>
        /// Gets the hull shader output topology.
        /// </summary>
        public HullOutputTopology HullTopology { get; set; }

        /// <summary>
        /// Gets the hull shader partitioning.
        /// </summary>
        public HullPartitioning HullPartitioning { get; set; }

        /// <summary>
        /// Gets the hull shader patch-constant callback name.
        /// </summary>
        public string HullPatchConstantCallback { get; set; }

        /// <summary>
        /// Gets the geometry shader input type.
        /// </summary>
        public GeometryInputType GeometryType { get; set; }

        /// <summary>
        /// Gets the maximum output vertices of a geometry shader.
        /// </summary>
        public uint GeometryMaxVertexOut { get; set; }

        /// <summary>
        /// Creates a new instance of <see cref="EntryPointInfo"/>.
        /// </summary>
        public EntryPointInfo() { }
    }
}
