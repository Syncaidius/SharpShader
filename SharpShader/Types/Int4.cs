using System.Runtime.InteropServices;

namespace SharpShader
{
	[StructLayout(LayoutKind.Sequential)]
	public struct Int4
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
        /// The W component.
        /// </summary>
		public int W;

        /// <summary>
        /// Creates a new instance of <see cref="Int4"/>.
        /// </summary>
		public Int4(int x, int y, int z, int w)
		{
			X = x;
			Y = y;
			Z = z;
			W = w;
		}

		public Int2 XX => new Int2(X,X);

		public Int2 XY => new Int2(X,Y);

		public Int2 XZ => new Int2(X,Z);

		public Int2 XW => new Int2(X,W);

		public Int2 YX => new Int2(Y,X);

		public Int2 YY => new Int2(Y,Y);

		public Int2 YZ => new Int2(Y,Z);

		public Int2 YW => new Int2(Y,W);

		public Int2 ZX => new Int2(Z,X);

		public Int2 ZY => new Int2(Z,Y);

		public Int2 ZZ => new Int2(Z,Z);

		public Int2 ZW => new Int2(Z,W);

		public Int2 WX => new Int2(W,X);

		public Int2 WY => new Int2(W,Y);

		public Int2 WZ => new Int2(W,Z);

		public Int2 WW => new Int2(W,W);

		public Int3 XXX => new Int3(X,X,X);

		public Int3 XXY => new Int3(X,X,Y);

		public Int3 XXZ => new Int3(X,X,Z);

		public Int3 XXW => new Int3(X,X,W);

		public Int3 XYX => new Int3(X,Y,X);

		public Int3 XYY => new Int3(X,Y,Y);

		public Int3 XYZ => new Int3(X,Y,Z);

		public Int3 XYW => new Int3(X,Y,W);

		public Int3 XZX => new Int3(X,Z,X);

		public Int3 XZY => new Int3(X,Z,Y);

		public Int3 XZZ => new Int3(X,Z,Z);

		public Int3 XZW => new Int3(X,Z,W);

		public Int3 XWX => new Int3(X,W,X);

		public Int3 XWY => new Int3(X,W,Y);

		public Int3 XWZ => new Int3(X,W,Z);

		public Int3 XWW => new Int3(X,W,W);

		public Int3 YXX => new Int3(Y,X,X);

		public Int3 YXY => new Int3(Y,X,Y);

		public Int3 YXZ => new Int3(Y,X,Z);

		public Int3 YXW => new Int3(Y,X,W);

		public Int3 YYX => new Int3(Y,Y,X);

		public Int3 YYY => new Int3(Y,Y,Y);

		public Int3 YYZ => new Int3(Y,Y,Z);

		public Int3 YYW => new Int3(Y,Y,W);

		public Int3 YZX => new Int3(Y,Z,X);

		public Int3 YZY => new Int3(Y,Z,Y);

		public Int3 YZZ => new Int3(Y,Z,Z);

		public Int3 YZW => new Int3(Y,Z,W);

		public Int3 YWX => new Int3(Y,W,X);

		public Int3 YWY => new Int3(Y,W,Y);

		public Int3 YWZ => new Int3(Y,W,Z);

		public Int3 YWW => new Int3(Y,W,W);

		public Int3 ZXX => new Int3(Z,X,X);

		public Int3 ZXY => new Int3(Z,X,Y);

		public Int3 ZXZ => new Int3(Z,X,Z);

		public Int3 ZXW => new Int3(Z,X,W);

		public Int3 ZYX => new Int3(Z,Y,X);

		public Int3 ZYY => new Int3(Z,Y,Y);

		public Int3 ZYZ => new Int3(Z,Y,Z);

		public Int3 ZYW => new Int3(Z,Y,W);

		public Int3 ZZX => new Int3(Z,Z,X);

		public Int3 ZZY => new Int3(Z,Z,Y);

		public Int3 ZZZ => new Int3(Z,Z,Z);

		public Int3 ZZW => new Int3(Z,Z,W);

		public Int3 ZWX => new Int3(Z,W,X);

		public Int3 ZWY => new Int3(Z,W,Y);

		public Int3 ZWZ => new Int3(Z,W,Z);

		public Int3 ZWW => new Int3(Z,W,W);

		public Int3 WXX => new Int3(W,X,X);

		public Int3 WXY => new Int3(W,X,Y);

		public Int3 WXZ => new Int3(W,X,Z);

		public Int3 WXW => new Int3(W,X,W);

		public Int3 WYX => new Int3(W,Y,X);

		public Int3 WYY => new Int3(W,Y,Y);

		public Int3 WYZ => new Int3(W,Y,Z);

		public Int3 WYW => new Int3(W,Y,W);

		public Int3 WZX => new Int3(W,Z,X);

		public Int3 WZY => new Int3(W,Z,Y);

		public Int3 WZZ => new Int3(W,Z,Z);

		public Int3 WZW => new Int3(W,Z,W);

		public Int3 WWX => new Int3(W,W,X);

		public Int3 WWY => new Int3(W,W,Y);

		public Int3 WWZ => new Int3(W,W,Z);

		public Int3 WWW => new Int3(W,W,W);

		public Int4 XXXX => new Int4(X,X,X,X);

		public Int4 XXXY => new Int4(X,X,X,Y);

		public Int4 XXXZ => new Int4(X,X,X,Z);

		public Int4 XXXW => new Int4(X,X,X,W);

		public Int4 XXYX => new Int4(X,X,Y,X);

		public Int4 XXYY => new Int4(X,X,Y,Y);

		public Int4 XXYZ => new Int4(X,X,Y,Z);

		public Int4 XXYW => new Int4(X,X,Y,W);

