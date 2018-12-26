using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 3 row, 3 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Int3x3 : IMatrix<int>, IIntrinsicValue<int>, UniformDimensions
	{
		/// <summary>
		///	The value at row 1, column 1 of the matrix.
		/// </summary>
		public int M11;

		/// <summary>
		///	The value at row 1, column 2 of the matrix.
		/// </summary>
		public int M12;

		/// <summary>
		///	The value at row 1, column 3 of the matrix.
		/// </summary>
		public int M13;

		/// <summary>
		///	The value at row 2, column 1 of the matrix.
		/// </summary>
		public int M21;

		/// <summary>
		///	The value at row 2, column 2 of the matrix.
		/// </summary>
		public int M22;

		/// <summary>
		///	The value at row 2, column 3 of the matrix.
		/// </summary>
		public int M23;

		/// <summary>
		///	The value at row 3, column 1 of the matrix.
		/// </summary>
		public int M31;

		/// <summary>
		///	The value at row 3, column 2 of the matrix.
		/// </summary>
		public int M32;

		/// <summary>
		///	The value at row 3, column 3 of the matrix.
		/// </summary>
		public int M33;

		/// <summary>
		/// Creates a new instance of <see cref="Int3x3"/>.
		/// </summary>
		public Int3x3(int m11, int m21, int m31, int m12, int m22, int m32, int m13, int m23, int m33)
		{
			M11 = m11;
			M12 = m12;
			M13 = m13;
			M21 = m21;
			M22 = m22;
			M23 = m23;
			M31 = m31;
			M32 = m32;
			M33 = m33;
		}
	}
}


