using System.Runtime.InteropServices;

namespace SharpShader
{
	[StructLayout(LayoutKind.Sequential)]
	public struct Vector4
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
        /// The W component.
        /// </summary>
		public float W;

        /// <summary>
        /// Creates a new instance of <see cref="Vector4"/>.
        /// </summary>
		public Vector4(float x, float y, float z, float w)
		{
			X = x;
			Y = y;
			Z = z;
			W = w;
		}

		public Vector2 XX => new Vector2(X,X);

		public Vector2 XY => new Vector2(X,Y);

		public Vector2 XZ => new Vector2(X,Z);

		public Vector2 XW => new Vector2(X,W);

		public Vector2 YX => new Vector2(Y,X);

		public Vector2 YY => new Vector2(Y,Y);

		public Vector2 YZ => new Vector2(Y,Z);

		public Vector2 YW => new Vector2(Y,W);

		public Vector2 ZX => new Vector2(Z,X);

		public Vector2 ZY => new Vector2(Z,Y);

		public Vector2 ZZ => new Vector2(Z,Z);

		public Vector2 ZW => new Vector2(Z,W);

		public Vector2 WX => new Vector2(W,X);

		public Vector2 WY => new Vector2(W,Y);

		public Vector2 WZ => new Vector2(W,Z);

		public Vector2 WW => new Vector2(W,W);

		public Vector3 XXX => new Vector3(X,X,X);

		public Vector3 XXY => new Vector3(X,X,Y);

		public Vector3 XXZ => new Vector3(X,X,Z);

		public Vector3 XXW => new Vector3(X,X,W);

		public Vector3 XYX => new Vector3(X,Y,X);

		public Vector3 XYY => new Vector3(X,Y,Y);

		public Vector3 XYZ => new Vector3(X,Y,Z);

		public Vector3 XYW => new Vector3(X,Y,W);

		public Vector3 XZX => new Vector3(X,Z,X);

		public Vector3 XZY => new Vector3(X,Z,Y);

		public Vector3 XZZ => new Vector3(X,Z,Z);

		public Vector3 XZW => new Vector3(X,Z,W);

		public Vector3 XWX => new Vector3(X,W,X);

		public Vector3 XWY => new Vector3(X,W,Y);

		public Vector3 XWZ => new Vector3(X,W,Z);

		public Vector3 XWW => new Vector3(X,W,W);

		public Vector3 YXX => new Vector3(Y,X,X);

		public Vector3 YXY => new Vector3(Y,X,Y);

		public Vector3 YXZ => new Vector3(Y,X,Z);

		public Vector3 YXW => new Vector3(Y,X,W);

		public Vector3 YYX => new Vector3(Y,Y,X);

		public Vector3 YYY => new Vector3(Y,Y,Y);

		public Vector3 YYZ => new Vector3(Y,Y,Z);

		public Vector3 YYW => new Vector3(Y,Y,W);

		public Vector3 YZX => new Vector3(Y,Z,X);

		public Vector3 YZY => new Vector3(Y,Z,Y);

		public Vector3 YZZ => new Vector3(Y,Z,Z);

		public Vector3 YZW => new Vector3(Y,Z,W);

		public Vector3 YWX => new Vector3(Y,W,X);

		public Vector3 YWY => new Vector3(Y,W,Y);

		public Vector3 YWZ => new Vector3(Y,W,Z);

		public Vector3 YWW => new Vector3(Y,W,W);

		public Vector3 ZXX => new Vector3(Z,X,X);

		public Vector3 ZXY => new Vector3(Z,X,Y);

		public Vector3 ZXZ => new Vector3(Z,X,Z);

		public Vector3 ZXW => new Vector3(Z,X,W);

		public Vector3 ZYX => new Vector3(Z,Y,X);

		public Vector3 ZYY => new Vector3(Z,Y,Y);

		public Vector3 ZYZ => new Vector3(Z,Y,Z);

		public Vector3 ZYW => new Vector3(Z,Y,W);

		public Vector3 ZZX => new Vector3(Z,Z,X);

		public Vector3 ZZY => new Vector3(Z,Z,Y);

		public Vector3 ZZZ => new Vector3(Z,Z,Z);

		public Vector3 ZZW => new Vector3(Z,Z,W);

		public Vector3 ZWX => new Vector3(Z,W,X);

		public Vector3 ZWY => new Vector3(Z,W,Y);

		public Vector3 ZWZ => new Vector3(Z,W,Z);

		public Vector3 ZWW => new Vector3(Z,W,W);

		public Vector3 WXX => new Vector3(W,X,X);

		public Vector3 WXY => new Vector3(W,X,Y);

		public Vector3 WXZ => new Vector3(W,X,Z);

		public Vector3 WXW => new Vector3(W,X,W);

		public Vector3 WYX => new Vector3(W,Y,X);

		public Vector3 WYY => new Vector3(W,Y,Y);

		public Vector3 WYZ => new Vector3(W,Y,Z);

		public Vector3 WYW => new Vector3(W,Y,W);

		public Vector3 WZX => new Vector3(W,Z,X);

		public Vector3 WZY => new Vector3(W,Z,Y);

		public Vector3 WZZ => new Vector3(W,Z,Z);

		public Vector3 WZW => new Vector3(W,Z,W);

		public Vector3 WWX => new Vector3(W,W,X);

		public Vector3 WWY => new Vector3(W,W,Y);

		public Vector3 WWZ => new Vector3(W,W,Z);

		public Vector3 WWW => new Vector3(W,W,W);

		public Vector4 XXXX => new Vector4(X,X,X,X);

		public Vector4 XXXY => new Vector4(X,X,X,Y);

		public Vector4 XXXZ => new Vector4(X,X,X,Z);

		public Vector4 XXXW => new Vector4(X,X,X,W);

		public Vector4 XXYX => new Vector4(X,X,Y,X);

		public Vector4 XXYY => new Vector4(X,X,Y,Y);

		public Vector4 XXYZ => new Vector4(X,X,Y,Z);

		public Vector4 XXYW => new Vector4(X,X,Y,W);

		public Vector4 XXZX => new Vector4(X,X,Z,X);