		public Int4 XXZX => new Int4(X,X,Z,X);

		public Int4 XXZY => new Int4(X,X,Z,Y);

		public Int4 XXZZ => new Int4(X,X,Z,Z);

		public Int4 XXZW => new Int4(X,X,Z,W);

		public Int4 XXWX => new Int4(X,X,W,X);

		public Int4 XXWY => new Int4(X,X,W,Y);

		public Int4 XXWZ => new Int4(X,X,W,Z);

		public Int4 XXWW => new Int4(X,X,W,W);

		public Int4 XYXX => new Int4(X,Y,X,X);

		public Int4 XYXY => new Int4(X,Y,X,Y);

		public Int4 XYXZ => new Int4(X,Y,X,Z);

		public Int4 XYXW => new Int4(X,Y,X,W);

		public Int4 XYYX => new Int4(X,Y,Y,X);

		public Int4 XYYY => new Int4(X,Y,Y,Y);

		public Int4 XYYZ => new Int4(X,Y,Y,Z);

		public Int4 XYYW => new Int4(X,Y,Y,W);

		public Int4 XYZX => new Int4(X,Y,Z,X);

		public Int4 XYZY => new Int4(X,Y,Z,Y);

		public Int4 XYZZ => new Int4(X,Y,Z,Z);

		public Int4 XYZW => new Int4(X,Y,Z,W);

		public Int4 XYWX => new Int4(X,Y,W,X);

		public Int4 XYWY => new Int4(X,Y,W,Y);

		public Int4 XYWZ => new Int4(X,Y,W,Z);

		public Int4 XYWW => new Int4(X,Y,W,W);

		public Int4 XZXX => new Int4(X,Z,X,X);

		public Int4 XZXY => new Int4(X,Z,X,Y);

		public Int4 XZXZ => new Int4(X,Z,X,Z);

		public Int4 XZXW => new Int4(X,Z,X,W);

		public Int4 XZYX => new Int4(X,Z,Y,X);

		public Int4 XZYY => new Int4(X,Z,Y,Y);

		public Int4 XZYZ => new Int4(X,Z,Y,Z);

		public Int4 XZYW => new Int4(X,Z,Y,W);

		public Int4 XZZX => new Int4(X,Z,Z,X);

		public Int4 XZZY => new Int4(X,Z,Z,Y);

		public Int4 XZZZ => new Int4(X,Z,Z,Z);

		public Int4 XZZW => new Int4(X,Z,Z,W);

		public Int4 XZWX => new Int4(X,Z,W,X);

		public Int4 XZWY => new Int4(X,Z,W,Y);

		public Int4 XZWZ => new Int4(X,Z,W,Z);

		public Int4 XZWW => new Int4(X,Z,W,W);

		public Int4 XWXX => new Int4(X,W,X,X);

		public Int4 XWXY => new Int4(X,W,X,Y);

		public Int4 XWXZ => new Int4(X,W,X,Z);

		public Int4 XWXW => new Int4(X,W,X,W);

		public Int4 XWYX => new Int4(X,W,Y,X);

		public Int4 XWYY => new Int4(X,W,Y,Y);

		public Int4 XWYZ => new Int4(X,W,Y,Z);

		public Int4 XWYW => new Int4(X,W,Y,W);

		public Int4 XWZX => new Int4(X,W,Z,X);

		public Int4 XWZY => new Int4(X,W,Z,Y);

		public Int4 XWZZ => new Int4(X,W,Z,Z);

		public Int4 XWZW => new Int4(X,W,Z,W);

		public Int4 XWWX => new Int4(X,W,W,X);

		public Int4 XWWY => new Int4(X,W,W,Y);

		public Int4 XWWZ => new Int4(X,W,W,Z);

		public Int4 XWWW => new Int4(X,W,W,W);

		public Int4 YXXX => new Int4(Y,X,X,X);

		public Int4 YXXY => new Int4(Y,X,X,Y);

		public Int4 YXXZ => new Int4(Y,X,X,Z);

		public Int4 YXXW => new Int4(Y,X,X,W);

		public Int4 YXYX => new Int4(Y,X,Y,X);

		public Int4 YXYY => new Int4(Y,X,Y,Y);

		public Int4 YXYZ => new Int4(Y,X,Y,Z);

		public Int4 YXYW => new Int4(Y,X,Y,W);

		public Int4 YXZX => new Int4(Y,X,Z,X);

		public Int4 YXZY => new Int4(Y,X,Z,Y);

		public Int4 YXZZ => new Int4(Y,X,Z,Z);

		public Int4 YXZW => new Int4(Y,X,Z,W);

		public Int4 YXWX => new Int4(Y,X,W,X);

		public Int4 YXWY => new Int4(Y,X,W,Y);

		public Int4 YXWZ => new Int4(Y,X,W,Z);

		public Int4 YXWW => new Int4(Y,X,W,W);

		public Int4 YYXX => new Int4(Y,Y,X,X);

		public Int4 YYXY => new Int4(Y,Y,X,Y);

		public Int4 YYXZ => new Int4(Y,Y,X,Z);

		public Int4 YYXW => new Int4(Y,Y,X,W);

		public Int4 YYYX => new Int4(Y,Y,Y,X);

		public Int4 YYYY => new Int4(Y,Y,Y,Y);

		public Int4 YYYZ => new Int4(Y,Y,Y,Z);

		public Int4 YYYW => new Int4(Y,Y,Y,W);

		public Int4 YYZX => new Int4(Y,Y,Z,X);

		public Int4 YYZY => new Int4(Y,Y,Z,Y);

		public Int4 YYZZ => new Int4(Y,Y,Z,Z);

		public Int4 YYZW => new Int4(Y,Y,Z,W);

