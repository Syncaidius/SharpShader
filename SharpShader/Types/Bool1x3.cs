using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 1 row, 3 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Bool1x3 : IIntrinsicValue<bool>
	{
			/// <summary>
			///	The value at row 1, column 1 of the matrix.
			/// </summary>
			public bool M11;

			/// <summary>
			///	The value at row 1, column 2 of the matrix.
			/// </summary>
			public bool M12;

			/// <summary>
			///	The value at row 1, column 3 of the matrix.
			/// </summary>
			public bool M13;

	}
}


