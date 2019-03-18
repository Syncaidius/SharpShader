using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    public enum SemanticType
    {
        None = -1,

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

        SV_Depth = 19,

        SV_DepthGreaterEqual = 20,

        SV_DepthLessEqual = 21,

        SV_DispatchThreadID = 22,

        SV_DomainLocation = 23,

        SV_GroupID = 24,

        SV_GroupIndex = 25,

        SV_GroupThreadID = 26,

        SV_GSInstanceID = 27,

        SV_InnerCoverage = 28,

        SV_InsideTessFactor = 29,

        SV_InstanceID = 30,

        SV_IsFrontFace = 31,

        SV_OutputControlPointID = 32,

        SV_PrimitiveID = 33,

        SV_RenderTargetArrayIndex = 34,

        SV_SampleIndex = 35,

        SV_StencilRef = 36,

        SV_Target = 37,

        SV_TessFactor = 38,

        SV_VertexID = 39,

        SV_ViewportArrayIndex = 40,
    }
}
