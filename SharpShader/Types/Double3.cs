using System.Runtime.InteropServices;

namespace SharpShader
{
	public struct Double3
	{
		public double X;

		public double Y;

		public double Z;

		public Double3(double x, double y, double z)
		{
			X = x;
			Y = y;
			Z = z;
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

		public static Double3 operator +(Double3 a, Double3 b)
		{
			return new Double3()
			{
				X = a.X + b.X,
				Y = a.Y + b.Y,
				Z = a.Z + b.Z,
			};
		}

		public static Double3 operator -(Double3 a, Double3 b)
		{
			return new Double3()
			{
				X = a.X - b.X,
				Y = a.Y - b.Y,
				Z = a.Z - b.Z,
			};
		}

		public static Double3 operator *(Double3 a, Double3 b)
		{
			return new Double3()
			{
				X = a.X * b.X,
				Y = a.Y * b.Y,
				Z = a.Z * b.Z,
			};
		}

		public static Double3 operator /(Double3 a, Double3 b)
		{
			return new Double3()
			{
				X = a.X / b.X,
				Y = a.Y / b.Y,
				Z = a.Z / b.Z,
			};
		}

	}
}
