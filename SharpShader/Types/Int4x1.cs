using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 4 row, 1 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Int4x1 : IMatrix<int>, IIntrinsicValue<int>
	{
		/// <summary>
		///	The value at row 1, column 1 of the matrix.
		/// </summary>
		public int M11;

		/// <summary>
		///	The value at row 2, column 1 of the matrix.
		/// </summary>
		public int M21;

		/// <summary>
		///	The value at row 3, column 1 of the matrix.
		/// </summary>
		public int M31;

		/// <summary>
		///	The value at row 4, column 1 of the matrix.
		/// </summary>
		public int M41;

		/// <summary>
		/// Creates a new instance of <see cref="Int4x1"/>.
		/// </summary>
		public Int4x1(int m11, int m21, int m31, int m41)
		{
			M11 = m11;
			M21 = m21;
			M31 = m31;
			M41 = m41;
		}
	}
}


