using System.Runtime.InteropServices;

namespace SharpShader
{
	public struct Int4
	{
		public int X;

		public int Y;

		public int Z;

		public int W;

		public Int4(int x, int y, int z, int w)
		{
			X = x;
			Y = y;
			Z = z;
			W = w;
		}

		public Int2 XX
		{
			get => new Int2(X,X);
		}

		public Int2 XY
		{
			get => new Int2(X,Y);
		}

		public Int2 XZ
		{
			get => new Int2(X,Z);
		}

		public Int2 XW
		{
			get => new Int2(X,W);
		}

		public Int2 YX
		{
			get => new Int2(Y,X);
		}

		public Int2 YY
		{
			get => new Int2(Y,Y);
		}

		public Int2 YZ
		{
			get => new Int2(Y,Z);
		}

		public Int2 YW
		{
			get => new Int2(Y,W);
		}

		public Int2 ZX
		{
			get => new Int2(Z,X);
		}

		public Int2 ZY
		{
			get => new Int2(Z,Y);
		}

		public Int2 ZZ
		{
			get => new Int2(Z,Z);
		}

		public Int2 ZW
		{
			get => new Int2(Z,W);
		}

		public Int2 WX
		{
			get => new Int2(W,X);
		}

		public Int2 WY
		{
			get => new Int2(W,Y);
		}

		public Int2 WZ
		{
			get => new Int2(W,Z);
		}

		public Int2 WW
		{
			get => new Int2(W,W);
		}

		public Int3 XXX
		{
			get => new Int3(X,X,X);
		}

		public Int3 XXY
		{
			get => new Int3(X,X,Y);
		}

		public Int3 XXZ
		{
			get => new Int3(X,X,Z);
		}

		public Int3 XXW
		{
			get => new Int3(X,X,W);
		}

		public Int3 XYX
		{
			get => new Int3(X,Y,X);
		}

		public Int3 XYY
		{
			get => new Int3(X,Y,Y);
		}

		public Int3 XYZ
		{
			get => new Int3(X,Y,Z);
		}

		public Int3 XYW
		{
			get => new Int3(X,Y,W);
		}

		public Int3 XZX
		{
			get => new Int3(X,Z,X);
		}

		public Int3 XZY
		{
			get => new Int3(X,Z,Y);
		}

		public Int3 XZZ
		{
			get => new Int3(X,Z,Z);
		}

		public Int3 XZW
		{
			get => new Int3(X,Z,W);
		}

		public Int3 XWX
		{
			get => new Int3(X,W,X);
		}

		public Int3 XWY
		{
			get => new Int3(X,W,Y);
		}

		public Int3 XWZ
		{
			get => new Int3(X,W,Z);
		}

		public Int3 XWW
		{
			get => new Int3(X,W,W);
		}

		public Int3 YXX
		{
			get => new Int3(Y,X,X);
		}

		public Int3 YXY
		{
			get => new Int3(Y,X,Y);
		}

		public Int3 YXZ
		{
			get => new Int3(Y,X,Z);
		}

		public Int3 YXW
		{
			get => new Int3(Y,X,W);
		}

		public Int3 YYX
		{
			get => new Int3(Y,Y,X);
		}

		public Int3 YYY
		{
			get => new Int3(Y,Y,Y);
		}

		public Int3 YYZ
		{
			get => new Int3(Y,Y,Z);
		}

		public Int3 YYW
		{
			get => new Int3(Y,Y,W);
		}

		public Int3 YZX
		{
			get => new Int3(Y,Z,X);
		}

		public Int3 YZY
		{
			get => new Int3(Y,Z,Y);
		}

		public Int3 YZZ
		{
			get => new Int3(Y,Z,Z);
		}

		public Int3 YZW
		{
			get => new Int3(Y,Z,W);
		}

		public Int3 YWX
		{
			get => new Int3(Y,W,X);
		}

		public Int3 YWY
		{
			get => new Int3(Y,W,Y);
		}

		public Int3 YWZ
		{
			get => new Int3(Y,W,Z);
		}

		public Int3 YWW
		{
			get => new Int3(Y,W,W);
		}

		public Int3 ZXX
		{
			get => new Int3(Z,X,X);
		}

		public Int3 ZXY
		{
			get => new Int3(Z,X,Y);
		}

		public Int3 ZXZ
		{
			get => new Int3(Z,X,Z);
		}

