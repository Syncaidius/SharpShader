using System.Runtime.InteropServices;

namespace SharpShader
{
	[StructLayout(LayoutKind.Sequential)]
	public struct Double4
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
        /// The W component.
        /// </summary>
		public double W;

        /// <summary>
        /// Creates a new instance of <see cref="Double4"/>.
        /// </summary>
		public Double4(double x, double y, double z, double w)
		{
			X = x;
			Y = y;
			Z = z;
			W = w;
		}

		public Double2 XX => new Double2(X,X);

		public Double2 XY => new Double2(X,Y);

		public Double2 XZ => new Double2(X,Z);

		public Double2 XW => new Double2(X,W);

		public Double2 YX => new Double2(Y,X);

		public Double2 YY => new Double2(Y,Y);

		public Double2 YZ => new Double2(Y,Z);

		public Double2 YW => new Double2(Y,W);

		public Double2 ZX => new Double2(Z,X);

		public Double2 ZY => new Double2(Z,Y);

		public Double2 ZZ => new Double2(Z,Z);

		public Double2 ZW => new Double2(Z,W);

		public Double2 WX => new Double2(W,X);

		public Double2 WY => new Double2(W,Y);

		public Double2 WZ => new Double2(W,Z);

		public Double2 WW => new Double2(W,W);

		public Double3 XXX => new Double3(X,X,X);

		public Double3 XXY => new Double3(X,X,Y);

		public Double3 XXZ => new Double3(X,X,Z);

		public Double3 XXW => new Double3(X,X,W);

		public Double3 XYX => new Double3(X,Y,X);

		public Double3 XYY => new Double3(X,Y,Y);

		public Double3 XYZ => new Double3(X,Y,Z);

		public Double3 XYW => new Double3(X,Y,W);

		public Double3 XZX => new Double3(X,Z,X);

		public Double3 XZY => new Double3(X,Z,Y);

		public Double3 XZZ => new Double3(X,Z,Z);

		public Double3 XZW => new Double3(X,Z,W);

		public Double3 XWX => new Double3(X,W,X);

		public Double3 XWY => new Double3(X,W,Y);

		public Double3 XWZ => new Double3(X,W,Z);

		public Double3 XWW => new Double3(X,W,W);

		public Double3 YXX => new Double3(Y,X,X);

		public Double3 YXY => new Double3(Y,X,Y);

		public Double3 YXZ => new Double3(Y,X,Z);

		public Double3 YXW => new Double3(Y,X,W);

		public Double3 YYX => new Double3(Y,Y,X);

		public Double3 YYY => new Double3(Y,Y,Y);

		public Double3 YYZ => new Double3(Y,Y,Z);

		public Double3 YYW => new Double3(Y,Y,W);

		public Double3 YZX => new Double3(Y,Z,X);

		public Double3 YZY => new Double3(Y,Z,Y);

		public Double3 YZZ => new Double3(Y,Z,Z);

		public Double3 YZW => new Double3(Y,Z,W);

		public Double3 YWX => new Double3(Y,W,X);

		public Double3 YWY => new Double3(Y,W,Y);

		public Double3 YWZ => new Double3(Y,W,Z);

		public Double3 YWW => new Double3(Y,W,W);

		public Double3 ZXX => new Double3(Z,X,X);

		public Double3 ZXY => new Double3(Z,X,Y);

		public Double3 ZXZ => new Double3(Z,X,Z);

		public Double3 ZXW => new Double3(Z,X,W);

		public Double3 ZYX => new Double3(Z,Y,X);

		public Double3 ZYY => new Double3(Z,Y,Y);

		public Double3 ZYZ => new Double3(Z,Y,Z);

		public Double3 ZYW => new Double3(Z,Y,W);

		public Double3 ZZX => new Double3(Z,Z,X);

		public Double3 ZZY => new Double3(Z,Z,Y);

		public Double3 ZZZ => new Double3(Z,Z,Z);

		public Double3 ZZW => new Double3(Z,Z,W);

		public Double3 ZWX => new Double3(Z,W,X);

		public Double3 ZWY => new Double3(Z,W,Y);

		public Double3 ZWZ => new Double3(Z,W,Z);

		public Double3 ZWW => new Double3(Z,W,W);

		public Double3 WXX => new Double3(W,X,X);

		public Double3 WXY => new Double3(W,X,Y);

		public Double3 WXZ => new Double3(W,X,Z);

		public Double3 WXW => new Double3(W,X,W);

		public Double3 WYX => new Double3(W,Y,X);

		public Double3 WYY => new Double3(W,Y,Y);

		public Double3 WYZ => new Double3(W,Y,Z);

		public Double3 WYW => new Double3(W,Y,W);

		public Double3 WZX => new Double3(W,Z,X);

		public Double3 WZY => new Double3(W,Z,Y);

		public Double3 WZZ => new Double3(W,Z,Z);

		public Double3 WZW => new Double3(W,Z,W);

		public Double3 WWX => new Double3(W,W,X);

		public Double3 WWY => new Double3(W,W,Y);

		public Double3 WWZ => new Double3(W,W,Z);

		public Double3 WWW => new Double3(W,W,W);

		public Double4 XXXX => new Double4(X,X,X,X);

		public Double4 XXXY => new Double4(X,X,X,Y);

		public Double4 XXXZ => new Double4(X,X,X,Z);

		public Double4 XXXW => new Double4(X,X,X,W);

		public Double4 XXYX => new Double4(X,X,Y,X);

		public Double4 XXYY => new Double4(X,X,Y,Y);

		public Double4 XXYZ => new Double4(X,X,Y,Z);

		public Double4 XXYW => new Double4(X,X,Y,W);

		public Double4 XXZX => new Double4(X,X,Z,X);

