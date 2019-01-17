
using System;

namespace SharpShader
{
	public abstract class CSharpShader
	{
		/// <summary>HLSL: Submits an error message to the information queue and terminates the current draw or dispatch call being executed.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "abort")]
		protected void Abort() {  }

		/// <summary>HLSL: Returns the absolute value of the specified value.<para/>
		/// GLSL: Returns the absolute value of the parameter.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "abs")]
		[ShaderIntrinsic(OutputLanguage.GLSL, "abs")]
		protected Int32 Abs(Int32 x) { return default(Int32); }

		/// <summary>HLSL: Returns the absolute value of the specified value.<para/>
		/// GLSL: Returns the absolute value of the parameter.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "abs")]
		[ShaderIntrinsic(OutputLanguage.GLSL, "abs")]
		protected Single Abs(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the absolute value of the specified value.<para/>
		/// GLSL: Returns the absolute value of the parameter.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "abs")]
		[ShaderIntrinsic(OutputLanguage.GLSL, "abs")]
		protected T Abs<T>(T x) where T : struct, IIntrinsicValue { return default(T); }

		/// <summary>HLSL: Returns the absolute value of the specified value.<para/>
		/// GLSL: Returns the absolute value of the parameter.</summary>
		[ShaderIntrinsic(OutputLanguage.GLSL, "abs")]
		protected Double Abs(Double x) { return default(Double); }

		/// <summary>HLSL: Returns the arccosine of the specified value.<para/>
		/// GLSL: Returns the arccosine of the parameter.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "acos")]
		[ShaderIntrinsic(OutputLanguage.GLSL, "acos")]
		protected Single Acos(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the arccosine of the specified value.<para/>
		/// GLSL: Returns the arccosine of the parameter.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "acos")]
		[ShaderIntrinsic(OutputLanguage.GLSL, "acos")]
		protected T Acos<T>() where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Determines if all components of the specified value are non-zero.<para/>
		/// GLSL: Determines if all components of the specified vector are true.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "all")]
		protected Boolean All(Int32 x) { return default(Boolean); }

		/// <summary>HLSL: Determines if all components of the specified value are non-zero.<para/>
		/// GLSL: Determines if all components of the specified vector are true.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "all")]
		protected Boolean All(Single x) { return default(Boolean); }

		/// <summary>HLSL: Determines if all components of the specified value are non-zero.<para/>
		/// GLSL: Determines if all components of the specified vector are true.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "all")]
		protected Boolean All(Boolean x) { return default(Boolean); }

		/// <summary>HLSL: Determines if all components of the specified value are non-zero.<para/>
		/// GLSL: Determines if all components of the specified vector are true.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "all")]
		[ShaderIntrinsic(OutputLanguage.GLSL, "all")]
		protected Boolean All<T>(T x) where T : struct, IIntrinsicValue { return default(Boolean); }

		/// <summary>HLSL: Blocks execution of all threads in a group until all memory accesses have been completed.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "AllMemoryBarrier")]
		[IntrinsicVersion(IntrinsicPipelineType.Compute, 5f, 3.402823E+38f)]
		protected void AllMemoryBarrier() {  }

		/// <summary>HLSL: Blocks execution of all threads in a group until all memory accesses have been completed and all threads in the group have reached this call.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "AllMemoryBarrierWithGroupSync")]
		protected void AllMemoryBarrierWithGroupSync() {  }

		/// <summary>HLSL: Determines if any components of the specified value are non-zero.<para/>
		/// GLSL: Determines if any components of the specified vector are true.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "any")]
		protected Boolean Any(Int32 x) { return default(Boolean); }

		/// <summary>HLSL: Determines if any components of the specified value are non-zero.<para/>
		/// GLSL: Determines if any components of the specified vector are true.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "any")]
		protected Boolean Any(Single x) { return default(Boolean); }

		/// <summary>HLSL: Determines if any components of the specified value are non-zero.<para/>
		/// GLSL: Determines if any components of the specified vector are true.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "any")]
		protected Boolean Any(Boolean x) { return default(Boolean); }

		/// <summary>HLSL: Determines if any components of the specified value are non-zero.<para/>
		/// GLSL: Determines if any components of the specified vector are true.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "any")]
		[ShaderIntrinsic(OutputLanguage.GLSL, "any")]
		protected Boolean Any<T>(T x) where T : struct, IIntrinsicValue { return default(Boolean); }

		/// <summary>HLSL: Reinterprets a cast value (two 32-bit values) into a double.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "asdouble")]
		protected Double AsDouble(UInt32 lowBits, UInt32 highBits) { return default(Double); }

		/// <summary>HLSL: Interprets the bit pattern of x as a floating-point number.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "asfloat")]
		protected Single AsFloat(UInt32 x) { return default(Single); }

		/// <summary>HLSL: Interprets the bit pattern of x as a floating-point number.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "asfloat")]
		protected Single AsFloat(Int32 x) { return default(Single); }

		/// <summary>HLSL: Interprets the bit pattern of x as a floating-point number.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "asfloat")]
		protected T AsFloat<T>(T x) where T : struct, IIntrinsicValue { return default(T); }

		/// <summary>HLSL: Returns the arcsine of the specified value.<para/>
		/// GLSL: Returns the arcsine of the parameter.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "asin")]
		[ShaderIntrinsic(OutputLanguage.GLSL, "asin")]
		protected Single Asin(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the arcsine of the specified value.<para/>
		/// GLSL: Returns the arcsine of the parameter.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "asin")]
		[ShaderIntrinsic(OutputLanguage.GLSL, "asin")]
		protected T Asin<T>() where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Interprets the bit pattern of x as an integer.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "asint")]
		protected Int32 AsInt(UInt32 x) { return default(Int32); }

		/// <summary>HLSL: Interprets the bit pattern of x as an integer.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "asint")]
		protected Int32 AsInt(Single x) { return default(Int32); }

		/// <summary>HLSL: Interprets the bit pattern of x as an integer.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "asint")]
		protected T AsInt<T>(T x) where T : struct, IIntrinsicValue { return default(T); }

		/// <summary>HLSL: Interprets the bit pattern of x as an unsigned integer, or reinterprets the bit pattern of a double as two unsigned 32-bit integers.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "asuint")]
		protected UInt32 AsUInt(Int32 x) { return default(UInt32); }

		/// <summary>HLSL: Interprets the bit pattern of x as an unsigned integer, or reinterprets the bit pattern of a double as two unsigned 32-bit integers.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "asuint")]
		protected UInt32 AsUInt(Single x) { return default(UInt32); }

		/// <summary>HLSL: Interprets the bit pattern of x as an unsigned integer, or reinterprets the bit pattern of a double as two unsigned 32-bit integers.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "asuint")]
		protected T AsUInt<T>(T x) where T : struct, IIntrinsicValue { return default(T); }

		/// <summary>HLSL: Interprets the bit pattern of x as an unsigned integer, or reinterprets the bit pattern of a double as two unsigned 32-bit integers.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "asuint")]
		protected void AsUInt(Double x, out UInt32 lowBits, out UInt32 highBits) { highBits = default(UInt32); lowBits = default(UInt32); }

		/// <summary>HLSL: Returns the arctangent of the specified value.<para/>
		/// GLSL: Return the arc-tangent of the parameters.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "atan")]
		[ShaderIntrinsic(OutputLanguage.GLSL, "atan")]
		protected Single Atan(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the arctangent of the specified value.<para/>
		/// GLSL: Return the arc-tangent of the parameters.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "atan")]
		[ShaderIntrinsic(OutputLanguage.GLSL, "atan")]
		protected T Atan<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns the arctangent of the specified value.<para/>
		/// GLSL: Return the arc-tangent of the parameters.</summary>
		[ShaderIntrinsic(OutputLanguage.GLSL, "atan")]
		protected Single Atan(Single y, Single x) { return default(Single); }

		/// <summary>HLSL: Returns the arctangent of the specified value.<para/>
		/// GLSL: Return the arc-tangent of the parameters.</summary>
		[ShaderIntrinsic(OutputLanguage.GLSL, "atan")]
		protected T Atan<T>(T y, T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns the arctangent of two values (x,y).</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "atan2")]
		protected Single Atan2(Single y, Single x) { return default(Single); }

		/// <summary>HLSL: Returns the arctangent of two values (x,y).</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "atan2")]
		protected T Atan2<T>(Single y, T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns the smallest integer value that is greater than or equal to the specified value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "ceil")]
		protected Single Ceil(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the smallest integer value that is greater than or equal to the specified value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "ceil")]
		protected T Ceil<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Determines whether all values from a Sample, Gather, or Load operation accessed mapped tiles in a tiled resource.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "CheckAccessFullyMapped")]
		protected void CheckAccessFullyMapped() {  }

		/// <summary>HLSL: Clamps the specified value to the specified minimum and maximum range.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "clamp")]
		protected Single Clamp(Single x, Single min, Single max) { return default(Single); }

		/// <summary>HLSL: Clamps the specified value to the specified minimum and maximum range.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "clamp")]
		protected Int32 Clamp(Int32 x, Int32 min, Int32 max) { return default(Int32); }

		/// <summary>HLSL: Clamps the specified value to the specified minimum and maximum range.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "clamp")]
		protected T Clamp<T>(T x, T min, T max) where T : struct, IIntrinsicValue { return default(T); }

		/// <summary>HLSL: Discards the current pixel if the specified value is less than zero.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "clip")]
		protected void Clip(Single x) {  }

		/// <summary>HLSL: Discards the current pixel if the specified value is less than zero.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "clip")]
		protected void Clip<T>(T x) where T : struct, IIntrinsicValue {  }

		/// <summary>HLSL: Returns the cosine of the specified value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "cos")]
		protected Single Cos(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the cosine of the specified value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "cos")]
		protected T Cos<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns the hyperbolic cosine of the specified value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "cosh")]
		protected Single CosH(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the hyperbolic cosine of the specified value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "cosh")]
		protected T CosH<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Counts the number of bits (per component) in the input integer.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "countbits")]
		protected UInt32 CountBits(UInt32 x) { return default(UInt32); }

		/// <summary>HLSL: Counts the number of bits (per component) in the input integer.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "countbits")]
		protected UInt2 CountBits(UInt2 x) { return default(UInt2); }

		/// <summary>HLSL: Counts the number of bits (per component) in the input integer.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "countbits")]
		protected UInt3 CountBits(UInt3 x) { return default(UInt3); }

		/// <summary>HLSL: Counts the number of bits (per component) in the input integer.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "countbits")]
		protected UInt4 CountBits(UInt4 x) { return default(UInt4); }

		/// <summary>HLSL: Returns the cross product of two floating-point, 3D vectors.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "cross")]
		protected T Cross<T>(T x, T y) where T : struct, IVector<Single> { return default(T); }

		/// <summary>HLSL:  Converts a floating-point, 4D vector set by a D3DCOLOR to a UBYTE4 (a UInt32). I can be used to swizzle and scale components of the x parameter. Use this function to compensate for the lack of UBYTE4 support in some hardware.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "D3DCOLORtoUBYTE4")]
		protected UInt32 D3dColorToUByte4<T>(T x) where T : struct, IVector<Single> { return default(UInt32); }

		/// <summary>HLSL: Returns the partial derivative of the specified value with respect to the screen-space x-coordinate. This function is only supported in pixel shaders.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "ddx")]
		protected Single Ddx(Single value) { return default(Single); }

		/// <summary>HLSL: Returns the partial derivative of the specified value with respect to the screen-space x-coordinate. This function is only supported in pixel shaders.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "ddx")]
		protected T Ddx<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Computes a low precision partial derivative with respect to the screen-space x-coordinate.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "ddx_coarse")]
		protected Single DdxCourse(Single value) { return default(Single); }

		/// <summary>HLSL: Computes a low precision partial derivative with respect to the screen-space x-coordinate.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "ddx_coarse")]
		protected Vector2 DdxCourse(Vector2 value) { return default(Vector2); }

		/// <summary>HLSL: Computes a low precision partial derivative with respect to the screen-space x-coordinate.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "ddx_coarse")]
		protected Vector3 DdxCourse(Vector3 value) { return default(Vector3); }

		/// <summary>HLSL: Computes a low precision partial derivative with respect to the screen-space x-coordinate.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "ddx_coarse")]
		protected Vector4 DdxCourse(Vector4 value) { return default(Vector4); }

		/// <summary>HLSL: Computes a high precision partial derivative with respect to the screen-space x-coordinate.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "ddx_fine")]
		protected Single DdxFine(Single value) { return default(Single); }

		/// <summary>HLSL: Computes a high precision partial derivative with respect to the screen-space x-coordinate.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "ddx_fine")]
		protected Vector2 DdxFine(Vector2 value) { return default(Vector2); }

		/// <summary>HLSL: Computes a high precision partial derivative with respect to the screen-space x-coordinate.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "ddx_fine")]
		protected Vector3 DdxFine(Vector3 value) { return default(Vector3); }

		/// <summary>HLSL: Computes a high precision partial derivative with respect to the screen-space x-coordinate.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "ddx_fine")]
		protected Vector4 DdxFine(Vector4 value) { return default(Vector4); }

		/// <summary>HLSL: Returns the partial derivative of the specified value with respect to the screen-space y-coordinate. This function is only supported in pixel shaders.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "ddy")]
		protected Single Ddy(Single value) { return default(Single); }

		/// <summary>HLSL: Returns the partial derivative of the specified value with respect to the screen-space y-coordinate. This function is only supported in pixel shaders.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "ddy")]
		protected T Ddy<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Computes a low precision partial derivative with respect to the screen-space y-coordinate.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "ddy_coarse")]
		protected Single DdyCourse(Single value) { return default(Single); }

		/// <summary>HLSL: Computes a low precision partial derivative with respect to the screen-space y-coordinate.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "ddy_coarse")]
		protected Vector2 DdyCourse(Vector2 value) { return default(Vector2); }

		/// <summary>HLSL: Computes a low precision partial derivative with respect to the screen-space y-coordinate.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "ddy_coarse")]
		protected Vector3 DdyCourse(Vector3 value) { return default(Vector3); }

		/// <summary>HLSL: Computes a low precision partial derivative with respect to the screen-space y-coordinate.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "ddy_coarse")]
		protected Vector4 DdyCourse(Vector4 value) { return default(Vector4); }

		/// <summary>HLSL: Computes a high precision partial derivative with respect to the screen-space y-coordinate.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "ddy_fine")]
		protected Single DdyFine(Single value) { return default(Single); }

		/// <summary>HLSL: Computes a high precision partial derivative with respect to the screen-space y-coordinate.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "ddy_fine")]
		protected Vector2 DdyFine(Vector2 value) { return default(Vector2); }

		/// <summary>HLSL: Computes a high precision partial derivative with respect to the screen-space y-coordinate.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "ddy_fine")]
		protected Vector3 DdyFine(Vector3 value) { return default(Vector3); }

		/// <summary>HLSL: Computes a high precision partial derivative with respect to the screen-space y-coordinate.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "ddy_fine")]
		protected Vector4 DdyFine(Vector4 value) { return default(Vector4); }

		/// <summary>HLSL: Converts the specified value from radians to degrees.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "degrees")]
		protected Single Degrees(Single x) { return default(Single); }

		/// <summary>HLSL: Converts the specified value from radians to degrees.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "degrees")]
		protected T Degrees<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns the determinant of the specified floating-point, square matrix.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "determinant")]
		protected Single Determinant<T>(T m) where T : struct, IMatrix<Single> { return default(Single); }

		/// <summary>HLSL: Blocks execution of all threads in a group until all device memory accesses have been completed.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "DeviceMemoryBarrier")]
		protected void DeviceMemoryBarrier() {  }

		/// <summary>HLSL: Blocks execution of all threads in a group until all device memory accesses have been completed and all threads in the group have reached this call.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "DeviceMemoryBarrierWithGroupSync")]
		protected void DeviceMemoryBarrierWithGroupSync() {  }

		/// <summary>HLSL: Returns a distance scalar between two vectors.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "distance")]
		protected Single Distance<T>(T x, T y) where T : struct, IVector<Single> { return default(Single); }

		/// <summary>HLSL: Returns the dot product of two vectors.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "dot")]
		protected Single Dot<T>(T x, T y) where T : struct, IVector<Single> { return default(Single); }

		/// <summary>HLSL: Returns the dot product of two vectors.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "dot")]
		protected Int2 Dot(Int2 x, Int2 y) { return default(Int2); }

		/// <summary>HLSL: Returns the dot product of two vectors.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "dot")]
		protected Int32 Dot(Int3 x, Int3 y) { return default(Int32); }

		/// <summary>HLSL: Returns the dot product of two vectors.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "dot")]
		protected Int32 Dot(Int4 x, Int4 y) { return default(Int32); }

		/// <summary>HLSL: Calculates a distance vector. This intrinsic function provides the same functionality as the Vertex Shader instruction dst.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "dst")]
		protected T Dst<T>(T x, T y) where T : struct, IVector<Single> { return default(T); }

		/// <summary>HLSL: Submits an error message to the information queue.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "errorf")]
		protected void Errorf(String format, params Object[] args) {  }

		/// <summary>HLSL: Evaluates at the pixel centroid. TODO: NOT IMPLEMENTED.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "EvaluateAttributeAtCentroid")]
		protected void EvaluateAttributeAtCentroid() {  }

		/// <summary>HLSL: Evaluates at the indexed sample location. TODO: NOT IMPLEMENTED.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "EvaluateAttributeAtSample")]
		protected void EvaluateAttributeAtSample() {  }

		/// <summary>HLSL: Evaluates at the pixel centroid with an offset. TODO: NOT IMPLEMENTED.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "EvaluateAttributeSnapped")]
		protected void EvaluateAttributeSnapped() {  }

		/// <summary>HLSL: Returns the base-e exponential, or ex, of the specified value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "exp")]
		protected Single Exp(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the base-e exponential, or ex, of the specified value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "exp")]
		protected T Exp<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns the base 2 exponential, or 2x, of the specified value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "exp2")]
		protected Single Exp2(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the base 2 exponential, or 2x, of the specified value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "exp2")]
		protected T Exp2<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Converts the float16 stored in the low-half of the uint to a float.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "f16tof32")]
		protected Single F16toF32(UInt32 value) { return default(Single); }

		/// <summary>HLSL: Converts the float16 stored in the low-half of the uint to a float.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "f16tof32")]
		protected Vector2 F16toF32(UInt2 value) { return default(Vector2); }

		/// <summary>HLSL: Converts the float16 stored in the low-half of the uint to a float.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "f16tof32")]
		protected Vector3 F16toF32(UInt3 value) { return default(Vector3); }

		/// <summary>HLSL: Converts the float16 stored in the low-half of the uint to a float.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "f16tof32")]
		protected Vector4 F16toF32(UInt4 value) { return default(Vector4); }

		/// <summary>HLSL: Converts an input into a float16 type.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "f32tof16")]
		protected UInt32 F32toF16(Single value) { return default(UInt32); }

		/// <summary>HLSL: Converts an input into a float16 type.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "f32tof16")]
		protected UInt2 F32toF16(Vector2 value) { return default(UInt2); }

		/// <summary>HLSL: Converts an input into a float16 type.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "f32tof16")]
		protected UInt3 F32toF16(Vector3 value) { return default(UInt3); }

		/// <summary>HLSL: Converts an input into a float16 type.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "f32tof16")]
		protected UInt4 F32toF16(Vector4 value) { return default(UInt4); }

		/// <summary>HLSL: Flips the surface-normal (if needed) to face in a direction opposite to i; returns the result in n.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "faceforward")]
		protected T FaceForward<T>(T n, T i, T ng) where T : struct, IVector<float> { return default(T); }

		/// <summary>HLSL: Gets the location of the first set bit starting from the highest order bit and working downward, per component.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "firstbithigh")]
		protected Int32 FirstBitHigh(Int32 value) { return default(Int32); }

		/// <summary>HLSL: Gets the location of the first set bit starting from the highest order bit and working downward, per component.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "firstbithigh")]
		protected UInt32 FirstBitHigh() { return default(UInt32); }

		/// <summary>HLSL: Gets the location of the first set bit starting from the highest order bit and working downward, per component.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "firstbithigh")]
		protected T FirstBitHigh<T>(T value) where T : struct, IVector<Int32> { return default(T); }

		/// <summary>HLSL: Gets the location of the first set bit starting from the highest order bit and working downward, per component.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "firstbithigh")]
		protected UInt2 FirstBitHigh(UInt2 value) { return default(UInt2); }

		/// <summary>HLSL: Gets the location of the first set bit starting from the highest order bit and working downward, per component.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "firstbithigh")]
		protected UInt3 FirstBitHigh(UInt3 value) { return default(UInt3); }

		/// <summary>HLSL: Gets the location of the first set bit starting from the highest order bit and working downward, per component.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "firstbithigh")]
		protected UInt4 FirstBitHigh(UInt4 value) { return default(UInt4); }

		/// <summary>HLSL: Returns the location of the first set bit starting from the lowest order bit and working upward, per component.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "firstbitlow")]
		protected Int32 FirstBitLow(Int32 value) { return default(Int32); }

		/// <summary>HLSL: Returns the location of the first set bit starting from the lowest order bit and working upward, per component.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "firstbitlow")]
		protected T FirstBitLow<T>(T value) where T : struct, IVector<UInt32> { return default(T); }

		/// <summary>HLSL: Returns the largest integer value that is lesss than or equal to the specified value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "floor")]
		protected Single Floor(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the largest integer value that is lesss than or equal to the specified value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "floor")]
		protected T Floor<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns the double-precision fused multiply-addition of a * b + c.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "fma")]
		protected Double Fma(Double a, Double b, Double c) { return default(Double); }

		/// <summary>HLSL: Returns the double-precision fused multiply-addition of a * b + c.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "fma")]
		protected T Fma<T>(T b, T c) where T : struct, IIntrinsicValue<Double> { return default(T); }

		/// <summary>HLSL: Returns the floating-point remainder of x/y.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "fmod")]
		protected Single Fmod(Single x, Single y) { return default(Single); }

		/// <summary>HLSL: Returns the floating-point remainder of x/y.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "fmod")]
		protected T Fmod<T>(T x, T y) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns the fractional (or decimal) part of x; which is greater than or equal to 0 and less than 1.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "frac")]
		protected Single Frac(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the fractional (or decimal) part of x; which is greater than or equal to 0 and less than 1.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "frac")]
		protected T Frac<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns the mantissa and exponent of the specified floating-point value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "frexp")]
		protected Single Frexp(Single x, Single exp) { return default(Single); }

		/// <summary>HLSL: Returns the mantissa and exponent of the specified floating-point value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "frexp")]
		protected T Frexp<T>(T x, T exp) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns the absolute value of the partial derivatives of the specified value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "fwidth")]
		protected Single Fwidth(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the absolute value of the partial derivatives of the specified value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "fwidth")]
		protected T Fwidth<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Gets the number of samples for a render target.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "GetRenderTargetSampleCount")]
		protected UInt32 GetRenderTargetSampleCount() { return default(UInt32); }

		/// <summary>HLSL: Gets the sampling position (x,y) for a given sample index.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "GetRenderTargetSamplePosition")]
		protected Int2 GetRenderTargetSamplePosition() { return default(Int2); }

		/// <summary>HLSL: Blocks execution of all threads in a group until all group shared accesses have been completed.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "GroupMemoryBarrier")]
		protected void GroupMemoryBarrier() {  }

		/// <summary>HLSL: Blocks execution of all threads in a group until all group shared accesses have been completed and all threads in the group have reached this call.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "GroupMemoryBarrierWithSync")]
		protected void GroupMemoryBarrierWithSync() {  }

		/// <summary>HLSL: Performs a guaranteed atomic add of value to the dest resource variable.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "InterlockedAdd")]
		protected void InterlockedAdd(Int32 dest, Int32 value) {  }

		/// <summary>HLSL: Performs a guaranteed atomic add of value to the dest resource variable.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "InterlockedAdd")]
		protected void InterlockedAdd(Int32 dest, Int32 value, out Int32 original_value) { original_value = default(Int32); }

		/// <summary>HLSL: Performs a guaranteed atomic add of value to the dest resource variable.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "InterlockedAdd")]
		protected void InterlockedAdd(UInt32 dest, UInt32 value) {  }

		/// <summary>HLSL: Performs a guaranteed atomic add of value to the dest resource variable.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "InterlockedAdd")]
		protected void InterlockedAdd(UInt32 dest, UInt32 value, out UInt32 original_value) { original_value = default(UInt32); }

		/// <summary>HLSL: Performs a guaranteed atomic and.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "InterlockedAnd")]
		protected void InterlockedAnd(Int32 dest, Int32 value) {  }

		/// <summary>HLSL: Performs a guaranteed atomic and.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "InterlockedAnd")]
		protected void InterlockedAnd(Int32 dest, Int32 value, out Int32 original_value) { original_value = default(Int32); }

		/// <summary>HLSL: Performs a guaranteed atomic and.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "InterlockedAnd")]
		protected void InterlockedAnd(UInt32 dest, UInt32 value) {  }

		/// <summary>HLSL: Performs a guaranteed atomic and.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "InterlockedAnd")]
		protected void InterlockedAnd(UInt32 dest, UInt32 value, out UInt32 original_value) { original_value = default(UInt32); }

		/// <summary>HLSL: Atomically compares the destination with the comparison value. If they are identical, the destination is overwritten with the input value. The original value is set to the destination's original value. Note: If you call InterlockedCompareExchange in a for or while compute shader loop, to properly compile, you must use the [allow_uav_condition] attribute on that loop.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "InterlockedCompareExchange")]
		protected void InterlockedCompareExchange(Int32 dest, Int32 compare_value, Int32 value, out Int32 original_value) { original_value = default(Int32); }

		/// <summary>HLSL: Atomically compares the destination with the comparison value. If they are identical, the destination is overwritten with the input value. The original value is set to the destination's original value. Note: If you call InterlockedCompareExchange in a for or while compute shader loop, to properly compile, you must use the [allow_uav_condition] attribute on that loop.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "InterlockedCompareExchange")]
		protected void InterlockedCompareExchange(UInt32 dest, UInt32 compare_value, UInt32 value, out UInt32 original_value) { original_value = default(UInt32); }

		/// <summary>HLSL: Atomically compares the destination with the comparison value. If they are identical, the destination is overwritten with the input value. The original value is set to the destination's original value. Note: If you call InterlockedCompareExchange in a for or while compute shader loop, to properly compile, you must use the [allow_uav_condition] attribute on that loop.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "InterlockedCompareStore")]
		protected void InterlockedCompareStore(Int32 dest, Int32 compare_value, Int32 value) {  }

		/// <summary>HLSL: Atomically compares the destination with the comparison value. If they are identical, the destination is overwritten with the input value. The original value is set to the destination's original value. Note: If you call InterlockedCompareExchange in a for or while compute shader loop, to properly compile, you must use the [allow_uav_condition] attribute on that loop.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "InterlockedCompareStore")]
		protected void InterlockedCompareStore(UInt32 dest, UInt32 compare_value, UInt32 value) {  }

		/// <summary>HLSL: Assigns value to dest and returns the original value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "InterlockedExchange")]
		protected void InterlockedExchange(Int32 dest, Int32 value, out Int32 original_value) { original_value = default(Int32); }

		/// <summary>HLSL: Assigns value to dest and returns the original value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "InterlockedExchange")]
		protected void InterlockedExchange(UInt32 dest, UInt32 value, out UInt32 original_value) { original_value = default(UInt32); }

		/// <summary>HLSL: Performs a guaranteed atomic max.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "InterlockedMax")]
		protected void InterlockedMax(Int32 dest, Int32 value) {  }

		/// <summary>HLSL: Performs a guaranteed atomic max.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "InterlockedMax")]
		protected void InterlockedMax(Int32 dest, Int32 value, out Int32 original_value) { original_value = default(Int32); }

		/// <summary>HLSL: Performs a guaranteed atomic max.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "InterlockedMax")]
		protected void InterlockedMax(UInt32 dest, UInt32 value) {  }

		/// <summary>HLSL: Performs a guaranteed atomic max.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "InterlockedMax")]
		protected void InterlockedMax(UInt32 dest, UInt32 value, out UInt32 original_value) { original_value = default(UInt32); }

		/// <summary>HLSL: Performs a guaranteed atomic min.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "InterlockedMin")]
		protected void InterlockedMin(Int32 dest, Int32 value) {  }

		/// <summary>HLSL: Performs a guaranteed atomic min.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "InterlockedMin")]
		protected void InterlockedMin(Int32 dest, Int32 value, out Int32 original_value) { original_value = default(Int32); }

		/// <summary>HLSL: Performs a guaranteed atomic min.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "InterlockedMin")]
		protected void InterlockedMin(UInt32 dest, UInt32 value) {  }

		/// <summary>HLSL: Performs a guaranteed atomic min.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "InterlockedMin")]
		protected void InterlockedMin(UInt32 dest, UInt32 value, out UInt32 original_value) { original_value = default(UInt32); }

		/// <summary>HLSL: Performs a guaranteed atomic or.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "InterlockedOr")]
		protected void InterlockedOr(Int32 dest, Int32 value) {  }

		/// <summary>HLSL: Performs a guaranteed atomic or.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "InterlockedOr")]
		protected void InterlockedOr(Int32 dest, Int32 value, out Int32 original_value) { original_value = default(Int32); }

		/// <summary>HLSL: Performs a guaranteed atomic or.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "InterlockedOr")]
		protected void InterlockedOr(UInt32 dest, UInt32 value) {  }

		/// <summary>HLSL: Performs a guaranteed atomic or.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "InterlockedOr")]
		protected void InterlockedOr(UInt32 dest, UInt32 value, out UInt32 original_value) { original_value = default(UInt32); }

		/// <summary>HLSL: Performs a guaranteed atomic xor.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "InterlockedXor")]
		protected void InterlockedXor(Int32 dest, Int32 value) {  }

		/// <summary>HLSL: Performs a guaranteed atomic xor.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "InterlockedXor")]
		protected void InterlockedXor(Int32 dest, Int32 value, out Int32 original_value) { original_value = default(Int32); }

		/// <summary>HLSL: Performs a guaranteed atomic xor.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "InterlockedXor")]
		protected void InterlockedXor(UInt32 dest, UInt32 value) {  }

		/// <summary>HLSL: Performs a guaranteed atomic xor.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "InterlockedXor")]
		protected void InterlockedXor(UInt32 dest, UInt32 value, out UInt32 original_value) { original_value = default(UInt32); }

		/// <summary>HLSL: Determines if the specified floating-point value is finite.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "isfinite")]
		protected Boolean IsFinite(Single x) { return default(Boolean); }

		/// <summary>HLSL: Determines if the specified floating-point value is finite.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "isfinite")]
		protected R IsFinite<T, R>(T x) where T : struct, IIntrinsicValue<Single> where R : struct, IIntrinsicValue<Boolean> { return default(R); }

		/// <summary>HLSL: Determines if the specified floating-point value is infinite. Returns a value of the same size as the input, with a value set to True if the x parameter is +INF or -INF. Otherwise, False.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "isinf")]
		protected Boolean IsInf(Single x) { return default(Boolean); }

		/// <summary>HLSL: Determines if the specified floating-point value is infinite. Returns a value of the same size as the input, with a value set to True if the x parameter is +INF or -INF. Otherwise, False.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "isinf")]
		protected R IsInf<T, R>(T x) where T : struct, IIntrinsicValue<Single> where R : struct, IIntrinsicValue<Boolean> { return default(R); }

		/// <summary>HLSL: Determines if the specified value is NAN or QNAN.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "isnan")]
		protected Boolean IsNan(Single x) { return default(Boolean); }

		/// <summary>HLSL: Determines if the specified value is NAN or QNAN.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "isnan")]
		protected R IsNan<T, R>(T x) where T : struct, IIntrinsicValue<Single> where R : struct, IIntrinsicValue<Boolean> { return default(R); }

		/// <summary>HLSL: Returns the result of multiplying the specified value by two, raised to the power of the specified exponent.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "ldexp")]
		protected Single Ldexp(Single x, Single exp) { return default(Single); }

		/// <summary>HLSL: Returns the result of multiplying the specified value by two, raised to the power of the specified exponent.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "ldexp")]
		protected T Ldexp<T>(T x, T exp) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns the length of the specified floating-point vector.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "length")]
		protected Single Length<T>(T x) where T : struct, IVector<Single> { return default(Single); }

		/// <summary>HLSL: Performs a linear interpolation.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "lerp")]
		protected Single Lerp(Single x, Single y, Single s) { return default(Single); }

		/// <summary>HLSL: Performs a linear interpolation.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "lerp")]
		protected T Lerp<T>(T x, T y, T s) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns a lighting coefficient vector. This function returns a lighting coefficient vector (ambient, diffuse, specular, 1) </summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "lit")]
		protected Vector4 Lit(Single n_dot_l, Single n_dot_h, Single m) { return default(Vector4); }

		/// <summary>HLSL: Returns the base-e logarithm of the specified value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "log")]
		protected Single Log(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the base-e logarithm of the specified value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "log")]
		protected T Log<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns the base-10 logarithm of the specified value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "log10")]
		protected Single Log10(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the base-10 logarithm of the specified value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "log10")]
		protected T Log10<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns the base-2 logarithm of the specified value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "log2")]
		protected Single Log2(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the base-2 logarithm of the specified value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "log2")]
		protected T Log2<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Performs an arithmetic multiply/add operation on three values.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "mad")]
		protected Single Mad(Single mValue, Single aValue, Single bValue) { return default(Single); }

		/// <summary>HLSL: Performs an arithmetic multiply/add operation on three values.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "mad")]
		protected Int32 Mad(Int32 mValue, Int32 aValue, Int32 bValue) { return default(Int32); }

		/// <summary>HLSL: Performs an arithmetic multiply/add operation on three values.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "mad")]
		protected UInt32 Mad(UInt32 mValue, UInt32 aValue, UInt32 bValue) { return default(UInt32); }

		/// <summary>HLSL: Performs an arithmetic multiply/add operation on three values.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "mad")]
		protected T Mad<T>(T mValue, T aValue, T bValue) where T : struct, IVector { return default(T); }

		/// <summary>HLSL: Selects the greater of x and y.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "max")]
		protected Single Max(Single x, Single y) { return default(Single); }

		/// <summary>HLSL: Selects the greater of x and y.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "max")]
		protected Int32 Max(Int32 x, Int32 y) { return default(Int32); }

		/// <summary>HLSL: Selects the greater of x and y.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "max")]
		protected T Max<T>(T x, T y) where T : struct, IIntrinsicValue { return default(T); }

		/// <summary>HLSL: Selects the lesser of x and y.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "min")]
		protected Single Min(Single x, Single y) { return default(Single); }

		/// <summary>HLSL: Selects the lesser of x and y.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "min")]
		protected Int32 Min(Int32 x, Int32 y) { return default(Int32); }

		/// <summary>HLSL: Selects the lesser of x and y.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "min")]
		protected T Min<T>(T x, T y) where T : struct, IIntrinsicValue { return default(T); }

		/// <summary>HLSL: Splits the value x into fractional and integer parts, each of which has the same sign as x. Returns the signed-fractional portion of x.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "modf")]
		protected Single ModF(Single x, Single ip) { return default(Single); }

		/// <summary>HLSL: Splits the value x into fractional and integer parts, each of which has the same sign as x. Returns the signed-fractional portion of x.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "modf")]
		protected Int32 ModF(Int32 x, Int32 ip) { return default(Int32); }

		/// <summary>HLSL: Splits the value x into fractional and integer parts, each of which has the same sign as x. Returns the signed-fractional portion of x.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "modf")]
		protected T ModF<T>(T x, out T integerPortion) where T : struct, IIntrinsicValue { integerPortion = default(T); return default(T); }

		/// <summary>HLSL: Compares a 4-byte reference value and an 8-byte source value and accumulates a vector of 4 sums. Each sum corresponds to the masked sum of absolute differences of a different byte alignment between the reference value and the source value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "msad4")]
		protected void MSad4(UInt32 reference, UInt2 source, UInt4 accum) {  }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "mul")]
		protected Single Mul(Single a, Single b) { return default(Single); }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "mul")]
		protected Int32 Mul(Int32 a, Int32 b) { return default(Int32); }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "mul")]
		protected T Mul<T>(Single a, T b) where T : struct, IIntrinsicValue { return default(T); }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "mul")]
		protected T Mul<T>(Int32 a, T b) where T : struct, IIntrinsicValue { return default(T); }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "mul")]
		protected T Mul<T>(T a, Single b) where T : struct, IIntrinsicValue { return default(T); }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "mul")]
		protected T Mul<T>(T a, Int32 b) where T : struct, IIntrinsicValue { return default(T); }

		/// <summary>No summary.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "mul")]
		protected V1 Mul<V1, V2>(V1 a, V2 b) where V1 : struct, IIntrinsicValue where V2 : struct, IIntrinsicValue { return default(V1); }

		/// <summary>HLSL: Generates a random value using the Perlin-noise algorithm. The Perlin noise value within a range between -1 and 1.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "noise")]
		protected Single Noise<T>(T x) where T : struct, IVector<Single> { return default(Single); }

		/// <summary>HLSL: Normalizes the specified floating-point vector according to x / length(x).</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "normalize")]
		protected T Normalize<T>(T x) where T : struct, IVector<Single> { return default(T); }

		/// <summary>HLSL: Returns the specified value raised to the specified power.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "pow")]
		protected Single Pow(Single value, Single power) { return default(Single); }

		/// <summary>HLSL: Returns the specified value raised to the specified power.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "pow")]
		protected T Pow<T>(T value, T power) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Submits a custom shader message to the information queue.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "printf")]
		protected void PrintF(String format, params Object[] args) {  }

		/// <summary>HLSL: Generates the corrected tessellation factors for a quad patch.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "Process2DQuadTessFactorsAvg")]
		protected void Process2DQuadTessFactorsAvg(Vector4 rawEdgeFactors, Vector2 insideScale, out Vector4 roundedEdgeTessFactors, out Vector2 roundedInsideTessFactors, out Vector2 unroundedInsideTessFactors) { unroundedInsideTessFactors = default(Vector2); roundedInsideTessFactors = default(Vector2); roundedEdgeTessFactors = default(Vector4); }

		/// <summary>HLSL: Generates the corrected tessellation factors for a quad patch.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "Process2DQuadTessFactorsMax")]
		protected void Process2DQuadTessFactorsMax(Vector4 rawEdgeFactors, Vector2 insideScale, out Vector4 roundedEdgeTessFactors, out Vector2 roundedInsideTessFactors, out Vector2 unroundedInsideTessFactors) { unroundedInsideTessFactors = default(Vector2); roundedInsideTessFactors = default(Vector2); roundedEdgeTessFactors = default(Vector4); }

		/// <summary>HLSL: Generates the corrected tessellation factors for a quad patch.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "Process2DQuadTessFactorsMin")]
		protected void Process2DQuadTessFactorsMin(Vector4 rawEdgeFactors, Vector2 insideScale, out Vector4 roundedEdgeTessFactors, out Vector2 roundedInsideTessFactors, out Vector2 unroundedInsideTessFactors) { unroundedInsideTessFactors = default(Vector2); roundedInsideTessFactors = default(Vector2); roundedEdgeTessFactors = default(Vector4); }

		/// <summary>HLSL: Generates the rounded tessellation factors for an isoline.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "ProcessIsolineTessFactors")]
		protected void ProcessIsolineTessFactors(Single rawDetailFactor, Single rawDensityFactor, out Single roundedDetailFactor, out Single roundedDensityFactor) { roundedDensityFactor = default(Single); roundedDetailFactor = default(Single); }

		/// <summary>HLSL: Generates the corrected tessellation factors for a quad patch.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "ProcessQuadTessFactorsAvg")]
		protected void ProcessQuadTessFactorsAvg(Vector4 rawEdgeFactors, Single insideScale, out Vector4 roundedEdgeTessFactors, out Vector2 roundedInsideTessFactors, out Vector2 unroundedInsideTessFactors) { unroundedInsideTessFactors = default(Vector2); roundedInsideTessFactors = default(Vector2); roundedEdgeTessFactors = default(Vector4); }

		/// <summary>HLSL: Generates the corrected tessellation factors for a quad patch.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "ProcessQuadTessFactorsMax")]
		protected void ProcessQuadTessFactorsMax(Vector4 rawEdgeFactors, Single insideScale, out Vector4 roundedEdgeTessFactors, out Vector2 roundedInsideTessFactors, out Vector2 unroundedInsideTessFactors) { unroundedInsideTessFactors = default(Vector2); roundedInsideTessFactors = default(Vector2); roundedEdgeTessFactors = default(Vector4); }

		/// <summary>HLSL: Generates the corrected tessellation factors for a quad patch.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "ProcessQuadTessFactorsMin")]
		protected void ProcessQuadTessFactorsMin(Vector4 rawEdgeFactors, Single insideScale, out Vector4 roundedEdgeTessFactors, out Vector2 roundedInsideTessFactors, out Vector2 unroundedInsideTessFactors) { unroundedInsideTessFactors = default(Vector2); roundedInsideTessFactors = default(Vector2); roundedEdgeTessFactors = default(Vector4); }

		/// <summary>HLSL: Generates the corrected tessellation factors for a tri patch.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "ProcessTriTessFactorsAvg")]
		protected void ProcessTriTessFactorsAvg(Vector3 rawEdgeFactors, Single insideScale, out Vector3 roundedEdgeTessFactors, out Single roundedInsideTessFactor, out Single unroundedInsideTessFactor) { unroundedInsideTessFactor = default(Single); roundedInsideTessFactor = default(Single); roundedEdgeTessFactors = default(Vector3); }

		/// <summary>HLSL: Generates the corrected tessellation factors for a tri patch.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "ProcessTriTessFactorsMax")]
		protected void ProcessTriTessFactorsMax(Vector3 rawEdgeFactors, Single insideScale, out Vector3 roundedEdgeTessFactors, out Single roundedInsideTessFactor, out Single unroundedInsideTessFactor) { unroundedInsideTessFactor = default(Single); roundedInsideTessFactor = default(Single); roundedEdgeTessFactors = default(Vector3); }

		/// <summary>HLSL: Generates the corrected tessellation factors for a tri patch.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "ProcessTriTessFactorsMin")]
		protected void ProcessTriTessFactorsMin(Vector3 rawEdgeFactors, Single insideScale, out Vector3 roundedEdgeTessFactors, out Single roundedInsideTessFactor, out Single unroundedInsideTessFactor) { unroundedInsideTessFactor = default(Single); roundedInsideTessFactor = default(Single); roundedEdgeTessFactors = default(Vector3); }

		/// <summary>HLSL: Converts the specified value from degrees to radians.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "radians")]
		protected Single Radians(Single x) { return default(Single); }

		/// <summary>HLSL: Converts the specified value from degrees to radians.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "radians")]
		protected T Radians<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Calculates a fast, approximate, per-component reciprocal.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "rcp")]
		protected Single Rcp(Single x) { return default(Single); }

		/// <summary>HLSL: Calculates a fast, approximate, per-component reciprocal.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "rcp")]
		protected T Rcp<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns a reflection vector using an incident ray and a surface normal.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "reflect")]
		protected T Reflect<T>(T incidentVector, T surfaceNormal) where T : struct, IVector<Single> { return default(T); }

		/// <summary>HLSL: Returns a refraction vector using an entering ray, a surface normal, and a refraction index. A floating-point, refraction vector. If the angle between the entering ray i and the surface normal n is too great for a given refraction index ?, the return value is (0,0,0).</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "refract")]
		protected T Refract<T>(T rayDirection, T surfaceNormal, Single refractionIndex) where T : struct, IVector<Single> { return default(T); }

		/// <summary>HLSL: Reverses the order of the bits, per component.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "reversebits")]
		protected UInt32 ReverseBits(UInt32 value) { return default(UInt32); }

		/// <summary>HLSL: Rounds the specified value to the nearest integer.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "round")]
		protected Single Round(Single x) { return default(Single); }

		/// <summary>HLSL: Rounds the specified value to the nearest integer.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "round")]
		protected T Round<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns the reciprocal of the square root of the specified value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "rsqrt")]
		protected Single RSqrt(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the reciprocal of the square root of the specified value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "rsqrt")]
		protected T RSqrt<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Clamps the specified value within the range of 0 to 1.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "saturate")]
		protected Single Saturate(Single x) { return default(Single); }

		/// <summary>HLSL: Clamps the specified value within the range of 0 to 1.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "saturate")]
		protected T Saturate<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns the sign of x. Returns -1 if x is less than zero; 0 if x equals zero; and 1 if x is greater than zero.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "sign")]
		protected Single Sign(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the sign of x. Returns -1 if x is less than zero; 0 if x equals zero; and 1 if x is greater than zero.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "sign")]
		protected T Sign<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns the sine of the specified value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "sin")]
		protected Single Sin(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the sine of the specified value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "sin")]
		protected T Sin<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns the sine and cosine of x.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "sincos")]
		protected Single SinCos(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the sine and cosine of x.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "sincos")]
		protected void SinCos<T>(T x, out T sine, out T cosine) where T : struct, IIntrinsicValue<Single> { cosine = default(T); sine = default(T); }

		/// <summary>HLSL: Returns the hyperbolic sine of the specified value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "sinh")]
		protected Single SinH(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the hyperbolic sine of the specified value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "sinh")]
		protected T SinH<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns a smooth Hermite interpolation between 0 and 1, if x is in the range [min, max].</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "smoothstep")]
		protected Single SmoothStep(Single min, Single max, Single x) { return default(Single); }

		/// <summary>HLSL: Returns a smooth Hermite interpolation between 0 and 1, if x is in the range [min, max].</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "smoothstep")]
		protected T SmoothStep<T>(T min, T max, T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns the square root of the specified floating-point value, per component.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "sqrt")]
		protected Single Sqrt(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the square root of the specified floating-point value, per component.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "sqrt")]
		protected T Sqrt<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Compares two values, returning 0 or 1 based on which value is greater.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "step")]
		protected Single Step(Single y, Single x) { return default(Single); }

		/// <summary>HLSL: Compares two values, returning 0 or 1 based on which value is greater.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "step")]
		protected T Step<T>(T y, T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns the tangent of the specified value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "tan")]
		protected Single Tan(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the tangent of the specified value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "tan")]
		protected T Tan<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: Returns the hyperbolic tangent of the specified value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "tanh")]
		protected Single Tanh(Single x) { return default(Single); }

		/// <summary>HLSL: Returns the hyperbolic tangent of the specified value.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "tanh")]
		protected T Tanh<T>(T x) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>HLSL: samples a 1D texture.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "tex1D")]
		protected Vector4 Tex1D(TextureSampler sampler, Single texCoords) { return default(Vector4); }

		/// <summary>HLSL: samples a 1D texture.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "tex1D")]
		protected Vector4 Tex1D(TextureSampler sampler, Single texCoords, Single ddx, Single ddy) { return default(Vector4); }

		/// <summary>HLSL: Samples a 1D texture after biasing the mip level by t.w.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "tex1Dbias")]
		protected Vector4 Tex1Dbias(TextureSampler sampler, Vector4 texCoords) { return default(Vector4); }

		/// <summary>HLSL: Samples a 1D texture using a gradient to select the mip level.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "tex1Dgrad")]
		protected Vector4 Tex1Dgrad(TextureSampler sampler, Single texCoords, Single ddx, Single ddy) { return default(Vector4); }

		/// <summary>HLSL: Samples a 1D texture with mipmaps. The mipmap LOD is specified in t.w.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "tex1Dlod")]
		protected Vector4 Tex1Dlod(TextureSampler sampler, Vector4 texCoords) { return default(Vector4); }

		/// <summary>HLSL: Samples a 1D texture using a projective divide; the texture coordinate is divided by t.w before the lookup takes place.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "tex1Dproj")]
		protected Vector4 Tex1Dproj(TextureSampler sampler, Vector4 texCoords) { return default(Vector4); }

		/// <summary>HLSL: Samples a 2D texture.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "tex2D")]
		protected Vector4 Tex2D(TextureSampler sampler, Vector2 texCoords) { return default(Vector4); }

		/// <summary>HLSL: Samples a 2D texture.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "tex2D")]
		protected Vector4 Tex2D(TextureSampler sampler, Vector2 texCoords, Vector2 ddx, Vector2 ddy) { return default(Vector4); }

		/// <summary>HLSL: Samples a 2D texture after biasing the mip level by t.w.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "tex2Dbias")]
		protected Vector4 Tex2Dbias(TextureSampler sampler, Vector4 texCoords) { return default(Vector4); }

		/// <summary>HLSL: Samples a 2D texture using a gradient to select the mip level.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "tex2Dgrad")]
		protected Vector4 Tex2Dgrad(TextureSampler sampler, Vector2 texCoords, Vector2 ddx, Vector2 ddy) { return default(Vector4); }

		/// <summary>HLSL: Samples a 2D texture with mipmaps. The mipmap LOD is specified in t.w.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "tex2Dlod")]
		protected Vector4 Tex2Dlod(TextureSampler sampler, Vector4 texCoords) { return default(Vector4); }

		/// <summary>HLSL: Samples a 2D texture using a projective divide; the texture coordinate is divided by t.w before the lookup takes place.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "tex2Dproj")]
		protected Vector4 Tex2Dproj(TextureSampler sampler, Vector4 texCoords) { return default(Vector4); }

		/// <summary>HLSL: Samples a 3D texture.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "tex3D")]
		protected Vector4 Tex3D(TextureSampler sampler, Vector3 texCoords) { return default(Vector4); }

		/// <summary>HLSL: Samples a 3D texture.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "tex3D")]
		protected Vector4 Tex3D(TextureSampler sampler, Vector3 texCoords, Vector3 ddx, Vector3 ddy) { return default(Vector4); }

		/// <summary>HLSL: Samples a 3D texture after biasing the mip level by t.w.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "tex3Dbias")]
		protected Vector4 Tex3Dbias(TextureSampler sampler, Vector4 texCoords) { return default(Vector4); }

		/// <summary>HLSL: Samples a 3D texture using a gradient to select the mip level.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "tex3Dgrad")]
		protected Vector4 Tex3Dgrad(TextureSampler sampler, Vector3 texCoords, Vector3 ddx, Vector3 ddy) { return default(Vector4); }

		/// <summary>HLSL: Samples a 3D texture with mipmaps. The mipmap LOD is specified in t.w.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "tex3Dlod")]
		protected Vector4 Tex3Dlod(TextureSampler sampler, Vector4 texCoords) { return default(Vector4); }

		/// <summary>HLSL: Samples a 3D texture using a projective divide; the texture coordinate is divided by t.w before the lookup takes place.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "tex3Dproj")]
		protected Vector4 Tex3Dproj(TextureSampler sampler, Vector4 texCoords) { return default(Vector4); }

		/// <summary>HLSL: Samples a cube texture.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "texCUBE")]
		protected Vector4 TexCUBE(TextureSampler sampler, Vector3 texCoords) { return default(Vector4); }

		/// <summary>HLSL: Samples a cube texture.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "texCUBE")]
		protected Vector4 TexCUBE(TextureSampler sampler, Vector3 texCoords, Vector3 ddx, Vector3 ddy) { return default(Vector4); }

		/// <summary>HLSL: Samples a cube texture after biasing the mip level by t.w.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "texCUBEbias")]
		protected Vector4 TexCUBEbias(TextureSampler sampler, Vector4 texCoords) { return default(Vector4); }

		/// <summary>HLSL: Samples a cube texture using a gradient to select the mip level.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "texCUBEgrad")]
		protected Vector4 TexCUBEgrad(TextureSampler sampler, Vector3 texCoords, Vector3 ddx, Vector3 ddy) { return default(Vector4); }

		/// <summary>HLSL: Samples a cube texture with mipmaps. The mipmap LOD is specified in t.w.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "texCUBElod")]
		protected Vector4 TexCUBElod(TextureSampler sampler, Vector4 texCoords) { return default(Vector4); }

		/// <summary>HLSL: Samples a cube texture using a projective divide; the texture coordinate is divided by t.w before the lookup takes place.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "texCUBEproj")]
		protected Vector4 TexCUBEproj(TextureSampler sampler, Vector4 texCoords) { return default(Vector4); }

		/// <summary>HLSL: Transposes the specified input matrix.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "transpose")]
		protected T Transpose<T>(T x) where T : struct, IMatrix { return default(T); }

		/// <summary>HLSL: Truncates a floating-point value to the integer component.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "trunc")]
		protected Single Truncate(Single value, Single power) { return default(Single); }

		/// <summary>HLSL: Truncates a floating-point value to the integer component.</summary>
		[ShaderIntrinsic(OutputLanguage.HLSL, "trunc")]
		protected T Truncate<T>(T value, T power) where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>GLSL: Returns the arc hyperbolic cosine of the parameter.</summary>
		[ShaderIntrinsic(OutputLanguage.GLSL, "acosh")]
		protected Single AcosH(Single x) { return default(Single); }

		/// <summary>GLSL: Returns the arc hyperbolic cosine of the parameter.</summary>
		[ShaderIntrinsic(OutputLanguage.GLSL, "acosh")]
		protected T AcosH<T>() where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>GLSL: Returns the arc hyperbolic sine of the parameter.</summary>
		[ShaderIntrinsic(OutputLanguage.GLSL, "asinh")]
		protected Single AsinH(Single x) { return default(Single); }

		/// <summary>GLSL: Returns the arc hyperbolic sine of the parameter.</summary>
		[ShaderIntrinsic(OutputLanguage.GLSL, "asinh")]
		protected T AsinH<T>() where T : struct, IIntrinsicValue<Single> { return default(T); }

		/// <summary>GLSL: Returns the arc hyperbolic tangent of the parameter.</summary>
		[ShaderIntrinsic(OutputLanguage.GLSL, "atanh")]
		protected Single AtanH(Single x) { return default(Single); }

		/// <summary>GLSL: Returns the arc hyperbolic tangent of the parameter.</summary>
		[ShaderIntrinsic(OutputLanguage.GLSL, "atanh")]
		protected T AtanH<T>() where T : struct, IIntrinsicValue<Single> { return default(T); }
	}
}