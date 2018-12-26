using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 2 row, 4 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Matrix2x4 : IMatrix<float>, IIntrinsicValue<float>
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
		///	The value at row 1, column 3 of the matrix.
		/// </summary>
		public float M13;

		/// <summary>
		///	The value at row 1, column 4 of the matrix.
		/// </summary>
		public float M14;

		/// <summary>
		///	The value at row 2, column 1 of the matrix.
		/// </summary>
		public float M21;

		/// <summary>
		///	The value at row 2, column 2 of the matrix.
		/// </summary>
		public float M22;

		/// <summary>
		///	The value at row 2, column 3 of the matrix.
		/// </summary>
		public float M23;

		/// <summary>
		///	The value at row 2, column 4 of the matrix.
		/// </summary>
		public float M24;

		/// <summary>
		/// Creates a new instance of <see cref="Matrix2x4"/>.
		/// </summary>
		public Matrix2x4(float m11, float m21, float m12, float m22, float m13, float m23, float m14, float m24)
		{
			M11 = m11;
			M12 = m12;
			M13 = m13;
			M14 = m14;
			M21 = m21;
			M22 = m22;
			M23 = m23;
			M24 = m24;
		}
	}
}


