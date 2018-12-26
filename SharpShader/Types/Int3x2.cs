using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 3 row, 2 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Int3x2 : IMatrix<int>, IIntrinsicValue<int>
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
		///	The value at row 2, column 1 of the matrix.
		/// </summary>
		public int M21;

		/// <summary>
		///	The value at row 2, column 2 of the matrix.
		/// </summary>
		public int M22;

		/// <summary>
		///	The value at row 3, column 1 of the matrix.
		/// </summary>
		public int M31;

		/// <summary>
		///	The value at row 3, column 2 of the matrix.
		/// </summary>
		public int M32;

		/// <summary>
		/// Creates a new instance of <see cref="Int3x2"/>.
		/// </summary>
		public Int3x2(int m11, int m21, int m31, int m12, int m22, int m32)
		{
			M11 = m11;
			M12 = m12;
			M21 = m21;
			M22 = m22;
			M31 = m31;
			M32 = m32;
		}
	}
}


