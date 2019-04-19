using System;
using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 3 row, 1 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	[Serializable]
	public struct Bool3x1 : IMatrix<bool>
	{
		/// <summary>
		///	The number of rows in a <see cref="Bool3x1"/>.
		/// </summary>
		public const int ROW_COUNT = 3;

		/// <summary>
		///	The number of columns in a <see cref="Bool3x1"/>.
		/// </summary>
		public const int COLUMN_COUNT = 1;

		/// <summary>
		///	The size of a <see cref="Bool3x1"/>, in bytes.
		/// </summary>
		public const int ELEMENT_SIZE = sizeof(bool);

		/// <summary>
		///	The size of a single element within a <see cref="Bool3x1"/>, in bytes.
		/// </summary>
		public const int SIZE_OF = (ROW_COUNT * COLUMN_COUNT) * ELEMENT_SIZE;

		/// <summary>
		///	Gets the <see cref="Type"/> of each element in a <see cref="Bool3x1"/>.
		/// </summary>
		public static readonly Type ElementType = typeof(bool);

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
