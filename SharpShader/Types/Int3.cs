using System.Runtime.InteropServices;

namespace SharpShader
{
	[StructLayout(LayoutKind.Sequential)]
	public struct Int3
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
        /// The Z component.
        /// </summary>
		public int Z;

        /// <summary>
        /// Creates a new instance of <see cref="Int3"/>.
        /// </summary>
		public Int3(int x, int y, int z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		public Int2 XX => new Int2(X,X);

		public Int2 XY => new Int2(X,Y);

		public Int2 XZ => new Int2(X,Z);

		public Int2 YX => new Int2(Y,X);

		public Int2 YY => new Int2(Y,Y);

		public Int2 YZ => new Int2(Y,Z);

		public Int2 ZX => new Int2(Z,X);

		public Int2 ZY => new Int2(Z,Y);

		public Int2 ZZ => new Int2(Z,Z);

		public Int3 XXX => new Int3(X,X,X);

		public Int3 XXY => new Int3(X,X,Y);

		public Int3 XXZ => new Int3(X,X,Z);

		public Int3 XYX => new Int3(X,Y,X);

		public Int3 XYY => new Int3(X,Y,Y);

		public Int3 XYZ => new Int3(X,Y,Z);

		public Int3 XZX => new Int3(X,Z,X);

		public Int3 XZY => new Int3(X,Z,Y);

		public Int3 XZZ => new Int3(X,Z,Z);

		public Int3 YXX => new Int3(Y,X,X);

		public Int3 YXY => new Int3(Y,X,Y);

		public Int3 YXZ => new Int3(Y,X,Z);

		public Int3 YYX => new Int3(Y,Y,X);

		public Int3 YYY => new Int3(Y,Y,Y);

		public Int3 YYZ => new Int3(Y,Y,Z);

		public Int3 YZX => new Int3(Y,Z,X);

		public Int3 YZY => new Int3(Y,Z,Y);

		public Int3 YZZ => new Int3(Y,Z,Z);

		public Int3 ZXX => new Int3(Z,X,X);

		public Int3 ZXY => new Int3(Z,X,Y);

		public Int3 ZXZ => new Int3(Z,X,Z);

		public Int3 ZYX => new Int3(Z,Y,X);

		public Int3 ZYY => new Int3(Z,Y,Y);

		public Int3 ZYZ => new Int3(Z,Y,Z);

		public Int3 ZZX => new Int3(Z,Z,X);

		public Int3 ZZY => new Int3(Z,Z,Y);

		public Int3 ZZZ => new Int3(Z,Z,Z);

		public Int4 XXXX => new Int4(X,X,X,X);

		public Int4 XXXY => new Int4(X,X,X,Y);

		public Int4 XXXZ => new Int4(X,X,X,Z);

		public Int4 XXYX => new Int4(X,X,Y,X);

		public Int4 XXYY => new Int4(X,X,Y,Y);

		public Int4 XXYZ => new Int4(X,X,Y,Z);

		public Int4 XXZX => new Int4(X,X,Z,X);

		public Int4 XXZY => new Int4(X,X,Z,Y);

		public Int4 XXZZ => new Int4(X,X,Z,Z);

		public Int4 XYXX => new Int4(X,Y,X,X);

		public Int4 XYXY => new Int4(X,Y,X,Y);

		public Int4 XYXZ => new Int4(X,Y,X,Z);

		public Int4 XYYX => new Int4(X,Y,Y,X);

		public Int4 XYYY => new Int4(X,Y,Y,Y);

		public Int4 XYYZ => new Int4(X,Y,Y,Z);

		public Int4 XYZX => new Int4(X,Y,Z,X);

		public Int4 XYZY => new Int4(X,Y,Z,Y);

		public Int4 XYZZ => new Int4(X,Y,Z,Z);

		public Int4 XZXX => new Int4(X,Z,X,X);

		public Int4 XZXY => new Int4(X,Z,X,Y);

		public Int4 XZXZ => new Int4(X,Z,X,Z);

		public Int4 XZYX => new Int4(X,Z,Y,X);

		public Int4 XZYY => new Int4(X,Z,Y,Y);

		public Int4 XZYZ => new Int4(X,Z,Y,Z);

		public Int4 XZZX => new Int4(X,Z,Z,X);

		public Int4 XZZY => new Int4(X,Z,Z,Y);

		public Int4 XZZZ => new Int4(X,Z,Z,Z);

		public Int4 YXXX => new Int4(Y,X,X,X);

		public Int4 YXXY => new Int4(Y,X,X,Y);

		public Int4 YXXZ => new Int4(Y,X,X,Z);

		public Int4 YXYX => new Int4(Y,X,Y,X);

		public Int4 YXYY => new Int4(Y,X,Y,Y);

		public Int4 YXYZ => new Int4(Y,X,Y,Z);

		public Int4 YXZX => new Int4(Y,X,Z,X);

		public Int4 YXZY => new Int4(Y,X,Z,Y);

		public Int4 YXZZ => new Int4(Y,X,Z,Z);

		public Int4 YYXX => new Int4(Y,Y,X,X);

		public Int4 YYXY => new Int4(Y,Y,X,Y);

		public Int4 YYXZ => new Int4(Y,Y,X,Z);

		public Int4 YYYX => new Int4(Y,Y,Y,X);

		public Int4 YYYY => new Int4(Y,Y,Y,Y);

		public Int4 YYYZ => new Int4(Y,Y,Y,Z);

		public Int4 YYZX => new Int4(Y,Y,Z,X);

		public Int4 YYZY => new Int4(Y,Y,Z,Y);

		public Int4 YYZZ => new Int4(Y,Y,Z,Z);

		public Int4 YZXX => new Int4(Y,Z,X,X);

		public Int4 YZXY => new Int4(Y,Z,X,Y);

		public Int4 YZXZ => new Int4(Y,Z,X,Z);

		public Int4 YZYX => new Int4(Y,Z,Y,X);

		public Int4 YZYY => new Int4(Y,Z,Y,Y);

		public Int4 YZYZ => new Int4(Y,Z,Y,Z);

		public Int4 YZZX => new Int4(Y,Z,Z,X);

		public Int4 YZZY => new Int4(Y,Z,Z,Y);

		public Int4 YZZZ => new Int4(Y,Z,Z,Z);

		public Int4 ZXXX => new Int4(Z,X,X,X);

		public Int4 ZXXY => new Int4(Z,X,X,Y);

		public Int4 ZXXZ => new Int4(Z,X,X,Z);

		public Int4 ZXYX => new Int4(Z,X,Y,X);

		public Int4 ZXYY => new Int4(Z,X,Y,Y);

		public Int4 ZXYZ => new Int4(Z,X,Y,Z);

		public Int4 ZXZX => new Int4(Z,X,Z,X);

		public Int4 ZXZY => new Int4(Z,X,Z,Y);

		public Int4 ZXZZ => new Int4(Z,X,Z,Z);

		public Int4 ZYXX => new Int4(Z,Y,X,X);

		public Int4 ZYXY => new Int4(Z,Y,X,Y);

		public Int4 ZYXZ => new Int4(Z,Y,X,Z);

		public Int4 ZYYX => new Int4(Z,Y,Y,X);

		public Int4 ZYYY => new Int4(Z,Y,Y,Y);

		public Int4 ZYYZ => new Int4(Z,Y,Y,Z);

		public Int4 ZYZX => new Int4(Z,Y,Z,X);

		public Int4 ZYZY => new Int4(Z,Y,Z,Y);

		public Int4 ZYZZ => new Int4(Z,Y,Z,Z);

		public Int4 ZZXX => new Int4(Z,Z,X,X);

		public Int4 ZZXY => new Int4(Z,Z,X,Y);

		public Int4 ZZXZ => new Int4(Z,Z,X,Z);

		public Int4 ZZYX => new Int4(Z,Z,Y,X);

		public Int4 ZZYY => new Int4(Z,Z,Y,Y);

		public Int4 ZZYZ => new Int4(Z,Z,Y,Z);

		public Int4 ZZZX => new Int4(Z,Z,Z,X);

		public Int4 ZZZY => new Int4(Z,Z,Z,Y);

		public Int4 ZZZZ => new Int4(Z,Z,Z,Z);

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

		public int B
		{
			get => Z;
			set => Z = value;
		}

		public Int2 RR => new Int2(X,X);

		public Int2 RG => new Int2(X,Y);

		public Int2 RB => new Int2(X,Z);

		public Int2 GR => new Int2(Y,X);

		public Int2 GG => new Int2(Y,Y);

		public Int2 GB => new Int2(Y,Z);

		public Int2 BR => new Int2(Z,X);

		public Int2 BG => new Int2(Z,Y);

		public Int2 BB => new Int2(Z,Z);

		public Int3 RRR => new Int3(X,X,X);

		public Int3 RRG => new Int3(X,X,Y);

		public Int3 RRB => new Int3(X,X,Z);

		public Int3 RGR => new Int3(X,Y,X);

		public Int3 RGG => new Int3(X,Y,Y);

		public Int3 RGB => new Int3(X,Y,Z);

		public Int3 RBR => new Int3(X,Z,X);

		public Int3 RBG => new Int3(X,Z,Y);

		public Int3 RBB => new Int3(X,Z,Z);

		public Int3 GRR => new Int3(Y,X,X);

		public Int3 GRG => new Int3(Y,X,Y);

		public Int3 GRB => new Int3(Y,X,Z);

		public Int3 GGR => new Int3(Y,Y,X);

		public Int3 GGG => new Int3(Y,Y,Y);

		public Int3 GGB => new Int3(Y,Y,Z);

		public Int3 GBR => new Int3(Y,Z,X);

		public Int3 GBG => new Int3(Y,Z,Y);

		public Int3 GBB => new Int3(Y,Z,Z);

		public Int3 BRR => new Int3(Z,X,X);

		public Int3 BRG => new Int3(Z,X,Y);

		public Int3 BRB => new Int3(Z,X,Z);

		public Int3 BGR => new Int3(Z,Y,X);

		public Int3 BGG => new Int3(Z,Y,Y);

		public Int3 BGB => new Int3(Z,Y,Z);

		public Int3 BBR => new Int3(Z,Z,X);

		public Int3 BBG => new Int3(Z,Z,Y);

		public Int3 BBB => new Int3(Z,Z,Z);

		public Int4 RRRR => new Int4(X,X,X,X);

		public Int4 RRRG => new Int4(X,X,X,Y);

		public Int4 RRRB => new Int4(X,X,X,Z);

		public Int4 RRGR => new Int4(X,X,Y,X);

		public Int4 RRGG => new Int4(X,X,Y,Y);

		public Int4 RRGB => new Int4(X,X,Y,Z);

		public Int4 RRBR => new Int4(X,X,Z,X);

		public Int4 RRBG => new Int4(X,X,Z,Y);

		public Int4 RRBB => new Int4(X,X,Z,Z);

		public Int4 RGRR => new Int4(X,Y,X,X);

		public Int4 RGRG => new Int4(X,Y,X,Y);

		public Int4 RGRB => new Int4(X,Y,X,Z);

		public Int4 RGGR => new Int4(X,Y,Y,X);

		public Int4 RGGG => new Int4(X,Y,Y,Y);

		public Int4 RGGB => new Int4(X,Y,Y,Z);

		public Int4 RGBR => new Int4(X,Y,Z,X);

		public Int4 RGBG => new Int4(X,Y,Z,Y);

		public Int4 RGBB => new Int4(X,Y,Z,Z);

		public Int4 RBRR => new Int4(X,Z,X,X);

		public Int4 RBRG => new Int4(X,Z,X,Y);

		public Int4 RBRB => new Int4(X,Z,X,Z);

		public Int4 RBGR => new Int4(X,Z,Y,X);

		public Int4 RBGG => new Int4(X,Z,Y,Y);

		public Int4 RBGB => new Int4(X,Z,Y,Z);

		public Int4 RBBR => new Int4(X,Z,Z,X);

		public Int4 RBBG => new Int4(X,Z,Z,Y);

		public Int4 RBBB => new Int4(X,Z,Z,Z);

		public Int4 GRRR => new Int4(Y,X,X,X);

		public Int4 GRRG => new Int4(Y,X,X,Y);

		public Int4 GRRB => new Int4(Y,X,X,Z);

		public Int4 GRGR => new Int4(Y,X,Y,X);

		public Int4 GRGG => new Int4(Y,X,Y,Y);

		public Int4 GRGB => new Int4(Y,X,Y,Z);

		public Int4 GRBR => new Int4(Y,X,Z,X);

		public Int4 GRBG => new Int4(Y,X,Z,Y);

		public Int4 GRBB => new Int4(Y,X,Z,Z);

		public Int4 GGRR => new Int4(Y,Y,X,X);

		public Int4 GGRG => new Int4(Y,Y,X,Y);

		public Int4 GGRB => new Int4(Y,Y,X,Z);

		public Int4 GGGR => new Int4(Y,Y,Y,X);

		public Int4 GGGG => new Int4(Y,Y,Y,Y);

		public Int4 GGGB => new Int4(Y,Y,Y,Z);

		public Int4 GGBR => new Int4(Y,Y,Z,X);

		public Int4 GGBG => new Int4(Y,Y,Z,Y);

		public Int4 GGBB => new Int4(Y,Y,Z,Z);

		public Int4 GBRR => new Int4(Y,Z,X,X);

		public Int4 GBRG => new Int4(Y,Z,X,Y);

		public Int4 GBRB => new Int4(Y,Z,X,Z);

		public Int4 GBGR => new Int4(Y,Z,Y,X);

		public Int4 GBGG => new Int4(Y,Z,Y,Y);

		public Int4 GBGB => new Int4(Y,Z,Y,Z);

		public Int4 GBBR => new Int4(Y,Z,Z,X);

		public Int4 GBBG => new Int4(Y,Z,Z,Y);

		public Int4 GBBB => new Int4(Y,Z,Z,Z);

		public Int4 BRRR => new Int4(Z,X,X,X);

		public Int4 BRRG => new Int4(Z,X,X,Y);

		public Int4 BRRB => new Int4(Z,X,X,Z);

		public Int4 BRGR => new Int4(Z,X,Y,X);

		public Int4 BRGG => new Int4(Z,X,Y,Y);

		public Int4 BRGB => new Int4(Z,X,Y,Z);

		public Int4 BRBR => new Int4(Z,X,Z,X);

		public Int4 BRBG => new Int4(Z,X,Z,Y);

		public Int4 BRBB => new Int4(Z,X,Z,Z);

		public Int4 BGRR => new Int4(Z,Y,X,X);

		public Int4 BGRG => new Int4(Z,Y,X,Y);

		public Int4 BGRB => new Int4(Z,Y,X,Z);

		public Int4 BGGR => new Int4(Z,Y,Y,X);

		public Int4 BGGG => new Int4(Z,Y,Y,Y);

		public Int4 BGGB => new Int4(Z,Y,Y,Z);

		public Int4 BGBR => new Int4(Z,Y,Z,X);

		public Int4 BGBG => new Int4(Z,Y,Z,Y);

		public Int4 BGBB => new Int4(Z,Y,Z,Z);

		public Int4 BBRR => new Int4(Z,Z,X,X);

		public Int4 BBRG => new Int4(Z,Z,X,Y);

		public Int4 BBRB => new Int4(Z,Z,X,Z);

		public Int4 BBGR => new Int4(Z,Z,Y,X);

		public Int4 BBGG => new Int4(Z,Z,Y,Y);

		public Int4 BBGB => new Int4(Z,Z,Y,Z);

		public Int4 BBBR => new Int4(Z,Z,Z,X);

		public Int4 BBBG => new Int4(Z,Z,Z,Y);

		public Int4 BBBB => new Int4(Z,Z,Z,Z);

		public static Int3 operator +(Int3 a, Int3 b)
		{
			return new Int3()
			{
				X = a.X + b.X,
				Y = a.Y + b.Y,
				Z = a.Z + b.Z,
			};
		}

		public static Int3 operator -(Int3 a, Int3 b)
		{
			return new Int3()
			{
				X = a.X - b.X,
				Y = a.Y - b.Y,
				Z = a.Z - b.Z,
			};
		}

		public static Int3 operator *(Int3 a, Int3 b)
		{
			return new Int3()
			{
				X = a.X * b.X,
				Y = a.Y * b.Y,
				Z = a.Z * b.Z,
			};
		}

		public static Int3 operator /(Int3 a, Int3 b)
		{
			return new Int3()
			{
				X = a.X / b.X,
				Y = a.Y / b.Y,
				Z = a.Z / b.Z,
			};
		}

	}
}
