using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 3 row, 2 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Double3x2 : IIntrinsicValue<double>
	{
			/// <summary>
			///	The value at row 1, column 1 of the matrix.
			/// </summary>
			public double M11;

			/// <summary>
			///	The value at row 1, column 2 of the matrix.
			/// </summary>
			public double M12;

			/// <summary>
			///	The value at row 2, column 1 of the matrix.
			/// </summary>
			public double M21;

			/// <summary>
			///	The value at row 2, column 2 of the matrix.
			/// </summary>
			public double M22;

			/// <summary>
			///	The value at row 3, column 1 of the matrix.
			/// </summary>
			public double M31;

			/// <summary>
			///	The value at row 3, column 2 of the matrix.
			/// </summary>
			public double M32;

	}
}


