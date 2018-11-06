using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 4 row, 3 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Int4x3 : IMatrix<int>, IIntrinsicValue<int>
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
			///	The value at row 4, column 1 of the matrix.
			/// </summary>
			public int M41;

			/// <summary>
			///	The value at row 4, column 2 of the matrix.
			/// </summary>
			public int M42;

			/// <summary>
			///	The value at row 4, column 3 of the matrix.
			/// </summary>
			public int M43;

	}
}


