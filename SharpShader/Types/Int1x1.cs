using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 1 row, 1 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Int1x1 : IMatrix<int>, IIntrinsicValue<int>, UniformDimensions
	{
		/// <summary>
		///	The value at row 1, column 1 of the matrix.
		/// </summary>
		public int M11;

		/// <summary>
		/// Creates a new instance of <see cref="Int1x1"/>.
		/// </summary>
		public Int1x1(int m11)
		{
			M11 = m11;
		}
	}
}


