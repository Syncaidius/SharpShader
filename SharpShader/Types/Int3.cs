using System.Runtime.InteropServices;

namespace SharpShader
{
	public struct Int3
	{
		public int X;

		public int Y;

		public int Z;

		public Int3(int x, int y, int z)
		{
			X = x;
			Y = y;
			Z = z;
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
