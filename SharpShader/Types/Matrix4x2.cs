using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 4 row, 2 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Matrix4x2 : IMatrix<float>, IIntrinsicValue<float>
	{
		/// <summary>
		///	The value at row 1, column 1 of the matrix.
		/// </summary>
		public float M11;

		/// <summary>
		///	The value at row 1, column 2 of the matrix.
		/// </summary>
		public float M12;

		/// <summary>
		///	The value at row 2, column 1 of the matrix.
		/// </summary>
		public float M21;

		/// <summary>
		///	The value at row 2, column 2 of the matrix.
		/// </summary>
		public float M22;

		/// <summary>
		///	The value at row 3, column 1 of the matrix.
		/// </summary>
		public float M31;

		/// <summary>
		///	The value at row 3, column 2 of the matrix.
		/// </summary>
		public float M32;

		/// <summary>
		///	The value at row 4, column 1 of the matrix.
		/// </summary>
		public float M41;

		/// <summary>
		///	The value at row 4, column 2 of the matrix.
		/// </summary>
		public float M42;

		/// <summary>
		/// Creates a new instance of <see cref="Matrix4x2"/>.
		/// </summary>
		public Matrix4x2(float m11, float m21, float m31, float m41, float m12, float m22, float m32, float m42)
		{
			M11 = m11;
			M12 = m12;
			M21 = m21;
			M22 = m22;
			M31 = m31;
			M32 = m32;
			M41 = m41;
			M42 = m42;
		}
	}
}