		public Double4 XXZY => new Double4(X,X,Z,Y);

		public Double4 XXZZ => new Double4(X,X,Z,Z);

		public Double4 XXZW => new Double4(X,X,Z,W);

		public Double4 XXWX => new Double4(X,X,W,X);

		public Double4 XXWY => new Double4(X,X,W,Y);

		public Double4 XXWZ => new Double4(X,X,W,Z);

		public Double4 XXWW => new Double4(X,X,W,W);

		public Double4 XYXX => new Double4(X,Y,X,X);

		public Double4 XYXY => new Double4(X,Y,X,Y);

		public Double4 XYXZ => new Double4(X,Y,X,Z);

		public Double4 XYXW => new Double4(X,Y,X,W);

		public Double4 XYYX => new Double4(X,Y,Y,X);

		public Double4 XYYY => new Double4(X,Y,Y,Y);

		public Double4 XYYZ => new Double4(X,Y,Y,Z);

		public Double4 XYYW => new Double4(X,Y,Y,W);

		public Double4 XYZX => new Double4(X,Y,Z,X);

		public Double4 XYZY => new Double4(X,Y,Z,Y);

		public Double4 XYZZ => new Double4(X,Y,Z,Z);

		public Double4 XYZW => new Double4(X,Y,Z,W);

		public Double4 XYWX => new Double4(X,Y,W,X);

		public Double4 XYWY => new Double4(X,Y,W,Y);

		public Double4 XYWZ => new Double4(X,Y,W,Z);

		public Double4 XYWW => new Double4(X,Y,W,W);

		public Double4 XZXX => new Double4(X,Z,X,X);

		public Double4 XZXY => new Double4(X,Z,X,Y);

		public Double4 XZXZ => new Double4(X,Z,X,Z);

		public Double4 XZXW => new Double4(X,Z,X,W);

		public Double4 XZYX => new Double4(X,Z,Y,X);

		public Double4 XZYY => new Double4(X,Z,Y,Y);

		public Double4 XZYZ => new Double4(X,Z,Y,Z);

		public Double4 XZYW => new Double4(X,Z,Y,W);

		public Double4 XZZX => new Double4(X,Z,Z,X);

		public Double4 XZZY => new Double4(X,Z,Z,Y);

		public Double4 XZZZ => new Double4(X,Z,Z,Z);

		public Double4 XZZW => new Double4(X,Z,Z,W);

		public Double4 XZWX => new Double4(X,Z,W,X);

		public Double4 XZWY => new Double4(X,Z,W,Y);

		public Double4 XZWZ => new Double4(X,Z,W,Z);

		public Double4 XZWW => new Double4(X,Z,W,W);

		public Double4 XWXX => new Double4(X,W,X,X);

		public Double4 XWXY => new Double4(X,W,X,Y);

		public Double4 XWXZ => new Double4(X,W,X,Z);

		public Double4 XWXW => new Double4(X,W,X,W);

		public Double4 XWYX => new Double4(X,W,Y,X);

		public Double4 XWYY => new Double4(X,W,Y,Y);

		public Double4 XWYZ => new Double4(X,W,Y,Z);

		public Double4 XWYW => new Double4(X,W,Y,W);

		public Double4 XWZX => new Double4(X,W,Z,X);

		public Double4 XWZY => new Double4(X,W,Z,Y);

		public Double4 XWZZ => new Double4(X,W,Z,Z);

		public Double4 XWZW => new Double4(X,W,Z,W);

		public Double4 XWWX => new Double4(X,W,W,X);

		public Double4 XWWY => new Double4(X,W,W,Y);

		public Double4 XWWZ => new Double4(X,W,W,Z);

		public Double4 XWWW => new Double4(X,W,W,W);

		public Double4 YXXX => new Double4(Y,X,X,X);

		public Double4 YXXY => new Double4(Y,X,X,Y);

		public Double4 YXXZ => new Double4(Y,X,X,Z);

		public Double4 YXXW => new Double4(Y,X,X,W);

		public Double4 YXYX => new Double4(Y,X,Y,X);

		public Double4 YXYY => new Double4(Y,X,Y,Y);

		public Double4 YXYZ => new Double4(Y,X,Y,Z);

		public Double4 YXYW => new Double4(Y,X,Y,W);

		public Double4 YXZX => new Double4(Y,X,Z,X);

		public Double4 YXZY => new Double4(Y,X,Z,Y);

		public Double4 YXZZ => new Double4(Y,X,Z,Z);

		public Double4 YXZW => new Double4(Y,X,Z,W);

		public Double4 YXWX => new Double4(Y,X,W,X);

		public Double4 YXWY => new Double4(Y,X,W,Y);

		public Double4 YXWZ => new Double4(Y,X,W,Z);

		public Double4 YXWW => new Double4(Y,X,W,W);

		public Double4 YYXX => new Double4(Y,Y,X,X);

		public Double4 YYXY => new Double4(Y,Y,X,Y);

		public Double4 YYXZ => new Double4(Y,Y,X,Z);

		public Double4 YYXW => new Double4(Y,Y,X,W);

		public Double4 YYYX => new Double4(Y,Y,Y,X);

		public Double4 YYYY => new Double4(Y,Y,Y,Y);

		public Double4 YYYZ => new Double4(Y,Y,Y,Z);

		public Double4 YYYW => new Double4(Y,Y,Y,W);

		public Double4 YYZX => new Double4(Y,Y,Z,X);

		public Double4 YYZY => new Double4(Y,Y,Z,Y);

		public Double4 YYZZ => new Double4(Y,Y,Z,Z);

		public Double4 YYZW => new Double4(Y,Y,Z,W);

		public Double4 YYWX => new Double4(Y,Y,W,X);

