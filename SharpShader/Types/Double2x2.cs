using System.Runtime.InteropServices;

namespace SharpShader
{
	[StructLayout(LayoutKind.Sequential)]
	public struct Double2x2
	{
			/// <summary>
			///	The value at row 1 column 1 of the matrix.
			/// </summary>
			public double M11;

			/// <summary>
			///	The value at row 1 column 2 of the matrix.
			/// </summary>
			public double M12;

			/// <summary>
			///	The value at row 2 column 1 of the matrix.
			/// </summary>
			public double M21;

			/// <summary>
			///	The value at row 2 column 2 of the matrix.
			/// </summary>
			public double M22;

	}
}


