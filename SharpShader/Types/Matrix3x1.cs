using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 3 row, 1 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Matrix3x1 : IMatrix<float>, IIntrinsicValue<float>
	{
		/// <summary>
		///	The value at row 1, column 1 of the matrix.
		/// </summary>
		public float M11;

		/// <summary>
		///	The value at row 2, column 1 of the matrix.
		/// </summary>
		public float M21;

		/// <summary>
		///	The value at row 3, column 1 of the matrix.
		/// </summary>
		public float M31;

		/// <summary>
		/// Creates a new instance of <see cref="Matrix3x1"/>.
		/// </summary>
		public Matrix3x1(float m11, float m21, float m31)
		{
			M11 = m11;
			M21 = m21;
			M31 = m31;
		}

		/// <summary>
		/// Gets or sets a component at the specified index for the current <see cref="Matrix3x1"/> .
		/// </summary>
		public float[] this[int index]
		{
			get => null;
			set {}
		}
	}
}
