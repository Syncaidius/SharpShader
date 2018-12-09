﻿using SharpShader;

namespace SharpShaderSample
{
    class SampleTextureShader : CSharpShader
    {
        public struct VertexInput
        {
            [Semantic(SemanticType.Position, 0)]
            public Vector4 Position;

            [Semantic(SemanticType.TexCoord, 0)]
            public Vector2 UV;
        }

        public struct PixelInput
        {
            [Semantic(SemanticType.SV_Position)]
            public Vector4 Position;

            [Semantic(SemanticType.TexCoord)]
            public Vector2 UV;
        }

        [ConstantBuffer(0)]
        public struct CommonData
        {
            [PackOffset(0)]
            public Matrix4x4 View;

            [PackOffset(4)]
            public Matrix4x4 Projection;

            [PackOffset(8)]
            public Matrix4x4 ViewProjection;

            [PackOffset(12)]
            public Matrix4x4 InvViewProjection;
        }

        [ConstantBuffer(1)]
        public struct ObjectData
        {
            [PackOffset(0)]
            public Matrix4x4 Wvp;

            [PackOffset(4)]
            public Matrix4x4 World;
        }

        public ObjectData cbObject;
        public Texture2D mapTexture;
        public TextureSampler texSampler;

        [VertexShader]
        public PixelInput VertexFunc(VertexInput input)
        {
            return new PixelInput()
            {
                Position = Mul(input.Position, cbObject.Wvp),
                UV = input.UV,
            };
        }

        [FragmentShader(SemanticFragmentOutputType.SV_Target)]
        public Vector4 FragFunc(PixelInput input)
        {
            return mapTexture.Sample(texSampler, input.UV);
        }
    }
}