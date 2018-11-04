using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 2 row, 4 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Matrix2x4 : IIntrinsicValue<float>
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
			///	The value at row 1, column 3 of the matrix.
			/// </summary>
			public float M13;

			/// <summary>
			///	The value at row 1, column 4 of the matrix.
			/// </summary>
			public float M14;

			/// <summary>
			///	The value at row 2, column 1 of the matrix.
			/// </summary>
			public float M21;

			/// <summary>
			///	The value at row 2, column 2 of the matrix.
			/// </summary>
			public float M22;

			/// <summary>
			///	The value at row 2, column 3 of the matrix.
			/// </summary>
			public float M23;

			/// <summary>
			///	The value at row 2, column 4 of the matrix.
			/// </summary>
			public float M24;

	}
}


