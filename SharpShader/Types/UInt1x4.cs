using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 1 row, 4 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct UInt1x4 : IMatrix<uint>
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
		/// Creates a new instance of <see cref="UInt1x4"/>.
		/// </summary>
		public UInt1x4(uint m11, uint m12, uint m13, uint m14)
		{
			M11 = m11;
			M12 = m12;
			M13 = m13;
			M14 = m14;
		}
	}
}