		public Vector4 XXZY => new Vector4(X,X,Z,Y);

		public Vector4 XXZZ => new Vector4(X,X,Z,Z);

		public Vector4 XXZW => new Vector4(X,X,Z,W);

		public Vector4 XXWX => new Vector4(X,X,W,X);

		public Vector4 XXWY => new Vector4(X,X,W,Y);

		public Vector4 XXWZ => new Vector4(X,X,W,Z);

		public Vector4 XXWW => new Vector4(X,X,W,W);

		public Vector4 XYXX => new Vector4(X,Y,X,X);

		public Vector4 XYXY => new Vector4(X,Y,X,Y);

		public Vector4 XYXZ => new Vector4(X,Y,X,Z);

		public Vector4 XYXW => new Vector4(X,Y,X,W);

		public Vector4 XYYX => new Vector4(X,Y,Y,X);

		public Vector4 XYYY => new Vector4(X,Y,Y,Y);

		public Vector4 XYYZ => new Vector4(X,Y,Y,Z);

		public Vector4 XYYW => new Vector4(X,Y,Y,W);

		public Vector4 XYZX => new Vector4(X,Y,Z,X);

		public Vector4 XYZY => new Vector4(X,Y,Z,Y);

		public Vector4 XYZZ => new Vector4(X,Y,Z,Z);

		public Vector4 XYZW => new Vector4(X,Y,Z,W);

		public Vector4 XYWX => new Vector4(X,Y,W,X);

		public Vector4 XYWY => new Vector4(X,Y,W,Y);

		public Vector4 XYWZ => new Vector4(X,Y,W,Z);

		public Vector4 XYWW => new Vector4(X,Y,W,W);

		public Vector4 XZXX => new Vector4(X,Z,X,X);

		public Vector4 XZXY => new Vector4(X,Z,X,Y);

		public Vector4 XZXZ => new Vector4(X,Z,X,Z);

		public Vector4 XZXW => new Vector4(X,Z,X,W);

		public Vector4 XZYX => new Vector4(X,Z,Y,X);

		public Vector4 XZYY => new Vector4(X,Z,Y,Y);

		public Vector4 XZYZ => new Vector4(X,Z,Y,Z);

		public Vector4 XZYW => new Vector4(X,Z,Y,W);

		public Vector4 XZZX => new Vector4(X,Z,Z,X);

		public Vector4 XZZY => new Vector4(X,Z,Z,Y);

		public Vector4 XZZZ => new Vector4(X,Z,Z,Z);

		public Vector4 XZZW => new Vector4(X,Z,Z,W);

		public Vector4 XZWX => new Vector4(X,Z,W,X);

		public Vector4 XZWY => new Vector4(X,Z,W,Y);

		public Vector4 XZWZ => new Vector4(X,Z,W,Z);

		public Vector4 XZWW => new Vector4(X,Z,W,W);

		public Vector4 XWXX => new Vector4(X,W,X,X);

		public Vector4 XWXY => new Vector4(X,W,X,Y);

		public Vector4 XWXZ => new Vector4(X,W,X,Z);

		public Vector4 XWXW => new Vector4(X,W,X,W);

		public Vector4 XWYX => new Vector4(X,W,Y,X);

		public Vector4 XWYY => new Vector4(X,W,Y,Y);

		public Vector4 XWYZ => new Vector4(X,W,Y,Z);

		public Vector4 XWYW => new Vector4(X,W,Y,W);

		public Vector4 XWZX => new Vector4(X,W,Z,X);

		public Vector4 XWZY => new Vector4(X,W,Z,Y);

		public Vector4 XWZZ => new Vector4(X,W,Z,Z);

		public Vector4 XWZW => new Vector4(X,W,Z,W);

		public Vector4 XWWX => new Vector4(X,W,W,X);

		public Vector4 XWWY => new Vector4(X,W,W,Y);

		public Vector4 XWWZ => new Vector4(X,W,W,Z);

		public Vector4 XWWW => new Vector4(X,W,W,W);

		public Vector4 YXXX => new Vector4(Y,X,X,X);

		public Vector4 YXXY => new Vector4(Y,X,X,Y);

		public Vector4 YXXZ => new Vector4(Y,X,X,Z);

		public Vector4 YXXW => new Vector4(Y,X,X,W);

		public Vector4 YXYX => new Vector4(Y,X,Y,X);

		public Vector4 YXYY => new Vector4(Y,X,Y,Y);

		public Vector4 YXYZ => new Vector4(Y,X,Y,Z);

		public Vector4 YXYW => new Vector4(Y,X,Y,W);

		public Vector4 YXZX => new Vector4(Y,X,Z,X);

		public Vector4 YXZY => new Vector4(Y,X,Z,Y);

		public Vector4 YXZZ => new Vector4(Y,X,Z,Z);

		public Vector4 YXZW => new Vector4(Y,X,Z,W);

		public Vector4 YXWX => new Vector4(Y,X,W,X);

		public Vector4 YXWY => new Vector4(Y,X,W,Y);

		public Vector4 YXWZ => new Vector4(Y,X,W,Z);

		public Vector4 YXWW => new Vector4(Y,X,W,W);

		public Vector4 YYXX => new Vector4(Y,Y,X,X);

		public Vector4 YYXY => new Vector4(Y,Y,X,Y);

		public Vector4 YYXZ => new Vector4(Y,Y,X,Z);

		public Vector4 YYXW => new Vector4(Y,Y,X,W);

		public Vector4 YYYX => new Vector4(Y,Y,Y,X);

		public Vector4 YYYY => new Vector4(Y,Y,Y,Y);

		public Vector4 YYYZ => new Vector4(Y,Y,Y,Z);

		public Vector4 YYYW => new Vector4(Y,Y,Y,W);

		public Vector4 YYZX => new Vector4(Y,Y,Z,X);

		public Vector4 YYZY => new Vector4(Y,Y,Z,Y);

		public Vector4 YYZZ => new Vector4(Y,Y,Z,Z);

		public Vector4 YYZW => new Vector4(Y,Y,Z,W);

		public Vector4 YYWX => new Vector4(Y,Y,W,X);

