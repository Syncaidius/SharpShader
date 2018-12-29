using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 2 row, 2 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Matrix2x2 : IMatrix<float>, IIntrinsicValue<float>, UniformDimensions
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
		///	The value at row 2, column 1 of the matrix.
		/// </summary>
		public float M21;

		/// <summary>
		///	The value at row 2, column 2 of the matrix.
		/// </summary>
		public float M22;

		/// <summary>
		/// Creates a new instance of <see cref="Matrix2x2"/>.
		/// </summary>
		public Matrix2x2(float m11, float m21, float m12, float m22)
		{
			M11 = m11;
			M12 = m12;
			M21 = m21;
			M22 = m22;
		}

		/// <summary>
		/// Gets or sets a component at the specified index for the current <see cref="Matrix2x2"/> .
		/// </summary>
		public float[] this[int index]
		{
			get => null;
			set {}
		}
	}
}
