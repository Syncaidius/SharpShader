using System.Runtime.InteropServices;

namespace SharpShader
{
	[StructLayout(LayoutKind.Sequential)]
	public struct Double3
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
        /// The Z component.
        /// </summary>
		public double Z;

        /// <summary>
        /// Creates a new instance of <see cref="Double3"/>.
        /// </summary>
		public Double3(double x, double y, double z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		public Double2 XX => new Double2(X,X);

		public Double2 XY => new Double2(X,Y);

		public Double2 XZ => new Double2(X,Z);

		public Double2 YX => new Double2(Y,X);

		public Double2 YY => new Double2(Y,Y);

		public Double2 YZ => new Double2(Y,Z);

		public Double2 ZX => new Double2(Z,X);

		public Double2 ZY => new Double2(Z,Y);

		public Double2 ZZ => new Double2(Z,Z);

		public Double3 XXX => new Double3(X,X,X);

		public Double3 XXY => new Double3(X,X,Y);

		public Double3 XXZ => new Double3(X,X,Z);

		public Double3 XYX => new Double3(X,Y,X);

		public Double3 XYY => new Double3(X,Y,Y);

		public Double3 XYZ => new Double3(X,Y,Z);

		public Double3 XZX => new Double3(X,Z,X);

		public Double3 XZY => new Double3(X,Z,Y);

		public Double3 XZZ => new Double3(X,Z,Z);

		public Double3 YXX => new Double3(Y,X,X);

		public Double3 YXY => new Double3(Y,X,Y);

		public Double3 YXZ => new Double3(Y,X,Z);

		public Double3 YYX => new Double3(Y,Y,X);

		public Double3 YYY => new Double3(Y,Y,Y);

		public Double3 YYZ => new Double3(Y,Y,Z);

		public Double3 YZX => new Double3(Y,Z,X);

		public Double3 YZY => new Double3(Y,Z,Y);

		public Double3 YZZ => new Double3(Y,Z,Z);

		public Double3 ZXX => new Double3(Z,X,X);

		public Double3 ZXY => new Double3(Z,X,Y);

		public Double3 ZXZ => new Double3(Z,X,Z);

		public Double3 ZYX => new Double3(Z,Y,X);

		public Double3 ZYY => new Double3(Z,Y,Y);

		public Double3 ZYZ => new Double3(Z,Y,Z);

		public Double3 ZZX => new Double3(Z,Z,X);

		public Double3 ZZY => new Double3(Z,Z,Y);

		public Double3 ZZZ => new Double3(Z,Z,Z);

		public Double4 XXXX => new Double4(X,X,X,X);

		public Double4 XXXY => new Double4(X,X,X,Y);

		public Double4 XXXZ => new Double4(X,X,X,Z);

		public Double4 XXYX => new Double4(X,X,Y,X);

		public Double4 XXYY => new Double4(X,X,Y,Y);

		public Double4 XXYZ => new Double4(X,X,Y,Z);

		public Double4 XXZX => new Double4(X,X,Z,X);

		public Double4 XXZY => new Double4(X,X,Z,Y);

		public Double4 XXZZ => new Double4(X,X,Z,Z);

		public Double4 XYXX => new Double4(X,Y,X,X);

		public Double4 XYXY => new Double4(X,Y,X,Y);

		public Double4 XYXZ => new Double4(X,Y,X,Z);

		public Double4 XYYX => new Double4(X,Y,Y,X);

		public Double4 XYYY => new Double4(X,Y,Y,Y);

		public Double4 XYYZ => new Double4(X,Y,Y,Z);

		public Double4 XYZX => new Double4(X,Y,Z,X);

		public Double4 XYZY => new Double4(X,Y,Z,Y);

		public Double4 XYZZ => new Double4(X,Y,Z,Z);

		public Double4 XZXX => new Double4(X,Z,X,X);

		public Double4 XZXY => new Double4(X,Z,X,Y);

		public Double4 XZXZ => new Double4(X,Z,X,Z);

		public Double4 XZYX => new Double4(X,Z,Y,X);

		public Double4 XZYY => new Double4(X,Z,Y,Y);

		public Double4 XZYZ => new Double4(X,Z,Y,Z);

		public Double4 XZZX => new Double4(X,Z,Z,X);

		public Double4 XZZY => new Double4(X,Z,Z,Y);

		public Double4 XZZZ => new Double4(X,Z,Z,Z);

		public Double4 YXXX => new Double4(Y,X,X,X);

		public Double4 YXXY => new Double4(Y,X,X,Y);

		public Double4 YXXZ => new Double4(Y,X,X,Z);

		public Double4 YXYX => new Double4(Y,X,Y,X);

		public Double4 YXYY => new Double4(Y,X,Y,Y);

		public Double4 YXYZ => new Double4(Y,X,Y,Z);

		public Double4 YXZX => new Double4(Y,X,Z,X);

		public Double4 YXZY => new Double4(Y,X,Z,Y);

		public Double4 YXZZ => new Double4(Y,X,Z,Z);

		public Double4 YYXX => new Double4(Y,Y,X,X);

		public Double4 YYXY => new Double4(Y,Y,X,Y);

		public Double4 YYXZ => new Double4(Y,Y,X,Z);

		public Double4 YYYX => new Double4(Y,Y,Y,X);

		public Double4 YYYY => new Double4(Y,Y,Y,Y);

		public Double4 YYYZ => new Double4(Y,Y,Y,Z);

		public Double4 YYZX => new Double4(Y,Y,Z,X);

		public Double4 YYZY => new Double4(Y,Y,Z,Y);

		public Double4 YYZZ => new Double4(Y,Y,Z,Z);

		public Double4 YZXX => new Double4(Y,Z,X,X);

		public Double4 YZXY => new Double4(Y,Z,X,Y);

		public Double4 YZXZ => new Double4(Y,Z,X,Z);

		public Double4 YZYX => new Double4(Y,Z,Y,X);

		public Double4 YZYY => new Double4(Y,Z,Y,Y);

		public Double4 YZYZ => new Double4(Y,Z,Y,Z);

		public Double4 YZZX => new Double4(Y,Z,Z,X);

		public Double4 YZZY => new Double4(Y,Z,Z,Y);

		public Double4 YZZZ => new Double4(Y,Z,Z,Z);

		public Double4 ZXXX => new Double4(Z,X,X,X);

		public Double4 ZXXY => new Double4(Z,X,X,Y);

		public Double4 ZXXZ => new Double4(Z,X,X,Z);

		public Double4 ZXYX => new Double4(Z,X,Y,X);

		public Double4 ZXYY => new Double4(Z,X,Y,Y);

		public Double4 ZXYZ => new Double4(Z,X,Y,Z);

		public Double4 ZXZX => new Double4(Z,X,Z,X);

		public Double4 ZXZY => new Double4(Z,X,Z,Y);

		public Double4 ZXZZ => new Double4(Z,X,Z,Z);

		public Double4 ZYXX => new Double4(Z,Y,X,X);

		public Double4 ZYXY => new Double4(Z,Y,X,Y);

		public Double4 ZYXZ => new Double4(Z,Y,X,Z);

		public Double4 ZYYX => new Double4(Z,Y,Y,X);

		public Double4 ZYYY => new Double4(Z,Y,Y,Y);

		public Double4 ZYYZ => new Double4(Z,Y,Y,Z);

		public Double4 ZYZX => new Double4(Z,Y,Z,X);

		public Double4 ZYZY => new Double4(Z,Y,Z,Y);

		public Double4 ZYZZ => new Double4(Z,Y,Z,Z);

		public Double4 ZZXX => new Double4(Z,Z,X,X);

		public Double4 ZZXY => new Double4(Z,Z,X,Y);

		public Double4 ZZXZ => new Double4(Z,Z,X,Z);

		public Double4 ZZYX => new Double4(Z,Z,Y,X);

		public Double4 ZZYY => new Double4(Z,Z,Y,Y);

		public Double4 ZZYZ => new Double4(Z,Z,Y,Z);

		public Double4 ZZZX => new Double4(Z,Z,Z,X);

		public Double4 ZZZY => new Double4(Z,Z,Z,Y);

		public Double4 ZZZZ => new Double4(Z,Z,Z,Z);

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

		public double B
		{
			get => Z;
			set => Z = value;
		}

		public Double2 RR => new Double2(X,X);

		public Double2 RG => new Double2(X,Y);

		public Double2 RB => new Double2(X,Z);

		public Double2 GR => new Double2(Y,X);

		public Double2 GG => new Double2(Y,Y);

		public Double2 GB => new Double2(Y,Z);

		public Double2 BR => new Double2(Z,X);

		public Double2 BG => new Double2(Z,Y);

		public Double2 BB => new Double2(Z,Z);

		public Double3 RRR => new Double3(X,X,X);

		public Double3 RRG => new Double3(X,X,Y);

		public Double3 RRB => new Double3(X,X,Z);

		public Double3 RGR => new Double3(X,Y,X);

		public Double3 RGG => new Double3(X,Y,Y);

		public Double3 RGB => new Double3(X,Y,Z);

		public Double3 RBR => new Double3(X,Z,X);

		public Double3 RBG => new Double3(X,Z,Y);

		public Double3 RBB => new Double3(X,Z,Z);

		public Double3 GRR => new Double3(Y,X,X);

		public Double3 GRG => new Double3(Y,X,Y);

		public Double3 GRB => new Double3(Y,X,Z);

		public Double3 GGR => new Double3(Y,Y,X);

		public Double3 GGG => new Double3(Y,Y,Y);

		public Double3 GGB => new Double3(Y,Y,Z);

		public Double3 GBR => new Double3(Y,Z,X);

		public Double3 GBG => new Double3(Y,Z,Y);

		public Double3 GBB => new Double3(Y,Z,Z);

		public Double3 BRR => new Double3(Z,X,X);

		public Double3 BRG => new Double3(Z,X,Y);

		public Double3 BRB => new Double3(Z,X,Z);

		public Double3 BGR => new Double3(Z,Y,X);

		public Double3 BGG => new Double3(Z,Y,Y);

		public Double3 BGB => new Double3(Z,Y,Z);

		public Double3 BBR => new Double3(Z,Z,X);

		public Double3 BBG => new Double3(Z,Z,Y);

		public Double3 BBB => new Double3(Z,Z,Z);

		public Double4 RRRR => new Double4(X,X,X,X);

		public Double4 RRRG => new Double4(X,X,X,Y);

		public Double4 RRRB => new Double4(X,X,X,Z);

		public Double4 RRGR => new Double4(X,X,Y,X);

		public Double4 RRGG => new Double4(X,X,Y,Y);

		public Double4 RRGB => new Double4(X,X,Y,Z);

		public Double4 RRBR => new Double4(X,X,Z,X);

		public Double4 RRBG => new Double4(X,X,Z,Y);

		public Double4 RRBB => new Double4(X,X,Z,Z);

		public Double4 RGRR => new Double4(X,Y,X,X);

		public Double4 RGRG => new Double4(X,Y,X,Y);

		public Double4 RGRB => new Double4(X,Y,X,Z);

		public Double4 RGGR => new Double4(X,Y,Y,X);

		public Double4 RGGG => new Double4(X,Y,Y,Y);

		public Double4 RGGB => new Double4(X,Y,Y,Z);

		public Double4 RGBR => new Double4(X,Y,Z,X);

		public Double4 RGBG => new Double4(X,Y,Z,Y);

		public Double4 RGBB => new Double4(X,Y,Z,Z);

		public Double4 RBRR => new Double4(X,Z,X,X);

		public Double4 RBRG => new Double4(X,Z,X,Y);

		public Double4 RBRB => new Double4(X,Z,X,Z);

		public Double4 RBGR => new Double4(X,Z,Y,X);

		public Double4 RBGG => new Double4(X,Z,Y,Y);

		public Double4 RBGB => new Double4(X,Z,Y,Z);

		public Double4 RBBR => new Double4(X,Z,Z,X);

		public Double4 RBBG => new Double4(X,Z,Z,Y);

		public Double4 RBBB => new Double4(X,Z,Z,Z);

		public Double4 GRRR => new Double4(Y,X,X,X);

		public Double4 GRRG => new Double4(Y,X,X,Y);

		public Double4 GRRB => new Double4(Y,X,X,Z);

		public Double4 GRGR => new Double4(Y,X,Y,X);

		public Double4 GRGG => new Double4(Y,X,Y,Y);

		public Double4 GRGB => new Double4(Y,X,Y,Z);

		public Double4 GRBR => new Double4(Y,X,Z,X);

		public Double4 GRBG => new Double4(Y,X,Z,Y);

		public Double4 GRBB => new Double4(Y,X,Z,Z);

		public Double4 GGRR => new Double4(Y,Y,X,X);

		public Double4 GGRG => new Double4(Y,Y,X,Y);

		public Double4 GGRB => new Double4(Y,Y,X,Z);

		public Double4 GGGR => new Double4(Y,Y,Y,X);

		public Double4 GGGG => new Double4(Y,Y,Y,Y);

		public Double4 GGGB => new Double4(Y,Y,Y,Z);

		public Double4 GGBR => new Double4(Y,Y,Z,X);

		public Double4 GGBG => new Double4(Y,Y,Z,Y);

		public Double4 GGBB => new Double4(Y,Y,Z,Z);

		public Double4 GBRR => new Double4(Y,Z,X,X);

		public Double4 GBRG => new Double4(Y,Z,X,Y);

		public Double4 GBRB => new Double4(Y,Z,X,Z);

		public Double4 GBGR => new Double4(Y,Z,Y,X);

		public Double4 GBGG => new Double4(Y,Z,Y,Y);

		public Double4 GBGB => new Double4(Y,Z,Y,Z);

		public Double4 GBBR => new Double4(Y,Z,Z,X);

		public Double4 GBBG => new Double4(Y,Z,Z,Y);

		public Double4 GBBB => new Double4(Y,Z,Z,Z);

		public Double4 BRRR => new Double4(Z,X,X,X);

		public Double4 BRRG => new Double4(Z,X,X,Y);

		public Double4 BRRB => new Double4(Z,X,X,Z);

		public Double4 BRGR => new Double4(Z,X,Y,X);

		public Double4 BRGG => new Double4(Z,X,Y,Y);

		public Double4 BRGB => new Double4(Z,X,Y,Z);

		public Double4 BRBR => new Double4(Z,X,Z,X);

		public Double4 BRBG => new Double4(Z,X,Z,Y);

		public Double4 BRBB => new Double4(Z,X,Z,Z);

		public Double4 BGRR => new Double4(Z,Y,X,X);

		public Double4 BGRG => new Double4(Z,Y,X,Y);

		public Double4 BGRB => new Double4(Z,Y,X,Z);

		public Double4 BGGR => new Double4(Z,Y,Y,X);

		public Double4 BGGG => new Double4(Z,Y,Y,Y);

		public Double4 BGGB => new Double4(Z,Y,Y,Z);

		public Double4 BGBR => new Double4(Z,Y,Z,X);

		public Double4 BGBG => new Double4(Z,Y,Z,Y);

		public Double4 BGBB => new Double4(Z,Y,Z,Z);

		public Double4 BBRR => new Double4(Z,Z,X,X);

		public Double4 BBRG => new Double4(Z,Z,X,Y);

		public Double4 BBRB => new Double4(Z,Z,X,Z);

		public Double4 BBGR => new Double4(Z,Z,Y,X);

		public Double4 BBGG => new Double4(Z,Z,Y,Y);

		public Double4 BBGB => new Double4(Z,Z,Y,Z);

		public Double4 BBBR => new Double4(Z,Z,Z,X);

		public Double4 BBBG => new Double4(Z,Z,Z,Y);

		public Double4 BBBB => new Double4(Z,Z,Z,Z);

		public static Double3 operator +(Double3 a, Double3 b)
		{
			return new Double3()
			{
				X = a.X + b.X,
				Y = a.Y + b.Y,
				Z = a.Z + b.Z,
			};
		}

		public static Double3 operator -(Double3 a, Double3 b)
		{
			return new Double3()
			{
				X = a.X - b.X,
				Y = a.Y - b.Y,
				Z = a.Z - b.Z,
			};
		}

		public static Double3 operator *(Double3 a, Double3 b)
		{
			return new Double3()
			{
				X = a.X * b.X,
				Y = a.Y * b.Y,
				Z = a.Z * b.Z,
			};
		}

		public static Double3 operator /(Double3 a, Double3 b)
		{
			return new Double3()
			{
				X = a.X / b.X,
				Y = a.Y / b.Y,
				Z = a.Z / b.Z,
			};
		}

	}
}
