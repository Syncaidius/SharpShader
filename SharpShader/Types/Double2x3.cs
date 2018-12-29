using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 2 row, 3 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Double2x3 : IMatrix<double>
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
		/// Creates a new instance of <see cref="Double2x3"/>.
		/// </summary>
		public Double2x3(double m11, double m21, double m12, double m22, double m13, double m23)
		{
			M11 = m11;
			M12 = m12;
			M13 = m13;
			M21 = m21;
			M22 = m22;
			M23 = m23;
		}

		/// <summary>
		/// Gets or sets a component at the specified index for the current <see cref="Double2x3"/> .
		/// </summary>
		public double[] this[int index]
		{
			get => null;
			set {}
		}
	}
}
