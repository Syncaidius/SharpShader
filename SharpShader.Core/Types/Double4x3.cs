using System;
using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 4 row, 3 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	[Serializable]
	public struct Double4x3 : IMatrix<double>
	{
		/// <summary>
		///	The number of rows in a <see cref="Double4x3"/>.
		/// </summary>
		public const int ROW_COUNT = 4;

		/// <summary>
		///	The number of columns in a <see cref="Double4x3"/>.
		/// </summary>
		public const int COLUMN_COUNT = 3;

		/// <summary>
		///	The size of a <see cref="Double4x3"/>, in bytes.
		/// </summary>
		public const int ELEMENT_SIZE = sizeof(double);

		/// <summary>
		///	The size of a single element within a <see cref="Double4x3"/>, in bytes.
		/// </summary>
		public const int SIZE_OF = (ROW_COUNT * COLUMN_COUNT) * ELEMENT_SIZE;

		/// <summary>
		///	Gets the <see cref="Type"/> of each element in a <see cref="Double4x3"/>.
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
		///	The value at row 4, column 1 of the matrix.
		/// </summary>
		public double M41;

		/// <summary>
		///	The value at row 4, column 2 of the matrix.
		/// </summary>
		public double M42;

		/// <summary>
		///	The value at row 4, column 3 of the matrix.
		/// </summary>
		public double M43;

		/// <summary>
		/// Creates a new instance of <see cref="Double4x3"/>.
		/// </summary>
		public Double4x3(double m11, double m21, double m31, double m41, double m12, double m22, double m32, double m42, double m13, double m23, double m33, double m43)
		{
			M11 = m11;
			M12 = m12;
			M13 = m13;
			M21 = m21;
			M22 = m22;
			M23 = m23;
			M31 = m31;
			M32 = m32;
			M33 = m33;
			M41 = m41;
			M42 = m42;
			M43 = m43;
		}

		/// <summary>
		/// Gets or sets a component at the specified index for the current <see cref="Double4x3"/> .
		/// </summary>
		public double[] this[int index]
		{
			get => null;
			set {}
		}
	}
}
