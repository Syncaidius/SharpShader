
using System;

namespace SharpShader
{
	public abstract class CSharpShader
	{
		// TODO CRITICAL: store intrinsic entries by C# name instead of their native language name, otherwise multiple methods will be generated with the same C# name, regardless of return/parameter types.


		/// <summary>HLSL: Submits an error message to the information queue and terminates the current draw or dispatch call being executed.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "abort")]
		protected void Abort() {  }

		/// <summary>HLSL: Returns the absolute value of the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "abs")]
		protected Int32 Abs(Int32 x) { return default(Int32); }

		/// <summary>HLSL: Returns the absolute value of the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "abs")]
		protected Single Abs(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the absolute value of the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "abs")]
		protected T Abs<T>() where T : struct, IIntrinsicValue { return default(T); }

		/// <summary>HLSL: Returns the arccosine of the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "acos")]
		protected Single Acos(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the arccosine of the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "acos")]
		protected T Acos<T>() where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Determines if all components of the specified value are non-zero.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "all")]
		protected Boolean All(Int32 x) { return default(Boolean); }

		/// <summary>HLSL: Determines if all components of the specified value are non-zero.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "all")]
		protected Boolean All(Single x) { return default(Boolean); }

		/// <summary>HLSL: Determines if all components of the specified value are non-zero.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "all")]
		protected Boolean All(Boolean x) { return default(Boolean); }

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
		protected Boolean Any(Int32 x) { return default(Boolean); }

		/// <summary>HLSL: Determines if any components of the specified value are non-zero.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "any")]
		protected Boolean Any(Single x) { return default(Boolean); }

		/// <summary>HLSL: Determines if any components of the specified value are non-zero.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "any")]
		protected Boolean Any(Boolean x) { return default(Boolean); }

		/// <summary>HLSL: Determines if any components of the specified value are non-zero.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "any")]
		protected Boolean Any<T>(T x) where T : struct, IIntrinsicValue { return default(Boolean); }

		/// <summary>HLSL: Reinterprets a cast value (two 32-bit values) into a double.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "asdouble")]
		protected Double AsDouble(UInt32 lowBits, UInt32 highBits) { return default(Double); }

		/// <summary>HLSL: Interprets the bit pattern of x as a floating-point number.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "asfloat")]
		protected Single AsFloat(UInt32 x) { return default(Single); }

		/// <summary>HLSL: Interprets the bit pattern of x as a floating-point number.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "asfloat")]
		protected Single AsFloat(Int32 x) { return default(Single); }

		/// <summary>HLSL: Interprets the bit pattern of x as a floating-point number.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "asfloat")]
		protected T AsFloat<T>(T x) where T : struct, IIntrinsicValue { return default(T); }

		/// <summary>HLSL: Returns the arcsine of the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "asin")]
		protected Single Asin(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the arcsine of the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "asin")]
		protected T Asin<T>() where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Interprets the bit pattern of x as an integer.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "asint")]
		protected Int32 AsInt(UInt32 x) { return default(Int32); }

		/// <summary>HLSL: Interprets the bit pattern of x as an integer.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "asint")]
		protected Int32 AsInt(Single x) { return default(Int32); }

		/// <summary>HLSL: Interprets the bit pattern of x as an integer.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "asint")]
		protected T AsInt<T>(T x) where T : struct, IIntrinsicValue { return default(T); }

		/// <summary>HLSL: Interprets the bit pattern of x as an unsigned integer, or reinterprets the bit pattern of a double as two unsigned 32-bit integers.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "asuint")]
		protected UInt32 AsUInt(Int32 x) { return default(UInt32); }

		/// <summary>HLSL: Interprets the bit pattern of x as an unsigned integer, or reinterprets the bit pattern of a double as two unsigned 32-bit integers.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "asuint")]
		protected UInt32 AsUInt(Single x) { return default(UInt32); }

		/// <summary>HLSL: Interprets the bit pattern of x as an unsigned integer, or reinterprets the bit pattern of a double as two unsigned 32-bit integers.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "asuint")]
		protected T AsUInt<T>(T x) where T : struct, IIntrinsicValue { return default(T); }

		/// <summary>HLSL: Interprets the bit pattern of x as an unsigned integer, or reinterprets the bit pattern of a double as two unsigned 32-bit integers.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "asuint")]
		protected void AsUInt(Double x, out UInt32 lowBits, out UInt32 highBits) { highBits = default(UInt32); lowBits = default(UInt32); }

		/// <summary>HLSL: Returns the arctangent of the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "atan")]
		protected Single Atan(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the arctangent of the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "atan")]
		protected T Atan<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns the arctangent of two values (x,y).</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "atan2")]
		protected Single Atan2(Single y, Single x) { return default(Single); }

		/// <summary>HLSL: Returns the arctangent of two values (x,y).</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "atan2")]
		protected T Atan2<T>(Single y, T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns the smallest integer value that is greater than or equal to the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ceil")]
		protected Single Ceil(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the smallest integer value that is greater than or equal to the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ceil")]
		protected T Ceil<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Determines whether all values from a Sample, Gather, or Load operation accessed mapped tiles in a tiled resource.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "CheckAccessFullyMapped")]
		protected void CheckAccessFullyMapped() {  }

		/// <summary>HLSL: Clamps the specified value to the specified minimum and maximum range.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "clamp")]
		protected Single Clamp(Single x, Single min, Single max) { return default(Single); }

		/// <summary>HLSL: Clamps the specified value to the specified minimum and maximum range.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "clamp")]
		protected Int32 Clamp(Int32 x, Int32 min, Int32 max) { return default(Int32); }

		/// <summary>HLSL: Clamps the specified value to the specified minimum and maximum range.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "clamp")]
		protected T Clamp<T>(T x, T min, T max) where T : struct, IIntrinsicValue { return default(T); }

		/// <summary>HLSL: Discards the current pixel if the specified value is less than zero.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "clip")]
		protected void Clip(Single x) {  }

		/// <summary>HLSL: Discards the current pixel if the specified value is less than zero.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "clip")]
		protected void Clip<T>(T x) where T : struct, IIntrinsicValue {  }

		/// <summary>HLSL: Returns the cosine of the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "cos")]
		protected Single Cos(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the cosine of the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "cos")]
		protected T Cos<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns the hyperbolic cosine of the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "cosh")]
		protected Single CosH(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the hyperbolic cosine of the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "cosh")]
		protected T CosH<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Counts the number of bits (per component) in the input integer.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "countbits")]
		protected UInt32 CountBits(UInt32 x) { return default(UInt32); }

		/// <summary>HLSL: Counts the number of bits (per component) in the input integer.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "countbits")]
		protected UInt2 CountBits(UInt2 x) { return default(UInt2); }

		/// <summary>HLSL: Counts the number of bits (per component) in the input integer.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "countbits")]
		protected UInt3 CountBits(UInt3 x) { return default(UInt3); }

		/// <summary>HLSL: Counts the number of bits (per component) in the input integer.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "countbits")]
		protected UInt4 CountBits(UInt4 x) { return default(UInt4); }

		/// <summary>HLSL: Returns the cross product of two floating-point, 3D vectors.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "cross")]
		protected T Cross<T>(T x, T y) where T : struct, IVector<Single> { return default(T); }

		/// <summary>HLSL:  Converts a floating-point, 4D vector set by a D3DCOLOR to a UBYTE4 (a UInt32). I can be used to swizzle and scale components of the x parameter. Use this function to compensate for the lack of UBYTE4 support in some hardware.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "D3DCOLORtoUBYTE4")]
		protected UInt32 D3dColorToUByte4<T>(T x) where T : struct, IVector<Single> { return default(UInt32); }

		/// <summary>HLSL: Returns the partial derivative of the specified value with respect to the screen-space x-coordinate. This function is only supported in pixel shaders.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ddx")]
		protected Single Ddx(Single value) { return default(Single); }

		/// <summary>HLSL: Returns the partial derivative of the specified value with respect to the screen-space x-coordinate. This function is only supported in pixel shaders.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ddx")]
		protected T Ddx<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Computes a low precision partial derivative with respect to the screen-space x-coordinate.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ddx_coarse")]
		protected Single DdxCourse(Single value) { return default(Single); }

		/// <summary>HLSL: Computes a low precision partial derivative with respect to the screen-space x-coordinate.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ddx_coarse")]
		protected Vector2 DdxCourse(Vector2 value) { return default(Vector2); }

		/// <summary>HLSL: Computes a low precision partial derivative with respect to the screen-space x-coordinate.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ddx_coarse")]
		protected Vector3 DdxCourse(Vector3 value) { return default(Vector3); }

		/// <summary>HLSL: Computes a low precision partial derivative with respect to the screen-space x-coordinate.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ddx_coarse")]
		protected Vector4 DdxCourse(Vector4 value) { return default(Vector4); }

		/// <summary>HLSL: Computes a high precision partial derivative with respect to the screen-space x-coordinate.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ddx_fine")]
		protected Single DdxFine(Single value) { return default(Single); }

		/// <summary>HLSL: Computes a high precision partial derivative with respect to the screen-space x-coordinate.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ddx_fine")]
		protected Vector2 DdxFine(Vector2 value) { return default(Vector2); }

		/// <summary>HLSL: Computes a high precision partial derivative with respect to the screen-space x-coordinate.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ddx_fine")]
		protected Vector3 DdxFine(Vector3 value) { return default(Vector3); }

		/// <summary>HLSL: Computes a high precision partial derivative with respect to the screen-space x-coordinate.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ddx_fine")]
		protected Vector4 DdxFine(Vector4 value) { return default(Vector4); }

		/// <summary>HLSL: Returns the partial derivative of the specified value with respect to the screen-space y-coordinate. This function is only supported in pixel shaders.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ddy")]
		protected Single Ddy(Single value) { return default(Single); }

		/// <summary>HLSL: Returns the partial derivative of the specified value with respect to the screen-space y-coordinate. This function is only supported in pixel shaders.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ddy")]
		protected T Ddy<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Computes a low precision partial derivative with respect to the screen-space y-coordinate.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ddy_coarse")]
		protected Single DdyCourse(Single value) { return default(Single); }

		/// <summary>HLSL: Computes a low precision partial derivative with respect to the screen-space y-coordinate.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ddy_coarse")]
		protected Vector2 DdyCourse(Vector2 value) { return default(Vector2); }

		/// <summary>HLSL: Computes a low precision partial derivative with respect to the screen-space y-coordinate.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ddy_coarse")]
		protected Vector3 DdyCourse(Vector3 value) { return default(Vector3); }

		/// <summary>HLSL: Computes a low precision partial derivative with respect to the screen-space y-coordinate.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ddy_coarse")]
		protected Vector4 DdyCourse(Vector4 value) { return default(Vector4); }

		/// <summary>HLSL: Computes a high precision partial derivative with respect to the screen-space y-coordinate.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ddy_fine")]
		protected Single DdyFine(Single value) { return default(Single); }

		/// <summary>HLSL: Computes a high precision partial derivative with respect to the screen-space y-coordinate.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ddy_fine")]
		protected Vector2 DdyFine(Vector2 value) { return default(Vector2); }

		/// <summary>HLSL: Computes a high precision partial derivative with respect to the screen-space y-coordinate.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ddy_fine")]
		protected Vector3 DdyFine(Vector3 value) { return default(Vector3); }

		/// <summary>HLSL: Computes a high precision partial derivative with respect to the screen-space y-coordinate.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ddy_fine")]
		protected Vector4 DdyFine(Vector4 value) { return default(Vector4); }

		/// <summary>HLSL: Converts the specified value from radians to degrees.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "degrees")]
		protected Single Degrees(Single x) { return default(Single); }

		/// <summary>HLSL: Converts the specified value from radians to degrees.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "degrees")]
		protected T Degrees<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns the determinant of the specified floating-point, square matrix.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "determinant")]
		protected Single Determinant<T>(T m) where T : struct, IMatrix<Single> { return default(Single); }

		/// <summary>HLSL: Blocks execution of all threads in a group until all device memory accesses have been completed.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "DeviceMemoryBarrier")]
		protected void DeviceMemoryBarrier() {  }

		/// <summary>HLSL: Blocks execution of all threads in a group until all device memory accesses have been completed and all threads in the group have reached this call.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "DeviceMemoryBarrierWithGroupSync")]
		protected void DeviceMemoryBarrierWithGroupSync() {  }

		/// <summary>HLSL: Returns a distance scalar between two vectors.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "distance")]
		protected Single Distance<T>(T x, T y) where T : struct, IVector<Single> { return default(Single); }

		/// <summary>HLSL: Returns the dot product of two vectors.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "dot")]
		protected Single Dot<T>(T x, T y) where T : struct, IVector<Single> { return default(Single); }

		/// <summary>HLSL: Returns the dot product of two vectors.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "dot")]
		protected Int2 Dot(Int2 x, Int2 y) { return default(Int2); }

		/// <summary>HLSL: Returns the dot product of two vectors.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "dot")]
		protected Int32 Dot(Int3 x, Int3 y) { return default(Int32); }

		/// <summary>HLSL: Returns the dot product of two vectors.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "dot")]
		protected Int32 Dot(Int4 x, Int4 y) { return default(Int32); }

		/// <summary>HLSL: Calculates a distance vector. This intrinsic function provides the same functionality as the Vertex Shader instruction dst.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "dst")]
		protected T Dst<T>(T x, T y) where T : struct, IVector<Single> { return default(T); }

		/// <summary>HLSL: Submits an error message to the information queue.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "errorf")]
		protected void Errorf(String format, params Object[] args) {  }

		/// <summary>HLSL: Evaluates at the pixel centroid. TODO: NOT IMPLEMENTED.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "EvaluateAttributeAtCentroid")]
		protected void EvaluateAttributeAtCentroid() {  }

		/// <summary>HLSL: Evaluates at the indexed sample location. TODO: NOT IMPLEMENTED.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "EvaluateAttributeAtSample")]
		protected void EvaluateAttributeAtSample() {  }

		/// <summary>HLSL: Evaluates at the pixel centroid with an offset. TODO: NOT IMPLEMENTED.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "EvaluateAttributeSnapped")]
		protected void EvaluateAttributeSnapped() {  }

		/// <summary>HLSL: Returns the base-e exponential, or ex, of the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "exp")]
		protected Single Exp(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the base-e exponential, or ex, of the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "exp")]
		protected T Exp<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns the base 2 exponential, or 2x, of the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "exp2")]
		protected Single Exp2(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the base 2 exponential, or 2x, of the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "exp2")]
		protected T Exp2<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Converts the float16 stored in the low-half of the uint to a float.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "f16tof32")]
		protected Single F16toF32(UInt32 value) { return default(Single); }

		/// <summary>HLSL: Converts the float16 stored in the low-half of the uint to a float.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "f16tof32")]
		protected Vector2 F16toF32(UInt2 value) { return default(Vector2); }

		/// <summary>HLSL: Converts the float16 stored in the low-half of the uint to a float.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "f16tof32")]
		protected Vector3 F16toF32(UInt3 value) { return default(Vector3); }

		/// <summary>HLSL: Converts the float16 stored in the low-half of the uint to a float.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "f16tof32")]
		protected Vector4 F16toF32(UInt4 value) { return default(Vector4); }

		/// <summary>HLSL: Converts an input into a float16 type.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "f32tof16")]
		protected UInt32 F32toF16(Single value) { return default(UInt32); }

		/// <summary>HLSL: Converts an input into a float16 type.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "f32tof16")]
		protected UInt2 F32toF16(Vector2 value) { return default(UInt2); }

		/// <summary>HLSL: Converts an input into a float16 type.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "f32tof16")]
		protected UInt3 F32toF16(Vector3 value) { return default(UInt3); }

		/// <summary>HLSL: Converts an input into a float16 type.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "f32tof16")]
		protected UInt4 F32toF16(Vector4 value) { return default(UInt4); }

		/// <summary>HLSL: Flips the surface-normal (if needed) to face in a direction opposite to i; returns the result in n.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "faceforward")]
		protected T FaceForward<T>(T n, T i, T ng) where T : struct, IVector<float> { return default(T); }

		/// <summary>HLSL: Gets the location of the first set bit starting from the highest order bit and working downward, per component.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "firstbithigh")]
		protected Int32 FirstBitHigh(Int32 value) { return default(Int32); }

		/// <summary>HLSL: Gets the location of the first set bit starting from the highest order bit and working downward, per component.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "firstbithigh")]
		protected UInt32 FirstBitHigh() { return default(UInt32); }

		/// <summary>HLSL: Gets the location of the first set bit starting from the highest order bit and working downward, per component.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "firstbithigh")]
		protected T FirstBitHigh<T>(T value) where T : struct, IVector<Int32> { return default(T); }

		/// <summary>HLSL: Gets the location of the first set bit starting from the highest order bit and working downward, per component.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "firstbithigh")]
		protected UInt2 FirstBitHigh(UInt2 value) { return default(UInt2); }

		/// <summary>HLSL: Gets the location of the first set bit starting from the highest order bit and working downward, per component.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "firstbithigh")]
		protected UInt3 FirstBitHigh(UInt3 value) { return default(UInt3); }

		/// <summary>HLSL: Gets the location of the first set bit starting from the highest order bit and working downward, per component.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "firstbithigh")]
		protected UInt4 FirstBitHigh(UInt4 value) { return default(UInt4); }

		/// <summary>HLSL: Returns the location of the first set bit starting from the lowest order bit and working upward, per component.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "firstbitlow")]
		protected Int32 FirstBitLow(Int32 value) { return default(Int32); }

		/// <summary>HLSL: Returns the location of the first set bit starting from the lowest order bit and working upward, per component.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "firstbitlow")]
		protected T FirstBitLow<T>(T value) where T : struct, IVector<UInt32> { return default(T); }

		/// <summary>HLSL: Returns the largest integer value that is lesss than or equal to the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "floor")]
		protected Single Floor(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the largest integer value that is lesss than or equal to the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "floor")]
		protected T Floor<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns the double-precision fused multiply-addition of a * b + c.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "fma")]
		protected Double Fma(Double a, Double b, Double c) { return default(Double); }

		/// <summary>HLSL: Returns the double-precision fused multiply-addition of a * b + c.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "fma")]
		protected T Fma<T>(T b, T c) where T : struct, IIntrinsicValue<Double> { return default(T); }

		/// <summary>HLSL: Returns the floating-point remainder of x/y.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "fmod")]
		protected Single Fmod(Single x, Single y) { return default(Single); }

		/// <summary>HLSL: Returns the floating-point remainder of x/y.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "fmod")]
		protected T Fmod<T>(T x, T y) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns the fractional (or decimal) part of x; which is greater than or equal to 0 and less than 1.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "frac")]
		protected Single Frac(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the fractional (or decimal) part of x; which is greater than or equal to 0 and less than 1.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "frac")]
		protected T Frac<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns the mantissa and exponent of the specified floating-point value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "frexp")]
		protected Single Frexp(Single x, Single exp) { return default(Single); }

		/// <summary>HLSL: Returns the mantissa and exponent of the specified floating-point value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "frexp")]
		protected T Frexp<T>(T x, T exp) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns the absolute value of the partial derivatives of the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "fwidth")]
		protected Single Fwidth(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the absolute value of the partial derivatives of the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "fwidth")]
		protected T Fwidth<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Gets the number of samples for a render target.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "GetRenderTargetSampleCount")]
		protected UInt32 GetRenderTargetSampleCount() { return default(UInt32); }

		/// <summary>HLSL: Gets the sampling position (x,y) for a given sample index.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "GetRenderTargetSamplePosition")]
		protected Int2 GetRenderTargetSamplePosition() { return default(Int2); }

		/// <summary>HLSL: Blocks execution of all threads in a group until all group shared accesses have been completed.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "GroupMemoryBarrier")]
		protected void GroupMemoryBarrier() {  }

		/// <summary>HLSL: Blocks execution of all threads in a group until all group shared accesses have been completed and all threads in the group have reached this call.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "GroupMemoryBarrierWithSync")]
		protected void GroupMemoryBarrierWithSync() {  }

		/// <summary>HLSL: Performs a guaranteed atomic add of value to the dest resource variable.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedAdd")]
		protected void InterlockedAdd(Int32 dest, Int32 value) {  }

		/// <summary>HLSL: Performs a guaranteed atomic add of value to the dest resource variable.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedAdd")]
		protected void InterlockedAdd(Int32 dest, Int32 value, out Int32 original_value) { original_value = default(Int32); }

		/// <summary>HLSL: Performs a guaranteed atomic add of value to the dest resource variable.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedAdd")]
		protected void InterlockedAdd(UInt32 dest, UInt32 value) {  }

		/// <summary>HLSL: Performs a guaranteed atomic add of value to the dest resource variable.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedAdd")]
		protected void InterlockedAdd(UInt32 dest, UInt32 value, out UInt32 original_value) { original_value = default(UInt32); }

		/// <summary>HLSL: Performs a guaranteed atomic and.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedAnd")]
		protected void InterlockedAnd(Int32 dest, Int32 value) {  }

		/// <summary>HLSL: Performs a guaranteed atomic and.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedAnd")]
		protected void InterlockedAnd(Int32 dest, Int32 value, out Int32 original_value) { original_value = default(Int32); }

		/// <summary>HLSL: Performs a guaranteed atomic and.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedAnd")]
		protected void InterlockedAnd(UInt32 dest, UInt32 value) {  }

		/// <summary>HLSL: Performs a guaranteed atomic and.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedAnd")]
		protected void InterlockedAnd(UInt32 dest, UInt32 value, out UInt32 original_value) { original_value = default(UInt32); }

		/// <summary>HLSL: Atomically compares the destination with the comparison value. If they are identical, the destination is overwritten with the input value. The original value is set to the destination's original value. Note: If you call InterlockedCompareExchange in a for or while compute shader loop, to properly compile, you must use the [allow_uav_condition] attribute on that loop.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedCompareExchange")]
		protected void InterlockedCompareExchange(Int32 dest, Int32 compare_value, Int32 value, out Int32 original_value) { original_value = default(Int32); }

		/// <summary>HLSL: Atomically compares the destination with the comparison value. If they are identical, the destination is overwritten with the input value. The original value is set to the destination's original value. Note: If you call InterlockedCompareExchange in a for or while compute shader loop, to properly compile, you must use the [allow_uav_condition] attribute on that loop.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedCompareExchange")]
		protected void InterlockedCompareExchange(UInt32 dest, UInt32 compare_value, UInt32 value, out UInt32 original_value) { original_value = default(UInt32); }

		/// <summary>HLSL: Atomically compares the destination with the comparison value. If they are identical, the destination is overwritten with the input value. The original value is set to the destination's original value. Note: If you call InterlockedCompareExchange in a for or while compute shader loop, to properly compile, you must use the [allow_uav_condition] attribute on that loop.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedCompareStore")]
		protected void InterlockedCompareStore(Int32 dest, Int32 compare_value, Int32 value) {  }

		/// <summary>HLSL: Atomically compares the destination with the comparison value. If they are identical, the destination is overwritten with the input value. The original value is set to the destination's original value. Note: If you call InterlockedCompareExchange in a for or while compute shader loop, to properly compile, you must use the [allow_uav_condition] attribute on that loop.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedCompareStore")]
		protected void InterlockedCompareStore(UInt32 dest, UInt32 compare_value, UInt32 value) {  }

		/// <summary>HLSL: Assigns value to dest and returns the original value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedExchange")]
		protected void InterlockedExchange(Int32 dest, Int32 value, out Int32 original_value) { original_value = default(Int32); }

		/// <summary>HLSL: Assigns value to dest and returns the original value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedExchange")]
		protected void InterlockedExchange(UInt32 dest, UInt32 value, out UInt32 original_value) { original_value = default(UInt32); }

		/// <summary>HLSL: Performs a guaranteed atomic max.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedMax")]
		protected void InterlockedMax(Int32 dest, Int32 value) {  }

		/// <summary>HLSL: Performs a guaranteed atomic max.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedMax")]
		protected void InterlockedMax(Int32 dest, Int32 value, out Int32 original_value) { original_value = default(Int32); }

		/// <summary>HLSL: Performs a guaranteed atomic max.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedMax")]
		protected void InterlockedMax(UInt32 dest, UInt32 value) {  }

		/// <summary>HLSL: Performs a guaranteed atomic max.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedMax")]
		protected void InterlockedMax(UInt32 dest, UInt32 value, out UInt32 original_value) { original_value = default(UInt32); }

		/// <summary>HLSL: Performs a guaranteed atomic min.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedMin")]
		protected void InterlockedMin(Int32 dest, Int32 value) {  }

		/// <summary>HLSL: Performs a guaranteed atomic min.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedMin")]
		protected void InterlockedMin(Int32 dest, Int32 value, out Int32 original_value) { original_value = default(Int32); }

		/// <summary>HLSL: Performs a guaranteed atomic min.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedMin")]
		protected void InterlockedMin(UInt32 dest, UInt32 value) {  }

		/// <summary>HLSL: Performs a guaranteed atomic min.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedMin")]
		protected void InterlockedMin(UInt32 dest, UInt32 value, out UInt32 original_value) { original_value = default(UInt32); }

		/// <summary>HLSL: Performs a guaranteed atomic or.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedOr")]
		protected void InterlockedOr(Int32 dest, Int32 value) {  }

		/// <summary>HLSL: Performs a guaranteed atomic or.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedOr")]
		protected void InterlockedOr(Int32 dest, Int32 value, out Int32 original_value) { original_value = default(Int32); }

		/// <summary>HLSL: Performs a guaranteed atomic or.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedOr")]
		protected void InterlockedOr(UInt32 dest, UInt32 value) {  }

		/// <summary>HLSL: Performs a guaranteed atomic or.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedOr")]
		protected void InterlockedOr(UInt32 dest, UInt32 value, out UInt32 original_value) { original_value = default(UInt32); }

		/// <summary>HLSL: Performs a guaranteed atomic xor.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedXor")]
		protected void InterlockedXor(Int32 dest, Int32 value) {  }

		/// <summary>HLSL: Performs a guaranteed atomic xor.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedXor")]
		protected void InterlockedXor(Int32 dest, Int32 value, out Int32 original_value) { original_value = default(Int32); }

		/// <summary>HLSL: Performs a guaranteed atomic xor.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedXor")]
		protected void InterlockedXor(UInt32 dest, UInt32 value) {  }

		/// <summary>HLSL: Performs a guaranteed atomic xor.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "InterlockedXor")]
		protected void InterlockedXor(UInt32 dest, UInt32 value, out UInt32 original_value) { original_value = default(UInt32); }

		/// <summary>HLSL: Determines if the specified floating-point value is finite.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "isfinite")]
		protected Boolean IsFinite(Single x) { return default(Boolean); }

		/// <summary>HLSL: Determines if the specified floating-point value is finite.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "isfinite")]
		protected R IsFinite<T, R>(T x) where T : struct, IIntrinsicValue<Single> where R : struct, IIntrinsicValue<Boolean> { return default(R); }

		/// <summary>HLSL: Determines if the specified floating-point value is infinite. Returns a value of the same size as the input, with a value set to True if the x parameter is +INF or -INF. Otherwise, False.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "isinf")]
		protected Boolean IsInf(Single x) { return default(Boolean); }

		/// <summary>HLSL: Determines if the specified floating-point value is infinite. Returns a value of the same size as the input, with a value set to True if the x parameter is +INF or -INF. Otherwise, False.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "isinf")]
		protected R IsInf<T, R>(T x) where T : struct, IIntrinsicValue<Single> where R : struct, IIntrinsicValue<Boolean> { return default(R); }

		/// <summary>HLSL: Determines if the specified value is NAN or QNAN.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "isnan")]
		protected Boolean IsNan(Single x) { return default(Boolean); }

		/// <summary>HLSL: Determines if the specified value is NAN or QNAN.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "isnan")]
		protected R IsNan<T, R>(T x) where T : struct, IIntrinsicValue<Single> where R : struct, IIntrinsicValue<Boolean> { return default(R); }

		/// <summary>HLSL: Returns the result of multiplying the specified value by two, raised to the power of the specified exponent.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ldexp")]
		protected Single Ldexp(Single x, Single exp) { return default(Single); }

		/// <summary>HLSL: Returns the result of multiplying the specified value by two, raised to the power of the specified exponent.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "ldexp")]
		protected T Ldexp<T>(T x, T exp) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns the length of the specified floating-point vector.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "length")]
		protected Single Length<T>(T x) where T : struct, IVector<Single> { return default(Single); }

		/// <summary>HLSL: Performs a linear interpolation.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "lerp")]
		protected Single Lerp(Single x, Single y, Single s) { return default(Single); }

		/// <summary>HLSL: Performs a linear interpolation.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "lerp")]
		protected T Lerp<T>(T x, T y, T s) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns a lighting coefficient vector. This function returns a lighting coefficient vector (ambient, diffuse, specular, 1) </summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "lit")]
		protected Vector4 Lit(Single n_dot_l, Single n_dot_h, Single m) { return default(Vector4); }

		/// <summary>HLSL: Returns the base-e logarithm of the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "log")]
		protected Single Log(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the base-e logarithm of the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "log")]
		protected T Log<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns the base-10 logarithm of the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "log10")]
		protected Single Log10(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the base-10 logarithm of the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "log10")]
		protected T Log10<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns the base-2 logarithm of the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "log2")]
		protected Single Log2(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the base-2 logarithm of the specified value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "log2")]
		protected T Log2<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Performs an arithmetic multiply/add operation on three values.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "mad")]
		protected Single Mad(Single mValue, Single aValue, Single bValue) { return default(Single); }

		/// <summary>HLSL: Performs an arithmetic multiply/add operation on three values.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "mad")]
		protected Int32 Mad(Int32 mValue, Int32 aValue, Int32 bValue) { return default(Int32); }

		/// <summary>HLSL: Performs an arithmetic multiply/add operation on three values.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "mad")]
		protected UInt32 Mad(UInt32 mValue, UInt32 aValue, UInt32 bValue) { return default(UInt32); }

		/// <summary>HLSL: Performs an arithmetic multiply/add operation on three values.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "mad")]
		protected T Mad<T>(T mValue, T aValue, T bValue) where T : struct, IVector { return default(T); }

		/// <summary>HLSL: Selects the greater of x and y.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "max")]
		protected Single Max(Single x, Single y) { return default(Single); }

		/// <summary>HLSL: Selects the greater of x and y.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "max")]
		protected Int32 Max(Int32 x, Int32 y) { return default(Int32); }

		/// <summary>HLSL: Selects the greater of x and y.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "max")]
		protected T Max<T>(T x, T y) where T : struct, IIntrinsicValue { return default(T); }

		/// <summary>HLSL: Selects the greater of x and y.</summary>
		[ShaderIntrinsic(ShaderLanguage.GLSL, "max")]
		protected void Max() {  }

		/// <summary>HLSL: Selects the lesser of x and y.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "min")]
		protected Single Min(Single x, Single y) { return default(Single); }

		/// <summary>HLSL: Selects the lesser of x and y.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "min")]
		protected Int32 Min(Int32 x, Int32 y) { return default(Int32); }

		/// <summary>HLSL: Selects the lesser of x and y.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "min")]
		protected T Min<T>(T x, T y) where T : struct, IIntrinsicValue { return default(T); }

		/// <summary>HLSL: Selects the lesser of x and y.</summary>
		[ShaderIntrinsic(ShaderLanguage.GLSL, "min")]
		protected void Min() {  }

		/// <summary>HLSL: Splits the value x into fractional and integer parts, each of which has the same sign as x. Returns the signed-fractional portion of x.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "modf")]
		protected Single Modf(Single x, Single ip) { return default(Single); }

		/// <summary>HLSL: Splits the value x into fractional and integer parts, each of which has the same sign as x. Returns the signed-fractional portion of x.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "modf")]
		protected Int32 Modf(Int32 x, Int32 ip) { return default(Int32); }

		/// <summary>HLSL: Splits the value x into fractional and integer parts, each of which has the same sign as x. Returns the signed-fractional portion of x.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "modf")]
		protected T Modf<T>(T x, out T integerPortion) where T : struct, IIntrinsicValue { integerPortion = default(T); return default(T); }

		/// <summary>HLSL: Compares a 4-byte reference value and an 8-byte source value and accumulates a vector of 4 sums. Each sum corresponds to the masked sum of absolute differences of a different byte alignment between the reference value and the source value.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "msad4")]
		protected void Msad4(UInt32 reference, UInt2 source, UInt4 accum) {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "mul")]
		protected Single Mul(Single a, Single b) { return default(Single); }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "mul")]
		protected Int32 Mul(Int32 a, Int32 b) { return default(Int32); }

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
		protected void ReverseBits() {  }

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
		protected void SinCos() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "sinh")]
		protected void SinH() {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(ShaderLanguage.HLSL, "smoothstep")]
		protected void SmoothStep() {  }

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