		public Double4 YYWY => new Double4(Y,Y,W,Y);

		public Double4 YYWZ => new Double4(Y,Y,W,Z);

		public Double4 YYWW => new Double4(Y,Y,W,W);

		public Double4 YZXX => new Double4(Y,Z,X,X);

		public Double4 YZXY => new Double4(Y,Z,X,Y);

		public Double4 YZXZ => new Double4(Y,Z,X,Z);

		public Double4 YZXW => new Double4(Y,Z,X,W);

		public Double4 YZYX => new Double4(Y,Z,Y,X);

		public Double4 YZYY => new Double4(Y,Z,Y,Y);

		public Double4 YZYZ => new Double4(Y,Z,Y,Z);

		public Double4 YZYW => new Double4(Y,Z,Y,W);

		public Double4 YZZX => new Double4(Y,Z,Z,X);

		public Double4 YZZY => new Double4(Y,Z,Z,Y);

		public Double4 YZZZ => new Double4(Y,Z,Z,Z);

		public Double4 YZZW => new Double4(Y,Z,Z,W);

		public Double4 YZWX => new Double4(Y,Z,W,X);

		public Double4 YZWY => new Double4(Y,Z,W,Y);

		public Double4 YZWZ => new Double4(Y,Z,W,Z);

		public Double4 YZWW => new Double4(Y,Z,W,W);

		public Double4 YWXX => new Double4(Y,W,X,X);

		public Double4 YWXY => new Double4(Y,W,X,Y);

		public Double4 YWXZ => new Double4(Y,W,X,Z);

		public Double4 YWXW => new Double4(Y,W,X,W);

		public Double4 YWYX => new Double4(Y,W,Y,X);

		public Double4 YWYY => new Double4(Y,W,Y,Y);

		public Double4 YWYZ => new Double4(Y,W,Y,Z);

		public Double4 YWYW => new Double4(Y,W,Y,W);

		public Double4 YWZX => new Double4(Y,W,Z,X);

		public Double4 YWZY => new Double4(Y,W,Z,Y);

		public Double4 YWZZ => new Double4(Y,W,Z,Z);

		public Double4 YWZW => new Double4(Y,W,Z,W);

		public Double4 YWWX => new Double4(Y,W,W,X);

		public Double4 YWWY => new Double4(Y,W,W,Y);

		public Double4 YWWZ => new Double4(Y,W,W,Z);

		public Double4 YWWW => new Double4(Y,W,W,W);

		public Double4 ZXXX => new Double4(Z,X,X,X);

		public Double4 ZXXY => new Double4(Z,X,X,Y);

		public Double4 ZXXZ => new Double4(Z,X,X,Z);

		public Double4 ZXXW => new Double4(Z,X,X,W);

		public Double4 ZXYX => new Double4(Z,X,Y,X);

		public Double4 ZXYY => new Double4(Z,X,Y,Y);

		public Double4 ZXYZ => new Double4(Z,X,Y,Z);

		public Double4 ZXYW => new Double4(Z,X,Y,W);

		public Double4 ZXZX => new Double4(Z,X,Z,X);

		public Double4 ZXZY => new Double4(Z,X,Z,Y);

		public Double4 ZXZZ => new Double4(Z,X,Z,Z);

		public Double4 ZXZW => new Double4(Z,X,Z,W);

		public Double4 ZXWX => new Double4(Z,X,W,X);

		public Double4 ZXWY => new Double4(Z,X,W,Y);

		public Double4 ZXWZ => new Double4(Z,X,W,Z);

		public Double4 ZXWW => new Double4(Z,X,W,W);

		public Double4 ZYXX => new Double4(Z,Y,X,X);

		public Double4 ZYXY => new Double4(Z,Y,X,Y);

		public Double4 ZYXZ => new Double4(Z,Y,X,Z);

		public Double4 ZYXW => new Double4(Z,Y,X,W);

		public Double4 ZYYX => new Double4(Z,Y,Y,X);

		public Double4 ZYYY => new Double4(Z,Y,Y,Y);

		public Double4 ZYYZ => new Double4(Z,Y,Y,Z);

		public Double4 ZYYW => new Double4(Z,Y,Y,W);

		public Double4 ZYZX => new Double4(Z,Y,Z,X);

		public Double4 ZYZY => new Double4(Z,Y,Z,Y);

		public Double4 ZYZZ => new Double4(Z,Y,Z,Z);

		public Double4 ZYZW => new Double4(Z,Y,Z,W);

		public Double4 ZYWX => new Double4(Z,Y,W,X);

		public Double4 ZYWY => new Double4(Z,Y,W,Y);

		public Double4 ZYWZ => new Double4(Z,Y,W,Z);

		public Double4 ZYWW => new Double4(Z,Y,W,W);

		public Double4 ZZXX => new Double4(Z,Z,X,X);

		public Double4 ZZXY => new Double4(Z,Z,X,Y);

		public Double4 ZZXZ => new Double4(Z,Z,X,Z);

		public Double4 ZZXW => new Double4(Z,Z,X,W);

		public Double4 ZZYX => new Double4(Z,Z,Y,X);

		public Double4 ZZYY => new Double4(Z,Z,Y,Y);

		public Double4 ZZYZ => new Double4(Z,Z,Y,Z);

		public Double4 ZZYW => new Double4(Z,Z,Y,W);

		public Double4 ZZZX => new Double4(Z,Z,Z,X);

		public Double4 ZZZY => new Double4(Z,Z,Z,Y);

		public Double4 ZZZZ => new Double4(Z,Z,Z,Z);

		public Double4 ZZZW => new Double4(Z,Z,Z,W);

		public Double4 ZZWX => new Double4(Z,Z,W,X);