		public Int4 YYWX => new Int4(Y,Y,W,X);

		public Int4 YYWY => new Int4(Y,Y,W,Y);

		public Int4 YYWZ => new Int4(Y,Y,W,Z);

		public Int4 YYWW => new Int4(Y,Y,W,W);

		public Int4 YZXX => new Int4(Y,Z,X,X);

		public Int4 YZXY => new Int4(Y,Z,X,Y);

		public Int4 YZXZ => new Int4(Y,Z,X,Z);

		public Int4 YZXW => new Int4(Y,Z,X,W);

		public Int4 YZYX => new Int4(Y,Z,Y,X);

		public Int4 YZYY => new Int4(Y,Z,Y,Y);

		public Int4 YZYZ => new Int4(Y,Z,Y,Z);

		public Int4 YZYW => new Int4(Y,Z,Y,W);

		public Int4 YZZX => new Int4(Y,Z,Z,X);

		public Int4 YZZY => new Int4(Y,Z,Z,Y);

		public Int4 YZZZ => new Int4(Y,Z,Z,Z);

		public Int4 YZZW => new Int4(Y,Z,Z,W);

		public Int4 YZWX => new Int4(Y,Z,W,X);

		public Int4 YZWY => new Int4(Y,Z,W,Y);

		public Int4 YZWZ => new Int4(Y,Z,W,Z);

		public Int4 YZWW => new Int4(Y,Z,W,W);

		public Int4 YWXX => new Int4(Y,W,X,X);

		public Int4 YWXY => new Int4(Y,W,X,Y);

		public Int4 YWXZ => new Int4(Y,W,X,Z);

		public Int4 YWXW => new Int4(Y,W,X,W);

		public Int4 YWYX => new Int4(Y,W,Y,X);

		public Int4 YWYY => new Int4(Y,W,Y,Y);

		public Int4 YWYZ => new Int4(Y,W,Y,Z);

		public Int4 YWYW => new Int4(Y,W,Y,W);

		public Int4 YWZX => new Int4(Y,W,Z,X);

		public Int4 YWZY => new Int4(Y,W,Z,Y);

		public Int4 YWZZ => new Int4(Y,W,Z,Z);

		public Int4 YWZW => new Int4(Y,W,Z,W);

		public Int4 YWWX => new Int4(Y,W,W,X);

		public Int4 YWWY => new Int4(Y,W,W,Y);

		public Int4 YWWZ => new Int4(Y,W,W,Z);

		public Int4 YWWW => new Int4(Y,W,W,W);

		public Int4 ZXXX => new Int4(Z,X,X,X);

		public Int4 ZXXY => new Int4(Z,X,X,Y);

		public Int4 ZXXZ => new Int4(Z,X,X,Z);

		public Int4 ZXXW => new Int4(Z,X,X,W);

		public Int4 ZXYX => new Int4(Z,X,Y,X);

		public Int4 ZXYY => new Int4(Z,X,Y,Y);

		public Int4 ZXYZ => new Int4(Z,X,Y,Z);

		public Int4 ZXYW => new Int4(Z,X,Y,W);

		public Int4 ZXZX => new Int4(Z,X,Z,X);

		public Int4 ZXZY => new Int4(Z,X,Z,Y);

		public Int4 ZXZZ => new Int4(Z,X,Z,Z);

		public Int4 ZXZW => new Int4(Z,X,Z,W);

		public Int4 ZXWX => new Int4(Z,X,W,X);

		public Int4 ZXWY => new Int4(Z,X,W,Y);

		public Int4 ZXWZ => new Int4(Z,X,W,Z);

		public Int4 ZXWW => new Int4(Z,X,W,W);

		public Int4 ZYXX => new Int4(Z,Y,X,X);

		public Int4 ZYXY => new Int4(Z,Y,X,Y);

		public Int4 ZYXZ => new Int4(Z,Y,X,Z);

		public Int4 ZYXW => new Int4(Z,Y,X,W);

		public Int4 ZYYX => new Int4(Z,Y,Y,X);

		public Int4 ZYYY => new Int4(Z,Y,Y,Y);

		public Int4 ZYYZ => new Int4(Z,Y,Y,Z);

		public Int4 ZYYW => new Int4(Z,Y,Y,W);

		public Int4 ZYZX => new Int4(Z,Y,Z,X);

		public Int4 ZYZY => new Int4(Z,Y,Z,Y);

		public Int4 ZYZZ => new Int4(Z,Y,Z,Z);

		public Int4 ZYZW => new Int4(Z,Y,Z,W);

		public Int4 ZYWX => new Int4(Z,Y,W,X);

		public Int4 ZYWY => new Int4(Z,Y,W,Y);

		public Int4 ZYWZ => new Int4(Z,Y,W,Z);

		public Int4 ZYWW => new Int4(Z,Y,W,W);

		public Int4 ZZXX => new Int4(Z,Z,X,X);

		public Int4 ZZXY => new Int4(Z,Z,X,Y);

		public Int4 ZZXZ => new Int4(Z,Z,X,Z);

		public Int4 ZZXW => new Int4(Z,Z,X,W);

		public Int4 ZZYX => new Int4(Z,Z,Y,X);

		public Int4 ZZYY => new Int4(Z,Z,Y,Y);

		public Int4 ZZYZ => new Int4(Z,Z,Y,Z);

		public Int4 ZZYW => new Int4(Z,Z,Y,W);

		public Int4 ZZZX => new Int4(Z,Z,Z,X);

		public Int4 ZZZY => new Int4(Z,Z,Z,Y);

		public Int4 ZZZZ => new Int4(Z,Z,Z,Z);

		public Int4 ZZZW => new Int4(Z,Z,Z,W);

