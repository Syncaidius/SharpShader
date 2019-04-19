using System;
using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 3 row, 3 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	[Serializable]
	public struct Bool3x3 : IMatrix<bool>, UniformDimensions
	{
		/// <summary>
		///	The number of rows in a <see cref="Bool3x3"/>.
		/// </summary>
		public const int ROW_COUNT = 3;

		/// <summary>
		///	The number of columns in a <see cref="Bool3x3"/>.
		/// </summary>
		public const int COLUMN_COUNT = 3;

		/// <summary>
		///	The size of a <see cref="Bool3x3"/>, in bytes.
		/// </summary>
		public const int ELEMENT_SIZE = sizeof(bool);

		/// <summary>
		///	The size of a single element within a <see cref="Bool3x3"/>, in bytes.
		/// </summary>
		public const int SIZE_OF = (ROW_COUNT * COLUMN_COUNT) * ELEMENT_SIZE;

		/// <summary>
		///	Gets the <see cref="Type"/> of each element in a <see cref="Bool3x3"/>.
		/// </summary>
		public static readonly Type ElementType = typeof(bool);

		/// <summary>
		///	The value at row 1, column 1 of the matrix.
		/// </summary>
		public bool M11;

		/// <summary>
		///	The value at row 1, column 2 of the matrix.
		/// </summary>
		public bool M12;

		/// <summary>
		///	The value at row 1, column 3 of the matrix.
		/// </summary>
		public bool M13;

		/// <summary>
		///	The value at row 2, column 1 of the matrix.
		/// </summary>
		public bool M21;

		/// <summary>
		///	The value at row 2, column 2 of the matrix.
		/// </summary>
		public bool M22;

		/// <summary>
		///	The value at row 2, column 3 of the matrix.
		/// </summary>
		public bool M23;

		/// <summary>
		///	The value at row 3, column 1 of the matrix.
		/// </summary>
		public bool M31;

		/// <summary>
		///	The value at row 3, column 2 of the matrix.
		/// </summary>
		public bool M32;

		/// <summary>
		///	The value at row 3, column 3 of the matrix.
		/// </summary>
		public bool M33;

		/// <summary>
		/// Creates a new instance of <see cref="Bool3x3"/>.
		/// </summary>
		public Bool3x3(bool m11, bool m21, bool m31, bool m12, bool m22, bool m32, bool m13, bool m23, bool m33)
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
		}

		/// <summary>
		/// Gets or sets a component at the specified index for the current <see cref="Bool3x3"/> .
		/// </summary>
		public bool[] this[int index]
		{
			get => null;
			set {}
		}
	}
}
