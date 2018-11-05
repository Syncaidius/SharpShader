using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 3 row, 1 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct UInt3x1 : IMatrix
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

	}
}