		public Vector4 YYWY => new Vector4(Y,Y,W,Y);

		public Vector4 YYWZ => new Vector4(Y,Y,W,Z);

		public Vector4 YYWW => new Vector4(Y,Y,W,W);

		public Vector4 YZXX => new Vector4(Y,Z,X,X);

		public Vector4 YZXY => new Vector4(Y,Z,X,Y);

		public Vector4 YZXZ => new Vector4(Y,Z,X,Z);

		public Vector4 YZXW => new Vector4(Y,Z,X,W);

		public Vector4 YZYX => new Vector4(Y,Z,Y,X);

		public Vector4 YZYY => new Vector4(Y,Z,Y,Y);

		public Vector4 YZYZ => new Vector4(Y,Z,Y,Z);

		public Vector4 YZYW => new Vector4(Y,Z,Y,W);

		public Vector4 YZZX => new Vector4(Y,Z,Z,X);

		public Vector4 YZZY => new Vector4(Y,Z,Z,Y);

		public Vector4 YZZZ => new Vector4(Y,Z,Z,Z);

		public Vector4 YZZW => new Vector4(Y,Z,Z,W);

		public Vector4 YZWX => new Vector4(Y,Z,W,X);

		public Vector4 YZWY => new Vector4(Y,Z,W,Y);

		public Vector4 YZWZ => new Vector4(Y,Z,W,Z);

		public Vector4 YZWW => new Vector4(Y,Z,W,W);

		public Vector4 YWXX => new Vector4(Y,W,X,X);

		public Vector4 YWXY => new Vector4(Y,W,X,Y);

		public Vector4 YWXZ => new Vector4(Y,W,X,Z);

		public Vector4 YWXW => new Vector4(Y,W,X,W);

		public Vector4 YWYX => new Vector4(Y,W,Y,X);

		public Vector4 YWYY => new Vector4(Y,W,Y,Y);

		public Vector4 YWYZ => new Vector4(Y,W,Y,Z);

		public Vector4 YWYW => new Vector4(Y,W,Y,W);

		public Vector4 YWZX => new Vector4(Y,W,Z,X);

		public Vector4 YWZY => new Vector4(Y,W,Z,Y);

		public Vector4 YWZZ => new Vector4(Y,W,Z,Z);

		public Vector4 YWZW => new Vector4(Y,W,Z,W);

		public Vector4 YWWX => new Vector4(Y,W,W,X);

		public Vector4 YWWY => new Vector4(Y,W,W,Y);

		public Vector4 YWWZ => new Vector4(Y,W,W,Z);

		public Vector4 YWWW => new Vector4(Y,W,W,W);

		public Vector4 ZXXX => new Vector4(Z,X,X,X);

		public Vector4 ZXXY => new Vector4(Z,X,X,Y);

		public Vector4 ZXXZ => new Vector4(Z,X,X,Z);

		public Vector4 ZXXW => new Vector4(Z,X,X,W);

		public Vector4 ZXYX => new Vector4(Z,X,Y,X);

		public Vector4 ZXYY => new Vector4(Z,X,Y,Y);

		public Vector4 ZXYZ => new Vector4(Z,X,Y,Z);

		public Vector4 ZXYW => new Vector4(Z,X,Y,W);

		public Vector4 ZXZX => new Vector4(Z,X,Z,X);

		public Vector4 ZXZY => new Vector4(Z,X,Z,Y);

		public Vector4 ZXZZ => new Vector4(Z,X,Z,Z);

		public Vector4 ZXZW => new Vector4(Z,X,Z,W);

		public Vector4 ZXWX => new Vector4(Z,X,W,X);

		public Vector4 ZXWY => new Vector4(Z,X,W,Y);

		public Vector4 ZXWZ => new Vector4(Z,X,W,Z);

		public Vector4 ZXWW => new Vector4(Z,X,W,W);

		public Vector4 ZYXX => new Vector4(Z,Y,X,X);

		public Vector4 ZYXY => new Vector4(Z,Y,X,Y);

		public Vector4 ZYXZ => new Vector4(Z,Y,X,Z);

		public Vector4 ZYXW => new Vector4(Z,Y,X,W);

		public Vector4 ZYYX => new Vector4(Z,Y,Y,X);

		public Vector4 ZYYY => new Vector4(Z,Y,Y,Y);

		public Vector4 ZYYZ => new Vector4(Z,Y,Y,Z);

		public Vector4 ZYYW => new Vector4(Z,Y,Y,W);

		public Vector4 ZYZX => new Vector4(Z,Y,Z,X);

		public Vector4 ZYZY => new Vector4(Z,Y,Z,Y);

		public Vector4 ZYZZ => new Vector4(Z,Y,Z,Z);

		public Vector4 ZYZW => new Vector4(Z,Y,Z,W);

		public Vector4 ZYWX => new Vector4(Z,Y,W,X);

		public Vector4 ZYWY => new Vector4(Z,Y,W,Y);

		public Vector4 ZYWZ => new Vector4(Z,Y,W,Z);

		public Vector4 ZYWW => new Vector4(Z,Y,W,W);

		public Vector4 ZZXX => new Vector4(Z,Z,X,X);

		public Vector4 ZZXY => new Vector4(Z,Z,X,Y);

		public Vector4 ZZXZ => new Vector4(Z,Z,X,Z);

		public Vector4 ZZXW => new Vector4(Z,Z,X,W);

		public Vector4 ZZYX => new Vector4(Z,Z,Y,X);

		public Vector4 ZZYY => new Vector4(Z,Z,Y,Y);

		public Vector4 ZZYZ => new Vector4(Z,Z,Y,Z);

		public Vector4 ZZYW => new Vector4(Z,Z,Y,W);

		public Vector4 ZZZX => new Vector4(Z,Z,Z,X);

		public Vector4 ZZZY => new Vector4(Z,Z,Z,Y);

		public Vector4 ZZZZ => new Vector4(Z,Z,Z,Z);

		public Vector4 ZZZW => new Vector4(Z,Z,Z,W);

		public Vector4 ZZWX => new Vector4(Z,Z,W,X);

