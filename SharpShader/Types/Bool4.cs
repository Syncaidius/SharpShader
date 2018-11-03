using System.Runtime.InteropServices;

namespace SharpShader
{
	public struct Bool4
	{
		public bool X;

		public bool Y;

		public bool Z;

		public bool W;

		public Bool4(bool x, bool y, bool z, bool w)
		{
			X = x;
			Y = y;
			Z = z;
			W = w;
		}

		public Bool2 XX
		{
			get => new Bool2(X,X);
		}

		public Bool2 XY
		{
			get => new Bool2(X,Y);
		}

		public Bool2 XZ
		{
			get => new Bool2(X,Z);
		}

		public Bool2 XW
		{
			get => new Bool2(X,W);
		}

		public Bool2 YX
		{
			get => new Bool2(Y,X);
		}

		public Bool2 YY
		{
			get => new Bool2(Y,Y);
		}

		public Bool2 YZ
		{
			get => new Bool2(Y,Z);
		}

		public Bool2 YW
		{
			get => new Bool2(Y,W);
		}

		public Bool2 ZX
		{
			get => new Bool2(Z,X);
		}

		public Bool2 ZY
		{
			get => new Bool2(Z,Y);
		}

		public Bool2 ZZ
		{
			get => new Bool2(Z,Z);
		}

		public Bool2 ZW
		{
			get => new Bool2(Z,W);
		}

		public Bool2 WX
		{
			get => new Bool2(W,X);
		}

		public Bool2 WY
		{
			get => new Bool2(W,Y);
		}

		public Bool2 WZ
		{
			get => new Bool2(W,Z);
		}

		public Bool2 WW
		{
			get => new Bool2(W,W);
		}

		public Bool3 XXX
		{
			get => new Bool3(X,X,X);
		}

		public Bool3 XXY
		{
			get => new Bool3(X,X,Y);
		}

		public Bool3 XXZ
		{
			get => new Bool3(X,X,Z);
		}

		public Bool3 XXW
		{
			get => new Bool3(X,X,W);
		}

		public Bool3 XYX
		{
			get => new Bool3(X,Y,X);
		}

		public Bool3 XYY
		{
			get => new Bool3(X,Y,Y);
		}

		public Bool3 XYZ
		{
			get => new Bool3(X,Y,Z);
		}

		public Bool3 XYW
		{
			get => new Bool3(X,Y,W);
		}

		public Bool3 XZX
		{
			get => new Bool3(X,Z,X);
		}

		public Bool3 XZY
		{
			get => new Bool3(X,Z,Y);
		}

		public Bool3 XZZ
		{
			get => new Bool3(X,Z,Z);
		}

		public Bool3 XZW
		{
			get => new Bool3(X,Z,W);
		}

		public Bool3 XWX
		{
			get => new Bool3(X,W,X);
		}

		public Bool3 XWY
		{
			get => new Bool3(X,W,Y);
		}

		public Bool3 XWZ
		{
			get => new Bool3(X,W,Z);
		}

		public Bool3 XWW
		{
			get => new Bool3(X,W,W);
		}

		public Bool3 YXX
		{
			get => new Bool3(Y,X,X);
		}

		public Bool3 YXY
		{
			get => new Bool3(Y,X,Y);
		}

		public Bool3 YXZ
		{
			get => new Bool3(Y,X,Z);
		}

		public Bool3 YXW
		{
			get => new Bool3(Y,X,W);
		}

		public Bool3 YYX
		{
			get => new Bool3(Y,Y,X);
		}

		public Bool3 YYY
		{
			get => new Bool3(Y,Y,Y);
		}

		public Bool3 YYZ
		{
			get => new Bool3(Y,Y,Z);
		}

		public Bool3 YYW
		{
			get => new Bool3(Y,Y,W);
		}

		public Bool3 YZX
		{
			get => new Bool3(Y,Z,X);
		}

		public Bool3 YZY
		{
			get => new Bool3(Y,Z,Y);
		}

		public Bool3 YZZ
		{
			get => new Bool3(Y,Z,Z);
		}

