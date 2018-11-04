using System.Runtime.InteropServices;

namespace SharpShader
{
	[StructLayout(LayoutKind.Sequential)]
	public struct Int2
	{
        /// <summary>
        /// The X component.
        /// </summary>
		public int X;

        /// <summary>
        /// The Y component.
        /// </summary>
		public int Y;

        /// <summary>
        /// Creates a new instance of <see cref="Int2"/>.
        /// </summary>
		public Int2(int x, int y)
		{
			X = x;
			Y = y;
		}

		public Int2 XX => new Int2(X,X);

		public Int2 XY => new Int2(X,Y);

		public Int2 YX => new Int2(Y,X);

		public Int2 YY => new Int2(Y,Y);

		public Int3 XXX => new Int3(X,X,X);

		public Int3 XXY => new Int3(X,X,Y);

		public Int3 XYX => new Int3(X,Y,X);

		public Int3 XYY => new Int3(X,Y,Y);

		public Int3 YXX => new Int3(Y,X,X);

		public Int3 YXY => new Int3(Y,X,Y);

		public Int3 YYX => new Int3(Y,Y,X);

		public Int3 YYY => new Int3(Y,Y,Y);

		public Int4 XXXX => new Int4(X,X,X,X);

		public Int4 XXXY => new Int4(X,X,X,Y);

		public Int4 XXYX => new Int4(X,X,Y,X);

		public Int4 XXYY => new Int4(X,X,Y,Y);

		public Int4 XYXX => new Int4(X,Y,X,X);

		public Int4 XYXY => new Int4(X,Y,X,Y);

		public Int4 XYYX => new Int4(X,Y,Y,X);

		public Int4 XYYY => new Int4(X,Y,Y,Y);

		public Int4 YXXX => new Int4(Y,X,X,X);

		public Int4 YXXY => new Int4(Y,X,X,Y);

		public Int4 YXYX => new Int4(Y,X,Y,X);

		public Int4 YXYY => new Int4(Y,X,Y,Y);

		public Int4 YYXX => new Int4(Y,Y,X,X);

		public Int4 YYXY => new Int4(Y,Y,X,Y);

		public Int4 YYYX => new Int4(Y,Y,Y,X);

		public Int4 YYYY => new Int4(Y,Y,Y,Y);

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

		public Int2 RR => new Int2(X,X);

		public Int2 RG => new Int2(X,Y);

		public Int2 GR => new Int2(Y,X);

		public Int2 GG => new Int2(Y,Y);

		public Int3 RRR => new Int3(X,X,X);

		public Int3 RRG => new Int3(X,X,Y);

		public Int3 RGR => new Int3(X,Y,X);

		public Int3 RGG => new Int3(X,Y,Y);

		public Int3 GRR => new Int3(Y,X,X);

		public Int3 GRG => new Int3(Y,X,Y);

		public Int3 GGR => new Int3(Y,Y,X);

		public Int3 GGG => new Int3(Y,Y,Y);

		public Int4 RRRR => new Int4(X,X,X,X);

		public Int4 RRRG => new Int4(X,X,X,Y);

		public Int4 RRGR => new Int4(X,X,Y,X);

		public Int4 RRGG => new Int4(X,X,Y,Y);

		public Int4 RGRR => new Int4(X,Y,X,X);

		public Int4 RGRG => new Int4(X,Y,X,Y);

		public Int4 RGGR => new Int4(X,Y,Y,X);

		public Int4 RGGG => new Int4(X,Y,Y,Y);

		public Int4 GRRR => new Int4(Y,X,X,X);

		public Int4 GRRG => new Int4(Y,X,X,Y);

		public Int4 GRGR => new Int4(Y,X,Y,X);

		public Int4 GRGG => new Int4(Y,X,Y,Y);

		public Int4 GGRR => new Int4(Y,Y,X,X);

		public Int4 GGRG => new Int4(Y,Y,X,Y);

		public Int4 GGGR => new Int4(Y,Y,Y,X);

		public Int4 GGGG => new Int4(Y,Y,Y,Y);

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