		public Double4 ZZWY => new Double4(Z,Z,W,Y);

		public Double4 ZZWZ => new Double4(Z,Z,W,Z);

		public Double4 ZZWW => new Double4(Z,Z,W,W);

		public Double4 ZWXX => new Double4(Z,W,X,X);

		public Double4 ZWXY => new Double4(Z,W,X,Y);

		public Double4 ZWXZ => new Double4(Z,W,X,Z);

		public Double4 ZWXW => new Double4(Z,W,X,W);

		public Double4 ZWYX => new Double4(Z,W,Y,X);

		public Double4 ZWYY => new Double4(Z,W,Y,Y);

		public Double4 ZWYZ => new Double4(Z,W,Y,Z);

		public Double4 ZWYW => new Double4(Z,W,Y,W);

		public Double4 ZWZX => new Double4(Z,W,Z,X);

		public Double4 ZWZY => new Double4(Z,W,Z,Y);

		public Double4 ZWZZ => new Double4(Z,W,Z,Z);

		public Double4 ZWZW => new Double4(Z,W,Z,W);

		public Double4 ZWWX => new Double4(Z,W,W,X);

		public Double4 ZWWY => new Double4(Z,W,W,Y);

		public Double4 ZWWZ => new Double4(Z,W,W,Z);

		public Double4 ZWWW => new Double4(Z,W,W,W);

		public Double4 WXXX => new Double4(W,X,X,X);

		public Double4 WXXY => new Double4(W,X,X,Y);

		public Double4 WXXZ => new Double4(W,X,X,Z);

		public Double4 WXXW => new Double4(W,X,X,W);

		public Double4 WXYX => new Double4(W,X,Y,X);

		public Double4 WXYY => new Double4(W,X,Y,Y);

		public Double4 WXYZ => new Double4(W,X,Y,Z);

		public Double4 WXYW => new Double4(W,X,Y,W);

		public Double4 WXZX => new Double4(W,X,Z,X);

		public Double4 WXZY => new Double4(W,X,Z,Y);

		public Double4 WXZZ => new Double4(W,X,Z,Z);

		public Double4 WXZW => new Double4(W,X,Z,W);

		public Double4 WXWX => new Double4(W,X,W,X);

		public Double4 WXWY => new Double4(W,X,W,Y);

		public Double4 WXWZ => new Double4(W,X,W,Z);

		public Double4 WXWW => new Double4(W,X,W,W);

		public Double4 WYXX => new Double4(W,Y,X,X);

		public Double4 WYXY => new Double4(W,Y,X,Y);

		public Double4 WYXZ => new Double4(W,Y,X,Z);

		public Double4 WYXW => new Double4(W,Y,X,W);

		public Double4 WYYX => new Double4(W,Y,Y,X);

		public Double4 WYYY => new Double4(W,Y,Y,Y);

		public Double4 WYYZ => new Double4(W,Y,Y,Z);

		public Double4 WYYW => new Double4(W,Y,Y,W);

		public Double4 WYZX => new Double4(W,Y,Z,X);

		public Double4 WYZY => new Double4(W,Y,Z,Y);

		public Double4 WYZZ => new Double4(W,Y,Z,Z);

		public Double4 WYZW => new Double4(W,Y,Z,W);

		public Double4 WYWX => new Double4(W,Y,W,X);

		public Double4 WYWY => new Double4(W,Y,W,Y);

		public Double4 WYWZ => new Double4(W,Y,W,Z);

		public Double4 WYWW => new Double4(W,Y,W,W);

		public Double4 WZXX => new Double4(W,Z,X,X);

		public Double4 WZXY => new Double4(W,Z,X,Y);

		public Double4 WZXZ => new Double4(W,Z,X,Z);

		public Double4 WZXW => new Double4(W,Z,X,W);

		public Double4 WZYX => new Double4(W,Z,Y,X);

		public Double4 WZYY => new Double4(W,Z,Y,Y);

		public Double4 WZYZ => new Double4(W,Z,Y,Z);

		public Double4 WZYW => new Double4(W,Z,Y,W);

		public Double4 WZZX => new Double4(W,Z,Z,X);

		public Double4 WZZY => new Double4(W,Z,Z,Y);

		public Double4 WZZZ => new Double4(W,Z,Z,Z);

		public Double4 WZZW => new Double4(W,Z,Z,W);

		public Double4 WZWX => new Double4(W,Z,W,X);

		public Double4 WZWY => new Double4(W,Z,W,Y);

		public Double4 WZWZ => new Double4(W,Z,W,Z);

		public Double4 WZWW => new Double4(W,Z,W,W);

		public Double4 WWXX => new Double4(W,W,X,X);

		public Double4 WWXY => new Double4(W,W,X,Y);

		public Double4 WWXZ => new Double4(W,W,X,Z);

		public Double4 WWXW => new Double4(W,W,X,W);

		public Double4 WWYX => new Double4(W,W,Y,X);

		public Double4 WWYY => new Double4(W,W,Y,Y);

		public Double4 WWYZ => new Double4(W,W,Y,Z);

		public Double4 WWYW => new Double4(W,W,Y,W);

		public Double4 WWZX => new Double4(W,W,Z,X);

		public Double4 WWZY => new Double4(W,W,Z,Y);

		public Double4 WWZZ => new Double4(W,W,Z,Z);

		public Double4 WWZW => new Double4(W,W,Z,W);

		public Double4 WWWX => new Double4(W,W,W,X);

		public Double4 WWWY => new Double4(W,W,W,Y);

		public Double4 WWWZ => new Double4(W,W,W,Z);

		public Double4 WWWW => new Double4(W,W,W,W);

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

		public double A
		{
			get => W;
			set => W = value;
		}