		public Bool3 YZW
		{
			get => new Bool3(Y,Z,W);
		}

		public Bool3 YWX
		{
			get => new Bool3(Y,W,X);
		}

		public Bool3 YWY
		{
			get => new Bool3(Y,W,Y);
		}

		public Bool3 YWZ
		{
			get => new Bool3(Y,W,Z);
		}

		public Bool3 YWW
		{
			get => new Bool3(Y,W,W);
		}

		public Bool3 ZXX
		{
			get => new Bool3(Z,X,X);
		}

		public Bool3 ZXY
		{
			get => new Bool3(Z,X,Y);
		}

		public Bool3 ZXZ
		{
			get => new Bool3(Z,X,Z);
		}

		public Bool3 ZXW
		{
			get => new Bool3(Z,X,W);
		}

		public Bool3 ZYX
		{
			get => new Bool3(Z,Y,X);
		}

		public Bool3 ZYY
		{
			get => new Bool3(Z,Y,Y);
		}

		public Bool3 ZYZ
		{
			get => new Bool3(Z,Y,Z);
		}

		public Bool3 ZYW
		{
			get => new Bool3(Z,Y,W);
		}

		public Bool3 ZZX
		{
			get => new Bool3(Z,Z,X);
		}

		public Bool3 ZZY
		{
			get => new Bool3(Z,Z,Y);
		}

		public Bool3 ZZZ
		{
			get => new Bool3(Z,Z,Z);
		}

		public Bool3 ZZW
		{
			get => new Bool3(Z,Z,W);
		}

		public Bool3 ZWX
		{
			get => new Bool3(Z,W,X);
		}

		public Bool3 ZWY
		{
			get => new Bool3(Z,W,Y);
		}

		public Bool3 ZWZ
		{
			get => new Bool3(Z,W,Z);
		}

		public Bool3 ZWW
		{
			get => new Bool3(Z,W,W);
		}

		public Bool3 WXX
		{
			get => new Bool3(W,X,X);
		}

		public Bool3 WXY
		{
			get => new Bool3(W,X,Y);
		}

		public Bool3 WXZ
		{
			get => new Bool3(W,X,Z);
		}

		public Bool3 WXW
		{
			get => new Bool3(W,X,W);
		}

		public Bool3 WYX
		{
			get => new Bool3(W,Y,X);
		}

		public Bool3 WYY
		{
			get => new Bool3(W,Y,Y);
		}

		public Bool3 WYZ
		{
			get => new Bool3(W,Y,Z);
		}

		public Bool3 WYW
		{
			get => new Bool3(W,Y,W);
		}

		public Bool3 WZX
		{
			get => new Bool3(W,Z,X);
		}

		public Bool3 WZY
		{
			get => new Bool3(W,Z,Y);
		}

		public Bool3 WZZ
		{
			get => new Bool3(W,Z,Z);
		}

		public Bool3 WZW
		{
			get => new Bool3(W,Z,W);
		}

		public Bool3 WWX
		{
			get => new Bool3(W,W,X);
		}

		public Bool3 WWY
		{
			get => new Bool3(W,W,Y);
		}

		public Bool3 WWZ
		{
			get => new Bool3(W,W,Z);
		}

		public Bool3 WWW
		{
			get => new Bool3(W,W,W);
		}

		public Bool4 XXXX
		{
			get => new Bool4(X,X,X,X);
		}

		public Bool4 XXXY
		{
			get => new Bool4(X,X,X,Y);
		}

		public Bool4 XXXZ
		{
			get => new Bool4(X,X,X,Z);
		}

		public Bool4 XXXW
		{
			get => new Bool4(X,X,X,W);
		}

		public Bool4 XXYX
		{
			get => new Bool4(X,X,Y,X);
		}

		public Bool4 XXYY
		{
			get => new Bool4(X,X,Y,Y);
		}

		public Bool4 XXYZ
		{
			get => new Bool4(X,X,Y,Z);
		}

		public Bool4 XXYW
		{
			get => new Bool4(X,X,Y,W);
		}

