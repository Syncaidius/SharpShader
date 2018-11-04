using System.Runtime.InteropServices;

namespace SharpShader
{
	[StructLayout(LayoutKind.Sequential)]
	public struct Vector3
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
        /// The Z component.
        /// </summary>
		public float Z;

        /// <summary>
        /// Creates a new instance of <see cref="Vector3"/>.
        /// </summary>
		public Vector3(float x, float y, float z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		public Vector2 XX => new Vector2(X,X);

		public Vector2 XY => new Vector2(X,Y);

		public Vector2 XZ => new Vector2(X,Z);

		public Vector2 YX => new Vector2(Y,X);

		public Vector2 YY => new Vector2(Y,Y);

		public Vector2 YZ => new Vector2(Y,Z);

		public Vector2 ZX => new Vector2(Z,X);

		public Vector2 ZY => new Vector2(Z,Y);

		public Vector2 ZZ => new Vector2(Z,Z);

		public Vector3 XXX => new Vector3(X,X,X);

		public Vector3 XXY => new Vector3(X,X,Y);

		public Vector3 XXZ => new Vector3(X,X,Z);

		public Vector3 XYX => new Vector3(X,Y,X);

		public Vector3 XYY => new Vector3(X,Y,Y);

		public Vector3 XYZ => new Vector3(X,Y,Z);

		public Vector3 XZX => new Vector3(X,Z,X);

		public Vector3 XZY => new Vector3(X,Z,Y);

		public Vector3 XZZ => new Vector3(X,Z,Z);

		public Vector3 YXX => new Vector3(Y,X,X);

		public Vector3 YXY => new Vector3(Y,X,Y);

		public Vector3 YXZ => new Vector3(Y,X,Z);

		public Vector3 YYX => new Vector3(Y,Y,X);

		public Vector3 YYY => new Vector3(Y,Y,Y);

		public Vector3 YYZ => new Vector3(Y,Y,Z);

		public Vector3 YZX => new Vector3(Y,Z,X);

		public Vector3 YZY => new Vector3(Y,Z,Y);

		public Vector3 YZZ => new Vector3(Y,Z,Z);

		public Vector3 ZXX => new Vector3(Z,X,X);

		public Vector3 ZXY => new Vector3(Z,X,Y);

		public Vector3 ZXZ => new Vector3(Z,X,Z);

		public Vector3 ZYX => new Vector3(Z,Y,X);

		public Vector3 ZYY => new Vector3(Z,Y,Y);

		public Vector3 ZYZ => new Vector3(Z,Y,Z);

		public Vector3 ZZX => new Vector3(Z,Z,X);

		public Vector3 ZZY => new Vector3(Z,Z,Y);

		public Vector3 ZZZ => new Vector3(Z,Z,Z);

		public Vector4 XXXX => new Vector4(X,X,X,X);

		public Vector4 XXXY => new Vector4(X,X,X,Y);

		public Vector4 XXXZ => new Vector4(X,X,X,Z);

		public Vector4 XXYX => new Vector4(X,X,Y,X);

		public Vector4 XXYY => new Vector4(X,X,Y,Y);

		public Vector4 XXYZ => new Vector4(X,X,Y,Z);

		public Vector4 XXZX => new Vector4(X,X,Z,X);

		public Vector4 XXZY => new Vector4(X,X,Z,Y);

		public Vector4 XXZZ => new Vector4(X,X,Z,Z);

		public Vector4 XYXX => new Vector4(X,Y,X,X);

		public Vector4 XYXY => new Vector4(X,Y,X,Y);

		public Vector4 XYXZ => new Vector4(X,Y,X,Z);

		public Vector4 XYYX => new Vector4(X,Y,Y,X);

		public Vector4 XYYY => new Vector4(X,Y,Y,Y);

		public Vector4 XYYZ => new Vector4(X,Y,Y,Z);

		public Vector4 XYZX => new Vector4(X,Y,Z,X);

		public Vector4 XYZY => new Vector4(X,Y,Z,Y);

		public Vector4 XYZZ => new Vector4(X,Y,Z,Z);

		public Vector4 XZXX => new Vector4(X,Z,X,X);

		public Vector4 XZXY => new Vector4(X,Z,X,Y);

		public Vector4 XZXZ => new Vector4(X,Z,X,Z);

		public Vector4 XZYX => new Vector4(X,Z,Y,X);

		public Vector4 XZYY => new Vector4(X,Z,Y,Y);

		public Vector4 XZYZ => new Vector4(X,Z,Y,Z);

		public Vector4 XZZX => new Vector4(X,Z,Z,X);

		public Vector4 XZZY => new Vector4(X,Z,Z,Y);

		public Vector4 XZZZ => new Vector4(X,Z,Z,Z);

		public Vector4 YXXX => new Vector4(Y,X,X,X);

		public Vector4 YXXY => new Vector4(Y,X,X,Y);

		public Vector4 YXXZ => new Vector4(Y,X,X,Z);

		public Vector4 YXYX => new Vector4(Y,X,Y,X);

		public Vector4 YXYY => new Vector4(Y,X,Y,Y);

		public Vector4 YXYZ => new Vector4(Y,X,Y,Z);

		public Vector4 YXZX => new Vector4(Y,X,Z,X);

		public Vector4 YXZY => new Vector4(Y,X,Z,Y);

		public Vector4 YXZZ => new Vector4(Y,X,Z,Z);

		public Vector4 YYXX => new Vector4(Y,Y,X,X);

		public Vector4 YYXY => new Vector4(Y,Y,X,Y);

		public Vector4 YYXZ => new Vector4(Y,Y,X,Z);

		public Vector4 YYYX => new Vector4(Y,Y,Y,X);

		public Vector4 YYYY => new Vector4(Y,Y,Y,Y);

		public Vector4 YYYZ => new Vector4(Y,Y,Y,Z);

		public Vector4 YYZX => new Vector4(Y,Y,Z,X);

		public Vector4 YYZY => new Vector4(Y,Y,Z,Y);

		public Vector4 YYZZ => new Vector4(Y,Y,Z,Z);

		public Vector4 YZXX => new Vector4(Y,Z,X,X);

		public Vector4 YZXY => new Vector4(Y,Z,X,Y);

		public Vector4 YZXZ => new Vector4(Y,Z,X,Z);

		public Vector4 YZYX => new Vector4(Y,Z,Y,X);

		public Vector4 YZYY => new Vector4(Y,Z,Y,Y);

		public Vector4 YZYZ => new Vector4(Y,Z,Y,Z);

		public Vector4 YZZX => new Vector4(Y,Z,Z,X);

		public Vector4 YZZY => new Vector4(Y,Z,Z,Y);

		public Vector4 YZZZ => new Vector4(Y,Z,Z,Z);

		public Vector4 ZXXX => new Vector4(Z,X,X,X);

		public Vector4 ZXXY => new Vector4(Z,X,X,Y);

		public Vector4 ZXXZ => new Vector4(Z,X,X,Z);

		public Vector4 ZXYX => new Vector4(Z,X,Y,X);

		public Vector4 ZXYY => new Vector4(Z,X,Y,Y);

		public Vector4 ZXYZ => new Vector4(Z,X,Y,Z);

		public Vector4 ZXZX => new Vector4(Z,X,Z,X);

		public Vector4 ZXZY => new Vector4(Z,X,Z,Y);

		public Vector4 ZXZZ => new Vector4(Z,X,Z,Z);

		public Vector4 ZYXX => new Vector4(Z,Y,X,X);

		public Vector4 ZYXY => new Vector4(Z,Y,X,Y);

		public Vector4 ZYXZ => new Vector4(Z,Y,X,Z);

		public Vector4 ZYYX => new Vector4(Z,Y,Y,X);

		public Vector4 ZYYY => new Vector4(Z,Y,Y,Y);

		public Vector4 ZYYZ => new Vector4(Z,Y,Y,Z);

		public Vector4 ZYZX => new Vector4(Z,Y,Z,X);

		public Vector4 ZYZY => new Vector4(Z,Y,Z,Y);

		public Vector4 ZYZZ => new Vector4(Z,Y,Z,Z);

		public Vector4 ZZXX => new Vector4(Z,Z,X,X);

		public Vector4 ZZXY => new Vector4(Z,Z,X,Y);

		public Vector4 ZZXZ => new Vector4(Z,Z,X,Z);

		public Vector4 ZZYX => new Vector4(Z,Z,Y,X);

		public Vector4 ZZYY => new Vector4(Z,Z,Y,Y);

		public Vector4 ZZYZ => new Vector4(Z,Z,Y,Z);

		public Vector4 ZZZX => new Vector4(Z,Z,Z,X);

		public Vector4 ZZZY => new Vector4(Z,Z,Z,Y);

		public Vector4 ZZZZ => new Vector4(Z,Z,Z,Z);

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

		public float B
		{
			get => Z;
			set => Z = value;
		}

		public Vector2 RR => new Vector2(X,X);

		public Vector2 RG => new Vector2(X,Y);

		public Vector2 RB => new Vector2(X,Z);

		public Vector2 GR => new Vector2(Y,X);

		public Vector2 GG => new Vector2(Y,Y);

		public Vector2 GB => new Vector2(Y,Z);

		public Vector2 BR => new Vector2(Z,X);

		public Vector2 BG => new Vector2(Z,Y);

		public Vector2 BB => new Vector2(Z,Z);

		public Vector3 RRR => new Vector3(X,X,X);

		public Vector3 RRG => new Vector3(X,X,Y);

		public Vector3 RRB => new Vector3(X,X,Z);

		public Vector3 RGR => new Vector3(X,Y,X);

		public Vector3 RGG => new Vector3(X,Y,Y);

		public Vector3 RGB => new Vector3(X,Y,Z);

		public Vector3 RBR => new Vector3(X,Z,X);

		public Vector3 RBG => new Vector3(X,Z,Y);

		public Vector3 RBB => new Vector3(X,Z,Z);

		public Vector3 GRR => new Vector3(Y,X,X);

		public Vector3 GRG => new Vector3(Y,X,Y);

		public Vector3 GRB => new Vector3(Y,X,Z);

		public Vector3 GGR => new Vector3(Y,Y,X);

		public Vector3 GGG => new Vector3(Y,Y,Y);

		public Vector3 GGB => new Vector3(Y,Y,Z);

		public Vector3 GBR => new Vector3(Y,Z,X);

		public Vector3 GBG => new Vector3(Y,Z,Y);

		public Vector3 GBB => new Vector3(Y,Z,Z);

		public Vector3 BRR => new Vector3(Z,X,X);

		public Vector3 BRG => new Vector3(Z,X,Y);

		public Vector3 BRB => new Vector3(Z,X,Z);

		public Vector3 BGR => new Vector3(Z,Y,X);

		public Vector3 BGG => new Vector3(Z,Y,Y);

		public Vector3 BGB => new Vector3(Z,Y,Z);

		public Vector3 BBR => new Vector3(Z,Z,X);

		public Vector3 BBG => new Vector3(Z,Z,Y);

		public Vector3 BBB => new Vector3(Z,Z,Z);

		public Vector4 RRRR => new Vector4(X,X,X,X);

		public Vector4 RRRG => new Vector4(X,X,X,Y);

		public Vector4 RRRB => new Vector4(X,X,X,Z);

		public Vector4 RRGR => new Vector4(X,X,Y,X);

		public Vector4 RRGG => new Vector4(X,X,Y,Y);

		public Vector4 RRGB => new Vector4(X,X,Y,Z);

		public Vector4 RRBR => new Vector4(X,X,Z,X);

		public Vector4 RRBG => new Vector4(X,X,Z,Y);

		public Vector4 RRBB => new Vector4(X,X,Z,Z);

		public Vector4 RGRR => new Vector4(X,Y,X,X);

		public Vector4 RGRG => new Vector4(X,Y,X,Y);

		public Vector4 RGRB => new Vector4(X,Y,X,Z);

		public Vector4 RGGR => new Vector4(X,Y,Y,X);

		public Vector4 RGGG => new Vector4(X,Y,Y,Y);

		public Vector4 RGGB => new Vector4(X,Y,Y,Z);

		public Vector4 RGBR => new Vector4(X,Y,Z,X);

		public Vector4 RGBG => new Vector4(X,Y,Z,Y);

		public Vector4 RGBB => new Vector4(X,Y,Z,Z);

		public Vector4 RBRR => new Vector4(X,Z,X,X);

		public Vector4 RBRG => new Vector4(X,Z,X,Y);

		public Vector4 RBRB => new Vector4(X,Z,X,Z);

		public Vector4 RBGR => new Vector4(X,Z,Y,X);

		public Vector4 RBGG => new Vector4(X,Z,Y,Y);

		public Vector4 RBGB => new Vector4(X,Z,Y,Z);

		public Vector4 RBBR => new Vector4(X,Z,Z,X);

		public Vector4 RBBG => new Vector4(X,Z,Z,Y);

		public Vector4 RBBB => new Vector4(X,Z,Z,Z);

		public Vector4 GRRR => new Vector4(Y,X,X,X);

		public Vector4 GRRG => new Vector4(Y,X,X,Y);

		public Vector4 GRRB => new Vector4(Y,X,X,Z);

		public Vector4 GRGR => new Vector4(Y,X,Y,X);

		public Vector4 GRGG => new Vector4(Y,X,Y,Y);

		public Vector4 GRGB => new Vector4(Y,X,Y,Z);

		public Vector4 GRBR => new Vector4(Y,X,Z,X);

		public Vector4 GRBG => new Vector4(Y,X,Z,Y);

		public Vector4 GRBB => new Vector4(Y,X,Z,Z);

		public Vector4 GGRR => new Vector4(Y,Y,X,X);

		public Vector4 GGRG => new Vector4(Y,Y,X,Y);

		public Vector4 GGRB => new Vector4(Y,Y,X,Z);

		public Vector4 GGGR => new Vector4(Y,Y,Y,X);

		public Vector4 GGGG => new Vector4(Y,Y,Y,Y);

		public Vector4 GGGB => new Vector4(Y,Y,Y,Z);

		public Vector4 GGBR => new Vector4(Y,Y,Z,X);

		public Vector4 GGBG => new Vector4(Y,Y,Z,Y);

		public Vector4 GGBB => new Vector4(Y,Y,Z,Z);

		public Vector4 GBRR => new Vector4(Y,Z,X,X);

		public Vector4 GBRG => new Vector4(Y,Z,X,Y);

		public Vector4 GBRB => new Vector4(Y,Z,X,Z);

		public Vector4 GBGR => new Vector4(Y,Z,Y,X);

		public Vector4 GBGG => new Vector4(Y,Z,Y,Y);

		public Vector4 GBGB => new Vector4(Y,Z,Y,Z);

		public Vector4 GBBR => new Vector4(Y,Z,Z,X);

		public Vector4 GBBG => new Vector4(Y,Z,Z,Y);

		public Vector4 GBBB => new Vector4(Y,Z,Z,Z);

		public Vector4 BRRR => new Vector4(Z,X,X,X);

		public Vector4 BRRG => new Vector4(Z,X,X,Y);

		public Vector4 BRRB => new Vector4(Z,X,X,Z);

		public Vector4 BRGR => new Vector4(Z,X,Y,X);

		public Vector4 BRGG => new Vector4(Z,X,Y,Y);

		public Vector4 BRGB => new Vector4(Z,X,Y,Z);

		public Vector4 BRBR => new Vector4(Z,X,Z,X);

		public Vector4 BRBG => new Vector4(Z,X,Z,Y);

		public Vector4 BRBB => new Vector4(Z,X,Z,Z);

		public Vector4 BGRR => new Vector4(Z,Y,X,X);

		public Vector4 BGRG => new Vector4(Z,Y,X,Y);

		public Vector4 BGRB => new Vector4(Z,Y,X,Z);

		public Vector4 BGGR => new Vector4(Z,Y,Y,X);

		public Vector4 BGGG => new Vector4(Z,Y,Y,Y);

		public Vector4 BGGB => new Vector4(Z,Y,Y,Z);

		public Vector4 BGBR => new Vector4(Z,Y,Z,X);

		public Vector4 BGBG => new Vector4(Z,Y,Z,Y);

		public Vector4 BGBB => new Vector4(Z,Y,Z,Z);

		public Vector4 BBRR => new Vector4(Z,Z,X,X);

		public Vector4 BBRG => new Vector4(Z,Z,X,Y);

		public Vector4 BBRB => new Vector4(Z,Z,X,Z);

		public Vector4 BBGR => new Vector4(Z,Z,Y,X);

		public Vector4 BBGG => new Vector4(Z,Z,Y,Y);

		public Vector4 BBGB => new Vector4(Z,Z,Y,Z);

		public Vector4 BBBR => new Vector4(Z,Z,Z,X);

		public Vector4 BBBG => new Vector4(Z,Z,Z,Y);

		public Vector4 BBBB => new Vector4(Z,Z,Z,Z);

		public static Vector3 operator +(Vector3 a, Vector3 b)
		{
			return new Vector3()
			{
				X = a.X + b.X,
				Y = a.Y + b.Y,
				Z = a.Z + b.Z,
			};
		}

		public static Vector3 operator -(Vector3 a, Vector3 b)
		{
			return new Vector3()
			{
				X = a.X - b.X,
				Y = a.Y - b.Y,
				Z = a.Z - b.Z,
			};
		}

		public static Vector3 operator *(Vector3 a, Vector3 b)
		{
			return new Vector3()
			{
				X = a.X * b.X,
				Y = a.Y * b.Y,
				Z = a.Z * b.Z,
			};
		}

		public static Vector3 operator /(Vector3 a, Vector3 b)
		{
			return new Vector3()
			{
				X = a.X / b.X,
				Y = a.Y / b.Y,
				Z = a.Z / b.Z,
			};
		}

	}
}
