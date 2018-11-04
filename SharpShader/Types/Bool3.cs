using System.Runtime.InteropServices;

namespace SharpShader
{
	[StructLayout(LayoutKind.Sequential)]
	public struct Bool3
	{
        /// <summary>
        /// The X component.
        /// </summary>
		public bool X;

        /// <summary>
        /// The Y component.
        /// </summary>
		public bool Y;

        /// <summary>
        /// The Z component.
        /// </summary>
		public bool Z;

        /// <summary>
        /// Creates a new instance of <see cref="Bool3"/>.
        /// </summary>
		public Bool3(bool x, bool y, bool z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		public Bool2 XX => new Bool2(X,X);

		public Bool2 XY => new Bool2(X,Y);

		public Bool2 XZ => new Bool2(X,Z);

		public Bool2 YX => new Bool2(Y,X);

		public Bool2 YY => new Bool2(Y,Y);

		public Bool2 YZ => new Bool2(Y,Z);

		public Bool2 ZX => new Bool2(Z,X);

		public Bool2 ZY => new Bool2(Z,Y);

		public Bool2 ZZ => new Bool2(Z,Z);

		public Bool3 XXX => new Bool3(X,X,X);

		public Bool3 XXY => new Bool3(X,X,Y);

		public Bool3 XXZ => new Bool3(X,X,Z);

		public Bool3 XYX => new Bool3(X,Y,X);

		public Bool3 XYY => new Bool3(X,Y,Y);

		public Bool3 XYZ => new Bool3(X,Y,Z);

		public Bool3 XZX => new Bool3(X,Z,X);

		public Bool3 XZY => new Bool3(X,Z,Y);

		public Bool3 XZZ => new Bool3(X,Z,Z);

		public Bool3 YXX => new Bool3(Y,X,X);

		public Bool3 YXY => new Bool3(Y,X,Y);

		public Bool3 YXZ => new Bool3(Y,X,Z);

		public Bool3 YYX => new Bool3(Y,Y,X);

		public Bool3 YYY => new Bool3(Y,Y,Y);

		public Bool3 YYZ => new Bool3(Y,Y,Z);

		public Bool3 YZX => new Bool3(Y,Z,X);

		public Bool3 YZY => new Bool3(Y,Z,Y);

		public Bool3 YZZ => new Bool3(Y,Z,Z);

		public Bool3 ZXX => new Bool3(Z,X,X);

		public Bool3 ZXY => new Bool3(Z,X,Y);

		public Bool3 ZXZ => new Bool3(Z,X,Z);

		public Bool3 ZYX => new Bool3(Z,Y,X);

		public Bool3 ZYY => new Bool3(Z,Y,Y);

		public Bool3 ZYZ => new Bool3(Z,Y,Z);

		public Bool3 ZZX => new Bool3(Z,Z,X);

		public Bool3 ZZY => new Bool3(Z,Z,Y);

		public Bool3 ZZZ => new Bool3(Z,Z,Z);

		public Bool4 XXXX => new Bool4(X,X,X,X);

		public Bool4 XXXY => new Bool4(X,X,X,Y);

		public Bool4 XXXZ => new Bool4(X,X,X,Z);

		public Bool4 XXYX => new Bool4(X,X,Y,X);

		public Bool4 XXYY => new Bool4(X,X,Y,Y);

		public Bool4 XXYZ => new Bool4(X,X,Y,Z);

		public Bool4 XXZX => new Bool4(X,X,Z,X);

		public Bool4 XXZY => new Bool4(X,X,Z,Y);

		public Bool4 XXZZ => new Bool4(X,X,Z,Z);

		public Bool4 XYXX => new Bool4(X,Y,X,X);

		public Bool4 XYXY => new Bool4(X,Y,X,Y);

		public Bool4 XYXZ => new Bool4(X,Y,X,Z);

		public Bool4 XYYX => new Bool4(X,Y,Y,X);

		public Bool4 XYYY => new Bool4(X,Y,Y,Y);

		public Bool4 XYYZ => new Bool4(X,Y,Y,Z);

		public Bool4 XYZX => new Bool4(X,Y,Z,X);

		public Bool4 XYZY => new Bool4(X,Y,Z,Y);

		public Bool4 XYZZ => new Bool4(X,Y,Z,Z);

		public Bool4 XZXX => new Bool4(X,Z,X,X);

		public Bool4 XZXY => new Bool4(X,Z,X,Y);

		public Bool4 XZXZ => new Bool4(X,Z,X,Z);

		public Bool4 XZYX => new Bool4(X,Z,Y,X);

		public Bool4 XZYY => new Bool4(X,Z,Y,Y);

		public Bool4 XZYZ => new Bool4(X,Z,Y,Z);

		public Bool4 XZZX => new Bool4(X,Z,Z,X);

		public Bool4 XZZY => new Bool4(X,Z,Z,Y);

		public Bool4 XZZZ => new Bool4(X,Z,Z,Z);

		public Bool4 YXXX => new Bool4(Y,X,X,X);

		public Bool4 YXXY => new Bool4(Y,X,X,Y);

		public Bool4 YXXZ => new Bool4(Y,X,X,Z);

		public Bool4 YXYX => new Bool4(Y,X,Y,X);

		public Bool4 YXYY => new Bool4(Y,X,Y,Y);

		public Bool4 YXYZ => new Bool4(Y,X,Y,Z);

		public Bool4 YXZX => new Bool4(Y,X,Z,X);

		public Bool4 YXZY => new Bool4(Y,X,Z,Y);

		public Bool4 YXZZ => new Bool4(Y,X,Z,Z);

		public Bool4 YYXX => new Bool4(Y,Y,X,X);

		public Bool4 YYXY => new Bool4(Y,Y,X,Y);

		public Bool4 YYXZ => new Bool4(Y,Y,X,Z);

		public Bool4 YYYX => new Bool4(Y,Y,Y,X);

		public Bool4 YYYY => new Bool4(Y,Y,Y,Y);

		public Bool4 YYYZ => new Bool4(Y,Y,Y,Z);

		public Bool4 YYZX => new Bool4(Y,Y,Z,X);

		public Bool4 YYZY => new Bool4(Y,Y,Z,Y);

		public Bool4 YYZZ => new Bool4(Y,Y,Z,Z);

		public Bool4 YZXX => new Bool4(Y,Z,X,X);

		public Bool4 YZXY => new Bool4(Y,Z,X,Y);

		public Bool4 YZXZ => new Bool4(Y,Z,X,Z);

		public Bool4 YZYX => new Bool4(Y,Z,Y,X);

		public Bool4 YZYY => new Bool4(Y,Z,Y,Y);

		public Bool4 YZYZ => new Bool4(Y,Z,Y,Z);

		public Bool4 YZZX => new Bool4(Y,Z,Z,X);

		public Bool4 YZZY => new Bool4(Y,Z,Z,Y);

		public Bool4 YZZZ => new Bool4(Y,Z,Z,Z);

		public Bool4 ZXXX => new Bool4(Z,X,X,X);

		public Bool4 ZXXY => new Bool4(Z,X,X,Y);

		public Bool4 ZXXZ => new Bool4(Z,X,X,Z);

		public Bool4 ZXYX => new Bool4(Z,X,Y,X);

		public Bool4 ZXYY => new Bool4(Z,X,Y,Y);

		public Bool4 ZXYZ => new Bool4(Z,X,Y,Z);

		public Bool4 ZXZX => new Bool4(Z,X,Z,X);

		public Bool4 ZXZY => new Bool4(Z,X,Z,Y);

		public Bool4 ZXZZ => new Bool4(Z,X,Z,Z);

		public Bool4 ZYXX => new Bool4(Z,Y,X,X);

		public Bool4 ZYXY => new Bool4(Z,Y,X,Y);

		public Bool4 ZYXZ => new Bool4(Z,Y,X,Z);

		public Bool4 ZYYX => new Bool4(Z,Y,Y,X);

		public Bool4 ZYYY => new Bool4(Z,Y,Y,Y);

		public Bool4 ZYYZ => new Bool4(Z,Y,Y,Z);

		public Bool4 ZYZX => new Bool4(Z,Y,Z,X);

		public Bool4 ZYZY => new Bool4(Z,Y,Z,Y);

		public Bool4 ZYZZ => new Bool4(Z,Y,Z,Z);

		public Bool4 ZZXX => new Bool4(Z,Z,X,X);

		public Bool4 ZZXY => new Bool4(Z,Z,X,Y);

		public Bool4 ZZXZ => new Bool4(Z,Z,X,Z);

		public Bool4 ZZYX => new Bool4(Z,Z,Y,X);

		public Bool4 ZZYY => new Bool4(Z,Z,Y,Y);

		public Bool4 ZZYZ => new Bool4(Z,Z,Y,Z);

		public Bool4 ZZZX => new Bool4(Z,Z,Z,X);

		public Bool4 ZZZY => new Bool4(Z,Z,Z,Y);

		public Bool4 ZZZZ => new Bool4(Z,Z,Z,Z);

		public bool R
		{
			get => X;
			set => X = value;
		}

		public bool G
		{
			get => Y;
			set => Y = value;
		}

		public bool B
		{
			get => Z;
			set => Z = value;
		}

		public Bool2 RR => new Bool2(X,X);

		public Bool2 RG => new Bool2(X,Y);

		public Bool2 RB => new Bool2(X,Z);

		public Bool2 GR => new Bool2(Y,X);

		public Bool2 GG => new Bool2(Y,Y);

		public Bool2 GB => new Bool2(Y,Z);

		public Bool2 BR => new Bool2(Z,X);

		public Bool2 BG => new Bool2(Z,Y);

		public Bool2 BB => new Bool2(Z,Z);

		public Bool3 RRR => new Bool3(X,X,X);

		public Bool3 RRG => new Bool3(X,X,Y);

		public Bool3 RRB => new Bool3(X,X,Z);

		public Bool3 RGR => new Bool3(X,Y,X);

		public Bool3 RGG => new Bool3(X,Y,Y);

		public Bool3 RGB => new Bool3(X,Y,Z);

		public Bool3 RBR => new Bool3(X,Z,X);

		public Bool3 RBG => new Bool3(X,Z,Y);

		public Bool3 RBB => new Bool3(X,Z,Z);

		public Bool3 GRR => new Bool3(Y,X,X);

		public Bool3 GRG => new Bool3(Y,X,Y);

		public Bool3 GRB => new Bool3(Y,X,Z);

		public Bool3 GGR => new Bool3(Y,Y,X);

		public Bool3 GGG => new Bool3(Y,Y,Y);

		public Bool3 GGB => new Bool3(Y,Y,Z);

		public Bool3 GBR => new Bool3(Y,Z,X);

		public Bool3 GBG => new Bool3(Y,Z,Y);

		public Bool3 GBB => new Bool3(Y,Z,Z);

		public Bool3 BRR => new Bool3(Z,X,X);

		public Bool3 BRG => new Bool3(Z,X,Y);

		public Bool3 BRB => new Bool3(Z,X,Z);

		public Bool3 BGR => new Bool3(Z,Y,X);

		public Bool3 BGG => new Bool3(Z,Y,Y);

		public Bool3 BGB => new Bool3(Z,Y,Z);

		public Bool3 BBR => new Bool3(Z,Z,X);

		public Bool3 BBG => new Bool3(Z,Z,Y);

		public Bool3 BBB => new Bool3(Z,Z,Z);

		public Bool4 RRRR => new Bool4(X,X,X,X);

		public Bool4 RRRG => new Bool4(X,X,X,Y);

		public Bool4 RRRB => new Bool4(X,X,X,Z);

		public Bool4 RRGR => new Bool4(X,X,Y,X);

		public Bool4 RRGG => new Bool4(X,X,Y,Y);

		public Bool4 RRGB => new Bool4(X,X,Y,Z);

		public Bool4 RRBR => new Bool4(X,X,Z,X);

		public Bool4 RRBG => new Bool4(X,X,Z,Y);

		public Bool4 RRBB => new Bool4(X,X,Z,Z);

		public Bool4 RGRR => new Bool4(X,Y,X,X);

		public Bool4 RGRG => new Bool4(X,Y,X,Y);

		public Bool4 RGRB => new Bool4(X,Y,X,Z);

		public Bool4 RGGR => new Bool4(X,Y,Y,X);

		public Bool4 RGGG => new Bool4(X,Y,Y,Y);

		public Bool4 RGGB => new Bool4(X,Y,Y,Z);

		public Bool4 RGBR => new Bool4(X,Y,Z,X);

		public Bool4 RGBG => new Bool4(X,Y,Z,Y);

		public Bool4 RGBB => new Bool4(X,Y,Z,Z);

		public Bool4 RBRR => new Bool4(X,Z,X,X);

		public Bool4 RBRG => new Bool4(X,Z,X,Y);

		public Bool4 RBRB => new Bool4(X,Z,X,Z);

		public Bool4 RBGR => new Bool4(X,Z,Y,X);

		public Bool4 RBGG => new Bool4(X,Z,Y,Y);

		public Bool4 RBGB => new Bool4(X,Z,Y,Z);

		public Bool4 RBBR => new Bool4(X,Z,Z,X);

		public Bool4 RBBG => new Bool4(X,Z,Z,Y);

		public Bool4 RBBB => new Bool4(X,Z,Z,Z);

		public Bool4 GRRR => new Bool4(Y,X,X,X);

		public Bool4 GRRG => new Bool4(Y,X,X,Y);

		public Bool4 GRRB => new Bool4(Y,X,X,Z);

		public Bool4 GRGR => new Bool4(Y,X,Y,X);

		public Bool4 GRGG => new Bool4(Y,X,Y,Y);

		public Bool4 GRGB => new Bool4(Y,X,Y,Z);

		public Bool4 GRBR => new Bool4(Y,X,Z,X);

		public Bool4 GRBG => new Bool4(Y,X,Z,Y);

		public Bool4 GRBB => new Bool4(Y,X,Z,Z);

		public Bool4 GGRR => new Bool4(Y,Y,X,X);

		public Bool4 GGRG => new Bool4(Y,Y,X,Y);

		public Bool4 GGRB => new Bool4(Y,Y,X,Z);

		public Bool4 GGGR => new Bool4(Y,Y,Y,X);

		public Bool4 GGGG => new Bool4(Y,Y,Y,Y);

		public Bool4 GGGB => new Bool4(Y,Y,Y,Z);

		public Bool4 GGBR => new Bool4(Y,Y,Z,X);

		public Bool4 GGBG => new Bool4(Y,Y,Z,Y);

		public Bool4 GGBB => new Bool4(Y,Y,Z,Z);

		public Bool4 GBRR => new Bool4(Y,Z,X,X);

		public Bool4 GBRG => new Bool4(Y,Z,X,Y);

		public Bool4 GBRB => new Bool4(Y,Z,X,Z);

		public Bool4 GBGR => new Bool4(Y,Z,Y,X);

		public Bool4 GBGG => new Bool4(Y,Z,Y,Y);

		public Bool4 GBGB => new Bool4(Y,Z,Y,Z);

		public Bool4 GBBR => new Bool4(Y,Z,Z,X);

		public Bool4 GBBG => new Bool4(Y,Z,Z,Y);

		public Bool4 GBBB => new Bool4(Y,Z,Z,Z);

		public Bool4 BRRR => new Bool4(Z,X,X,X);

		public Bool4 BRRG => new Bool4(Z,X,X,Y);

		public Bool4 BRRB => new Bool4(Z,X,X,Z);

		public Bool4 BRGR => new Bool4(Z,X,Y,X);

		public Bool4 BRGG => new Bool4(Z,X,Y,Y);

		public Bool4 BRGB => new Bool4(Z,X,Y,Z);

		public Bool4 BRBR => new Bool4(Z,X,Z,X);

		public Bool4 BRBG => new Bool4(Z,X,Z,Y);

		public Bool4 BRBB => new Bool4(Z,X,Z,Z);

		public Bool4 BGRR => new Bool4(Z,Y,X,X);

		public Bool4 BGRG => new Bool4(Z,Y,X,Y);

		public Bool4 BGRB => new Bool4(Z,Y,X,Z);

		public Bool4 BGGR => new Bool4(Z,Y,Y,X);

		public Bool4 BGGG => new Bool4(Z,Y,Y,Y);

		public Bool4 BGGB => new Bool4(Z,Y,Y,Z);

		public Bool4 BGBR => new Bool4(Z,Y,Z,X);

		public Bool4 BGBG => new Bool4(Z,Y,Z,Y);

		public Bool4 BGBB => new Bool4(Z,Y,Z,Z);

		public Bool4 BBRR => new Bool4(Z,Z,X,X);

		public Bool4 BBRG => new Bool4(Z,Z,X,Y);

		public Bool4 BBRB => new Bool4(Z,Z,X,Z);

		public Bool4 BBGR => new Bool4(Z,Z,Y,X);

		public Bool4 BBGG => new Bool4(Z,Z,Y,Y);

		public Bool4 BBGB => new Bool4(Z,Z,Y,Z);

		public Bool4 BBBR => new Bool4(Z,Z,Z,X);

		public Bool4 BBBG => new Bool4(Z,Z,Z,Y);

		public Bool4 BBBB => new Bool4(Z,Z,Z,Z);

	}
}
