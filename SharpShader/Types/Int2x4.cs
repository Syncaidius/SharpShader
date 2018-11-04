using System.Runtime.InteropServices;

namespace SharpShader
{
	[StructLayout(LayoutKind.Sequential)]
	public struct Int2x4
	{
			/// <summary>
			///	The value at row 1 column 1 of the matrix.
			/// </summary>
			public int M11;

			/// <summary>
			///	The value at row 1 column 2 of the matrix.
			/// </summary>
			public int M12;

			/// <summary>
			///	The value at row 2 column 1 of the matrix.
			/// </summary>
			public int M21;

			/// <summary>
			///	The value at row 2 column 2 of the matrix.
			/// </summary>
			public int M22;

			/// <summary>
			///	The value at row 3 column 1 of the matrix.
			/// </summary>
			public int M31;

			/// <summary>
			///	The value at row 3 column 2 of the matrix.
			/// </summary>
			public int M32;

			/// <summary>
			///	The value at row 4 column 1 of the matrix.
			/// </summary>
			public int M41;

			/// <summary>
			///	The value at row 4 column 2 of the matrix.
			/// </summary>
			public int M42;

	}
}


