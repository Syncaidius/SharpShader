using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 2 row, 1 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Int2x1 : IMatrix<int>, IIntrinsicValue<int>
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
		/// Creates a new instance of <see cref="Int2x1"/>.
		/// </summary>
		public Int2x1(int m11, int m21)
		{
			M11 = m11;
			M21 = m21;
		}
	}
}