		public Int3 ZXW
		{
			get => new Int3(Z,X,W);
		}

		public Int3 ZYX
		{
			get => new Int3(Z,Y,X);
		}

		public Int3 ZYY
		{
			get => new Int3(Z,Y,Y);
		}

		public Int3 ZYZ
		{
			get => new Int3(Z,Y,Z);
		}

		public Int3 ZYW
		{
			get => new Int3(Z,Y,W);
		}

		public Int3 ZZX
		{
			get => new Int3(Z,Z,X);
		}

		public Int3 ZZY
		{
			get => new Int3(Z,Z,Y);
		}

		public Int3 ZZZ
		{
			get => new Int3(Z,Z,Z);
		}

		public Int3 ZZW
		{
			get => new Int3(Z,Z,W);
		}

		public Int3 ZWX
		{
			get => new Int3(Z,W,X);
		}

		public Int3 ZWY
		{
			get => new Int3(Z,W,Y);
		}

		public Int3 ZWZ
		{
			get => new Int3(Z,W,Z);
		}

		public Int3 ZWW
		{
			get => new Int3(Z,W,W);
		}

		public Int3 WXX
		{
			get => new Int3(W,X,X);
		}

		public Int3 WXY
		{
			get => new Int3(W,X,Y);
		}

		public Int3 WXZ
		{
			get => new Int3(W,X,Z);
		}

		public Int3 WXW
		{
			get => new Int3(W,X,W);
		}

		public Int3 WYX
		{
			get => new Int3(W,Y,X);
		}

		public Int3 WYY
		{
			get => new Int3(W,Y,Y);
		}

		public Int3 WYZ
		{
			get => new Int3(W,Y,Z);
		}

		public Int3 WYW
		{
			get => new Int3(W,Y,W);
		}

		public Int3 WZX
		{
			get => new Int3(W,Z,X);
		}

		public Int3 WZY
		{
			get => new Int3(W,Z,Y);
		}

		public Int3 WZZ
		{
			get => new Int3(W,Z,Z);
		}

		public Int3 WZW
		{
			get => new Int3(W,Z,W);
		}

		public Int3 WWX
		{
			get => new Int3(W,W,X);
		}

		public Int3 WWY
		{
			get => new Int3(W,W,Y);
		}

		public Int3 WWZ
		{
			get => new Int3(W,W,Z);
		}

		public Int3 WWW
		{
			get => new Int3(W,W,W);
		}

		public Int4 XXXX
		{
			get => new Int4(X,X,X,X);
		}

		public Int4 XXXY
		{
			get => new Int4(X,X,X,Y);
		}

		public Int4 XXXZ
		{
			get => new Int4(X,X,X,Z);
		}

		public Int4 XXXW
		{
			get => new Int4(X,X,X,W);
		}

		public Int4 XXYX
		{
			get => new Int4(X,X,Y,X);
		}

		public Int4 XXYY
		{
			get => new Int4(X,X,Y,Y);
		}

		public Int4 XXYZ
		{
			get => new Int4(X,X,Y,Z);
		}

		public Int4 XXYW
		{
			get => new Int4(X,X,Y,W);
		}

		public Int4 XXZX
		{
			get => new Int4(X,X,Z,X);
		}

		public Int4 XXZY
		{
			get => new Int4(X,X,Z,Y);
		}

		public Int4 XXZZ
		{
			get => new Int4(X,X,Z,Z);
		}

		public Int4 XXZW
		{
			get => new Int4(X,X,Z,W);
		}

		public Int4 XXWX
		{
			get => new Int4(X,X,W,X);
		}

		public Int4 XXWY
		{
			get => new Int4(X,X,W,Y);
		}

		public Int4 XXWZ
		{
			get => new Int4(X,X,W,Z);
		}

		public Int4 XXWW
		{
			get => new Int4(X,X,W,W);
		}

		public Int4 XYXX
		{
			get => new Int4(X,Y,X,X);
		}

		public Int4 XYXY
		{
			get => new Int4(X,Y,X,Y);
		}

		public Int4 XYXZ
		{
			get => new Int4(X,Y,X,Z);
		}

		public Int4 XYXW
		{
			get => new Int4(X,Y,X,W);
		}

		public Int4 XYYX
		{
			get => new Int4(X,Y,Y,X);
		}

