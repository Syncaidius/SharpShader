using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 2 row, 1 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Matrix2x1 : IMatrix, IIntrinsicValue
	{
			/// <summary>
			///	The value at row 1, column 1 of the matrix.
			/// </summary>
			public float M11;

			/// <summary>
			///	The value at row 2, column 1 of the matrix.
			/// </summary>
			public float M21;

	}
}


