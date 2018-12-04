
using System;

namespace SharpShader
{
	public abstract class CSharpShader
	{

		/// <summary>HLSL: Submits an error message to the information queue and terminates the current draw or dispatch call being executed.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "abort")]
		protected void Abort() {  }

		/// <summary>HLSL: Returns the absolute value of the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "abs")]
		protected void Abs(Int32 x) {  }

		/// <summary>HLSL: Returns the absolute value of the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "abs")]
		protected void Abs(Single x) {  }

		/// <summary>HLSL: Returns the absolute value of the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "abs")]
		protected T Abs<T>() where T : struct, IIntrinsicValue { return default(T); }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "acos")]
		protected void Acos(Single x) {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "acos")]
		protected T Acos<T>() where T : struct, IIntrinsicValue { return default(T); }

		/// <summary>HLSL: Determines if all components of the specified value are non-zero.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "all")]
		protected void All(Int32 x) {  }

		/// <summary>HLSL: Determines if all components of the specified value are non-zero.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "all")]
		protected void All(Single x) {  }

		/// <summary>HLSL: Determines if all components of the specified value are non-zero.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "all")]
		protected void All(Boolean x) {  }

		/// <summary>HLSL: Determines if all components of the specified value are non-zero.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "all")]
		protected Boolean All<T>(T x) where T : struct, IIntrinsicValue { return default(Boolean); }

		/// <summary>HLSL: Blocks execution of all threads in a group until all memory accesses have been completed.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "AllMemoryBarrier")]
		protected void AllMemoryBarrier() {  }

		/// <summary>HLSL: Blocks execution of all threads in a group until all memory accesses have been completed and all threads in the group have reached this call.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "AllMemoryBarrierWithGroupSync")]
		protected void AllMemoryBarrierWithGroupSync() {  }

		/// <summary>HLSL: Determines if any components of the specified value are non-zero.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "any")]
		protected void Any(Int32 x) {  }

		/// <summary>HLSL: Determines if any components of the specified value are non-zero.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "any")]
		protected void Any(Single x) {  }

		/// <summary>HLSL: Determines if any components of the specified value are non-zero.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "any")]
		protected void Any(Boolean x) {  }

		/// <summary>HLSL: Determines if any components of the specified value are non-zero.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "any")]
		protected Boolean Any<T>(T x) where T : struct, IIntrinsicValue { return default(Boolean); }

		/// <summary>HLSL: Reinterprets a cast value (two 32-bit values) into a double.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "asdouble")]
		protected void AsDouble(UInt32 lowBits, UInt32 highBits) {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "asfloat")]
		protected void AsFloat(UInt32 x) {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "asfloat")]
		protected void AsFloat(Int32 x) {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "asfloat")]
		protected T AsFloat<T>(T x) where T : struct, IIntrinsicValue { return default(T); }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "asin")]
		protected void Asin() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "asint")]
		protected void Asint() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "asuint")]
		protected void Asuint() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "atan")]
		protected void Atan() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "atan2")]
		protected void Atan2() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ceil")]
		protected void Ceil() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "CheckAccessFullyMapped")]
		protected void CheckAccessFullyMapped() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "clamp")]
		protected void Clamp() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "clip")]
		protected void Clip() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "cos")]
		protected void Cos() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "cosh")]
		protected void Cosh() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "countbits")]
		protected void Countbits() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "cross")]
		protected void Cross() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "D3DCOLORtoUBYTE4")]
		protected void D3dColorToUByte4() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ddx")]
		protected void Ddx() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ddx_coarse")]
		protected void DdxCourse() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ddx_fine")]
		protected void DdxFine() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ddy")]
		protected void Ddy() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ddy_coarse")]
		protected void DdyCourse() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ddy_fine")]
		protected void DdyFine() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "degrees")]
		protected void Degrees() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "determinant")]
		protected void Determinant() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "DeviceMemoryBarrier")]
		protected void DeviceMemoryBarrier() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "DeviceMemoryBarrierWithGroupSync")]
		protected void DeviceMemoryBarrierWithGroupSync() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "distance")]
		protected void Distance() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "dot")]
		protected void Dot() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "dst")]
		protected void Dst() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "errorf")]
		protected void Errorf() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "EvaluateAttributeAtCentroid")]
		protected void EvaluateAttributeAtCentroid() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "EvaluateAttributeAtSample")]
		protected void EvaluateAttributeAtSample() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "EvaluateAttributeSnapped")]
		protected void EvaluateAttributeSnapped() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "exp")]
		protected void Exp() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "exp2")]
		protected void Exp2() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "f16tof32")]
		protected void F16tof32() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "f32tof16")]
		protected void F32tof16() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "faceforward")]
		protected void Faceforward() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "firstbithigh")]
		protected void Firstbithigh() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "firstbitlow")]
		protected void Firstbitlow() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "floor")]
		protected void Floor() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "fma")]
		protected void Fma() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "fmod")]
		protected void Fmod() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "frac")]
		protected void Frac() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "frexp")]
		protected void Frexp() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "fwidth")]
		protected void Fwidth() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "GetRenderTargetSampleCount")]
		protected void GetRenderTargetSampleCount() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "GetRenderTargetSamplePosition")]
		protected void GetRenderTargetSamplePosition() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "GroupMemoryBarrier")]
		protected void GroupMemoryBarrier() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "GroupMemoryBarrierWithSync")]
		protected void GroupMemoryBarrierWithSync() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedAdd")]
		protected void InterlockedAdd() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedAnd")]
		protected void InterlockedAnd() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedCompareExchange")]
		protected void InterlockedCompareExchange() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedCompareStore")]
		protected void InterlockedCompareStore() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedExchange")]
		protected void InterlockedExchange() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedMax")]
		protected void InterlockedMax() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedMin")]
		protected void InterlockedMin() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedOr")]
		protected void InterlockedOr() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedXor")]
		protected void InterlockedXor() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "isfinite")]
		protected void Isfinite() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "isinf")]
		protected void Isinf() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "isnan")]
		protected void Isnan() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ldexp")]
		protected void Ldexp() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "length")]
		protected void Length() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "lerp")]
		protected void Lerp() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "lit")]
		protected void Lit() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "log")]
		protected void Log() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "log10")]
		protected void Log10() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "log2")]
		protected void Log2() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "mad")]
		protected void Mad() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "max")]
		[ShaderIntrinsic(ShaderLanguage.GLSL, "max")]
		protected void Max() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "min")]
		[ShaderIntrinsic(ShaderLanguage.GLSL, "min")]
		protected void Min() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "modf")]
		protected void Modf() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "msad4")]
		protected void Msad4() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "mul")]
		protected void Mul(Single a, Single b) {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "mul")]
		protected void Mul(Int32 a, Int32 b) {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "mul")]
		protected T Mul<T>(Single a, T b) where T : struct, IIntrinsicValue { return default(T); }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "mul")]
		protected T Mul<T>(Int32 a, T b) where T : struct, IIntrinsicValue { return default(T); }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "mul")]
		protected T Mul<T>(T a, Single b) where T : struct, IIntrinsicValue { return default(T); }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "mul")]
		protected T Mul<T>(T a, Int32 b) where T : struct, IIntrinsicValue { return default(T); }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "mul")]
		protected V1 Mul<V1, V2>(V1 a, V2 b) where V1 : struct, IIntrinsicValue where V2 : struct, IIntrinsicValue { return default(V1); }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "noise")]
		protected void Noise() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "normalize")]
		protected void Normalize() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "pow")]
		protected void Pow() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "printf")]
		protected void Printf() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "Process2DQuadTessFactorsAvg")]
		protected void Process2DQuadTessFactorsAvg() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "Process2DQuadTessFactorsMax")]
		protected void Process2DQuadTessFactorsMax() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "Process2DQuadTessFactorsMin")]
		protected void Process2DQuadTessFactorsMin() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ProcessIsolineTessFactors")]
		protected void ProcessIsolineTessFactors() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ProcessQuadTessFactorsAvg")]
		protected void ProcessQuadTessFactorsAvg() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ProcessQuadTessFactorsMax")]
		protected void ProcessQuadTessFactorsMax() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ProcessQuadTessFactorsMin")]
		protected void ProcessQuadTessFactorsMin() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ProcessTriTessFactorsAvg")]
		protected void ProcessTriTessFactorsAvg() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ProcessTriTessFactorsMax")]
		protected void ProcessTriTessFactorsMax() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ProcessTriTessFactorsMin")]
		protected void ProcessTriTessFactorsMin() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "radians")]
		protected void Radians() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "rcp")]
		protected void Rcp() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "reflect")]
		protected void Reflect() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "refract")]
		protected void Refract() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "reversebits")]
		protected void Reversebits() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "round")]
		protected void Round() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "rsqrt")]
		protected void Rsqrt() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "saturate")]
		protected void Saturate() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "sign")]
		protected void Sign() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "sincos")]
		protected void Sincos() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "sinh")]
		protected void Sinh() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "smoothstep")]
		protected void Smoothstep() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "sqrt")]
		protected void Sqrt() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "step")]
		protected void Step() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "tan")]
		protected void Tan() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "tanh")]
		protected void Tanh() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "tex1D")]
		protected void Tex1D() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "tex1Dbias")]
		protected void Tex1Dbias() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "tex1Dgrad")]
		protected void Tex1Dgrad() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "tex1Dlod")]
		protected void Tex1Dlod() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "tex1Dproj")]
		protected void Tex1Dproj() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "tex2D")]
		protected void Tex2D() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "tex2Dbias")]
		protected void Tex2Dbias() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "tex2Dgrad")]
		protected void Tex2Dgrad() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "tex2Dlod")]
		protected void Tex2Dlod() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "tex2Dproj")]
		protected void Tex2Dproj() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "tex3D")]
		protected void Tex3D() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "tex3Dbias")]
		protected void Tex3Dbias() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "tex3Dgrad")]
		protected void Tex3Dgrad() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "tex3Dlod")]
		protected void Tex3Dlod() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "tex3Dproj")]
		protected void Tex3Dproj() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "texCUBE")]
		protected void TexCUBE() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "texCUBEbias")]
		protected void TexCUBEbias() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "texCUBEgrad")]
		protected void TexCUBEgrad() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "texCUBElod")]
		protected void TexCUBElod() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "texCUBEproj")]
		protected void TexCUBEproj() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "transpose")]
		protected void Transpose() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "trunc")]
		protected void Truncate() {  }
	}
}