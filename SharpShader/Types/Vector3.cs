using System.Runtime.InteropServices;

namespace SharpShader
{
	public struct Vector3
	{
		public float X;

		public float Y;

		public float Z;

		public Vector3(float x, float y, float z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		public Vector2 XX
		{
			get => new Vector2(X,X);
		}

		public Vector2 XY
		{
			get => new Vector2(X,Y);
		}

		public Vector2 XZ
		{
			get => new Vector2(X,Z);
		}

		public Vector2 YX
		{
			get => new Vector2(Y,X);
		}

		public Vector2 YY
		{
			get => new Vector2(Y,Y);
		}

		public Vector2 YZ
		{
			get => new Vector2(Y,Z);
		}

		public Vector2 ZX
		{
			get => new Vector2(Z,X);
		}

		public Vector2 ZY
		{
			get => new Vector2(Z,Y);
		}

		public Vector2 ZZ
		{
			get => new Vector2(Z,Z);
		}

		public Vector3 XXX
		{
			get => new Vector3(X,X,X);
		}

		public Vector3 XXY
		{
			get => new Vector3(X,X,Y);
		}

		public Vector3 XXZ
		{
			get => new Vector3(X,X,Z);
		}

		public Vector3 XYX
		{
			get => new Vector3(X,Y,X);
		}

		public Vector3 XYY
		{
			get => new Vector3(X,Y,Y);
		}

		public Vector3 XYZ
		{
			get => new Vector3(X,Y,Z);
		}

		public Vector3 XZX
		{
			get => new Vector3(X,Z,X);
		}

		public Vector3 XZY
		{
			get => new Vector3(X,Z,Y);
		}

		public Vector3 XZZ
		{
			get => new Vector3(X,Z,Z);
		}

		public Vector3 YXX
		{
			get => new Vector3(Y,X,X);
		}

		public Vector3 YXY
		{
			get => new Vector3(Y,X,Y);
		}

		public Vector3 YXZ
		{
			get => new Vector3(Y,X,Z);
		}

		public Vector3 YYX
		{
			get => new Vector3(Y,Y,X);
		}

		public Vector3 YYY
		{
			get => new Vector3(Y,Y,Y);
		}

		public Vector3 YYZ
		{
			get => new Vector3(Y,Y,Z);
		}

		public Vector3 YZX
		{
			get => new Vector3(Y,Z,X);
		}

		public Vector3 YZY
		{
			get => new Vector3(Y,Z,Y);
		}

		public Vector3 YZZ
		{
			get => new Vector3(Y,Z,Z);
		}

		public Vector3 ZXX
		{
			get => new Vector3(Z,X,X);
		}

		public Vector3 ZXY
		{
			get => new Vector3(Z,X,Y);
		}

		public Vector3 ZXZ
		{
			get => new Vector3(Z,X,Z);
		}

		public Vector3 ZYX
		{
			get => new Vector3(Z,Y,X);
		}

		public Vector3 ZYY
		{
			get => new Vector3(Z,Y,Y);
		}

		public Vector3 ZYZ
		{
			get => new Vector3(Z,Y,Z);
		}

		public Vector3 ZZX
		{
			get => new Vector3(Z,Z,X);
		}

		public Vector3 ZZY
		{
			get => new Vector3(Z,Z,Y);
		}

		public Vector3 ZZZ
		{
			get => new Vector3(Z,Z,Z);
		}

		public Vector4 XXXX
		{
			get => new Vector4(X,X,X,X);
		}

		public Vector4 XXXY
		{
			get => new Vector4(X,X,X,Y);
		}

		public Vector4 XXXZ
		{
			get => new Vector4(X,X,X,Z);
		}

		public Vector4 XXYX
		{
			get => new Vector4(X,X,Y,X);
		}

		public Vector4 XXYY
		{
			get => new Vector4(X,X,Y,Y);
		}

		public Vector4 XXYZ
		{
			get => new Vector4(X,X,Y,Z);
		}

		public Vector4 XXZX
		{
			get => new Vector4(X,X,Z,X);
		}

		public Vector4 XXZY
		{
			get => new Vector4(X,X,Z,Y);
		}

		public Vector4 XXZZ
		{
			get => new Vector4(X,X,Z,Z);
		}

		public Vector4 XYXX
		{
			get => new Vector4(X,Y,X,X);
		}

		public Vector4 XYXY
		{
			get => new Vector4(X,Y,X,Y);
		}

		public Vector4 XYXZ
		{
			get => new Vector4(X,Y,X,Z);
		}

		public Vector4 XYYX
		{
			get => new Vector4(X,Y,Y,X);
		}

		public Vector4 XYYY
		{
			get => new Vector4(X,Y,Y,Y);
		}

		public Vector4 XYYZ
		{
			get => new Vector4(X,Y,Y,Z);
		}

		public Vector4 XYZX
		{
			get => new Vector4(X,Y,Z,X);
		}

		public Vector4 XYZY
		{
			get => new Vector4(X,Y,Z,Y);
		}

		public Vector4 XYZZ
		{
			get => new Vector4(X,Y,Z,Z);
		}

		public Vector4 XZXX
		{
			get => new Vector4(X,Z,X,X);
		}

		public Vector4 XZXY
		{
			get => new Vector4(X,Z,X,Y);
		}

		public Vector4 XZXZ
		{
			get => new Vector4(X,Z,X,Z);
		}

		public Vector4 XZYX
		{
			get => new Vector4(X,Z,Y,X);
		}

		public Vector4 XZYY
		{
			get => new Vector4(X,Z,Y,Y);
		}

		public Vector4 XZYZ
		{
			get => new Vector4(X,Z,Y,Z);
		}

		public Vector4 XZZX
		{
			get => new Vector4(X,Z,Z,X);
		}

		public Vector4 XZZY
		{
			get => new Vector4(X,Z,Z,Y);
		}

		public Vector4 XZZZ
		{
			get => new Vector4(X,Z,Z,Z);
		}

		public Vector4 YXXX
		{
			get => new Vector4(Y,X,X,X);
		}

		public Vector4 YXXY
		{
			get => new Vector4(Y,X,X,Y);
		}

		public Vector4 YXXZ
		{
			get => new Vector4(Y,X,X,Z);
		}

		public Vector4 YXYX
		{
			get => new Vector4(Y,X,Y,X);
		}

		public Vector4 YXYY
		{
			get => new Vector4(Y,X,Y,Y);
		}

		public Vector4 YXYZ
		{
			get => new Vector4(Y,X,Y,Z);
		}

		public Vector4 YXZX
		{
			get => new Vector4(Y,X,Z,X);
		}

		public Vector4 YXZY
		{
			get => new Vector4(Y,X,Z,Y);
		}

		public Vector4 YXZZ
		{
			get => new Vector4(Y,X,Z,Z);
		}

		public Vector4 YYXX
		{
			get => new Vector4(Y,Y,X,X);
		}

		public Vector4 YYXY
		{
			get => new Vector4(Y,Y,X,Y);
		}

		public Vector4 YYXZ
		{
			get => new Vector4(Y,Y,X,Z);
		}

		public Vector4 YYYX
		{
			get => new Vector4(Y,Y,Y,X);
		}

		public Vector4 YYYY
		{
			get => new Vector4(Y,Y,Y,Y);
		}

		public Vector4 YYYZ
		{
			get => new Vector4(Y,Y,Y,Z);
		}

		public Vector4 YYZX
		{
			get => new Vector4(Y,Y,Z,X);
		}

		public Vector4 YYZY
		{
			get => new Vector4(Y,Y,Z,Y);
		}

		public Vector4 YYZZ
		{
			get => new Vector4(Y,Y,Z,Z);
		}

		public Vector4 YZXX
		{
			get => new Vector4(Y,Z,X,X);
		}

		public Vector4 YZXY
		{
			get => new Vector4(Y,Z,X,Y);
		}

		public Vector4 YZXZ
		{
			get => new Vector4(Y,Z,X,Z);
		}

		public Vector4 YZYX
		{
			get => new Vector4(Y,Z,Y,X);
		}

		public Vector4 YZYY
		{
			get => new Vector4(Y,Z,Y,Y);
		}

		public Vector4 YZYZ
		{
			get => new Vector4(Y,Z,Y,Z);
		}

		public Vector4 YZZX
		{
			get => new Vector4(Y,Z,Z,X);
		}

		public Vector4 YZZY
		{
			get => new Vector4(Y,Z,Z,Y);
		}

		public Vector4 YZZZ
		{
			get => new Vector4(Y,Z,Z,Z);
		}

		public Vector4 ZXXX
		{
			get => new Vector4(Z,X,X,X);
		}

		public Vector4 ZXXY
		{
			get => new Vector4(Z,X,X,Y);
		}

		public Vector4 ZXXZ
		{
			get => new Vector4(Z,X,X,Z);
		}

		public Vector4 ZXYX
		{
			get => new Vector4(Z,X,Y,X);
		}

		public Vector4 ZXYY
		{
			get => new Vector4(Z,X,Y,Y);
		}

		public Vector4 ZXYZ
		{
			get => new Vector4(Z,X,Y,Z);
		}

		public Vector4 ZXZX
		{
			get => new Vector4(Z,X,Z,X);
		}

		public Vector4 ZXZY
		{
			get => new Vector4(Z,X,Z,Y);
		}

		public Vector4 ZXZZ
		{
			get => new Vector4(Z,X,Z,Z);
		}

		public Vector4 ZYXX
		{
			get => new Vector4(Z,Y,X,X);
		}

		public Vector4 ZYXY
		{
			get => new Vector4(Z,Y,X,Y);
		}

		public Vector4 ZYXZ
		{
			get => new Vector4(Z,Y,X,Z);
		}

		public Vector4 ZYYX
		{
			get => new Vector4(Z,Y,Y,X);
		}

		public Vector4 ZYYY
		{
			get => new Vector4(Z,Y,Y,Y);
		}

		public Vector4 ZYYZ
		{
			get => new Vector4(Z,Y,Y,Z);
		}

		public Vector4 ZYZX
		{
			get => new Vector4(Z,Y,Z,X);
		}

		public Vector4 ZYZY
		{
			get => new Vector4(Z,Y,Z,Y);
		}

		public Vector4 ZYZZ
		{
			get => new Vector4(Z,Y,Z,Z);
		}

		public Vector4 ZZXX
		{
			get => new Vector4(Z,Z,X,X);
		}

		public Vector4 ZZXY
		{
			get => new Vector4(Z,Z,X,Y);
		}

		public Vector4 ZZXZ
		{
			get => new Vector4(Z,Z,X,Z);
		}

		public Vector4 ZZYX
		{
			get => new Vector4(Z,Z,Y,X);
		}

		public Vector4 ZZYY
		{
			get => new Vector4(Z,Z,Y,Y);
		}

		public Vector4 ZZYZ
		{
			get => new Vector4(Z,Z,Y,Z);
		}

		public Vector4 ZZZX
		{
			get => new Vector4(Z,Z,Z,X);
		}

		public Vector4 ZZZY
		{
			get => new Vector4(Z,Z,Z,Y);
		}

		public Vector4 ZZZZ
		{
			get => new Vector4(Z,Z,Z,Z);
		}

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
