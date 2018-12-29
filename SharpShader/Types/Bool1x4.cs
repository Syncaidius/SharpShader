using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 1 row, 4 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Bool1x4 : IMatrix<bool>
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
		///	The value at row 1, column 3 of the matrix.
		/// </summary>
		public bool M13;

		/// <summary>
		///	The value at row 1, column 4 of the matrix.
		/// </summary>
		public bool M14;

		/// <summary>
		/// Creates a new instance of <see cref="Bool1x4"/>.
		/// </summary>
		public Bool1x4(bool m11, bool m12, bool m13, bool m14)
		{
			M11 = m11;
			M12 = m12;
			M13 = m13;
			M14 = m14;
		}

		/// <summary>
		/// Gets or sets a component at the specified index for the current <see cref="Bool1x4"/> .
		/// </summary>
		public bool[] this[int index]
		{
			get => null;
			set {}
		}
	}
}