		public Int4 ZZWX => new Int4(Z,Z,W,X);

		public Int4 ZZWY => new Int4(Z,Z,W,Y);

		public Int4 ZZWZ => new Int4(Z,Z,W,Z);

		public Int4 ZZWW => new Int4(Z,Z,W,W);

		public Int4 ZWXX => new Int4(Z,W,X,X);

		public Int4 ZWXY => new Int4(Z,W,X,Y);

		public Int4 ZWXZ => new Int4(Z,W,X,Z);

		public Int4 ZWXW => new Int4(Z,W,X,W);

		public Int4 ZWYX => new Int4(Z,W,Y,X);

		public Int4 ZWYY => new Int4(Z,W,Y,Y);

		public Int4 ZWYZ => new Int4(Z,W,Y,Z);

		public Int4 ZWYW => new Int4(Z,W,Y,W);

		public Int4 ZWZX => new Int4(Z,W,Z,X);

		public Int4 ZWZY => new Int4(Z,W,Z,Y);

		public Int4 ZWZZ => new Int4(Z,W,Z,Z);

		public Int4 ZWZW => new Int4(Z,W,Z,W);

		public Int4 ZWWX => new Int4(Z,W,W,X);

		public Int4 ZWWY => new Int4(Z,W,W,Y);

		public Int4 ZWWZ => new Int4(Z,W,W,Z);

		public Int4 ZWWW => new Int4(Z,W,W,W);

		public Int4 WXXX => new Int4(W,X,X,X);

		public Int4 WXXY => new Int4(W,X,X,Y);

		public Int4 WXXZ => new Int4(W,X,X,Z);

		public Int4 WXXW => new Int4(W,X,X,W);

		public Int4 WXYX => new Int4(W,X,Y,X);

		public Int4 WXYY => new Int4(W,X,Y,Y);

		public Int4 WXYZ => new Int4(W,X,Y,Z);

		public Int4 WXYW => new Int4(W,X,Y,W);

		public Int4 WXZX => new Int4(W,X,Z,X);

		public Int4 WXZY => new Int4(W,X,Z,Y);

		public Int4 WXZZ => new Int4(W,X,Z,Z);

		public Int4 WXZW => new Int4(W,X,Z,W);

		public Int4 WXWX => new Int4(W,X,W,X);

		public Int4 WXWY => new Int4(W,X,W,Y);

		public Int4 WXWZ => new Int4(W,X,W,Z);

		public Int4 WXWW => new Int4(W,X,W,W);

		public Int4 WYXX => new Int4(W,Y,X,X);

		public Int4 WYXY => new Int4(W,Y,X,Y);

		public Int4 WYXZ => new Int4(W,Y,X,Z);

		public Int4 WYXW => new Int4(W,Y,X,W);

		public Int4 WYYX => new Int4(W,Y,Y,X);

		public Int4 WYYY => new Int4(W,Y,Y,Y);

		public Int4 WYYZ => new Int4(W,Y,Y,Z);

		public Int4 WYYW => new Int4(W,Y,Y,W);

		public Int4 WYZX => new Int4(W,Y,Z,X);

		public Int4 WYZY => new Int4(W,Y,Z,Y);

		public Int4 WYZZ => new Int4(W,Y,Z,Z);

		public Int4 WYZW => new Int4(W,Y,Z,W);

		public Int4 WYWX => new Int4(W,Y,W,X);

		public Int4 WYWY => new Int4(W,Y,W,Y);

		public Int4 WYWZ => new Int4(W,Y,W,Z);

		public Int4 WYWW => new Int4(W,Y,W,W);

		public Int4 WZXX => new Int4(W,Z,X,X);

		public Int4 WZXY => new Int4(W,Z,X,Y);

		public Int4 WZXZ => new Int4(W,Z,X,Z);

		public Int4 WZXW => new Int4(W,Z,X,W);

		public Int4 WZYX => new Int4(W,Z,Y,X);

		public Int4 WZYY => new Int4(W,Z,Y,Y);

		public Int4 WZYZ => new Int4(W,Z,Y,Z);

		public Int4 WZYW => new Int4(W,Z,Y,W);

		public Int4 WZZX => new Int4(W,Z,Z,X);

		public Int4 WZZY => new Int4(W,Z,Z,Y);

		public Int4 WZZZ => new Int4(W,Z,Z,Z);

		public Int4 WZZW => new Int4(W,Z,Z,W);

		public Int4 WZWX => new Int4(W,Z,W,X);

		public Int4 WZWY => new Int4(W,Z,W,Y);

		public Int4 WZWZ => new Int4(W,Z,W,Z);

		public Int4 WZWW => new Int4(W,Z,W,W);

		public Int4 WWXX => new Int4(W,W,X,X);

		public Int4 WWXY => new Int4(W,W,X,Y);

		public Int4 WWXZ => new Int4(W,W,X,Z);

		public Int4 WWXW => new Int4(W,W,X,W);

		public Int4 WWYX => new Int4(W,W,Y,X);

		public Int4 WWYY => new Int4(W,W,Y,Y);

		public Int4 WWYZ => new Int4(W,W,Y,Z);

		public Int4 WWYW => new Int4(W,W,Y,W);

		public Int4 WWZX => new Int4(W,W,Z,X);

		public Int4 WWZY => new Int4(W,W,Z,Y);

		public Int4 WWZZ => new Int4(W,W,Z,Z);

		public Int4 WWZW => new Int4(W,W,Z,W);

		public Int4 WWWX => new Int4(W,W,W,X);

		public Int4 WWWY => new Int4(W,W,W,Y);

		public Int4 WWWZ => new Int4(W,W,W,Z);

		public Int4 WWWW => new Int4(W,W,W,W);

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

