using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 4 row, 1 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct UInt4x1 : IIntrinsicValue<uint>
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

			/// <summary>
			///	The value at row 4, column 1 of the matrix.
			/// </summary>
			public uint M41;

	}
}