		public Int4 XYYY
		{
			get => new Int4(X,Y,Y,Y);
		}

		public Int4 XYYZ
		{
			get => new Int4(X,Y,Y,Z);
		}

		public Int4 XYYW
		{
			get => new Int4(X,Y,Y,W);
		}

		public Int4 XYZX
		{
			get => new Int4(X,Y,Z,X);
		}

		public Int4 XYZY
		{
			get => new Int4(X,Y,Z,Y);
		}

		public Int4 XYZZ
		{
			get => new Int4(X,Y,Z,Z);
		}

		public Int4 XYZW
		{
			get => new Int4(X,Y,Z,W);
		}

		public Int4 XYWX
		{
			get => new Int4(X,Y,W,X);
		}

		public Int4 XYWY
		{
			get => new Int4(X,Y,W,Y);
		}

		public Int4 XYWZ
		{
			get => new Int4(X,Y,W,Z);
		}

		public Int4 XYWW
		{
			get => new Int4(X,Y,W,W);
		}

		public Int4 XZXX
		{
			get => new Int4(X,Z,X,X);
		}

		public Int4 XZXY
		{
			get => new Int4(X,Z,X,Y);
		}

		public Int4 XZXZ
		{
			get => new Int4(X,Z,X,Z);
		}

		public Int4 XZXW
		{
			get => new Int4(X,Z,X,W);
		}

		public Int4 XZYX
		{
			get => new Int4(X,Z,Y,X);
		}

		public Int4 XZYY
		{
			get => new Int4(X,Z,Y,Y);
		}

		public Int4 XZYZ
		{
			get => new Int4(X,Z,Y,Z);
		}

		public Int4 XZYW
		{
			get => new Int4(X,Z,Y,W);
		}

		public Int4 XZZX
		{
			get => new Int4(X,Z,Z,X);
		}

		public Int4 XZZY
		{
			get => new Int4(X,Z,Z,Y);
		}

		public Int4 XZZZ
		{
			get => new Int4(X,Z,Z,Z);
		}

		public Int4 XZZW
		{
			get => new Int4(X,Z,Z,W);
		}

		public Int4 XZWX
		{
			get => new Int4(X,Z,W,X);
		}

		public Int4 XZWY
		{
			get => new Int4(X,Z,W,Y);
		}

		public Int4 XZWZ
		{
			get => new Int4(X,Z,W,Z);
		}

		public Int4 XZWW
		{
			get => new Int4(X,Z,W,W);
		}

		public Int4 XWXX
		{
			get => new Int4(X,W,X,X);
		}

		public Int4 XWXY
		{
			get => new Int4(X,W,X,Y);
		}

		public Int4 XWXZ
		{
			get => new Int4(X,W,X,Z);
		}

		public Int4 XWXW
		{
			get => new Int4(X,W,X,W);
		}

		public Int4 XWYX
		{
			get => new Int4(X,W,Y,X);
		}

		public Int4 XWYY
		{
			get => new Int4(X,W,Y,Y);
		}

		public Int4 XWYZ
		{
			get => new Int4(X,W,Y,Z);
		}

		public Int4 XWYW
		{
			get => new Int4(X,W,Y,W);
		}

		public Int4 XWZX
		{
			get => new Int4(X,W,Z,X);
		}

		public Int4 XWZY
		{
			get => new Int4(X,W,Z,Y);
		}

		public Int4 XWZZ
		{
			get => new Int4(X,W,Z,Z);
		}

		public Int4 XWZW
		{
			get => new Int4(X,W,Z,W);
		}

		public Int4 XWWX
		{
			get => new Int4(X,W,W,X);
		}

		public Int4 XWWY
		{
			get => new Int4(X,W,W,Y);
		}

		public Int4 XWWZ
		{
			get => new Int4(X,W,W,Z);
		}

		public Int4 XWWW
		{
			get => new Int4(X,W,W,W);
		}

		public Int4 YXXX
		{
			get => new Int4(Y,X,X,X);
		}

		public Int4 YXXY
		{
			get => new Int4(Y,X,X,Y);
		}

		public Int4 YXXZ
		{
			get => new Int4(Y,X,X,Z);
		}

		public Int4 YXXW
		{
			get => new Int4(Y,X,X,W);
		}

		public Int4 YXYX
		{
			get => new Int4(Y,X,Y,X);
		}

