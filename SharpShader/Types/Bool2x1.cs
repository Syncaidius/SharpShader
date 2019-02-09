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
		///	The number of rows in a <see cref="Bool2x1"/>.
		/// </summary>
		public const int ROW_COUNT = 2;

		/// <summary>
		///	The number of columns in a <see cref="Bool2x1"/>.
		/// </summary>
		public const int COLUMN_COUNT = 1;

		/// <summary>
		///	The size of a <see cref="Bool2x1"/>, in bytes.
		/// </summary>
		public const int ELEMENT_SIZE = sizeof(bool);

		/// <summary>
		///	The size of a single element within a <see cref="Bool2x1"/>, in bytes.
		/// </summary>
		public const int SIZE_OF = (ROW_COUNT * COLUMN_COUNT) * ELEMENT_SIZE;

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
