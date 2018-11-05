using System.Runtime.InteropServices;

namespace SharpShader
{
	[StructLayout(LayoutKind.Sequential)]
	public struct Int2 : IVector, IIntrinsicValue
	{
        /// <summary>
        /// The X component.
        /// </summary>
		public int X;

        /// <summary>
        /// The Y component.
        /// </summary>
		public int Y;

        /// <summary>
        /// Creates a new instance of <see cref="Int2"/>.
        /// </summary>
		public Int2(int x, int y)
		{
			X = x;
			Y = y;
		}

		/// <summary>
		/// Returns a new <see cref="Int2"/> comprised of X, X from the current <see cref="Int2"/>.
		/// </summary>
		public Int2 XX => new Int2(X, X);

		/// <summary>
		/// Returns a new <see cref="Int2"/> comprised of R, R from the current <see cref="Int2"/>.
		/// </summary>
		public Int2 RR => new Int2(R, R);

		/// <summary>
		/// Returns a new <see cref="Int2"/> comprised of X, Y from the current <see cref="Int2"/>.
		/// </summary>
		public Int2 XY => new Int2(X, Y);

		/// <summary>
		/// Returns a new <see cref="Int2"/> comprised of R, G from the current <see cref="Int2"/>.
		/// </summary>
		public Int2 RG => new Int2(R, G);

		/// <summary>
		/// Returns a new <see cref="Int2"/> comprised of Y, X from the current <see cref="Int2"/>.
		/// </summary>
		public Int2 YX => new Int2(Y, X);

		/// <summary>
		/// Returns a new <see cref="Int2"/> comprised of G, R from the current <see cref="Int2"/>.
		/// </summary>
		public Int2 GR => new Int2(G, R);

		/// <summary>
		/// Returns a new <see cref="Int2"/> comprised of Y, Y from the current <see cref="Int2"/>.
		/// </summary>
		public Int2 YY => new Int2(Y, Y);

		/// <summary>
		/// Returns a new <see cref="Int2"/> comprised of G, G from the current <see cref="Int2"/>.
		/// </summary>
		public Int2 GG => new Int2(G, G);

		/// <summary>
		/// Returns a new <see cref="Int3"/> comprised of X, X, X from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 XXX => new Int3(X, X, X);

		/// <summary>
		/// Returns a new <see cref="Int3"/> comprised of R, R, R from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 RRR => new Int3(R, R, R);

		/// <summary>
		/// Returns a new <see cref="Int3"/> comprised of X, X, Y from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 XXY => new Int3(X, X, Y);

		/// <summary>
		/// Returns a new <see cref="Int3"/> comprised of R, R, G from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 RRG => new Int3(R, R, G);

		/// <summary>
		/// Returns a new <see cref="Int3"/> comprised of X, Y, X from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 XYX => new Int3(X, Y, X);

		/// <summary>
		/// Returns a new <see cref="Int3"/> comprised of R, G, R from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 RGR => new Int3(R, G, R);

		/// <summary>
		/// Returns a new <see cref="Int3"/> comprised of X, Y, Y from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 XYY => new Int3(X, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Int3"/> comprised of R, G, G from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 RGG => new Int3(R, G, G);

		/// <summary>
		/// Returns a new <see cref="Int3"/> comprised of Y, X, X from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 YXX => new Int3(Y, X, X);

		/// <summary>
		/// Returns a new <see cref="Int3"/> comprised of G, R, R from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 GRR => new Int3(G, R, R);

		/// <summary>
		/// Returns a new <see cref="Int3"/> comprised of Y, X, Y from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 YXY => new Int3(Y, X, Y);

		/// <summary>
		/// Returns a new <see cref="Int3"/> comprised of G, R, G from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 GRG => new Int3(G, R, G);

		/// <summary>
		/// Returns a new <see cref="Int3"/> comprised of Y, Y, X from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 YYX => new Int3(Y, Y, X);

		/// <summary>
		/// Returns a new <see cref="Int3"/> comprised of G, G, R from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 GGR => new Int3(G, G, R);

		/// <summary>
		/// Returns a new <see cref="Int3"/> comprised of Y, Y, Y from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 YYY => new Int3(Y, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Int3"/> comprised of G, G, G from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 GGG => new Int3(G, G, G);

		/// <summary>
		/// Returns a new <see cref="Int4"/> comprised of X, X, X, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XXXX => new Int4(X, X, X, X);

		/// <summary>
		/// Returns a new <see cref="Int4"/> comprised of R, R, R, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RRRR => new Int4(R, R, R, R);

		/// <summary>
		/// Returns a new <see cref="Int4"/> comprised of X, X, X, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XXXY => new Int4(X, X, X, Y);