		public int A
		{
			get => W;
			set => W = value;
		}

		public Int2 RR => new Int2(X,X);

		public Int2 RG => new Int2(X,Y);

		public Int2 RB => new Int2(X,Z);

		public Int2 RA => new Int2(X,W);

		public Int2 GR => new Int2(Y,X);

		public Int2 GG => new Int2(Y,Y);

		public Int2 GB => new Int2(Y,Z);

		public Int2 GA => new Int2(Y,W);

		public Int2 BR => new Int2(Z,X);

		public Int2 BG => new Int2(Z,Y);

		public Int2 BB => new Int2(Z,Z);

		public Int2 BA => new Int2(Z,W);

		public Int2 AR => new Int2(W,X);

		public Int2 AG => new Int2(W,Y);

		public Int2 AB => new Int2(W,Z);

		public Int2 AA => new Int2(W,W);

		public Int3 RRR => new Int3(X,X,X);

		public Int3 RRG => new Int3(X,X,Y);

		public Int3 RRB => new Int3(X,X,Z);

		public Int3 RRA => new Int3(X,X,W);

		public Int3 RGR => new Int3(X,Y,X);

		public Int3 RGG => new Int3(X,Y,Y);

		public Int3 RGB => new Int3(X,Y,Z);

		public Int3 RGA => new Int3(X,Y,W);

		public Int3 RBR => new Int3(X,Z,X);

		public Int3 RBG => new Int3(X,Z,Y);

		public Int3 RBB => new Int3(X,Z,Z);

		public Int3 RBA => new Int3(X,Z,W);

		public Int3 RAR => new Int3(X,W,X);

		public Int3 RAG => new Int3(X,W,Y);

		public Int3 RAB => new Int3(X,W,Z);

		public Int3 RAA => new Int3(X,W,W);

		public Int3 GRR => new Int3(Y,X,X);

		public Int3 GRG => new Int3(Y,X,Y);

		public Int3 GRB => new Int3(Y,X,Z);

		public Int3 GRA => new Int3(Y,X,W);

		public Int3 GGR => new Int3(Y,Y,X);

		public Int3 GGG => new Int3(Y,Y,Y);

		public Int3 GGB => new Int3(Y,Y,Z);

		public Int3 GGA => new Int3(Y,Y,W);

		public Int3 GBR => new Int3(Y,Z,X);

		public Int3 GBG => new Int3(Y,Z,Y);

		public Int3 GBB => new Int3(Y,Z,Z);

		public Int3 GBA => new Int3(Y,Z,W);

		public Int3 GAR => new Int3(Y,W,X);

		public Int3 GAG => new Int3(Y,W,Y);

		public Int3 GAB => new Int3(Y,W,Z);

		public Int3 GAA => new Int3(Y,W,W);

		public Int3 BRR => new Int3(Z,X,X);

		public Int3 BRG => new Int3(Z,X,Y);

		public Int3 BRB => new Int3(Z,X,Z);

		public Int3 BRA => new Int3(Z,X,W);

		public Int3 BGR => new Int3(Z,Y,X);

		public Int3 BGG => new Int3(Z,Y,Y);

		public Int3 BGB => new Int3(Z,Y,Z);

		public Int3 BGA => new Int3(Z,Y,W);

		public Int3 BBR => new Int3(Z,Z,X);

		public Int3 BBG => new Int3(Z,Z,Y);

		public Int3 BBB => new Int3(Z,Z,Z);

		public Int3 BBA => new Int3(Z,Z,W);

		public Int3 BAR => new Int3(Z,W,X);

		public Int3 BAG => new Int3(Z,W,Y);

		public Int3 BAB => new Int3(Z,W,Z);

		public Int3 BAA => new Int3(Z,W,W);

		public Int3 ARR => new Int3(W,X,X);

		public Int3 ARG => new Int3(W,X,Y);

		public Int3 ARB => new Int3(W,X,Z);

		public Int3 ARA => new Int3(W,X,W);

		public Int3 AGR => new Int3(W,Y,X);

		public Int3 AGG => new Int3(W,Y,Y);

		public Int3 AGB => new Int3(W,Y,Z);

		public Int3 AGA => new Int3(W,Y,W);

		public Int3 ABR => new Int3(W,Z,X);

		public Int3 ABG => new Int3(W,Z,Y);

		public Int3 ABB => new Int3(W,Z,Z);

		public Int3 ABA => new Int3(W,Z,W);

		public Int3 AAR => new Int3(W,W,X);

		public Int3 AAG => new Int3(W,W,Y);

		public Int3 AAB => new Int3(W,W,Z);

		public Int3 AAA => new Int3(W,W,W);

		public Int4 RRRR => new Int4(X,X,X,X);

		public Int4 RRRG => new Int4(X,X,X,Y);

		public Int4 RRRB => new Int4(X,X,X,Z);

		public Int4 RRRA => new Int4(X,X,X,W);

		public Int4 RRGR => new Int4(X,X,Y,X);

		public Int4 RRGG => new Int4(X,X,Y,Y);

		public Int4 RRGB => new Int4(X,X,Y,Z);

		public Int4 RRGA => new Int4(X,X,Y,W);

		public Int4 RRBR => new Int4(X,X,Z,X);

		public Int4 RRBG => new Int4(X,X,Z,Y);

		public Int4 RRBB => new Int4(X,X,Z,Z);

		public Int4 RRBA => new Int4(X,X,Z,W);

		public Int4 RRAR => new Int4(X,X,W,X);

		public Int4 RRAG => new Int4(X,X,W,Y);

		public Int4 RRAB => new Int4(X,X,W,Z);

		public Int4 RRAA => new Int4(X,X,W,W);

		public Int4 RGRR => new Int4(X,Y,X,X);

