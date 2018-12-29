using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 4 row, 1 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Matrix4x1 : IMatrix<float>, IIntrinsicValue<float>
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
		///	The value at row 4, column 1 of the matrix.
		/// </summary>
		public float M41;

		/// <summary>
		/// Creates a new instance of <see cref="Matrix4x1"/>.
		/// </summary>
		public Matrix4x1(float m11, float m21, float m31, float m41)
		{
			M11 = m11;
			M21 = m21;
			M31 = m31;
			M41 = m41;
		}

		/// <summary>
		/// Gets or sets a component at the specified index for the current <see cref="Matrix4x1"/> .
		/// </summary>
		public float[] this[int index]
		{
			get => null;
			set {}
		}
	}
}
