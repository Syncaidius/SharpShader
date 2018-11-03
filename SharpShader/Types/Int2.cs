using System.Runtime.InteropServices;

namespace SharpShader
{
	public struct Int2
	{
		public int X;

		public int Y;

		public Int2(int x, int y)
		{
			X = x;
			Y = y;
		}

		public Int2 XX
		{
			get => new Int2(X,X);
		}

		public Int2 XY
		{
			get => new Int2(X,Y);
		}

		public Int2 YX
		{
			get => new Int2(Y,X);
		}

		public Int2 YY
		{
			get => new Int2(Y,Y);
		}

		public Int3 XXX
		{
			get => new Int3(X,X,X);
		}

		public Int3 XXY
		{
			get => new Int3(X,X,Y);
		}

		public Int3 XYX
		{
			get => new Int3(X,Y,X);
		}

		public Int3 XYY
		{
			get => new Int3(X,Y,Y);
		}

		public Int3 YXX
		{
			get => new Int3(Y,X,X);
		}

		public Int3 YXY
		{
			get => new Int3(Y,X,Y);
		}

		public Int3 YYX
		{
			get => new Int3(Y,Y,X);
		}

		public Int3 YYY
		{
			get => new Int3(Y,Y,Y);
		}

		public Int4 XXXX
		{
			get => new Int4(X,X,X,X);
		}

		public Int4 XXXY
		{
			get => new Int4(X,X,X,Y);
		}

		public Int4 XXYX
		{
			get => new Int4(X,X,Y,X);
		}

		public Int4 XXYY
		{
			get => new Int4(X,X,Y,Y);
		}

		public Int4 XYXX
		{
			get => new Int4(X,Y,X,X);
		}

		public Int4 XYXY
		{
			get => new Int4(X,Y,X,Y);
		}

		public Int4 XYYX
		{
			get => new Int4(X,Y,Y,X);
		}

		public Int4 XYYY
		{
			get => new Int4(X,Y,Y,Y);
		}

		public Int4 YXXX
		{
			get => new Int4(Y,X,X,X);
		}

		public Int4 YXXY
		{
			get => new Int4(Y,X,X,Y);
		}

		public Int4 YXYX
		{
			get => new Int4(Y,X,Y,X);
		}

		public Int4 YXYY
		{
			get => new Int4(Y,X,Y,Y);
		}

		public Int4 YYXX
		{
			get => new Int4(Y,Y,X,X);
		}

		public Int4 YYXY
		{
			get => new Int4(Y,Y,X,Y);
		}

		public Int4 YYYX
		{
			get => new Int4(Y,Y,Y,X);
		}

		public Int4 YYYY
		{
			get => new Int4(Y,Y,Y,Y);
		}

		public int R
		{
			get => X;
			set => X = value;
		}

		public int G
		{
			get => Y;
			set => Y = value;
		}

		public static Int2 operator +(Int2 a, Int2 b)
		{
			return new Int2()
			{
				X = a.X + b.X,
				Y = a.Y + b.Y,
			};
		}

		public static Int2 operator -(Int2 a, Int2 b)
		{
			return new Int2()
			{
				X = a.X - b.X,
				Y = a.Y - b.Y,
			};
		}

		public static Int2 operator *(Int2 a, Int2 b)
		{
			return new Int2()
			{
				X = a.X * b.X,
				Y = a.Y * b.Y,
			};
		}

		public static Int2 operator /(Int2 a, Int2 b)
		{
			return new Int2()
			{
				X = a.X / b.X,
				Y = a.Y / b.Y,
			};
		}

	}
}
