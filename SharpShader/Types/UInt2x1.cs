using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 2 row, 1 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct UInt2x1 : IMatrix<uint>
	{
		/// <summary>
		///	The value at row 1, column 1 of the matrix.
		/// </summary>
		public uint M11;

		/// <summary>
		///	The value at row 2, column 1 of the matrix.
		/// </summary>
		public uint M21;

		/// <summary>
		/// Creates a new instance of <see cref="UInt2x1"/>.
		/// </summary>
		public UInt2x1(uint m11, uint m21)
		{
			M11 = m11;
			M21 = m21;
		}

		/// <summary>
		/// Gets or sets a component at the specified index for the current <see cref="UInt2x1"/> .
		/// </summary>
		public uint[] this[int index]
		{
			get => null;
			set {}
		}
	}
}
