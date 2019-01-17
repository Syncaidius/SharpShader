using SharpShader;
using System;

namespace SharpShaderSample
{
    /// <summary>
    /// A nonsensical shader made up of random pieces of code for testing purposes.
    /// </summary>
    public class FunctionalityTestShader : CSharpShader
    {
        #region Constants
        public const int LAPS = 5;
        public const float RADIUS = 0.5f;
        public const double PI = Math.PI;
        readonly static Vector3 DefaultPos = new Vector3(10.2f, 5.3f, 9.8f);
        #endregion

        #region Structs
        private struct HS_OUTPUT
        {
            [Semantic(SemanticType.Position)]
            public Vector3 HemiDir;

            [Semantic(SemanticType.TexCoord)]
            public uint LightID;
        };

        public struct DS_OUTPUT
        {
            [Semantic(SemanticType.SV_Position)]
            public Vector4 Position;

            [Semantic(SemanticType.TexCoord)]
            public Vector3 PositionXYW;

            [Semantic(SemanticType.BlendIndices)]
            public uint LightID;
        };

        // Unsafe struct with fixed-size arrays. Syntax is very similar to GLSL and HLSL arrays.
        public unsafe struct HS_CONSTANT_DATA_OUTPUT
        {
            [Semantic(SemanticType.SV_TessFactor)]
            public fixed float Edges[4];

            [Semantic(SemanticType.SV_InsideTessFactor)]
            public fixed float Inside[2];
        };

        struct Light
        {
            public Matrix4x4 Transform;
            public Vector3 Position;
            public float RangeRcp;
            public float Intensity;
            public Vector3 Color;
            public float Tess; // Tessellation factor

            public Vector3 Forward;
            public float Length;
            public float HalfLength;
        };

        #endregion

        #region Variables
        static Vector3 CameraPos;

        readonly static Vector4 Color = new Vector4(0.5f, 0.2f, 0.1f, 1.0f);

        readonly static Vector2[] testArray = {
            new Vector2(0,-1),
            new Vector2(0, 0),
            new Vector2(1,-1),
            new Vector2(1,0),
        }, testArray2 = new Vector2[]
{
            new Vector2(5,0),
            new Vector2(0, 4),
            new Vector2(2,3),
        }, testArray3 = new Vector2[4]
        {
            new Vector2(7,6),
            new Vector2(93.0f, 0.5f),
            new Vector2(1, 0.458f),
            new Vector2(.34f, 19.431f),
        };

        [Register(8)]
        StructuredBuffer<Light> LightData;
        #endregion

        #region Methods
        int IAmALambdaMethod() => 9;

        int AnotherLambdaMethod(int increment) => 9 + increment;

        T GenericLambdaMethod<T>(int increment) where T : struct => default(T);

        void NoReturnLambdaMethod(bool isValid) => CameraPos = new Vector3(5, 0.2f, -11);

        public void DelegateParameterTest(Action<int, float> test)
        {
            test(LAPS, RADIUS);
        }

        private Vector2 AccessibleThings(bool access)
        {
            bool invertedAccess = !access;

            if (access)
            {
                return this.Normalize(new Vector2(5,5));
            }
            else if (invertedAccess)
            {
                Vector2 inv = new Vector2(-5, -5);
                return Normalize(inv);
            }
            else
            {
                return base.Normalize(new Vector2(32.0f, -23.0f));
            }
        }

        private Vector2 AccessibleThingsShortened(bool access)
        {
            return access ? this.Normalize(new Vector2(5, 5)) : base.Normalize(new Vector2(32.0f, -23.0f));
        }

        private Vector2 AccessibleThingsShortenedLambdas(bool access) => access ? this.Normalize(new Vector2(5, 5)) : base.Normalize(new Vector2(32.0f, -23.0f));

        private float TotalLappedDistance(int laps, float trackRadius)
        {
            double circumference = 2 * PI * trackRadius;
            return (float)(circumference * laps);
        }

        public (float, int) TupleTest(int value)
        {
            return (value / 2f, value);
        }

        public (float, int) TupleTestLambda(int value) => (value / 2f, value);

        public int TupleTestParameter((float, int) value)
        {
            return value.Item2;
        }

        public int NamedTupleTestParameter((float f, int i) value)
        {
            return (int)(value.f * value.i);
        }

        public (float fResult, double dResult) NamedTupleTestReturnParameter((float f, int i) value)
        {
            return (value.f * 10.9f, value.i * 10.45f);
        }

