

using System.Runtime.InteropServices;

namespace SharpShader
{
	public struct Vector2
	{
		public float X;

		public float Y;

		public Vector2(float x, float y)
		{
			X = x;
			Y = y;
		}

		public Vector2 XX
		{
			get => new Vector2(X,X);
		}

		public Vector2 XY
		{
			get => new Vector2(X,Y);
		}

		public Vector2 YX
		{
			get => new Vector2(Y,X);
		}

		public Vector2 YY
		{
			get => new Vector2(Y,Y);
		}

		public Vector3 XXX
		{
			get => new Vector3(X,X,X);
		}

		public Vector3 XXY
		{
			get => new Vector3(X,X,Y);
		}

		public Vector3 XYX
		{
			get => new Vector3(X,Y,X);
		}

		public Vector3 XYY
		{
			get => new Vector3(X,Y,Y);
		}

		public Vector3 YXX
		{
			get => new Vector3(Y,X,X);
		}

		public Vector3 YXY
		{
			get => new Vector3(Y,X,Y);
		}

		public Vector3 YYX
		{
			get => new Vector3(Y,Y,X);
		}

		public Vector3 YYY
		{
			get => new Vector3(Y,Y,Y);
		}

		public Vector4 XXXX
		{
			get => new Vector4(X,X,X,X);
		}

		public Vector4 XXXY
		{
			get => new Vector4(X,X,X,Y);
		}

		public Vector4 XXYX
		{
			get => new Vector4(X,X,Y,X);
		}

		public Vector4 XXYY
		{
			get => new Vector4(X,X,Y,Y);
		}

		public Vector4 XYXX
		{
			get => new Vector4(X,Y,X,X);
		}

		public Vector4 XYXY
		{
			get => new Vector4(X,Y,X,Y);
		}

		public Vector4 XYYX
		{
			get => new Vector4(X,Y,Y,X);
		}

		public Vector4 XYYY
		{
			get => new Vector4(X,Y,Y,Y);
		}

		public Vector4 YXXX
		{
			get => new Vector4(Y,X,X,X);
		}

		public Vector4 YXXY
		{
			get => new Vector4(Y,X,X,Y);
		}

		public Vector4 YXYX
		{
			get => new Vector4(Y,X,Y,X);
		}

		public Vector4 YXYY
		{
			get => new Vector4(Y,X,Y,Y);
		}

		public Vector4 YYXX
		{
			get => new Vector4(Y,Y,X,X);
		}

		public Vector4 YYXY
		{
			get => new Vector4(Y,Y,X,Y);
		}

		public Vector4 YYYX
		{
			get => new Vector4(Y,Y,Y,X);
		}

		public Vector4 YYYY
		{
			get => new Vector4(Y,Y,Y,Y);
		}

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
