using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 4 row, 3 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Bool4x3 : IMatrix<bool>
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
		///	The value at row 4, column 1 of the matrix.
		/// </summary>
		public bool M41;

		/// <summary>
		///	The value at row 4, column 2 of the matrix.
		/// </summary>
		public bool M42;

		/// <summary>
		///	The value at row 4, column 3 of the matrix.
		/// </summary>
		public bool M43;

		/// <summary>
		/// Creates a new instance of <see cref="Bool4x3"/>.
		/// </summary>
		public Bool4x3(bool m11, bool m21, bool m31, bool m41, bool m12, bool m22, bool m32, bool m42, bool m13, bool m23, bool m33, bool m43)
		{
			M11 = m11;
			M12 = m12;
			M13 = m13;
			M21 = m21;
			M22 = m22;
			M23 = m23;
			M31 = m31;
			M32 = m32;
			M33 = m33;
			M41 = m41;
			M42 = m42;
			M43 = m43;
		}
	}
}


