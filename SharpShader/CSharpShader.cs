
using System;

namespace SharpShader
{
	public abstract class CSharpShader
	{
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "abort")]
		protected void Abort() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "abs")]
		protected void Abs() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "acos")]
		protected void Acos() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "all")]
		protected void All() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "AllMemoryBarrier")]
		protected void AllMemoryBarrier() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "AllMemoryBarrierWithGroupSync")]
		protected void AllMemoryBarrierWithGroupSync() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "any")]
		protected void Any() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "asdouble")]
		protected void Asdouble() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "asfloat")]
		protected void Asfloat() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "asin")]
		protected void Asin() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "asint")]
		protected void Asint() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "asuint")]
		protected void Asuint() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "atan")]
		protected void Atan() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "atan2")]
		protected void Atan2() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ceil")]
		protected void Ceil() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "CheckAccessFullyMapped")]
		protected void CheckAccessFullyMapped() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "clamp")]
		protected void Clamp() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "clip")]
		protected void Clip() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "cos")]
		protected void Cos() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "cosh")]
		protected void Cosh() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "countbits")]
		protected void Countbits() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "cross")]
		protected void Cross() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "D3DCOLORtoUBYTE4")]
		protected void D3dColorToUByte4() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ddx")]
		protected void Ddx() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ddx_coarse")]
		protected void DdxCourse() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ddx_fine")]
		protected void DdxFine() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ddy")]
		protected void Ddy() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ddy_coarse")]
		protected void DdyCourse() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ddy_fine")]
		protected void DdyFine() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "degrees")]
		protected void Degrees() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "determinant")]
		protected void Determinant() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "DeviceMemoryBarrier")]
		protected void DeviceMemoryBarrier() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "DeviceMemoryBarrierWithGroupSync")]
		protected void DeviceMemoryBarrierWithGroupSync() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "distance")]
		protected void Distance() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "dot")]
		protected void Dot() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "dst")]
		protected void Dst() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "errorf")]
		protected void Errorf() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "EvaluateAttributeAtCentroid")]
		protected void EvaluateAttributeAtCentroid() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "EvaluateAttributeAtSample")]
		protected void EvaluateAttributeAtSample() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "EvaluateAttributeSnapped")]
		protected void EvaluateAttributeSnapped() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "exp")]
		protected void Exp() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "exp2")]
		protected void Exp2() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "f16tof32")]
		protected void F16tof32() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "f32tof16")]
		protected void F32tof16() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "faceforward")]
		protected void Faceforward() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "firstbithigh")]
		protected void Firstbithigh() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "firstbitlow")]
		protected void Firstbitlow() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "floor")]
		protected void Floor() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "fma")]
		protected void Fma() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "fmod")]
		protected void Fmod() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "frac")]
		protected void Frac() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "frexp")]
		protected void Frexp() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "fwidth")]
		protected void Fwidth() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "GetRenderTargetSampleCount")]
		protected void GetRenderTargetSampleCount() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "GetRenderTargetSamplePosition")]
		protected void GetRenderTargetSamplePosition() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "GroupMemoryBarrier")]
		protected void GroupMemoryBarrier() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "GroupMemoryBarrierWithSync")]
		protected void GroupMemoryBarrierWithSync() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedAdd")]
		protected void InterlockedAdd() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedAnd")]
		protected void InterlockedAnd() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedCompareExchange")]
		protected void InterlockedCompareExchange() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedCompareStore")]
		protected void InterlockedCompareStore() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedExchange")]
		protected void InterlockedExchange() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedMax")]
		protected void InterlockedMax() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedMin")]
		protected void InterlockedMin() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedOr")]
		protected void InterlockedOr() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedXor")]
		protected void InterlockedXor() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "isfinite")]
		protected void Isfinite() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "isinf")]
		protected void Isinf() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "isnan")]
		protected void Isnan() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ldexp")]
		protected void Ldexp() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "length")]
		protected void Length() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "lerp")]
		protected void Lerp() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "lit")]
		protected void Lit() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "log")]
		protected void Log() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "log10")]
		protected void Log10() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "log2")]
		protected void Log2() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "mad")]
		protected void Mad() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "max")]
		[ShaderIntrinsic(ShaderLanguage.GLSL, "max")]
		protected void Max() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "min")]
		[ShaderIntrinsic(ShaderLanguage.GLSL, "min")]
		protected void Min() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "modf")]
		protected void Modf() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "msad4")]
		protected void Msad4() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "mul")]
		protected Single Mul(Single a, Single b) { return default(Single); }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "mul")]
		protected Int32 Mul(Int32 a, Int32 b) { return default(Int32); }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "mul")]
		protected T Mul<T>(Single a, T b) where T : struct, IIntrinsicValue { return default(T); }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "mul")]
		protected T Mul<T>(Int32 a, T b) where T : struct, IIntrinsicValue { return default(T); }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "mul")]
		protected T Mul<T>(T a, Single b) where T : struct, IIntrinsicValue { return default(T); }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "mul")]
		protected T Mul<T>(T a, Int32 b) where T : struct, IIntrinsicValue { return default(T); }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "mul")]
		protected V1 Mul<V1, V2>(V1 a, V2 b) where V1 : struct, IIntrinsicValue where V2 : struct, IIntrinsicValue { return default(V1); }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "noise")]
		protected void Noise() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "normalize")]
		protected void Normalize() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "pow")]
		protected void Pow() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "printf")]
		protected void Printf() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "Process2DQuadTessFactorsAvg")]
		protected void Process2DQuadTessFactorsAvg() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "Process2DQuadTessFactorsMax")]
		protected void Process2DQuadTessFactorsMax() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "Process2DQuadTessFactorsMin")]
		protected void Process2DQuadTessFactorsMin() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ProcessIsolineTessFactors")]
		protected void ProcessIsolineTessFactors() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ProcessQuadTessFactorsAvg")]
		protected void ProcessQuadTessFactorsAvg() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ProcessQuadTessFactorsMax")]
		protected void ProcessQuadTessFactorsMax() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ProcessQuadTessFactorsMin")]
		protected void ProcessQuadTessFactorsMin() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ProcessTriTessFactorsAvg")]
		protected void ProcessTriTessFactorsAvg() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ProcessTriTessFactorsMax")]
		protected void ProcessTriTessFactorsMax() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ProcessTriTessFactorsMin")]
		protected void ProcessTriTessFactorsMin() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "radians")]
		protected void Radians() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "rcp")]
		protected void Rcp() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "reflect")]
		protected void Reflect() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "refract")]
		protected void Refract() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "reversebits")]
		protected void Reversebits() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "round")]
		protected void Round() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "rsqrt")]
		protected void Rsqrt() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "saturate")]
		protected void Saturate() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "sign")]
		protected void Sign() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "sincos")]
		protected void Sincos() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "sinh")]
		protected void Sinh() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "smoothstep")]
		protected void Smoothstep() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "sqrt")]
		protected void Sqrt() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "step")]
		protected void Step() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "tan")]
		protected void Tan() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "tanh")]
		protected void Tanh() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "tex1D")]
		protected void Tex1D() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "tex1Dbias")]
		protected void Tex1Dbias() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "tex1Dgrad")]
		protected void Tex1Dgrad() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "tex1Dlod")]
		protected void Tex1Dlod() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "tex1Dproj")]
		protected void Tex1Dproj() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "tex2D")]
		protected void Tex2D() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "tex2Dbias")]
		protected void Tex2Dbias() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "tex2Dgrad")]
		protected void Tex2Dgrad() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "tex2Dlod")]
		protected void Tex2Dlod() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "tex2Dproj")]
		protected void Tex2Dproj() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "tex3D")]
		protected void Tex3D() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "tex3Dbias")]
		protected void Tex3Dbias() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "tex3Dgrad")]
		protected void Tex3Dgrad() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "tex3Dlod")]
		protected void Tex3Dlod() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "tex3Dproj")]
		protected void Tex3Dproj() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "texCUBE")]
		protected void TexCUBE() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "texCUBEbias")]
		protected void TexCUBEbias() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "texCUBEgrad")]
		protected void TexCUBEgrad() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "texCUBElod")]
		protected void TexCUBElod() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "texCUBEproj")]
		protected void TexCUBEproj() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "transpose")]
		protected void Transpose() {  }
		
		[ShaderIntrinsic(ShaderLanguage.HLSL, "trunc")]
		protected void Truncate() {  }
	}
}