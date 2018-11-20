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

        public SemanticAttribute(SemanticType semantic, int slot)
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
    }
}