		public Bool4 XXZX
		{
			get => new Bool4(X,X,Z,X);
		}

		public Bool4 XXZY
		{
			get => new Bool4(X,X,Z,Y);
		}

		public Bool4 XXZZ
		{
			get => new Bool4(X,X,Z,Z);
		}

		public Bool4 XXZW
		{
			get => new Bool4(X,X,Z,W);
		}

		public Bool4 XXWX
		{
			get => new Bool4(X,X,W,X);
		}

		public Bool4 XXWY
		{
			get => new Bool4(X,X,W,Y);
		}

		public Bool4 XXWZ
		{
			get => new Bool4(X,X,W,Z);
		}

		public Bool4 XXWW
		{
			get => new Bool4(X,X,W,W);
		}

		public Bool4 XYXX
		{
			get => new Bool4(X,Y,X,X);
		}

		public Bool4 XYXY
		{
			get => new Bool4(X,Y,X,Y);
		}

		public Bool4 XYXZ
		{
			get => new Bool4(X,Y,X,Z);
		}

		public Bool4 XYXW
		{
			get => new Bool4(X,Y,X,W);
		}

		public Bool4 XYYX
		{
			get => new Bool4(X,Y,Y,X);
		}

		public Bool4 XYYY
		{
			get => new Bool4(X,Y,Y,Y);
		}

		public Bool4 XYYZ
		{
			get => new Bool4(X,Y,Y,Z);
		}

		public Bool4 XYYW
		{
			get => new Bool4(X,Y,Y,W);
		}

		public Bool4 XYZX
		{
			get => new Bool4(X,Y,Z,X);
		}

		public Bool4 XYZY
		{
			get => new Bool4(X,Y,Z,Y);
		}

		public Bool4 XYZZ
		{
			get => new Bool4(X,Y,Z,Z);
		}

		public Bool4 XYZW
		{
			get => new Bool4(X,Y,Z,W);
		}

		public Bool4 XYWX
		{
			get => new Bool4(X,Y,W,X);
		}

		public Bool4 XYWY
		{
			get => new Bool4(X,Y,W,Y);
		}

		public Bool4 XYWZ
		{
			get => new Bool4(X,Y,W,Z);
		}

		public Bool4 XYWW
		{
			get => new Bool4(X,Y,W,W);
		}

		public Bool4 XZXX
		{
			get => new Bool4(X,Z,X,X);
		}

		public Bool4 XZXY
		{
			get => new Bool4(X,Z,X,Y);
		}

		public Bool4 XZXZ
		{
			get => new Bool4(X,Z,X,Z);
		}

		public Bool4 XZXW
		{
			get => new Bool4(X,Z,X,W);
		}

		public Bool4 XZYX
		{
			get => new Bool4(X,Z,Y,X);
		}

		public Bool4 XZYY
		{
			get => new Bool4(X,Z,Y,Y);
		}

		public Bool4 XZYZ
		{
			get => new Bool4(X,Z,Y,Z);
		}

		public Bool4 XZYW
		{
			get => new Bool4(X,Z,Y,W);
		}

		public Bool4 XZZX
		{
			get => new Bool4(X,Z,Z,X);
		}

		public Bool4 XZZY
		{
			get => new Bool4(X,Z,Z,Y);
		}

		public Bool4 XZZZ
		{
			get => new Bool4(X,Z,Z,Z);
		}

		public Bool4 XZZW
		{
			get => new Bool4(X,Z,Z,W);
		}

		public Bool4 XZWX
		{
			get => new Bool4(X,Z,W,X);
		}

		public Bool4 XZWY
		{
			get => new Bool4(X,Z,W,Y);
		}

		public Bool4 XZWZ
		{
			get => new Bool4(X,Z,W,Z);
		}

		public Bool4 XZWW
		{
			get => new Bool4(X,Z,W,W);
		}

		public Bool4 XWXX
		{
			get => new Bool4(X,W,X,X);
		}

		public Bool4 XWXY
		{
			get => new Bool4(X,W,X,Y);
		}

