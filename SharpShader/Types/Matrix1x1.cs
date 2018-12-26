

using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 1 row, 1 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Matrix1x1 : IMatrix<float>, IIntrinsicValue<float>, UniformDimensions
	{
		/// <summary>
		///	The value at row 1, column 1 of the matrix.
		/// </summary>
		public float M11;

		/// <summary>
		/// Creates a new instance of <see cref="Matrix1x1"/>.
		/// </summary>
		public Matrix1x1(float m11)
		{
			M11 = m11;
		}
	}
}


