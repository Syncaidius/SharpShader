using System.Runtime.InteropServices;

namespace SharpShader
{
	public struct Double4
	{
		public double X;

		public double Y;

		public double Z;

		public double W;

		public Double4(double x, double y, double z, double w)
		{
			X = x;
			Y = y;
			Z = z;
			W = w;
		}

		public Double2 XX
		{
			get => new Double2(X,X);
		}

		public Double2 XY
		{
			get => new Double2(X,Y);
		}

		public Double2 XZ
		{
			get => new Double2(X,Z);
		}

		public Double2 XW
		{
			get => new Double2(X,W);
		}

		public Double2 YX
		{
			get => new Double2(Y,X);
		}

		public Double2 YY
		{
			get => new Double2(Y,Y);
		}

		public Double2 YZ
		{
			get => new Double2(Y,Z);
		}

		public Double2 YW
		{
			get => new Double2(Y,W);
		}

		public Double2 ZX
		{
			get => new Double2(Z,X);
		}

		public Double2 ZY
		{
			get => new Double2(Z,Y);
		}

		public Double2 ZZ
		{
			get => new Double2(Z,Z);
		}

		public Double2 ZW
		{
			get => new Double2(Z,W);
		}

		public Double2 WX
		{
			get => new Double2(W,X);
		}

		public Double2 WY
		{
			get => new Double2(W,Y);
		}

		public Double2 WZ
		{
			get => new Double2(W,Z);
		}

		public Double2 WW
		{
			get => new Double2(W,W);
		}

		public Double3 XXX
		{
			get => new Double3(X,X,X);
		}

		public Double3 XXY
		{
			get => new Double3(X,X,Y);
		}

		public Double3 XXZ
		{
			get => new Double3(X,X,Z);
		}

		public Double3 XXW
		{
			get => new Double3(X,X,W);
		}

		public Double3 XYX
		{
			get => new Double3(X,Y,X);
		}

		public Double3 XYY
		{
			get => new Double3(X,Y,Y);
		}

		public Double3 XYZ
		{
			get => new Double3(X,Y,Z);
		}

		public Double3 XYW
		{
			get => new Double3(X,Y,W);
		}

		public Double3 XZX
		{
			get => new Double3(X,Z,X);
		}

		public Double3 XZY
		{
			get => new Double3(X,Z,Y);
		}

		public Double3 XZZ
		{
			get => new Double3(X,Z,Z);
		}

		public Double3 XZW
		{
			get => new Double3(X,Z,W);
		}

		public Double3 XWX
		{
			get => new Double3(X,W,X);
		}

		public Double3 XWY
		{
			get => new Double3(X,W,Y);
		}

		public Double3 XWZ
		{
			get => new Double3(X,W,Z);
		}

		public Double3 XWW
		{
			get => new Double3(X,W,W);
		}

		public Double3 YXX
		{
			get => new Double3(Y,X,X);
		}

		public Double3 YXY
		{
			get => new Double3(Y,X,Y);
		}

		public Double3 YXZ
		{
			get => new Double3(Y,X,Z);
		}

		public Double3 YXW
		{
			get => new Double3(Y,X,W);
		}

		public Double3 YYX
		{
			get => new Double3(Y,Y,X);
		}

		public Double3 YYY
		{
			get => new Double3(Y,Y,Y);
		}

		public Double3 YYZ
		{
			get => new Double3(Y,Y,Z);
		}

		public Double3 YYW
		{
			get => new Double3(Y,Y,W);
		}

		public Double3 YZX
		{
			get => new Double3(Y,Z,X);
		}

		public Double3 YZY
		{
			get => new Double3(Y,Z,Y);
		}

		public Double3 YZZ
		{
			get => new Double3(Y,Z,Z);
		}

		public Double3 YZW
		{
			get => new Double3(Y,Z,W);
		}

		public Double3 YWX
		{
			get => new Double3(Y,W,X);
		}

		public Double3 YWY
		{
			get => new Double3(Y,W,Y);
		}

		public Double3 YWZ
		{
			get => new Double3(Y,W,Z);
		}

		public Double3 YWW
		{
			get => new Double3(Y,W,W);
		}

		public Double3 ZXX
		{
			get => new Double3(Z,X,X);
		}

		public Double3 ZXY
		{
			get => new Double3(Z,X,Y);
		}

