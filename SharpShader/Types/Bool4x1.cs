using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 4 row, 1 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Bool4x1 : IMatrix
	{
			/// <summary>
			///	The value at row 1, column 1 of the matrix.
			/// </summary>
			public bool M11;

			/// <summary>
			///	The value at row 2, column 1 of the matrix.
			/// </summary>
			public bool M21;

			/// <summary>
			///	The value at row 3, column 1 of the matrix.
			/// </summary>
			public bool M31;

			/// <summary>
			///	The value at row 4, column 1 of the matrix.
			/// </summary>
			public bool M41;

	}
}