		/// <summary>
		/// Returns a new <see cref="Int4"/> comprised of R, R, R, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RRRG => new Int4(R, R, R, G);

		/// <summary>
		/// Returns a new <see cref="Int4"/> comprised of X, X, Y, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XXYX => new Int4(X, X, Y, X);

		/// <summary>
		/// Returns a new <see cref="Int4"/> comprised of R, R, G, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RRGR => new Int4(R, R, G, R);

		/// <summary>
		/// Returns a new <see cref="Int4"/> comprised of X, X, Y, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XXYY => new Int4(X, X, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Int4"/> comprised of R, R, G, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RRGG => new Int4(R, R, G, G);

		/// <summary>
		/// Returns a new <see cref="Int4"/> comprised of X, Y, X, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XYXX => new Int4(X, Y, X, X);

		/// <summary>
		/// Returns a new <see cref="Int4"/> comprised of R, G, R, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RGRR => new Int4(R, G, R, R);

		/// <summary>
		/// Returns a new <see cref="Int4"/> comprised of X, Y, X, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XYXY => new Int4(X, Y, X, Y);

		/// <summary>
		/// Returns a new <see cref="Int4"/> comprised of R, G, R, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RGRG => new Int4(R, G, R, G);

		/// <summary>
		/// Returns a new <see cref="Int4"/> comprised of X, Y, Y, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XYYX => new Int4(X, Y, Y, X);

		/// <summary>
		/// Returns a new <see cref="Int4"/> comprised of R, G, G, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RGGR => new Int4(R, G, G, R);

		/// <summary>
		/// Returns a new <see cref="Int4"/> comprised of X, Y, Y, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XYYY => new Int4(X, Y, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Int4"/> comprised of R, G, G, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RGGG => new Int4(R, G, G, G);

		/// <summary>
		/// Returns a new <see cref="Int4"/> comprised of Y, X, X, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YXXX => new Int4(Y, X, X, X);

		/// <summary>
		/// Returns a new <see cref="Int4"/> comprised of G, R, R, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GRRR => new Int4(G, R, R, R);

		/// <summary>
		/// Returns a new <see cref="Int4"/> comprised of Y, X, X, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YXXY => new Int4(Y, X, X, Y);

		/// <summary>
		/// Returns a new <see cref="Int4"/> comprised of G, R, R, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GRRG => new Int4(G, R, R, G);

		/// <summary>
		/// Returns a new <see cref="Int4"/> comprised of Y, X, Y, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YXYX => new Int4(Y, X, Y, X);

		/// <summary>
		/// Returns a new <see cref="Int4"/> comprised of G, R, G, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GRGR => new Int4(G, R, G, R);

		/// <summary>
		/// Returns a new <see cref="Int4"/> comprised of Y, X, Y, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YXYY => new Int4(Y, X, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Int4"/> comprised of G, R, G, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GRGG => new Int4(G, R, G, G);

		/// <summary>
		/// Returns a new <see cref="Int4"/> comprised of Y, Y, X, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YYXX => new Int4(Y, Y, X, X);

		/// <summary>
		/// Returns a new <see cref="Int4"/> comprised of G, G, R, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GGRR => new Int4(G, G, R, R);

		/// <summary>
		/// Returns a new <see cref="Int4"/> comprised of Y, Y, X, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YYXY => new Int4(Y, Y, X, Y);

		/// <summary>
		/// Returns a new <see cref="Int4"/> comprised of G, G, R, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GGRG => new Int4(G, G, R, G);

		/// <summary>
		/// Returns a new <see cref="Int4"/> comprised of Y, Y, Y, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YYYX => new Int4(Y, Y, Y, X);

		/// <summary>
		/// Returns a new <see cref="Int4"/> comprised of G, G, G, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GGGR => new Int4(G, G, G, R);

		/// <summary>
		/// Returns a new <see cref="Int4"/> comprised of Y, Y, Y, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YYYY => new Int4(Y, Y, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Int4"/> comprised of G, G, G, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GGGG => new Int4(G, G, G, G);

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

		public static Int2 operator +(Int2 a, Int2 b)
		{
			return new Int2()
			{
				X = a.X + b.X,
				Y = a.Y + b.Y,
			};
		}

		public static Int2 operator -(Int2 a, Int2 b)
		{
			return new Int2()
			{
				X = a.X - b.X,
				Y = a.Y - b.Y,
			};
		}

		public static Int2 operator *(Int2 a, Int2 b)
		{
			return new Int2()
			{
				X = a.X * b.X,
				Y = a.Y * b.Y,
			};
		}

		public static Int2 operator /(Int2 a, Int2 b)
		{
			return new Int2()
			{
				X = a.X / b.X,
				Y = a.Y / b.Y,
			};
		}

	}
}
