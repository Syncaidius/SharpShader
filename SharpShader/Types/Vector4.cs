using System.Runtime.InteropServices;

namespace SharpShader
{
	[StructLayout(LayoutKind.Sequential)]
	public struct Vector4 : IVector, IIntrinsicValue
	{
        /// <summary>
        /// The X component.
        /// </summary>
		public float X;

        /// <summary>
        /// The Y component.
        /// </summary>
		public float Y;

        /// <summary>
        /// The Z component.
        /// </summary>
		public float Z;

        /// <summary>
        /// The W component.
        /// </summary>
		public float W;

        /// <summary>
        /// Creates a new instance of <see cref="Vector4"/>.
        /// </summary>
		public Vector4(float x, float y, float z, float w)
		{
			X = x;
			Y = y;
			Z = z;
			W = w;
		}

		/// <summary>
		/// Returns a new <see cref="Vector2"/> comprised of X, X from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 XX => new Vector2(X, X);

		/// <summary>
		/// Returns a new <see cref="Vector2"/> comprised of R, R from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 RR => new Vector2(R, R);

		/// <summary>
		/// Returns a new <see cref="Vector2"/> comprised of X, Y from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 XY => new Vector2(X, Y);

		/// <summary>
		/// Returns a new <see cref="Vector2"/> comprised of R, G from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 RG => new Vector2(R, G);

		/// <summary>
		/// Returns a new <see cref="Vector2"/> comprised of X, Z from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 XZ => new Vector2(X, Z);

		/// <summary>
		/// Returns a new <see cref="Vector2"/> comprised of R, B from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 RB => new Vector2(R, B);

		/// <summary>
		/// Returns a new <see cref="Vector2"/> comprised of X, W from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 XW => new Vector2(X, W);

		/// <summary>
		/// Returns a new <see cref="Vector2"/> comprised of R, A from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 RA => new Vector2(R, A);

		/// <summary>
		/// Returns a new <see cref="Vector2"/> comprised of Y, X from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 YX => new Vector2(Y, X);

		/// <summary>
		/// Returns a new <see cref="Vector2"/> comprised of G, R from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 GR => new Vector2(G, R);

		/// <summary>
		/// Returns a new <see cref="Vector2"/> comprised of Y, Y from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 YY => new Vector2(Y, Y);

		/// <summary>
		/// Returns a new <see cref="Vector2"/> comprised of G, G from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 GG => new Vector2(G, G);

		/// <summary>
		/// Returns a new <see cref="Vector2"/> comprised of Y, Z from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 YZ => new Vector2(Y, Z);

		/// <summary>
		/// Returns a new <see cref="Vector2"/> comprised of G, B from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 GB => new Vector2(G, B);

		/// <summary>
		/// Returns a new <see cref="Vector2"/> comprised of Y, W from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 YW => new Vector2(Y, W);

		/// <summary>
		/// Returns a new <see cref="Vector2"/> comprised of G, A from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 GA => new Vector2(G, A);

		/// <summary>
		/// Returns a new <see cref="Vector2"/> comprised of Z, X from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 ZX => new Vector2(Z, X);

		/// <summary>
		/// Returns a new <see cref="Vector2"/> comprised of B, R from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 BR => new Vector2(B, R);

		/// <summary>
		/// Returns a new <see cref="Vector2"/> comprised of Z, Y from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 ZY => new Vector2(Z, Y);

		/// <summary>
		/// Returns a new <see cref="Vector2"/> comprised of B, G from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 BG => new Vector2(B, G);

		/// <summary>
		/// Returns a new <see cref="Vector2"/> comprised of Z, Z from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 ZZ => new Vector2(Z, Z);

		/// <summary>
		/// Returns a new <see cref="Vector2"/> comprised of B, B from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 BB => new Vector2(B, B);

		/// <summary>
		/// Returns a new <see cref="Vector2"/> comprised of Z, W from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 ZW => new Vector2(Z, W);

		/// <summary>
		/// Returns a new <see cref="Vector2"/> comprised of B, A from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 BA => new Vector2(B, A);

		/// <summary>
		/// Returns a new <see cref="Vector2"/> comprised of W, X from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 WX => new Vector2(W, X);

		/// <summary>
		/// Returns a new <see cref="Vector2"/> comprised of A, R from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 AR => new Vector2(A, R);

		/// <summary>
		/// Returns a new <see cref="Vector2"/> comprised of W, Y from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 WY => new Vector2(W, Y);

		/// <summary>
		/// Returns a new <see cref="Vector2"/> comprised of A, G from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 AG => new Vector2(A, G);

		/// <summary>
		/// Returns a new <see cref="Vector2"/> comprised of W, Z from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 WZ => new Vector2(W, Z);

		/// <summary>
		/// Returns a new <see cref="Vector2"/> comprised of A, B from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 AB => new Vector2(A, B);

		/// <summary>
		/// Returns a new <see cref="Vector2"/> comprised of W, W from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 WW => new Vector2(W, W);

