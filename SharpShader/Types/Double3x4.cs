using System.Runtime.InteropServices;

namespace SharpShader
{
	[StructLayout(LayoutKind.Sequential)]
	public struct Double3x4
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
			///	The value at row 1 column 3 of the matrix.
			/// </summary>
			public double M13;

			/// <summary>
			///	The value at row 2 column 1 of the matrix.
			/// </summary>
			public double M21;

			/// <summary>
			///	The value at row 2 column 2 of the matrix.
			/// </summary>
			public double M22;

			/// <summary>
			///	The value at row 2 column 3 of the matrix.
			/// </summary>
			public double M23;

			/// <summary>
			///	The value at row 3 column 1 of the matrix.
			/// </summary>
			public double M31;

			/// <summary>
			///	The value at row 3 column 2 of the matrix.
			/// </summary>
			public double M32;

			/// <summary>
			///	The value at row 3 column 3 of the matrix.
			/// </summary>
			public double M33;

			/// <summary>
			///	The value at row 4 column 1 of the matrix.
			/// </summary>
			public double M41;

			/// <summary>
			///	The value at row 4 column 2 of the matrix.
			/// </summary>
			public double M42;

			/// <summary>
			///	The value at row 4 column 3 of the matrix.
			/// </summary>
			public double M43;

	}
}


