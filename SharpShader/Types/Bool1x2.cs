using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 1 row, 2 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Bool1x2 : IMatrix<bool>
	{
		/// <summary>
		///	The value at row 1, column 1 of the matrix.
		/// </summary>
		public bool M11;

		/// <summary>
		///	The value at row 1, column 2 of the matrix.
		/// </summary>
		public bool M12;

		/// <summary>
		/// Creates a new instance of <see cref="Bool1x2"/>.
		/// </summary>
		public Bool1x2(bool m11, bool m12)
		{
			M11 = m11;
			M12 = m12;
		}
	}
}


