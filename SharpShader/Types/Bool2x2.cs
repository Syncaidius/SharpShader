using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 2 row, 2 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Bool2x2 : IMatrix
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

	}
}


