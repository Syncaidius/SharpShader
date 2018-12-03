
using System;

namespace SharpShader
{
	public abstract class CSharpShader
	{
		protected void Abort() {  }

		protected void Abs() {  }

		protected void Acos() {  }

		protected void All() {  }

		protected void AllMemoryBarrier() {  }

		protected void AllMemoryBarrierWithGroupSync() {  }

		protected void Any() {  }

		protected void Asdouble() {  }

		protected void Asfloat() {  }

		protected void Asin() {  }

		protected void Asint() {  }

		protected void Asuint() {  }

		protected void Atan() {  }

		protected void Atan2() {  }

		protected void Ceil() {  }

		protected void CheckAccessFullyMapped() {  }

		protected void Clamp() {  }

		protected void Clip() {  }

		protected void Cos() {  }

		protected void Cosh() {  }

		protected void Countbits() {  }

		protected void Cross() {  }

		protected void D3DCOLORtoUBYTE4() {  }

		protected void Ddx() {  }

		protected void Ddx_coarse() {  }

		protected void Ddx_fine() {  }

		protected void Ddy() {  }

		protected void Ddy_coarse() {  }

		protected void Ddy_fine() {  }

		protected void Degrees() {  }

		protected void Determinant() {  }

		protected void DeviceMemoryBarrier() {  }

		protected void DeviceMemoryBarrierWithGroupSync() {  }

		protected void Distance() {  }

		protected void Dot() {  }

		protected void Dst() {  }

		protected void Errorf() {  }

		protected void EvaluateAttributeAtCentroid() {  }

		protected void EvaluateAttributeAtSample() {  }

		protected void EvaluateAttributeSnapped() {  }

		protected void Exp() {  }

		protected void Exp2() {  }

		protected void F16tof32() {  }

		protected void F32tof16() {  }

		protected void Faceforward() {  }

		protected void Firstbithigh() {  }

		protected void Firstbitlow() {  }

		protected void Floor() {  }

		protected void Fma() {  }

		protected void Fmod() {  }

		protected void Frac() {  }

		protected void Frexp() {  }

		protected void Fwidth() {  }

		protected void GetRenderTargetSampleCount() {  }

		protected void GetRenderTargetSamplePosition() {  }

		protected void GroupMemoryBarrier() {  }

		protected void GroupMemoryBarrierWithSync() {  }

		protected void InterlockedAdd() {  }

		protected void InterlockedAnd() {  }

		protected void InterlockedCompareExchange() {  }

		protected void InterlockedCompareStore() {  }

		protected void InterlockedExchange() {  }

		protected void InterlockedMax() {  }

		protected void InterlockedMin() {  }

		protected void InterlockedOr() {  }

		protected void InterlockedXor() {  }

		protected void Isfinite() {  }

		protected void Isinf() {  }

		protected void Isnan() {  }

		protected void Ldexp() {  }

		protected void Length() {  }

		protected void Lerp() {  }

		protected void Lit() {  }

		protected void Log() {  }

		protected void Log10() {  }

		protected void Log2() {  }

		protected void Mad() {  }

		protected void Max() {  }

		protected void Min() {  }

		protected void Modf() {  }

		protected void Msad4() {  }

		protected Single Mul(Single a, Single b) { return default(Single); }

		protected Int32 Mul(Int32 a, Int32 b) { return default(Int32); }

		protected T Mul<T>(Single a, T b) where T : struct, IIntrinsicValue { return default(T); }

		protected T Mul<T>(Int32 a, T b) where T : struct, IIntrinsicValue { return default(T); }

		protected T Mul<T>(T a, Single b) where T : struct, IIntrinsicValue { return default(T); }

		protected T Mul<T>(T a, Int32 b) where T : struct, IIntrinsicValue { return default(T); }

		protected V1 Mul<V1, V2>(V1 a, V2 b) where V1 : struct, IIntrinsicValue where V2 : struct, IIntrinsicValue { return default(V1); }

		protected void Noise() {  }

		protected void Normalize() {  }

		protected void Pow() {  }

		protected void Printf() {  }

		protected void Process2DQuadTessFactorsAvg() {  }

		protected void Process2DQuadTessFactorsMax() {  }

		protected void Process2DQuadTessFactorsMin() {  }

		protected void ProcessIsolineTessFactors() {  }

		protected void ProcessQuadTessFactorsAvg() {  }

		protected void ProcessQuadTessFactorsMax() {  }

		protected void ProcessQuadTessFactorsMin() {  }

		protected void ProcessTriTessFactorsAvg() {  }

		protected void ProcessTriTessFactorsMax() {  }

		protected void ProcessTriTessFactorsMin() {  }

		protected void Radians() {  }

		protected void Rcp() {  }

		protected void Reflect() {  }

		protected void Refract() {  }

		protected void Reversebits() {  }

		protected void Round() {  }

		protected void Rsqrt() {  }

		protected void Saturate() {  }

		protected void Sign() {  }

		protected void Sincos() {  }

		protected void Sinh() {  }

		protected void Smoothstep() {  }

		protected void Sqrt() {  }

		protected void Step() {  }

		protected void Tan() {  }

		protected void Tanh() {  }

		protected void Tex1D() {  }

		protected void Tex1Dbias() {  }

		protected void Tex1Dgrad() {  }

		protected void Tex1Dlod() {  }

		protected void Tex1Dproj() {  }

		protected void Tex2D() {  }

		protected void Tex2Dbias() {  }

		protected void Tex2Dgrad() {  }

		protected void Tex2Dlod() {  }

		protected void Tex2Dproj() {  }

		protected void Tex3D() {  }

		protected void Tex3Dbias() {  }

		protected void Tex3Dgrad() {  }

		protected void Tex3Dlod() {  }

		protected void Tex3Dproj() {  }

		protected void TexCUBE() {  }

		protected void TexCUBEbias() {  }

		protected void TexCUBEgrad() {  }

		protected void TexCUBElod() {  }

		protected void TexCUBEproj() {  }

		protected void Transpose() {  }

		protected void Trunc() {  }

	}
}