        public Vector3 HalfCookedLighting
        (
        in Vector3 normal, // normal
        in Vector3 toEye, // direction to eye/camera
        in Vector3 toLight, // direction to light
        in Vector3 cLightCol, // light color
        in Vector3 cDiffuse, // scene color
        in Vector3 cSpecular // specular color
        )
        {
            // Sample the textures
            // TODO: These are to be mapped to a PBR texture.
            float surfaceR = 0.1f; // IoR
            float surfaceG = 0.2f; // Roughness
            float surfaceB = 1; // Metallic

            Vector2 Roughness = new Vector2(surfaceR, surfaceG);

            Roughness.R *= 3.0f;

            // Correct the input and compute aliases
            Vector3 ViewDir = Normalize(toEye);
            Vector3 LightDir = Normalize(toLight);
            Vector3 vHalf = Normalize(LightDir + ViewDir);
            float NormalDotHalf = Dot(normal, vHalf);
            float ViewDotHalf = Dot(vHalf, ViewDir);
            float NormalDotView = Dot(normal, ViewDir);
            float NormalDotLight = Dot(normal, LightDir);

            // Compute the geometric term
            float G1 = (2.0f * NormalDotHalf * NormalDotView) / ViewDotHalf;
            float G2 = (2.0f * NormalDotHalf * NormalDotLight) / ViewDotHalf;
            float G = Min(1.0f, Max(0.0f, Min(G1, G2)));

            // Compute the fresnel term
            float F = Roughness.G + (1.0f - Roughness.G) * Pow(1.0f - NormalDotView, 5.0f);

            // Compute the roughness term
            float R_2 = Roughness.R * Roughness.R;
            float NDotH_2 = NormalDotHalf * NormalDotHalf;
            float A = 1.0f / (4.0f * R_2 * NDotH_2 * NDotH_2);
            float B = Exp(-(1.0f - NDotH_2) / (R_2 * NDotH_2));
            float R = A * B;

            // Compute the final term
            Vector3 S = cSpecular * ((G * F * R) / (NormalDotLight * NormalDotView));

            // Clamp specular into a reasonable range to prevent patchy bloom glitches.
            Vector3 finalS = Saturate(S) * 4;
            finalS = Min(finalS, S);

            Vector3 Final = cLightCol.RGB * Max(0.0f, NormalDotLight) * (cDiffuse + finalS);
            return Final;
        }

        // Custom point light constant function
        HS_CONSTANT_DATA_OUTPUT PointConstantHS([Semantic(SemanticType.SV_PrimitiveID)] uint PatchID)
        {
            HS_CONSTANT_DATA_OUTPUT Output;

            uint id = (uint)Floor(0.5f * PatchID); // Light ID (2 patches per light)
            // Conside also allowing f
            unsafe
            {
                Output.Edges[0] = Output.Edges[1] = Output.Edges[2] = Output.Edges[3] = LightData[id].Tess;
                Output.Inside[0] = Output.Inside[1] = LightData[id].Tess;
            }

            return Output;
        }
        #endregion

        #region Properties
        // Lamda property
        public bool AmIAShader => true;

        // Property with lambda getter
        public bool AreBananasAVegetable
        {
            get => false;
        }

        // Another property with a lambda getter.
        public static float FortyTwo
        {
            get => 42.0f;
        }

        // Property with two lambda accessors
        public static Vector2 WaveOffset
        {
            get => new Vector2(8 * 4.2f, 8 * 4.0f);
            set => new Vector2(value.X, value.Y);
        }

        // Fully-defined property
        public static Vector2 WaveOffsetNumberTwo
        {
            get
            {
                return new Vector2(8 * 2.2f, 8 * 2.0f);
            }
            set
            {
                Vector2 test = new Vector2()
                {
                    X = value.X,
                    Y = value.Y
                };
            }
        }

        // Plain ol' property
        public float NumberOfWaves { get; set; }

        // Read-only property
        public float WaveHeight { get; } = 2.9f;

        #endregion

        #region Indexers
        public float this[int index]
        {
            get => 0;
            set { }
        }

        public float this[int x, int y, int z]
        {
            get => 0;
            set { }
        }
  
        #endregion

        #region Entry points
        [DomainShader(PatchType.Quad)]
        DS_OUTPUT DS(HS_CONSTANT_DATA_OUTPUT input,
            [Semantic(SemanticType.SV_DomainLocation)] Vector2 UV,
            [OutputPatch(4)] in HS_OUTPUT[] quad)
        {
            // Transform the UV's into clip-space
            Vector2 posClipSpace = UV.XY * 2.0 - 1.0;

            // Find the absulate maximum distance from the center
            Vector2 posClipSpaceAbs = Abs(posClipSpace.XY);
            float maxLen = Max(posClipSpaceAbs.X, posClipSpaceAbs.Y);

            // Generate the final position in clip-space
            Vector3 normDir = Normalize(new Vector3(posClipSpace.XY, (maxLen - 1.0f)) * quad[0].HemiDir);
            Vector4 posLS = new Vector4(normDir.XYZ, 1.0f);

            // Transform all the way to projected space
            DS_OUTPUT Output;
            Output.LightID = quad[0].LightID;
            Output.Position = Mul(posLS, LightData[Output.LightID].Transform);

            // Store the clip space position
            Output.PositionXYW = Output.Position.XYW;

            return Output;
        }
        #endregion
    }
}
