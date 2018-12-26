using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 1 row, 2 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct UInt1x2 : IMatrix<uint>
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
		/// Creates a new instance of <see cref="UInt1x2"/>.
		/// </summary>
		public UInt1x2(uint m11, uint m12)
		{
			M11 = m11;
			M12 = m12;
		}
	}
}