		public Double2 RR => new Double2(X,X);

		public Double2 RG => new Double2(X,Y);

		public Double2 RB => new Double2(X,Z);

		public Double2 RA => new Double2(X,W);

		public Double2 GR => new Double2(Y,X);

		public Double2 GG => new Double2(Y,Y);

		public Double2 GB => new Double2(Y,Z);

		public Double2 GA => new Double2(Y,W);

		public Double2 BR => new Double2(Z,X);

		public Double2 BG => new Double2(Z,Y);

		public Double2 BB => new Double2(Z,Z);

		public Double2 BA => new Double2(Z,W);

		public Double2 AR => new Double2(W,X);

		public Double2 AG => new Double2(W,Y);

		public Double2 AB => new Double2(W,Z);

		public Double2 AA => new Double2(W,W);

		public Double3 RRR => new Double3(X,X,X);

		public Double3 RRG => new Double3(X,X,Y);

		public Double3 RRB => new Double3(X,X,Z);

		public Double3 RRA => new Double3(X,X,W);

		public Double3 RGR => new Double3(X,Y,X);

		public Double3 RGG => new Double3(X,Y,Y);

		public Double3 RGB => new Double3(X,Y,Z);

		public Double3 RGA => new Double3(X,Y,W);

		public Double3 RBR => new Double3(X,Z,X);

		public Double3 RBG => new Double3(X,Z,Y);

		public Double3 RBB => new Double3(X,Z,Z);

		public Double3 RBA => new Double3(X,Z,W);

		public Double3 RAR => new Double3(X,W,X);

		public Double3 RAG => new Double3(X,W,Y);

		public Double3 RAB => new Double3(X,W,Z);

		public Double3 RAA => new Double3(X,W,W);

		public Double3 GRR => new Double3(Y,X,X);

		public Double3 GRG => new Double3(Y,X,Y);

		public Double3 GRB => new Double3(Y,X,Z);

		public Double3 GRA => new Double3(Y,X,W);

		public Double3 GGR => new Double3(Y,Y,X);

		public Double3 GGG => new Double3(Y,Y,Y);

		public Double3 GGB => new Double3(Y,Y,Z);

		public Double3 GGA => new Double3(Y,Y,W);

		public Double3 GBR => new Double3(Y,Z,X);

		public Double3 GBG => new Double3(Y,Z,Y);

		public Double3 GBB => new Double3(Y,Z,Z);

		public Double3 GBA => new Double3(Y,Z,W);

		public Double3 GAR => new Double3(Y,W,X);

		public Double3 GAG => new Double3(Y,W,Y);

		public Double3 GAB => new Double3(Y,W,Z);

		public Double3 GAA => new Double3(Y,W,W);

		public Double3 BRR => new Double3(Z,X,X);

		public Double3 BRG => new Double3(Z,X,Y);

		public Double3 BRB => new Double3(Z,X,Z);

		public Double3 BRA => new Double3(Z,X,W);

		public Double3 BGR => new Double3(Z,Y,X);

		public Double3 BGG => new Double3(Z,Y,Y);

		public Double3 BGB => new Double3(Z,Y,Z);

		public Double3 BGA => new Double3(Z,Y,W);

		public Double3 BBR => new Double3(Z,Z,X);

		public Double3 BBG => new Double3(Z,Z,Y);

		public Double3 BBB => new Double3(Z,Z,Z);

		public Double3 BBA => new Double3(Z,Z,W);

		public Double3 BAR => new Double3(Z,W,X);

		public Double3 BAG => new Double3(Z,W,Y);

		public Double3 BAB => new Double3(Z,W,Z);

		public Double3 BAA => new Double3(Z,W,W);

		public Double3 ARR => new Double3(W,X,X);

		public Double3 ARG => new Double3(W,X,Y);

		public Double3 ARB => new Double3(W,X,Z);

		public Double3 ARA => new Double3(W,X,W);

		public Double3 AGR => new Double3(W,Y,X);

		public Double3 AGG => new Double3(W,Y,Y);

		public Double3 AGB => new Double3(W,Y,Z);

		public Double3 AGA => new Double3(W,Y,W);

		public Double3 ABR => new Double3(W,Z,X);

		public Double3 ABG => new Double3(W,Z,Y);

		public Double3 ABB => new Double3(W,Z,Z);

		public Double3 ABA => new Double3(W,Z,W);

		public Double3 AAR => new Double3(W,W,X);

		public Double3 AAG => new Double3(W,W,Y);

		public Double3 AAB => new Double3(W,W,Z);

		public Double3 AAA => new Double3(W,W,W);

		public Double4 RRRR => new Double4(X,X,X,X);

		public Double4 RRRG => new Double4(X,X,X,Y);

		public Double4 RRRB => new Double4(X,X,X,Z);

		public Double4 RRRA => new Double4(X,X,X,W);

		public Double4 RRGR => new Double4(X,X,Y,X);

		public Double4 RRGG => new Double4(X,X,Y,Y);

		public Double4 RRGB => new Double4(X,X,Y,Z);

		public Double4 RRGA => new Double4(X,X,Y,W);

		public Double4 RRBR => new Double4(X,X,Z,X);

		public Double4 RRBG => new Double4(X,X,Z,Y);

		public Double4 RRBB => new Double4(X,X,Z,Z);

		public Double4 RRBA => new Double4(X,X,Z,W);

		public Double4 RRAR => new Double4(X,X,W,X);

		public Double4 RRAG => new Double4(X,X,W,Y);

		public Double4 RRAB => new Double4(X,X,W,Z);

		public Double4 RRAA => new Double4(X,X,W,W);

		public Double4 RGRR => new Double4(X,Y,X,X);

