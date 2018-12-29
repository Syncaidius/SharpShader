using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 2 row, 1 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Bool2x1 : IMatrix<bool>
	{
		/// <summary>
		///	The value at row 1, column 1 of the matrix.
		/// </summary>
		public bool M11;

		/// <summary>
		///	The value at row 2, column 1 of the matrix.
		/// </summary>
		public bool M21;

		/// <summary>
		/// Creates a new instance of <see cref="Bool2x1"/>.
		/// </summary>
		public Bool2x1(bool m11, bool m21)
		{
			M11 = m11;
			M21 = m21;
		}

		/// <summary>
		/// Gets or sets a component at the specified index for the current <see cref="Bool2x1"/> .
		/// </summary>
		public bool[] this[int index]
		{
			get => null;
			set {}
		}
	}
}
