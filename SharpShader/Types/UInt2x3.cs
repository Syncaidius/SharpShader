using System.Runtime.InteropServices;

namespace SharpShader
{
	[StructLayout(LayoutKind.Sequential)]
	public struct UInt2x3
	{
			/// <summary>
			///	The value at row 1 column 1 of the matrix.
			/// </summary>
			public uint M11;

			/// <summary>
			///	The value at row 1 column 2 of the matrix.
			/// </summary>
			public uint M12;

			/// <summary>
			///	The value at row 2 column 1 of the matrix.
			/// </summary>
			public uint M21;

			/// <summary>
			///	The value at row 2 column 2 of the matrix.
			/// </summary>
			public uint M22;

			/// <summary>
			///	The value at row 3 column 1 of the matrix.
			/// </summary>
			public uint M31;

			/// <summary>
			///	The value at row 3 column 2 of the matrix.
			/// </summary>
			public uint M32;

	}
}


