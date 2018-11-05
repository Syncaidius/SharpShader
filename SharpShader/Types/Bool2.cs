using System.Runtime.InteropServices;

namespace SharpShader
{
	[StructLayout(LayoutKind.Sequential)]
	public struct Bool2 : IVector
	{
        /// <summary>
        /// The X component.
        /// </summary>
		public bool X;

        /// <summary>
        /// The Y component.
        /// </summary>
		public bool Y;

        /// <summary>
        /// Creates a new instance of <see cref="Bool2"/>.
        /// </summary>
		public Bool2(bool x, bool y)
		{
			X = x;
			Y = y;
		}

		/// <summary>
		/// Returns a new <see cref="Bool2"/> comprised of X, X from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 XX => new Bool2(X, X);

		/// <summary>
		/// Returns a new <see cref="Bool2"/> comprised of R, R from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 RR => new Bool2(R, R);

		/// <summary>
		/// Returns a new <see cref="Bool2"/> comprised of X, Y from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 XY => new Bool2(X, Y);

		/// <summary>
		/// Returns a new <see cref="Bool2"/> comprised of R, G from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 RG => new Bool2(R, G);

		/// <summary>
		/// Returns a new <see cref="Bool2"/> comprised of Y, X from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 YX => new Bool2(Y, X);

		/// <summary>
		/// Returns a new <see cref="Bool2"/> comprised of G, R from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 GR => new Bool2(G, R);

		/// <summary>
		/// Returns a new <see cref="Bool2"/> comprised of Y, Y from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 YY => new Bool2(Y, Y);

		/// <summary>
		/// Returns a new <see cref="Bool2"/> comprised of G, G from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 GG => new Bool2(G, G);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of X, X, X from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 XXX => new Bool3(X, X, X);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of R, R, R from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 RRR => new Bool3(R, R, R);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of X, X, Y from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 XXY => new Bool3(X, X, Y);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of R, R, G from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 RRG => new Bool3(R, R, G);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of X, Y, X from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 XYX => new Bool3(X, Y, X);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of R, G, R from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 RGR => new Bool3(R, G, R);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of X, Y, Y from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 XYY => new Bool3(X, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of R, G, G from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 RGG => new Bool3(R, G, G);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of Y, X, X from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 YXX => new Bool3(Y, X, X);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of G, R, R from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 GRR => new Bool3(G, R, R);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of Y, X, Y from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 YXY => new Bool3(Y, X, Y);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of G, R, G from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 GRG => new Bool3(G, R, G);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of Y, Y, X from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 YYX => new Bool3(Y, Y, X);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of G, G, R from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 GGR => new Bool3(G, G, R);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of Y, Y, Y from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 YYY => new Bool3(Y, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of G, G, G from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 GGG => new Bool3(G, G, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, X, X, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XXXX => new Bool4(X, X, X, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, R, R, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RRRR => new Bool4(R, R, R, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, X, X, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XXXY => new Bool4(X, X, X, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, R, R, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RRRG => new Bool4(R, R, R, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, X, Y, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XXYX => new Bool4(X, X, Y, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, R, G, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RRGR => new Bool4(R, R, G, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, X, Y, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XXYY => new Bool4(X, X, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, R, G, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RRGG => new Bool4(R, R, G, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, Y, X, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XYXX => new Bool4(X, Y, X, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, G, R, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RGRR => new Bool4(R, G, R, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, Y, X, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XYXY => new Bool4(X, Y, X, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, G, R, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RGRG => new Bool4(R, G, R, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, Y, Y, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XYYX => new Bool4(X, Y, Y, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, G, G, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RGGR => new Bool4(R, G, G, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, Y, Y, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XYYY => new Bool4(X, Y, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, G, G, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RGGG => new Bool4(R, G, G, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, X, X, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YXXX => new Bool4(Y, X, X, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, R, R, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GRRR => new Bool4(G, R, R, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, X, X, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YXXY => new Bool4(Y, X, X, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, R, R, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GRRG => new Bool4(G, R, R, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, X, Y, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YXYX => new Bool4(Y, X, Y, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, R, G, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GRGR => new Bool4(G, R, G, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, X, Y, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YXYY => new Bool4(Y, X, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, R, G, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GRGG => new Bool4(G, R, G, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, Y, X, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YYXX => new Bool4(Y, Y, X, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, G, R, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GGRR => new Bool4(G, G, R, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, Y, X, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YYXY => new Bool4(Y, Y, X, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, G, R, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GGRG => new Bool4(G, G, R, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, Y, Y, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YYYX => new Bool4(Y, Y, Y, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, G, G, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GGGR => new Bool4(G, G, G, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, Y, Y, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YYYY => new Bool4(Y, Y, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, G, G, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GGGG => new Bool4(G, G, G, G);

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
