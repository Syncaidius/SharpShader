using SharpShader;

namespace SharpShaderSample
{
    class SampleShader : CSharpShader
    {
        [ConstantBuffer(0)]
        public struct ObjectBuffer
        {
            [PackOffset(0)]
            public Matrix4x4 Wvp;

            [PackOffset(4, PackOffsetComponent.X)]
            public Vector4 TintColor;
        }

        public struct VertexInput
        {
            [Semantic(SemanticType.Position, 0)]
            public Vector4 Position;

            [Semantic(SemanticType.Color, 0)]
            public Vector4 Color;
        }

        public struct PixelInput
        {
            public Vector4 Position;
            public Vector4 Color;
        }

        public ObjectBuffer cbObject = new ObjectBuffer();

        // This method is simply for testing purposes. Beyond that, it's pointless!
        public Vector4 getColor(Vector4 input, float multiplier)
        {
            return input * multiplier;
        }

        // This is another test method!
        public Vector4 getOtherColor()
        {
            float r = 0f, g = 1.0f, b = 0f, a = 1f;
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

        [FragmentShader]
        public Vector4 FragFunc(PixelInput input)
        {
            return getColor(input.Color, 1) * getOtherColor() * cbObject.TintColor;
        }
    }
}
