using SharpShader;

namespace SharpShaderSample
{    
    class SampleShader
    {
        [ConstantBuffer(0)]
        public struct WvpBuffer
        {
           
        }

        public struct VertexInput
        {
            public Vector3 Position;
        }

        public struct PixelInput
        {
            public Vector4 Position;
        }

        [VertexShader]
        public PixelInput VertexFunc(VertexInput input)
        {
            return new PixelInput()
            {
                Position = new Vector4(),
            };
        }

        [FragmentShader]
        public Vector4 FragFunc(PixelInput input)
        {
            return new Vector4(1.0f, 0.5f, 0, 1.0f);
        }
    }
}
