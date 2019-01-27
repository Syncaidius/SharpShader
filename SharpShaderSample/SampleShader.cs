using SharpShader;

namespace SharpShaderSample
{
    class SampleShader : CSharpShader
    {
        public struct VertexInput
        {
            [Semantic(SemanticType.Position, 0)]
            public Vector4 Position;

            [Semantic(SemanticType.Color, 0)]
            public Vector4 Color;
        }

        public struct PixelInput
        {
            [Semantic(SemanticType.SV_Position)]
            public Vector4 Position;

            [Semantic(SemanticType.Color)]
            public Vector4 Color;
        }

        [ConstantBuffer]
        [Register(0)]
        public struct CommonData
        {
            [PackOffset(0)]
            public Matrix4x4 View;

            [PackOffset(4)]
            public Matrix4x4 Projection;

            [PackOffset(8)]
            public Matrix4x4 ViewProjection;

            [PackOffset(12, PackOffsetComponent.X)]
            public Matrix4x4 InvViewProjection;
        }

        [ConstantBuffer]
        [Register(1)]
        public struct ObjectData
        {
            [PackOffset(0)]
            public Matrix4x4 Wvp;

            [PackOffset(4)]
            public Matrix4x4 World;
        }

        public ObjectData cbObject = new ObjectData();

        // This method is simply for testing purposes. Beyond that, it's pointless!
        public Vector4 getColor(Vector4 input, float multiplier)
        {
            return input * multiplier;
        }

        // This is another test method!
        public Vector4 getOtherColor()
        {
            float r = 0f, g = 1.0f, b = 0b0000_01110, a = 1f;
            return new Vector4(r,g,b,a);
        }

        [VertexShader]
        public PixelInput VertexFunc(VertexInput input)
        {
            return new PixelInput()
            {
                Position = Mul(input.Position, cbObject.Wvp),
                Color = input.Color,
            };
        }

        [FragmentShader(SemanticType.SV_Target)]
        public Vector4 FragFunc(PixelInput input)
        {
            return getColor(input.Color, 1) * getOtherColor();
        }
    }
}
