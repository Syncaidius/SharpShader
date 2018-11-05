using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 1 row, 3 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Double1x3 : IMatrix
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
			///	The value at row 1, column 3 of the matrix.
			/// </summary>
			public double M13;

	}
}


