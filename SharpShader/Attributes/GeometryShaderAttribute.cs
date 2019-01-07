using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    [AttributeUsage(AttributeTargets.Method)]
    public class GeometryShaderAttribute : SharpShaderAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inType"></param>
        /// <param name="maxVertexOutCount">The maximum number of output vertices.</param>
        public GeometryShaderAttribute(GeometryInputType inType, uint maxVertexOutCount)
        {
            InputType = inType;
            MaxVertexOutCount = maxVertexOutCount;
        }

        public GeometryInputType InputType { get; }

        uint MaxVertexOutCount { get; }
    }

    public enum GeometryInputType
    {
        /// <summary>
        /// Point list. One input vertex required.
        /// </summary>
        Point = 0,

        /// <summary>
        /// Triangle list or triangle strip. Three input vertices required.
        /// </summary>
        Triangle = 1,

        /// <summary>
        /// Line list or line strip
        /// </summary>
        Line = 2,

        /// <summary>
        /// Line list with adjacency or line strip with adjacency. Adjacency lines have two ends; therefore, require four vertices.
        /// </summary>
        LineWithAdjacency = 3,

        /// <summary>
        /// Triangle list with adjacency or triangle strip with adjacency. Adjacency triangles border with three more triangles; therefore, they requires six input vertices.
        /// </summary>
        TriangleWithAdjacency = 4,
    }
}
