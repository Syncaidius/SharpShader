using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 3 row, 4 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Int3x4 : IIntrinsicValue<int>
	{
			/// <summary>
			///	The value at row 1, column 1 of the matrix.
			/// </summary>
			public int M11;

			/// <summary>
			///	The value at row 1, column 2 of the matrix.
			/// </summary>
			public int M12;

			/// <summary>
			///	The value at row 1, column 3 of the matrix.
			/// </summary>
			public int M13;

			/// <summary>
			///	The value at row 1, column 4 of the matrix.
			/// </summary>
			public int M14;

			/// <summary>
			///	The value at row 2, column 1 of the matrix.
			/// </summary>
			public int M21;

			/// <summary>
			///	The value at row 2, column 2 of the matrix.
			/// </summary>
			public int M22;

			/// <summary>
			///	The value at row 2, column 3 of the matrix.
			/// </summary>
			public int M23;

			/// <summary>
			///	The value at row 2, column 4 of the matrix.
			/// </summary>
			public int M24;

			/// <summary>
			///	The value at row 3, column 1 of the matrix.
			/// </summary>
			public int M31;

			/// <summary>
			///	The value at row 3, column 2 of the matrix.
			/// </summary>
			public int M32;

			/// <summary>
			///	The value at row 3, column 3 of the matrix.
			/// </summary>
			public int M33;

			/// <summary>
			///	The value at row 3, column 4 of the matrix.
			/// </summary>
			public int M34;

	}
}


