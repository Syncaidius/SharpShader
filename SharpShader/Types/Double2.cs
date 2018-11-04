using System.Runtime.InteropServices;

namespace SharpShader
{
	[StructLayout(LayoutKind.Sequential)]
	public struct Double2
	{
        /// <summary>
        /// The X component.
        /// </summary>
		public double X;

        /// <summary>
        /// The Y component.
        /// </summary>
		public double Y;

        /// <summary>
        /// Creates a new instance of <see cref="Double2"/>.
        /// </summary>
		public Double2(double x, double y)
		{
			X = x;
			Y = y;
		}

		public Double2 XX => new Double2(X,X);

		public Double2 XY => new Double2(X,Y);

		public Double2 YX => new Double2(Y,X);

		public Double2 YY => new Double2(Y,Y);

		public Double3 XXX => new Double3(X,X,X);

		public Double3 XXY => new Double3(X,X,Y);

		public Double3 XYX => new Double3(X,Y,X);

		public Double3 XYY => new Double3(X,Y,Y);

		public Double3 YXX => new Double3(Y,X,X);

		public Double3 YXY => new Double3(Y,X,Y);

		public Double3 YYX => new Double3(Y,Y,X);

		public Double3 YYY => new Double3(Y,Y,Y);

		public Double4 XXXX => new Double4(X,X,X,X);

		public Double4 XXXY => new Double4(X,X,X,Y);

		public Double4 XXYX => new Double4(X,X,Y,X);

		public Double4 XXYY => new Double4(X,X,Y,Y);

		public Double4 XYXX => new Double4(X,Y,X,X);

		public Double4 XYXY => new Double4(X,Y,X,Y);

		public Double4 XYYX => new Double4(X,Y,Y,X);

		public Double4 XYYY => new Double4(X,Y,Y,Y);

		public Double4 YXXX => new Double4(Y,X,X,X);

		public Double4 YXXY => new Double4(Y,X,X,Y);

		public Double4 YXYX => new Double4(Y,X,Y,X);

		public Double4 YXYY => new Double4(Y,X,Y,Y);

		public Double4 YYXX => new Double4(Y,Y,X,X);

		public Double4 YYXY => new Double4(Y,Y,X,Y);

		public Double4 YYYX => new Double4(Y,Y,Y,X);

		public Double4 YYYY => new Double4(Y,Y,Y,Y);

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

		public Double2 RR => new Double2(X,X);

		public Double2 RG => new Double2(X,Y);

		public Double2 GR => new Double2(Y,X);

		public Double2 GG => new Double2(Y,Y);

		public Double3 RRR => new Double3(X,X,X);

		public Double3 RRG => new Double3(X,X,Y);

		public Double3 RGR => new Double3(X,Y,X);

		public Double3 RGG => new Double3(X,Y,Y);

		public Double3 GRR => new Double3(Y,X,X);

		public Double3 GRG => new Double3(Y,X,Y);

		public Double3 GGR => new Double3(Y,Y,X);

		public Double3 GGG => new Double3(Y,Y,Y);

		public Double4 RRRR => new Double4(X,X,X,X);

		public Double4 RRRG => new Double4(X,X,X,Y);

		public Double4 RRGR => new Double4(X,X,Y,X);

		public Double4 RRGG => new Double4(X,X,Y,Y);

		public Double4 RGRR => new Double4(X,Y,X,X);

		public Double4 RGRG => new Double4(X,Y,X,Y);

		public Double4 RGGR => new Double4(X,Y,Y,X);

		public Double4 RGGG => new Double4(X,Y,Y,Y);

		public Double4 GRRR => new Double4(Y,X,X,X);

		public Double4 GRRG => new Double4(Y,X,X,Y);

		public Double4 GRGR => new Double4(Y,X,Y,X);

		public Double4 GRGG => new Double4(Y,X,Y,Y);

		public Double4 GGRR => new Double4(Y,Y,X,X);

		public Double4 GGRG => new Double4(Y,Y,X,Y);

		public Double4 GGGR => new Double4(Y,Y,Y,X);

		public Double4 GGGG => new Double4(Y,Y,Y,Y);

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
