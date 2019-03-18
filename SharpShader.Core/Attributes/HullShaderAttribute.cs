using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    [AttributeUsage(AttributeTargets.Method)]
    public class HullShaderAttribute : EntryPointAttribute
    {
        /// <summary>
        /// Creates a new instance of <see cref="DomainShaderAttribute"/>
        /// </summary>
        /// <param name="pType">The patch type.</param>
        /// <param name="partition">The tesselation partitioning scheme to be used in the hull shader</param>
        /// <param name="topology">The expected output topology.</param>
        /// <param name="outputControlPoints">The number of output control points.</param>
        /// <param name="patchConstantMethodName">The name of the method used for calculating patch-constant data.</param>
        public HullShaderAttribute(PatchType pType, HullPartitioning partition, HullOutputTopology topology, int outputControlPoints, string patchConstantMethodName)
        {
            PatchType = pType;
            Partitioning = partition;
            Topology = topology;
            OutputControlPoints = outputControlPoints;
            PatchConstantCallback = patchConstantMethodName;
        }

        /// <summary>
        /// Gets the patch type.
        /// </summary>
        public PatchType PatchType { get; }

        /// <summary>
        /// Gets gets the tesselation partitioning scheme to be used in the hull shader.
        /// </summary>
        public HullPartitioning Partitioning { get; }

        /// <summary>
        /// Gets the expected output topology.
        /// </summary>
        public HullOutputTopology Topology { get; }

        /// <summary>
        /// Gets the number of output control points.
        /// </summary>
        public int OutputControlPoints { get; }

        /// <summary>
        /// Gets the callback used for calculating patch-constant data.
        /// </summary>
        public string PatchConstantCallback { get; }

        public override EntryPointType EntryType => EntryPointType.HullShader;
    }
}
