using System.Runtime.InteropServices;

namespace SharpShader
{
	[StructLayout(LayoutKind.Sequential)]
	public struct Bool4 : IIntrinsicValue<bool>
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
        /// The Z component.
        /// </summary>
		public bool Z;

        /// <summary>
        /// The W component.
        /// </summary>
		public bool W;

        /// <summary>
        /// Creates a new instance of <see cref="Bool4"/>.
        /// </summary>
		public Bool4(bool x, bool y, bool z, bool w)
		{
			X = x;
			Y = y;
			Z = z;
			W = w;
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
		/// Returns a new <see cref="Bool2"/> comprised of X, Z from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 XZ => new Bool2(X, Z);

		/// <summary>
		/// Returns a new <see cref="Bool2"/> comprised of R, B from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 RB => new Bool2(R, B);

		/// <summary>
		/// Returns a new <see cref="Bool2"/> comprised of X, W from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 XW => new Bool2(X, W);

		/// <summary>
		/// Returns a new <see cref="Bool2"/> comprised of R, A from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 RA => new Bool2(R, A);

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
		/// Returns a new <see cref="Bool2"/> comprised of Y, Z from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 YZ => new Bool2(Y, Z);

		/// <summary>
		/// Returns a new <see cref="Bool2"/> comprised of G, B from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 GB => new Bool2(G, B);

		/// <summary>
		/// Returns a new <see cref="Bool2"/> comprised of Y, W from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 YW => new Bool2(Y, W);

		/// <summary>
		/// Returns a new <see cref="Bool2"/> comprised of G, A from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 GA => new Bool2(G, A);

		/// <summary>
		/// Returns a new <see cref="Bool2"/> comprised of Z, X from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 ZX => new Bool2(Z, X);

		/// <summary>
		/// Returns a new <see cref="Bool2"/> comprised of B, R from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 BR => new Bool2(B, R);

		/// <summary>
		/// Returns a new <see cref="Bool2"/> comprised of Z, Y from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 ZY => new Bool2(Z, Y);

		/// <summary>
		/// Returns a new <see cref="Bool2"/> comprised of B, G from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 BG => new Bool2(B, G);

		/// <summary>
		/// Returns a new <see cref="Bool2"/> comprised of Z, Z from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 ZZ => new Bool2(Z, Z);

		/// <summary>
		/// Returns a new <see cref="Bool2"/> comprised of B, B from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 BB => new Bool2(B, B);

		/// <summary>
		/// Returns a new <see cref="Bool2"/> comprised of Z, W from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 ZW => new Bool2(Z, W);

		/// <summary>
		/// Returns a new <see cref="Bool2"/> comprised of B, A from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 BA => new Bool2(B, A);

		/// <summary>
		/// Returns a new <see cref="Bool2"/> comprised of W, X from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 WX => new Bool2(W, X);

		/// <summary>
		/// Returns a new <see cref="Bool2"/> comprised of A, R from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 AR => new Bool2(A, R);

		/// <summary>
		/// Returns a new <see cref="Bool2"/> comprised of W, Y from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 WY => new Bool2(W, Y);

		/// <summary>
		/// Returns a new <see cref="Bool2"/> comprised of A, G from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 AG => new Bool2(A, G);

		/// <summary>
		/// Returns a new <see cref="Bool2"/> comprised of W, Z from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 WZ => new Bool2(W, Z);

		/// <summary>
		/// Returns a new <see cref="Bool2"/> comprised of A, B from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 AB => new Bool2(A, B);

		/// <summary>
		/// Returns a new <see cref="Bool2"/> comprised of W, W from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 WW => new Bool2(W, W);

		/// <summary>
		/// Returns a new <see cref="Bool2"/> comprised of A, A from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 AA => new Bool2(A, A);

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
		/// Returns a new <see cref="Bool3"/> comprised of X, X, Z from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 XXZ => new Bool3(X, X, Z);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of R, R, B from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 RRB => new Bool3(R, R, B);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of X, X, W from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 XXW => new Bool3(X, X, W);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of R, R, A from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 RRA => new Bool3(R, R, A);

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
		/// Returns a new <see cref="Bool3"/> comprised of X, Y, Z from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 XYZ => new Bool3(X, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of R, G, B from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 RGB => new Bool3(R, G, B);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of X, Y, W from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 XYW => new Bool3(X, Y, W);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of R, G, A from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 RGA => new Bool3(R, G, A);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of X, Z, X from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 XZX => new Bool3(X, Z, X);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of R, B, R from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 RBR => new Bool3(R, B, R);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of X, Z, Y from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 XZY => new Bool3(X, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of R, B, G from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 RBG => new Bool3(R, B, G);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of X, Z, Z from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 XZZ => new Bool3(X, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of R, B, B from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 RBB => new Bool3(R, B, B);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of X, Z, W from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 XZW => new Bool3(X, Z, W);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of R, B, A from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 RBA => new Bool3(R, B, A);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of X, W, X from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 XWX => new Bool3(X, W, X);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of R, A, R from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 RAR => new Bool3(R, A, R);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of X, W, Y from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 XWY => new Bool3(X, W, Y);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of R, A, G from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 RAG => new Bool3(R, A, G);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of X, W, Z from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 XWZ => new Bool3(X, W, Z);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of R, A, B from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 RAB => new Bool3(R, A, B);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of X, W, W from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 XWW => new Bool3(X, W, W);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of R, A, A from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 RAA => new Bool3(R, A, A);

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
		/// Returns a new <see cref="Bool3"/> comprised of Y, X, Z from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 YXZ => new Bool3(Y, X, Z);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of G, R, B from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 GRB => new Bool3(G, R, B);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of Y, X, W from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 YXW => new Bool3(Y, X, W);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of G, R, A from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 GRA => new Bool3(G, R, A);

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
		/// Returns a new <see cref="Bool3"/> comprised of Y, Y, Z from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 YYZ => new Bool3(Y, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of G, G, B from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 GGB => new Bool3(G, G, B);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of Y, Y, W from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 YYW => new Bool3(Y, Y, W);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of G, G, A from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 GGA => new Bool3(G, G, A);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of Y, Z, X from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 YZX => new Bool3(Y, Z, X);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of G, B, R from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 GBR => new Bool3(G, B, R);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of Y, Z, Y from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 YZY => new Bool3(Y, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of G, B, G from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 GBG => new Bool3(G, B, G);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of Y, Z, Z from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 YZZ => new Bool3(Y, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of G, B, B from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 GBB => new Bool3(G, B, B);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of Y, Z, W from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 YZW => new Bool3(Y, Z, W);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of G, B, A from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 GBA => new Bool3(G, B, A);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of Y, W, X from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 YWX => new Bool3(Y, W, X);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of G, A, R from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 GAR => new Bool3(G, A, R);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of Y, W, Y from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 YWY => new Bool3(Y, W, Y);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of G, A, G from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 GAG => new Bool3(G, A, G);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of Y, W, Z from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 YWZ => new Bool3(Y, W, Z);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of G, A, B from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 GAB => new Bool3(G, A, B);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of Y, W, W from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 YWW => new Bool3(Y, W, W);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of G, A, A from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 GAA => new Bool3(G, A, A);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of Z, X, X from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 ZXX => new Bool3(Z, X, X);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of B, R, R from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 BRR => new Bool3(B, R, R);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of Z, X, Y from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 ZXY => new Bool3(Z, X, Y);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of B, R, G from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 BRG => new Bool3(B, R, G);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of Z, X, Z from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 ZXZ => new Bool3(Z, X, Z);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of B, R, B from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 BRB => new Bool3(B, R, B);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of Z, X, W from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 ZXW => new Bool3(Z, X, W);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of B, R, A from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 BRA => new Bool3(B, R, A);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of Z, Y, X from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 ZYX => new Bool3(Z, Y, X);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of B, G, R from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 BGR => new Bool3(B, G, R);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of Z, Y, Y from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 ZYY => new Bool3(Z, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of B, G, G from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 BGG => new Bool3(B, G, G);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of Z, Y, Z from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 ZYZ => new Bool3(Z, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of B, G, B from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 BGB => new Bool3(B, G, B);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of Z, Y, W from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 ZYW => new Bool3(Z, Y, W);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of B, G, A from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 BGA => new Bool3(B, G, A);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of Z, Z, X from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 ZZX => new Bool3(Z, Z, X);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of B, B, R from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 BBR => new Bool3(B, B, R);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of Z, Z, Y from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 ZZY => new Bool3(Z, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of B, B, G from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 BBG => new Bool3(B, B, G);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of Z, Z, Z from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 ZZZ => new Bool3(Z, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of B, B, B from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 BBB => new Bool3(B, B, B);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of Z, Z, W from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 ZZW => new Bool3(Z, Z, W);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of B, B, A from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 BBA => new Bool3(B, B, A);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of Z, W, X from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 ZWX => new Bool3(Z, W, X);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of B, A, R from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 BAR => new Bool3(B, A, R);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of Z, W, Y from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 ZWY => new Bool3(Z, W, Y);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of B, A, G from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 BAG => new Bool3(B, A, G);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of Z, W, Z from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 ZWZ => new Bool3(Z, W, Z);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of B, A, B from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 BAB => new Bool3(B, A, B);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of Z, W, W from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 ZWW => new Bool3(Z, W, W);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of B, A, A from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 BAA => new Bool3(B, A, A);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of W, X, X from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 WXX => new Bool3(W, X, X);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of A, R, R from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 ARR => new Bool3(A, R, R);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of W, X, Y from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 WXY => new Bool3(W, X, Y);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of A, R, G from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 ARG => new Bool3(A, R, G);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of W, X, Z from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 WXZ => new Bool3(W, X, Z);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of A, R, B from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 ARB => new Bool3(A, R, B);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of W, X, W from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 WXW => new Bool3(W, X, W);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of A, R, A from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 ARA => new Bool3(A, R, A);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of W, Y, X from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 WYX => new Bool3(W, Y, X);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of A, G, R from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 AGR => new Bool3(A, G, R);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of W, Y, Y from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 WYY => new Bool3(W, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of A, G, G from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 AGG => new Bool3(A, G, G);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of W, Y, Z from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 WYZ => new Bool3(W, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of A, G, B from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 AGB => new Bool3(A, G, B);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of W, Y, W from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 WYW => new Bool3(W, Y, W);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of A, G, A from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 AGA => new Bool3(A, G, A);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of W, Z, X from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 WZX => new Bool3(W, Z, X);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of A, B, R from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 ABR => new Bool3(A, B, R);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of W, Z, Y from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 WZY => new Bool3(W, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of A, B, G from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 ABG => new Bool3(A, B, G);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of W, Z, Z from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 WZZ => new Bool3(W, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of A, B, B from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 ABB => new Bool3(A, B, B);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of W, Z, W from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 WZW => new Bool3(W, Z, W);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of A, B, A from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 ABA => new Bool3(A, B, A);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of W, W, X from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 WWX => new Bool3(W, W, X);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of A, A, R from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 AAR => new Bool3(A, A, R);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of W, W, Y from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 WWY => new Bool3(W, W, Y);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of A, A, G from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 AAG => new Bool3(A, A, G);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of W, W, Z from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 WWZ => new Bool3(W, W, Z);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of A, A, B from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 AAB => new Bool3(A, A, B);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of W, W, W from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 WWW => new Bool3(W, W, W);

		/// <summary>
		/// Returns a new <see cref="Bool3"/> comprised of A, A, A from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 AAA => new Bool3(A, A, A);

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
		/// Returns a new <see cref="Bool4"/> comprised of X, X, X, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XXXZ => new Bool4(X, X, X, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, R, R, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RRRB => new Bool4(R, R, R, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, X, X, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XXXW => new Bool4(X, X, X, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, R, R, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RRRA => new Bool4(R, R, R, A);

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
		/// Returns a new <see cref="Bool4"/> comprised of X, X, Y, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XXYZ => new Bool4(X, X, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, R, G, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RRGB => new Bool4(R, R, G, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, X, Y, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XXYW => new Bool4(X, X, Y, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, R, G, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RRGA => new Bool4(R, R, G, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, X, Z, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XXZX => new Bool4(X, X, Z, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, R, B, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RRBR => new Bool4(R, R, B, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, X, Z, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XXZY => new Bool4(X, X, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, R, B, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RRBG => new Bool4(R, R, B, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, X, Z, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XXZZ => new Bool4(X, X, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, R, B, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RRBB => new Bool4(R, R, B, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, X, Z, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XXZW => new Bool4(X, X, Z, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, R, B, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RRBA => new Bool4(R, R, B, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, X, W, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XXWX => new Bool4(X, X, W, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, R, A, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RRAR => new Bool4(R, R, A, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, X, W, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XXWY => new Bool4(X, X, W, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, R, A, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RRAG => new Bool4(R, R, A, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, X, W, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XXWZ => new Bool4(X, X, W, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, R, A, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RRAB => new Bool4(R, R, A, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, X, W, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XXWW => new Bool4(X, X, W, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, R, A, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RRAA => new Bool4(R, R, A, A);

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
		/// Returns a new <see cref="Bool4"/> comprised of X, Y, X, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XYXZ => new Bool4(X, Y, X, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, G, R, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RGRB => new Bool4(R, G, R, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, Y, X, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XYXW => new Bool4(X, Y, X, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, G, R, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RGRA => new Bool4(R, G, R, A);

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
		/// Returns a new <see cref="Bool4"/> comprised of X, Y, Y, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XYYZ => new Bool4(X, Y, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, G, G, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RGGB => new Bool4(R, G, G, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, Y, Y, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XYYW => new Bool4(X, Y, Y, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, G, G, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RGGA => new Bool4(R, G, G, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, Y, Z, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XYZX => new Bool4(X, Y, Z, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, G, B, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RGBR => new Bool4(R, G, B, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, Y, Z, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XYZY => new Bool4(X, Y, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, G, B, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RGBG => new Bool4(R, G, B, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, Y, Z, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XYZZ => new Bool4(X, Y, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, G, B, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RGBB => new Bool4(R, G, B, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, Y, Z, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XYZW => new Bool4(X, Y, Z, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, G, B, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RGBA => new Bool4(R, G, B, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, Y, W, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XYWX => new Bool4(X, Y, W, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, G, A, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RGAR => new Bool4(R, G, A, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, Y, W, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XYWY => new Bool4(X, Y, W, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, G, A, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RGAG => new Bool4(R, G, A, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, Y, W, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XYWZ => new Bool4(X, Y, W, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, G, A, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RGAB => new Bool4(R, G, A, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, Y, W, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XYWW => new Bool4(X, Y, W, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, G, A, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RGAA => new Bool4(R, G, A, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, Z, X, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XZXX => new Bool4(X, Z, X, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, B, R, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RBRR => new Bool4(R, B, R, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, Z, X, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XZXY => new Bool4(X, Z, X, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, B, R, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RBRG => new Bool4(R, B, R, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, Z, X, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XZXZ => new Bool4(X, Z, X, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, B, R, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RBRB => new Bool4(R, B, R, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, Z, X, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XZXW => new Bool4(X, Z, X, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, B, R, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RBRA => new Bool4(R, B, R, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, Z, Y, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XZYX => new Bool4(X, Z, Y, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, B, G, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RBGR => new Bool4(R, B, G, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, Z, Y, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XZYY => new Bool4(X, Z, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, B, G, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RBGG => new Bool4(R, B, G, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, Z, Y, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XZYZ => new Bool4(X, Z, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, B, G, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RBGB => new Bool4(R, B, G, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, Z, Y, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XZYW => new Bool4(X, Z, Y, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, B, G, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RBGA => new Bool4(R, B, G, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, Z, Z, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XZZX => new Bool4(X, Z, Z, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, B, B, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RBBR => new Bool4(R, B, B, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, Z, Z, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XZZY => new Bool4(X, Z, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, B, B, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RBBG => new Bool4(R, B, B, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, Z, Z, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XZZZ => new Bool4(X, Z, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, B, B, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RBBB => new Bool4(R, B, B, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, Z, Z, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XZZW => new Bool4(X, Z, Z, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, B, B, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RBBA => new Bool4(R, B, B, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, Z, W, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XZWX => new Bool4(X, Z, W, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, B, A, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RBAR => new Bool4(R, B, A, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, Z, W, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XZWY => new Bool4(X, Z, W, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, B, A, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RBAG => new Bool4(R, B, A, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, Z, W, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XZWZ => new Bool4(X, Z, W, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, B, A, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RBAB => new Bool4(R, B, A, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, Z, W, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XZWW => new Bool4(X, Z, W, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, B, A, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RBAA => new Bool4(R, B, A, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, W, X, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XWXX => new Bool4(X, W, X, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, A, R, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RARR => new Bool4(R, A, R, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, W, X, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XWXY => new Bool4(X, W, X, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, A, R, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RARG => new Bool4(R, A, R, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, W, X, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XWXZ => new Bool4(X, W, X, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, A, R, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RARB => new Bool4(R, A, R, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, W, X, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XWXW => new Bool4(X, W, X, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, A, R, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RARA => new Bool4(R, A, R, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, W, Y, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XWYX => new Bool4(X, W, Y, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, A, G, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RAGR => new Bool4(R, A, G, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, W, Y, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XWYY => new Bool4(X, W, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, A, G, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RAGG => new Bool4(R, A, G, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, W, Y, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XWYZ => new Bool4(X, W, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, A, G, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RAGB => new Bool4(R, A, G, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, W, Y, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XWYW => new Bool4(X, W, Y, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, A, G, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RAGA => new Bool4(R, A, G, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, W, Z, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XWZX => new Bool4(X, W, Z, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, A, B, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RABR => new Bool4(R, A, B, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, W, Z, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XWZY => new Bool4(X, W, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, A, B, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RABG => new Bool4(R, A, B, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, W, Z, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XWZZ => new Bool4(X, W, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, A, B, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RABB => new Bool4(R, A, B, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, W, Z, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XWZW => new Bool4(X, W, Z, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, A, B, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RABA => new Bool4(R, A, B, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, W, W, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XWWX => new Bool4(X, W, W, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, A, A, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RAAR => new Bool4(R, A, A, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, W, W, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XWWY => new Bool4(X, W, W, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, A, A, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RAAG => new Bool4(R, A, A, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, W, W, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XWWZ => new Bool4(X, W, W, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, A, A, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RAAB => new Bool4(R, A, A, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of X, W, W, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XWWW => new Bool4(X, W, W, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of R, A, A, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RAAA => new Bool4(R, A, A, A);

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
		/// Returns a new <see cref="Bool4"/> comprised of Y, X, X, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YXXZ => new Bool4(Y, X, X, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, R, R, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GRRB => new Bool4(G, R, R, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, X, X, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YXXW => new Bool4(Y, X, X, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, R, R, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GRRA => new Bool4(G, R, R, A);

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
		/// Returns a new <see cref="Bool4"/> comprised of Y, X, Y, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YXYZ => new Bool4(Y, X, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, R, G, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GRGB => new Bool4(G, R, G, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, X, Y, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YXYW => new Bool4(Y, X, Y, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, R, G, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GRGA => new Bool4(G, R, G, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, X, Z, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YXZX => new Bool4(Y, X, Z, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, R, B, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GRBR => new Bool4(G, R, B, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, X, Z, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YXZY => new Bool4(Y, X, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, R, B, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GRBG => new Bool4(G, R, B, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, X, Z, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YXZZ => new Bool4(Y, X, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, R, B, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GRBB => new Bool4(G, R, B, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, X, Z, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YXZW => new Bool4(Y, X, Z, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, R, B, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GRBA => new Bool4(G, R, B, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, X, W, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YXWX => new Bool4(Y, X, W, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, R, A, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GRAR => new Bool4(G, R, A, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, X, W, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YXWY => new Bool4(Y, X, W, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, R, A, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GRAG => new Bool4(G, R, A, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, X, W, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YXWZ => new Bool4(Y, X, W, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, R, A, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GRAB => new Bool4(G, R, A, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, X, W, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YXWW => new Bool4(Y, X, W, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, R, A, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GRAA => new Bool4(G, R, A, A);

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
		/// Returns a new <see cref="Bool4"/> comprised of Y, Y, X, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YYXZ => new Bool4(Y, Y, X, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, G, R, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GGRB => new Bool4(G, G, R, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, Y, X, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YYXW => new Bool4(Y, Y, X, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, G, R, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GGRA => new Bool4(G, G, R, A);

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

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, Y, Y, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YYYZ => new Bool4(Y, Y, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, G, G, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GGGB => new Bool4(G, G, G, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, Y, Y, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YYYW => new Bool4(Y, Y, Y, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, G, G, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GGGA => new Bool4(G, G, G, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, Y, Z, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YYZX => new Bool4(Y, Y, Z, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, G, B, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GGBR => new Bool4(G, G, B, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, Y, Z, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YYZY => new Bool4(Y, Y, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, G, B, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GGBG => new Bool4(G, G, B, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, Y, Z, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YYZZ => new Bool4(Y, Y, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, G, B, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GGBB => new Bool4(G, G, B, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, Y, Z, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YYZW => new Bool4(Y, Y, Z, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, G, B, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GGBA => new Bool4(G, G, B, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, Y, W, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YYWX => new Bool4(Y, Y, W, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, G, A, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GGAR => new Bool4(G, G, A, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, Y, W, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YYWY => new Bool4(Y, Y, W, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, G, A, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GGAG => new Bool4(G, G, A, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, Y, W, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YYWZ => new Bool4(Y, Y, W, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, G, A, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GGAB => new Bool4(G, G, A, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, Y, W, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YYWW => new Bool4(Y, Y, W, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, G, A, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GGAA => new Bool4(G, G, A, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, Z, X, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YZXX => new Bool4(Y, Z, X, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, B, R, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GBRR => new Bool4(G, B, R, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, Z, X, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YZXY => new Bool4(Y, Z, X, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, B, R, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GBRG => new Bool4(G, B, R, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, Z, X, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YZXZ => new Bool4(Y, Z, X, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, B, R, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GBRB => new Bool4(G, B, R, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, Z, X, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YZXW => new Bool4(Y, Z, X, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, B, R, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GBRA => new Bool4(G, B, R, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, Z, Y, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YZYX => new Bool4(Y, Z, Y, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, B, G, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GBGR => new Bool4(G, B, G, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, Z, Y, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YZYY => new Bool4(Y, Z, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, B, G, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GBGG => new Bool4(G, B, G, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, Z, Y, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YZYZ => new Bool4(Y, Z, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, B, G, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GBGB => new Bool4(G, B, G, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, Z, Y, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YZYW => new Bool4(Y, Z, Y, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, B, G, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GBGA => new Bool4(G, B, G, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, Z, Z, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YZZX => new Bool4(Y, Z, Z, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, B, B, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GBBR => new Bool4(G, B, B, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, Z, Z, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YZZY => new Bool4(Y, Z, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, B, B, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GBBG => new Bool4(G, B, B, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, Z, Z, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YZZZ => new Bool4(Y, Z, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, B, B, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GBBB => new Bool4(G, B, B, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, Z, Z, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YZZW => new Bool4(Y, Z, Z, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, B, B, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GBBA => new Bool4(G, B, B, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, Z, W, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YZWX => new Bool4(Y, Z, W, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, B, A, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GBAR => new Bool4(G, B, A, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, Z, W, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YZWY => new Bool4(Y, Z, W, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, B, A, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GBAG => new Bool4(G, B, A, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, Z, W, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YZWZ => new Bool4(Y, Z, W, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, B, A, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GBAB => new Bool4(G, B, A, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, Z, W, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YZWW => new Bool4(Y, Z, W, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, B, A, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GBAA => new Bool4(G, B, A, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, W, X, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YWXX => new Bool4(Y, W, X, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, A, R, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GARR => new Bool4(G, A, R, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, W, X, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YWXY => new Bool4(Y, W, X, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, A, R, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GARG => new Bool4(G, A, R, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, W, X, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YWXZ => new Bool4(Y, W, X, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, A, R, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GARB => new Bool4(G, A, R, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, W, X, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YWXW => new Bool4(Y, W, X, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, A, R, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GARA => new Bool4(G, A, R, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, W, Y, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YWYX => new Bool4(Y, W, Y, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, A, G, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GAGR => new Bool4(G, A, G, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, W, Y, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YWYY => new Bool4(Y, W, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, A, G, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GAGG => new Bool4(G, A, G, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, W, Y, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YWYZ => new Bool4(Y, W, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, A, G, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GAGB => new Bool4(G, A, G, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, W, Y, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YWYW => new Bool4(Y, W, Y, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, A, G, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GAGA => new Bool4(G, A, G, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, W, Z, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YWZX => new Bool4(Y, W, Z, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, A, B, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GABR => new Bool4(G, A, B, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, W, Z, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YWZY => new Bool4(Y, W, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, A, B, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GABG => new Bool4(G, A, B, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, W, Z, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YWZZ => new Bool4(Y, W, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, A, B, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GABB => new Bool4(G, A, B, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, W, Z, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YWZW => new Bool4(Y, W, Z, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, A, B, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GABA => new Bool4(G, A, B, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, W, W, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YWWX => new Bool4(Y, W, W, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, A, A, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GAAR => new Bool4(G, A, A, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, W, W, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YWWY => new Bool4(Y, W, W, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, A, A, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GAAG => new Bool4(G, A, A, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, W, W, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YWWZ => new Bool4(Y, W, W, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, A, A, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GAAB => new Bool4(G, A, A, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Y, W, W, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YWWW => new Bool4(Y, W, W, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of G, A, A, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GAAA => new Bool4(G, A, A, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, X, X, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZXXX => new Bool4(Z, X, X, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, R, R, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BRRR => new Bool4(B, R, R, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, X, X, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZXXY => new Bool4(Z, X, X, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, R, R, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BRRG => new Bool4(B, R, R, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, X, X, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZXXZ => new Bool4(Z, X, X, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, R, R, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BRRB => new Bool4(B, R, R, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, X, X, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZXXW => new Bool4(Z, X, X, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, R, R, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BRRA => new Bool4(B, R, R, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, X, Y, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZXYX => new Bool4(Z, X, Y, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, R, G, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BRGR => new Bool4(B, R, G, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, X, Y, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZXYY => new Bool4(Z, X, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, R, G, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BRGG => new Bool4(B, R, G, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, X, Y, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZXYZ => new Bool4(Z, X, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, R, G, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BRGB => new Bool4(B, R, G, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, X, Y, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZXYW => new Bool4(Z, X, Y, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, R, G, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BRGA => new Bool4(B, R, G, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, X, Z, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZXZX => new Bool4(Z, X, Z, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, R, B, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BRBR => new Bool4(B, R, B, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, X, Z, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZXZY => new Bool4(Z, X, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, R, B, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BRBG => new Bool4(B, R, B, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, X, Z, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZXZZ => new Bool4(Z, X, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, R, B, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BRBB => new Bool4(B, R, B, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, X, Z, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZXZW => new Bool4(Z, X, Z, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, R, B, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BRBA => new Bool4(B, R, B, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, X, W, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZXWX => new Bool4(Z, X, W, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, R, A, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BRAR => new Bool4(B, R, A, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, X, W, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZXWY => new Bool4(Z, X, W, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, R, A, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BRAG => new Bool4(B, R, A, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, X, W, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZXWZ => new Bool4(Z, X, W, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, R, A, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BRAB => new Bool4(B, R, A, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, X, W, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZXWW => new Bool4(Z, X, W, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, R, A, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BRAA => new Bool4(B, R, A, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, Y, X, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZYXX => new Bool4(Z, Y, X, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, G, R, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BGRR => new Bool4(B, G, R, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, Y, X, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZYXY => new Bool4(Z, Y, X, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, G, R, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BGRG => new Bool4(B, G, R, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, Y, X, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZYXZ => new Bool4(Z, Y, X, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, G, R, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BGRB => new Bool4(B, G, R, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, Y, X, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZYXW => new Bool4(Z, Y, X, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, G, R, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BGRA => new Bool4(B, G, R, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, Y, Y, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZYYX => new Bool4(Z, Y, Y, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, G, G, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BGGR => new Bool4(B, G, G, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, Y, Y, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZYYY => new Bool4(Z, Y, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, G, G, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BGGG => new Bool4(B, G, G, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, Y, Y, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZYYZ => new Bool4(Z, Y, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, G, G, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BGGB => new Bool4(B, G, G, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, Y, Y, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZYYW => new Bool4(Z, Y, Y, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, G, G, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BGGA => new Bool4(B, G, G, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, Y, Z, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZYZX => new Bool4(Z, Y, Z, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, G, B, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BGBR => new Bool4(B, G, B, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, Y, Z, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZYZY => new Bool4(Z, Y, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, G, B, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BGBG => new Bool4(B, G, B, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, Y, Z, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZYZZ => new Bool4(Z, Y, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, G, B, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BGBB => new Bool4(B, G, B, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, Y, Z, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZYZW => new Bool4(Z, Y, Z, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, G, B, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BGBA => new Bool4(B, G, B, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, Y, W, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZYWX => new Bool4(Z, Y, W, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, G, A, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BGAR => new Bool4(B, G, A, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, Y, W, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZYWY => new Bool4(Z, Y, W, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, G, A, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BGAG => new Bool4(B, G, A, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, Y, W, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZYWZ => new Bool4(Z, Y, W, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, G, A, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BGAB => new Bool4(B, G, A, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, Y, W, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZYWW => new Bool4(Z, Y, W, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, G, A, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BGAA => new Bool4(B, G, A, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, Z, X, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZZXX => new Bool4(Z, Z, X, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, B, R, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BBRR => new Bool4(B, B, R, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, Z, X, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZZXY => new Bool4(Z, Z, X, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, B, R, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BBRG => new Bool4(B, B, R, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, Z, X, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZZXZ => new Bool4(Z, Z, X, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, B, R, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BBRB => new Bool4(B, B, R, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, Z, X, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZZXW => new Bool4(Z, Z, X, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, B, R, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BBRA => new Bool4(B, B, R, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, Z, Y, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZZYX => new Bool4(Z, Z, Y, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, B, G, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BBGR => new Bool4(B, B, G, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, Z, Y, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZZYY => new Bool4(Z, Z, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, B, G, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BBGG => new Bool4(B, B, G, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, Z, Y, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZZYZ => new Bool4(Z, Z, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, B, G, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BBGB => new Bool4(B, B, G, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, Z, Y, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZZYW => new Bool4(Z, Z, Y, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, B, G, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BBGA => new Bool4(B, B, G, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, Z, Z, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZZZX => new Bool4(Z, Z, Z, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, B, B, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BBBR => new Bool4(B, B, B, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, Z, Z, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZZZY => new Bool4(Z, Z, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, B, B, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BBBG => new Bool4(B, B, B, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, Z, Z, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZZZZ => new Bool4(Z, Z, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, B, B, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BBBB => new Bool4(B, B, B, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, Z, Z, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZZZW => new Bool4(Z, Z, Z, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, B, B, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BBBA => new Bool4(B, B, B, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, Z, W, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZZWX => new Bool4(Z, Z, W, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, B, A, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BBAR => new Bool4(B, B, A, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, Z, W, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZZWY => new Bool4(Z, Z, W, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, B, A, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BBAG => new Bool4(B, B, A, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, Z, W, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZZWZ => new Bool4(Z, Z, W, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, B, A, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BBAB => new Bool4(B, B, A, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, Z, W, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZZWW => new Bool4(Z, Z, W, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, B, A, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BBAA => new Bool4(B, B, A, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, W, X, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZWXX => new Bool4(Z, W, X, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, A, R, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BARR => new Bool4(B, A, R, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, W, X, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZWXY => new Bool4(Z, W, X, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, A, R, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BARG => new Bool4(B, A, R, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, W, X, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZWXZ => new Bool4(Z, W, X, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, A, R, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BARB => new Bool4(B, A, R, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, W, X, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZWXW => new Bool4(Z, W, X, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, A, R, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BARA => new Bool4(B, A, R, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, W, Y, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZWYX => new Bool4(Z, W, Y, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, A, G, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BAGR => new Bool4(B, A, G, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, W, Y, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZWYY => new Bool4(Z, W, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, A, G, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BAGG => new Bool4(B, A, G, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, W, Y, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZWYZ => new Bool4(Z, W, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, A, G, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BAGB => new Bool4(B, A, G, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, W, Y, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZWYW => new Bool4(Z, W, Y, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, A, G, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BAGA => new Bool4(B, A, G, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, W, Z, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZWZX => new Bool4(Z, W, Z, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, A, B, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BABR => new Bool4(B, A, B, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, W, Z, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZWZY => new Bool4(Z, W, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, A, B, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BABG => new Bool4(B, A, B, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, W, Z, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZWZZ => new Bool4(Z, W, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, A, B, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BABB => new Bool4(B, A, B, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, W, Z, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZWZW => new Bool4(Z, W, Z, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, A, B, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BABA => new Bool4(B, A, B, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, W, W, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZWWX => new Bool4(Z, W, W, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, A, A, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BAAR => new Bool4(B, A, A, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, W, W, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZWWY => new Bool4(Z, W, W, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, A, A, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BAAG => new Bool4(B, A, A, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, W, W, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZWWZ => new Bool4(Z, W, W, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, A, A, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BAAB => new Bool4(B, A, A, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of Z, W, W, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZWWW => new Bool4(Z, W, W, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of B, A, A, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BAAA => new Bool4(B, A, A, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, X, X, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WXXX => new Bool4(W, X, X, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, R, R, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ARRR => new Bool4(A, R, R, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, X, X, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WXXY => new Bool4(W, X, X, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, R, R, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ARRG => new Bool4(A, R, R, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, X, X, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WXXZ => new Bool4(W, X, X, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, R, R, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ARRB => new Bool4(A, R, R, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, X, X, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WXXW => new Bool4(W, X, X, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, R, R, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ARRA => new Bool4(A, R, R, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, X, Y, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WXYX => new Bool4(W, X, Y, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, R, G, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ARGR => new Bool4(A, R, G, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, X, Y, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WXYY => new Bool4(W, X, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, R, G, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ARGG => new Bool4(A, R, G, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, X, Y, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WXYZ => new Bool4(W, X, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, R, G, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ARGB => new Bool4(A, R, G, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, X, Y, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WXYW => new Bool4(W, X, Y, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, R, G, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ARGA => new Bool4(A, R, G, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, X, Z, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WXZX => new Bool4(W, X, Z, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, R, B, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ARBR => new Bool4(A, R, B, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, X, Z, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WXZY => new Bool4(W, X, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, R, B, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ARBG => new Bool4(A, R, B, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, X, Z, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WXZZ => new Bool4(W, X, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, R, B, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ARBB => new Bool4(A, R, B, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, X, Z, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WXZW => new Bool4(W, X, Z, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, R, B, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ARBA => new Bool4(A, R, B, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, X, W, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WXWX => new Bool4(W, X, W, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, R, A, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ARAR => new Bool4(A, R, A, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, X, W, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WXWY => new Bool4(W, X, W, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, R, A, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ARAG => new Bool4(A, R, A, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, X, W, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WXWZ => new Bool4(W, X, W, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, R, A, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ARAB => new Bool4(A, R, A, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, X, W, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WXWW => new Bool4(W, X, W, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, R, A, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ARAA => new Bool4(A, R, A, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, Y, X, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WYXX => new Bool4(W, Y, X, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, G, R, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 AGRR => new Bool4(A, G, R, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, Y, X, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WYXY => new Bool4(W, Y, X, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, G, R, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 AGRG => new Bool4(A, G, R, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, Y, X, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WYXZ => new Bool4(W, Y, X, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, G, R, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 AGRB => new Bool4(A, G, R, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, Y, X, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WYXW => new Bool4(W, Y, X, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, G, R, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 AGRA => new Bool4(A, G, R, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, Y, Y, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WYYX => new Bool4(W, Y, Y, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, G, G, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 AGGR => new Bool4(A, G, G, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, Y, Y, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WYYY => new Bool4(W, Y, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, G, G, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 AGGG => new Bool4(A, G, G, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, Y, Y, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WYYZ => new Bool4(W, Y, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, G, G, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 AGGB => new Bool4(A, G, G, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, Y, Y, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WYYW => new Bool4(W, Y, Y, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, G, G, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 AGGA => new Bool4(A, G, G, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, Y, Z, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WYZX => new Bool4(W, Y, Z, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, G, B, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 AGBR => new Bool4(A, G, B, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, Y, Z, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WYZY => new Bool4(W, Y, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, G, B, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 AGBG => new Bool4(A, G, B, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, Y, Z, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WYZZ => new Bool4(W, Y, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, G, B, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 AGBB => new Bool4(A, G, B, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, Y, Z, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WYZW => new Bool4(W, Y, Z, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, G, B, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 AGBA => new Bool4(A, G, B, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, Y, W, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WYWX => new Bool4(W, Y, W, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, G, A, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 AGAR => new Bool4(A, G, A, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, Y, W, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WYWY => new Bool4(W, Y, W, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, G, A, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 AGAG => new Bool4(A, G, A, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, Y, W, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WYWZ => new Bool4(W, Y, W, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, G, A, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 AGAB => new Bool4(A, G, A, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, Y, W, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WYWW => new Bool4(W, Y, W, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, G, A, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 AGAA => new Bool4(A, G, A, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, Z, X, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WZXX => new Bool4(W, Z, X, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, B, R, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ABRR => new Bool4(A, B, R, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, Z, X, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WZXY => new Bool4(W, Z, X, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, B, R, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ABRG => new Bool4(A, B, R, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, Z, X, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WZXZ => new Bool4(W, Z, X, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, B, R, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ABRB => new Bool4(A, B, R, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, Z, X, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WZXW => new Bool4(W, Z, X, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, B, R, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ABRA => new Bool4(A, B, R, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, Z, Y, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WZYX => new Bool4(W, Z, Y, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, B, G, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ABGR => new Bool4(A, B, G, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, Z, Y, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WZYY => new Bool4(W, Z, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, B, G, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ABGG => new Bool4(A, B, G, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, Z, Y, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WZYZ => new Bool4(W, Z, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, B, G, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ABGB => new Bool4(A, B, G, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, Z, Y, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WZYW => new Bool4(W, Z, Y, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, B, G, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ABGA => new Bool4(A, B, G, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, Z, Z, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WZZX => new Bool4(W, Z, Z, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, B, B, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ABBR => new Bool4(A, B, B, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, Z, Z, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WZZY => new Bool4(W, Z, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, B, B, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ABBG => new Bool4(A, B, B, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, Z, Z, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WZZZ => new Bool4(W, Z, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, B, B, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ABBB => new Bool4(A, B, B, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, Z, Z, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WZZW => new Bool4(W, Z, Z, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, B, B, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ABBA => new Bool4(A, B, B, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, Z, W, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WZWX => new Bool4(W, Z, W, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, B, A, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ABAR => new Bool4(A, B, A, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, Z, W, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WZWY => new Bool4(W, Z, W, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, B, A, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ABAG => new Bool4(A, B, A, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, Z, W, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WZWZ => new Bool4(W, Z, W, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, B, A, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ABAB => new Bool4(A, B, A, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, Z, W, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WZWW => new Bool4(W, Z, W, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, B, A, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ABAA => new Bool4(A, B, A, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, W, X, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WWXX => new Bool4(W, W, X, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, A, R, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 AARR => new Bool4(A, A, R, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, W, X, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WWXY => new Bool4(W, W, X, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, A, R, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 AARG => new Bool4(A, A, R, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, W, X, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WWXZ => new Bool4(W, W, X, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, A, R, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 AARB => new Bool4(A, A, R, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, W, X, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WWXW => new Bool4(W, W, X, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, A, R, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 AARA => new Bool4(A, A, R, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, W, Y, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WWYX => new Bool4(W, W, Y, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, A, G, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 AAGR => new Bool4(A, A, G, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, W, Y, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WWYY => new Bool4(W, W, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, A, G, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 AAGG => new Bool4(A, A, G, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, W, Y, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WWYZ => new Bool4(W, W, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, A, G, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 AAGB => new Bool4(A, A, G, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, W, Y, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WWYW => new Bool4(W, W, Y, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, A, G, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 AAGA => new Bool4(A, A, G, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, W, Z, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WWZX => new Bool4(W, W, Z, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, A, B, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 AABR => new Bool4(A, A, B, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, W, Z, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WWZY => new Bool4(W, W, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, A, B, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 AABG => new Bool4(A, A, B, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, W, Z, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WWZZ => new Bool4(W, W, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, A, B, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 AABB => new Bool4(A, A, B, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, W, Z, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WWZW => new Bool4(W, W, Z, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, A, B, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 AABA => new Bool4(A, A, B, A);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, W, W, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WWWX => new Bool4(W, W, W, X);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, A, A, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 AAAR => new Bool4(A, A, A, R);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, W, W, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WWWY => new Bool4(W, W, W, Y);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, A, A, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 AAAG => new Bool4(A, A, A, G);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, W, W, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WWWZ => new Bool4(W, W, W, Z);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, A, A, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 AAAB => new Bool4(A, A, A, B);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of W, W, W, W from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 WWWW => new Bool4(W, W, W, W);

		/// <summary>
		/// Returns a new <see cref="Bool4"/> comprised of A, A, A, A from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 AAAA => new Bool4(A, A, A, A);

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

		public bool A
		{
			get => W;
			set => W = value;
		}

	}
}