		public Vector4 ZZWY => new Vector4(Z,Z,W,Y);

		public Vector4 ZZWZ => new Vector4(Z,Z,W,Z);

		public Vector4 ZZWW => new Vector4(Z,Z,W,W);

		public Vector4 ZWXX => new Vector4(Z,W,X,X);

		public Vector4 ZWXY => new Vector4(Z,W,X,Y);

		public Vector4 ZWXZ => new Vector4(Z,W,X,Z);

		public Vector4 ZWXW => new Vector4(Z,W,X,W);

		public Vector4 ZWYX => new Vector4(Z,W,Y,X);

		public Vector4 ZWYY => new Vector4(Z,W,Y,Y);

		public Vector4 ZWYZ => new Vector4(Z,W,Y,Z);

		public Vector4 ZWYW => new Vector4(Z,W,Y,W);

		public Vector4 ZWZX => new Vector4(Z,W,Z,X);

		public Vector4 ZWZY => new Vector4(Z,W,Z,Y);

		public Vector4 ZWZZ => new Vector4(Z,W,Z,Z);

		public Vector4 ZWZW => new Vector4(Z,W,Z,W);

		public Vector4 ZWWX => new Vector4(Z,W,W,X);

		public Vector4 ZWWY => new Vector4(Z,W,W,Y);

		public Vector4 ZWWZ => new Vector4(Z,W,W,Z);

		public Vector4 ZWWW => new Vector4(Z,W,W,W);

		public Vector4 WXXX => new Vector4(W,X,X,X);

		public Vector4 WXXY => new Vector4(W,X,X,Y);

		public Vector4 WXXZ => new Vector4(W,X,X,Z);

		public Vector4 WXXW => new Vector4(W,X,X,W);

		public Vector4 WXYX => new Vector4(W,X,Y,X);

		public Vector4 WXYY => new Vector4(W,X,Y,Y);

		public Vector4 WXYZ => new Vector4(W,X,Y,Z);

		public Vector4 WXYW => new Vector4(W,X,Y,W);

		public Vector4 WXZX => new Vector4(W,X,Z,X);

		public Vector4 WXZY => new Vector4(W,X,Z,Y);

		public Vector4 WXZZ => new Vector4(W,X,Z,Z);

		public Vector4 WXZW => new Vector4(W,X,Z,W);

		public Vector4 WXWX => new Vector4(W,X,W,X);

		public Vector4 WXWY => new Vector4(W,X,W,Y);

		public Vector4 WXWZ => new Vector4(W,X,W,Z);

		public Vector4 WXWW => new Vector4(W,X,W,W);

		public Vector4 WYXX => new Vector4(W,Y,X,X);

		public Vector4 WYXY => new Vector4(W,Y,X,Y);

		public Vector4 WYXZ => new Vector4(W,Y,X,Z);

		public Vector4 WYXW => new Vector4(W,Y,X,W);

		public Vector4 WYYX => new Vector4(W,Y,Y,X);

		public Vector4 WYYY => new Vector4(W,Y,Y,Y);

		public Vector4 WYYZ => new Vector4(W,Y,Y,Z);

		public Vector4 WYYW => new Vector4(W,Y,Y,W);

		public Vector4 WYZX => new Vector4(W,Y,Z,X);

		public Vector4 WYZY => new Vector4(W,Y,Z,Y);

		public Vector4 WYZZ => new Vector4(W,Y,Z,Z);

		public Vector4 WYZW => new Vector4(W,Y,Z,W);

		public Vector4 WYWX => new Vector4(W,Y,W,X);

		public Vector4 WYWY => new Vector4(W,Y,W,Y);

		public Vector4 WYWZ => new Vector4(W,Y,W,Z);

		public Vector4 WYWW => new Vector4(W,Y,W,W);

		public Vector4 WZXX => new Vector4(W,Z,X,X);

		public Vector4 WZXY => new Vector4(W,Z,X,Y);

		public Vector4 WZXZ => new Vector4(W,Z,X,Z);

		public Vector4 WZXW => new Vector4(W,Z,X,W);

		public Vector4 WZYX => new Vector4(W,Z,Y,X);

		public Vector4 WZYY => new Vector4(W,Z,Y,Y);

		public Vector4 WZYZ => new Vector4(W,Z,Y,Z);

		public Vector4 WZYW => new Vector4(W,Z,Y,W);

		public Vector4 WZZX => new Vector4(W,Z,Z,X);

		public Vector4 WZZY => new Vector4(W,Z,Z,Y);

		public Vector4 WZZZ => new Vector4(W,Z,Z,Z);

		public Vector4 WZZW => new Vector4(W,Z,Z,W);

		public Vector4 WZWX => new Vector4(W,Z,W,X);

		public Vector4 WZWY => new Vector4(W,Z,W,Y);

		public Vector4 WZWZ => new Vector4(W,Z,W,Z);

		public Vector4 WZWW => new Vector4(W,Z,W,W);

		public Vector4 WWXX => new Vector4(W,W,X,X);

		public Vector4 WWXY => new Vector4(W,W,X,Y);

		public Vector4 WWXZ => new Vector4(W,W,X,Z);

		public Vector4 WWXW => new Vector4(W,W,X,W);

		public Vector4 WWYX => new Vector4(W,W,Y,X);

		public Vector4 WWYY => new Vector4(W,W,Y,Y);

		public Vector4 WWYZ => new Vector4(W,W,Y,Z);

		public Vector4 WWYW => new Vector4(W,W,Y,W);

		public Vector4 WWZX => new Vector4(W,W,Z,X);

		public Vector4 WWZY => new Vector4(W,W,Z,Y);

		public Vector4 WWZZ => new Vector4(W,W,Z,Z);

		public Vector4 WWZW => new Vector4(W,W,Z,W);

		public Vector4 WWWX => new Vector4(W,W,W,X);

		public Vector4 WWWY => new Vector4(W,W,W,Y);

		public Vector4 WWWZ => new Vector4(W,W,W,Z);

		public Vector4 WWWW => new Vector4(W,W,W,W);

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

		public float A
		{
			get => W;
			set => W = value;
		}