		public Double4 RGRG => new Double4(X,Y,X,Y);

		public Double4 RGRB => new Double4(X,Y,X,Z);

		public Double4 RGRA => new Double4(X,Y,X,W);

		public Double4 RGGR => new Double4(X,Y,Y,X);

		public Double4 RGGG => new Double4(X,Y,Y,Y);

		public Double4 RGGB => new Double4(X,Y,Y,Z);

		public Double4 RGGA => new Double4(X,Y,Y,W);

		public Double4 RGBR => new Double4(X,Y,Z,X);

		public Double4 RGBG => new Double4(X,Y,Z,Y);

		public Double4 RGBB => new Double4(X,Y,Z,Z);

		public Double4 RGBA => new Double4(X,Y,Z,W);

		public Double4 RGAR => new Double4(X,Y,W,X);

		public Double4 RGAG => new Double4(X,Y,W,Y);

		public Double4 RGAB => new Double4(X,Y,W,Z);

		public Double4 RGAA => new Double4(X,Y,W,W);

		public Double4 RBRR => new Double4(X,Z,X,X);

		public Double4 RBRG => new Double4(X,Z,X,Y);

		public Double4 RBRB => new Double4(X,Z,X,Z);

		public Double4 RBRA => new Double4(X,Z,X,W);

		public Double4 RBGR => new Double4(X,Z,Y,X);

		public Double4 RBGG => new Double4(X,Z,Y,Y);

		public Double4 RBGB => new Double4(X,Z,Y,Z);

		public Double4 RBGA => new Double4(X,Z,Y,W);

		public Double4 RBBR => new Double4(X,Z,Z,X);

		public Double4 RBBG => new Double4(X,Z,Z,Y);

		public Double4 RBBB => new Double4(X,Z,Z,Z);

		public Double4 RBBA => new Double4(X,Z,Z,W);

		public Double4 RBAR => new Double4(X,Z,W,X);

		public Double4 RBAG => new Double4(X,Z,W,Y);

		public Double4 RBAB => new Double4(X,Z,W,Z);

		public Double4 RBAA => new Double4(X,Z,W,W);

		public Double4 RARR => new Double4(X,W,X,X);

		public Double4 RARG => new Double4(X,W,X,Y);

		public Double4 RARB => new Double4(X,W,X,Z);

		public Double4 RARA => new Double4(X,W,X,W);

		public Double4 RAGR => new Double4(X,W,Y,X);

		public Double4 RAGG => new Double4(X,W,Y,Y);

		public Double4 RAGB => new Double4(X,W,Y,Z);

		public Double4 RAGA => new Double4(X,W,Y,W);

		public Double4 RABR => new Double4(X,W,Z,X);

		public Double4 RABG => new Double4(X,W,Z,Y);

		public Double4 RABB => new Double4(X,W,Z,Z);

		public Double4 RABA => new Double4(X,W,Z,W);

		public Double4 RAAR => new Double4(X,W,W,X);

		public Double4 RAAG => new Double4(X,W,W,Y);

		public Double4 RAAB => new Double4(X,W,W,Z);

		public Double4 RAAA => new Double4(X,W,W,W);

		public Double4 GRRR => new Double4(Y,X,X,X);

		public Double4 GRRG => new Double4(Y,X,X,Y);

		public Double4 GRRB => new Double4(Y,X,X,Z);

		public Double4 GRRA => new Double4(Y,X,X,W);

		public Double4 GRGR => new Double4(Y,X,Y,X);

		public Double4 GRGG => new Double4(Y,X,Y,Y);

		public Double4 GRGB => new Double4(Y,X,Y,Z);

		public Double4 GRGA => new Double4(Y,X,Y,W);

		public Double4 GRBR => new Double4(Y,X,Z,X);

		public Double4 GRBG => new Double4(Y,X,Z,Y);

		public Double4 GRBB => new Double4(Y,X,Z,Z);

		public Double4 GRBA => new Double4(Y,X,Z,W);

		public Double4 GRAR => new Double4(Y,X,W,X);

		public Double4 GRAG => new Double4(Y,X,W,Y);

		public Double4 GRAB => new Double4(Y,X,W,Z);

		public Double4 GRAA => new Double4(Y,X,W,W);

		public Double4 GGRR => new Double4(Y,Y,X,X);

		public Double4 GGRG => new Double4(Y,Y,X,Y);

		public Double4 GGRB => new Double4(Y,Y,X,Z);

		public Double4 GGRA => new Double4(Y,Y,X,W);

		public Double4 GGGR => new Double4(Y,Y,Y,X);

		public Double4 GGGG => new Double4(Y,Y,Y,Y);

		public Double4 GGGB => new Double4(Y,Y,Y,Z);

		public Double4 GGGA => new Double4(Y,Y,Y,W);

		public Double4 GGBR => new Double4(Y,Y,Z,X);

		public Double4 GGBG => new Double4(Y,Y,Z,Y);

		public Double4 GGBB => new Double4(Y,Y,Z,Z);

		public Double4 GGBA => new Double4(Y,Y,Z,W);

		public Double4 GGAR => new Double4(Y,Y,W,X);

		public Double4 GGAG => new Double4(Y,Y,W,Y);

		public Double4 GGAB => new Double4(Y,Y,W,Z);

		public Double4 GGAA => new Double4(Y,Y,W,W);

		public Double4 GBRR => new Double4(Y,Z,X,X);

		public Double4 GBRG => new Double4(Y,Z,X,Y);

		public Double4 GBRB => new Double4(Y,Z,X,Z);

		public Double4 GBRA => new Double4(Y,Z,X,W);

		public Double4 GBGR => new Double4(Y,Z,Y,X);

		public Double4 GBGG => new Double4(Y,Z,Y,Y);

