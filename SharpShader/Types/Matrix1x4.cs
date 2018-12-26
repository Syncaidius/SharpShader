using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 1 row, 4 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Matrix1x4 : IMatrix<float>, IIntrinsicValue<float>
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
		/// Creates a new instance of <see cref="Matrix1x4"/>.
		/// </summary>
		public Matrix1x4(float m11, float m12, float m13, float m14)
		{
			M11 = m11;
			M12 = m12;
			M13 = m13;
			M14 = m14;
		}
	}
}


