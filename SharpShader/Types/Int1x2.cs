using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 1 row, 2 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Int1x2 : IMatrix<int>, IIntrinsicValue<int>
	{
		/// <summary>
		///	The value at row 1, column 1 of the matrix.
		/// </summary>
		public int M11;

		/// <summary>
		///	The value at row 1, column 2 of the matrix.
		/// </summary>
		public int M12;

		/// <summary>
		/// Creates a new instance of <see cref="Int1x2"/>.
		/// </summary>
		public Int1x2(int m11, int m12)
		{
			M11 = m11;
			M12 = m12;
		}

		/// <summary>
		/// Gets or sets a component at the specified index for the current <see cref="Int1x2"/> .
		/// </summary>
		public int[] this[int index]
		{
			get => null;
			set {}
		}
	}
}