		public Bool4 XWXZ
		{
			get => new Bool4(X,W,X,Z);
		}

		public Bool4 XWXW
		{
			get => new Bool4(X,W,X,W);
		}

		public Bool4 XWYX
		{
			get => new Bool4(X,W,Y,X);
		}

		public Bool4 XWYY
		{
			get => new Bool4(X,W,Y,Y);
		}

		public Bool4 XWYZ
		{
			get => new Bool4(X,W,Y,Z);
		}

		public Bool4 XWYW
		{
			get => new Bool4(X,W,Y,W);
		}

		public Bool4 XWZX
		{
			get => new Bool4(X,W,Z,X);
		}

		public Bool4 XWZY
		{
			get => new Bool4(X,W,Z,Y);
		}

		public Bool4 XWZZ
		{
			get => new Bool4(X,W,Z,Z);
		}

		public Bool4 XWZW
		{
			get => new Bool4(X,W,Z,W);
		}

		public Bool4 XWWX
		{
			get => new Bool4(X,W,W,X);
		}

		public Bool4 XWWY
		{
			get => new Bool4(X,W,W,Y);
		}

		public Bool4 XWWZ
		{
			get => new Bool4(X,W,W,Z);
		}

		public Bool4 XWWW
		{
			get => new Bool4(X,W,W,W);
		}

		public Bool4 YXXX
		{
			get => new Bool4(Y,X,X,X);
		}

		public Bool4 YXXY
		{
			get => new Bool4(Y,X,X,Y);
		}

		public Bool4 YXXZ
		{
			get => new Bool4(Y,X,X,Z);
		}

		public Bool4 YXXW
		{
			get => new Bool4(Y,X,X,W);
		}

		public Bool4 YXYX
		{
			get => new Bool4(Y,X,Y,X);
		}

		public Bool4 YXYY
		{
			get => new Bool4(Y,X,Y,Y);
		}

		public Bool4 YXYZ
		{
			get => new Bool4(Y,X,Y,Z);
		}

		public Bool4 YXYW
		{
			get => new Bool4(Y,X,Y,W);
		}

		public Bool4 YXZX
		{
			get => new Bool4(Y,X,Z,X);
		}

		public Bool4 YXZY
		{
			get => new Bool4(Y,X,Z,Y);
		}

		public Bool4 YXZZ
		{
			get => new Bool4(Y,X,Z,Z);
		}

		public Bool4 YXZW
		{
			get => new Bool4(Y,X,Z,W);
		}

		public Bool4 YXWX
		{
			get => new Bool4(Y,X,W,X);
		}

		public Bool4 YXWY
		{
			get => new Bool4(Y,X,W,Y);
		}

		public Bool4 YXWZ
		{
			get => new Bool4(Y,X,W,Z);
		}

		public Bool4 YXWW
		{
			get => new Bool4(Y,X,W,W);
		}

		public Bool4 YYXX
		{
			get => new Bool4(Y,Y,X,X);
		}

		public Bool4 YYXY
		{
			get => new Bool4(Y,Y,X,Y);
		}

		public Bool4 YYXZ
		{
			get => new Bool4(Y,Y,X,Z);
		}

		public Bool4 YYXW
		{
			get => new Bool4(Y,Y,X,W);
		}

		public Bool4 YYYX
		{
			get => new Bool4(Y,Y,Y,X);
		}

		public Bool4 YYYY
		{
			get => new Bool4(Y,Y,Y,Y);
		}

		public Bool4 YYYZ
		{
			get => new Bool4(Y,Y,Y,Z);
		}

		public Bool4 YYYW
		{
			get => new Bool4(Y,Y,Y,W);
		}

		public Bool4 YYZX
		{
			get => new Bool4(Y,Y,Z,X);
		}

		public Bool4 YYZY
		{
			get => new Bool4(Y,Y,Z,Y);
		}

		public Bool4 YYZZ
		{
			get => new Bool4(Y,Y,Z,Z);
		}

		public Bool4 YYZW
		{
			get => new Bool4(Y,Y,Z,W);
		}

