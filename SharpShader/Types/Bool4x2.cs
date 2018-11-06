using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 4 row, 2 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Bool4x2 : IMatrix<bool>
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
			///	The value at row 2, column 1 of the matrix.
			/// </summary>
			public bool M21;

			/// <summary>
			///	The value at row 2, column 2 of the matrix.
			/// </summary>
			public bool M22;

			/// <summary>
			///	The value at row 3, column 1 of the matrix.
			/// </summary>
			public bool M31;

			/// <summary>
			///	The value at row 3, column 2 of the matrix.
			/// </summary>
			public bool M32;

			/// <summary>
			///	The value at row 4, column 1 of the matrix.
			/// </summary>
			public bool M41;

			/// <summary>
			///	The value at row 4, column 2 of the matrix.
			/// </summary>
			public bool M42;

	}
}