		public Double3 ZXZ
		{
			get => new Double3(Z,X,Z);
		}

		public Double3 ZXW
		{
			get => new Double3(Z,X,W);
		}

		public Double3 ZYX
		{
			get => new Double3(Z,Y,X);
		}

		public Double3 ZYY
		{
			get => new Double3(Z,Y,Y);
		}

		public Double3 ZYZ
		{
			get => new Double3(Z,Y,Z);
		}

		public Double3 ZYW
		{
			get => new Double3(Z,Y,W);
		}

		public Double3 ZZX
		{
			get => new Double3(Z,Z,X);
		}

		public Double3 ZZY
		{
			get => new Double3(Z,Z,Y);
		}

		public Double3 ZZZ
		{
			get => new Double3(Z,Z,Z);
		}

		public Double3 ZZW
		{
			get => new Double3(Z,Z,W);
		}

		public Double3 ZWX
		{
			get => new Double3(Z,W,X);
		}

		public Double3 ZWY
		{
			get => new Double3(Z,W,Y);
		}

		public Double3 ZWZ
		{
			get => new Double3(Z,W,Z);
		}

		public Double3 ZWW
		{
			get => new Double3(Z,W,W);
		}

		public Double3 WXX
		{
			get => new Double3(W,X,X);
		}

		public Double3 WXY
		{
			get => new Double3(W,X,Y);
		}

		public Double3 WXZ
		{
			get => new Double3(W,X,Z);
		}

		public Double3 WXW
		{
			get => new Double3(W,X,W);
		}

		public Double3 WYX
		{
			get => new Double3(W,Y,X);
		}

		public Double3 WYY
		{
			get => new Double3(W,Y,Y);
		}

		public Double3 WYZ
		{
			get => new Double3(W,Y,Z);
		}

		public Double3 WYW
		{
			get => new Double3(W,Y,W);
		}

		public Double3 WZX
		{
			get => new Double3(W,Z,X);
		}

		public Double3 WZY
		{
			get => new Double3(W,Z,Y);
		}

		public Double3 WZZ
		{
			get => new Double3(W,Z,Z);
		}

		public Double3 WZW
		{
			get => new Double3(W,Z,W);
		}

		public Double3 WWX
		{
			get => new Double3(W,W,X);
		}

		public Double3 WWY
		{
			get => new Double3(W,W,Y);
		}

		public Double3 WWZ
		{
			get => new Double3(W,W,Z);
		}

		public Double3 WWW
		{
			get => new Double3(W,W,W);
		}

		public Double4 XXXX
		{
			get => new Double4(X,X,X,X);
		}

		public Double4 XXXY
		{
			get => new Double4(X,X,X,Y);
		}

		public Double4 XXXZ
		{
			get => new Double4(X,X,X,Z);
		}

		public Double4 XXXW
		{
			get => new Double4(X,X,X,W);
		}

		public Double4 XXYX
		{
			get => new Double4(X,X,Y,X);
		}

		public Double4 XXYY
		{
			get => new Double4(X,X,Y,Y);
		}

		public Double4 XXYZ
		{
			get => new Double4(X,X,Y,Z);
		}

		public Double4 XXYW
		{
			get => new Double4(X,X,Y,W);
		}

		public Double4 XXZX
		{
			get => new Double4(X,X,Z,X);
		}

		public Double4 XXZY
		{
			get => new Double4(X,X,Z,Y);
		}

		public Double4 XXZZ
		{
			get => new Double4(X,X,Z,Z);
		}

		public Double4 XXZW
		{
			get => new Double4(X,X,Z,W);
		}

		public Double4 XXWX
		{
			get => new Double4(X,X,W,X);
		}

		public Double4 XXWY
		{
			get => new Double4(X,X,W,Y);
		}

		public Double4 XXWZ
		{
			get => new Double4(X,X,W,Z);
		}

		public Double4 XXWW
		{
			get => new Double4(X,X,W,W);
		}

		public Double4 XYXX
		{
			get => new Double4(X,Y,X,X);
		}

		public Double4 XYXY
		{
			get => new Double4(X,Y,X,Y);
		}

		public Double4 XYXZ
		{
			get => new Double4(X,Y,X,Z);
		}

		public Double4 XYXW
		{
			get => new Double4(X,Y,X,W);
		}

		public Double4 XYYX
		{
			get => new Double4(X,Y,Y,X);
		}

