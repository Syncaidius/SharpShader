using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 2 row, 4 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Bool2x4 : IMatrix<bool>
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

	}
}


