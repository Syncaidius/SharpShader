using System.Runtime.InteropServices;

namespace SharpShader
{
	[StructLayout(LayoutKind.Sequential)]
	public struct Bool2
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

		public Bool2 XX => new Bool2(X,X);

		public Bool2 XY => new Bool2(X,Y);

		public Bool2 YX => new Bool2(Y,X);

		public Bool2 YY => new Bool2(Y,Y);

		public Bool3 XXX => new Bool3(X,X,X);

		public Bool3 XXY => new Bool3(X,X,Y);

		public Bool3 XYX => new Bool3(X,Y,X);

		public Bool3 XYY => new Bool3(X,Y,Y);

		public Bool3 YXX => new Bool3(Y,X,X);

		public Bool3 YXY => new Bool3(Y,X,Y);

		public Bool3 YYX => new Bool3(Y,Y,X);

		public Bool3 YYY => new Bool3(Y,Y,Y);

		public Bool4 XXXX => new Bool4(X,X,X,X);

		public Bool4 XXXY => new Bool4(X,X,X,Y);

		public Bool4 XXYX => new Bool4(X,X,Y,X);

		public Bool4 XXYY => new Bool4(X,X,Y,Y);

		public Bool4 XYXX => new Bool4(X,Y,X,X);

		public Bool4 XYXY => new Bool4(X,Y,X,Y);

		public Bool4 XYYX => new Bool4(X,Y,Y,X);

		public Bool4 XYYY => new Bool4(X,Y,Y,Y);

		public Bool4 YXXX => new Bool4(Y,X,X,X);

		public Bool4 YXXY => new Bool4(Y,X,X,Y);

		public Bool4 YXYX => new Bool4(Y,X,Y,X);

		public Bool4 YXYY => new Bool4(Y,X,Y,Y);

		public Bool4 YYXX => new Bool4(Y,Y,X,X);

		public Bool4 YYXY => new Bool4(Y,Y,X,Y);

		public Bool4 YYYX => new Bool4(Y,Y,Y,X);

		public Bool4 YYYY => new Bool4(Y,Y,Y,Y);

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

		public Bool2 RR => new Bool2(X,X);

		public Bool2 RG => new Bool2(X,Y);

		public Bool2 GR => new Bool2(Y,X);

		public Bool2 GG => new Bool2(Y,Y);

		public Bool3 RRR => new Bool3(X,X,X);

		public Bool3 RRG => new Bool3(X,X,Y);

		public Bool3 RGR => new Bool3(X,Y,X);

		public Bool3 RGG => new Bool3(X,Y,Y);

		public Bool3 GRR => new Bool3(Y,X,X);

		public Bool3 GRG => new Bool3(Y,X,Y);

		public Bool3 GGR => new Bool3(Y,Y,X);

		public Bool3 GGG => new Bool3(Y,Y,Y);

		public Bool4 RRRR => new Bool4(X,X,X,X);

		public Bool4 RRRG => new Bool4(X,X,X,Y);

		public Bool4 RRGR => new Bool4(X,X,Y,X);

		public Bool4 RRGG => new Bool4(X,X,Y,Y);

		public Bool4 RGRR => new Bool4(X,Y,X,X);

		public Bool4 RGRG => new Bool4(X,Y,X,Y);

		public Bool4 RGGR => new Bool4(X,Y,Y,X);

		public Bool4 RGGG => new Bool4(X,Y,Y,Y);

		public Bool4 GRRR => new Bool4(Y,X,X,X);

		public Bool4 GRRG => new Bool4(Y,X,X,Y);

		public Bool4 GRGR => new Bool4(Y,X,Y,X);

		public Bool4 GRGG => new Bool4(Y,X,Y,Y);

		public Bool4 GGRR => new Bool4(Y,Y,X,X);

		public Bool4 GGRG => new Bool4(Y,Y,X,Y);

		public Bool4 GGGR => new Bool4(Y,Y,Y,X);

		public Bool4 GGGG => new Bool4(Y,Y,Y,Y);

	}
}
