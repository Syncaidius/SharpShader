

using System.Runtime.InteropServices;

namespace SharpShader
{
	[StructLayout(LayoutKind.Sequential)]
	public struct Vector2
	{
        /// <summary>
        /// The X component.
        /// </summary>
		public float X;

        /// <summary>
        /// The Y component.
        /// </summary>
		public float Y;

        /// <summary>
        /// Creates a new instance of <see cref="Vector2"/>.
        /// </summary>
		public Vector2(float x, float y)
		{
			X = x;
			Y = y;
		}

		public Vector2 XX => new Vector2(X,X);

		public Vector2 XY => new Vector2(X,Y);

		public Vector2 YX => new Vector2(Y,X);

		public Vector2 YY => new Vector2(Y,Y);

		public Vector3 XXX => new Vector3(X,X,X);

		public Vector3 XXY => new Vector3(X,X,Y);

		public Vector3 XYX => new Vector3(X,Y,X);

		public Vector3 XYY => new Vector3(X,Y,Y);

		public Vector3 YXX => new Vector3(Y,X,X);

		public Vector3 YXY => new Vector3(Y,X,Y);

		public Vector3 YYX => new Vector3(Y,Y,X);

		public Vector3 YYY => new Vector3(Y,Y,Y);

		public Vector4 XXXX => new Vector4(X,X,X,X);

		public Vector4 XXXY => new Vector4(X,X,X,Y);

		public Vector4 XXYX => new Vector4(X,X,Y,X);

		public Vector4 XXYY => new Vector4(X,X,Y,Y);

		public Vector4 XYXX => new Vector4(X,Y,X,X);

		public Vector4 XYXY => new Vector4(X,Y,X,Y);

		public Vector4 XYYX => new Vector4(X,Y,Y,X);

		public Vector4 XYYY => new Vector4(X,Y,Y,Y);

		public Vector4 YXXX => new Vector4(Y,X,X,X);

		public Vector4 YXXY => new Vector4(Y,X,X,Y);

		public Vector4 YXYX => new Vector4(Y,X,Y,X);

		public Vector4 YXYY => new Vector4(Y,X,Y,Y);

		public Vector4 YYXX => new Vector4(Y,Y,X,X);

		public Vector4 YYXY => new Vector4(Y,Y,X,Y);

		public Vector4 YYYX => new Vector4(Y,Y,Y,X);

		public Vector4 YYYY => new Vector4(Y,Y,Y,Y);

		public float R
		{
			get => X;
			set => X = value;
		}

		public float G
		{
			get => Y;
			set => Y = value;
		}

		public Vector2 RR => new Vector2(X,X);

		public Vector2 RG => new Vector2(X,Y);

		public Vector2 GR => new Vector2(Y,X);

		public Vector2 GG => new Vector2(Y,Y);

		public Vector3 RRR => new Vector3(X,X,X);

		public Vector3 RRG => new Vector3(X,X,Y);

		public Vector3 RGR => new Vector3(X,Y,X);

		public Vector3 RGG => new Vector3(X,Y,Y);

		public Vector3 GRR => new Vector3(Y,X,X);

		public Vector3 GRG => new Vector3(Y,X,Y);

		public Vector3 GGR => new Vector3(Y,Y,X);

		public Vector3 GGG => new Vector3(Y,Y,Y);

		public Vector4 RRRR => new Vector4(X,X,X,X);

		public Vector4 RRRG => new Vector4(X,X,X,Y);

		public Vector4 RRGR => new Vector4(X,X,Y,X);

		public Vector4 RRGG => new Vector4(X,X,Y,Y);

		public Vector4 RGRR => new Vector4(X,Y,X,X);

		public Vector4 RGRG => new Vector4(X,Y,X,Y);

		public Vector4 RGGR => new Vector4(X,Y,Y,X);

		public Vector4 RGGG => new Vector4(X,Y,Y,Y);

		public Vector4 GRRR => new Vector4(Y,X,X,X);

		public Vector4 GRRG => new Vector4(Y,X,X,Y);

		public Vector4 GRGR => new Vector4(Y,X,Y,X);

		public Vector4 GRGG => new Vector4(Y,X,Y,Y);

		public Vector4 GGRR => new Vector4(Y,Y,X,X);

		public Vector4 GGRG => new Vector4(Y,Y,X,Y);

		public Vector4 GGGR => new Vector4(Y,Y,Y,X);

		public Vector4 GGGG => new Vector4(Y,Y,Y,Y);

		public static Vector2 operator +(Vector2 a, Vector2 b)
		{
			return new Vector2()
			{
				X = a.X + b.X,
				Y = a.Y + b.Y,
			};
		}

		public static Vector2 operator -(Vector2 a, Vector2 b)
		{
			return new Vector2()
			{
				X = a.X - b.X,
				Y = a.Y - b.Y,
			};
		}

		public static Vector2 operator *(Vector2 a, Vector2 b)
		{
			return new Vector2()
			{
				X = a.X * b.X,
				Y = a.Y * b.Y,
			};
		}

		public static Vector2 operator /(Vector2 a, Vector2 b)
		{
			return new Vector2()
			{
				X = a.X / b.X,
				Y = a.Y / b.Y,
			};
		}

	}
}