		public Bool4 YYWX
		{
			get => new Bool4(Y,Y,W,X);
		}

		public Bool4 YYWY
		{
			get => new Bool4(Y,Y,W,Y);
		}

		public Bool4 YYWZ
		{
			get => new Bool4(Y,Y,W,Z);
		}

		public Bool4 YYWW
		{
			get => new Bool4(Y,Y,W,W);
		}

		public Bool4 YZXX
		{
			get => new Bool4(Y,Z,X,X);
		}

		public Bool4 YZXY
		{
			get => new Bool4(Y,Z,X,Y);
		}

		public Bool4 YZXZ
		{
			get => new Bool4(Y,Z,X,Z);
		}

		public Bool4 YZXW
		{
			get => new Bool4(Y,Z,X,W);
		}

		public Bool4 YZYX
		{
			get => new Bool4(Y,Z,Y,X);
		}

		public Bool4 YZYY
		{
			get => new Bool4(Y,Z,Y,Y);
		}

		public Bool4 YZYZ
		{
			get => new Bool4(Y,Z,Y,Z);
		}

		public Bool4 YZYW
		{
			get => new Bool4(Y,Z,Y,W);
		}

		public Bool4 YZZX
		{
			get => new Bool4(Y,Z,Z,X);
		}

		public Bool4 YZZY
		{
			get => new Bool4(Y,Z,Z,Y);
		}

		public Bool4 YZZZ
		{
			get => new Bool4(Y,Z,Z,Z);
		}

		public Bool4 YZZW
		{
			get => new Bool4(Y,Z,Z,W);
		}

		public Bool4 YZWX
		{
			get => new Bool4(Y,Z,W,X);
		}

		public Bool4 YZWY
		{
			get => new Bool4(Y,Z,W,Y);
		}

		public Bool4 YZWZ
		{
			get => new Bool4(Y,Z,W,Z);
		}

		public Bool4 YZWW
		{
			get => new Bool4(Y,Z,W,W);
		}

		public Bool4 YWXX
		{
			get => new Bool4(Y,W,X,X);
		}

		public Bool4 YWXY
		{
			get => new Bool4(Y,W,X,Y);
		}

		public Bool4 YWXZ
		{
			get => new Bool4(Y,W,X,Z);
		}

		public Bool4 YWXW
		{
			get => new Bool4(Y,W,X,W);
		}

		public Bool4 YWYX
		{
			get => new Bool4(Y,W,Y,X);
		}

		public Bool4 YWYY
		{
			get => new Bool4(Y,W,Y,Y);
		}

		public Bool4 YWYZ
		{
			get => new Bool4(Y,W,Y,Z);
		}

		public Bool4 YWYW
		{
			get => new Bool4(Y,W,Y,W);
		}

		public Bool4 YWZX
		{
			get => new Bool4(Y,W,Z,X);
		}

		public Bool4 YWZY
		{
			get => new Bool4(Y,W,Z,Y);
		}

		public Bool4 YWZZ
		{
			get => new Bool4(Y,W,Z,Z);
		}

		public Bool4 YWZW
		{
			get => new Bool4(Y,W,Z,W);
		}

		public Bool4 YWWX
		{
			get => new Bool4(Y,W,W,X);
		}

		public Bool4 YWWY
		{
			get => new Bool4(Y,W,W,Y);
		}

		public Bool4 YWWZ
		{
			get => new Bool4(Y,W,W,Z);
		}

		public Bool4 YWWW
		{
			get => new Bool4(Y,W,W,W);
		}

		public Bool4 ZXXX
		{
			get => new Bool4(Z,X,X,X);
		}

		public Bool4 ZXXY
		{
			get => new Bool4(Z,X,X,Y);
		}

		public Bool4 ZXXZ
		{
			get => new Bool4(Z,X,X,Z);
		}

		public Bool4 ZXXW
		{
			get => new Bool4(Z,X,X,W);
		}

		public Bool4 ZXYX
		{
			get => new Bool4(Z,X,Y,X);
		}