		public Double4 GBGB => new Double4(Y,Z,Y,Z);

		public Double4 GBGA => new Double4(Y,Z,Y,W);

		public Double4 GBBR => new Double4(Y,Z,Z,X);

		public Double4 GBBG => new Double4(Y,Z,Z,Y);

		public Double4 GBBB => new Double4(Y,Z,Z,Z);

		public Double4 GBBA => new Double4(Y,Z,Z,W);

		public Double4 GBAR => new Double4(Y,Z,W,X);

		public Double4 GBAG => new Double4(Y,Z,W,Y);

		public Double4 GBAB => new Double4(Y,Z,W,Z);

		public Double4 GBAA => new Double4(Y,Z,W,W);

		public Double4 GARR => new Double4(Y,W,X,X);

		public Double4 GARG => new Double4(Y,W,X,Y);

		public Double4 GARB => new Double4(Y,W,X,Z);

		public Double4 GARA => new Double4(Y,W,X,W);

		public Double4 GAGR => new Double4(Y,W,Y,X);

		public Double4 GAGG => new Double4(Y,W,Y,Y);

		public Double4 GAGB => new Double4(Y,W,Y,Z);

		public Double4 GAGA => new Double4(Y,W,Y,W);

		public Double4 GABR => new Double4(Y,W,Z,X);

		public Double4 GABG => new Double4(Y,W,Z,Y);

		public Double4 GABB => new Double4(Y,W,Z,Z);

		public Double4 GABA => new Double4(Y,W,Z,W);

		public Double4 GAAR => new Double4(Y,W,W,X);

		public Double4 GAAG => new Double4(Y,W,W,Y);

		public Double4 GAAB => new Double4(Y,W,W,Z);

		public Double4 GAAA => new Double4(Y,W,W,W);

		public Double4 BRRR => new Double4(Z,X,X,X);

		public Double4 BRRG => new Double4(Z,X,X,Y);

		public Double4 BRRB => new Double4(Z,X,X,Z);

		public Double4 BRRA => new Double4(Z,X,X,W);

		public Double4 BRGR => new Double4(Z,X,Y,X);

		public Double4 BRGG => new Double4(Z,X,Y,Y);

		public Double4 BRGB => new Double4(Z,X,Y,Z);

		public Double4 BRGA => new Double4(Z,X,Y,W);

		public Double4 BRBR => new Double4(Z,X,Z,X);

		public Double4 BRBG => new Double4(Z,X,Z,Y);

		public Double4 BRBB => new Double4(Z,X,Z,Z);

		public Double4 BRBA => new Double4(Z,X,Z,W);

		public Double4 BRAR => new Double4(Z,X,W,X);

		public Double4 BRAG => new Double4(Z,X,W,Y);

		public Double4 BRAB => new Double4(Z,X,W,Z);

		public Double4 BRAA => new Double4(Z,X,W,W);

		public Double4 BGRR => new Double4(Z,Y,X,X);

		public Double4 BGRG => new Double4(Z,Y,X,Y);

		public Double4 BGRB => new Double4(Z,Y,X,Z);

		public Double4 BGRA => new Double4(Z,Y,X,W);

		public Double4 BGGR => new Double4(Z,Y,Y,X);

		public Double4 BGGG => new Double4(Z,Y,Y,Y);

		public Double4 BGGB => new Double4(Z,Y,Y,Z);

		public Double4 BGGA => new Double4(Z,Y,Y,W);

		public Double4 BGBR => new Double4(Z,Y,Z,X);

		public Double4 BGBG => new Double4(Z,Y,Z,Y);

		public Double4 BGBB => new Double4(Z,Y,Z,Z);

		public Double4 BGBA => new Double4(Z,Y,Z,W);

		public Double4 BGAR => new Double4(Z,Y,W,X);

		public Double4 BGAG => new Double4(Z,Y,W,Y);

		public Double4 BGAB => new Double4(Z,Y,W,Z);

		public Double4 BGAA => new Double4(Z,Y,W,W);

		public Double4 BBRR => new Double4(Z,Z,X,X);

		public Double4 BBRG => new Double4(Z,Z,X,Y);

		public Double4 BBRB => new Double4(Z,Z,X,Z);

		public Double4 BBRA => new Double4(Z,Z,X,W);

		public Double4 BBGR => new Double4(Z,Z,Y,X);

		public Double4 BBGG => new Double4(Z,Z,Y,Y);

		public Double4 BBGB => new Double4(Z,Z,Y,Z);

		public Double4 BBGA => new Double4(Z,Z,Y,W);

		public Double4 BBBR => new Double4(Z,Z,Z,X);

		public Double4 BBBG => new Double4(Z,Z,Z,Y);

		public Double4 BBBB => new Double4(Z,Z,Z,Z);

		public Double4 BBBA => new Double4(Z,Z,Z,W);

		public Double4 BBAR => new Double4(Z,Z,W,X);

		public Double4 BBAG => new Double4(Z,Z,W,Y);

		public Double4 BBAB => new Double4(Z,Z,W,Z);

		public Double4 BBAA => new Double4(Z,Z,W,W);

		public Double4 BARR => new Double4(Z,W,X,X);

		public Double4 BARG => new Double4(Z,W,X,Y);

		public Double4 BARB => new Double4(Z,W,X,Z);

		public Double4 BARA => new Double4(Z,W,X,W);

		public Double4 BAGR => new Double4(Z,W,Y,X);

		public Double4 BAGG => new Double4(Z,W,Y,Y);

		public Double4 BAGB => new Double4(Z,W,Y,Z);

		public Double4 BAGA => new Double4(Z,W,Y,W);

		public Double4 BABR => new Double4(Z,W,Z,X);

