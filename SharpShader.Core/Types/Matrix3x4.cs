using System;
using System.Runtime.InteropServices;

namespace SharpShader
{
	/// <summary>
	///	A 3 row, 4 column matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	[Serializable]
	public struct Matrix3x4 : IMatrix<float>, IIntrinsicValue<float>
	{
		/// <summary>
		///	The number of rows in a <see cref="Matrix3x4"/>.
		/// </summary>
		public const int ROW_COUNT = 3;

		/// <summary>
		///	The number of columns in a <see cref="Matrix3x4"/>.
		/// </summary>
		public const int COLUMN_COUNT = 4;

		/// <summary>
		///	The size of a <see cref="Matrix3x4"/>, in bytes.
		/// </summary>
		public const int ELEMENT_SIZE = sizeof(float);

		/// <summary>
		///	The size of a single element within a <see cref="Matrix3x4"/>, in bytes.
		/// </summary>
		public const int SIZE_OF = (ROW_COUNT * COLUMN_COUNT) * ELEMENT_SIZE;

		/// <summary>
		///	Gets the <see cref="Type"/> of each element in a <see cref="Matrix3x4"/>.
		/// </summary>
		public static readonly Type ElementType = typeof(float);

		/// <summary>
		///	The value at row 1, column 1 of the matrix.
		/// </summary>
		public float M11;

		/// <summary>
		///	The value at row 1, column 2 of the matrix.
		/// </summary>
		public float M12;

		/// <summary>
		///	The value at row 1, column 3 of the matrix.
		/// </summary>
		public float M13;

		/// <summary>
		///	The value at row 1, column 4 of the matrix.
		/// </summary>
		public float M14;

		/// <summary>
		///	The value at row 2, column 1 of the matrix.
		/// </summary>
		public float M21;

		/// <summary>
		///	The value at row 2, column 2 of the matrix.
		/// </summary>
		public float M22;

		/// <summary>
		///	The value at row 2, column 3 of the matrix.
		/// </summary>
		public float M23;

		/// <summary>
		///	The value at row 2, column 4 of the matrix.
		/// </summary>
		public float M24;

		/// <summary>
		///	The value at row 3, column 1 of the matrix.
		/// </summary>
		public float M31;

		/// <summary>
		///	The value at row 3, column 2 of the matrix.
		/// </summary>
		public float M32;

		/// <summary>
		///	The value at row 3, column 3 of the matrix.
		/// </summary>
		public float M33;

		/// <summary>
		///	The value at row 3, column 4 of the matrix.
		/// </summary>
		public float M34;

		/// <summary>
		/// Creates a new instance of <see cref="Matrix3x4"/>.
		/// </summary>
		public Matrix3x4(float m11, float m21, float m31, float m12, float m22, float m32, float m13, float m23, float m33, float m14, float m24, float m34)
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
		/// Gets or sets a component at the specified index for the current <see cref="Matrix3x4"/> .
		/// </summary>
		public float[] this[int index]
		{
			get => null;
			set {}
		}
	}
}