		public Int4 YXYY
		{
			get => new Int4(Y,X,Y,Y);
		}

		public Int4 YXYZ
		{
			get => new Int4(Y,X,Y,Z);
		}

		public Int4 YXYW
		{
			get => new Int4(Y,X,Y,W);
		}

		public Int4 YXZX
		{
			get => new Int4(Y,X,Z,X);
		}

		public Int4 YXZY
		{
			get => new Int4(Y,X,Z,Y);
		}

		public Int4 YXZZ
		{
			get => new Int4(Y,X,Z,Z);
		}

		public Int4 YXZW
		{
			get => new Int4(Y,X,Z,W);
		}

		public Int4 YXWX
		{
			get => new Int4(Y,X,W,X);
		}

		public Int4 YXWY
		{
			get => new Int4(Y,X,W,Y);
		}

		public Int4 YXWZ
		{
			get => new Int4(Y,X,W,Z);
		}

		public Int4 YXWW
		{
			get => new Int4(Y,X,W,W);
		}

		public Int4 YYXX
		{
			get => new Int4(Y,Y,X,X);
		}

		public Int4 YYXY
		{
			get => new Int4(Y,Y,X,Y);
		}

		public Int4 YYXZ
		{
			get => new Int4(Y,Y,X,Z);
		}

		public Int4 YYXW
		{
			get => new Int4(Y,Y,X,W);
		}

		public Int4 YYYX
		{
			get => new Int4(Y,Y,Y,X);
		}

		public Int4 YYYY
		{
			get => new Int4(Y,Y,Y,Y);
		}

		public Int4 YYYZ
		{
			get => new Int4(Y,Y,Y,Z);
		}

		public Int4 YYYW
		{
			get => new Int4(Y,Y,Y,W);
		}

		public Int4 YYZX
		{
			get => new Int4(Y,Y,Z,X);
		}

		public Int4 YYZY
		{
			get => new Int4(Y,Y,Z,Y);
		}

		public Int4 YYZZ
		{
			get => new Int4(Y,Y,Z,Z);
		}

		public Int4 YYZW
		{
			get => new Int4(Y,Y,Z,W);
		}

		public Int4 YYWX
		{
			get => new Int4(Y,Y,W,X);
		}

		public Int4 YYWY
		{
			get => new Int4(Y,Y,W,Y);
		}

		public Int4 YYWZ
		{
			get => new Int4(Y,Y,W,Z);
		}

		public Int4 YYWW
		{
			get => new Int4(Y,Y,W,W);
		}

		public Int4 YZXX
		{
			get => new Int4(Y,Z,X,X);
		}

		public Int4 YZXY
		{
			get => new Int4(Y,Z,X,Y);
		}

		public Int4 YZXZ
		{
			get => new Int4(Y,Z,X,Z);
		}

		public Int4 YZXW
		{
			get => new Int4(Y,Z,X,W);
		}

		public Int4 YZYX
		{
			get => new Int4(Y,Z,Y,X);
		}

		public Int4 YZYY
		{
			get => new Int4(Y,Z,Y,Y);
		}

		public Int4 YZYZ
		{
			get => new Int4(Y,Z,Y,Z);
		}

		public Int4 YZYW
		{
			get => new Int4(Y,Z,Y,W);
		}

		public Int4 YZZX
		{
			get => new Int4(Y,Z,Z,X);
		}

		public Int4 YZZY
		{
			get => new Int4(Y,Z,Z,Y);
		}

		public Int4 YZZZ
		{
			get => new Int4(Y,Z,Z,Z);
		}

		public Int4 YZZW
		{
			get => new Int4(Y,Z,Z,W);
		}

		public Int4 YZWX
		{
			get => new Int4(Y,Z,W,X);
		}

		public Int4 YZWY
		{
			get => new Int4(Y,Z,W,Y);
		}

		public Int4 YZWZ
		{
			get => new Int4(Y,Z,W,Z);
		}

		public Int4 YZWW
		{
			get => new Int4(Y,Z,W,W);
		}

		public Int4 YWXX
		{
			get => new Int4(Y,W,X,X);
		}

		public Int4 YWXY
		{
			get => new Int4(Y,W,X,Y);
		}

		public Int4 YWXZ
		{
			get => new Int4(Y,W,X,Z);
		}