		public Double4 BABG => new Double4(Z,W,Z,Y);

		public Double4 BABB => new Double4(Z,W,Z,Z);

		public Double4 BABA => new Double4(Z,W,Z,W);

		public Double4 BAAR => new Double4(Z,W,W,X);

		public Double4 BAAG => new Double4(Z,W,W,Y);

		public Double4 BAAB => new Double4(Z,W,W,Z);

		public Double4 BAAA => new Double4(Z,W,W,W);

		public Double4 ARRR => new Double4(W,X,X,X);

		public Double4 ARRG => new Double4(W,X,X,Y);

		public Double4 ARRB => new Double4(W,X,X,Z);

		public Double4 ARRA => new Double4(W,X,X,W);

		public Double4 ARGR => new Double4(W,X,Y,X);

		public Double4 ARGG => new Double4(W,X,Y,Y);

		public Double4 ARGB => new Double4(W,X,Y,Z);

		public Double4 ARGA => new Double4(W,X,Y,W);

		public Double4 ARBR => new Double4(W,X,Z,X);

		public Double4 ARBG => new Double4(W,X,Z,Y);

		public Double4 ARBB => new Double4(W,X,Z,Z);

		public Double4 ARBA => new Double4(W,X,Z,W);

		public Double4 ARAR => new Double4(W,X,W,X);

		public Double4 ARAG => new Double4(W,X,W,Y);

		public Double4 ARAB => new Double4(W,X,W,Z);

		public Double4 ARAA => new Double4(W,X,W,W);

		public Double4 AGRR => new Double4(W,Y,X,X);

		public Double4 AGRG => new Double4(W,Y,X,Y);

		public Double4 AGRB => new Double4(W,Y,X,Z);

		public Double4 AGRA => new Double4(W,Y,X,W);

		public Double4 AGGR => new Double4(W,Y,Y,X);

		public Double4 AGGG => new Double4(W,Y,Y,Y);

		public Double4 AGGB => new Double4(W,Y,Y,Z);

		public Double4 AGGA => new Double4(W,Y,Y,W);

		public Double4 AGBR => new Double4(W,Y,Z,X);

		public Double4 AGBG => new Double4(W,Y,Z,Y);

		public Double4 AGBB => new Double4(W,Y,Z,Z);

		public Double4 AGBA => new Double4(W,Y,Z,W);

		public Double4 AGAR => new Double4(W,Y,W,X);

		public Double4 AGAG => new Double4(W,Y,W,Y);

		public Double4 AGAB => new Double4(W,Y,W,Z);

		public Double4 AGAA => new Double4(W,Y,W,W);

		public Double4 ABRR => new Double4(W,Z,X,X);

		public Double4 ABRG => new Double4(W,Z,X,Y);

		public Double4 ABRB => new Double4(W,Z,X,Z);

		public Double4 ABRA => new Double4(W,Z,X,W);

		public Double4 ABGR => new Double4(W,Z,Y,X);

		public Double4 ABGG => new Double4(W,Z,Y,Y);

		public Double4 ABGB => new Double4(W,Z,Y,Z);

		public Double4 ABGA => new Double4(W,Z,Y,W);

		public Double4 ABBR => new Double4(W,Z,Z,X);

		public Double4 ABBG => new Double4(W,Z,Z,Y);

		public Double4 ABBB => new Double4(W,Z,Z,Z);

		public Double4 ABBA => new Double4(W,Z,Z,W);

		public Double4 ABAR => new Double4(W,Z,W,X);

		public Double4 ABAG => new Double4(W,Z,W,Y);

		public Double4 ABAB => new Double4(W,Z,W,Z);

		public Double4 ABAA => new Double4(W,Z,W,W);

		public Double4 AARR => new Double4(W,W,X,X);

		public Double4 AARG => new Double4(W,W,X,Y);

		public Double4 AARB => new Double4(W,W,X,Z);

		public Double4 AARA => new Double4(W,W,X,W);

		public Double4 AAGR => new Double4(W,W,Y,X);

		public Double4 AAGG => new Double4(W,W,Y,Y);

		public Double4 AAGB => new Double4(W,W,Y,Z);

		public Double4 AAGA => new Double4(W,W,Y,W);

		public Double4 AABR => new Double4(W,W,Z,X);

		public Double4 AABG => new Double4(W,W,Z,Y);

		public Double4 AABB => new Double4(W,W,Z,Z);

		public Double4 AABA => new Double4(W,W,Z,W);

		public Double4 AAAR => new Double4(W,W,W,X);

		public Double4 AAAG => new Double4(W,W,W,Y);

		public Double4 AAAB => new Double4(W,W,W,Z);

		public Double4 AAAA => new Double4(W,W,W,W);

		public static Double4 operator +(Double4 a, Double4 b)
		{
			return new Double4()
			{
				X = a.X + b.X,
				Y = a.Y + b.Y,
				Z = a.Z + b.Z,
				W = a.W + b.W,
			};
		}

		public static Double4 operator -(Double4 a, Double4 b)
		{
			return new Double4()
			{
				X = a.X - b.X,
				Y = a.Y - b.Y,
				Z = a.Z - b.Z,
				W = a.W - b.W,
			};
		}

		public static Double4 operator *(Double4 a, Double4 b)
		{
			return new Double4()
			{
				X = a.X * b.X,
				Y = a.Y * b.Y,
				Z = a.Z * b.Z,
				W = a.W * b.W,
			};
		}

		public static Double4 operator /(Double4 a, Double4 b)
		{
			return new Double4()
			{
				X = a.X / b.X,
				Y = a.Y / b.Y,
				Z = a.Z / b.Z,
				W = a.W / b.W,
			};
		}

	}
}
