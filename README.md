# Sharp Shader
Write HLSL or GLSL shaders in C#

Current Status:
 - It is possible to generate basic HLSL shaders from C# source.
 - GLSL shaders are not support in any shape or form, yet
 - Geometry, hull, domain and compute shaders are not properly handled yet
 - Many elements of C# syntax are not supported yet, such as lamda, inheritance and properties.
 - There is currently no way to target a specific shader model (or GLSL version).
 - Lots of unfinished things!
 - A lot of bugs. Probably! 

# Example
Here is a C# to HLSL example showing off what Sharp Shader is capable of so far.  

C# source:
```csharp
using SharpShader;

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

            [PackOffset(12)]
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

        public ObjectData cbObject;

        [Register(0)]
        public Texture2D mapTexture, mapNormals, mapSpecular;

        [Register(0)]
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
```

The above gets turned into the following HLSL source:
```HLSL
struct VertexInput
{
	float4 Position : POSITION0;
	float2 UV : TEXCOORD0;
};

struct PixelInput
{
	float4 Position : SV_POSITION;
	float2 UV : TEXCOORD;
};

cbuffer CommonData : register(b0)
{
	float4x4 View : packoffset(c0);
	float4x4 Projection : packoffset(c4);
	float4x4 ViewProjection : packoffset(c8);
	float4x4 InvViewProjection : packoffset(c12);
}

cbuffer ObjectData : register(b1)
{
	float4x4 Wvp : packoffset(c0);
	float4x4 World : packoffset(c4);
}

Texture2D mapTexture : register(t0);

Texture2D mapNormals : register(t1);

Texture2D mapSpecular : register(t2);

SamplerState texSampler : register(s0);

PixelInput VertexFunc(VertexInput input)
{
	PixelInput ss_ret_0;
	ss_ret_0.Position = mul(input.Position, Wvp);
	ss_ret_0.UV = input.UV;
	return ss_ret_0;
}

float4 FragFunc(PixelInput input) : SV_TARGET
{
	return mapTexture.Sample(texSampler, input.UV);
}
```

It is worth noting that while the above C# code has defined `Register` and `PackOffset` attributes on almost every struct and field, it is not mandatory to do so. The absence of such attributes will simply result in the associated HLSL being absent too, as shown in the example below:

C#: 
```csharp        
public TextureSampler texSampler;
```

HLSL:
```HLSL
SamplerState texSampler;
```