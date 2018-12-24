using System.Runtime.InteropServices;

namespace SharpShader
{
	[StructLayout(LayoutKind.Sequential)]
	public struct Int4 : IVector<int>, IIntrinsicValue<int>
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
        /// The Z component.
        /// </summary>
		public int Z;

        /// <summary>
        /// The W component.
        /// </summary>
		public int W;

        /// <summary>
        /// Creates a new instance of <see cref="Int4"/>.
        /// </summary>
		public Int4(int x, int y, int z, int w)
		{
			X = x;
			Y = y;
			Z = z;
			W = w;
		}

		/// <summary>
		/// Gets a new <see cref="Int2"/> comprised of X, X from the current <see cref="Int2"/>.
		/// </summary>
		public Int2 XX => new Int2(X, X);

		/// <summary>
		/// Gets a new <see cref="Int2"/> comprised of R, R from the current <see cref="Int2"/>.
		/// </summary>
		public Int2 RR => new Int2(R, R);

		/// <summary>
		/// Gets or sets a <see cref="Int2"/> comprised of X, Y on the current <see cref="Int2"/>.
		/// </summary>
		public Int2 XY
		{
			get => new Int2(X, Y); 	
			set
			{
				X = value.X;
				Y = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int2"/> comprised of R, G on the current <see cref="Int2"/>.
		/// </summary>
		public Int2 RG
		{
			get => new Int2(R, G);	
			set
			{
				R = value.R;
				G = value.G;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int2"/> comprised of X, Z on the current <see cref="Int2"/>.
		/// </summary>
		public Int2 XZ
		{
			get => new Int2(X, Z); 	
			set
			{
				X = value.X;
				Z = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int2"/> comprised of R, B on the current <see cref="Int2"/>.
		/// </summary>
		public Int2 RB
		{
			get => new Int2(R, B);	
			set
			{
				R = value.R;
				B = value.G;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int2"/> comprised of X, W on the current <see cref="Int2"/>.
		/// </summary>
		public Int2 XW
		{
			get => new Int2(X, W); 	
			set
			{
				X = value.X;
				W = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int2"/> comprised of R, A on the current <see cref="Int2"/>.
		/// </summary>
		public Int2 RA
		{
			get => new Int2(R, A);	
			set
			{
				R = value.R;
				A = value.G;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int2"/> comprised of Y, X on the current <see cref="Int2"/>.
		/// </summary>
		public Int2 YX
		{
			get => new Int2(Y, X); 	
			set
			{
				Y = value.X;
				X = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int2"/> comprised of G, R on the current <see cref="Int2"/>.
		/// </summary>
		public Int2 GR
		{
			get => new Int2(G, R);	
			set
			{
				G = value.R;
				R = value.G;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int2"/> comprised of Y, Y from the current <see cref="Int2"/>.
		/// </summary>
		public Int2 YY => new Int2(Y, Y);

		/// <summary>
		/// Gets a new <see cref="Int2"/> comprised of G, G from the current <see cref="Int2"/>.
		/// </summary>
		public Int2 GG => new Int2(G, G);

		/// <summary>
		/// Gets or sets a <see cref="Int2"/> comprised of Y, Z on the current <see cref="Int2"/>.
		/// </summary>
		public Int2 YZ
		{
			get => new Int2(Y, Z); 	
			set
			{
				Y = value.X;
				Z = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int2"/> comprised of G, B on the current <see cref="Int2"/>.
		/// </summary>
		public Int2 GB
		{
			get => new Int2(G, B);	
			set
			{
				G = value.R;
				B = value.G;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int2"/> comprised of Y, W on the current <see cref="Int2"/>.
		/// </summary>
		public Int2 YW
		{
			get => new Int2(Y, W); 	
			set
			{
				Y = value.X;
				W = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int2"/> comprised of G, A on the current <see cref="Int2"/>.
		/// </summary>
		public Int2 GA
		{
			get => new Int2(G, A);	
			set
			{
				G = value.R;
				A = value.G;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int2"/> comprised of Z, X on the current <see cref="Int2"/>.
		/// </summary>
		public Int2 ZX
		{
			get => new Int2(Z, X); 	
			set
			{
				Z = value.X;
				X = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int2"/> comprised of B, R on the current <see cref="Int2"/>.
		/// </summary>
		public Int2 BR
		{
			get => new Int2(B, R);	
			set
			{
				B = value.R;
				R = value.G;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int2"/> comprised of Z, Y on the current <see cref="Int2"/>.
		/// </summary>
		public Int2 ZY
		{
			get => new Int2(Z, Y); 	
			set
			{
				Z = value.X;
				Y = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int2"/> comprised of B, G on the current <see cref="Int2"/>.
		/// </summary>
		public Int2 BG
		{
			get => new Int2(B, G);	
			set
			{
				B = value.R;
				G = value.G;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int2"/> comprised of Z, Z from the current <see cref="Int2"/>.
		/// </summary>
		public Int2 ZZ => new Int2(Z, Z);

		/// <summary>
		/// Gets a new <see cref="Int2"/> comprised of B, B from the current <see cref="Int2"/>.
		/// </summary>
		public Int2 BB => new Int2(B, B);

		/// <summary>
		/// Gets or sets a <see cref="Int2"/> comprised of Z, W on the current <see cref="Int2"/>.
		/// </summary>
		public Int2 ZW
		{
			get => new Int2(Z, W); 	
			set
			{
				Z = value.X;
				W = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int2"/> comprised of B, A on the current <see cref="Int2"/>.
		/// </summary>
		public Int2 BA
		{
			get => new Int2(B, A);	
			set
			{
				B = value.R;
				A = value.G;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int2"/> comprised of W, X on the current <see cref="Int2"/>.
		/// </summary>
		public Int2 WX
		{
			get => new Int2(W, X); 	
			set
			{
				W = value.X;
				X = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int2"/> comprised of A, R on the current <see cref="Int2"/>.
		/// </summary>
		public Int2 AR
		{
			get => new Int2(A, R);	
			set
			{
				A = value.R;
				R = value.G;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int2"/> comprised of W, Y on the current <see cref="Int2"/>.
		/// </summary>
		public Int2 WY
		{
			get => new Int2(W, Y); 	
			set
			{
				W = value.X;
				Y = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int2"/> comprised of A, G on the current <see cref="Int2"/>.
		/// </summary>
		public Int2 AG
		{
			get => new Int2(A, G);	
			set
			{
				A = value.R;
				G = value.G;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int2"/> comprised of W, Z on the current <see cref="Int2"/>.
		/// </summary>
		public Int2 WZ
		{
			get => new Int2(W, Z); 	
			set
			{
				W = value.X;
				Z = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int2"/> comprised of A, B on the current <see cref="Int2"/>.
		/// </summary>
		public Int2 AB
		{
			get => new Int2(A, B);	
			set
			{
				A = value.R;
				B = value.G;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int2"/> comprised of W, W from the current <see cref="Int2"/>.
		/// </summary>
		public Int2 WW => new Int2(W, W);

		/// <summary>
		/// Gets a new <see cref="Int2"/> comprised of A, A from the current <see cref="Int2"/>.
		/// </summary>
		public Int2 AA => new Int2(A, A);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of X, X, X from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 XXX => new Int3(X, X, X);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of R, R, R from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 RRR => new Int3(R, R, R);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of X, X, Y from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 XXY => new Int3(X, X, Y);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of R, R, G from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 RRG => new Int3(R, R, G);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of X, X, Z from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 XXZ => new Int3(X, X, Z);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of R, R, B from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 RRB => new Int3(R, R, B);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of X, X, W from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 XXW => new Int3(X, X, W);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of R, R, A from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 RRA => new Int3(R, R, A);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of X, Y, X from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 XYX => new Int3(X, Y, X);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of R, G, R from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 RGR => new Int3(R, G, R);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of X, Y, Y from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 XYY => new Int3(X, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of R, G, G from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 RGG => new Int3(R, G, G);

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of X, Y, Z on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 XYZ
		{
			get => new Int3(X, Y, Z); 	
			set
			{
				X = value.X;
				Y = value.Y;
				Z = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of R, G, B on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 RGB
		{
			get => new Int3(R, G, B);	
			set
			{
				R = value.R;
				G = value.G;
				B = value.B;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of X, Y, W on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 XYW
		{
			get => new Int3(X, Y, W); 	
			set
			{
				X = value.X;
				Y = value.Y;
				W = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of R, G, A on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 RGA
		{
			get => new Int3(R, G, A);	
			set
			{
				R = value.R;
				G = value.G;
				A = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of X, Z, X from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 XZX => new Int3(X, Z, X);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of R, B, R from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 RBR => new Int3(R, B, R);

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of X, Z, Y on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 XZY
		{
			get => new Int3(X, Z, Y); 	
			set
			{
				X = value.X;
				Z = value.Y;
				Y = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of R, B, G on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 RBG
		{
			get => new Int3(R, B, G);	
			set
			{
				R = value.R;
				B = value.G;
				G = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of X, Z, Z from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 XZZ => new Int3(X, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of R, B, B from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 RBB => new Int3(R, B, B);

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of X, Z, W on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 XZW
		{
			get => new Int3(X, Z, W); 	
			set
			{
				X = value.X;
				Z = value.Y;
				W = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of R, B, A on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 RBA
		{
			get => new Int3(R, B, A);	
			set
			{
				R = value.R;
				B = value.G;
				A = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of X, W, X from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 XWX => new Int3(X, W, X);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of R, A, R from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 RAR => new Int3(R, A, R);

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of X, W, Y on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 XWY
		{
			get => new Int3(X, W, Y); 	
			set
			{
				X = value.X;
				W = value.Y;
				Y = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of R, A, G on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 RAG
		{
			get => new Int3(R, A, G);	
			set
			{
				R = value.R;
				A = value.G;
				G = value.B;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of X, W, Z on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 XWZ
		{
			get => new Int3(X, W, Z); 	
			set
			{
				X = value.X;
				W = value.Y;
				Z = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of R, A, B on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 RAB
		{
			get => new Int3(R, A, B);	
			set
			{
				R = value.R;
				A = value.G;
				B = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of X, W, W from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 XWW => new Int3(X, W, W);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of R, A, A from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 RAA => new Int3(R, A, A);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of Y, X, X from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 YXX => new Int3(Y, X, X);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of G, R, R from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 GRR => new Int3(G, R, R);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of Y, X, Y from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 YXY => new Int3(Y, X, Y);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of G, R, G from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 GRG => new Int3(G, R, G);

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of Y, X, Z on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 YXZ
		{
			get => new Int3(Y, X, Z); 	
			set
			{
				Y = value.X;
				X = value.Y;
				Z = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of G, R, B on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 GRB
		{
			get => new Int3(G, R, B);	
			set
			{
				G = value.R;
				R = value.G;
				B = value.B;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of Y, X, W on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 YXW
		{
			get => new Int3(Y, X, W); 	
			set
			{
				Y = value.X;
				X = value.Y;
				W = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of G, R, A on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 GRA
		{
			get => new Int3(G, R, A);	
			set
			{
				G = value.R;
				R = value.G;
				A = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of Y, Y, X from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 YYX => new Int3(Y, Y, X);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of G, G, R from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 GGR => new Int3(G, G, R);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of Y, Y, Y from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 YYY => new Int3(Y, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of G, G, G from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 GGG => new Int3(G, G, G);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of Y, Y, Z from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 YYZ => new Int3(Y, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of G, G, B from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 GGB => new Int3(G, G, B);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of Y, Y, W from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 YYW => new Int3(Y, Y, W);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of G, G, A from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 GGA => new Int3(G, G, A);

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of Y, Z, X on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 YZX
		{
			get => new Int3(Y, Z, X); 	
			set
			{
				Y = value.X;
				Z = value.Y;
				X = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of G, B, R on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 GBR
		{
			get => new Int3(G, B, R);	
			set
			{
				G = value.R;
				B = value.G;
				R = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of Y, Z, Y from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 YZY => new Int3(Y, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of G, B, G from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 GBG => new Int3(G, B, G);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of Y, Z, Z from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 YZZ => new Int3(Y, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of G, B, B from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 GBB => new Int3(G, B, B);

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of Y, Z, W on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 YZW
		{
			get => new Int3(Y, Z, W); 	
			set
			{
				Y = value.X;
				Z = value.Y;
				W = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of G, B, A on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 GBA
		{
			get => new Int3(G, B, A);	
			set
			{
				G = value.R;
				B = value.G;
				A = value.B;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of Y, W, X on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 YWX
		{
			get => new Int3(Y, W, X); 	
			set
			{
				Y = value.X;
				W = value.Y;
				X = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of G, A, R on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 GAR
		{
			get => new Int3(G, A, R);	
			set
			{
				G = value.R;
				A = value.G;
				R = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of Y, W, Y from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 YWY => new Int3(Y, W, Y);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of G, A, G from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 GAG => new Int3(G, A, G);

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of Y, W, Z on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 YWZ
		{
			get => new Int3(Y, W, Z); 	
			set
			{
				Y = value.X;
				W = value.Y;
				Z = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of G, A, B on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 GAB
		{
			get => new Int3(G, A, B);	
			set
			{
				G = value.R;
				A = value.G;
				B = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of Y, W, W from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 YWW => new Int3(Y, W, W);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of G, A, A from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 GAA => new Int3(G, A, A);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of Z, X, X from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 ZXX => new Int3(Z, X, X);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of B, R, R from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 BRR => new Int3(B, R, R);

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of Z, X, Y on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 ZXY
		{
			get => new Int3(Z, X, Y); 	
			set
			{
				Z = value.X;
				X = value.Y;
				Y = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of B, R, G on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 BRG
		{
			get => new Int3(B, R, G);	
			set
			{
				B = value.R;
				R = value.G;
				G = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of Z, X, Z from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 ZXZ => new Int3(Z, X, Z);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of B, R, B from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 BRB => new Int3(B, R, B);

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of Z, X, W on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 ZXW
		{
			get => new Int3(Z, X, W); 	
			set
			{
				Z = value.X;
				X = value.Y;
				W = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of B, R, A on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 BRA
		{
			get => new Int3(B, R, A);	
			set
			{
				B = value.R;
				R = value.G;
				A = value.B;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of Z, Y, X on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 ZYX
		{
			get => new Int3(Z, Y, X); 	
			set
			{
				Z = value.X;
				Y = value.Y;
				X = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of B, G, R on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 BGR
		{
			get => new Int3(B, G, R);	
			set
			{
				B = value.R;
				G = value.G;
				R = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of Z, Y, Y from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 ZYY => new Int3(Z, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of B, G, G from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 BGG => new Int3(B, G, G);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of Z, Y, Z from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 ZYZ => new Int3(Z, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of B, G, B from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 BGB => new Int3(B, G, B);

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of Z, Y, W on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 ZYW
		{
			get => new Int3(Z, Y, W); 	
			set
			{
				Z = value.X;
				Y = value.Y;
				W = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of B, G, A on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 BGA
		{
			get => new Int3(B, G, A);	
			set
			{
				B = value.R;
				G = value.G;
				A = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of Z, Z, X from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 ZZX => new Int3(Z, Z, X);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of B, B, R from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 BBR => new Int3(B, B, R);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of Z, Z, Y from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 ZZY => new Int3(Z, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of B, B, G from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 BBG => new Int3(B, B, G);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of Z, Z, Z from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 ZZZ => new Int3(Z, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of B, B, B from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 BBB => new Int3(B, B, B);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of Z, Z, W from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 ZZW => new Int3(Z, Z, W);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of B, B, A from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 BBA => new Int3(B, B, A);

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of Z, W, X on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 ZWX
		{
			get => new Int3(Z, W, X); 	
			set
			{
				Z = value.X;
				W = value.Y;
				X = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of B, A, R on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 BAR
		{
			get => new Int3(B, A, R);	
			set
			{
				B = value.R;
				A = value.G;
				R = value.B;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of Z, W, Y on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 ZWY
		{
			get => new Int3(Z, W, Y); 	
			set
			{
				Z = value.X;
				W = value.Y;
				Y = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of B, A, G on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 BAG
		{
			get => new Int3(B, A, G);	
			set
			{
				B = value.R;
				A = value.G;
				G = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of Z, W, Z from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 ZWZ => new Int3(Z, W, Z);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of B, A, B from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 BAB => new Int3(B, A, B);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of Z, W, W from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 ZWW => new Int3(Z, W, W);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of B, A, A from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 BAA => new Int3(B, A, A);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of W, X, X from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 WXX => new Int3(W, X, X);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of A, R, R from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 ARR => new Int3(A, R, R);

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of W, X, Y on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 WXY
		{
			get => new Int3(W, X, Y); 	
			set
			{
				W = value.X;
				X = value.Y;
				Y = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of A, R, G on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 ARG
		{
			get => new Int3(A, R, G);	
			set
			{
				A = value.R;
				R = value.G;
				G = value.B;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of W, X, Z on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 WXZ
		{
			get => new Int3(W, X, Z); 	
			set
			{
				W = value.X;
				X = value.Y;
				Z = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of A, R, B on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 ARB
		{
			get => new Int3(A, R, B);	
			set
			{
				A = value.R;
				R = value.G;
				B = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of W, X, W from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 WXW => new Int3(W, X, W);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of A, R, A from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 ARA => new Int3(A, R, A);

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of W, Y, X on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 WYX
		{
			get => new Int3(W, Y, X); 	
			set
			{
				W = value.X;
				Y = value.Y;
				X = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of A, G, R on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 AGR
		{
			get => new Int3(A, G, R);	
			set
			{
				A = value.R;
				G = value.G;
				R = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of W, Y, Y from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 WYY => new Int3(W, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of A, G, G from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 AGG => new Int3(A, G, G);

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of W, Y, Z on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 WYZ
		{
			get => new Int3(W, Y, Z); 	
			set
			{
				W = value.X;
				Y = value.Y;
				Z = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of A, G, B on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 AGB
		{
			get => new Int3(A, G, B);	
			set
			{
				A = value.R;
				G = value.G;
				B = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of W, Y, W from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 WYW => new Int3(W, Y, W);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of A, G, A from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 AGA => new Int3(A, G, A);

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of W, Z, X on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 WZX
		{
			get => new Int3(W, Z, X); 	
			set
			{
				W = value.X;
				Z = value.Y;
				X = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of A, B, R on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 ABR
		{
			get => new Int3(A, B, R);	
			set
			{
				A = value.R;
				B = value.G;
				R = value.B;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of W, Z, Y on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 WZY
		{
			get => new Int3(W, Z, Y); 	
			set
			{
				W = value.X;
				Z = value.Y;
				Y = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int3"/> comprised of A, B, G on the current <see cref="Int3"/>.
		/// </summary>
		public Int3 ABG
		{
			get => new Int3(A, B, G);	
			set
			{
				A = value.R;
				B = value.G;
				G = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of W, Z, Z from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 WZZ => new Int3(W, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of A, B, B from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 ABB => new Int3(A, B, B);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of W, Z, W from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 WZW => new Int3(W, Z, W);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of A, B, A from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 ABA => new Int3(A, B, A);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of W, W, X from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 WWX => new Int3(W, W, X);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of A, A, R from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 AAR => new Int3(A, A, R);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of W, W, Y from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 WWY => new Int3(W, W, Y);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of A, A, G from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 AAG => new Int3(A, A, G);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of W, W, Z from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 WWZ => new Int3(W, W, Z);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of A, A, B from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 AAB => new Int3(A, A, B);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of W, W, W from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 WWW => new Int3(W, W, W);

		/// <summary>
		/// Gets a new <see cref="Int3"/> comprised of A, A, A from the current <see cref="Int3"/>.
		/// </summary>
		public Int3 AAA => new Int3(A, A, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, X, X, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XXXX => new Int4(X, X, X, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, R, R, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RRRR => new Int4(R, R, R, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, X, X, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XXXY => new Int4(X, X, X, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, R, R, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RRRG => new Int4(R, R, R, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, X, X, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XXXZ => new Int4(X, X, X, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, R, R, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RRRB => new Int4(R, R, R, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, X, X, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XXXW => new Int4(X, X, X, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, R, R, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RRRA => new Int4(R, R, R, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, X, Y, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XXYX => new Int4(X, X, Y, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, R, G, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RRGR => new Int4(R, R, G, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, X, Y, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XXYY => new Int4(X, X, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, R, G, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RRGG => new Int4(R, R, G, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, X, Y, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XXYZ => new Int4(X, X, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, R, G, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RRGB => new Int4(R, R, G, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, X, Y, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XXYW => new Int4(X, X, Y, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, R, G, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RRGA => new Int4(R, R, G, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, X, Z, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XXZX => new Int4(X, X, Z, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, R, B, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RRBR => new Int4(R, R, B, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, X, Z, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XXZY => new Int4(X, X, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, R, B, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RRBG => new Int4(R, R, B, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, X, Z, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XXZZ => new Int4(X, X, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, R, B, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RRBB => new Int4(R, R, B, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, X, Z, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XXZW => new Int4(X, X, Z, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, R, B, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RRBA => new Int4(R, R, B, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, X, W, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XXWX => new Int4(X, X, W, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, R, A, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RRAR => new Int4(R, R, A, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, X, W, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XXWY => new Int4(X, X, W, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, R, A, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RRAG => new Int4(R, R, A, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, X, W, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XXWZ => new Int4(X, X, W, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, R, A, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RRAB => new Int4(R, R, A, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, X, W, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XXWW => new Int4(X, X, W, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, R, A, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RRAA => new Int4(R, R, A, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, Y, X, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XYXX => new Int4(X, Y, X, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, G, R, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RGRR => new Int4(R, G, R, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, Y, X, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XYXY => new Int4(X, Y, X, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, G, R, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RGRG => new Int4(R, G, R, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, Y, X, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XYXZ => new Int4(X, Y, X, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, G, R, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RGRB => new Int4(R, G, R, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, Y, X, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XYXW => new Int4(X, Y, X, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, G, R, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RGRA => new Int4(R, G, R, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, Y, Y, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XYYX => new Int4(X, Y, Y, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, G, G, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RGGR => new Int4(R, G, G, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, Y, Y, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XYYY => new Int4(X, Y, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, G, G, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RGGG => new Int4(R, G, G, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, Y, Y, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XYYZ => new Int4(X, Y, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, G, G, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RGGB => new Int4(R, G, G, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, Y, Y, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XYYW => new Int4(X, Y, Y, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, G, G, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RGGA => new Int4(R, G, G, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, Y, Z, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XYZX => new Int4(X, Y, Z, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, G, B, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RGBR => new Int4(R, G, B, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, Y, Z, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XYZY => new Int4(X, Y, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, G, B, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RGBG => new Int4(R, G, B, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, Y, Z, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XYZZ => new Int4(X, Y, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, G, B, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RGBB => new Int4(R, G, B, B);

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of X, Y, Z, W on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XYZW
		{
			get => new Int4(X, Y, Z, W); 	
			set
			{
				X = value.X;
				Y = value.Y;
				Z = value.Z;
				W = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of R, G, B, A on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RGBA
		{
			get => new Int4(R, G, B, A);	
			set
			{
				R = value.R;
				G = value.G;
				B = value.B;
				A = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, Y, W, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XYWX => new Int4(X, Y, W, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, G, A, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RGAR => new Int4(R, G, A, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, Y, W, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XYWY => new Int4(X, Y, W, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, G, A, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RGAG => new Int4(R, G, A, G);

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of X, Y, W, Z on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XYWZ
		{
			get => new Int4(X, Y, W, Z); 	
			set
			{
				X = value.X;
				Y = value.Y;
				W = value.Z;
				Z = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of R, G, A, B on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RGAB
		{
			get => new Int4(R, G, A, B);	
			set
			{
				R = value.R;
				G = value.G;
				A = value.B;
				B = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, Y, W, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XYWW => new Int4(X, Y, W, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, G, A, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RGAA => new Int4(R, G, A, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, Z, X, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XZXX => new Int4(X, Z, X, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, B, R, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RBRR => new Int4(R, B, R, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, Z, X, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XZXY => new Int4(X, Z, X, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, B, R, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RBRG => new Int4(R, B, R, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, Z, X, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XZXZ => new Int4(X, Z, X, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, B, R, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RBRB => new Int4(R, B, R, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, Z, X, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XZXW => new Int4(X, Z, X, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, B, R, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RBRA => new Int4(R, B, R, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, Z, Y, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XZYX => new Int4(X, Z, Y, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, B, G, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RBGR => new Int4(R, B, G, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, Z, Y, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XZYY => new Int4(X, Z, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, B, G, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RBGG => new Int4(R, B, G, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, Z, Y, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XZYZ => new Int4(X, Z, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, B, G, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RBGB => new Int4(R, B, G, B);

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of X, Z, Y, W on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XZYW
		{
			get => new Int4(X, Z, Y, W); 	
			set
			{
				X = value.X;
				Z = value.Y;
				Y = value.Z;
				W = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of R, B, G, A on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RBGA
		{
			get => new Int4(R, B, G, A);	
			set
			{
				R = value.R;
				B = value.G;
				G = value.B;
				A = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, Z, Z, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XZZX => new Int4(X, Z, Z, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, B, B, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RBBR => new Int4(R, B, B, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, Z, Z, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XZZY => new Int4(X, Z, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, B, B, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RBBG => new Int4(R, B, B, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, Z, Z, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XZZZ => new Int4(X, Z, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, B, B, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RBBB => new Int4(R, B, B, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, Z, Z, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XZZW => new Int4(X, Z, Z, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, B, B, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RBBA => new Int4(R, B, B, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, Z, W, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XZWX => new Int4(X, Z, W, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, B, A, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RBAR => new Int4(R, B, A, R);

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of X, Z, W, Y on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XZWY
		{
			get => new Int4(X, Z, W, Y); 	
			set
			{
				X = value.X;
				Z = value.Y;
				W = value.Z;
				Y = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of R, B, A, G on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RBAG
		{
			get => new Int4(R, B, A, G);	
			set
			{
				R = value.R;
				B = value.G;
				A = value.B;
				G = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, Z, W, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XZWZ => new Int4(X, Z, W, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, B, A, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RBAB => new Int4(R, B, A, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, Z, W, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XZWW => new Int4(X, Z, W, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, B, A, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RBAA => new Int4(R, B, A, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, W, X, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XWXX => new Int4(X, W, X, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, A, R, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RARR => new Int4(R, A, R, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, W, X, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XWXY => new Int4(X, W, X, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, A, R, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RARG => new Int4(R, A, R, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, W, X, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XWXZ => new Int4(X, W, X, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, A, R, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RARB => new Int4(R, A, R, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, W, X, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XWXW => new Int4(X, W, X, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, A, R, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RARA => new Int4(R, A, R, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, W, Y, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XWYX => new Int4(X, W, Y, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, A, G, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RAGR => new Int4(R, A, G, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, W, Y, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XWYY => new Int4(X, W, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, A, G, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RAGG => new Int4(R, A, G, G);

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of X, W, Y, Z on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XWYZ
		{
			get => new Int4(X, W, Y, Z); 	
			set
			{
				X = value.X;
				W = value.Y;
				Y = value.Z;
				Z = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of R, A, G, B on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RAGB
		{
			get => new Int4(R, A, G, B);	
			set
			{
				R = value.R;
				A = value.G;
				G = value.B;
				B = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, W, Y, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XWYW => new Int4(X, W, Y, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, A, G, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RAGA => new Int4(R, A, G, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, W, Z, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XWZX => new Int4(X, W, Z, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, A, B, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RABR => new Int4(R, A, B, R);

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of X, W, Z, Y on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XWZY
		{
			get => new Int4(X, W, Z, Y); 	
			set
			{
				X = value.X;
				W = value.Y;
				Z = value.Z;
				Y = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of R, A, B, G on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RABG
		{
			get => new Int4(R, A, B, G);	
			set
			{
				R = value.R;
				A = value.G;
				B = value.B;
				G = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, W, Z, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XWZZ => new Int4(X, W, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, A, B, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RABB => new Int4(R, A, B, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, W, Z, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XWZW => new Int4(X, W, Z, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, A, B, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RABA => new Int4(R, A, B, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, W, W, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XWWX => new Int4(X, W, W, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, A, A, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RAAR => new Int4(R, A, A, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, W, W, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XWWY => new Int4(X, W, W, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, A, A, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RAAG => new Int4(R, A, A, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, W, W, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XWWZ => new Int4(X, W, W, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, A, A, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RAAB => new Int4(R, A, A, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of X, W, W, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 XWWW => new Int4(X, W, W, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of R, A, A, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 RAAA => new Int4(R, A, A, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, X, X, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YXXX => new Int4(Y, X, X, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, R, R, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GRRR => new Int4(G, R, R, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, X, X, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YXXY => new Int4(Y, X, X, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, R, R, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GRRG => new Int4(G, R, R, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, X, X, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YXXZ => new Int4(Y, X, X, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, R, R, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GRRB => new Int4(G, R, R, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, X, X, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YXXW => new Int4(Y, X, X, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, R, R, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GRRA => new Int4(G, R, R, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, X, Y, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YXYX => new Int4(Y, X, Y, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, R, G, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GRGR => new Int4(G, R, G, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, X, Y, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YXYY => new Int4(Y, X, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, R, G, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GRGG => new Int4(G, R, G, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, X, Y, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YXYZ => new Int4(Y, X, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, R, G, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GRGB => new Int4(G, R, G, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, X, Y, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YXYW => new Int4(Y, X, Y, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, R, G, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GRGA => new Int4(G, R, G, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, X, Z, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YXZX => new Int4(Y, X, Z, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, R, B, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GRBR => new Int4(G, R, B, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, X, Z, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YXZY => new Int4(Y, X, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, R, B, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GRBG => new Int4(G, R, B, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, X, Z, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YXZZ => new Int4(Y, X, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, R, B, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GRBB => new Int4(G, R, B, B);

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of Y, X, Z, W on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YXZW
		{
			get => new Int4(Y, X, Z, W); 	
			set
			{
				Y = value.X;
				X = value.Y;
				Z = value.Z;
				W = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of G, R, B, A on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GRBA
		{
			get => new Int4(G, R, B, A);	
			set
			{
				G = value.R;
				R = value.G;
				B = value.B;
				A = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, X, W, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YXWX => new Int4(Y, X, W, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, R, A, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GRAR => new Int4(G, R, A, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, X, W, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YXWY => new Int4(Y, X, W, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, R, A, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GRAG => new Int4(G, R, A, G);

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of Y, X, W, Z on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YXWZ
		{
			get => new Int4(Y, X, W, Z); 	
			set
			{
				Y = value.X;
				X = value.Y;
				W = value.Z;
				Z = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of G, R, A, B on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GRAB
		{
			get => new Int4(G, R, A, B);	
			set
			{
				G = value.R;
				R = value.G;
				A = value.B;
				B = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, X, W, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YXWW => new Int4(Y, X, W, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, R, A, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GRAA => new Int4(G, R, A, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, Y, X, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YYXX => new Int4(Y, Y, X, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, G, R, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GGRR => new Int4(G, G, R, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, Y, X, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YYXY => new Int4(Y, Y, X, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, G, R, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GGRG => new Int4(G, G, R, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, Y, X, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YYXZ => new Int4(Y, Y, X, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, G, R, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GGRB => new Int4(G, G, R, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, Y, X, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YYXW => new Int4(Y, Y, X, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, G, R, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GGRA => new Int4(G, G, R, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, Y, Y, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YYYX => new Int4(Y, Y, Y, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, G, G, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GGGR => new Int4(G, G, G, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, Y, Y, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YYYY => new Int4(Y, Y, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, G, G, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GGGG => new Int4(G, G, G, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, Y, Y, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YYYZ => new Int4(Y, Y, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, G, G, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GGGB => new Int4(G, G, G, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, Y, Y, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YYYW => new Int4(Y, Y, Y, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, G, G, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GGGA => new Int4(G, G, G, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, Y, Z, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YYZX => new Int4(Y, Y, Z, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, G, B, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GGBR => new Int4(G, G, B, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, Y, Z, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YYZY => new Int4(Y, Y, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, G, B, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GGBG => new Int4(G, G, B, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, Y, Z, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YYZZ => new Int4(Y, Y, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, G, B, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GGBB => new Int4(G, G, B, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, Y, Z, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YYZW => new Int4(Y, Y, Z, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, G, B, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GGBA => new Int4(G, G, B, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, Y, W, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YYWX => new Int4(Y, Y, W, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, G, A, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GGAR => new Int4(G, G, A, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, Y, W, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YYWY => new Int4(Y, Y, W, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, G, A, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GGAG => new Int4(G, G, A, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, Y, W, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YYWZ => new Int4(Y, Y, W, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, G, A, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GGAB => new Int4(G, G, A, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, Y, W, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YYWW => new Int4(Y, Y, W, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, G, A, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GGAA => new Int4(G, G, A, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, Z, X, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YZXX => new Int4(Y, Z, X, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, B, R, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GBRR => new Int4(G, B, R, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, Z, X, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YZXY => new Int4(Y, Z, X, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, B, R, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GBRG => new Int4(G, B, R, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, Z, X, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YZXZ => new Int4(Y, Z, X, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, B, R, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GBRB => new Int4(G, B, R, B);

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of Y, Z, X, W on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YZXW
		{
			get => new Int4(Y, Z, X, W); 	
			set
			{
				Y = value.X;
				Z = value.Y;
				X = value.Z;
				W = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of G, B, R, A on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GBRA
		{
			get => new Int4(G, B, R, A);	
			set
			{
				G = value.R;
				B = value.G;
				R = value.B;
				A = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, Z, Y, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YZYX => new Int4(Y, Z, Y, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, B, G, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GBGR => new Int4(G, B, G, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, Z, Y, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YZYY => new Int4(Y, Z, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, B, G, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GBGG => new Int4(G, B, G, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, Z, Y, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YZYZ => new Int4(Y, Z, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, B, G, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GBGB => new Int4(G, B, G, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, Z, Y, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YZYW => new Int4(Y, Z, Y, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, B, G, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GBGA => new Int4(G, B, G, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, Z, Z, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YZZX => new Int4(Y, Z, Z, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, B, B, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GBBR => new Int4(G, B, B, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, Z, Z, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YZZY => new Int4(Y, Z, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, B, B, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GBBG => new Int4(G, B, B, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, Z, Z, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YZZZ => new Int4(Y, Z, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, B, B, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GBBB => new Int4(G, B, B, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, Z, Z, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YZZW => new Int4(Y, Z, Z, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, B, B, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GBBA => new Int4(G, B, B, A);

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of Y, Z, W, X on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YZWX
		{
			get => new Int4(Y, Z, W, X); 	
			set
			{
				Y = value.X;
				Z = value.Y;
				W = value.Z;
				X = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of G, B, A, R on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GBAR
		{
			get => new Int4(G, B, A, R);	
			set
			{
				G = value.R;
				B = value.G;
				A = value.B;
				R = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, Z, W, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YZWY => new Int4(Y, Z, W, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, B, A, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GBAG => new Int4(G, B, A, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, Z, W, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YZWZ => new Int4(Y, Z, W, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, B, A, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GBAB => new Int4(G, B, A, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, Z, W, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YZWW => new Int4(Y, Z, W, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, B, A, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GBAA => new Int4(G, B, A, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, W, X, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YWXX => new Int4(Y, W, X, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, A, R, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GARR => new Int4(G, A, R, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, W, X, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YWXY => new Int4(Y, W, X, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, A, R, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GARG => new Int4(G, A, R, G);

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of Y, W, X, Z on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YWXZ
		{
			get => new Int4(Y, W, X, Z); 	
			set
			{
				Y = value.X;
				W = value.Y;
				X = value.Z;
				Z = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of G, A, R, B on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GARB
		{
			get => new Int4(G, A, R, B);	
			set
			{
				G = value.R;
				A = value.G;
				R = value.B;
				B = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, W, X, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YWXW => new Int4(Y, W, X, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, A, R, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GARA => new Int4(G, A, R, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, W, Y, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YWYX => new Int4(Y, W, Y, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, A, G, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GAGR => new Int4(G, A, G, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, W, Y, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YWYY => new Int4(Y, W, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, A, G, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GAGG => new Int4(G, A, G, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, W, Y, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YWYZ => new Int4(Y, W, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, A, G, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GAGB => new Int4(G, A, G, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, W, Y, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YWYW => new Int4(Y, W, Y, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, A, G, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GAGA => new Int4(G, A, G, A);

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of Y, W, Z, X on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YWZX
		{
			get => new Int4(Y, W, Z, X); 	
			set
			{
				Y = value.X;
				W = value.Y;
				Z = value.Z;
				X = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of G, A, B, R on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GABR
		{
			get => new Int4(G, A, B, R);	
			set
			{
				G = value.R;
				A = value.G;
				B = value.B;
				R = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, W, Z, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YWZY => new Int4(Y, W, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, A, B, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GABG => new Int4(G, A, B, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, W, Z, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YWZZ => new Int4(Y, W, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, A, B, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GABB => new Int4(G, A, B, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, W, Z, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YWZW => new Int4(Y, W, Z, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, A, B, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GABA => new Int4(G, A, B, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, W, W, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YWWX => new Int4(Y, W, W, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, A, A, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GAAR => new Int4(G, A, A, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, W, W, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YWWY => new Int4(Y, W, W, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, A, A, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GAAG => new Int4(G, A, A, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, W, W, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YWWZ => new Int4(Y, W, W, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, A, A, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GAAB => new Int4(G, A, A, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Y, W, W, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 YWWW => new Int4(Y, W, W, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of G, A, A, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 GAAA => new Int4(G, A, A, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, X, X, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZXXX => new Int4(Z, X, X, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, R, R, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BRRR => new Int4(B, R, R, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, X, X, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZXXY => new Int4(Z, X, X, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, R, R, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BRRG => new Int4(B, R, R, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, X, X, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZXXZ => new Int4(Z, X, X, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, R, R, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BRRB => new Int4(B, R, R, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, X, X, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZXXW => new Int4(Z, X, X, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, R, R, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BRRA => new Int4(B, R, R, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, X, Y, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZXYX => new Int4(Z, X, Y, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, R, G, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BRGR => new Int4(B, R, G, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, X, Y, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZXYY => new Int4(Z, X, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, R, G, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BRGG => new Int4(B, R, G, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, X, Y, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZXYZ => new Int4(Z, X, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, R, G, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BRGB => new Int4(B, R, G, B);

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of Z, X, Y, W on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZXYW
		{
			get => new Int4(Z, X, Y, W); 	
			set
			{
				Z = value.X;
				X = value.Y;
				Y = value.Z;
				W = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of B, R, G, A on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BRGA
		{
			get => new Int4(B, R, G, A);	
			set
			{
				B = value.R;
				R = value.G;
				G = value.B;
				A = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, X, Z, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZXZX => new Int4(Z, X, Z, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, R, B, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BRBR => new Int4(B, R, B, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, X, Z, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZXZY => new Int4(Z, X, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, R, B, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BRBG => new Int4(B, R, B, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, X, Z, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZXZZ => new Int4(Z, X, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, R, B, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BRBB => new Int4(B, R, B, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, X, Z, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZXZW => new Int4(Z, X, Z, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, R, B, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BRBA => new Int4(B, R, B, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, X, W, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZXWX => new Int4(Z, X, W, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, R, A, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BRAR => new Int4(B, R, A, R);

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of Z, X, W, Y on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZXWY
		{
			get => new Int4(Z, X, W, Y); 	
			set
			{
				Z = value.X;
				X = value.Y;
				W = value.Z;
				Y = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of B, R, A, G on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BRAG
		{
			get => new Int4(B, R, A, G);	
			set
			{
				B = value.R;
				R = value.G;
				A = value.B;
				G = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, X, W, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZXWZ => new Int4(Z, X, W, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, R, A, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BRAB => new Int4(B, R, A, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, X, W, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZXWW => new Int4(Z, X, W, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, R, A, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BRAA => new Int4(B, R, A, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, Y, X, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZYXX => new Int4(Z, Y, X, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, G, R, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BGRR => new Int4(B, G, R, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, Y, X, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZYXY => new Int4(Z, Y, X, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, G, R, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BGRG => new Int4(B, G, R, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, Y, X, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZYXZ => new Int4(Z, Y, X, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, G, R, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BGRB => new Int4(B, G, R, B);

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of Z, Y, X, W on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZYXW
		{
			get => new Int4(Z, Y, X, W); 	
			set
			{
				Z = value.X;
				Y = value.Y;
				X = value.Z;
				W = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of B, G, R, A on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BGRA
		{
			get => new Int4(B, G, R, A);	
			set
			{
				B = value.R;
				G = value.G;
				R = value.B;
				A = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, Y, Y, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZYYX => new Int4(Z, Y, Y, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, G, G, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BGGR => new Int4(B, G, G, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, Y, Y, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZYYY => new Int4(Z, Y, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, G, G, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BGGG => new Int4(B, G, G, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, Y, Y, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZYYZ => new Int4(Z, Y, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, G, G, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BGGB => new Int4(B, G, G, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, Y, Y, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZYYW => new Int4(Z, Y, Y, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, G, G, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BGGA => new Int4(B, G, G, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, Y, Z, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZYZX => new Int4(Z, Y, Z, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, G, B, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BGBR => new Int4(B, G, B, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, Y, Z, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZYZY => new Int4(Z, Y, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, G, B, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BGBG => new Int4(B, G, B, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, Y, Z, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZYZZ => new Int4(Z, Y, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, G, B, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BGBB => new Int4(B, G, B, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, Y, Z, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZYZW => new Int4(Z, Y, Z, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, G, B, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BGBA => new Int4(B, G, B, A);

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of Z, Y, W, X on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZYWX
		{
			get => new Int4(Z, Y, W, X); 	
			set
			{
				Z = value.X;
				Y = value.Y;
				W = value.Z;
				X = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of B, G, A, R on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BGAR
		{
			get => new Int4(B, G, A, R);	
			set
			{
				B = value.R;
				G = value.G;
				A = value.B;
				R = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, Y, W, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZYWY => new Int4(Z, Y, W, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, G, A, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BGAG => new Int4(B, G, A, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, Y, W, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZYWZ => new Int4(Z, Y, W, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, G, A, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BGAB => new Int4(B, G, A, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, Y, W, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZYWW => new Int4(Z, Y, W, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, G, A, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BGAA => new Int4(B, G, A, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, Z, X, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZZXX => new Int4(Z, Z, X, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, B, R, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BBRR => new Int4(B, B, R, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, Z, X, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZZXY => new Int4(Z, Z, X, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, B, R, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BBRG => new Int4(B, B, R, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, Z, X, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZZXZ => new Int4(Z, Z, X, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, B, R, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BBRB => new Int4(B, B, R, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, Z, X, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZZXW => new Int4(Z, Z, X, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, B, R, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BBRA => new Int4(B, B, R, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, Z, Y, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZZYX => new Int4(Z, Z, Y, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, B, G, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BBGR => new Int4(B, B, G, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, Z, Y, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZZYY => new Int4(Z, Z, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, B, G, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BBGG => new Int4(B, B, G, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, Z, Y, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZZYZ => new Int4(Z, Z, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, B, G, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BBGB => new Int4(B, B, G, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, Z, Y, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZZYW => new Int4(Z, Z, Y, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, B, G, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BBGA => new Int4(B, B, G, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, Z, Z, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZZZX => new Int4(Z, Z, Z, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, B, B, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BBBR => new Int4(B, B, B, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, Z, Z, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZZZY => new Int4(Z, Z, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, B, B, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BBBG => new Int4(B, B, B, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, Z, Z, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZZZZ => new Int4(Z, Z, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, B, B, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BBBB => new Int4(B, B, B, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, Z, Z, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZZZW => new Int4(Z, Z, Z, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, B, B, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BBBA => new Int4(B, B, B, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, Z, W, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZZWX => new Int4(Z, Z, W, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, B, A, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BBAR => new Int4(B, B, A, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, Z, W, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZZWY => new Int4(Z, Z, W, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, B, A, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BBAG => new Int4(B, B, A, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, Z, W, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZZWZ => new Int4(Z, Z, W, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, B, A, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BBAB => new Int4(B, B, A, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, Z, W, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZZWW => new Int4(Z, Z, W, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, B, A, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BBAA => new Int4(B, B, A, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, W, X, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZWXX => new Int4(Z, W, X, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, A, R, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BARR => new Int4(B, A, R, R);

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of Z, W, X, Y on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZWXY
		{
			get => new Int4(Z, W, X, Y); 	
			set
			{
				Z = value.X;
				W = value.Y;
				X = value.Z;
				Y = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of B, A, R, G on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BARG
		{
			get => new Int4(B, A, R, G);	
			set
			{
				B = value.R;
				A = value.G;
				R = value.B;
				G = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, W, X, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZWXZ => new Int4(Z, W, X, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, A, R, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BARB => new Int4(B, A, R, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, W, X, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZWXW => new Int4(Z, W, X, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, A, R, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BARA => new Int4(B, A, R, A);

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of Z, W, Y, X on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZWYX
		{
			get => new Int4(Z, W, Y, X); 	
			set
			{
				Z = value.X;
				W = value.Y;
				Y = value.Z;
				X = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of B, A, G, R on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BAGR
		{
			get => new Int4(B, A, G, R);	
			set
			{
				B = value.R;
				A = value.G;
				G = value.B;
				R = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, W, Y, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZWYY => new Int4(Z, W, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, A, G, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BAGG => new Int4(B, A, G, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, W, Y, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZWYZ => new Int4(Z, W, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, A, G, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BAGB => new Int4(B, A, G, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, W, Y, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZWYW => new Int4(Z, W, Y, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, A, G, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BAGA => new Int4(B, A, G, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, W, Z, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZWZX => new Int4(Z, W, Z, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, A, B, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BABR => new Int4(B, A, B, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, W, Z, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZWZY => new Int4(Z, W, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, A, B, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BABG => new Int4(B, A, B, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, W, Z, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZWZZ => new Int4(Z, W, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, A, B, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BABB => new Int4(B, A, B, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, W, Z, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZWZW => new Int4(Z, W, Z, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, A, B, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BABA => new Int4(B, A, B, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, W, W, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZWWX => new Int4(Z, W, W, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, A, A, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BAAR => new Int4(B, A, A, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, W, W, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZWWY => new Int4(Z, W, W, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, A, A, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BAAG => new Int4(B, A, A, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, W, W, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZWWZ => new Int4(Z, W, W, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, A, A, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BAAB => new Int4(B, A, A, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of Z, W, W, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ZWWW => new Int4(Z, W, W, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of B, A, A, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 BAAA => new Int4(B, A, A, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, X, X, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WXXX => new Int4(W, X, X, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, R, R, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ARRR => new Int4(A, R, R, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, X, X, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WXXY => new Int4(W, X, X, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, R, R, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ARRG => new Int4(A, R, R, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, X, X, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WXXZ => new Int4(W, X, X, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, R, R, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ARRB => new Int4(A, R, R, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, X, X, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WXXW => new Int4(W, X, X, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, R, R, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ARRA => new Int4(A, R, R, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, X, Y, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WXYX => new Int4(W, X, Y, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, R, G, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ARGR => new Int4(A, R, G, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, X, Y, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WXYY => new Int4(W, X, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, R, G, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ARGG => new Int4(A, R, G, G);

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of W, X, Y, Z on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WXYZ
		{
			get => new Int4(W, X, Y, Z); 	
			set
			{
				W = value.X;
				X = value.Y;
				Y = value.Z;
				Z = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of A, R, G, B on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ARGB
		{
			get => new Int4(A, R, G, B);	
			set
			{
				A = value.R;
				R = value.G;
				G = value.B;
				B = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, X, Y, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WXYW => new Int4(W, X, Y, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, R, G, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ARGA => new Int4(A, R, G, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, X, Z, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WXZX => new Int4(W, X, Z, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, R, B, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ARBR => new Int4(A, R, B, R);

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of W, X, Z, Y on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WXZY
		{
			get => new Int4(W, X, Z, Y); 	
			set
			{
				W = value.X;
				X = value.Y;
				Z = value.Z;
				Y = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of A, R, B, G on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ARBG
		{
			get => new Int4(A, R, B, G);	
			set
			{
				A = value.R;
				R = value.G;
				B = value.B;
				G = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, X, Z, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WXZZ => new Int4(W, X, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, R, B, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ARBB => new Int4(A, R, B, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, X, Z, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WXZW => new Int4(W, X, Z, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, R, B, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ARBA => new Int4(A, R, B, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, X, W, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WXWX => new Int4(W, X, W, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, R, A, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ARAR => new Int4(A, R, A, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, X, W, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WXWY => new Int4(W, X, W, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, R, A, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ARAG => new Int4(A, R, A, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, X, W, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WXWZ => new Int4(W, X, W, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, R, A, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ARAB => new Int4(A, R, A, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, X, W, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WXWW => new Int4(W, X, W, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, R, A, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ARAA => new Int4(A, R, A, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, Y, X, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WYXX => new Int4(W, Y, X, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, G, R, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 AGRR => new Int4(A, G, R, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, Y, X, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WYXY => new Int4(W, Y, X, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, G, R, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 AGRG => new Int4(A, G, R, G);

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of W, Y, X, Z on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WYXZ
		{
			get => new Int4(W, Y, X, Z); 	
			set
			{
				W = value.X;
				Y = value.Y;
				X = value.Z;
				Z = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of A, G, R, B on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 AGRB
		{
			get => new Int4(A, G, R, B);	
			set
			{
				A = value.R;
				G = value.G;
				R = value.B;
				B = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, Y, X, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WYXW => new Int4(W, Y, X, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, G, R, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 AGRA => new Int4(A, G, R, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, Y, Y, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WYYX => new Int4(W, Y, Y, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, G, G, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 AGGR => new Int4(A, G, G, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, Y, Y, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WYYY => new Int4(W, Y, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, G, G, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 AGGG => new Int4(A, G, G, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, Y, Y, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WYYZ => new Int4(W, Y, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, G, G, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 AGGB => new Int4(A, G, G, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, Y, Y, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WYYW => new Int4(W, Y, Y, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, G, G, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 AGGA => new Int4(A, G, G, A);

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of W, Y, Z, X on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WYZX
		{
			get => new Int4(W, Y, Z, X); 	
			set
			{
				W = value.X;
				Y = value.Y;
				Z = value.Z;
				X = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of A, G, B, R on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 AGBR
		{
			get => new Int4(A, G, B, R);	
			set
			{
				A = value.R;
				G = value.G;
				B = value.B;
				R = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, Y, Z, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WYZY => new Int4(W, Y, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, G, B, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 AGBG => new Int4(A, G, B, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, Y, Z, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WYZZ => new Int4(W, Y, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, G, B, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 AGBB => new Int4(A, G, B, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, Y, Z, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WYZW => new Int4(W, Y, Z, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, G, B, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 AGBA => new Int4(A, G, B, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, Y, W, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WYWX => new Int4(W, Y, W, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, G, A, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 AGAR => new Int4(A, G, A, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, Y, W, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WYWY => new Int4(W, Y, W, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, G, A, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 AGAG => new Int4(A, G, A, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, Y, W, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WYWZ => new Int4(W, Y, W, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, G, A, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 AGAB => new Int4(A, G, A, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, Y, W, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WYWW => new Int4(W, Y, W, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, G, A, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 AGAA => new Int4(A, G, A, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, Z, X, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WZXX => new Int4(W, Z, X, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, B, R, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ABRR => new Int4(A, B, R, R);

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of W, Z, X, Y on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WZXY
		{
			get => new Int4(W, Z, X, Y); 	
			set
			{
				W = value.X;
				Z = value.Y;
				X = value.Z;
				Y = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of A, B, R, G on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ABRG
		{
			get => new Int4(A, B, R, G);	
			set
			{
				A = value.R;
				B = value.G;
				R = value.B;
				G = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, Z, X, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WZXZ => new Int4(W, Z, X, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, B, R, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ABRB => new Int4(A, B, R, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, Z, X, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WZXW => new Int4(W, Z, X, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, B, R, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ABRA => new Int4(A, B, R, A);

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of W, Z, Y, X on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WZYX
		{
			get => new Int4(W, Z, Y, X); 	
			set
			{
				W = value.X;
				Z = value.Y;
				Y = value.Z;
				X = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Int4"/> comprised of A, B, G, R on the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ABGR
		{
			get => new Int4(A, B, G, R);	
			set
			{
				A = value.R;
				B = value.G;
				G = value.B;
				R = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, Z, Y, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WZYY => new Int4(W, Z, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, B, G, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ABGG => new Int4(A, B, G, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, Z, Y, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WZYZ => new Int4(W, Z, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, B, G, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ABGB => new Int4(A, B, G, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, Z, Y, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WZYW => new Int4(W, Z, Y, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, B, G, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ABGA => new Int4(A, B, G, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, Z, Z, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WZZX => new Int4(W, Z, Z, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, B, B, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ABBR => new Int4(A, B, B, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, Z, Z, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WZZY => new Int4(W, Z, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, B, B, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ABBG => new Int4(A, B, B, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, Z, Z, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WZZZ => new Int4(W, Z, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, B, B, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ABBB => new Int4(A, B, B, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, Z, Z, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WZZW => new Int4(W, Z, Z, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, B, B, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ABBA => new Int4(A, B, B, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, Z, W, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WZWX => new Int4(W, Z, W, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, B, A, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ABAR => new Int4(A, B, A, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, Z, W, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WZWY => new Int4(W, Z, W, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, B, A, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ABAG => new Int4(A, B, A, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, Z, W, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WZWZ => new Int4(W, Z, W, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, B, A, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ABAB => new Int4(A, B, A, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, Z, W, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WZWW => new Int4(W, Z, W, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, B, A, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 ABAA => new Int4(A, B, A, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, W, X, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WWXX => new Int4(W, W, X, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, A, R, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 AARR => new Int4(A, A, R, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, W, X, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WWXY => new Int4(W, W, X, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, A, R, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 AARG => new Int4(A, A, R, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, W, X, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WWXZ => new Int4(W, W, X, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, A, R, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 AARB => new Int4(A, A, R, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, W, X, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WWXW => new Int4(W, W, X, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, A, R, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 AARA => new Int4(A, A, R, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, W, Y, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WWYX => new Int4(W, W, Y, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, A, G, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 AAGR => new Int4(A, A, G, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, W, Y, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WWYY => new Int4(W, W, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, A, G, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 AAGG => new Int4(A, A, G, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, W, Y, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WWYZ => new Int4(W, W, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, A, G, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 AAGB => new Int4(A, A, G, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, W, Y, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WWYW => new Int4(W, W, Y, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, A, G, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 AAGA => new Int4(A, A, G, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, W, Z, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WWZX => new Int4(W, W, Z, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, A, B, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 AABR => new Int4(A, A, B, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, W, Z, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WWZY => new Int4(W, W, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, A, B, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 AABG => new Int4(A, A, B, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, W, Z, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WWZZ => new Int4(W, W, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, A, B, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 AABB => new Int4(A, A, B, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, W, Z, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WWZW => new Int4(W, W, Z, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, A, B, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 AABA => new Int4(A, A, B, A);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, W, W, X from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WWWX => new Int4(W, W, W, X);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, A, A, R from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 AAAR => new Int4(A, A, A, R);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, W, W, Y from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WWWY => new Int4(W, W, W, Y);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, A, A, G from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 AAAG => new Int4(A, A, A, G);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, W, W, Z from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WWWZ => new Int4(W, W, W, Z);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, A, A, B from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 AAAB => new Int4(A, A, A, B);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of W, W, W, W from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 WWWW => new Int4(W, W, W, W);

		/// <summary>
		/// Gets a new <see cref="Int4"/> comprised of A, A, A, A from the current <see cref="Int4"/>.
		/// </summary>
		public Int4 AAAA => new Int4(A, A, A, A);

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

		public int B
		{
			get => Z;
			set => Z = value;
		}

		public int A
		{
			get => W;
			set => W = value;
		}

		public static Int4 operator +(Int4 a, Int4 b)
		{
			return new Int4()
			{
				X = a.X + b.X,
				Y = a.Y + b.Y,
				Z = a.Z + b.Z,
				W = a.W + b.W,
			};
		}
		public static Int4 operator +(Int4 a, int b)
		{
			return new Int4()
			{
				X = (int)(a.X + b),
				Y = (int)(a.Y + b),
				Z = (int)(a.Z + b),
				W = (int)(a.W + b),
			};
		}

		public static Int4 operator +(int a, Int4 b)
		{
			return new Int4()
			{
				X = (a + b.X),
				Y = (a + b.Y),
				Z = (a + b.Z),
				W = (a + b.W),
			};
		}
		public static Int4 operator +(Int4 a, float b)
		{
			return new Int4()
			{
				X = (int)(a.X + b),
				Y = (int)(a.Y + b),
				Z = (int)(a.Z + b),
				W = (int)(a.W + b),
			};
		}

		public static Int4 operator +(float a, Int4 b)
		{
			return new Int4()
			{
				X = (int)(a + b.X),
				Y = (int)(a + b.Y),
				Z = (int)(a + b.Z),
				W = (int)(a + b.W),
			};
		}
		public static Int4 operator +(Int4 a, double b)
		{
			return new Int4()
			{
				X = (int)(a.X + b),
				Y = (int)(a.Y + b),
				Z = (int)(a.Z + b),
				W = (int)(a.W + b),
			};
		}

		public static Int4 operator +(double a, Int4 b)
		{
			return new Int4()
			{
				X = (int)(a + b.X),
				Y = (int)(a + b.Y),
				Z = (int)(a + b.Z),
				W = (int)(a + b.W),
			};
		}
		public static Int4 operator -(Int4 a, Int4 b)
		{
			return new Int4()
			{
				X = a.X - b.X,
				Y = a.Y - b.Y,
				Z = a.Z - b.Z,
				W = a.W - b.W,
			};
		}
		public static Int4 operator -(Int4 a, int b)
		{
			return new Int4()
			{
				X = (int)(a.X - b),
				Y = (int)(a.Y - b),
				Z = (int)(a.Z - b),
				W = (int)(a.W - b),
			};
		}

		public static Int4 operator -(int a, Int4 b)
		{
			return new Int4()
			{
				X = (a - b.X),
				Y = (a - b.Y),
				Z = (a - b.Z),
				W = (a - b.W),
			};
		}
		public static Int4 operator -(Int4 a, float b)
		{
			return new Int4()
			{
				X = (int)(a.X - b),
				Y = (int)(a.Y - b),
				Z = (int)(a.Z - b),
				W = (int)(a.W - b),
			};
		}

		public static Int4 operator -(float a, Int4 b)
		{
			return new Int4()
			{
				X = (int)(a - b.X),
				Y = (int)(a - b.Y),
				Z = (int)(a - b.Z),
				W = (int)(a - b.W),
			};
		}
		public static Int4 operator -(Int4 a, double b)
		{
			return new Int4()
			{
				X = (int)(a.X - b),
				Y = (int)(a.Y - b),
				Z = (int)(a.Z - b),
				W = (int)(a.W - b),
			};
		}

		public static Int4 operator -(double a, Int4 b)
		{
			return new Int4()
			{
				X = (int)(a - b.X),
				Y = (int)(a - b.Y),
				Z = (int)(a - b.Z),
				W = (int)(a - b.W),
			};
		}
		public static Int4 operator *(Int4 a, Int4 b)
		{
			return new Int4()
			{
				X = a.X * b.X,
				Y = a.Y * b.Y,
				Z = a.Z * b.Z,
				W = a.W * b.W,
			};
		}
		public static Int4 operator *(Int4 a, int b)
		{
			return new Int4()
			{
				X = (int)(a.X * b),
				Y = (int)(a.Y * b),
				Z = (int)(a.Z * b),
				W = (int)(a.W * b),
			};
		}

		public static Int4 operator *(int a, Int4 b)
		{
			return new Int4()
			{
				X = (a * b.X),
				Y = (a * b.Y),
				Z = (a * b.Z),
				W = (a * b.W),
			};
		}
		public static Int4 operator *(Int4 a, float b)
		{
			return new Int4()
			{
				X = (int)(a.X * b),
				Y = (int)(a.Y * b),
				Z = (int)(a.Z * b),
				W = (int)(a.W * b),
			};
		}

		public static Int4 operator *(float a, Int4 b)
		{
			return new Int4()
			{
				X = (int)(a * b.X),
				Y = (int)(a * b.Y),
				Z = (int)(a * b.Z),
				W = (int)(a * b.W),
			};
		}
		public static Int4 operator *(Int4 a, double b)
		{
			return new Int4()
			{
				X = (int)(a.X * b),
				Y = (int)(a.Y * b),
				Z = (int)(a.Z * b),
				W = (int)(a.W * b),
			};
		}

		public static Int4 operator *(double a, Int4 b)
		{
			return new Int4()
			{
				X = (int)(a * b.X),
				Y = (int)(a * b.Y),
				Z = (int)(a * b.Z),
				W = (int)(a * b.W),
			};
		}
		public static Int4 operator /(Int4 a, Int4 b)
		{
			return new Int4()
			{
				X = a.X / b.X,
				Y = a.Y / b.Y,
				Z = a.Z / b.Z,
				W = a.W / b.W,
			};
		}
		public static Int4 operator /(Int4 a, int b)
		{
			return new Int4()
			{
				X = (int)(a.X / b),
				Y = (int)(a.Y / b),
				Z = (int)(a.Z / b),
				W = (int)(a.W / b),
			};
		}

		public static Int4 operator /(int a, Int4 b)
		{
			return new Int4()
			{
				X = (a / b.X),
				Y = (a / b.Y),
				Z = (a / b.Z),
				W = (a / b.W),
			};
		}
		public static Int4 operator /(Int4 a, float b)
		{
			return new Int4()
			{
				X = (int)(a.X / b),
				Y = (int)(a.Y / b),
				Z = (int)(a.Z / b),
				W = (int)(a.W / b),
			};
		}

		public static Int4 operator /(float a, Int4 b)
		{
			return new Int4()
			{
				X = (int)(a / b.X),
				Y = (int)(a / b.Y),
				Z = (int)(a / b.Z),
				W = (int)(a / b.W),
			};
		}
		public static Int4 operator /(Int4 a, double b)
		{
			return new Int4()
			{
				X = (int)(a.X / b),
				Y = (int)(a.Y / b),
				Z = (int)(a.Z / b),
				W = (int)(a.W / b),
			};
		}

		public static Int4 operator /(double a, Int4 b)
		{
			return new Int4()
			{
				X = (int)(a / b.X),
				Y = (int)(a / b.Y),
				Z = (int)(a / b.Z),
				W = (int)(a / b.W),
			};
		}
	}
}
