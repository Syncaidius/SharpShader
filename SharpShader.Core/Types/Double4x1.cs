using System;
using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 4 row, 1 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	[Serializable]
	public struct Double4x1 : IMatrix<double>
	{
		/// <summary>
		///	The number of rows in a <see cref="Double4x1"/>.
		/// </summary>
		public const int ROW_COUNT = 4;

		/// <summary>
		///	The number of columns in a <see cref="Double4x1"/>.
		/// </summary>
		public const int COLUMN_COUNT = 1;

		/// <summary>
		///	The size of a <see cref="Double4x1"/>, in bytes.
		/// </summary>
		public const int ELEMENT_SIZE = sizeof(double);

		/// <summary>
		///	The size of a single element within a <see cref="Double4x1"/>, in bytes.
		/// </summary>
		public const int SIZE_OF = (ROW_COUNT * COLUMN_COUNT) * ELEMENT_SIZE;

		/// <summary>
		///	Gets the <see cref="Type"/> of each element in a <see cref="Double4x1"/>.
		/// </summary>
		public static readonly Type ElementType = typeof(double);

		/// <summary>
		///	The value at row 1, column 1 of the matrix.
		/// </summary>
		public double M11;

		/// <summary>
		///	The value at row 2, column 1 of the matrix.
		/// </summary>
		public double M21;

		/// <summary>
		///	The value at row 3, column 1 of the matrix.
		/// </summary>
		public double M31;

		/// <summary>
		///	The value at row 4, column 1 of the matrix.
		/// </summary>
		public double M41;

		/// <summary>
		/// Creates a new instance of <see cref="Double4x1"/>.
		/// </summary>
		public Double4x1(double m11, double m21, double m31, double m41)
		{
			M11 = m11;
			M21 = m21;
			M31 = m31;
			M41 = m41;
		}

		/// <summary>
		/// Gets or sets a component at the specified index for the current <see cref="Double4x1"/> .
		/// </summary>
		public double[] this[int index]
		{
			get => null;
			set {}
		}
	}
}
