using System;
using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 3 row, 4 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	[Serializable]
	public struct Double3x4 : IMatrix<double>
	{
		/// <summary>
		///	The number of rows in a <see cref="Double3x4"/>.
		/// </summary>
		public const int ROW_COUNT = 3;

		/// <summary>
		///	The number of columns in a <see cref="Double3x4"/>.
		/// </summary>
		public const int COLUMN_COUNT = 4;

		/// <summary>
		///	The size of a <see cref="Double3x4"/>, in bytes.
		/// </summary>
		public const int ELEMENT_SIZE = sizeof(double);

		/// <summary>
		///	The size of a single element within a <see cref="Double3x4"/>, in bytes.
		/// </summary>
		public const int SIZE_OF = (ROW_COUNT * COLUMN_COUNT) * ELEMENT_SIZE;

		/// <summary>
		///	Gets the <see cref="Type"/> of each element in a <see cref="Double3x4"/>.
		/// </summary>
		public static readonly Type ElementType = typeof(double);

		/// <summary>
		///	The value at row 1, column 1 of the matrix.
		/// </summary>
		public double M11;

		/// <summary>
		///	The value at row 1, column 2 of the matrix.
		/// </summary>
		public double M12;

		/// <summary>
		///	The value at row 1, column 3 of the matrix.
		/// </summary>
		public double M13;

		/// <summary>
		///	The value at row 1, column 4 of the matrix.
		/// </summary>
		public double M14;

		/// <summary>
		///	The value at row 2, column 1 of the matrix.
		/// </summary>
		public double M21;

		/// <summary>
		///	The value at row 2, column 2 of the matrix.
		/// </summary>
		public double M22;

		/// <summary>
		///	The value at row 2, column 3 of the matrix.
		/// </summary>
		public double M23;

		/// <summary>
		///	The value at row 2, column 4 of the matrix.
		/// </summary>
		public double M24;

		/// <summary>
		///	The value at row 3, column 1 of the matrix.
		/// </summary>
		public double M31;

		/// <summary>
		///	The value at row 3, column 2 of the matrix.
		/// </summary>
		public double M32;

		/// <summary>
		///	The value at row 3, column 3 of the matrix.
		/// </summary>
		public double M33;

		/// <summary>
		///	The value at row 3, column 4 of the matrix.
		/// </summary>
		public double M34;

		/// <summary>
		/// Creates a new instance of <see cref="Double3x4"/>.
		/// </summary>
		public Double3x4(double m11, double m21, double m31, double m12, double m22, double m32, double m13, double m23, double m33, double m14, double m24, double m34)
		{
			M11 = m11;
			M12 = m12;
			M13 = m13;
			M14 = m14;
			M21 = m21;
			M22 = m22;
			M23 = m23;
			M24 = m24;
			M31 = m31;
			M32 = m32;
			M33 = m33;
			M34 = m34;
		}

		/// <summary>
		/// Gets or sets a component at the specified index for the current <see cref="Double3x4"/> .
		/// </summary>
		public double[] this[int index]
		{
			get => null;
			set {}
		}
	}
}