		public Vector2 RR => new Vector2(X,X);

		public Vector2 RG => new Vector2(X,Y);

		public Vector2 RB => new Vector2(X,Z);

		public Vector2 RA => new Vector2(X,W);

		public Vector2 GR => new Vector2(Y,X);

		public Vector2 GG => new Vector2(Y,Y);

		public Vector2 GB => new Vector2(Y,Z);

		public Vector2 GA => new Vector2(Y,W);

		public Vector2 BR => new Vector2(Z,X);

		public Vector2 BG => new Vector2(Z,Y);

		public Vector2 BB => new Vector2(Z,Z);

		public Vector2 BA => new Vector2(Z,W);

		public Vector2 AR => new Vector2(W,X);

		public Vector2 AG => new Vector2(W,Y);

		public Vector2 AB => new Vector2(W,Z);

		public Vector2 AA => new Vector2(W,W);

		public Vector3 RRR => new Vector3(X,X,X);

		public Vector3 RRG => new Vector3(X,X,Y);

		public Vector3 RRB => new Vector3(X,X,Z);

		public Vector3 RRA => new Vector3(X,X,W);

		public Vector3 RGR => new Vector3(X,Y,X);

		public Vector3 RGG => new Vector3(X,Y,Y);

		public Vector3 RGB => new Vector3(X,Y,Z);

		public Vector3 RGA => new Vector3(X,Y,W);

		public Vector3 RBR => new Vector3(X,Z,X);

		public Vector3 RBG => new Vector3(X,Z,Y);

		public Vector3 RBB => new Vector3(X,Z,Z);

		public Vector3 RBA => new Vector3(X,Z,W);

		public Vector3 RAR => new Vector3(X,W,X);

		public Vector3 RAG => new Vector3(X,W,Y);

		public Vector3 RAB => new Vector3(X,W,Z);

		public Vector3 RAA => new Vector3(X,W,W);

		public Vector3 GRR => new Vector3(Y,X,X);

		public Vector3 GRG => new Vector3(Y,X,Y);

		public Vector3 GRB => new Vector3(Y,X,Z);

		public Vector3 GRA => new Vector3(Y,X,W);

		public Vector3 GGR => new Vector3(Y,Y,X);

		public Vector3 GGG => new Vector3(Y,Y,Y);

		public Vector3 GGB => new Vector3(Y,Y,Z);

		public Vector3 GGA => new Vector3(Y,Y,W);

		public Vector3 GBR => new Vector3(Y,Z,X);

		public Vector3 GBG => new Vector3(Y,Z,Y);

		public Vector3 GBB => new Vector3(Y,Z,Z);

		public Vector3 GBA => new Vector3(Y,Z,W);

		public Vector3 GAR => new Vector3(Y,W,X);

		public Vector3 GAG => new Vector3(Y,W,Y);

		public Vector3 GAB => new Vector3(Y,W,Z);

		public Vector3 GAA => new Vector3(Y,W,W);

		public Vector3 BRR => new Vector3(Z,X,X);

		public Vector3 BRG => new Vector3(Z,X,Y);

		public Vector3 BRB => new Vector3(Z,X,Z);

		public Vector3 BRA => new Vector3(Z,X,W);

		public Vector3 BGR => new Vector3(Z,Y,X);

		public Vector3 BGG => new Vector3(Z,Y,Y);

		public Vector3 BGB => new Vector3(Z,Y,Z);

		public Vector3 BGA => new Vector3(Z,Y,W);

		public Vector3 BBR => new Vector3(Z,Z,X);

		public Vector3 BBG => new Vector3(Z,Z,Y);

		public Vector3 BBB => new Vector3(Z,Z,Z);

		public Vector3 BBA => new Vector3(Z,Z,W);

		public Vector3 BAR => new Vector3(Z,W,X);

		public Vector3 BAG => new Vector3(Z,W,Y);

		public Vector3 BAB => new Vector3(Z,W,Z);

		public Vector3 BAA => new Vector3(Z,W,W);

		public Vector3 ARR => new Vector3(W,X,X);

		public Vector3 ARG => new Vector3(W,X,Y);

		public Vector3 ARB => new Vector3(W,X,Z);

		public Vector3 ARA => new Vector3(W,X,W);

		public Vector3 AGR => new Vector3(W,Y,X);

		public Vector3 AGG => new Vector3(W,Y,Y);

		public Vector3 AGB => new Vector3(W,Y,Z);

		public Vector3 AGA => new Vector3(W,Y,W);

		public Vector3 ABR => new Vector3(W,Z,X);

		public Vector3 ABG => new Vector3(W,Z,Y);

		public Vector3 ABB => new Vector3(W,Z,Z);

		public Vector3 ABA => new Vector3(W,Z,W);

		public Vector3 AAR => new Vector3(W,W,X);

		public Vector3 AAG => new Vector3(W,W,Y);

		public Vector3 AAB => new Vector3(W,W,Z);

		public Vector3 AAA => new Vector3(W,W,W);

		public Vector4 RRRR => new Vector4(X,X,X,X);

		public Vector4 RRRG => new Vector4(X,X,X,Y);

		public Vector4 RRRB => new Vector4(X,X,X,Z);

		public Vector4 RRRA => new Vector4(X,X,X,W);

		public Vector4 RRGR => new Vector4(X,X,Y,X);

		public Vector4 RRGG => new Vector4(X,X,Y,Y);

		public Vector4 RRGB => new Vector4(X,X,Y,Z);

		public Vector4 RRGA => new Vector4(X,X,Y,W);

		public Vector4 RRBR => new Vector4(X,X,Z,X);

		public Vector4 RRBG => new Vector4(X,X,Z,Y);

		public Vector4 RRBB => new Vector4(X,X,Z,Z);

		public Vector4 RRBA => new Vector4(X,X,Z,W);

		public Vector4 RRAR => new Vector4(X,X,W,X);

		public Vector4 RRAG => new Vector4(X,X,W,Y);

		public Vector4 RRAB => new Vector4(X,X,W,Z);

		public Vector4 RRAA => new Vector4(X,X,W,W);

		public Vector4 RGRR => new Vector4(X,Y,X,X);

