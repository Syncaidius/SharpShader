using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 3 row, 1 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Bool3x1 : IMatrix<bool>
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
		///	The value at row 3, column 1 of the matrix.
		/// </summary>
		public bool M31;

		/// <summary>
		/// Creates a new instance of <see cref="Bool3x1"/>.
		/// </summary>
		public Bool3x1(bool m11, bool m21, bool m31)
		{
			M11 = m11;
			M21 = m21;
			M31 = m31;
		}

		/// <summary>
		/// Gets or sets a component at the specified index for the current <see cref="Bool3x1"/> .
		/// </summary>
		public bool[] this[int index]
		{
			get => null;
			set {}
		}
	}
}
