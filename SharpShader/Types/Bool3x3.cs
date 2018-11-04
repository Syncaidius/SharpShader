using System.Runtime.InteropServices;

namespace SharpShader
{
	[StructLayout(LayoutKind.Sequential)]
	public struct Bool3x3
	{
			/// <summary>
			///	The value at row 1 column 1 of the matrix.
			/// </summary>
			public bool M11;

			/// <summary>
			///	The value at row 1 column 2 of the matrix.
			/// </summary>
			public bool M12;

			/// <summary>
			///	The value at row 1 column 3 of the matrix.
			/// </summary>
			public bool M13;

			/// <summary>
			///	The value at row 2 column 1 of the matrix.
			/// </summary>
			public bool M21;

			/// <summary>
			///	The value at row 2 column 2 of the matrix.
			/// </summary>
			public bool M22;

			/// <summary>
			///	The value at row 2 column 3 of the matrix.
			/// </summary>
			public bool M23;

			/// <summary>
			///	The value at row 3 column 1 of the matrix.
			/// </summary>
			public bool M31;

			/// <summary>
			///	The value at row 3 column 2 of the matrix.
			/// </summary>
			public bool M32;

			/// <summary>
			///	The value at row 3 column 3 of the matrix.
			/// </summary>
			public bool M33;

	}
}