		public Vector4 RGRG => new Vector4(X,Y,X,Y);

		public Vector4 RGRB => new Vector4(X,Y,X,Z);

		public Vector4 RGRA => new Vector4(X,Y,X,W);

		public Vector4 RGGR => new Vector4(X,Y,Y,X);

		public Vector4 RGGG => new Vector4(X,Y,Y,Y);

		public Vector4 RGGB => new Vector4(X,Y,Y,Z);

		public Vector4 RGGA => new Vector4(X,Y,Y,W);

		public Vector4 RGBR => new Vector4(X,Y,Z,X);

		public Vector4 RGBG => new Vector4(X,Y,Z,Y);

		public Vector4 RGBB => new Vector4(X,Y,Z,Z);

		public Vector4 RGBA => new Vector4(X,Y,Z,W);

		public Vector4 RGAR => new Vector4(X,Y,W,X);

		public Vector4 RGAG => new Vector4(X,Y,W,Y);

		public Vector4 RGAB => new Vector4(X,Y,W,Z);

		public Vector4 RGAA => new Vector4(X,Y,W,W);

		public Vector4 RBRR => new Vector4(X,Z,X,X);

		public Vector4 RBRG => new Vector4(X,Z,X,Y);

		public Vector4 RBRB => new Vector4(X,Z,X,Z);

		public Vector4 RBRA => new Vector4(X,Z,X,W);

		public Vector4 RBGR => new Vector4(X,Z,Y,X);

		public Vector4 RBGG => new Vector4(X,Z,Y,Y);

		public Vector4 RBGB => new Vector4(X,Z,Y,Z);

		public Vector4 RBGA => new Vector4(X,Z,Y,W);

		public Vector4 RBBR => new Vector4(X,Z,Z,X);

		public Vector4 RBBG => new Vector4(X,Z,Z,Y);

		public Vector4 RBBB => new Vector4(X,Z,Z,Z);

		public Vector4 RBBA => new Vector4(X,Z,Z,W);

		public Vector4 RBAR => new Vector4(X,Z,W,X);

		public Vector4 RBAG => new Vector4(X,Z,W,Y);

		public Vector4 RBAB => new Vector4(X,Z,W,Z);

		public Vector4 RBAA => new Vector4(X,Z,W,W);

		public Vector4 RARR => new Vector4(X,W,X,X);

		public Vector4 RARG => new Vector4(X,W,X,Y);

		public Vector4 RARB => new Vector4(X,W,X,Z);

		public Vector4 RARA => new Vector4(X,W,X,W);

		public Vector4 RAGR => new Vector4(X,W,Y,X);

		public Vector4 RAGG => new Vector4(X,W,Y,Y);

		public Vector4 RAGB => new Vector4(X,W,Y,Z);

		public Vector4 RAGA => new Vector4(X,W,Y,W);

		public Vector4 RABR => new Vector4(X,W,Z,X);

		public Vector4 RABG => new Vector4(X,W,Z,Y);

		public Vector4 RABB => new Vector4(X,W,Z,Z);

		public Vector4 RABA => new Vector4(X,W,Z,W);

		public Vector4 RAAR => new Vector4(X,W,W,X);

		public Vector4 RAAG => new Vector4(X,W,W,Y);

		public Vector4 RAAB => new Vector4(X,W,W,Z);

		public Vector4 RAAA => new Vector4(X,W,W,W);

		public Vector4 GRRR => new Vector4(Y,X,X,X);

		public Vector4 GRRG => new Vector4(Y,X,X,Y);

		public Vector4 GRRB => new Vector4(Y,X,X,Z);

		public Vector4 GRRA => new Vector4(Y,X,X,W);

		public Vector4 GRGR => new Vector4(Y,X,Y,X);

		public Vector4 GRGG => new Vector4(Y,X,Y,Y);

		public Vector4 GRGB => new Vector4(Y,X,Y,Z);

		public Vector4 GRGA => new Vector4(Y,X,Y,W);

		public Vector4 GRBR => new Vector4(Y,X,Z,X);

		public Vector4 GRBG => new Vector4(Y,X,Z,Y);

		public Vector4 GRBB => new Vector4(Y,X,Z,Z);

		public Vector4 GRBA => new Vector4(Y,X,Z,W);

		public Vector4 GRAR => new Vector4(Y,X,W,X);

		public Vector4 GRAG => new Vector4(Y,X,W,Y);

		public Vector4 GRAB => new Vector4(Y,X,W,Z);

		public Vector4 GRAA => new Vector4(Y,X,W,W);

		public Vector4 GGRR => new Vector4(Y,Y,X,X);

		public Vector4 GGRG => new Vector4(Y,Y,X,Y);

		public Vector4 GGRB => new Vector4(Y,Y,X,Z);

		public Vector4 GGRA => new Vector4(Y,Y,X,W);

		public Vector4 GGGR => new Vector4(Y,Y,Y,X);

		public Vector4 GGGG => new Vector4(Y,Y,Y,Y);

		public Vector4 GGGB => new Vector4(Y,Y,Y,Z);

		public Vector4 GGGA => new Vector4(Y,Y,Y,W);

		public Vector4 GGBR => new Vector4(Y,Y,Z,X);

		public Vector4 GGBG => new Vector4(Y,Y,Z,Y);

		public Vector4 GGBB => new Vector4(Y,Y,Z,Z);

		public Vector4 GGBA => new Vector4(Y,Y,Z,W);

		public Vector4 GGAR => new Vector4(Y,Y,W,X);

		public Vector4 GGAG => new Vector4(Y,Y,W,Y);

		public Vector4 GGAB => new Vector4(Y,Y,W,Z);

		public Vector4 GGAA => new Vector4(Y,Y,W,W);

		public Vector4 GBRR => new Vector4(Y,Z,X,X);

		public Vector4 GBRG => new Vector4(Y,Z,X,Y);

		public Vector4 GBRB => new Vector4(Y,Z,X,Z);

		public Vector4 GBRA => new Vector4(Y,Z,X,W);

		public Vector4 GBGR => new Vector4(Y,Z,Y,X);

