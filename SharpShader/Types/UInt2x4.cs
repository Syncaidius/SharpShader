using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 2 row, 4 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct UInt2x4 : IMatrix<uint>
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
		/// Creates a new instance of <see cref="UInt2x4"/>.
		/// </summary>
		public UInt2x4(uint m11, uint m21, uint m12, uint m22, uint m13, uint m23, uint m14, uint m24)
		{
			M11 = m11;
			M12 = m12;
			M13 = m13;
			M14 = m14;
			M21 = m21;
			M22 = m22;
			M23 = m23;
			M24 = m24;
		}
	}
}