		public Int4 YWXW
		{
			get => new Int4(Y,W,X,W);
		}

		public Int4 YWYX
		{
			get => new Int4(Y,W,Y,X);
		}

		public Int4 YWYY
		{
			get => new Int4(Y,W,Y,Y);
		}

		public Int4 YWYZ
		{
			get => new Int4(Y,W,Y,Z);
		}

		public Int4 YWYW
		{
			get => new Int4(Y,W,Y,W);
		}

		public Int4 YWZX
		{
			get => new Int4(Y,W,Z,X);
		}

		public Int4 YWZY
		{
			get => new Int4(Y,W,Z,Y);
		}

		public Int4 YWZZ
		{
			get => new Int4(Y,W,Z,Z);
		}

		public Int4 YWZW
		{
			get => new Int4(Y,W,Z,W);
		}

		public Int4 YWWX
		{
			get => new Int4(Y,W,W,X);
		}

		public Int4 YWWY
		{
			get => new Int4(Y,W,W,Y);
		}

		public Int4 YWWZ
		{
			get => new Int4(Y,W,W,Z);
		}

		public Int4 YWWW
		{
			get => new Int4(Y,W,W,W);
		}

		public Int4 ZXXX
		{
			get => new Int4(Z,X,X,X);
		}

		public Int4 ZXXY
		{
			get => new Int4(Z,X,X,Y);
		}

		public Int4 ZXXZ
		{
			get => new Int4(Z,X,X,Z);
		}

		public Int4 ZXXW
		{
			get => new Int4(Z,X,X,W);
		}

		public Int4 ZXYX
		{
			get => new Int4(Z,X,Y,X);
		}

		public Int4 ZXYY
		{
			get => new Int4(Z,X,Y,Y);
		}

		public Int4 ZXYZ
		{
			get => new Int4(Z,X,Y,Z);
		}

		public Int4 ZXYW
		{
			get => new Int4(Z,X,Y,W);
		}

		public Int4 ZXZX
		{
			get => new Int4(Z,X,Z,X);
		}

		public Int4 ZXZY
		{
			get => new Int4(Z,X,Z,Y);
		}

		public Int4 ZXZZ
		{
			get => new Int4(Z,X,Z,Z);
		}

		public Int4 ZXZW
		{
			get => new Int4(Z,X,Z,W);
		}

		public Int4 ZXWX
		{
			get => new Int4(Z,X,W,X);
		}

		public Int4 ZXWY
		{
			get => new Int4(Z,X,W,Y);
		}

		public Int4 ZXWZ
		{
			get => new Int4(Z,X,W,Z);
		}

		public Int4 ZXWW
		{
			get => new Int4(Z,X,W,W);
		}

		public Int4 ZYXX
		{
			get => new Int4(Z,Y,X,X);
		}

		public Int4 ZYXY
		{
			get => new Int4(Z,Y,X,Y);
		}

		public Int4 ZYXZ
		{
			get => new Int4(Z,Y,X,Z);
		}

		public Int4 ZYXW
		{
			get => new Int4(Z,Y,X,W);
		}

		public Int4 ZYYX
		{
			get => new Int4(Z,Y,Y,X);
		}

		public Int4 ZYYY
		{
			get => new Int4(Z,Y,Y,Y);
		}

		public Int4 ZYYZ
		{
			get => new Int4(Z,Y,Y,Z);
		}

		public Int4 ZYYW
		{
			get => new Int4(Z,Y,Y,W);
		}

		public Int4 ZYZX
		{
			get => new Int4(Z,Y,Z,X);
		}

		public Int4 ZYZY
		{
			get => new Int4(Z,Y,Z,Y);
		}

		public Int4 ZYZZ
		{
			get => new Int4(Z,Y,Z,Z);
		}

		public Int4 ZYZW
		{
			get => new Int4(Z,Y,Z,W);
		}

		public Int4 ZYWX
		{
			get => new Int4(Z,Y,W,X);
		}

		public Int4 ZYWY
		{
			get => new Int4(Z,Y,W,Y);
		}

		public Int4 ZYWZ
		{
			get => new Int4(Z,Y,W,Z);
		}

		public Int4 ZYWW
		{
			get => new Int4(Z,Y,W,W);
		}

		public Int4 ZZXX
		{
			get => new Int4(Z,Z,X,X);
		}

		public Int4 ZZXY
		{
			get => new Int4(Z,Z,X,Y);
		}