		public Bool4 ZXYY
		{
			get => new Bool4(Z,X,Y,Y);
		}

		public Bool4 ZXYZ
		{
			get => new Bool4(Z,X,Y,Z);
		}

		public Bool4 ZXYW
		{
			get => new Bool4(Z,X,Y,W);
		}

		public Bool4 ZXZX
		{
			get => new Bool4(Z,X,Z,X);
		}

		public Bool4 ZXZY
		{
			get => new Bool4(Z,X,Z,Y);
		}

		public Bool4 ZXZZ
		{
			get => new Bool4(Z,X,Z,Z);
		}

		public Bool4 ZXZW
		{
			get => new Bool4(Z,X,Z,W);
		}

		public Bool4 ZXWX
		{
			get => new Bool4(Z,X,W,X);
		}

		public Bool4 ZXWY
		{
			get => new Bool4(Z,X,W,Y);
		}

		public Bool4 ZXWZ
		{
			get => new Bool4(Z,X,W,Z);
		}

		public Bool4 ZXWW
		{
			get => new Bool4(Z,X,W,W);
		}

		public Bool4 ZYXX
		{
			get => new Bool4(Z,Y,X,X);
		}

		public Bool4 ZYXY
		{
			get => new Bool4(Z,Y,X,Y);
		}

		public Bool4 ZYXZ
		{
			get => new Bool4(Z,Y,X,Z);
		}

		public Bool4 ZYXW
		{
			get => new Bool4(Z,Y,X,W);
		}

		public Bool4 ZYYX
		{
			get => new Bool4(Z,Y,Y,X);
		}

		public Bool4 ZYYY
		{
			get => new Bool4(Z,Y,Y,Y);
		}

		public Bool4 ZYYZ
		{
			get => new Bool4(Z,Y,Y,Z);
		}

		public Bool4 ZYYW
		{
			get => new Bool4(Z,Y,Y,W);
		}

		public Bool4 ZYZX
		{
			get => new Bool4(Z,Y,Z,X);
		}

		public Bool4 ZYZY
		{
			get => new Bool4(Z,Y,Z,Y);
		}

		public Bool4 ZYZZ
		{
			get => new Bool4(Z,Y,Z,Z);
		}

		public Bool4 ZYZW
		{
			get => new Bool4(Z,Y,Z,W);
		}

		public Bool4 ZYWX
		{
			get => new Bool4(Z,Y,W,X);
		}

		public Bool4 ZYWY
		{
			get => new Bool4(Z,Y,W,Y);
		}

		public Bool4 ZYWZ
		{
			get => new Bool4(Z,Y,W,Z);
		}

		public Bool4 ZYWW
		{
			get => new Bool4(Z,Y,W,W);
		}

		public Bool4 ZZXX
		{
			get => new Bool4(Z,Z,X,X);
		}

		public Bool4 ZZXY
		{
			get => new Bool4(Z,Z,X,Y);
		}

		public Bool4 ZZXZ
		{
			get => new Bool4(Z,Z,X,Z);
		}

		public Bool4 ZZXW
		{
			get => new Bool4(Z,Z,X,W);
		}

		public Bool4 ZZYX
		{
			get => new Bool4(Z,Z,Y,X);
		}

		public Bool4 ZZYY
		{
			get => new Bool4(Z,Z,Y,Y);
		}

		public Bool4 ZZYZ
		{
			get => new Bool4(Z,Z,Y,Z);
		}

		public Bool4 ZZYW
		{
			get => new Bool4(Z,Z,Y,W);
		}

		public Bool4 ZZZX
		{
			get => new Bool4(Z,Z,Z,X);
		}

		public Bool4 ZZZY
		{
			get => new Bool4(Z,Z,Z,Y);
		}

		public Bool4 ZZZZ
		{
			get => new Bool4(Z,Z,Z,Z);
		}

		public Bool4 ZZZW
		{
			get => new Bool4(Z,Z,Z,W);
		}

		public Bool4 ZZWX
		{
			get => new Bool4(Z,Z,W,X);
		}

