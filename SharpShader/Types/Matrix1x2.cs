using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 1 row, 2 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Matrix1x2 : IMatrix<float>, IIntrinsicValue<float>
	{
		/// <summary>
		///	The number of rows in a <see cref="Matrix1x2"/>.
		/// </summary>
		public const int ROW_COUNT = 1;

		/// <summary>
		///	The number of columns in a <see cref="Matrix1x2"/>.
		/// </summary>
		public const int COLUMN_COUNT = 2;

		/// <summary>
		///	The size of a <see cref="Matrix1x2"/>, in bytes.
		/// </summary>
		public const int ELEMENT_SIZE = sizeof(float);

		/// <summary>
		///	The size of a single element within a <see cref="Matrix1x2"/>, in bytes.
		/// </summary>
		public const int SIZE_OF = (ROW_COUNT * COLUMN_COUNT) * ELEMENT_SIZE;

		/// <summary>
		///	The value at row 1, column 1 of the matrix.
		/// </summary>
		public float M11;

		/// <summary>
		///	The value at row 1, column 2 of the matrix.
		/// </summary>
		public float M12;

		/// <summary>
		/// Creates a new instance of <see cref="Matrix1x2"/>.
		/// </summary>
		public Matrix1x2(float m11, float m12)
		{
			M11 = m11;
			M12 = m12;
		}

		/// <summary>
		/// Gets or sets a component at the specified index for the current <see cref="Matrix1x2"/> .
		/// </summary>
		public float[] this[int index]
		{
			get => null;
			set {}
		}
	}
}
