using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 1 row, 1 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct UInt1x1 : IIntrinsicValue<uint>
	{
			/// <summary>
			///	The value at row 1, column 1 of the matrix.
			/// </summary>
			public uint M11;

	}
}


