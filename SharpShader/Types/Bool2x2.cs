using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 2 row, 2 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Bool2x2 : IMatrix<bool>, UniformDimensions
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
		///	The value at row 2, column 1 of the matrix.
		/// </summary>
		public bool M21;

		/// <summary>
		///	The value at row 2, column 2 of the matrix.
		/// </summary>
		public bool M22;

		/// <summary>
		/// Creates a new instance of <see cref="Bool2x2"/>.
		/// </summary>
		public Bool2x2(bool m11, bool m21, bool m12, bool m22)
		{
			M11 = m11;
			M12 = m12;
			M21 = m21;
			M22 = m22;
		}

		/// <summary>
		/// Gets or sets a component at the specified index for the current <see cref="Bool2x2"/> .
		/// </summary>
		public bool[] this[int index]
		{
			get => null;
			set {}
		}
	}
}
