using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 1 row, 1 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Double1x1 : IMatrix<double>, UniformDimensions
	{
		/// <summary>
		///	The value at row 1, column 1 of the matrix.
		/// </summary>
		public double M11;

		/// <summary>
		/// Creates a new instance of <see cref="Double1x1"/>.
		/// </summary>
		public Double1x1(double m11)
		{
			M11 = m11;
		}
	}
}


