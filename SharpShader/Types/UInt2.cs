using System.Runtime.InteropServices;

namespace SharpShader
{
	[StructLayout(LayoutKind.Sequential)]
	public struct UInt2 : IVector
	{
        /// <summary>
        /// The X component.
        /// </summary>
		public uint X;

        /// <summary>
        /// The Y component.
        /// </summary>
		public uint Y;

        /// <summary>
        /// Creates a new instance of <see cref="UInt2"/>.
        /// </summary>
		public UInt2(uint x, uint y)
		{
			X = x;
			Y = y;
		}

		/// <summary>
		/// Returns a new <see cref="UInt2"/> comprised of X, X from the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 XX => new UInt2(X, X);

		/// <summary>
		/// Returns a new <see cref="UInt2"/> comprised of R, R from the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 RR => new UInt2(R, R);

		/// <summary>
		/// Returns a new <see cref="UInt2"/> comprised of X, Y from the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 XY => new UInt2(X, Y);

		/// <summary>
		/// Returns a new <see cref="UInt2"/> comprised of R, G from the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 RG => new UInt2(R, G);

		/// <summary>
		/// Returns a new <see cref="UInt2"/> comprised of Y, X from the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 YX => new UInt2(Y, X);

		/// <summary>
		/// Returns a new <see cref="UInt2"/> comprised of G, R from the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 GR => new UInt2(G, R);

		/// <summary>
		/// Returns a new <see cref="UInt2"/> comprised of Y, Y from the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 YY => new UInt2(Y, Y);

		/// <summary>
		/// Returns a new <see cref="UInt2"/> comprised of G, G from the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 GG => new UInt2(G, G);

		/// <summary>
		/// Returns a new <see cref="UInt3"/> comprised of X, X, X from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 XXX => new UInt3(X, X, X);

		/// <summary>
		/// Returns a new <see cref="UInt3"/> comprised of R, R, R from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 RRR => new UInt3(R, R, R);

		/// <summary>
		/// Returns a new <see cref="UInt3"/> comprised of X, X, Y from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 XXY => new UInt3(X, X, Y);

		/// <summary>
		/// Returns a new <see cref="UInt3"/> comprised of R, R, G from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 RRG => new UInt3(R, R, G);

		/// <summary>
		/// Returns a new <see cref="UInt3"/> comprised of X, Y, X from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 XYX => new UInt3(X, Y, X);

		/// <summary>
		/// Returns a new <see cref="UInt3"/> comprised of R, G, R from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 RGR => new UInt3(R, G, R);

		/// <summary>
		/// Returns a new <see cref="UInt3"/> comprised of X, Y, Y from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 XYY => new UInt3(X, Y, Y);

		/// <summary>
		/// Returns a new <see cref="UInt3"/> comprised of R, G, G from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 RGG => new UInt3(R, G, G);

		/// <summary>
		/// Returns a new <see cref="UInt3"/> comprised of Y, X, X from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 YXX => new UInt3(Y, X, X);

		/// <summary>
		/// Returns a new <see cref="UInt3"/> comprised of G, R, R from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 GRR => new UInt3(G, R, R);

		/// <summary>
		/// Returns a new <see cref="UInt3"/> comprised of Y, X, Y from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 YXY => new UInt3(Y, X, Y);

		/// <summary>
		/// Returns a new <see cref="UInt3"/> comprised of G, R, G from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 GRG => new UInt3(G, R, G);

		/// <summary>
		/// Returns a new <see cref="UInt3"/> comprised of Y, Y, X from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 YYX => new UInt3(Y, Y, X);

		/// <summary>
		/// Returns a new <see cref="UInt3"/> comprised of G, G, R from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 GGR => new UInt3(G, G, R);

		/// <summary>
		/// Returns a new <see cref="UInt3"/> comprised of Y, Y, Y from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 YYY => new UInt3(Y, Y, Y);

		/// <summary>
		/// Returns a new <see cref="UInt3"/> comprised of G, G, G from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 GGG => new UInt3(G, G, G);

		/// <summary>
		/// Returns a new <see cref="UInt4"/> comprised of X, X, X, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XXXX => new UInt4(X, X, X, X);

		/// <summary>
		/// Returns a new <see cref="UInt4"/> comprised of R, R, R, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RRRR => new UInt4(R, R, R, R);

		/// <summary>
		/// Returns a new <see cref="UInt4"/> comprised of X, X, X, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XXXY => new UInt4(X, X, X, Y);

		/// <summary>
		/// Returns a new <see cref="UInt4"/> comprised of R, R, R, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RRRG => new UInt4(R, R, R, G);

		/// <summary>
		/// Returns a new <see cref="UInt4"/> comprised of X, X, Y, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XXYX => new UInt4(X, X, Y, X);

		/// <summary>
		/// Returns a new <see cref="UInt4"/> comprised of R, R, G, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RRGR => new UInt4(R, R, G, R);