		/// <summary>
		/// Returns a new <see cref="Vector2"/> comprised of A, A from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 AA => new Vector2(A, A);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of X, X, X from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 XXX => new Vector3(X, X, X);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of R, R, R from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 RRR => new Vector3(R, R, R);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of X, X, Y from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 XXY => new Vector3(X, X, Y);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of R, R, G from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 RRG => new Vector3(R, R, G);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of X, X, Z from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 XXZ => new Vector3(X, X, Z);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of R, R, B from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 RRB => new Vector3(R, R, B);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of X, X, W from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 XXW => new Vector3(X, X, W);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of R, R, A from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 RRA => new Vector3(R, R, A);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of X, Y, X from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 XYX => new Vector3(X, Y, X);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of R, G, R from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 RGR => new Vector3(R, G, R);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of X, Y, Y from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 XYY => new Vector3(X, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of R, G, G from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 RGG => new Vector3(R, G, G);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of X, Y, Z from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 XYZ => new Vector3(X, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of R, G, B from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 RGB => new Vector3(R, G, B);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of X, Y, W from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 XYW => new Vector3(X, Y, W);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of R, G, A from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 RGA => new Vector3(R, G, A);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of X, Z, X from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 XZX => new Vector3(X, Z, X);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of R, B, R from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 RBR => new Vector3(R, B, R);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of X, Z, Y from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 XZY => new Vector3(X, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of R, B, G from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 RBG => new Vector3(R, B, G);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of X, Z, Z from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 XZZ => new Vector3(X, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of R, B, B from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 RBB => new Vector3(R, B, B);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of X, Z, W from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 XZW => new Vector3(X, Z, W);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of R, B, A from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 RBA => new Vector3(R, B, A);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of X, W, X from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 XWX => new Vector3(X, W, X);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of R, A, R from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 RAR => new Vector3(R, A, R);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of X, W, Y from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 XWY => new Vector3(X, W, Y);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of R, A, G from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 RAG => new Vector3(R, A, G);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of X, W, Z from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 XWZ => new Vector3(X, W, Z);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of R, A, B from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 RAB => new Vector3(R, A, B);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of X, W, W from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 XWW => new Vector3(X, W, W);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of R, A, A from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 RAA => new Vector3(R, A, A);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of Y, X, X from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 YXX => new Vector3(Y, X, X);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of G, R, R from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 GRR => new Vector3(G, R, R);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of Y, X, Y from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 YXY => new Vector3(Y, X, Y);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of G, R, G from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 GRG => new Vector3(G, R, G);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of Y, X, Z from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 YXZ => new Vector3(Y, X, Z);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of G, R, B from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 GRB => new Vector3(G, R, B);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of Y, X, W from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 YXW => new Vector3(Y, X, W);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of G, R, A from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 GRA => new Vector3(G, R, A);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of Y, Y, X from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 YYX => new Vector3(Y, Y, X);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of G, G, R from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 GGR => new Vector3(G, G, R);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of Y, Y, Y from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 YYY => new Vector3(Y, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of G, G, G from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 GGG => new Vector3(G, G, G);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of Y, Y, Z from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 YYZ => new Vector3(Y, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of G, G, B from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 GGB => new Vector3(G, G, B);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of Y, Y, W from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 YYW => new Vector3(Y, Y, W);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of G, G, A from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 GGA => new Vector3(G, G, A);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of Y, Z, X from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 YZX => new Vector3(Y, Z, X);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of G, B, R from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 GBR => new Vector3(G, B, R);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of Y, Z, Y from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 YZY => new Vector3(Y, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of G, B, G from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 GBG => new Vector3(G, B, G);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of Y, Z, Z from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 YZZ => new Vector3(Y, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of G, B, B from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 GBB => new Vector3(G, B, B);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of Y, Z, W from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 YZW => new Vector3(Y, Z, W);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of G, B, A from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 GBA => new Vector3(G, B, A);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of Y, W, X from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 YWX => new Vector3(Y, W, X);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of G, A, R from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 GAR => new Vector3(G, A, R);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of Y, W, Y from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 YWY => new Vector3(Y, W, Y);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of G, A, G from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 GAG => new Vector3(G, A, G);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of Y, W, Z from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 YWZ => new Vector3(Y, W, Z);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of G, A, B from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 GAB => new Vector3(G, A, B);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of Y, W, W from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 YWW => new Vector3(Y, W, W);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of G, A, A from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 GAA => new Vector3(G, A, A);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of Z, X, X from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 ZXX => new Vector3(Z, X, X);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of B, R, R from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 BRR => new Vector3(B, R, R);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of Z, X, Y from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 ZXY => new Vector3(Z, X, Y);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of B, R, G from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 BRG => new Vector3(B, R, G);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of Z, X, Z from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 ZXZ => new Vector3(Z, X, Z);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of B, R, B from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 BRB => new Vector3(B, R, B);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of Z, X, W from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 ZXW => new Vector3(Z, X, W);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of B, R, A from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 BRA => new Vector3(B, R, A);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of Z, Y, X from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 ZYX => new Vector3(Z, Y, X);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of B, G, R from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 BGR => new Vector3(B, G, R);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of Z, Y, Y from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 ZYY => new Vector3(Z, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of B, G, G from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 BGG => new Vector3(B, G, G);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of Z, Y, Z from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 ZYZ => new Vector3(Z, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of B, G, B from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 BGB => new Vector3(B, G, B);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of Z, Y, W from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 ZYW => new Vector3(Z, Y, W);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of B, G, A from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 BGA => new Vector3(B, G, A);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of Z, Z, X from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 ZZX => new Vector3(Z, Z, X);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of B, B, R from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 BBR => new Vector3(B, B, R);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of Z, Z, Y from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 ZZY => new Vector3(Z, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of B, B, G from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 BBG => new Vector3(B, B, G);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of Z, Z, Z from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 ZZZ => new Vector3(Z, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of B, B, B from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 BBB => new Vector3(B, B, B);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of Z, Z, W from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 ZZW => new Vector3(Z, Z, W);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of B, B, A from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 BBA => new Vector3(B, B, A);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of Z, W, X from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 ZWX => new Vector3(Z, W, X);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of B, A, R from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 BAR => new Vector3(B, A, R);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of Z, W, Y from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 ZWY => new Vector3(Z, W, Y);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of B, A, G from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 BAG => new Vector3(B, A, G);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of Z, W, Z from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 ZWZ => new Vector3(Z, W, Z);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of B, A, B from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 BAB => new Vector3(B, A, B);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of Z, W, W from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 ZWW => new Vector3(Z, W, W);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of B, A, A from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 BAA => new Vector3(B, A, A);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of W, X, X from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 WXX => new Vector3(W, X, X);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of A, R, R from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 ARR => new Vector3(A, R, R);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of W, X, Y from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 WXY => new Vector3(W, X, Y);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of A, R, G from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 ARG => new Vector3(A, R, G);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of W, X, Z from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 WXZ => new Vector3(W, X, Z);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of A, R, B from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 ARB => new Vector3(A, R, B);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of W, X, W from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 WXW => new Vector3(W, X, W);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of A, R, A from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 ARA => new Vector3(A, R, A);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of W, Y, X from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 WYX => new Vector3(W, Y, X);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of A, G, R from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 AGR => new Vector3(A, G, R);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of W, Y, Y from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 WYY => new Vector3(W, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of A, G, G from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 AGG => new Vector3(A, G, G);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of W, Y, Z from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 WYZ => new Vector3(W, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of A, G, B from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 AGB => new Vector3(A, G, B);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of W, Y, W from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 WYW => new Vector3(W, Y, W);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of A, G, A from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 AGA => new Vector3(A, G, A);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of W, Z, X from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 WZX => new Vector3(W, Z, X);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of A, B, R from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 ABR => new Vector3(A, B, R);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of W, Z, Y from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 WZY => new Vector3(W, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of A, B, G from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 ABG => new Vector3(A, B, G);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of W, Z, Z from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 WZZ => new Vector3(W, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of A, B, B from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 ABB => new Vector3(A, B, B);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of W, Z, W from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 WZW => new Vector3(W, Z, W);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of A, B, A from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 ABA => new Vector3(A, B, A);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of W, W, X from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 WWX => new Vector3(W, W, X);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of A, A, R from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 AAR => new Vector3(A, A, R);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of W, W, Y from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 WWY => new Vector3(W, W, Y);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of A, A, G from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 AAG => new Vector3(A, A, G);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of W, W, Z from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 WWZ => new Vector3(W, W, Z);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of A, A, B from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 AAB => new Vector3(A, A, B);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of W, W, W from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 WWW => new Vector3(W, W, W);

