
using System;

namespace SharpShader
{
	public abstract class CSharpShader
	{

		/// <summary>HLSL: Submits an error message to the information queue and terminates the current draw or dispatch call being executed.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Abort() {  }

		/// <summary>HLSL: Returns the absolute value of the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Abs(Int32 x) {  }

		/// <summary>HLSL: Returns the absolute value of the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Abs(Single x) {  }

		/// <summary>HLSL: Returns the absolute value of the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected T Abs<T>() where T : struct, IIntrinsicValue { return default(T); }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Acos(Single x) {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected T Acos<T>() where T : struct, IIntrinsicValue { return default(T); }

		/// <summary>HLSL: Determines if all components of the specified value are non-zero.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void All(Int32 x) {  }

		/// <summary>HLSL: Determines if all components of the specified value are non-zero.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void All(Single x) {  }

		/// <summary>HLSL: Determines if all components of the specified value are non-zero.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void All(Boolean x) {  }

		/// <summary>HLSL: Determines if all components of the specified value are non-zero.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected Boolean All<T>(T x) where T : struct, IIntrinsicValue { return default(Boolean); }

		/// <summary>HLSL: Blocks execution of all threads in a group until all memory accesses have been completed.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void AllMemoryBarrier() {  }

		/// <summary>HLSL: Blocks execution of all threads in a group until all memory accesses have been completed and all threads in the group have reached this call.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void AllMemoryBarrierWithGroupSync() {  }

		/// <summary>HLSL: Determines if any components of the specified value are non-zero.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Any(Int32 x) {  }

		/// <summary>HLSL: Determines if any components of the specified value are non-zero.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Any(Single x) {  }

		/// <summary>HLSL: Determines if any components of the specified value are non-zero.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Any(Boolean x) {  }

		/// <summary>HLSL: Determines if any components of the specified value are non-zero.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected Boolean Any<T>(T x) where T : struct, IIntrinsicValue { return default(Boolean); }

		/// <summary>HLSL: Reinterprets a cast value (two 32-bit values) into a double.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void AsDouble(UInt32 lowBits, UInt32 highBits) {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void AsFloat(UInt32 x) {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void AsFloat(Int32 x) {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected T AsFloat<T>(T x) where T : struct, IIntrinsicValue { return default(T); }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Asin() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Asint() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Asuint() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Atan() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Atan2() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Ceil() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void CheckAccessFullyMapped() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Clamp() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Clip() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Cos() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Cosh() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Countbits() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Cross() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void D3dColorToUByte4() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Ddx() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void DdxCourse() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void DdxFine() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Ddy() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void DdyCourse() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void DdyFine() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Degrees() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Determinant() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void DeviceMemoryBarrier() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void DeviceMemoryBarrierWithGroupSync() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Distance() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Dot() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Dst() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Errorf() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void EvaluateAttributeAtCentroid() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void EvaluateAttributeAtSample() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void EvaluateAttributeSnapped() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Exp() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Exp2() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void F16tof32() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void F32tof16() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Faceforward() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Firstbithigh() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Firstbitlow() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Floor() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Fma() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Fmod() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Frac() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Frexp() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Fwidth() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void GetRenderTargetSampleCount() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void GetRenderTargetSamplePosition() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void GroupMemoryBarrier() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void GroupMemoryBarrierWithSync() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void InterlockedAdd() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void InterlockedAnd() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void InterlockedCompareExchange() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void InterlockedCompareStore() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void InterlockedExchange() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void InterlockedMax() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void InterlockedMin() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void InterlockedOr() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void InterlockedXor() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Isfinite() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Isinf() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Isnan() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Ldexp() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Length() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Lerp() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Lit() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Log() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Log10() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Log2() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Mad() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		[ShaderIntrinsic(ShaderLanguage.GLSL, "GLSL")]
		protected void Max() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		[ShaderIntrinsic(ShaderLanguage.GLSL, "GLSL")]
		protected void Min() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Modf() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Msad4() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Mul(Single a, Single b) {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Mul(Int32 a, Int32 b) {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected T Mul<T>(Single a, T b) where T : struct, IIntrinsicValue { return default(T); }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected T Mul<T>(Int32 a, T b) where T : struct, IIntrinsicValue { return default(T); }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected T Mul<T>(T a, Single b) where T : struct, IIntrinsicValue { return default(T); }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected T Mul<T>(T a, Int32 b) where T : struct, IIntrinsicValue { return default(T); }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected V1 Mul<V1, V2>(V1 a, V2 b) where V1 : struct, IIntrinsicValue where V2 : struct, IIntrinsicValue { return default(V1); }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Noise() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Normalize() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Pow() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Printf() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Process2DQuadTessFactorsAvg() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Process2DQuadTessFactorsMax() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Process2DQuadTessFactorsMin() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void ProcessIsolineTessFactors() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void ProcessQuadTessFactorsAvg() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void ProcessQuadTessFactorsMax() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void ProcessQuadTessFactorsMin() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void ProcessTriTessFactorsAvg() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void ProcessTriTessFactorsMax() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void ProcessTriTessFactorsMin() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Radians() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Rcp() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Reflect() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Refract() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Reversebits() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Round() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Rsqrt() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Saturate() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Sign() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Sincos() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Sinh() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Smoothstep() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Sqrt() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Step() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Tan() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Tanh() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Tex1D() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Tex1Dbias() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Tex1Dgrad() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Tex1Dlod() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Tex1Dproj() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Tex2D() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Tex2Dbias() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Tex2Dgrad() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Tex2Dlod() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Tex2Dproj() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Tex3D() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Tex3Dbias() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Tex3Dgrad() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Tex3Dlod() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Tex3Dproj() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void TexCUBE() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void TexCUBEbias() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void TexCUBEgrad() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void TexCUBElod() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void TexCUBEproj() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Transpose() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "HLSL")]
		protected void Truncate() {  }
	}
}