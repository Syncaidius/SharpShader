using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 2 row, 3 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Int2x3 : IMatrix, IIntrinsicValue
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

	}
}