		public Int4 ZZXZ
		{
			get => new Int4(Z,Z,X,Z);
		}

		public Int4 ZZXW
		{
			get => new Int4(Z,Z,X,W);
		}

		public Int4 ZZYX
		{
			get => new Int4(Z,Z,Y,X);
		}

		public Int4 ZZYY
		{
			get => new Int4(Z,Z,Y,Y);
		}

		public Int4 ZZYZ
		{
			get => new Int4(Z,Z,Y,Z);
		}

		public Int4 ZZYW
		{
			get => new Int4(Z,Z,Y,W);
		}

		public Int4 ZZZX
		{
			get => new Int4(Z,Z,Z,X);
		}

		public Int4 ZZZY
		{
			get => new Int4(Z,Z,Z,Y);
		}

		public Int4 ZZZZ
		{
			get => new Int4(Z,Z,Z,Z);
		}

		public Int4 ZZZW
		{
			get => new Int4(Z,Z,Z,W);
		}

		public Int4 ZZWX
		{
			get => new Int4(Z,Z,W,X);
		}

		public Int4 ZZWY
		{
			get => new Int4(Z,Z,W,Y);
		}

		public Int4 ZZWZ
		{
			get => new Int4(Z,Z,W,Z);
		}

		public Int4 ZZWW
		{
			get => new Int4(Z,Z,W,W);
		}

		public Int4 ZWXX
		{
			get => new Int4(Z,W,X,X);
		}

		public Int4 ZWXY
		{
			get => new Int4(Z,W,X,Y);
		}

		public Int4 ZWXZ
		{
			get => new Int4(Z,W,X,Z);
		}

		public Int4 ZWXW
		{
			get => new Int4(Z,W,X,W);
		}

		public Int4 ZWYX
		{
			get => new Int4(Z,W,Y,X);
		}

		public Int4 ZWYY
		{
			get => new Int4(Z,W,Y,Y);
		}

		public Int4 ZWYZ
		{
			get => new Int4(Z,W,Y,Z);
		}

		public Int4 ZWYW
		{
			get => new Int4(Z,W,Y,W);
		}

		public Int4 ZWZX
		{
			get => new Int4(Z,W,Z,X);
		}

		public Int4 ZWZY
		{
			get => new Int4(Z,W,Z,Y);
		}

		public Int4 ZWZZ
		{
			get => new Int4(Z,W,Z,Z);
		}

		public Int4 ZWZW
		{
			get => new Int4(Z,W,Z,W);
		}

		public Int4 ZWWX
		{
			get => new Int4(Z,W,W,X);
		}

		public Int4 ZWWY
		{
			get => new Int4(Z,W,W,Y);
		}

		public Int4 ZWWZ
		{
			get => new Int4(Z,W,W,Z);
		}

		public Int4 ZWWW
		{
			get => new Int4(Z,W,W,W);
		}

		public Int4 WXXX
		{
			get => new Int4(W,X,X,X);
		}

		public Int4 WXXY
		{
			get => new Int4(W,X,X,Y);
		}

		public Int4 WXXZ
		{
			get => new Int4(W,X,X,Z);
		}

		public Int4 WXXW
		{
			get => new Int4(W,X,X,W);
		}

		public Int4 WXYX
		{
			get => new Int4(W,X,Y,X);
		}

		public Int4 WXYY
		{
			get => new Int4(W,X,Y,Y);
		}

		public Int4 WXYZ
		{
			get => new Int4(W,X,Y,Z);
		}

		public Int4 WXYW
		{
			get => new Int4(W,X,Y,W);
		}

		public Int4 WXZX
		{
			get => new Int4(W,X,Z,X);
		}

		public Int4 WXZY
		{
			get => new Int4(W,X,Z,Y);
		}

		public Int4 WXZZ
		{
			get => new Int4(W,X,Z,Z);
		}

		public Int4 WXZW
		{
			get => new Int4(W,X,Z,W);
		}

		public Int4 WXWX
		{
			get => new Int4(W,X,W,X);
		}

		public Int4 WXWY
		{
			get => new Int4(W,X,W,Y);
		}

		public Int4 WXWZ
		{
			get => new Int4(W,X,W,Z);
		}

		public Int4 WXWW
		{
			get => new Int4(W,X,W,W);
		}