		public Int4 RGRG => new Int4(X,Y,X,Y);

		public Int4 RGRB => new Int4(X,Y,X,Z);

		public Int4 RGRA => new Int4(X,Y,X,W);

		public Int4 RGGR => new Int4(X,Y,Y,X);

		public Int4 RGGG => new Int4(X,Y,Y,Y);

		public Int4 RGGB => new Int4(X,Y,Y,Z);

		public Int4 RGGA => new Int4(X,Y,Y,W);

		public Int4 RGBR => new Int4(X,Y,Z,X);

		public Int4 RGBG => new Int4(X,Y,Z,Y);

		public Int4 RGBB => new Int4(X,Y,Z,Z);

		public Int4 RGBA => new Int4(X,Y,Z,W);

		public Int4 RGAR => new Int4(X,Y,W,X);

		public Int4 RGAG => new Int4(X,Y,W,Y);

		public Int4 RGAB => new Int4(X,Y,W,Z);

		public Int4 RGAA => new Int4(X,Y,W,W);

		public Int4 RBRR => new Int4(X,Z,X,X);

		public Int4 RBRG => new Int4(X,Z,X,Y);

		public Int4 RBRB => new Int4(X,Z,X,Z);

		public Int4 RBRA => new Int4(X,Z,X,W);

		public Int4 RBGR => new Int4(X,Z,Y,X);

		public Int4 RBGG => new Int4(X,Z,Y,Y);

		public Int4 RBGB => new Int4(X,Z,Y,Z);

		public Int4 RBGA => new Int4(X,Z,Y,W);

		public Int4 RBBR => new Int4(X,Z,Z,X);

		public Int4 RBBG => new Int4(X,Z,Z,Y);

		public Int4 RBBB => new Int4(X,Z,Z,Z);

		public Int4 RBBA => new Int4(X,Z,Z,W);

		public Int4 RBAR => new Int4(X,Z,W,X);

		public Int4 RBAG => new Int4(X,Z,W,Y);

		public Int4 RBAB => new Int4(X,Z,W,Z);

		public Int4 RBAA => new Int4(X,Z,W,W);

		public Int4 RARR => new Int4(X,W,X,X);

		public Int4 RARG => new Int4(X,W,X,Y);

		public Int4 RARB => new Int4(X,W,X,Z);

		public Int4 RARA => new Int4(X,W,X,W);

		public Int4 RAGR => new Int4(X,W,Y,X);

		public Int4 RAGG => new Int4(X,W,Y,Y);

		public Int4 RAGB => new Int4(X,W,Y,Z);

		public Int4 RAGA => new Int4(X,W,Y,W);

		public Int4 RABR => new Int4(X,W,Z,X);

		public Int4 RABG => new Int4(X,W,Z,Y);

		public Int4 RABB => new Int4(X,W,Z,Z);

		public Int4 RABA => new Int4(X,W,Z,W);

		public Int4 RAAR => new Int4(X,W,W,X);

		public Int4 RAAG => new Int4(X,W,W,Y);

		public Int4 RAAB => new Int4(X,W,W,Z);

		public Int4 RAAA => new Int4(X,W,W,W);

		public Int4 GRRR => new Int4(Y,X,X,X);

		public Int4 GRRG => new Int4(Y,X,X,Y);

		public Int4 GRRB => new Int4(Y,X,X,Z);

		public Int4 GRRA => new Int4(Y,X,X,W);

		public Int4 GRGR => new Int4(Y,X,Y,X);

		public Int4 GRGG => new Int4(Y,X,Y,Y);

		public Int4 GRGB => new Int4(Y,X,Y,Z);

		public Int4 GRGA => new Int4(Y,X,Y,W);

		public Int4 GRBR => new Int4(Y,X,Z,X);

		public Int4 GRBG => new Int4(Y,X,Z,Y);

		public Int4 GRBB => new Int4(Y,X,Z,Z);

		public Int4 GRBA => new Int4(Y,X,Z,W);

		public Int4 GRAR => new Int4(Y,X,W,X);

		public Int4 GRAG => new Int4(Y,X,W,Y);

		public Int4 GRAB => new Int4(Y,X,W,Z);

		public Int4 GRAA => new Int4(Y,X,W,W);

		public Int4 GGRR => new Int4(Y,Y,X,X);

		public Int4 GGRG => new Int4(Y,Y,X,Y);

		public Int4 GGRB => new Int4(Y,Y,X,Z);

		public Int4 GGRA => new Int4(Y,Y,X,W);

		public Int4 GGGR => new Int4(Y,Y,Y,X);

		public Int4 GGGG => new Int4(Y,Y,Y,Y);

		public Int4 GGGB => new Int4(Y,Y,Y,Z);

		public Int4 GGGA => new Int4(Y,Y,Y,W);

		public Int4 GGBR => new Int4(Y,Y,Z,X);

		public Int4 GGBG => new Int4(Y,Y,Z,Y);

		public Int4 GGBB => new Int4(Y,Y,Z,Z);

		public Int4 GGBA => new Int4(Y,Y,Z,W);

		public Int4 GGAR => new Int4(Y,Y,W,X);

		public Int4 GGAG => new Int4(Y,Y,W,Y);

		public Int4 GGAB => new Int4(Y,Y,W,Z);

		public Int4 GGAA => new Int4(Y,Y,W,W);

		public Int4 GBRR => new Int4(Y,Z,X,X);

		public Int4 GBRG => new Int4(Y,Z,X,Y);

		public Int4 GBRB => new Int4(Y,Z,X,Z);

		public Int4 GBRA => new Int4(Y,Z,X,W);

		public Int4 GBGR => new Int4(Y,Z,Y,X);