		public Double4 XYYY
		{
			get => new Double4(X,Y,Y,Y);
		}

		public Double4 XYYZ
		{
			get => new Double4(X,Y,Y,Z);
		}

		public Double4 XYYW
		{
			get => new Double4(X,Y,Y,W);
		}

		public Double4 XYZX
		{
			get => new Double4(X,Y,Z,X);
		}

		public Double4 XYZY
		{
			get => new Double4(X,Y,Z,Y);
		}

		public Double4 XYZZ
		{
			get => new Double4(X,Y,Z,Z);
		}

		public Double4 XYZW
		{
			get => new Double4(X,Y,Z,W);
		}

		public Double4 XYWX
		{
			get => new Double4(X,Y,W,X);
		}

		public Double4 XYWY
		{
			get => new Double4(X,Y,W,Y);
		}

		public Double4 XYWZ
		{
			get => new Double4(X,Y,W,Z);
		}

		public Double4 XYWW
		{
			get => new Double4(X,Y,W,W);
		}

		public Double4 XZXX
		{
			get => new Double4(X,Z,X,X);
		}

		public Double4 XZXY
		{
			get => new Double4(X,Z,X,Y);
		}

		public Double4 XZXZ
		{
			get => new Double4(X,Z,X,Z);
		}

		public Double4 XZXW
		{
			get => new Double4(X,Z,X,W);
		}

		public Double4 XZYX
		{
			get => new Double4(X,Z,Y,X);
		}

		public Double4 XZYY
		{
			get => new Double4(X,Z,Y,Y);
		}

		public Double4 XZYZ
		{
			get => new Double4(X,Z,Y,Z);
		}

		public Double4 XZYW
		{
			get => new Double4(X,Z,Y,W);
		}

		public Double4 XZZX
		{
			get => new Double4(X,Z,Z,X);
		}

		public Double4 XZZY
		{
			get => new Double4(X,Z,Z,Y);
		}

		public Double4 XZZZ
		{
			get => new Double4(X,Z,Z,Z);
		}

		public Double4 XZZW
		{
			get => new Double4(X,Z,Z,W);
		}

		public Double4 XZWX
		{
			get => new Double4(X,Z,W,X);
		}

		public Double4 XZWY
		{
			get => new Double4(X,Z,W,Y);
		}

		public Double4 XZWZ
		{
			get => new Double4(X,Z,W,Z);
		}

		public Double4 XZWW
		{
			get => new Double4(X,Z,W,W);
		}

		public Double4 XWXX
		{
			get => new Double4(X,W,X,X);
		}

		public Double4 XWXY
		{
			get => new Double4(X,W,X,Y);
		}

		public Double4 XWXZ
		{
			get => new Double4(X,W,X,Z);
		}

		public Double4 XWXW
		{
			get => new Double4(X,W,X,W);
		}

		public Double4 XWYX
		{
			get => new Double4(X,W,Y,X);
		}

		public Double4 XWYY
		{
			get => new Double4(X,W,Y,Y);
		}

		public Double4 XWYZ
		{
			get => new Double4(X,W,Y,Z);
		}

		public Double4 XWYW
		{
			get => new Double4(X,W,Y,W);
		}

		public Double4 XWZX
		{
			get => new Double4(X,W,Z,X);
		}

		public Double4 XWZY
		{
			get => new Double4(X,W,Z,Y);
		}

		public Double4 XWZZ
		{
			get => new Double4(X,W,Z,Z);
		}

		public Double4 XWZW
		{
			get => new Double4(X,W,Z,W);
		}

		public Double4 XWWX
		{
			get => new Double4(X,W,W,X);
		}

		public Double4 XWWY
		{
			get => new Double4(X,W,W,Y);
		}

		public Double4 XWWZ
		{
			get => new Double4(X,W,W,Z);
		}

		public Double4 XWWW
		{
			get => new Double4(X,W,W,W);
		}

		public Double4 YXXX
		{
			get => new Double4(Y,X,X,X);
		}

		public Double4 YXXY
		{
			get => new Double4(Y,X,X,Y);
		}

		public Double4 YXXZ
		{
			get => new Double4(Y,X,X,Z);
		}

		public Double4 YXXW
		{
			get => new Double4(Y,X,X,W);
		}

		public Double4 YXYX
		{
			get => new Double4(Y,X,Y,X);
		}

