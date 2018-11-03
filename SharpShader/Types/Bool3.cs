using System.Runtime.InteropServices;

namespace SharpShader
{
	public struct Bool3
	{
		public bool X;

		public bool Y;

		public bool Z;

		public Bool3(bool x, bool y, bool z)
		{
			X = x;
			Y = y;
			Z = z;
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

	}
}
