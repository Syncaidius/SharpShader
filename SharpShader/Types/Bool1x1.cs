using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 1 row, 1 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Bool1x1 : IMatrix<bool>, UniformDimensions
	{
		/// <summary>
		///	The value at row 1, column 1 of the matrix.
		/// </summary>
		public bool M11;

		/// <summary>
		/// Creates a new instance of <see cref="Bool1x1"/>.
		/// </summary>
		public Bool1x1(bool m11)
		{
			M11 = m11;
		}
	}
}


