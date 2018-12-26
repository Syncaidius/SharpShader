using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 1 row, 4 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Int1x4 : IMatrix<int>, IIntrinsicValue<int>
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
		///	The value at row 1, column 4 of the matrix.
		/// </summary>
		public int M14;

		/// <summary>
		/// Creates a new instance of <see cref="Int1x4"/>.
		/// </summary>
		public Int1x4(int m11, int m12, int m13, int m14)
		{
			M11 = m11;
			M12 = m12;
			M13 = m13;
			M14 = m14;
		}
	}
}


