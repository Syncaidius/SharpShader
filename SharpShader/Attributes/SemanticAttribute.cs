using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    public class SemanticAttribute : SharpShaderAttribute
    {
        internal SemanticType Semantic { get; }
        internal int Slot { get; }

        public SemanticAttribute(SemanticType semantic, int slot = -1)
        {
            Semantic = semantic;
            Slot = slot;
        }
    }

    public enum SemanticType
    {
        Position = 0,

        Normal = 1,
        
        BiNormal = 2,

        Color = 3,
        
        /// <summary>
        /// Blend indicies.
        /// </summary>
        BlendIndices = 4,

        /// <summary>
        /// Blend weights.
        /// </summary>
        BlendWeight = 5,

        /// <summary>
        /// Transformed vertex position.
        /// </summary>
        PositionT = 6,

        /// <summary>
        /// Point size
        /// </summary>
        PSize = 7,

        Tangent = 8,

        /// <summary>
        /// Texture coordinates
        /// </summary>
        TexCoord = 9,

        /// <summary>
        /// Vertex fog
        /// </summary>
        Fog = 10,

        TessFactor = 11,

        /// <summary>
        /// Floating-point scalar that indicates a back-facing primitive. A negative value faces backwards, while a positive value faces the camera.
        /// </summary>
        VFace = 12,

        /// <summary>
        /// The pixel location (x,y) in screen space. 
        /// To convert a Direct3D 9 shader (that uses this semantic) to a Direct3D 10 and later shader, see Direct3D 9 VPOS and Direct3D 10 SV_Position)
        /// </summary>
        VPos = 13,

        /// <summary>
        /// Output depth
        /// </summary>
        Depth = 14,

        SV_Position = 15,

        SV_ClipDistance = 16,

        SV_CullDistance = 17,

        SV_Coverage = 18,

        SV_DepthGreaterEqual = 19,

        SV_DepthLessEqual = 20,

        SV_DispatchThreadID = 21,

        SV_DomainLocation = 22,

        SV_GroupID = 23,

        SV_GroupIndex = 24,

        SV_GroupThreadID = 25,

        SV_GSInstanceID = 26,

        SV_InnerCoverage = 27,

        SV_InsideTessFactor = 28,

        SV_InstanceID = 29,

        SV_IsFrontFace = 30,

        SV_OutputControlPointID = 31,

        SV_PrimitiveID = 32,

        SV_RenderTargetArrayIndex = 33,

        SV_SampleIndex = 34,

        SV_StencilRef = 35,

        SV_Target = 36,

        SV_TessFactor = 37,

        SV_VertexID = 38,

        SV_ViewportArrayIndex = 39,
    }
}
