using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 4 row, 1 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct UInt4x1 : IMatrix<uint>
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
		///	The value at row 3, column 1 of the matrix.
		/// </summary>
		public uint M31;

		/// <summary>
		///	The value at row 4, column 1 of the matrix.
		/// </summary>
		public uint M41;

		/// <summary>
		/// Creates a new instance of <see cref="UInt4x1"/>.
		/// </summary>
		public UInt4x1(uint m11, uint m21, uint m31, uint m41)
		{
			M11 = m11;
			M21 = m21;
			M31 = m31;
			M41 = m41;
		}

		/// <summary>
		/// Gets or sets a component at the specified index for the current <see cref="UInt4x1"/> .
		/// </summary>
		public uint[] this[int index]
		{
			get => null;
			set {}
		}
	}
}
