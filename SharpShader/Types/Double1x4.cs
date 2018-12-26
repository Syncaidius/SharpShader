using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 1 row, 4 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Double1x4 : IMatrix<double>
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
		///	The value at row 1, column 4 of the matrix.
		/// </summary>
		public double M14;

		/// <summary>
		/// Creates a new instance of <see cref="Double1x4"/>.
		/// </summary>
		public Double1x4(double m11, double m12, double m13, double m14)
		{
			M11 = m11;
			M12 = m12;
			M13 = m13;
			M14 = m14;
		}
	}
}


