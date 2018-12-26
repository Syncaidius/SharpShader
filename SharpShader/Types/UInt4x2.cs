using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 4 row, 2 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct UInt4x2 : IMatrix<uint>
	{
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
	}
}