		/// <summary>
		/// Returns a new <see cref="UInt4"/> comprised of X, X, Y, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XXYY => new UInt4(X, X, Y, Y);

		/// <summary>
		/// Returns a new <see cref="UInt4"/> comprised of R, R, G, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RRGG => new UInt4(R, R, G, G);

		/// <summary>
		/// Returns a new <see cref="UInt4"/> comprised of X, Y, X, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XYXX => new UInt4(X, Y, X, X);

		/// <summary>
		/// Returns a new <see cref="UInt4"/> comprised of R, G, R, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RGRR => new UInt4(R, G, R, R);

		/// <summary>
		/// Returns a new <see cref="UInt4"/> comprised of X, Y, X, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XYXY => new UInt4(X, Y, X, Y);

		/// <summary>
		/// Returns a new <see cref="UInt4"/> comprised of R, G, R, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RGRG => new UInt4(R, G, R, G);

		/// <summary>
		/// Returns a new <see cref="UInt4"/> comprised of X, Y, Y, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XYYX => new UInt4(X, Y, Y, X);

		/// <summary>
		/// Returns a new <see cref="UInt4"/> comprised of R, G, G, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RGGR => new UInt4(R, G, G, R);

		/// <summary>
		/// Returns a new <see cref="UInt4"/> comprised of X, Y, Y, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XYYY => new UInt4(X, Y, Y, Y);

		/// <summary>
		/// Returns a new <see cref="UInt4"/> comprised of R, G, G, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RGGG => new UInt4(R, G, G, G);

		/// <summary>
		/// Returns a new <see cref="UInt4"/> comprised of Y, X, X, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YXXX => new UInt4(Y, X, X, X);

		/// <summary>
		/// Returns a new <see cref="UInt4"/> comprised of G, R, R, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GRRR => new UInt4(G, R, R, R);

		/// <summary>
		/// Returns a new <see cref="UInt4"/> comprised of Y, X, X, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YXXY => new UInt4(Y, X, X, Y);

		/// <summary>
		/// Returns a new <see cref="UInt4"/> comprised of G, R, R, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GRRG => new UInt4(G, R, R, G);

		/// <summary>
		/// Returns a new <see cref="UInt4"/> comprised of Y, X, Y, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YXYX => new UInt4(Y, X, Y, X);

		/// <summary>
		/// Returns a new <see cref="UInt4"/> comprised of G, R, G, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GRGR => new UInt4(G, R, G, R);

		/// <summary>
		/// Returns a new <see cref="UInt4"/> comprised of Y, X, Y, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YXYY => new UInt4(Y, X, Y, Y);

		/// <summary>
		/// Returns a new <see cref="UInt4"/> comprised of G, R, G, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GRGG => new UInt4(G, R, G, G);

		/// <summary>
		/// Returns a new <see cref="UInt4"/> comprised of Y, Y, X, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YYXX => new UInt4(Y, Y, X, X);

		/// <summary>
		/// Returns a new <see cref="UInt4"/> comprised of G, G, R, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GGRR => new UInt4(G, G, R, R);

		/// <summary>
		/// Returns a new <see cref="UInt4"/> comprised of Y, Y, X, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YYXY => new UInt4(Y, Y, X, Y);

		/// <summary>
		/// Returns a new <see cref="UInt4"/> comprised of G, G, R, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GGRG => new UInt4(G, G, R, G);

		/// <summary>
		/// Returns a new <see cref="UInt4"/> comprised of Y, Y, Y, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YYYX => new UInt4(Y, Y, Y, X);

		/// <summary>
		/// Returns a new <see cref="UInt4"/> comprised of G, G, G, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GGGR => new UInt4(G, G, G, R);

		/// <summary>
		/// Returns a new <see cref="UInt4"/> comprised of Y, Y, Y, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YYYY => new UInt4(Y, Y, Y, Y);

		/// <summary>
		/// Returns a new <see cref="UInt4"/> comprised of G, G, G, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GGGG => new UInt4(G, G, G, G);

		public uint R
		{
			get => X;
			set => X = value;
		}

		public uint G
		{
			get => Y;
			set => Y = value;
		}

		public static UInt2 operator +(UInt2 a, UInt2 b)
		{
			return new UInt2()
			{
				X = a.X + b.X,
				Y = a.Y + b.Y,
			};
		}

		public static UInt2 operator -(UInt2 a, UInt2 b)
		{
			return new UInt2()
			{
				X = a.X - b.X,
				Y = a.Y - b.Y,
			};
		}

		public static UInt2 operator *(UInt2 a, UInt2 b)
		{
			return new UInt2()
			{
				X = a.X * b.X,
				Y = a.Y * b.Y,
			};
		}

		public static UInt2 operator /(UInt2 a, UInt2 b)
		{
			return new UInt2()
			{
				X = a.X / b.X,
				Y = a.Y / b.Y,
			};
		}

	}
}
