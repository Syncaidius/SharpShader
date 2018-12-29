using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 2 row, 3 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Matrix2x3 : IMatrix<float>, IIntrinsicValue<float>
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
		///	The value at row 2, column 1 of the matrix.
		/// </summary>
		public float M21;

		/// <summary>
		///	The value at row 2, column 2 of the matrix.
		/// </summary>
		public float M22;

		/// <summary>
		///	The value at row 2, column 3 of the matrix.
		/// </summary>
		public float M23;

		/// <summary>
		/// Creates a new instance of <see cref="Matrix2x3"/>.
		/// </summary>
		public Matrix2x3(float m11, float m21, float m12, float m22, float m13, float m23)
		{
			M11 = m11;
			M12 = m12;
			M13 = m13;
			M21 = m21;
			M22 = m22;
			M23 = m23;
		}

		/// <summary>
		/// Gets or sets a component at the specified index for the current <see cref="Matrix2x3"/> .
		/// </summary>
		public float[] this[int index]
		{
			get => null;
			set {}
		}
	}
}
