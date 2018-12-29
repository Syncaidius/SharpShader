using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 3 row, 4 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Int3x4 : IMatrix<int>, IIntrinsicValue<int>
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
		///	The value at row 1, column 3 of the matrix.
		/// </summary>
		public int M13;

		/// <summary>
		///	The value at row 1, column 4 of the matrix.
		/// </summary>
		public int M14;

		/// <summary>
		///	The value at row 2, column 1 of the matrix.
		/// </summary>
		public int M21;

		/// <summary>
		///	The value at row 2, column 2 of the matrix.
		/// </summary>
		public int M22;

		/// <summary>
		///	The value at row 2, column 3 of the matrix.
		/// </summary>
		public int M23;

		/// <summary>
		///	The value at row 2, column 4 of the matrix.
		/// </summary>
		public int M24;

		/// <summary>
		///	The value at row 3, column 1 of the matrix.
		/// </summary>
		public int M31;

		/// <summary>
		///	The value at row 3, column 2 of the matrix.
		/// </summary>
		public int M32;

		/// <summary>
		///	The value at row 3, column 3 of the matrix.
		/// </summary>
		public int M33;

		/// <summary>
		///	The value at row 3, column 4 of the matrix.
		/// </summary>
		public int M34;

		/// <summary>
		/// Creates a new instance of <see cref="Int3x4"/>.
		/// </summary>
		public Int3x4(int m11, int m21, int m31, int m12, int m22, int m32, int m13, int m23, int m33, int m14, int m24, int m34)
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
		/// Gets or sets a component at the specified index for the current <see cref="Int3x4"/> .
		/// </summary>
		public int[] this[int index]
		{
			get => null;
			set {}
		}
	}
}
