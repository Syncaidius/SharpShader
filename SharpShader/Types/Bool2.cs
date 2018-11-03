using System.Runtime.InteropServices;

namespace SharpShader
{
	public struct Bool2
	{
		public bool X;

		public bool Y;

		public Bool2(bool x, bool y)
		{
			X = x;
			Y = y;
		}

		public Bool2 XX
		{
			get => new Bool2(X,X);
		}

		public Bool2 XY
		{
			get => new Bool2(X,Y);
		}

		public Bool2 YX
		{
			get => new Bool2(Y,X);
		}

		public Bool2 YY
		{
			get => new Bool2(Y,Y);
		}

		public Bool3 XXX
		{
			get => new Bool3(X,X,X);
		}

		public Bool3 XXY
		{
			get => new Bool3(X,X,Y);
		}

		public Bool3 XYX
		{
			get => new Bool3(X,Y,X);
		}

		public Bool3 XYY
		{
			get => new Bool3(X,Y,Y);
		}

		public Bool3 YXX
		{
			get => new Bool3(Y,X,X);
		}

		public Bool3 YXY
		{
			get => new Bool3(Y,X,Y);
		}

		public Bool3 YYX
		{
			get => new Bool3(Y,Y,X);
		}

		public Bool3 YYY
		{
			get => new Bool3(Y,Y,Y);
		}

		public Bool4 XXXX
		{
			get => new Bool4(X,X,X,X);
		}

		public Bool4 XXXY
		{
			get => new Bool4(X,X,X,Y);
		}

		public Bool4 XXYX
		{
			get => new Bool4(X,X,Y,X);
		}

		public Bool4 XXYY
		{
			get => new Bool4(X,X,Y,Y);
		}

		public Bool4 XYXX
		{
			get => new Bool4(X,Y,X,X);
		}

		public Bool4 XYXY
		{
			get => new Bool4(X,Y,X,Y);
		}

		public Bool4 XYYX
		{
			get => new Bool4(X,Y,Y,X);
		}

		public Bool4 XYYY
		{
			get => new Bool4(X,Y,Y,Y);
		}

		public Bool4 YXXX
		{
			get => new Bool4(Y,X,X,X);
		}

		public Bool4 YXXY
		{
			get => new Bool4(Y,X,X,Y);
		}

		public Bool4 YXYX
		{
			get => new Bool4(Y,X,Y,X);
		}

		public Bool4 YXYY
		{
			get => new Bool4(Y,X,Y,Y);
		}

		public Bool4 YYXX
		{
			get => new Bool4(Y,Y,X,X);
		}

		public Bool4 YYXY
		{
			get => new Bool4(Y,Y,X,Y);
		}

		public Bool4 YYYX
		{
			get => new Bool4(Y,Y,Y,X);
		}

		public Bool4 YYYY
		{
			get => new Bool4(Y,Y,Y,Y);
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

	}
}