		public Double4 YXYY
		{
			get => new Double4(Y,X,Y,Y);
		}

		public Double4 YXYZ
		{
			get => new Double4(Y,X,Y,Z);
		}

		public Double4 YXYW
		{
			get => new Double4(Y,X,Y,W);
		}

		public Double4 YXZX
		{
			get => new Double4(Y,X,Z,X);
		}

		public Double4 YXZY
		{
			get => new Double4(Y,X,Z,Y);
		}

		public Double4 YXZZ
		{
			get => new Double4(Y,X,Z,Z);
		}

		public Double4 YXZW
		{
			get => new Double4(Y,X,Z,W);
		}

		public Double4 YXWX
		{
			get => new Double4(Y,X,W,X);
		}

		public Double4 YXWY
		{
			get => new Double4(Y,X,W,Y);
		}

		public Double4 YXWZ
		{
			get => new Double4(Y,X,W,Z);
		}

		public Double4 YXWW
		{
			get => new Double4(Y,X,W,W);
		}

		public Double4 YYXX
		{
			get => new Double4(Y,Y,X,X);
		}

		public Double4 YYXY
		{
			get => new Double4(Y,Y,X,Y);
		}

		public Double4 YYXZ
		{
			get => new Double4(Y,Y,X,Z);
		}

		public Double4 YYXW
		{
			get => new Double4(Y,Y,X,W);
		}

		public Double4 YYYX
		{
			get => new Double4(Y,Y,Y,X);
		}

		public Double4 YYYY
		{
			get => new Double4(Y,Y,Y,Y);
		}

		public Double4 YYYZ
		{
			get => new Double4(Y,Y,Y,Z);
		}

		public Double4 YYYW
		{
			get => new Double4(Y,Y,Y,W);
		}

		public Double4 YYZX
		{
			get => new Double4(Y,Y,Z,X);
		}

		public Double4 YYZY
		{
			get => new Double4(Y,Y,Z,Y);
		}

		public Double4 YYZZ
		{
			get => new Double4(Y,Y,Z,Z);
		}

		public Double4 YYZW
		{
			get => new Double4(Y,Y,Z,W);
		}

		public Double4 YYWX
		{
			get => new Double4(Y,Y,W,X);
		}

		public Double4 YYWY
		{
			get => new Double4(Y,Y,W,Y);
		}

		public Double4 YYWZ
		{
			get => new Double4(Y,Y,W,Z);
		}

		public Double4 YYWW
		{
			get => new Double4(Y,Y,W,W);
		}

		public Double4 YZXX
		{
			get => new Double4(Y,Z,X,X);
		}

		public Double4 YZXY
		{
			get => new Double4(Y,Z,X,Y);
		}

		public Double4 YZXZ
		{
			get => new Double4(Y,Z,X,Z);
		}

		public Double4 YZXW
		{
			get => new Double4(Y,Z,X,W);
		}

		public Double4 YZYX
		{
			get => new Double4(Y,Z,Y,X);
		}

		public Double4 YZYY
		{
			get => new Double4(Y,Z,Y,Y);
		}

		public Double4 YZYZ
		{
			get => new Double4(Y,Z,Y,Z);
		}

		public Double4 YZYW
		{
			get => new Double4(Y,Z,Y,W);
		}

		public Double4 YZZX
		{
			get => new Double4(Y,Z,Z,X);
		}

		public Double4 YZZY
		{
			get => new Double4(Y,Z,Z,Y);
		}

		public Double4 YZZZ
		{
			get => new Double4(Y,Z,Z,Z);
		}

		public Double4 YZZW
		{
			get => new Double4(Y,Z,Z,W);
		}

		public Double4 YZWX
		{
			get => new Double4(Y,Z,W,X);
		}

		public Double4 YZWY
		{
			get => new Double4(Y,Z,W,Y);
		}

		public Double4 YZWZ
		{
			get => new Double4(Y,Z,W,Z);
		}

		public Double4 YZWW
		{
			get => new Double4(Y,Z,W,W);
		}

		public Double4 YWXX
		{
			get => new Double4(Y,W,X,X);
		}

		public Double4 YWXY
		{
			get => new Double4(Y,W,X,Y);
		}

		public Double4 YWXZ
		{
			get => new Double4(Y,W,X,Z);
		}

