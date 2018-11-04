

using System.Runtime.InteropServices;

namespace SharpShader
{
	[StructLayout(LayoutKind.Sequential)]
	public struct Vector2
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
        /// Creates a new instance of <see cref="Vector2"/>.
        /// </summary>
		public Vector2(float x, float y)
		{
			X = x;
			Y = y;
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

		public static Vector2 operator +(Vector2 a, Vector2 b)
		{
			return new Vector2()
			{
				X = a.X + b.X,
				Y = a.Y + b.Y,
			};
		}

		public static Vector2 operator -(Vector2 a, Vector2 b)
		{
			return new Vector2()
			{
				X = a.X - b.X,
				Y = a.Y - b.Y,
			};
		}

		public static Vector2 operator *(Vector2 a, Vector2 b)
		{
			return new Vector2()
			{
				X = a.X * b.X,
				Y = a.Y * b.Y,
			};
		}

		public static Vector2 operator /(Vector2 a, Vector2 b)
		{
			return new Vector2()
			{
				X = a.X / b.X,
				Y = a.Y / b.Y,
			};
		}

	}
}
