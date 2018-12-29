using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 4 row, 4 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct UInt4x4 : IMatrix<uint>, UniformDimensions
	{
		/// <summary>
		///	The value at row 1, column 1 of the matrix.
		/// </summary>
		public uint M11;

		/// <summary>
		///	The value at row 1, column 2 of the matrix.
		/// </summary>
		public uint M12;

		/// <summary>
		///	The value at row 1, column 3 of the matrix.
		/// </summary>
		public uint M13;

		/// <summary>
		///	The value at row 1, column 4 of the matrix.
		/// </summary>
		public uint M14;

		/// <summary>
		///	The value at row 2, column 1 of the matrix.
		/// </summary>
		public uint M21;

		/// <summary>
		///	The value at row 2, column 2 of the matrix.
		/// </summary>
		public uint M22;

		/// <summary>
		///	The value at row 2, column 3 of the matrix.
		/// </summary>
		public uint M23;

		/// <summary>
		///	The value at row 2, column 4 of the matrix.
		/// </summary>
		public uint M24;

		/// <summary>
		///	The value at row 3, column 1 of the matrix.
		/// </summary>
		public uint M31;

		/// <summary>
		///	The value at row 3, column 2 of the matrix.
		/// </summary>
		public uint M32;

		/// <summary>
		///	The value at row 3, column 3 of the matrix.
		/// </summary>
		public uint M33;

		/// <summary>
		///	The value at row 3, column 4 of the matrix.
		/// </summary>
		public uint M34;

		/// <summary>
		///	The value at row 4, column 1 of the matrix.
		/// </summary>
		public uint M41;

		/// <summary>
		///	The value at row 4, column 2 of the matrix.
		/// </summary>
		public uint M42;

		/// <summary>
		///	The value at row 4, column 3 of the matrix.
		/// </summary>
		public uint M43;

		/// <summary>
		///	The value at row 4, column 4 of the matrix.
		/// </summary>
		public uint M44;

		/// <summary>
		/// Creates a new instance of <see cref="UInt4x4"/>.
		/// </summary>
		public UInt4x4(uint m11, uint m21, uint m31, uint m41, uint m12, uint m22, uint m32, uint m42, uint m13, uint m23, uint m33, uint m43, uint m14, uint m24, uint m34, uint m44)
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
			M41 = m41;
			M42 = m42;
			M43 = m43;
			M44 = m44;
		}

		/// <summary>
		/// Gets or sets a component at the specified index for the current <see cref="UInt4x4"/> .
		/// </summary>
		public uint[] this[int index]
		{
			get => null;
			set {}
		}
	}
}