		public Double4 YWXW
		{
			get => new Double4(Y,W,X,W);
		}

		public Double4 YWYX
		{
			get => new Double4(Y,W,Y,X);
		}

		public Double4 YWYY
		{
			get => new Double4(Y,W,Y,Y);
		}

		public Double4 YWYZ
		{
			get => new Double4(Y,W,Y,Z);
		}

		public Double4 YWYW
		{
			get => new Double4(Y,W,Y,W);
		}

		public Double4 YWZX
		{
			get => new Double4(Y,W,Z,X);
		}

		public Double4 YWZY
		{
			get => new Double4(Y,W,Z,Y);
		}

		public Double4 YWZZ
		{
			get => new Double4(Y,W,Z,Z);
		}

		public Double4 YWZW
		{
			get => new Double4(Y,W,Z,W);
		}

		public Double4 YWWX
		{
			get => new Double4(Y,W,W,X);
		}

		public Double4 YWWY
		{
			get => new Double4(Y,W,W,Y);
		}

		public Double4 YWWZ
		{
			get => new Double4(Y,W,W,Z);
		}

		public Double4 YWWW
		{
			get => new Double4(Y,W,W,W);
		}

		public Double4 ZXXX
		{
			get => new Double4(Z,X,X,X);
		}

		public Double4 ZXXY
		{
			get => new Double4(Z,X,X,Y);
		}

		public Double4 ZXXZ
		{
			get => new Double4(Z,X,X,Z);
		}

		public Double4 ZXXW
		{
			get => new Double4(Z,X,X,W);
		}

		public Double4 ZXYX
		{
			get => new Double4(Z,X,Y,X);
		}

		public Double4 ZXYY
		{
			get => new Double4(Z,X,Y,Y);
		}

		public Double4 ZXYZ
		{
			get => new Double4(Z,X,Y,Z);
		}

		public Double4 ZXYW
		{
			get => new Double4(Z,X,Y,W);
		}

		public Double4 ZXZX
		{
			get => new Double4(Z,X,Z,X);
		}

		public Double4 ZXZY
		{
			get => new Double4(Z,X,Z,Y);
		}

		public Double4 ZXZZ
		{
			get => new Double4(Z,X,Z,Z);
		}

		public Double4 ZXZW
		{
			get => new Double4(Z,X,Z,W);
		}

		public Double4 ZXWX
		{
			get => new Double4(Z,X,W,X);
		}

		public Double4 ZXWY
		{
			get => new Double4(Z,X,W,Y);
		}

		public Double4 ZXWZ
		{
			get => new Double4(Z,X,W,Z);
		}

		public Double4 ZXWW
		{
			get => new Double4(Z,X,W,W);
		}

		public Double4 ZYXX
		{
			get => new Double4(Z,Y,X,X);
		}

		public Double4 ZYXY
		{
			get => new Double4(Z,Y,X,Y);
		}

		public Double4 ZYXZ
		{
			get => new Double4(Z,Y,X,Z);
		}

		public Double4 ZYXW
		{
			get => new Double4(Z,Y,X,W);
		}

		public Double4 ZYYX
		{
			get => new Double4(Z,Y,Y,X);
		}

		public Double4 ZYYY
		{
			get => new Double4(Z,Y,Y,Y);
		}

		public Double4 ZYYZ
		{
			get => new Double4(Z,Y,Y,Z);
		}

		public Double4 ZYYW
		{
			get => new Double4(Z,Y,Y,W);
		}

		public Double4 ZYZX
		{
			get => new Double4(Z,Y,Z,X);
		}

		public Double4 ZYZY
		{
			get => new Double4(Z,Y,Z,Y);
		}

		public Double4 ZYZZ
		{
			get => new Double4(Z,Y,Z,Z);
		}

		public Double4 ZYZW
		{
			get => new Double4(Z,Y,Z,W);
		}

		public Double4 ZYWX
		{
			get => new Double4(Z,Y,W,X);
		}

		public Double4 ZYWY
		{
			get => new Double4(Z,Y,W,Y);
		}

		public Double4 ZYWZ
		{
			get => new Double4(Z,Y,W,Z);
		}

		public Double4 ZYWW
		{
			get => new Double4(Z,Y,W,W);
		}

		public Double4 ZZXX
		{
			get => new Double4(Z,Z,X,X);
		}

