// This is a port of Molten's DX11 sprite batch shaders, for testing Sharp Shader.
// GitHub: https://github.com/Syncaidius/MoltenEngine/blob/617358ded0e109af077a680c6b0168f3485bdb96/Molten.DX11/Assets/sprite_common.mfx

using SharpShader;

namespace SharpShaderSample
{
    class SampleSpriteShader : CSharpShader
    {
        struct VS_GS
        {
            [Semantic(SemanticType.Position, 0)]
            public Vector2 Pos;

            [Semantic(SemanticType.Position, 1)]
            public Vector2 Size;

            [Semantic(SemanticType.Position, 2)]
            public Vector2 Origin;

            [Semantic(SemanticType.Position, 3)]
            public Vector4 UV;

            [Semantic(SemanticType.Position, 4)]
            public float Rotation;

            [Semantic(SemanticType.Position, 5)]
            public float ArraySlice;

            [Semantic(SemanticType.Color)]
            public Vector4 Color;
        }

        struct PS_IN
        {
            [Semantic(SemanticType.SV_Position)]
            public Vector4 Pos;

            [Semantic(SemanticType.Color)]
            public Vector4 Color;

            [Semantic(SemanticType.TexCoord)]
            public Vector4 UV;
        }

        Texture2DArray mapDiffuse;
        TextureSampler diffuseSampler;

        Matrix4x4 wvp;
        Vector2 textureSize;

        static float degToRad360 = 6.28319f;

        [VertexShader]
        VS_GS VS(VS_GS input)
        {
            input.UV.XZ /= textureSize.X;
            input.UV.YW /= textureSize.Y;

            //invert y axis.
            input.Pos.Y = -input.Pos.Y;

            // Invert Y origin
            input.Origin.Y = -input.Origin.Y;

            return input;
        }

        [VertexShader]
        VS_GS VS_Line(VS_GS input)
        {
            //invert y axis.
            input.Pos.Y = -input.Pos.Y;
            input.Size.Y = -input.Size.Y; // y position of 2nd line point.
            return input;
        }

        [VertexShader]
        VS_GS VS_Circle(VS_GS input)
        {
            //invert y axis.
            input.Pos.Y = -input.Pos.Y;
            return input;
        }

        [VertexShader]
        VS_GS VS_Tri(VS_GS input)
        {
            //invert y axis.
            input.Pos.Y = -input.Pos.Y;
            input.Size.Y = -input.Size.Y;
            input.Origin.Y = -input.Origin.Y;
            return input;
        }

        readonly static Vector2[] spriteCorners = {
            new Vector2(0,-1),
            new Vector2(0, 0),
            new Vector2(1,-1),
            new Vector2(1,0),
        };

        readonly static Int2[] uvTable = {
            new Int2(0,3),
            new Int2(0,1),
            new Int2(2,3),
            new Int2(2,1),
        };

        Matrix2x2 GetRotation(float angle)
        {
            // Compute a 2x2 rotation matrix.
            float c = Cos(angle);
            float s = Sin(angle);

            return new Matrix2x2(c, -s, s, c);
        }

        [GeometryShader(GeometryInputType.Point, 4)]
        void GS(VS_GS[] input, TriangleStream<PS_IN> spriteStream)
        {
            PS_IN v = new PS_IN();
            VS_GS g = input[0];

            v.Color = g.Color;


            Matrix2x2 rot = GetRotation(input[0].Rotation);
            Vector2 origin = g.Origin.XY;
            Vector2 pos = g.Pos.XY;
            Vector2 size = g.Size.XY;
            Vector2 uv = g.UV.XY;
            Vector2 p;


            for (int i = 0; i < 4; i++)
            {
                p = Mul(size * (spriteCorners[i] - origin), rot);
                p += pos;
                v.Pos = new Vector4(p, 0, 1);
                v.Pos = Mul(v.Pos, wvp);
                v.UV.X = uv[uvTable[i].X];
                v.UV.Y = uv[uvTable[i].Y];
                v.UV.Z = g.ArraySlice;
                spriteStream.Append(v);
            }
        }

