using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 4 row, 4 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct UInt4x4 : IMatrix<uint>
	{
			/// <summary>
			///	The value at row 1, column 1 of the matrix.
			/// </summary>
			public uint M11;

			/// <summary>
			///	The value at row 1, column 2 of the matrix.
			/// </summary>
			public uint M12;

			/// <summary>
			///	The value at row 1, column 3 of the matrix.
			/// </summary>
			public uint M13;

			/// <summary>
			///	The value at row 1, column 4 of the matrix.
			/// </summary>
			public uint M14;

			/// <summary>
			///	The value at row 2, column 1 of the matrix.
			/// </summary>
			public uint M21;

			/// <summary>
			///	The value at row 2, column 2 of the matrix.
			/// </summary>
			public uint M22;

			/// <summary>
			///	The value at row 2, column 3 of the matrix.
			/// </summary>
			public uint M23;

			/// <summary>
			///	The value at row 2, column 4 of the matrix.
			/// </summary>
			public uint M24;

			/// <summary>
			///	The value at row 3, column 1 of the matrix.
			/// </summary>
			public uint M31;

			/// <summary>
			///	The value at row 3, column 2 of the matrix.
			/// </summary>
			public uint M32;

			/// <summary>
			///	The value at row 3, column 3 of the matrix.
			/// </summary>
			public uint M33;

			/// <summary>
			///	The value at row 3, column 4 of the matrix.
			/// </summary>
			public uint M34;

			/// <summary>
			///	The value at row 4, column 1 of the matrix.
			/// </summary>
			public uint M41;

			/// <summary>
			///	The value at row 4, column 2 of the matrix.
			/// </summary>
			public uint M42;

			/// <summary>
			///	The value at row 4, column 3 of the matrix.
			/// </summary>
			public uint M43;

			/// <summary>
			///	The value at row 4, column 4 of the matrix.
			/// </summary>
			public uint M44;

	}
}


