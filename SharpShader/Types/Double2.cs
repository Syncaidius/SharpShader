using System.Runtime.InteropServices;

namespace SharpShader
{
	public struct Double2
	{
		public double X;

		public double Y;

		public Double2(double x, double y)
		{
			X = x;
			Y = y;
		}

		public Double2 XX
		{
			get => new Double2(X,X);
		}

		public Double2 XY
		{
			get => new Double2(X,Y);
		}

		public Double2 YX
		{
			get => new Double2(Y,X);
		}

		public Double2 YY
		{
			get => new Double2(Y,Y);
		}

		public Double3 XXX
		{
			get => new Double3(X,X,X);
		}

		public Double3 XXY
		{
			get => new Double3(X,X,Y);
		}

		public Double3 XYX
		{
			get => new Double3(X,Y,X);
		}

		public Double3 XYY
		{
			get => new Double3(X,Y,Y);
		}

		public Double3 YXX
		{
			get => new Double3(Y,X,X);
		}

		public Double3 YXY
		{
			get => new Double3(Y,X,Y);
		}

		public Double3 YYX
		{
			get => new Double3(Y,Y,X);
		}

		public Double3 YYY
		{
			get => new Double3(Y,Y,Y);
		}

		public Double4 XXXX
		{
			get => new Double4(X,X,X,X);
		}

		public Double4 XXXY
		{
			get => new Double4(X,X,X,Y);
		}

		public Double4 XXYX
		{
			get => new Double4(X,X,Y,X);
		}

		public Double4 XXYY
		{
			get => new Double4(X,X,Y,Y);
		}

		public Double4 XYXX
		{
			get => new Double4(X,Y,X,X);
		}

		public Double4 XYXY
		{
			get => new Double4(X,Y,X,Y);
		}

		public Double4 XYYX
		{
			get => new Double4(X,Y,Y,X);
		}

		public Double4 XYYY
		{
			get => new Double4(X,Y,Y,Y);
		}

		public Double4 YXXX
		{
			get => new Double4(Y,X,X,X);
		}

		public Double4 YXXY
		{
			get => new Double4(Y,X,X,Y);
		}

		public Double4 YXYX
		{
			get => new Double4(Y,X,Y,X);
		}

		public Double4 YXYY
		{
			get => new Double4(Y,X,Y,Y);
		}

		public Double4 YYXX
		{
			get => new Double4(Y,Y,X,X);
		}

		public Double4 YYXY
		{
			get => new Double4(Y,Y,X,Y);
		}

		public Double4 YYYX
		{
			get => new Double4(Y,Y,Y,X);
		}

		public Double4 YYYY
		{
			get => new Double4(Y,Y,Y,Y);
		}

		public double R
		{
			get => X;
			set => X = value;
		}

		public double G
		{
			get => Y;
			set => Y = value;
		}

		public static Double2 operator +(Double2 a, Double2 b)
		{
			return new Double2()
			{
				X = a.X + b.X,
				Y = a.Y + b.Y,
			};
		}

		public static Double2 operator -(Double2 a, Double2 b)
		{
			return new Double2()
			{
				X = a.X - b.X,
				Y = a.Y - b.Y,
			};
		}

		public static Double2 operator *(Double2 a, Double2 b)
		{
			return new Double2()
			{
				X = a.X * b.X,
				Y = a.Y * b.Y,
			};
		}

		public static Double2 operator /(Double2 a, Double2 b)
		{
			return new Double2()
			{
				X = a.X / b.X,
				Y = a.Y / b.Y,
			};
		}

	}
}
