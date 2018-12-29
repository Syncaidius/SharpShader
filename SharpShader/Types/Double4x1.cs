using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 4 row, 1 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Double4x1 : IMatrix<double>
	{
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
