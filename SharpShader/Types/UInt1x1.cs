using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 1 row, 1 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct UInt1x1 : IMatrix<uint>, UniformDimensions
	{
		/// <summary>
		///	The value at row 1, column 1 of the matrix.
		/// </summary>
		public uint M11;

		/// <summary>
		/// Creates a new instance of <see cref="UInt1x1"/>.
		/// </summary>
		public UInt1x1(uint m11)
		{
			M11 = m11;
		}

		/// <summary>
		/// Gets or sets a component at the specified index for the current <see cref="UInt1x1"/> .
		/// </summary>
		public uint[] this[int index]
		{
			get => null;
			set {}
		}
	}
}