		public Bool4 ZZWY
		{
			get => new Bool4(Z,Z,W,Y);
		}

		public Bool4 ZZWZ
		{
			get => new Bool4(Z,Z,W,Z);
		}

		public Bool4 ZZWW
		{
			get => new Bool4(Z,Z,W,W);
		}

		public Bool4 ZWXX
		{
			get => new Bool4(Z,W,X,X);
		}

		public Bool4 ZWXY
		{
			get => new Bool4(Z,W,X,Y);
		}

		public Bool4 ZWXZ
		{
			get => new Bool4(Z,W,X,Z);
		}

		public Bool4 ZWXW
		{
			get => new Bool4(Z,W,X,W);
		}

		public Bool4 ZWYX
		{
			get => new Bool4(Z,W,Y,X);
		}

		public Bool4 ZWYY
		{
			get => new Bool4(Z,W,Y,Y);
		}

		public Bool4 ZWYZ
		{
			get => new Bool4(Z,W,Y,Z);
		}

		public Bool4 ZWYW
		{
			get => new Bool4(Z,W,Y,W);
		}

		public Bool4 ZWZX
		{
			get => new Bool4(Z,W,Z,X);
		}

		public Bool4 ZWZY
		{
			get => new Bool4(Z,W,Z,Y);
		}

		public Bool4 ZWZZ
		{
			get => new Bool4(Z,W,Z,Z);
		}

		public Bool4 ZWZW
		{
			get => new Bool4(Z,W,Z,W);
		}

		public Bool4 ZWWX
		{
			get => new Bool4(Z,W,W,X);
		}

		public Bool4 ZWWY
		{
			get => new Bool4(Z,W,W,Y);
		}

		public Bool4 ZWWZ
		{
			get => new Bool4(Z,W,W,Z);
		}

		public Bool4 ZWWW
		{
			get => new Bool4(Z,W,W,W);
		}

		public Bool4 WXXX
		{
			get => new Bool4(W,X,X,X);
		}

		public Bool4 WXXY
		{
			get => new Bool4(W,X,X,Y);
		}

		public Bool4 WXXZ
		{
			get => new Bool4(W,X,X,Z);
		}

		public Bool4 WXXW
		{
			get => new Bool4(W,X,X,W);
		}

		public Bool4 WXYX
		{
			get => new Bool4(W,X,Y,X);
		}

		public Bool4 WXYY
		{
			get => new Bool4(W,X,Y,Y);
		}

		public Bool4 WXYZ
		{
			get => new Bool4(W,X,Y,Z);
		}

		public Bool4 WXYW
		{
			get => new Bool4(W,X,Y,W);
		}

		public Bool4 WXZX
		{
			get => new Bool4(W,X,Z,X);
		}

		public Bool4 WXZY
		{
			get => new Bool4(W,X,Z,Y);
		}

		public Bool4 WXZZ
		{
			get => new Bool4(W,X,Z,Z);
		}

		public Bool4 WXZW
		{
			get => new Bool4(W,X,Z,W);
		}

		public Bool4 WXWX
		{
			get => new Bool4(W,X,W,X);
		}

		public Bool4 WXWY
		{
			get => new Bool4(W,X,W,Y);
		}

		public Bool4 WXWZ
		{
			get => new Bool4(W,X,W,Z);
		}

		public Bool4 WXWW
		{
			get => new Bool4(W,X,W,W);
		}

		public Bool4 WYXX
		{
			get => new Bool4(W,Y,X,X);
		}

		public Bool4 WYXY
		{
			get => new Bool4(W,Y,X,Y);
		}

		public Bool4 WYXZ
		{
			get => new Bool4(W,Y,X,Z);
		}

		public Bool4 WYXW
		{
			get => new Bool4(W,Y,X,W);
		}

		public Bool4 WYYX
		{
			get => new Bool4(W,Y,Y,X);
		}

		public Bool4 WYYY
		{
			get => new Bool4(W,Y,Y,Y);
		}

		public Bool4 WYYZ
		{
			get => new Bool4(W,Y,Y,Z);
		}