		public Vector4 GBGG => new Vector4(Y,Z,Y,Y);

		public Vector4 GBGB => new Vector4(Y,Z,Y,Z);

		public Vector4 GBGA => new Vector4(Y,Z,Y,W);

		public Vector4 GBBR => new Vector4(Y,Z,Z,X);

		public Vector4 GBBG => new Vector4(Y,Z,Z,Y);

		public Vector4 GBBB => new Vector4(Y,Z,Z,Z);

		public Vector4 GBBA => new Vector4(Y,Z,Z,W);

		public Vector4 GBAR => new Vector4(Y,Z,W,X);

		public Vector4 GBAG => new Vector4(Y,Z,W,Y);

		public Vector4 GBAB => new Vector4(Y,Z,W,Z);

		public Vector4 GBAA => new Vector4(Y,Z,W,W);

		public Vector4 GARR => new Vector4(Y,W,X,X);

		public Vector4 GARG => new Vector4(Y,W,X,Y);

		public Vector4 GARB => new Vector4(Y,W,X,Z);

		public Vector4 GARA => new Vector4(Y,W,X,W);

		public Vector4 GAGR => new Vector4(Y,W,Y,X);

		public Vector4 GAGG => new Vector4(Y,W,Y,Y);

		public Vector4 GAGB => new Vector4(Y,W,Y,Z);

		public Vector4 GAGA => new Vector4(Y,W,Y,W);

		public Vector4 GABR => new Vector4(Y,W,Z,X);

		public Vector4 GABG => new Vector4(Y,W,Z,Y);

		public Vector4 GABB => new Vector4(Y,W,Z,Z);

		public Vector4 GABA => new Vector4(Y,W,Z,W);

		public Vector4 GAAR => new Vector4(Y,W,W,X);

		public Vector4 GAAG => new Vector4(Y,W,W,Y);

		public Vector4 GAAB => new Vector4(Y,W,W,Z);

		public Vector4 GAAA => new Vector4(Y,W,W,W);

		public Vector4 BRRR => new Vector4(Z,X,X,X);

		public Vector4 BRRG => new Vector4(Z,X,X,Y);

		public Vector4 BRRB => new Vector4(Z,X,X,Z);

		public Vector4 BRRA => new Vector4(Z,X,X,W);

		public Vector4 BRGR => new Vector4(Z,X,Y,X);

		public Vector4 BRGG => new Vector4(Z,X,Y,Y);

		public Vector4 BRGB => new Vector4(Z,X,Y,Z);

		public Vector4 BRGA => new Vector4(Z,X,Y,W);

		public Vector4 BRBR => new Vector4(Z,X,Z,X);

		public Vector4 BRBG => new Vector4(Z,X,Z,Y);

		public Vector4 BRBB => new Vector4(Z,X,Z,Z);

		public Vector4 BRBA => new Vector4(Z,X,Z,W);

		public Vector4 BRAR => new Vector4(Z,X,W,X);

		public Vector4 BRAG => new Vector4(Z,X,W,Y);

		public Vector4 BRAB => new Vector4(Z,X,W,Z);

		public Vector4 BRAA => new Vector4(Z,X,W,W);

		public Vector4 BGRR => new Vector4(Z,Y,X,X);

		public Vector4 BGRG => new Vector4(Z,Y,X,Y);

		public Vector4 BGRB => new Vector4(Z,Y,X,Z);

		public Vector4 BGRA => new Vector4(Z,Y,X,W);

		public Vector4 BGGR => new Vector4(Z,Y,Y,X);

		public Vector4 BGGG => new Vector4(Z,Y,Y,Y);

		public Vector4 BGGB => new Vector4(Z,Y,Y,Z);

		public Vector4 BGGA => new Vector4(Z,Y,Y,W);

		public Vector4 BGBR => new Vector4(Z,Y,Z,X);

		public Vector4 BGBG => new Vector4(Z,Y,Z,Y);

		public Vector4 BGBB => new Vector4(Z,Y,Z,Z);

		public Vector4 BGBA => new Vector4(Z,Y,Z,W);

		public Vector4 BGAR => new Vector4(Z,Y,W,X);

		public Vector4 BGAG => new Vector4(Z,Y,W,Y);

		public Vector4 BGAB => new Vector4(Z,Y,W,Z);

		public Vector4 BGAA => new Vector4(Z,Y,W,W);

		public Vector4 BBRR => new Vector4(Z,Z,X,X);

		public Vector4 BBRG => new Vector4(Z,Z,X,Y);

		public Vector4 BBRB => new Vector4(Z,Z,X,Z);

		public Vector4 BBRA => new Vector4(Z,Z,X,W);

		public Vector4 BBGR => new Vector4(Z,Z,Y,X);

		public Vector4 BBGG => new Vector4(Z,Z,Y,Y);

		public Vector4 BBGB => new Vector4(Z,Z,Y,Z);

		public Vector4 BBGA => new Vector4(Z,Z,Y,W);

		public Vector4 BBBR => new Vector4(Z,Z,Z,X);

		public Vector4 BBBG => new Vector4(Z,Z,Z,Y);

		public Vector4 BBBB => new Vector4(Z,Z,Z,Z);

		public Vector4 BBBA => new Vector4(Z,Z,Z,W);

		public Vector4 BBAR => new Vector4(Z,Z,W,X);

		public Vector4 BBAG => new Vector4(Z,Z,W,Y);

		public Vector4 BBAB => new Vector4(Z,Z,W,Z);

		public Vector4 BBAA => new Vector4(Z,Z,W,W);

		public Vector4 BARR => new Vector4(Z,W,X,X);

		public Vector4 BARG => new Vector4(Z,W,X,Y);

		public Vector4 BARB => new Vector4(Z,W,X,Z);

		public Vector4 BARA => new Vector4(Z,W,X,W);

		public Vector4 BAGR => new Vector4(Z,W,Y,X);

		public Vector4 BAGG => new Vector4(Z,W,Y,Y);

		public Vector4 BAGB => new Vector4(Z,W,Y,Z);

		public Vector4 BAGA => new Vector4(Z,W,Y,W);

