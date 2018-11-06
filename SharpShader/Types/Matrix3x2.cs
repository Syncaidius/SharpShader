using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 3 row, 2 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Matrix3x2 : IMatrix<float>, IIntrinsicValue<float>
	{
			/// <summary>
			///	The value at row 1, column 1 of the matrix.
			/// </summary>
			public float M11;

			/// <summary>
			///	The value at row 1, column 2 of the matrix.
			/// </summary>
			public float M12;

			/// <summary>
			///	The value at row 2, column 1 of the matrix.
			/// </summary>
			public float M21;

			/// <summary>
			///	The value at row 2, column 2 of the matrix.
			/// </summary>
			public float M22;

			/// <summary>
			///	The value at row 3, column 1 of the matrix.
			/// </summary>
			public float M31;

			/// <summary>
			///	The value at row 3, column 2 of the matrix.
			/// </summary>
			public float M32;

	}
}