		public Bool4 WYYW
		{
			get => new Bool4(W,Y,Y,W);
		}

		public Bool4 WYZX
		{
			get => new Bool4(W,Y,Z,X);
		}

		public Bool4 WYZY
		{
			get => new Bool4(W,Y,Z,Y);
		}

		public Bool4 WYZZ
		{
			get => new Bool4(W,Y,Z,Z);
		}

		public Bool4 WYZW
		{
			get => new Bool4(W,Y,Z,W);
		}

		public Bool4 WYWX
		{
			get => new Bool4(W,Y,W,X);
		}

		public Bool4 WYWY
		{
			get => new Bool4(W,Y,W,Y);
		}

		public Bool4 WYWZ
		{
			get => new Bool4(W,Y,W,Z);
		}

		public Bool4 WYWW
		{
			get => new Bool4(W,Y,W,W);
		}

		public Bool4 WZXX
		{
			get => new Bool4(W,Z,X,X);
		}

		public Bool4 WZXY
		{
			get => new Bool4(W,Z,X,Y);
		}

		public Bool4 WZXZ
		{
			get => new Bool4(W,Z,X,Z);
		}

		public Bool4 WZXW
		{
			get => new Bool4(W,Z,X,W);
		}

		public Bool4 WZYX
		{
			get => new Bool4(W,Z,Y,X);
		}

		public Bool4 WZYY
		{
			get => new Bool4(W,Z,Y,Y);
		}

		public Bool4 WZYZ
		{
			get => new Bool4(W,Z,Y,Z);
		}

		public Bool4 WZYW
		{
			get => new Bool4(W,Z,Y,W);
		}

		public Bool4 WZZX
		{
			get => new Bool4(W,Z,Z,X);
		}

		public Bool4 WZZY
		{
			get => new Bool4(W,Z,Z,Y);
		}

		public Bool4 WZZZ
		{
			get => new Bool4(W,Z,Z,Z);
		}

		public Bool4 WZZW
		{
			get => new Bool4(W,Z,Z,W);
		}

		public Bool4 WZWX
		{
			get => new Bool4(W,Z,W,X);
		}

		public Bool4 WZWY
		{
			get => new Bool4(W,Z,W,Y);
		}

		public Bool4 WZWZ
		{
			get => new Bool4(W,Z,W,Z);
		}

		public Bool4 WZWW
		{
			get => new Bool4(W,Z,W,W);
		}

		public Bool4 WWXX
		{
			get => new Bool4(W,W,X,X);
		}

		public Bool4 WWXY
		{
			get => new Bool4(W,W,X,Y);
		}

		public Bool4 WWXZ
		{
			get => new Bool4(W,W,X,Z);
		}

		public Bool4 WWXW
		{
			get => new Bool4(W,W,X,W);
		}

		public Bool4 WWYX
		{
			get => new Bool4(W,W,Y,X);
		}

		public Bool4 WWYY
		{
			get => new Bool4(W,W,Y,Y);
		}

		public Bool4 WWYZ
		{
			get => new Bool4(W,W,Y,Z);
		}

		public Bool4 WWYW
		{
			get => new Bool4(W,W,Y,W);
		}

		public Bool4 WWZX
		{
			get => new Bool4(W,W,Z,X);
		}

		public Bool4 WWZY
		{
			get => new Bool4(W,W,Z,Y);
		}

		public Bool4 WWZZ
		{
			get => new Bool4(W,W,Z,Z);
		}

		public Bool4 WWZW
		{
			get => new Bool4(W,W,Z,W);
		}

		public Bool4 WWWX
		{
			get => new Bool4(W,W,W,X);
		}

		public Bool4 WWWY
		{
			get => new Bool4(W,W,W,Y);
		}

		public Bool4 WWWZ
		{
			get => new Bool4(W,W,W,Z);
		}

		public Bool4 WWWW
		{
			get => new Bool4(W,W,W,W);
		}

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

		public bool A
		{
			get => W;
			set => W = value;
		}

	}
}