		public Vector4 BABR => new Vector4(Z,W,Z,X);

		public Vector4 BABG => new Vector4(Z,W,Z,Y);

		public Vector4 BABB => new Vector4(Z,W,Z,Z);

		public Vector4 BABA => new Vector4(Z,W,Z,W);

		public Vector4 BAAR => new Vector4(Z,W,W,X);

		public Vector4 BAAG => new Vector4(Z,W,W,Y);

		public Vector4 BAAB => new Vector4(Z,W,W,Z);

		public Vector4 BAAA => new Vector4(Z,W,W,W);

		public Vector4 ARRR => new Vector4(W,X,X,X);

		public Vector4 ARRG => new Vector4(W,X,X,Y);

		public Vector4 ARRB => new Vector4(W,X,X,Z);

		public Vector4 ARRA => new Vector4(W,X,X,W);

		public Vector4 ARGR => new Vector4(W,X,Y,X);

		public Vector4 ARGG => new Vector4(W,X,Y,Y);

		public Vector4 ARGB => new Vector4(W,X,Y,Z);

		public Vector4 ARGA => new Vector4(W,X,Y,W);

		public Vector4 ARBR => new Vector4(W,X,Z,X);

		public Vector4 ARBG => new Vector4(W,X,Z,Y);

		public Vector4 ARBB => new Vector4(W,X,Z,Z);

		public Vector4 ARBA => new Vector4(W,X,Z,W);

		public Vector4 ARAR => new Vector4(W,X,W,X);

		public Vector4 ARAG => new Vector4(W,X,W,Y);

		public Vector4 ARAB => new Vector4(W,X,W,Z);

		public Vector4 ARAA => new Vector4(W,X,W,W);

		public Vector4 AGRR => new Vector4(W,Y,X,X);

		public Vector4 AGRG => new Vector4(W,Y,X,Y);

		public Vector4 AGRB => new Vector4(W,Y,X,Z);

		public Vector4 AGRA => new Vector4(W,Y,X,W);

		public Vector4 AGGR => new Vector4(W,Y,Y,X);

		public Vector4 AGGG => new Vector4(W,Y,Y,Y);

		public Vector4 AGGB => new Vector4(W,Y,Y,Z);

		public Vector4 AGGA => new Vector4(W,Y,Y,W);

		public Vector4 AGBR => new Vector4(W,Y,Z,X);

		public Vector4 AGBG => new Vector4(W,Y,Z,Y);

		public Vector4 AGBB => new Vector4(W,Y,Z,Z);

		public Vector4 AGBA => new Vector4(W,Y,Z,W);

		public Vector4 AGAR => new Vector4(W,Y,W,X);

		public Vector4 AGAG => new Vector4(W,Y,W,Y);

		public Vector4 AGAB => new Vector4(W,Y,W,Z);

		public Vector4 AGAA => new Vector4(W,Y,W,W);

		public Vector4 ABRR => new Vector4(W,Z,X,X);

		public Vector4 ABRG => new Vector4(W,Z,X,Y);

		public Vector4 ABRB => new Vector4(W,Z,X,Z);

		public Vector4 ABRA => new Vector4(W,Z,X,W);

		public Vector4 ABGR => new Vector4(W,Z,Y,X);

		public Vector4 ABGG => new Vector4(W,Z,Y,Y);

		public Vector4 ABGB => new Vector4(W,Z,Y,Z);

		public Vector4 ABGA => new Vector4(W,Z,Y,W);

		public Vector4 ABBR => new Vector4(W,Z,Z,X);

		public Vector4 ABBG => new Vector4(W,Z,Z,Y);

		public Vector4 ABBB => new Vector4(W,Z,Z,Z);

		public Vector4 ABBA => new Vector4(W,Z,Z,W);

		public Vector4 ABAR => new Vector4(W,Z,W,X);

		public Vector4 ABAG => new Vector4(W,Z,W,Y);

		public Vector4 ABAB => new Vector4(W,Z,W,Z);

		public Vector4 ABAA => new Vector4(W,Z,W,W);

		public Vector4 AARR => new Vector4(W,W,X,X);

		public Vector4 AARG => new Vector4(W,W,X,Y);

		public Vector4 AARB => new Vector4(W,W,X,Z);

		public Vector4 AARA => new Vector4(W,W,X,W);

		public Vector4 AAGR => new Vector4(W,W,Y,X);

		public Vector4 AAGG => new Vector4(W,W,Y,Y);

		public Vector4 AAGB => new Vector4(W,W,Y,Z);

		public Vector4 AAGA => new Vector4(W,W,Y,W);

		public Vector4 AABR => new Vector4(W,W,Z,X);

		public Vector4 AABG => new Vector4(W,W,Z,Y);

		public Vector4 AABB => new Vector4(W,W,Z,Z);

		public Vector4 AABA => new Vector4(W,W,Z,W);

		public Vector4 AAAR => new Vector4(W,W,W,X);

		public Vector4 AAAG => new Vector4(W,W,W,Y);

		public Vector4 AAAB => new Vector4(W,W,W,Z);

		public Vector4 AAAA => new Vector4(W,W,W,W);

		public static Vector4 operator +(Vector4 a, Vector4 b)
		{
			return new Vector4()
			{
				X = a.X + b.X,
				Y = a.Y + b.Y,
				Z = a.Z + b.Z,
				W = a.W + b.W,
			};
		}

		public static Vector4 operator -(Vector4 a, Vector4 b)
		{
			return new Vector4()
			{
				X = a.X - b.X,
				Y = a.Y - b.Y,
				Z = a.Z - b.Z,
				W = a.W - b.W,
			};
		}

		public static Vector4 operator *(Vector4 a, Vector4 b)
		{
			return new Vector4()
			{
				X = a.X * b.X,
				Y = a.Y * b.Y,
				Z = a.Z * b.Z,
				W = a.W * b.W,
			};
		}

		public static Vector4 operator /(Vector4 a, Vector4 b)
		{
			return new Vector4()
			{
				X = a.X / b.X,
				Y = a.Y / b.Y,
				Z = a.Z / b.Z,
				W = a.W / b.W,
			};
		}

	}
}
