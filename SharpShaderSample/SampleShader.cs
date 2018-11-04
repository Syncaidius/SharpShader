using SharpShader;

namespace SharpShaderSample
{    
    class SampleShader : CSharpShader
    {
        [ConstantBuffer(0)]
        public struct ObjectBuffer
        {
            public Matrix4x4 Wvp;
        }

        public struct VertexInput
        {
            public Vector4 Position;
            public Vector4 Color;
        }

        public struct PixelInput
        {
            public Vector4 Position;
            public Vector4 Color;
        }

        public ObjectBuffer cbObject = new ObjectBuffer();

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
            return input.Color;
        }
    }
}