		/// <summary>
		/// Returns a new <see cref="Vector3"/> comprised of A, A, A from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 AAA => new Vector3(A, A, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, X, X, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XXXX => new Vector4(X, X, X, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, R, R, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RRRR => new Vector4(R, R, R, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, X, X, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XXXY => new Vector4(X, X, X, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, R, R, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RRRG => new Vector4(R, R, R, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, X, X, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XXXZ => new Vector4(X, X, X, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, R, R, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RRRB => new Vector4(R, R, R, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, X, X, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XXXW => new Vector4(X, X, X, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, R, R, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RRRA => new Vector4(R, R, R, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, X, Y, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XXYX => new Vector4(X, X, Y, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, R, G, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RRGR => new Vector4(R, R, G, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, X, Y, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XXYY => new Vector4(X, X, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, R, G, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RRGG => new Vector4(R, R, G, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, X, Y, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XXYZ => new Vector4(X, X, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, R, G, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RRGB => new Vector4(R, R, G, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, X, Y, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XXYW => new Vector4(X, X, Y, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, R, G, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RRGA => new Vector4(R, R, G, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, X, Z, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XXZX => new Vector4(X, X, Z, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, R, B, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RRBR => new Vector4(R, R, B, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, X, Z, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XXZY => new Vector4(X, X, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, R, B, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RRBG => new Vector4(R, R, B, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, X, Z, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XXZZ => new Vector4(X, X, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, R, B, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RRBB => new Vector4(R, R, B, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, X, Z, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XXZW => new Vector4(X, X, Z, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, R, B, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RRBA => new Vector4(R, R, B, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, X, W, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XXWX => new Vector4(X, X, W, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, R, A, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RRAR => new Vector4(R, R, A, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, X, W, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XXWY => new Vector4(X, X, W, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, R, A, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RRAG => new Vector4(R, R, A, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, X, W, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XXWZ => new Vector4(X, X, W, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, R, A, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RRAB => new Vector4(R, R, A, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, X, W, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XXWW => new Vector4(X, X, W, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, R, A, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RRAA => new Vector4(R, R, A, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, Y, X, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XYXX => new Vector4(X, Y, X, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, G, R, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RGRR => new Vector4(R, G, R, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, Y, X, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XYXY => new Vector4(X, Y, X, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, G, R, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RGRG => new Vector4(R, G, R, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, Y, X, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XYXZ => new Vector4(X, Y, X, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, G, R, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RGRB => new Vector4(R, G, R, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, Y, X, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XYXW => new Vector4(X, Y, X, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, G, R, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RGRA => new Vector4(R, G, R, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, Y, Y, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XYYX => new Vector4(X, Y, Y, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, G, G, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RGGR => new Vector4(R, G, G, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, Y, Y, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XYYY => new Vector4(X, Y, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, G, G, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RGGG => new Vector4(R, G, G, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, Y, Y, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XYYZ => new Vector4(X, Y, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, G, G, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RGGB => new Vector4(R, G, G, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, Y, Y, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XYYW => new Vector4(X, Y, Y, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, G, G, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RGGA => new Vector4(R, G, G, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, Y, Z, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XYZX => new Vector4(X, Y, Z, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, G, B, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RGBR => new Vector4(R, G, B, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, Y, Z, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XYZY => new Vector4(X, Y, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, G, B, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RGBG => new Vector4(R, G, B, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, Y, Z, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XYZZ => new Vector4(X, Y, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, G, B, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RGBB => new Vector4(R, G, B, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, Y, Z, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XYZW => new Vector4(X, Y, Z, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, G, B, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RGBA => new Vector4(R, G, B, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, Y, W, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XYWX => new Vector4(X, Y, W, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, G, A, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RGAR => new Vector4(R, G, A, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, Y, W, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XYWY => new Vector4(X, Y, W, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, G, A, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RGAG => new Vector4(R, G, A, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, Y, W, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XYWZ => new Vector4(X, Y, W, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, G, A, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RGAB => new Vector4(R, G, A, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, Y, W, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XYWW => new Vector4(X, Y, W, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, G, A, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RGAA => new Vector4(R, G, A, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, Z, X, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XZXX => new Vector4(X, Z, X, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, B, R, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RBRR => new Vector4(R, B, R, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, Z, X, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XZXY => new Vector4(X, Z, X, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, B, R, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RBRG => new Vector4(R, B, R, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, Z, X, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XZXZ => new Vector4(X, Z, X, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, B, R, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RBRB => new Vector4(R, B, R, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, Z, X, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XZXW => new Vector4(X, Z, X, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, B, R, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RBRA => new Vector4(R, B, R, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, Z, Y, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XZYX => new Vector4(X, Z, Y, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, B, G, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RBGR => new Vector4(R, B, G, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, Z, Y, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XZYY => new Vector4(X, Z, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, B, G, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RBGG => new Vector4(R, B, G, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, Z, Y, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XZYZ => new Vector4(X, Z, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, B, G, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RBGB => new Vector4(R, B, G, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, Z, Y, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XZYW => new Vector4(X, Z, Y, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, B, G, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RBGA => new Vector4(R, B, G, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, Z, Z, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XZZX => new Vector4(X, Z, Z, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, B, B, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RBBR => new Vector4(R, B, B, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, Z, Z, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XZZY => new Vector4(X, Z, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, B, B, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RBBG => new Vector4(R, B, B, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, Z, Z, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XZZZ => new Vector4(X, Z, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, B, B, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RBBB => new Vector4(R, B, B, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, Z, Z, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XZZW => new Vector4(X, Z, Z, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, B, B, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RBBA => new Vector4(R, B, B, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, Z, W, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XZWX => new Vector4(X, Z, W, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, B, A, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RBAR => new Vector4(R, B, A, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, Z, W, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XZWY => new Vector4(X, Z, W, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, B, A, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RBAG => new Vector4(R, B, A, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, Z, W, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XZWZ => new Vector4(X, Z, W, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, B, A, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RBAB => new Vector4(R, B, A, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, Z, W, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XZWW => new Vector4(X, Z, W, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, B, A, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RBAA => new Vector4(R, B, A, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, W, X, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XWXX => new Vector4(X, W, X, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, A, R, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RARR => new Vector4(R, A, R, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, W, X, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XWXY => new Vector4(X, W, X, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, A, R, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RARG => new Vector4(R, A, R, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, W, X, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XWXZ => new Vector4(X, W, X, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, A, R, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RARB => new Vector4(R, A, R, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, W, X, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XWXW => new Vector4(X, W, X, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, A, R, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RARA => new Vector4(R, A, R, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, W, Y, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XWYX => new Vector4(X, W, Y, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, A, G, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RAGR => new Vector4(R, A, G, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, W, Y, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XWYY => new Vector4(X, W, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, A, G, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RAGG => new Vector4(R, A, G, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, W, Y, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XWYZ => new Vector4(X, W, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, A, G, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RAGB => new Vector4(R, A, G, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, W, Y, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XWYW => new Vector4(X, W, Y, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, A, G, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RAGA => new Vector4(R, A, G, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, W, Z, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XWZX => new Vector4(X, W, Z, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, A, B, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RABR => new Vector4(R, A, B, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, W, Z, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XWZY => new Vector4(X, W, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, A, B, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RABG => new Vector4(R, A, B, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, W, Z, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XWZZ => new Vector4(X, W, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, A, B, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RABB => new Vector4(R, A, B, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, W, Z, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XWZW => new Vector4(X, W, Z, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, A, B, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RABA => new Vector4(R, A, B, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, W, W, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XWWX => new Vector4(X, W, W, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, A, A, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RAAR => new Vector4(R, A, A, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, W, W, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XWWY => new Vector4(X, W, W, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, A, A, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RAAG => new Vector4(R, A, A, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, W, W, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XWWZ => new Vector4(X, W, W, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, A, A, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RAAB => new Vector4(R, A, A, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of X, W, W, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XWWW => new Vector4(X, W, W, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of R, A, A, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RAAA => new Vector4(R, A, A, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, X, X, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YXXX => new Vector4(Y, X, X, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, R, R, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GRRR => new Vector4(G, R, R, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, X, X, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YXXY => new Vector4(Y, X, X, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, R, R, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GRRG => new Vector4(G, R, R, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, X, X, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YXXZ => new Vector4(Y, X, X, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, R, R, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GRRB => new Vector4(G, R, R, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, X, X, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YXXW => new Vector4(Y, X, X, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, R, R, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GRRA => new Vector4(G, R, R, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, X, Y, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YXYX => new Vector4(Y, X, Y, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, R, G, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GRGR => new Vector4(G, R, G, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, X, Y, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YXYY => new Vector4(Y, X, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, R, G, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GRGG => new Vector4(G, R, G, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, X, Y, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YXYZ => new Vector4(Y, X, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, R, G, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GRGB => new Vector4(G, R, G, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, X, Y, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YXYW => new Vector4(Y, X, Y, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, R, G, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GRGA => new Vector4(G, R, G, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, X, Z, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YXZX => new Vector4(Y, X, Z, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, R, B, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GRBR => new Vector4(G, R, B, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, X, Z, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YXZY => new Vector4(Y, X, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, R, B, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GRBG => new Vector4(G, R, B, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, X, Z, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YXZZ => new Vector4(Y, X, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, R, B, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GRBB => new Vector4(G, R, B, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, X, Z, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YXZW => new Vector4(Y, X, Z, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, R, B, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GRBA => new Vector4(G, R, B, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, X, W, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YXWX => new Vector4(Y, X, W, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, R, A, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GRAR => new Vector4(G, R, A, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, X, W, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YXWY => new Vector4(Y, X, W, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, R, A, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GRAG => new Vector4(G, R, A, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, X, W, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YXWZ => new Vector4(Y, X, W, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, R, A, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GRAB => new Vector4(G, R, A, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, X, W, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YXWW => new Vector4(Y, X, W, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, R, A, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GRAA => new Vector4(G, R, A, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, Y, X, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YYXX => new Vector4(Y, Y, X, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, G, R, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GGRR => new Vector4(G, G, R, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, Y, X, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YYXY => new Vector4(Y, Y, X, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, G, R, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GGRG => new Vector4(G, G, R, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, Y, X, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YYXZ => new Vector4(Y, Y, X, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, G, R, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GGRB => new Vector4(G, G, R, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, Y, X, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YYXW => new Vector4(Y, Y, X, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, G, R, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GGRA => new Vector4(G, G, R, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, Y, Y, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YYYX => new Vector4(Y, Y, Y, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, G, G, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GGGR => new Vector4(G, G, G, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, Y, Y, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YYYY => new Vector4(Y, Y, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, G, G, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GGGG => new Vector4(G, G, G, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, Y, Y, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YYYZ => new Vector4(Y, Y, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, G, G, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GGGB => new Vector4(G, G, G, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, Y, Y, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YYYW => new Vector4(Y, Y, Y, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, G, G, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GGGA => new Vector4(G, G, G, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, Y, Z, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YYZX => new Vector4(Y, Y, Z, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, G, B, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GGBR => new Vector4(G, G, B, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, Y, Z, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YYZY => new Vector4(Y, Y, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, G, B, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GGBG => new Vector4(G, G, B, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, Y, Z, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YYZZ => new Vector4(Y, Y, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, G, B, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GGBB => new Vector4(G, G, B, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, Y, Z, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YYZW => new Vector4(Y, Y, Z, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, G, B, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GGBA => new Vector4(G, G, B, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, Y, W, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YYWX => new Vector4(Y, Y, W, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, G, A, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GGAR => new Vector4(G, G, A, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, Y, W, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YYWY => new Vector4(Y, Y, W, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, G, A, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GGAG => new Vector4(G, G, A, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, Y, W, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YYWZ => new Vector4(Y, Y, W, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, G, A, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GGAB => new Vector4(G, G, A, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, Y, W, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YYWW => new Vector4(Y, Y, W, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, G, A, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GGAA => new Vector4(G, G, A, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, Z, X, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YZXX => new Vector4(Y, Z, X, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, B, R, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GBRR => new Vector4(G, B, R, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, Z, X, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YZXY => new Vector4(Y, Z, X, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, B, R, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GBRG => new Vector4(G, B, R, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, Z, X, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YZXZ => new Vector4(Y, Z, X, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, B, R, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GBRB => new Vector4(G, B, R, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, Z, X, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YZXW => new Vector4(Y, Z, X, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, B, R, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GBRA => new Vector4(G, B, R, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, Z, Y, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YZYX => new Vector4(Y, Z, Y, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, B, G, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GBGR => new Vector4(G, B, G, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, Z, Y, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YZYY => new Vector4(Y, Z, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, B, G, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GBGG => new Vector4(G, B, G, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, Z, Y, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YZYZ => new Vector4(Y, Z, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, B, G, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GBGB => new Vector4(G, B, G, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, Z, Y, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YZYW => new Vector4(Y, Z, Y, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, B, G, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GBGA => new Vector4(G, B, G, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, Z, Z, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YZZX => new Vector4(Y, Z, Z, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, B, B, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GBBR => new Vector4(G, B, B, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, Z, Z, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YZZY => new Vector4(Y, Z, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, B, B, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GBBG => new Vector4(G, B, B, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, Z, Z, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YZZZ => new Vector4(Y, Z, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, B, B, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GBBB => new Vector4(G, B, B, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, Z, Z, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YZZW => new Vector4(Y, Z, Z, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, B, B, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GBBA => new Vector4(G, B, B, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, Z, W, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YZWX => new Vector4(Y, Z, W, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, B, A, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GBAR => new Vector4(G, B, A, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, Z, W, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YZWY => new Vector4(Y, Z, W, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, B, A, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GBAG => new Vector4(G, B, A, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, Z, W, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YZWZ => new Vector4(Y, Z, W, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, B, A, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GBAB => new Vector4(G, B, A, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, Z, W, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YZWW => new Vector4(Y, Z, W, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, B, A, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GBAA => new Vector4(G, B, A, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, W, X, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YWXX => new Vector4(Y, W, X, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, A, R, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GARR => new Vector4(G, A, R, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, W, X, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YWXY => new Vector4(Y, W, X, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, A, R, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GARG => new Vector4(G, A, R, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, W, X, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YWXZ => new Vector4(Y, W, X, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, A, R, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GARB => new Vector4(G, A, R, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, W, X, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YWXW => new Vector4(Y, W, X, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, A, R, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GARA => new Vector4(G, A, R, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, W, Y, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YWYX => new Vector4(Y, W, Y, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, A, G, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GAGR => new Vector4(G, A, G, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, W, Y, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YWYY => new Vector4(Y, W, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, A, G, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GAGG => new Vector4(G, A, G, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, W, Y, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YWYZ => new Vector4(Y, W, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, A, G, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GAGB => new Vector4(G, A, G, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, W, Y, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YWYW => new Vector4(Y, W, Y, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, A, G, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GAGA => new Vector4(G, A, G, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, W, Z, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YWZX => new Vector4(Y, W, Z, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, A, B, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GABR => new Vector4(G, A, B, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, W, Z, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YWZY => new Vector4(Y, W, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, A, B, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GABG => new Vector4(G, A, B, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, W, Z, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YWZZ => new Vector4(Y, W, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, A, B, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GABB => new Vector4(G, A, B, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, W, Z, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YWZW => new Vector4(Y, W, Z, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, A, B, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GABA => new Vector4(G, A, B, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, W, W, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YWWX => new Vector4(Y, W, W, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, A, A, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GAAR => new Vector4(G, A, A, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, W, W, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YWWY => new Vector4(Y, W, W, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, A, A, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GAAG => new Vector4(G, A, A, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, W, W, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YWWZ => new Vector4(Y, W, W, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, A, A, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GAAB => new Vector4(G, A, A, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Y, W, W, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YWWW => new Vector4(Y, W, W, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of G, A, A, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GAAA => new Vector4(G, A, A, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, X, X, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZXXX => new Vector4(Z, X, X, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, R, R, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BRRR => new Vector4(B, R, R, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, X, X, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZXXY => new Vector4(Z, X, X, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, R, R, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BRRG => new Vector4(B, R, R, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, X, X, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZXXZ => new Vector4(Z, X, X, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, R, R, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BRRB => new Vector4(B, R, R, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, X, X, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZXXW => new Vector4(Z, X, X, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, R, R, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BRRA => new Vector4(B, R, R, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, X, Y, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZXYX => new Vector4(Z, X, Y, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, R, G, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BRGR => new Vector4(B, R, G, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, X, Y, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZXYY => new Vector4(Z, X, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, R, G, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BRGG => new Vector4(B, R, G, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, X, Y, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZXYZ => new Vector4(Z, X, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, R, G, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BRGB => new Vector4(B, R, G, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, X, Y, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZXYW => new Vector4(Z, X, Y, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, R, G, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BRGA => new Vector4(B, R, G, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, X, Z, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZXZX => new Vector4(Z, X, Z, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, R, B, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BRBR => new Vector4(B, R, B, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, X, Z, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZXZY => new Vector4(Z, X, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, R, B, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BRBG => new Vector4(B, R, B, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, X, Z, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZXZZ => new Vector4(Z, X, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, R, B, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BRBB => new Vector4(B, R, B, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, X, Z, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZXZW => new Vector4(Z, X, Z, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, R, B, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BRBA => new Vector4(B, R, B, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, X, W, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZXWX => new Vector4(Z, X, W, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, R, A, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BRAR => new Vector4(B, R, A, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, X, W, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZXWY => new Vector4(Z, X, W, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, R, A, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BRAG => new Vector4(B, R, A, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, X, W, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZXWZ => new Vector4(Z, X, W, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, R, A, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BRAB => new Vector4(B, R, A, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, X, W, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZXWW => new Vector4(Z, X, W, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, R, A, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BRAA => new Vector4(B, R, A, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, Y, X, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZYXX => new Vector4(Z, Y, X, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, G, R, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BGRR => new Vector4(B, G, R, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, Y, X, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZYXY => new Vector4(Z, Y, X, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, G, R, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BGRG => new Vector4(B, G, R, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, Y, X, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZYXZ => new Vector4(Z, Y, X, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, G, R, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BGRB => new Vector4(B, G, R, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, Y, X, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZYXW => new Vector4(Z, Y, X, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, G, R, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BGRA => new Vector4(B, G, R, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, Y, Y, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZYYX => new Vector4(Z, Y, Y, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, G, G, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BGGR => new Vector4(B, G, G, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, Y, Y, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZYYY => new Vector4(Z, Y, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, G, G, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BGGG => new Vector4(B, G, G, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, Y, Y, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZYYZ => new Vector4(Z, Y, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, G, G, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BGGB => new Vector4(B, G, G, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, Y, Y, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZYYW => new Vector4(Z, Y, Y, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, G, G, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BGGA => new Vector4(B, G, G, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, Y, Z, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZYZX => new Vector4(Z, Y, Z, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, G, B, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BGBR => new Vector4(B, G, B, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, Y, Z, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZYZY => new Vector4(Z, Y, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, G, B, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BGBG => new Vector4(B, G, B, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, Y, Z, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZYZZ => new Vector4(Z, Y, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, G, B, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BGBB => new Vector4(B, G, B, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, Y, Z, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZYZW => new Vector4(Z, Y, Z, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, G, B, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BGBA => new Vector4(B, G, B, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, Y, W, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZYWX => new Vector4(Z, Y, W, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, G, A, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BGAR => new Vector4(B, G, A, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, Y, W, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZYWY => new Vector4(Z, Y, W, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, G, A, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BGAG => new Vector4(B, G, A, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, Y, W, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZYWZ => new Vector4(Z, Y, W, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, G, A, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BGAB => new Vector4(B, G, A, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, Y, W, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZYWW => new Vector4(Z, Y, W, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, G, A, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BGAA => new Vector4(B, G, A, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, Z, X, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZZXX => new Vector4(Z, Z, X, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, B, R, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BBRR => new Vector4(B, B, R, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, Z, X, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZZXY => new Vector4(Z, Z, X, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, B, R, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BBRG => new Vector4(B, B, R, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, Z, X, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZZXZ => new Vector4(Z, Z, X, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, B, R, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BBRB => new Vector4(B, B, R, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, Z, X, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZZXW => new Vector4(Z, Z, X, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, B, R, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BBRA => new Vector4(B, B, R, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, Z, Y, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZZYX => new Vector4(Z, Z, Y, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, B, G, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BBGR => new Vector4(B, B, G, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, Z, Y, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZZYY => new Vector4(Z, Z, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, B, G, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BBGG => new Vector4(B, B, G, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, Z, Y, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZZYZ => new Vector4(Z, Z, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, B, G, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BBGB => new Vector4(B, B, G, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, Z, Y, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZZYW => new Vector4(Z, Z, Y, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, B, G, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BBGA => new Vector4(B, B, G, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, Z, Z, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZZZX => new Vector4(Z, Z, Z, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, B, B, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BBBR => new Vector4(B, B, B, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, Z, Z, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZZZY => new Vector4(Z, Z, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, B, B, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BBBG => new Vector4(B, B, B, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, Z, Z, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZZZZ => new Vector4(Z, Z, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, B, B, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BBBB => new Vector4(B, B, B, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, Z, Z, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZZZW => new Vector4(Z, Z, Z, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, B, B, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BBBA => new Vector4(B, B, B, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, Z, W, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZZWX => new Vector4(Z, Z, W, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, B, A, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BBAR => new Vector4(B, B, A, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, Z, W, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZZWY => new Vector4(Z, Z, W, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, B, A, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BBAG => new Vector4(B, B, A, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, Z, W, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZZWZ => new Vector4(Z, Z, W, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, B, A, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BBAB => new Vector4(B, B, A, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, Z, W, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZZWW => new Vector4(Z, Z, W, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, B, A, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BBAA => new Vector4(B, B, A, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, W, X, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZWXX => new Vector4(Z, W, X, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, A, R, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BARR => new Vector4(B, A, R, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, W, X, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZWXY => new Vector4(Z, W, X, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, A, R, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BARG => new Vector4(B, A, R, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, W, X, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZWXZ => new Vector4(Z, W, X, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, A, R, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BARB => new Vector4(B, A, R, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, W, X, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZWXW => new Vector4(Z, W, X, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, A, R, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BARA => new Vector4(B, A, R, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, W, Y, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZWYX => new Vector4(Z, W, Y, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, A, G, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BAGR => new Vector4(B, A, G, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, W, Y, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZWYY => new Vector4(Z, W, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, A, G, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BAGG => new Vector4(B, A, G, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, W, Y, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZWYZ => new Vector4(Z, W, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, A, G, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BAGB => new Vector4(B, A, G, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, W, Y, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZWYW => new Vector4(Z, W, Y, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, A, G, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BAGA => new Vector4(B, A, G, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, W, Z, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZWZX => new Vector4(Z, W, Z, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, A, B, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BABR => new Vector4(B, A, B, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, W, Z, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZWZY => new Vector4(Z, W, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, A, B, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BABG => new Vector4(B, A, B, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, W, Z, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZWZZ => new Vector4(Z, W, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, A, B, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BABB => new Vector4(B, A, B, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, W, Z, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZWZW => new Vector4(Z, W, Z, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, A, B, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BABA => new Vector4(B, A, B, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, W, W, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZWWX => new Vector4(Z, W, W, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, A, A, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BAAR => new Vector4(B, A, A, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, W, W, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZWWY => new Vector4(Z, W, W, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, A, A, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BAAG => new Vector4(B, A, A, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, W, W, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZWWZ => new Vector4(Z, W, W, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, A, A, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BAAB => new Vector4(B, A, A, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of Z, W, W, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZWWW => new Vector4(Z, W, W, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of B, A, A, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BAAA => new Vector4(B, A, A, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, X, X, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WXXX => new Vector4(W, X, X, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, R, R, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ARRR => new Vector4(A, R, R, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, X, X, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WXXY => new Vector4(W, X, X, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, R, R, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ARRG => new Vector4(A, R, R, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, X, X, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WXXZ => new Vector4(W, X, X, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, R, R, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ARRB => new Vector4(A, R, R, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, X, X, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WXXW => new Vector4(W, X, X, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, R, R, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ARRA => new Vector4(A, R, R, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, X, Y, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WXYX => new Vector4(W, X, Y, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, R, G, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ARGR => new Vector4(A, R, G, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, X, Y, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WXYY => new Vector4(W, X, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, R, G, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ARGG => new Vector4(A, R, G, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, X, Y, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WXYZ => new Vector4(W, X, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, R, G, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ARGB => new Vector4(A, R, G, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, X, Y, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WXYW => new Vector4(W, X, Y, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, R, G, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ARGA => new Vector4(A, R, G, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, X, Z, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WXZX => new Vector4(W, X, Z, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, R, B, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ARBR => new Vector4(A, R, B, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, X, Z, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WXZY => new Vector4(W, X, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, R, B, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ARBG => new Vector4(A, R, B, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, X, Z, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WXZZ => new Vector4(W, X, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, R, B, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ARBB => new Vector4(A, R, B, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, X, Z, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WXZW => new Vector4(W, X, Z, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, R, B, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ARBA => new Vector4(A, R, B, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, X, W, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WXWX => new Vector4(W, X, W, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, R, A, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ARAR => new Vector4(A, R, A, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, X, W, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WXWY => new Vector4(W, X, W, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, R, A, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ARAG => new Vector4(A, R, A, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, X, W, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WXWZ => new Vector4(W, X, W, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, R, A, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ARAB => new Vector4(A, R, A, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, X, W, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WXWW => new Vector4(W, X, W, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, R, A, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ARAA => new Vector4(A, R, A, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, Y, X, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WYXX => new Vector4(W, Y, X, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, G, R, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 AGRR => new Vector4(A, G, R, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, Y, X, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WYXY => new Vector4(W, Y, X, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, G, R, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 AGRG => new Vector4(A, G, R, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, Y, X, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WYXZ => new Vector4(W, Y, X, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, G, R, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 AGRB => new Vector4(A, G, R, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, Y, X, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WYXW => new Vector4(W, Y, X, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, G, R, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 AGRA => new Vector4(A, G, R, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, Y, Y, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WYYX => new Vector4(W, Y, Y, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, G, G, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 AGGR => new Vector4(A, G, G, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, Y, Y, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WYYY => new Vector4(W, Y, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, G, G, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 AGGG => new Vector4(A, G, G, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, Y, Y, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WYYZ => new Vector4(W, Y, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, G, G, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 AGGB => new Vector4(A, G, G, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, Y, Y, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WYYW => new Vector4(W, Y, Y, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, G, G, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 AGGA => new Vector4(A, G, G, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, Y, Z, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WYZX => new Vector4(W, Y, Z, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, G, B, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 AGBR => new Vector4(A, G, B, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, Y, Z, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WYZY => new Vector4(W, Y, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, G, B, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 AGBG => new Vector4(A, G, B, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, Y, Z, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WYZZ => new Vector4(W, Y, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, G, B, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 AGBB => new Vector4(A, G, B, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, Y, Z, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WYZW => new Vector4(W, Y, Z, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, G, B, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 AGBA => new Vector4(A, G, B, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, Y, W, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WYWX => new Vector4(W, Y, W, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, G, A, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 AGAR => new Vector4(A, G, A, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, Y, W, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WYWY => new Vector4(W, Y, W, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, G, A, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 AGAG => new Vector4(A, G, A, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, Y, W, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WYWZ => new Vector4(W, Y, W, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, G, A, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 AGAB => new Vector4(A, G, A, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, Y, W, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WYWW => new Vector4(W, Y, W, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, G, A, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 AGAA => new Vector4(A, G, A, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, Z, X, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WZXX => new Vector4(W, Z, X, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, B, R, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ABRR => new Vector4(A, B, R, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, Z, X, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WZXY => new Vector4(W, Z, X, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, B, R, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ABRG => new Vector4(A, B, R, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, Z, X, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WZXZ => new Vector4(W, Z, X, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, B, R, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ABRB => new Vector4(A, B, R, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, Z, X, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WZXW => new Vector4(W, Z, X, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, B, R, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ABRA => new Vector4(A, B, R, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, Z, Y, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WZYX => new Vector4(W, Z, Y, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, B, G, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ABGR => new Vector4(A, B, G, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, Z, Y, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WZYY => new Vector4(W, Z, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, B, G, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ABGG => new Vector4(A, B, G, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, Z, Y, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WZYZ => new Vector4(W, Z, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, B, G, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ABGB => new Vector4(A, B, G, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, Z, Y, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WZYW => new Vector4(W, Z, Y, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, B, G, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ABGA => new Vector4(A, B, G, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, Z, Z, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WZZX => new Vector4(W, Z, Z, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, B, B, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ABBR => new Vector4(A, B, B, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, Z, Z, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WZZY => new Vector4(W, Z, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, B, B, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ABBG => new Vector4(A, B, B, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, Z, Z, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WZZZ => new Vector4(W, Z, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, B, B, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ABBB => new Vector4(A, B, B, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, Z, Z, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WZZW => new Vector4(W, Z, Z, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, B, B, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ABBA => new Vector4(A, B, B, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, Z, W, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WZWX => new Vector4(W, Z, W, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, B, A, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ABAR => new Vector4(A, B, A, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, Z, W, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WZWY => new Vector4(W, Z, W, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, B, A, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ABAG => new Vector4(A, B, A, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, Z, W, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WZWZ => new Vector4(W, Z, W, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, B, A, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ABAB => new Vector4(A, B, A, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, Z, W, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WZWW => new Vector4(W, Z, W, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, B, A, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ABAA => new Vector4(A, B, A, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, W, X, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WWXX => new Vector4(W, W, X, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, A, R, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 AARR => new Vector4(A, A, R, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, W, X, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WWXY => new Vector4(W, W, X, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, A, R, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 AARG => new Vector4(A, A, R, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, W, X, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WWXZ => new Vector4(W, W, X, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, A, R, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 AARB => new Vector4(A, A, R, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, W, X, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WWXW => new Vector4(W, W, X, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, A, R, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 AARA => new Vector4(A, A, R, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, W, Y, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WWYX => new Vector4(W, W, Y, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, A, G, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 AAGR => new Vector4(A, A, G, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, W, Y, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WWYY => new Vector4(W, W, Y, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, A, G, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 AAGG => new Vector4(A, A, G, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, W, Y, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WWYZ => new Vector4(W, W, Y, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, A, G, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 AAGB => new Vector4(A, A, G, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, W, Y, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WWYW => new Vector4(W, W, Y, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, A, G, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 AAGA => new Vector4(A, A, G, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, W, Z, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WWZX => new Vector4(W, W, Z, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, A, B, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 AABR => new Vector4(A, A, B, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, W, Z, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WWZY => new Vector4(W, W, Z, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, A, B, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 AABG => new Vector4(A, A, B, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, W, Z, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WWZZ => new Vector4(W, W, Z, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, A, B, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 AABB => new Vector4(A, A, B, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, W, Z, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WWZW => new Vector4(W, W, Z, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, A, B, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 AABA => new Vector4(A, A, B, A);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, W, W, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WWWX => new Vector4(W, W, W, X);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, A, A, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 AAAR => new Vector4(A, A, A, R);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, W, W, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WWWY => new Vector4(W, W, W, Y);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, A, A, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 AAAG => new Vector4(A, A, A, G);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, W, W, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WWWZ => new Vector4(W, W, W, Z);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, A, A, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 AAAB => new Vector4(A, A, A, B);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of W, W, W, W from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 WWWW => new Vector4(W, W, W, W);

		/// <summary>
		/// Returns a new <see cref="Vector4"/> comprised of A, A, A, A from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 AAAA => new Vector4(A, A, A, A);

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

		public float A
		{
			get => W;
			set => W = value;
		}

		public static Vector4 operator +(Vector4 a, Vector4 b)
		{
			return new Vector4()
			{
				X = a.X + b.X,
				Y = a.Y + b.Y,
				Z = a.Z + b.Z,
				W = a.W + b.W,
			};
		}

		public static Vector4 operator -(Vector4 a, Vector4 b)
		{
			return new Vector4()
			{
				X = a.X - b.X,
				Y = a.Y - b.Y,
				Z = a.Z - b.Z,
				W = a.W - b.W,
			};
		}

		public static Vector4 operator *(Vector4 a, Vector4 b)
		{
			return new Vector4()
			{
				X = a.X * b.X,
				Y = a.Y * b.Y,
				Z = a.Z * b.Z,
				W = a.W * b.W,
			};
		}

		public static Vector4 operator /(Vector4 a, Vector4 b)
		{
			return new Vector4()
			{
				X = a.X / b.X,
				Y = a.Y / b.Y,
				Z = a.Z / b.Z,
				W = a.W / b.W,
			};
		}

	}
}