		public Int4 GBGG => new Int4(Y,Z,Y,Y);

		public Int4 GBGB => new Int4(Y,Z,Y,Z);

		public Int4 GBGA => new Int4(Y,Z,Y,W);

		public Int4 GBBR => new Int4(Y,Z,Z,X);

		public Int4 GBBG => new Int4(Y,Z,Z,Y);

		public Int4 GBBB => new Int4(Y,Z,Z,Z);

		public Int4 GBBA => new Int4(Y,Z,Z,W);

		public Int4 GBAR => new Int4(Y,Z,W,X);

		public Int4 GBAG => new Int4(Y,Z,W,Y);

		public Int4 GBAB => new Int4(Y,Z,W,Z);

		public Int4 GBAA => new Int4(Y,Z,W,W);

		public Int4 GARR => new Int4(Y,W,X,X);

		public Int4 GARG => new Int4(Y,W,X,Y);

		public Int4 GARB => new Int4(Y,W,X,Z);

		public Int4 GARA => new Int4(Y,W,X,W);

		public Int4 GAGR => new Int4(Y,W,Y,X);

		public Int4 GAGG => new Int4(Y,W,Y,Y);

		public Int4 GAGB => new Int4(Y,W,Y,Z);

		public Int4 GAGA => new Int4(Y,W,Y,W);

		public Int4 GABR => new Int4(Y,W,Z,X);

		public Int4 GABG => new Int4(Y,W,Z,Y);

		public Int4 GABB => new Int4(Y,W,Z,Z);

		public Int4 GABA => new Int4(Y,W,Z,W);

		public Int4 GAAR => new Int4(Y,W,W,X);

		public Int4 GAAG => new Int4(Y,W,W,Y);

		public Int4 GAAB => new Int4(Y,W,W,Z);

		public Int4 GAAA => new Int4(Y,W,W,W);

		public Int4 BRRR => new Int4(Z,X,X,X);

		public Int4 BRRG => new Int4(Z,X,X,Y);

		public Int4 BRRB => new Int4(Z,X,X,Z);

		public Int4 BRRA => new Int4(Z,X,X,W);

		public Int4 BRGR => new Int4(Z,X,Y,X);

		public Int4 BRGG => new Int4(Z,X,Y,Y);

		public Int4 BRGB => new Int4(Z,X,Y,Z);

		public Int4 BRGA => new Int4(Z,X,Y,W);

		public Int4 BRBR => new Int4(Z,X,Z,X);

		public Int4 BRBG => new Int4(Z,X,Z,Y);

		public Int4 BRBB => new Int4(Z,X,Z,Z);

		public Int4 BRBA => new Int4(Z,X,Z,W);

		public Int4 BRAR => new Int4(Z,X,W,X);

		public Int4 BRAG => new Int4(Z,X,W,Y);

		public Int4 BRAB => new Int4(Z,X,W,Z);

		public Int4 BRAA => new Int4(Z,X,W,W);

		public Int4 BGRR => new Int4(Z,Y,X,X);

		public Int4 BGRG => new Int4(Z,Y,X,Y);

		public Int4 BGRB => new Int4(Z,Y,X,Z);

		public Int4 BGRA => new Int4(Z,Y,X,W);

		public Int4 BGGR => new Int4(Z,Y,Y,X);

		public Int4 BGGG => new Int4(Z,Y,Y,Y);

		public Int4 BGGB => new Int4(Z,Y,Y,Z);

		public Int4 BGGA => new Int4(Z,Y,Y,W);

		public Int4 BGBR => new Int4(Z,Y,Z,X);

		public Int4 BGBG => new Int4(Z,Y,Z,Y);

		public Int4 BGBB => new Int4(Z,Y,Z,Z);

		public Int4 BGBA => new Int4(Z,Y,Z,W);

		public Int4 BGAR => new Int4(Z,Y,W,X);

		public Int4 BGAG => new Int4(Z,Y,W,Y);

		public Int4 BGAB => new Int4(Z,Y,W,Z);

		public Int4 BGAA => new Int4(Z,Y,W,W);

		public Int4 BBRR => new Int4(Z,Z,X,X);

		public Int4 BBRG => new Int4(Z,Z,X,Y);

		public Int4 BBRB => new Int4(Z,Z,X,Z);

		public Int4 BBRA => new Int4(Z,Z,X,W);

		public Int4 BBGR => new Int4(Z,Z,Y,X);

		public Int4 BBGG => new Int4(Z,Z,Y,Y);

		public Int4 BBGB => new Int4(Z,Z,Y,Z);

		public Int4 BBGA => new Int4(Z,Z,Y,W);

		public Int4 BBBR => new Int4(Z,Z,Z,X);

		public Int4 BBBG => new Int4(Z,Z,Z,Y);

		public Int4 BBBB => new Int4(Z,Z,Z,Z);

		public Int4 BBBA => new Int4(Z,Z,Z,W);

		public Int4 BBAR => new Int4(Z,Z,W,X);

		public Int4 BBAG => new Int4(Z,Z,W,Y);

		public Int4 BBAB => new Int4(Z,Z,W,Z);

		public Int4 BBAA => new Int4(Z,Z,W,W);

		public Int4 BARR => new Int4(Z,W,X,X);

		public Int4 BARG => new Int4(Z,W,X,Y);

		public Int4 BARB => new Int4(Z,W,X,Z);

		public Int4 BARA => new Int4(Z,W,X,W);

		public Int4 BAGR => new Int4(Z,W,Y,X);

		public Int4 BAGG => new Int4(Z,W,Y,Y);

		public Int4 BAGB => new Int4(Z,W,Y,Z);

		public Int4 BAGA => new Int4(Z,W,Y,W);

		public Int4 BABR => new Int4(Z,W,Z,X);

