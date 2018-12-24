using System.Runtime.InteropServices;

namespace SharpShader
{
	[StructLayout(LayoutKind.Sequential)]
	public struct UInt3 : IVector<uint>
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
        /// The Z component.
        /// </summary>
		public uint Z;

        /// <summary>
        /// Creates a new instance of <see cref="UInt3"/>.
        /// </summary>
		public UInt3(uint x, uint y, uint z)
		{
			X = x;
			Y = y;
			Z = z;
		}

        /// <summary>
        /// Creates a new instance of <see cref="UInt3"/>.
        /// </summary>
		public UInt3(UInt2 p, uint z)
		{
			X = p.X;
			Y = p.Y;
			Z = z;
		}

        /// <summary>
        /// Creates a new instance of <see cref="UInt3"/>.
        /// </summary>
		public UInt3(uint x, UInt2 p)
		{
			X = x;
			Y = p.X;
			Z = p.Y;
		}

		/// <summary>
		/// Gets a new <see cref="UInt2"/> comprised of X, X from the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 XX => new UInt2(X, X);

		/// <summary>
		/// Gets a new <see cref="UInt2"/> comprised of R, R from the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 RR => new UInt2(R, R);

		/// <summary>
		/// Gets or sets a <see cref="UInt2"/> comprised of X, Y on the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 XY
		{
			get => new UInt2(X, Y); 	
			set
			{
				X = value.X;
				Y = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt2"/> comprised of R, G on the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 RG
		{
			get => new UInt2(R, G);	
			set
			{
				R = value.R;
				G = value.G;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt2"/> comprised of X, Z on the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 XZ
		{
			get => new UInt2(X, Z); 	
			set
			{
				X = value.X;
				Z = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt2"/> comprised of R, B on the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 RB
		{
			get => new UInt2(R, B);	
			set
			{
				R = value.R;
				B = value.G;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt2"/> comprised of Y, X on the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 YX
		{
			get => new UInt2(Y, X); 	
			set
			{
				Y = value.X;
				X = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt2"/> comprised of G, R on the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 GR
		{
			get => new UInt2(G, R);	
			set
			{
				G = value.R;
				R = value.G;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt2"/> comprised of Y, Y from the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 YY => new UInt2(Y, Y);

		/// <summary>
		/// Gets a new <see cref="UInt2"/> comprised of G, G from the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 GG => new UInt2(G, G);

		/// <summary>
		/// Gets or sets a <see cref="UInt2"/> comprised of Y, Z on the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 YZ
		{
			get => new UInt2(Y, Z); 	
			set
			{
				Y = value.X;
				Z = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt2"/> comprised of G, B on the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 GB
		{
			get => new UInt2(G, B);	
			set
			{
				G = value.R;
				B = value.G;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt2"/> comprised of Z, X on the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 ZX
		{
			get => new UInt2(Z, X); 	
			set
			{
				Z = value.X;
				X = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt2"/> comprised of B, R on the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 BR
		{
			get => new UInt2(B, R);	
			set
			{
				B = value.R;
				R = value.G;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt2"/> comprised of Z, Y on the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 ZY
		{
			get => new UInt2(Z, Y); 	
			set
			{
				Z = value.X;
				Y = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt2"/> comprised of B, G on the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 BG
		{
			get => new UInt2(B, G);	
			set
			{
				B = value.R;
				G = value.G;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt2"/> comprised of Z, Z from the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 ZZ => new UInt2(Z, Z);

		/// <summary>
		/// Gets a new <see cref="UInt2"/> comprised of B, B from the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 BB => new UInt2(B, B);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of X, X, X from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 XXX => new UInt3(X, X, X);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of R, R, R from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 RRR => new UInt3(R, R, R);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of X, X, Y from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 XXY => new UInt3(X, X, Y);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of R, R, G from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 RRG => new UInt3(R, R, G);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of X, X, Z from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 XXZ => new UInt3(X, X, Z);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of R, R, B from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 RRB => new UInt3(R, R, B);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of X, Y, X from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 XYX => new UInt3(X, Y, X);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of R, G, R from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 RGR => new UInt3(R, G, R);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of X, Y, Y from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 XYY => new UInt3(X, Y, Y);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of R, G, G from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 RGG => new UInt3(R, G, G);

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of X, Y, Z on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 XYZ
		{
			get => new UInt3(X, Y, Z); 	
			set
			{
				X = value.X;
				Y = value.Y;
				Z = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of R, G, B on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 RGB
		{
			get => new UInt3(R, G, B);	
			set
			{
				R = value.R;
				G = value.G;
				B = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of X, Z, X from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 XZX => new UInt3(X, Z, X);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of R, B, R from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 RBR => new UInt3(R, B, R);

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of X, Z, Y on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 XZY
		{
			get => new UInt3(X, Z, Y); 	
			set
			{
				X = value.X;
				Z = value.Y;
				Y = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of R, B, G on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 RBG
		{
			get => new UInt3(R, B, G);	
			set
			{
				R = value.R;
				B = value.G;
				G = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of X, Z, Z from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 XZZ => new UInt3(X, Z, Z);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of R, B, B from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 RBB => new UInt3(R, B, B);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of Y, X, X from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 YXX => new UInt3(Y, X, X);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of G, R, R from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 GRR => new UInt3(G, R, R);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of Y, X, Y from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 YXY => new UInt3(Y, X, Y);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of G, R, G from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 GRG => new UInt3(G, R, G);

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of Y, X, Z on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 YXZ
		{
			get => new UInt3(Y, X, Z); 	
			set
			{
				Y = value.X;
				X = value.Y;
				Z = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of G, R, B on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 GRB
		{
			get => new UInt3(G, R, B);	
			set
			{
				G = value.R;
				R = value.G;
				B = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of Y, Y, X from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 YYX => new UInt3(Y, Y, X);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of G, G, R from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 GGR => new UInt3(G, G, R);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of Y, Y, Y from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 YYY => new UInt3(Y, Y, Y);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of G, G, G from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 GGG => new UInt3(G, G, G);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of Y, Y, Z from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 YYZ => new UInt3(Y, Y, Z);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of G, G, B from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 GGB => new UInt3(G, G, B);

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of Y, Z, X on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 YZX
		{
			get => new UInt3(Y, Z, X); 	
			set
			{
				Y = value.X;
				Z = value.Y;
				X = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of G, B, R on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 GBR
		{
			get => new UInt3(G, B, R);	
			set
			{
				G = value.R;
				B = value.G;
				R = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of Y, Z, Y from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 YZY => new UInt3(Y, Z, Y);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of G, B, G from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 GBG => new UInt3(G, B, G);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of Y, Z, Z from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 YZZ => new UInt3(Y, Z, Z);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of G, B, B from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 GBB => new UInt3(G, B, B);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of Z, X, X from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 ZXX => new UInt3(Z, X, X);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of B, R, R from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 BRR => new UInt3(B, R, R);

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of Z, X, Y on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 ZXY
		{
			get => new UInt3(Z, X, Y); 	
			set
			{
				Z = value.X;
				X = value.Y;
				Y = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of B, R, G on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 BRG
		{
			get => new UInt3(B, R, G);	
			set
			{
				B = value.R;
				R = value.G;
				G = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of Z, X, Z from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 ZXZ => new UInt3(Z, X, Z);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of B, R, B from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 BRB => new UInt3(B, R, B);

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of Z, Y, X on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 ZYX
		{
			get => new UInt3(Z, Y, X); 	
			set
			{
				Z = value.X;
				Y = value.Y;
				X = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of B, G, R on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 BGR
		{
			get => new UInt3(B, G, R);	
			set
			{
				B = value.R;
				G = value.G;
				R = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of Z, Y, Y from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 ZYY => new UInt3(Z, Y, Y);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of B, G, G from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 BGG => new UInt3(B, G, G);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of Z, Y, Z from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 ZYZ => new UInt3(Z, Y, Z);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of B, G, B from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 BGB => new UInt3(B, G, B);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of Z, Z, X from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 ZZX => new UInt3(Z, Z, X);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of B, B, R from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 BBR => new UInt3(B, B, R);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of Z, Z, Y from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 ZZY => new UInt3(Z, Z, Y);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of B, B, G from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 BBG => new UInt3(B, B, G);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of Z, Z, Z from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 ZZZ => new UInt3(Z, Z, Z);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of B, B, B from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 BBB => new UInt3(B, B, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, X, X, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XXXX => new UInt4(X, X, X, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, R, R, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RRRR => new UInt4(R, R, R, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, X, X, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XXXY => new UInt4(X, X, X, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, R, R, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RRRG => new UInt4(R, R, R, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, X, X, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XXXZ => new UInt4(X, X, X, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, R, R, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RRRB => new UInt4(R, R, R, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, X, Y, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XXYX => new UInt4(X, X, Y, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, R, G, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RRGR => new UInt4(R, R, G, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, X, Y, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XXYY => new UInt4(X, X, Y, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, R, G, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RRGG => new UInt4(R, R, G, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, X, Y, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XXYZ => new UInt4(X, X, Y, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, R, G, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RRGB => new UInt4(R, R, G, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, X, Z, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XXZX => new UInt4(X, X, Z, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, R, B, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RRBR => new UInt4(R, R, B, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, X, Z, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XXZY => new UInt4(X, X, Z, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, R, B, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RRBG => new UInt4(R, R, B, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, X, Z, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XXZZ => new UInt4(X, X, Z, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, R, B, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RRBB => new UInt4(R, R, B, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, Y, X, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XYXX => new UInt4(X, Y, X, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, G, R, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RGRR => new UInt4(R, G, R, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, Y, X, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XYXY => new UInt4(X, Y, X, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, G, R, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RGRG => new UInt4(R, G, R, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, Y, X, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XYXZ => new UInt4(X, Y, X, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, G, R, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RGRB => new UInt4(R, G, R, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, Y, Y, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XYYX => new UInt4(X, Y, Y, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, G, G, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RGGR => new UInt4(R, G, G, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, Y, Y, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XYYY => new UInt4(X, Y, Y, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, G, G, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RGGG => new UInt4(R, G, G, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, Y, Y, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XYYZ => new UInt4(X, Y, Y, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, G, G, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RGGB => new UInt4(R, G, G, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, Y, Z, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XYZX => new UInt4(X, Y, Z, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, G, B, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RGBR => new UInt4(R, G, B, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, Y, Z, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XYZY => new UInt4(X, Y, Z, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, G, B, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RGBG => new UInt4(R, G, B, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, Y, Z, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XYZZ => new UInt4(X, Y, Z, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, G, B, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RGBB => new UInt4(R, G, B, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, Z, X, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XZXX => new UInt4(X, Z, X, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, B, R, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RBRR => new UInt4(R, B, R, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, Z, X, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XZXY => new UInt4(X, Z, X, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, B, R, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RBRG => new UInt4(R, B, R, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, Z, X, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XZXZ => new UInt4(X, Z, X, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, B, R, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RBRB => new UInt4(R, B, R, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, Z, Y, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XZYX => new UInt4(X, Z, Y, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, B, G, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RBGR => new UInt4(R, B, G, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, Z, Y, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XZYY => new UInt4(X, Z, Y, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, B, G, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RBGG => new UInt4(R, B, G, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, Z, Y, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XZYZ => new UInt4(X, Z, Y, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, B, G, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RBGB => new UInt4(R, B, G, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, Z, Z, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XZZX => new UInt4(X, Z, Z, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, B, B, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RBBR => new UInt4(R, B, B, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, Z, Z, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XZZY => new UInt4(X, Z, Z, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, B, B, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RBBG => new UInt4(R, B, B, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, Z, Z, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XZZZ => new UInt4(X, Z, Z, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, B, B, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RBBB => new UInt4(R, B, B, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, X, X, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YXXX => new UInt4(Y, X, X, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, R, R, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GRRR => new UInt4(G, R, R, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, X, X, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YXXY => new UInt4(Y, X, X, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, R, R, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GRRG => new UInt4(G, R, R, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, X, X, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YXXZ => new UInt4(Y, X, X, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, R, R, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GRRB => new UInt4(G, R, R, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, X, Y, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YXYX => new UInt4(Y, X, Y, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, R, G, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GRGR => new UInt4(G, R, G, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, X, Y, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YXYY => new UInt4(Y, X, Y, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, R, G, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GRGG => new UInt4(G, R, G, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, X, Y, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YXYZ => new UInt4(Y, X, Y, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, R, G, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GRGB => new UInt4(G, R, G, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, X, Z, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YXZX => new UInt4(Y, X, Z, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, R, B, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GRBR => new UInt4(G, R, B, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, X, Z, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YXZY => new UInt4(Y, X, Z, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, R, B, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GRBG => new UInt4(G, R, B, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, X, Z, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YXZZ => new UInt4(Y, X, Z, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, R, B, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GRBB => new UInt4(G, R, B, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, Y, X, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YYXX => new UInt4(Y, Y, X, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, G, R, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GGRR => new UInt4(G, G, R, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, Y, X, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YYXY => new UInt4(Y, Y, X, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, G, R, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GGRG => new UInt4(G, G, R, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, Y, X, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YYXZ => new UInt4(Y, Y, X, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, G, R, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GGRB => new UInt4(G, G, R, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, Y, Y, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YYYX => new UInt4(Y, Y, Y, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, G, G, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GGGR => new UInt4(G, G, G, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, Y, Y, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YYYY => new UInt4(Y, Y, Y, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, G, G, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GGGG => new UInt4(G, G, G, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, Y, Y, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YYYZ => new UInt4(Y, Y, Y, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, G, G, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GGGB => new UInt4(G, G, G, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, Y, Z, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YYZX => new UInt4(Y, Y, Z, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, G, B, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GGBR => new UInt4(G, G, B, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, Y, Z, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YYZY => new UInt4(Y, Y, Z, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, G, B, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GGBG => new UInt4(G, G, B, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, Y, Z, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YYZZ => new UInt4(Y, Y, Z, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, G, B, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GGBB => new UInt4(G, G, B, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, Z, X, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YZXX => new UInt4(Y, Z, X, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, B, R, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GBRR => new UInt4(G, B, R, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, Z, X, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YZXY => new UInt4(Y, Z, X, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, B, R, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GBRG => new UInt4(G, B, R, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, Z, X, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YZXZ => new UInt4(Y, Z, X, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, B, R, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GBRB => new UInt4(G, B, R, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, Z, Y, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YZYX => new UInt4(Y, Z, Y, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, B, G, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GBGR => new UInt4(G, B, G, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, Z, Y, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YZYY => new UInt4(Y, Z, Y, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, B, G, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GBGG => new UInt4(G, B, G, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, Z, Y, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YZYZ => new UInt4(Y, Z, Y, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, B, G, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GBGB => new UInt4(G, B, G, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, Z, Z, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YZZX => new UInt4(Y, Z, Z, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, B, B, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GBBR => new UInt4(G, B, B, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, Z, Z, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YZZY => new UInt4(Y, Z, Z, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, B, B, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GBBG => new UInt4(G, B, B, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, Z, Z, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YZZZ => new UInt4(Y, Z, Z, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, B, B, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GBBB => new UInt4(G, B, B, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, X, X, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZXXX => new UInt4(Z, X, X, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, R, R, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BRRR => new UInt4(B, R, R, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, X, X, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZXXY => new UInt4(Z, X, X, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, R, R, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BRRG => new UInt4(B, R, R, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, X, X, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZXXZ => new UInt4(Z, X, X, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, R, R, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BRRB => new UInt4(B, R, R, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, X, Y, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZXYX => new UInt4(Z, X, Y, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, R, G, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BRGR => new UInt4(B, R, G, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, X, Y, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZXYY => new UInt4(Z, X, Y, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, R, G, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BRGG => new UInt4(B, R, G, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, X, Y, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZXYZ => new UInt4(Z, X, Y, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, R, G, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BRGB => new UInt4(B, R, G, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, X, Z, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZXZX => new UInt4(Z, X, Z, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, R, B, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BRBR => new UInt4(B, R, B, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, X, Z, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZXZY => new UInt4(Z, X, Z, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, R, B, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BRBG => new UInt4(B, R, B, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, X, Z, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZXZZ => new UInt4(Z, X, Z, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, R, B, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BRBB => new UInt4(B, R, B, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, Y, X, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZYXX => new UInt4(Z, Y, X, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, G, R, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BGRR => new UInt4(B, G, R, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, Y, X, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZYXY => new UInt4(Z, Y, X, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, G, R, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BGRG => new UInt4(B, G, R, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, Y, X, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZYXZ => new UInt4(Z, Y, X, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, G, R, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BGRB => new UInt4(B, G, R, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, Y, Y, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZYYX => new UInt4(Z, Y, Y, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, G, G, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BGGR => new UInt4(B, G, G, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, Y, Y, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZYYY => new UInt4(Z, Y, Y, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, G, G, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BGGG => new UInt4(B, G, G, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, Y, Y, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZYYZ => new UInt4(Z, Y, Y, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, G, G, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BGGB => new UInt4(B, G, G, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, Y, Z, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZYZX => new UInt4(Z, Y, Z, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, G, B, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BGBR => new UInt4(B, G, B, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, Y, Z, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZYZY => new UInt4(Z, Y, Z, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, G, B, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BGBG => new UInt4(B, G, B, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, Y, Z, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZYZZ => new UInt4(Z, Y, Z, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, G, B, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BGBB => new UInt4(B, G, B, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, Z, X, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZZXX => new UInt4(Z, Z, X, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, B, R, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BBRR => new UInt4(B, B, R, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, Z, X, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZZXY => new UInt4(Z, Z, X, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, B, R, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BBRG => new UInt4(B, B, R, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, Z, X, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZZXZ => new UInt4(Z, Z, X, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, B, R, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BBRB => new UInt4(B, B, R, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, Z, Y, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZZYX => new UInt4(Z, Z, Y, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, B, G, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BBGR => new UInt4(B, B, G, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, Z, Y, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZZYY => new UInt4(Z, Z, Y, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, B, G, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BBGG => new UInt4(B, B, G, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, Z, Y, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZZYZ => new UInt4(Z, Z, Y, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, B, G, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BBGB => new UInt4(B, B, G, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, Z, Z, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZZZX => new UInt4(Z, Z, Z, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, B, B, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BBBR => new UInt4(B, B, B, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, Z, Z, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZZZY => new UInt4(Z, Z, Z, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, B, B, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BBBG => new UInt4(B, B, B, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, Z, Z, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZZZZ => new UInt4(Z, Z, Z, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, B, B, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BBBB => new UInt4(B, B, B, B);

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

		public uint B
		{
			get => Z;
			set => Z = value;
		}

		public static UInt3 operator +(UInt3 a, UInt3 b)
		{
			return new UInt3()
			{
				X = a.X + b.X,
				Y = a.Y + b.Y,
				Z = a.Z + b.Z,
			};
		}
		public static UInt3 operator +(UInt3 a, int b)
		{
			return new UInt3()
			{
				X = (uint)(a.X + b),
				Y = (uint)(a.Y + b),
				Z = (uint)(a.Z + b),
			};
		}

		public static UInt3 operator +(int a, UInt3 b)
		{
			return new UInt3()
			{
				X = (uint)(a + b.X),
				Y = (uint)(a + b.Y),
				Z = (uint)(a + b.Z),
			};
		}
		public static UInt3 operator +(UInt3 a, float b)
		{
			return new UInt3()
			{
				X = (uint)(a.X + b),
				Y = (uint)(a.Y + b),
				Z = (uint)(a.Z + b),
			};
		}

		public static UInt3 operator +(float a, UInt3 b)
		{
			return new UInt3()
			{
				X = (uint)(a + b.X),
				Y = (uint)(a + b.Y),
				Z = (uint)(a + b.Z),
			};
		}
		public static UInt3 operator +(UInt3 a, double b)
		{
			return new UInt3()
			{
				X = (uint)(a.X + b),
				Y = (uint)(a.Y + b),
				Z = (uint)(a.Z + b),
			};
		}

		public static UInt3 operator +(double a, UInt3 b)
		{
			return new UInt3()
			{
				X = (uint)(a + b.X),
				Y = (uint)(a + b.Y),
				Z = (uint)(a + b.Z),
			};
		}
		public static UInt3 operator -(UInt3 a, UInt3 b)
		{
			return new UInt3()
			{
				X = a.X - b.X,
				Y = a.Y - b.Y,
				Z = a.Z - b.Z,
			};
		}
		public static UInt3 operator -(UInt3 a, int b)
		{
			return new UInt3()
			{
				X = (uint)(a.X - b),
				Y = (uint)(a.Y - b),
				Z = (uint)(a.Z - b),
			};
		}

		public static UInt3 operator -(int a, UInt3 b)
		{
			return new UInt3()
			{
				X = (uint)(a - b.X),
				Y = (uint)(a - b.Y),
				Z = (uint)(a - b.Z),
			};
		}
		public static UInt3 operator -(UInt3 a, float b)
		{
			return new UInt3()
			{
				X = (uint)(a.X - b),
				Y = (uint)(a.Y - b),
				Z = (uint)(a.Z - b),
			};
		}

		public static UInt3 operator -(float a, UInt3 b)
		{
			return new UInt3()
			{
				X = (uint)(a - b.X),
				Y = (uint)(a - b.Y),
				Z = (uint)(a - b.Z),
			};
		}
		public static UInt3 operator -(UInt3 a, double b)
		{
			return new UInt3()
			{
				X = (uint)(a.X - b),
				Y = (uint)(a.Y - b),
				Z = (uint)(a.Z - b),
			};
		}

		public static UInt3 operator -(double a, UInt3 b)
		{
			return new UInt3()
			{
				X = (uint)(a - b.X),
				Y = (uint)(a - b.Y),
				Z = (uint)(a - b.Z),
			};
		}
		public static UInt3 operator *(UInt3 a, UInt3 b)
		{
			return new UInt3()
			{
				X = a.X * b.X,
				Y = a.Y * b.Y,
				Z = a.Z * b.Z,
			};
		}
		public static UInt3 operator *(UInt3 a, int b)
		{
			return new UInt3()
			{
				X = (uint)(a.X * b),
				Y = (uint)(a.Y * b),
				Z = (uint)(a.Z * b),
			};
		}

		public static UInt3 operator *(int a, UInt3 b)
		{
			return new UInt3()
			{
				X = (uint)(a * b.X),
				Y = (uint)(a * b.Y),
				Z = (uint)(a * b.Z),
			};
		}
		public static UInt3 operator *(UInt3 a, float b)
		{
			return new UInt3()
			{
				X = (uint)(a.X * b),
				Y = (uint)(a.Y * b),
				Z = (uint)(a.Z * b),
			};
		}

		public static UInt3 operator *(float a, UInt3 b)
		{
			return new UInt3()
			{
				X = (uint)(a * b.X),
				Y = (uint)(a * b.Y),
				Z = (uint)(a * b.Z),
			};
		}
		public static UInt3 operator *(UInt3 a, double b)
		{
			return new UInt3()
			{
				X = (uint)(a.X * b),
				Y = (uint)(a.Y * b),
				Z = (uint)(a.Z * b),
			};
		}

		public static UInt3 operator *(double a, UInt3 b)
		{
			return new UInt3()
			{
				X = (uint)(a * b.X),
				Y = (uint)(a * b.Y),
				Z = (uint)(a * b.Z),
			};
		}
		public static UInt3 operator /(UInt3 a, UInt3 b)
		{
			return new UInt3()
			{
				X = a.X / b.X,
				Y = a.Y / b.Y,
				Z = a.Z / b.Z,
			};
		}
		public static UInt3 operator /(UInt3 a, int b)
		{
			return new UInt3()
			{
				X = (uint)(a.X / b),
				Y = (uint)(a.Y / b),
				Z = (uint)(a.Z / b),
			};
		}

		public static UInt3 operator /(int a, UInt3 b)
		{
			return new UInt3()
			{
				X = (uint)(a / b.X),
				Y = (uint)(a / b.Y),
				Z = (uint)(a / b.Z),
			};
		}
		public static UInt3 operator /(UInt3 a, float b)
		{
			return new UInt3()
			{
				X = (uint)(a.X / b),
				Y = (uint)(a.Y / b),
				Z = (uint)(a.Z / b),
			};
		}

		public static UInt3 operator /(float a, UInt3 b)
		{
			return new UInt3()
			{
				X = (uint)(a / b.X),
				Y = (uint)(a / b.Y),
				Z = (uint)(a / b.Z),
			};
		}
		public static UInt3 operator /(UInt3 a, double b)
		{
			return new UInt3()
			{
				X = (uint)(a.X / b),
				Y = (uint)(a.Y / b),
				Z = (uint)(a.Z / b),
			};
		}

		public static UInt3 operator /(double a, UInt3 b)
		{
			return new UInt3()
			{
				X = (uint)(a / b.X),
				Y = (uint)(a / b.Y),
				Z = (uint)(a / b.Z),
			};
		}
	}
}