		public Int4 WYXX
		{
			get => new Int4(W,Y,X,X);
		}

		public Int4 WYXY
		{
			get => new Int4(W,Y,X,Y);
		}

		public Int4 WYXZ
		{
			get => new Int4(W,Y,X,Z);
		}

		public Int4 WYXW
		{
			get => new Int4(W,Y,X,W);
		}

		public Int4 WYYX
		{
			get => new Int4(W,Y,Y,X);
		}

		public Int4 WYYY
		{
			get => new Int4(W,Y,Y,Y);
		}

		public Int4 WYYZ
		{
			get => new Int4(W,Y,Y,Z);
		}

		public Int4 WYYW
		{
			get => new Int4(W,Y,Y,W);
		}

		public Int4 WYZX
		{
			get => new Int4(W,Y,Z,X);
		}

		public Int4 WYZY
		{
			get => new Int4(W,Y,Z,Y);
		}

		public Int4 WYZZ
		{
			get => new Int4(W,Y,Z,Z);
		}

		public Int4 WYZW
		{
			get => new Int4(W,Y,Z,W);
		}

		public Int4 WYWX
		{
			get => new Int4(W,Y,W,X);
		}

		public Int4 WYWY
		{
			get => new Int4(W,Y,W,Y);
		}

		public Int4 WYWZ
		{
			get => new Int4(W,Y,W,Z);
		}

		public Int4 WYWW
		{
			get => new Int4(W,Y,W,W);
		}

		public Int4 WZXX
		{
			get => new Int4(W,Z,X,X);
		}

		public Int4 WZXY
		{
			get => new Int4(W,Z,X,Y);
		}

		public Int4 WZXZ
		{
			get => new Int4(W,Z,X,Z);
		}

		public Int4 WZXW
		{
			get => new Int4(W,Z,X,W);
		}

		public Int4 WZYX
		{
			get => new Int4(W,Z,Y,X);
		}

		public Int4 WZYY
		{
			get => new Int4(W,Z,Y,Y);
		}

		public Int4 WZYZ
		{
			get => new Int4(W,Z,Y,Z);
		}

		public Int4 WZYW
		{
			get => new Int4(W,Z,Y,W);
		}

		public Int4 WZZX
		{
			get => new Int4(W,Z,Z,X);
		}

		public Int4 WZZY
		{
			get => new Int4(W,Z,Z,Y);
		}

		public Int4 WZZZ
		{
			get => new Int4(W,Z,Z,Z);
		}

		public Int4 WZZW
		{
			get => new Int4(W,Z,Z,W);
		}

		public Int4 WZWX
		{
			get => new Int4(W,Z,W,X);
		}

		public Int4 WZWY
		{
			get => new Int4(W,Z,W,Y);
		}

		public Int4 WZWZ
		{
			get => new Int4(W,Z,W,Z);
		}

		public Int4 WZWW
		{
			get => new Int4(W,Z,W,W);
		}

		public Int4 WWXX
		{
			get => new Int4(W,W,X,X);
		}

		public Int4 WWXY
		{
			get => new Int4(W,W,X,Y);
		}

		public Int4 WWXZ
		{
			get => new Int4(W,W,X,Z);
		}

		public Int4 WWXW
		{
			get => new Int4(W,W,X,W);
		}

		public Int4 WWYX
		{
			get => new Int4(W,W,Y,X);
		}

		public Int4 WWYY
		{
			get => new Int4(W,W,Y,Y);
		}

		public Int4 WWYZ
		{
			get => new Int4(W,W,Y,Z);
		}

		public Int4 WWYW
		{
			get => new Int4(W,W,Y,W);
		}

		public Int4 WWZX
		{
			get => new Int4(W,W,Z,X);
		}

		public Int4 WWZY
		{
			get => new Int4(W,W,Z,Y);
		}

		public Int4 WWZZ
		{
			get => new Int4(W,W,Z,Z);
		}

		public Int4 WWZW
		{
			get => new Int4(W,W,Z,W);
		}

		public Int4 WWWX
		{
			get => new Int4(W,W,W,X);
		}

		public Int4 WWWY
		{
			get => new Int4(W,W,W,Y);
		}

		public Int4 WWWZ
		{
			get => new Int4(W,W,W,Z);
		}

		public Int4 WWWW
		{
			get => new Int4(W,W,W,W);
		}

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