		public Double4 ZZXY
		{
			get => new Double4(Z,Z,X,Y);
		}

		public Double4 ZZXZ
		{
			get => new Double4(Z,Z,X,Z);
		}

		public Double4 ZZXW
		{
			get => new Double4(Z,Z,X,W);
		}

		public Double4 ZZYX
		{
			get => new Double4(Z,Z,Y,X);
		}

		public Double4 ZZYY
		{
			get => new Double4(Z,Z,Y,Y);
		}

		public Double4 ZZYZ
		{
			get => new Double4(Z,Z,Y,Z);
		}

		public Double4 ZZYW
		{
			get => new Double4(Z,Z,Y,W);
		}

		public Double4 ZZZX
		{
			get => new Double4(Z,Z,Z,X);
		}

		public Double4 ZZZY
		{
			get => new Double4(Z,Z,Z,Y);
		}

		public Double4 ZZZZ
		{
			get => new Double4(Z,Z,Z,Z);
		}

		public Double4 ZZZW
		{
			get => new Double4(Z,Z,Z,W);
		}

		public Double4 ZZWX
		{
			get => new Double4(Z,Z,W,X);
		}

		public Double4 ZZWY
		{
			get => new Double4(Z,Z,W,Y);
		}

		public Double4 ZZWZ
		{
			get => new Double4(Z,Z,W,Z);
		}

		public Double4 ZZWW
		{
			get => new Double4(Z,Z,W,W);
		}

		public Double4 ZWXX
		{
			get => new Double4(Z,W,X,X);
		}

		public Double4 ZWXY
		{
			get => new Double4(Z,W,X,Y);
		}

		public Double4 ZWXZ
		{
			get => new Double4(Z,W,X,Z);
		}

		public Double4 ZWXW
		{
			get => new Double4(Z,W,X,W);
		}

		public Double4 ZWYX
		{
			get => new Double4(Z,W,Y,X);
		}

		public Double4 ZWYY
		{
			get => new Double4(Z,W,Y,Y);
		}

		public Double4 ZWYZ
		{
			get => new Double4(Z,W,Y,Z);
		}

		public Double4 ZWYW
		{
			get => new Double4(Z,W,Y,W);
		}

		public Double4 ZWZX
		{
			get => new Double4(Z,W,Z,X);
		}

		public Double4 ZWZY
		{
			get => new Double4(Z,W,Z,Y);
		}

		public Double4 ZWZZ
		{
			get => new Double4(Z,W,Z,Z);
		}

		public Double4 ZWZW
		{
			get => new Double4(Z,W,Z,W);
		}

		public Double4 ZWWX
		{
			get => new Double4(Z,W,W,X);
		}

		public Double4 ZWWY
		{
			get => new Double4(Z,W,W,Y);
		}

		public Double4 ZWWZ
		{
			get => new Double4(Z,W,W,Z);
		}

		public Double4 ZWWW
		{
			get => new Double4(Z,W,W,W);
		}

		public Double4 WXXX
		{
			get => new Double4(W,X,X,X);
		}

		public Double4 WXXY
		{
			get => new Double4(W,X,X,Y);
		}

		public Double4 WXXZ
		{
			get => new Double4(W,X,X,Z);
		}

		public Double4 WXXW
		{
			get => new Double4(W,X,X,W);
		}

		public Double4 WXYX
		{
			get => new Double4(W,X,Y,X);
		}

		public Double4 WXYY
		{
			get => new Double4(W,X,Y,Y);
		}

		public Double4 WXYZ
		{
			get => new Double4(W,X,Y,Z);
		}

		public Double4 WXYW
		{
			get => new Double4(W,X,Y,W);
		}

		public Double4 WXZX
		{
			get => new Double4(W,X,Z,X);
		}

		public Double4 WXZY
		{
			get => new Double4(W,X,Z,Y);
		}

		public Double4 WXZZ
		{
			get => new Double4(W,X,Z,Z);
		}

		public Double4 WXZW
		{
			get => new Double4(W,X,Z,W);
		}

		public Double4 WXWX
		{
			get => new Double4(W,X,W,X);
		}

		public Double4 WXWY
		{
			get => new Double4(W,X,W,Y);
		}

		public Double4 WXWZ
		{
			get => new Double4(W,X,W,Z);
		}

		public Double4 WXWW
		{
			get => new Double4(W,X,W,W);
		}

