using System;
using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 1 row, 1 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	[Serializable]
	public struct Bool1x1 : IMatrix<bool>, UniformDimensions
	{
		/// <summary>
		///	The number of rows in a <see cref="Bool1x1"/>.
		/// </summary>
		public const int ROW_COUNT = 1;

		/// <summary>
		///	The number of columns in a <see cref="Bool1x1"/>.
		/// </summary>
		public const int COLUMN_COUNT = 1;

		/// <summary>
		///	The size of a <see cref="Bool1x1"/>, in bytes.
		/// </summary>
		public const int ELEMENT_SIZE = sizeof(bool);

		/// <summary>
		///	The size of a single element within a <see cref="Bool1x1"/>, in bytes.
		/// </summary>
		public const int SIZE_OF = (ROW_COUNT * COLUMN_COUNT) * ELEMENT_SIZE;

		/// <summary>
		///	Gets the <see cref="Type"/> of each element in a <see cref="Bool1x1"/>.
		/// </summary>
		public static readonly Type ElementType = typeof(bool);

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

		/// <summary>
		/// Gets or sets a component at the specified index for the current <see cref="Bool1x1"/> .
		/// </summary>
		public bool[] this[int index]
		{
			get => null;
			set {}
		}
	}
}