		public Int4 BABG => new Int4(Z,W,Z,Y);

		public Int4 BABB => new Int4(Z,W,Z,Z);

		public Int4 BABA => new Int4(Z,W,Z,W);

		public Int4 BAAR => new Int4(Z,W,W,X);

		public Int4 BAAG => new Int4(Z,W,W,Y);

		public Int4 BAAB => new Int4(Z,W,W,Z);

		public Int4 BAAA => new Int4(Z,W,W,W);

		public Int4 ARRR => new Int4(W,X,X,X);

		public Int4 ARRG => new Int4(W,X,X,Y);

		public Int4 ARRB => new Int4(W,X,X,Z);

		public Int4 ARRA => new Int4(W,X,X,W);

		public Int4 ARGR => new Int4(W,X,Y,X);

		public Int4 ARGG => new Int4(W,X,Y,Y);

		public Int4 ARGB => new Int4(W,X,Y,Z);

		public Int4 ARGA => new Int4(W,X,Y,W);

		public Int4 ARBR => new Int4(W,X,Z,X);

		public Int4 ARBG => new Int4(W,X,Z,Y);

		public Int4 ARBB => new Int4(W,X,Z,Z);

		public Int4 ARBA => new Int4(W,X,Z,W);

		public Int4 ARAR => new Int4(W,X,W,X);

		public Int4 ARAG => new Int4(W,X,W,Y);

		public Int4 ARAB => new Int4(W,X,W,Z);

		public Int4 ARAA => new Int4(W,X,W,W);

		public Int4 AGRR => new Int4(W,Y,X,X);

		public Int4 AGRG => new Int4(W,Y,X,Y);

		public Int4 AGRB => new Int4(W,Y,X,Z);

		public Int4 AGRA => new Int4(W,Y,X,W);

		public Int4 AGGR => new Int4(W,Y,Y,X);

		public Int4 AGGG => new Int4(W,Y,Y,Y);

		public Int4 AGGB => new Int4(W,Y,Y,Z);

		public Int4 AGGA => new Int4(W,Y,Y,W);

		public Int4 AGBR => new Int4(W,Y,Z,X);

		public Int4 AGBG => new Int4(W,Y,Z,Y);

		public Int4 AGBB => new Int4(W,Y,Z,Z);

		public Int4 AGBA => new Int4(W,Y,Z,W);

		public Int4 AGAR => new Int4(W,Y,W,X);

		public Int4 AGAG => new Int4(W,Y,W,Y);

		public Int4 AGAB => new Int4(W,Y,W,Z);

		public Int4 AGAA => new Int4(W,Y,W,W);

		public Int4 ABRR => new Int4(W,Z,X,X);

		public Int4 ABRG => new Int4(W,Z,X,Y);

		public Int4 ABRB => new Int4(W,Z,X,Z);

		public Int4 ABRA => new Int4(W,Z,X,W);

		public Int4 ABGR => new Int4(W,Z,Y,X);

		public Int4 ABGG => new Int4(W,Z,Y,Y);

		public Int4 ABGB => new Int4(W,Z,Y,Z);

		public Int4 ABGA => new Int4(W,Z,Y,W);

		public Int4 ABBR => new Int4(W,Z,Z,X);

		public Int4 ABBG => new Int4(W,Z,Z,Y);

		public Int4 ABBB => new Int4(W,Z,Z,Z);

		public Int4 ABBA => new Int4(W,Z,Z,W);

		public Int4 ABAR => new Int4(W,Z,W,X);

		public Int4 ABAG => new Int4(W,Z,W,Y);

		public Int4 ABAB => new Int4(W,Z,W,Z);

		public Int4 ABAA => new Int4(W,Z,W,W);

		public Int4 AARR => new Int4(W,W,X,X);

		public Int4 AARG => new Int4(W,W,X,Y);

		public Int4 AARB => new Int4(W,W,X,Z);

		public Int4 AARA => new Int4(W,W,X,W);

		public Int4 AAGR => new Int4(W,W,Y,X);

		public Int4 AAGG => new Int4(W,W,Y,Y);

		public Int4 AAGB => new Int4(W,W,Y,Z);

		public Int4 AAGA => new Int4(W,W,Y,W);

		public Int4 AABR => new Int4(W,W,Z,X);

		public Int4 AABG => new Int4(W,W,Z,Y);

		public Int4 AABB => new Int4(W,W,Z,Z);

		public Int4 AABA => new Int4(W,W,Z,W);

		public Int4 AAAR => new Int4(W,W,W,X);

		public Int4 AAAG => new Int4(W,W,W,Y);

		public Int4 AAAB => new Int4(W,W,W,Z);

		public Int4 AAAA => new Int4(W,W,W,W);

		public static Int4 operator +(Int4 a, Int4 b)
		{
			return new Int4()
			{
				X = a.X + b.X,
				Y = a.Y + b.Y,
				Z = a.Z + b.Z,
				W = a.W + b.W,
			};
		}

		public static Int4 operator -(Int4 a, Int4 b)
		{
			return new Int4()
			{
				X = a.X - b.X,
				Y = a.Y - b.Y,
				Z = a.Z - b.Z,
				W = a.W - b.W,
			};
		}

		public static Int4 operator *(Int4 a, Int4 b)
		{
			return new Int4()
			{
				X = a.X * b.X,
				Y = a.Y * b.Y,
				Z = a.Z * b.Z,
				W = a.W * b.W,
			};
		}

		public static Int4 operator /(Int4 a, Int4 b)
		{
			return new Int4()
			{
				X = a.X / b.X,
				Y = a.Y / b.Y,
				Z = a.Z / b.Z,
				W = a.W / b.W,
			};
		}

	}
}
