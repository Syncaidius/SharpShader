using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 4 row, 2 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Double4x2 : IMatrix<double>
	{
		/// <summary>
		///	The value at row 1, column 1 of the matrix.
		/// </summary>
		public double M11;

		/// <summary>
		///	The value at row 1, column 2 of the matrix.
		/// </summary>
		public double M12;

		/// <summary>
		///	The value at row 2, column 1 of the matrix.
		/// </summary>
		public double M21;

		/// <summary>
		///	The value at row 2, column 2 of the matrix.
		/// </summary>
		public double M22;

		/// <summary>
		///	The value at row 3, column 1 of the matrix.
		/// </summary>
		public double M31;

		/// <summary>
		///	The value at row 3, column 2 of the matrix.
		/// </summary>
		public double M32;

		/// <summary>
		///	The value at row 4, column 1 of the matrix.
		/// </summary>
		public double M41;

		/// <summary>
		///	The value at row 4, column 2 of the matrix.
		/// </summary>
		public double M42;

		/// <summary>
		/// Creates a new instance of <see cref="Double4x2"/>.
		/// </summary>
		public Double4x2(double m11, double m21, double m31, double m41, double m12, double m22, double m32, double m42)
		{
			M11 = m11;
			M12 = m12;
			M21 = m21;
			M22 = m22;
			M31 = m31;
			M32 = m32;
			M41 = m41;
			M42 = m42;
		}

		/// <summary>
		/// Gets or sets a component at the specified index for the current <see cref="Double4x2"/> .
		/// </summary>
		public double[] this[int index]
		{
			get => null;
			set {}
		}
	}
}
