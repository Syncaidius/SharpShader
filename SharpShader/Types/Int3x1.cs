using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 3 row, 1 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Int3x1 : IMatrix<int>, IIntrinsicValue<int>
	{
			/// <summary>
			///	The value at row 1, column 1 of the matrix.
			/// </summary>
			public int M11;

			/// <summary>
			///	The value at row 2, column 1 of the matrix.
			/// </summary>
			public int M21;

			/// <summary>
			///	The value at row 3, column 1 of the matrix.
			/// </summary>
			public int M31;

	}
}


