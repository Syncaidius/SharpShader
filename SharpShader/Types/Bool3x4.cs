using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 3 row, 4 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Bool3x4 : IMatrix<bool>
	{
		/// <summary>
		///	The value at row 1, column 1 of the matrix.
		/// </summary>
		public bool M11;

		/// <summary>
		///	The value at row 1, column 2 of the matrix.
		/// </summary>
		public bool M12;

		/// <summary>
		///	The value at row 1, column 3 of the matrix.
		/// </summary>
		public bool M13;

		/// <summary>
		///	The value at row 1, column 4 of the matrix.
		/// </summary>
		public bool M14;

		/// <summary>
		///	The value at row 2, column 1 of the matrix.
		/// </summary>
		public bool M21;

		/// <summary>
		///	The value at row 2, column 2 of the matrix.
		/// </summary>
		public bool M22;

		/// <summary>
		///	The value at row 2, column 3 of the matrix.
		/// </summary>
		public bool M23;

		/// <summary>
		///	The value at row 2, column 4 of the matrix.
		/// </summary>
		public bool M24;

		/// <summary>
		///	The value at row 3, column 1 of the matrix.
		/// </summary>
		public bool M31;

		/// <summary>
		///	The value at row 3, column 2 of the matrix.
		/// </summary>
		public bool M32;

		/// <summary>
		///	The value at row 3, column 3 of the matrix.
		/// </summary>
		public bool M33;

		/// <summary>
		///	The value at row 3, column 4 of the matrix.
		/// </summary>
		public bool M34;

		/// <summary>
		/// Creates a new instance of <see cref="Bool3x4"/>.
		/// </summary>
		public Bool3x4(bool m11, bool m21, bool m31, bool m12, bool m22, bool m32, bool m13, bool m23, bool m33, bool m14, bool m24, bool m34)
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
	}
}


