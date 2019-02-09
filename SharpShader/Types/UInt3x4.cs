using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 3 row, 4 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct UInt3x4 : IMatrix<uint>
	{
		/// <summary>
		///	The number of rows in a <see cref="UInt3x4"/>.
		/// </summary>
		public const int ROW_COUNT = 3;

		/// <summary>
		///	The number of columns in a <see cref="UInt3x4"/>.
		/// </summary>
		public const int COLUMN_COUNT = 4;

		/// <summary>
		///	The size of a <see cref="UInt3x4"/>, in bytes.
		/// </summary>
		public const int ELEMENT_SIZE = sizeof(uint);

		/// <summary>
		///	The size of a single element within a <see cref="UInt3x4"/>, in bytes.
		/// </summary>
		public const int SIZE_OF = (ROW_COUNT * COLUMN_COUNT) * ELEMENT_SIZE;

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
		///	The value at row 2, column 1 of the matrix.
		/// </summary>
		public uint M21;

		/// <summary>
		///	The value at row 2, column 2 of the matrix.
		/// </summary>
		public uint M22;

		/// <summary>
		///	The value at row 2, column 3 of the matrix.
		/// </summary>
		public uint M23;

		/// <summary>
		///	The value at row 2, column 4 of the matrix.
		/// </summary>
		public uint M24;

		/// <summary>
		///	The value at row 3, column 1 of the matrix.
		/// </summary>
		public uint M31;

		/// <summary>
		///	The value at row 3, column 2 of the matrix.
		/// </summary>
		public uint M32;

		/// <summary>
		///	The value at row 3, column 3 of the matrix.
		/// </summary>
		public uint M33;

		/// <summary>
		///	The value at row 3, column 4 of the matrix.
		/// </summary>
		public uint M34;

		/// <summary>
		/// Creates a new instance of <see cref="UInt3x4"/>.
		/// </summary>
		public UInt3x4(uint m11, uint m21, uint m31, uint m12, uint m22, uint m32, uint m13, uint m23, uint m33, uint m14, uint m24, uint m34)
		{
			M11 = m11;
			M12 = m12;
			M13 = m13;
			M14 = m14;
			M21 = m21;
			M22 = m22;
			M23 = m23;
			M24 = m24;
			M31 = m31;
			M32 = m32;
			M33 = m33;
			M34 = m34;
		}

		/// <summary>
		/// Gets or sets a component at the specified index for the current <see cref="UInt3x4"/> .
		/// </summary>
		public uint[] this[int index]
		{
			get => null;
			set {}
		}
	}
}