		public Double4 WYXX
		{
			get => new Double4(W,Y,X,X);
		}

		public Double4 WYXY
		{
			get => new Double4(W,Y,X,Y);
		}

		public Double4 WYXZ
		{
			get => new Double4(W,Y,X,Z);
		}

		public Double4 WYXW
		{
			get => new Double4(W,Y,X,W);
		}

		public Double4 WYYX
		{
			get => new Double4(W,Y,Y,X);
		}

		public Double4 WYYY
		{
			get => new Double4(W,Y,Y,Y);
		}

		public Double4 WYYZ
		{
			get => new Double4(W,Y,Y,Z);
		}

		public Double4 WYYW
		{
			get => new Double4(W,Y,Y,W);
		}

		public Double4 WYZX
		{
			get => new Double4(W,Y,Z,X);
		}

		public Double4 WYZY
		{
			get => new Double4(W,Y,Z,Y);
		}

		public Double4 WYZZ
		{
			get => new Double4(W,Y,Z,Z);
		}

		public Double4 WYZW
		{
			get => new Double4(W,Y,Z,W);
		}

		public Double4 WYWX
		{
			get => new Double4(W,Y,W,X);
		}

		public Double4 WYWY
		{
			get => new Double4(W,Y,W,Y);
		}

		public Double4 WYWZ
		{
			get => new Double4(W,Y,W,Z);
		}

		public Double4 WYWW
		{
			get => new Double4(W,Y,W,W);
		}

		public Double4 WZXX
		{
			get => new Double4(W,Z,X,X);
		}

		public Double4 WZXY
		{
			get => new Double4(W,Z,X,Y);
		}

		public Double4 WZXZ
		{
			get => new Double4(W,Z,X,Z);
		}

		public Double4 WZXW
		{
			get => new Double4(W,Z,X,W);
		}

		public Double4 WZYX
		{
			get => new Double4(W,Z,Y,X);
		}

		public Double4 WZYY
		{
			get => new Double4(W,Z,Y,Y);
		}

		public Double4 WZYZ
		{
			get => new Double4(W,Z,Y,Z);
		}

		public Double4 WZYW
		{
			get => new Double4(W,Z,Y,W);
		}

		public Double4 WZZX
		{
			get => new Double4(W,Z,Z,X);
		}

		public Double4 WZZY
		{
			get => new Double4(W,Z,Z,Y);
		}

		public Double4 WZZZ
		{
			get => new Double4(W,Z,Z,Z);
		}

		public Double4 WZZW
		{
			get => new Double4(W,Z,Z,W);
		}

		public Double4 WZWX
		{
			get => new Double4(W,Z,W,X);
		}

		public Double4 WZWY
		{
			get => new Double4(W,Z,W,Y);
		}

		public Double4 WZWZ
		{
			get => new Double4(W,Z,W,Z);
		}

		public Double4 WZWW
		{
			get => new Double4(W,Z,W,W);
		}

		public Double4 WWXX
		{
			get => new Double4(W,W,X,X);
		}

		public Double4 WWXY
		{
			get => new Double4(W,W,X,Y);
		}

		public Double4 WWXZ
		{
			get => new Double4(W,W,X,Z);
		}

		public Double4 WWXW
		{
			get => new Double4(W,W,X,W);
		}

		public Double4 WWYX
		{
			get => new Double4(W,W,Y,X);
		}

		public Double4 WWYY
		{
			get => new Double4(W,W,Y,Y);
		}

		public Double4 WWYZ
		{
			get => new Double4(W,W,Y,Z);
		}

		public Double4 WWYW
		{
			get => new Double4(W,W,Y,W);
		}

		public Double4 WWZX
		{
			get => new Double4(W,W,Z,X);
		}

		public Double4 WWZY
		{
			get => new Double4(W,W,Z,Y);
		}

		public Double4 WWZZ
		{
			get => new Double4(W,W,Z,Z);
		}

		public Double4 WWZW
		{
			get => new Double4(W,W,Z,W);
		}

		public Double4 WWWX
		{
			get => new Double4(W,W,W,X);
		}

		public Double4 WWWY
		{
			get => new Double4(W,W,W,Y);
		}

		public Double4 WWWZ
		{
			get => new Double4(W,W,W,Z);
		}

		public Double4 WWWW
		{
			get => new Double4(W,W,W,W);
		}

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
