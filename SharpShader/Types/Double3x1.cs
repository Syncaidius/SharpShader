using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 3 row, 1 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Double3x1 : IMatrix<double>
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
		/// Creates a new instance of <see cref="Double3x1"/>.
		/// </summary>
		public Double3x1(double m11, double m21, double m31)
		{
			M11 = m11;
			M21 = m21;
			M31 = m31;
		}

		/// <summary>
		/// Gets or sets a component at the specified index for the current <see cref="Double3x1"/> .
		/// </summary>
		public double[] this[int index]
		{
			get => null;
			set {}
		}
	}
}
