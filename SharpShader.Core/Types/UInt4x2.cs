using System;
using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 4 row, 2 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	[Serializable]
	public struct UInt4x2 : IMatrix<uint>
	{
		/// <summary>
		///	The number of rows in a <see cref="UInt4x2"/>.
		/// </summary>
		public const int ROW_COUNT = 4;

		/// <summary>
		///	The number of columns in a <see cref="UInt4x2"/>.
		/// </summary>
		public const int COLUMN_COUNT = 2;

		/// <summary>
		///	The size of a <see cref="UInt4x2"/>, in bytes.
		/// </summary>
		public const int ELEMENT_SIZE = sizeof(uint);

		/// <summary>
		///	The size of a single element within a <see cref="UInt4x2"/>, in bytes.
		/// </summary>
		public const int SIZE_OF = (ROW_COUNT * COLUMN_COUNT) * ELEMENT_SIZE;

		/// <summary>
		///	Gets the <see cref="Type"/> of each element in a <see cref="UInt4x2"/>.
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
		///	The value at row 2, column 1 of the matrix.
		/// </summary>
		public uint M21;

		/// <summary>
		///	The value at row 2, column 2 of the matrix.
		/// </summary>
		public uint M22;

		/// <summary>
		///	The value at row 3, column 1 of the matrix.
		/// </summary>
		public uint M31;

		/// <summary>
		///	The value at row 3, column 2 of the matrix.
		/// </summary>
		public uint M32;

		/// <summary>
		///	The value at row 4, column 1 of the matrix.
		/// </summary>
		public uint M41;

		/// <summary>
		///	The value at row 4, column 2 of the matrix.
		/// </summary>
		public uint M42;

		/// <summary>
		/// Creates a new instance of <see cref="UInt4x2"/>.
		/// </summary>
		public UInt4x2(uint m11, uint m21, uint m31, uint m41, uint m12, uint m22, uint m32, uint m42)
		{
			M11 = m11;
			M12 = m12;
			M21 = m21;
			M22 = m22;
			M31 = m31;
			M32 = m32;
			M41 = m41;
			M42 = m42;
		}

		/// <summary>
		/// Gets or sets a component at the specified index for the current <see cref="UInt4x2"/> .
		/// </summary>
		public uint[] this[int index]
		{
			get => null;
			set {}
		}
	}
}