        [GeometryShader(GeometryInputType.Line, 4)]
        void GS_Line(VS_GS[] input, TriangleStream<PS_IN> spriteStream)
        {
            PS_IN v = new PS_IN();
            v.Color = input[0].Color;
            v.UV = new Vector4();
            Vector2 p1 = input[0].Pos;
            Vector2 p2 = input[0].Size;
            Vector2 dir = p2 - p1;
            Vector2 normal = Normalize(new Vector2(-dir.Y, dir.X));
            float thickness = input[0].Rotation * 0.5f;

            // Vertex p1 vertex 0 (v0)
            v.Pos = new Vector4(p1 - (thickness * normal), 0, 1);
            v.Pos = Mul(v.Pos, wvp);
            spriteStream.Append(v);

            // Vertex p1 vertex 1 (v1)
            v.Pos = new Vector4(p1 + (thickness * normal), 0, 1);
            v.Pos = Mul(v.Pos, wvp);
            spriteStream.Append(v);

            // Vertex p2 vertex 0 (v2)
            v.Color = input[0].UV;
            v.Pos = new Vector4(p2 - (thickness * normal), 0, 1);
            v.Pos = Mul(v.Pos, wvp);
            spriteStream.Append(v);

            // Vertex p2 vertex 1 (v3)
            v.Pos = new Vector4(p2 + (thickness * normal), 0, 1);
            v.Pos = Mul(v.Pos, wvp);
            spriteStream.Append(v);
        }

        [GeometryShader(GeometryInputType.Triangle, 4)]
        void GS_Circle(VS_GS[] input, TriangleStream<PS_IN> spriteStream)
        {
            PS_IN v = new PS_IN();
            // center vertex
            v.Color = input[0].Color;
            v.UV = new Vector4();
            Vector4 center = new Vector4(input[0].Pos, 0, 1);

            float segs = input[0].Rotation;
            Vector2 radius = input[0].Size;
            Vector2 startEnd = input[0].Origin;
            float range = startEnd.Y - startEnd.X;
            float angleInc = degToRad360 / segs;
            float angle = startEnd.X;
            float remaining = range;

            float inc = 0;
            float doEdge = 0; // if 0, we place a center point for the strip to orient around.
            float vCount = (segs * 2) + 2;
            for (int i = 0; i < vCount; i++)
            {
                v.Pos = center + (doEdge * new Vector4(Sin(angle) * radius.X, Cos(angle) * radius.Y, 0, 0));
                v.Pos = Mul(v.Pos, wvp);

                inc = Min(angleInc, remaining);
                angle += inc * doEdge;
                remaining -= inc * doEdge;
                doEdge = 1 - doEdge;
                spriteStream.Append(v);
            }
        }

        [GeometryShader(GeometryInputType.Triangle, 3)]
        void GS_Tri(VS_GS[] input, TriangleStream<PS_IN> spriteStream)
        {
            PS_IN v = new PS_IN();
            v.Color = input[0].Color;
            v.UV = new Vector4();

            // p1
            v.Pos = Mul(new Vector4(input[0].Pos, 0, 1), wvp);
            spriteStream.Append(v);

            // p3
            v.Pos = Mul(new Vector4(input[0].Origin, 0, 1), wvp);
            spriteStream.Append(v);

            // p2
            v.Pos = Mul(new Vector4(input[0].Size, 0, 1), wvp);
            spriteStream.Append(v);
        }

        [FragmentShader(SemanticFragmentOutputType.SV_Target)]
        Vector4 PS(PS_IN input)
        {
            Vector4 col = mapDiffuse.Sample(diffuseSampler, input.UV.XYZ);
            return col * input.Color;
        }

        [FragmentShader(SemanticFragmentOutputType.SV_Target)]
        Vector4 PS_NoTexture(PS_IN input)
        {
            return input.Color;
        }
    }
}
