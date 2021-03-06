using System;
using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 1 row, 4 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	[Serializable]
	public struct UInt1x4 : IMatrix<uint>
	{
		/// <summary>
		///	The number of rows in a <see cref="UInt1x4"/>.
		/// </summary>
		public const int ROW_COUNT = 1;

		/// <summary>
		///	The number of columns in a <see cref="UInt1x4"/>.
		/// </summary>
		public const int COLUMN_COUNT = 4;

		/// <summary>
		///	The size of a <see cref="UInt1x4"/>, in bytes.
		/// </summary>
		public const int ELEMENT_SIZE = sizeof(uint);

		/// <summary>
		///	The size of a single element within a <see cref="UInt1x4"/>, in bytes.
		/// </summary>
		public const int SIZE_OF = (ROW_COUNT * COLUMN_COUNT) * ELEMENT_SIZE;

		/// <summary>
		///	Gets the <see cref="Type"/> of each element in a <see cref="UInt1x4"/>.
		/// </summary>
		public static readonly Type ElementType = typeof(uint);

		/// <summary>
		///	The value at row 1, column 1 of the matrix.
		/// </summary>
		public uint M11;

		/// <summary>
		///	The value at row 1, column 2 of the matrix.
		/// </summary>
		public uint M12;

		/// <summary>
		///	The value at row 1, column 3 of the matrix.
		/// </summary>
		public uint M13;

		/// <summary>
		///	The value at row 1, column 4 of the matrix.
		/// </summary>
		public uint M14;

		/// <summary>
		/// Creates a new instance of <see cref="UInt1x4"/>.
		/// </summary>
		public UInt1x4(uint m11, uint m12, uint m13, uint m14)
		{
			M11 = m11;
			M12 = m12;
			M13 = m13;
			M14 = m14;
		}

		/// <summary>
		/// Gets or sets a component at the specified index for the current <see cref="UInt1x4"/> .
		/// </summary>
		public uint[] this[int index]
		{
			get => null;
			set {}
		}
	}
}
