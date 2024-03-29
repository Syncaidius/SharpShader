using System;
using System.Runtime.InteropServices;

namespace SharpShader
{
	[StructLayout(LayoutKind.Sequential)]
	[Serializable]
	public struct UInt4 : IVector<uint>
	{
		/// <summary>
		///	The number of elements (components) in a <see cref="UInt4"/>.
		/// </summary>
		public const int ELEMENT_COUNT = 4;
		
		/// <summary>
		///	The size of a <see cref="UInt4"/>, in bytes.
		/// </summary>
		public const int ELEMENT_SIZE = sizeof(uint);

		/// <summary>
		///	The size of a single element (component) within a <see cref="UInt4"/>, in bytes.
		/// </summary>
		public const int SIZE_OF = ELEMENT_COUNT * ELEMENT_SIZE;

		/// <summary>
		///	Gets the <see cref="Type"/> of each element in a <see cref="UInt4"/>.
		/// </summary>
		public static readonly Type ElementType = typeof(uint);

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
        /// The W component.
        /// </summary>
		public uint W;

        /// <summary>
        /// Creates a new instance of <see cref="UInt4"/>.
        /// </summary>
		public UInt4(uint x, uint y, uint z, uint w)
		{
			X = x;
			Y = y;
			Z = z;
			W = w;
		}

        /// <summary>
        /// Creates a new instance of <see cref="UInt4"/>.
        /// </summary>
		public UInt4(UInt3 p, uint w)
		{
			X = p.X;
			Y = p.Y;
			Z = p.Z;
			W = w;
		}

        /// <summary>
        /// Creates a new instance of <see cref="UInt4"/>.
        /// </summary>
		public UInt4(uint x, UInt3 p)
		{
			X = x;
			Y = p.X;
			Z = p.Y;
			W = p.Z;
		}

        /// <summary>
        /// Creates a new instance of <see cref="UInt4"/>.
        /// </summary>
		public UInt4(UInt2 p, uint z, uint w)
		{
			X = p.X;
			Y = p.Y;
			Z = z;
			W = w;
		}

        /// <summary>
        /// Creates a new instance of <see cref="UInt4"/>.
        /// </summary>
		public UInt4(uint x, UInt2 p, uint w)
		{
			X = x;
			Y = p.X;
			Z = p.Y;
			W = w;
		}

        /// <summary>
        /// Creates a new instance of <see cref="UInt4"/>.
        /// </summary>
		public UInt4(uint x, uint y, UInt2 p)
		{
			X = x;
			Y = y;
			Z = p.X;
			W = p.Y;
		}

		/// <summary>
		/// Gets or sets a component at the specified index for the current <see cref="UInt4"/> .
		/// </summary>
		public uint this[int index]
		{
			get
			{
				switch(index)
				{
					case 0: return X;
					case 1: return Y;
					case 2: return Z;
					case 3: return W;
					default: throw new IndexOutOfRangeException("The maximum index of a UInt4 is 3.");
				}
			}
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
		/// Gets or sets a <see cref="UInt2"/> comprised of X, W on the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 XW
		{
			get => new UInt2(X, W); 	
			set
			{
				X = value.X;
				W = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt2"/> comprised of R, A on the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 RA
		{
			get => new UInt2(R, A);	
			set
			{
				R = value.R;
				A = value.G;
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
		/// Gets or sets a <see cref="UInt2"/> comprised of Y, W on the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 YW
		{
			get => new UInt2(Y, W); 	
			set
			{
				Y = value.X;
				W = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt2"/> comprised of G, A on the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 GA
		{
			get => new UInt2(G, A);	
			set
			{
				G = value.R;
				A = value.G;
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
		/// Gets or sets a <see cref="UInt2"/> comprised of Z, W on the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 ZW
		{
			get => new UInt2(Z, W); 	
			set
			{
				Z = value.X;
				W = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt2"/> comprised of B, A on the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 BA
		{
			get => new UInt2(B, A);	
			set
			{
				B = value.R;
				A = value.G;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt2"/> comprised of W, X on the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 WX
		{
			get => new UInt2(W, X); 	
			set
			{
				W = value.X;
				X = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt2"/> comprised of A, R on the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 AR
		{
			get => new UInt2(A, R);	
			set
			{
				A = value.R;
				R = value.G;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt2"/> comprised of W, Y on the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 WY
		{
			get => new UInt2(W, Y); 	
			set
			{
				W = value.X;
				Y = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt2"/> comprised of A, G on the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 AG
		{
			get => new UInt2(A, G);	
			set
			{
				A = value.R;
				G = value.G;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt2"/> comprised of W, Z on the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 WZ
		{
			get => new UInt2(W, Z); 	
			set
			{
				W = value.X;
				Z = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt2"/> comprised of A, B on the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 AB
		{
			get => new UInt2(A, B);	
			set
			{
				A = value.R;
				B = value.G;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt2"/> comprised of W, W from the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 WW => new UInt2(W, W);

		/// <summary>
		/// Gets a new <see cref="UInt2"/> comprised of A, A from the current <see cref="UInt2"/>.
		/// </summary>
		public UInt2 AA => new UInt2(A, A);

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
		/// Gets a new <see cref="UInt3"/> comprised of X, X, W from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 XXW => new UInt3(X, X, W);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of R, R, A from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 RRA => new UInt3(R, R, A);

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
		/// Gets or sets a <see cref="UInt3"/> comprised of X, Y, W on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 XYW
		{
			get => new UInt3(X, Y, W); 	
			set
			{
				X = value.X;
				Y = value.Y;
				W = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of R, G, A on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 RGA
		{
			get => new UInt3(R, G, A);	
			set
			{
				R = value.R;
				G = value.G;
				A = value.B;
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
		/// Gets or sets a <see cref="UInt3"/> comprised of X, Z, W on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 XZW
		{
			get => new UInt3(X, Z, W); 	
			set
			{
				X = value.X;
				Z = value.Y;
				W = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of R, B, A on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 RBA
		{
			get => new UInt3(R, B, A);	
			set
			{
				R = value.R;
				B = value.G;
				A = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of X, W, X from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 XWX => new UInt3(X, W, X);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of R, A, R from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 RAR => new UInt3(R, A, R);

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of X, W, Y on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 XWY
		{
			get => new UInt3(X, W, Y); 	
			set
			{
				X = value.X;
				W = value.Y;
				Y = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of R, A, G on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 RAG
		{
			get => new UInt3(R, A, G);	
			set
			{
				R = value.R;
				A = value.G;
				G = value.B;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of X, W, Z on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 XWZ
		{
			get => new UInt3(X, W, Z); 	
			set
			{
				X = value.X;
				W = value.Y;
				Z = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of R, A, B on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 RAB
		{
			get => new UInt3(R, A, B);	
			set
			{
				R = value.R;
				A = value.G;
				B = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of X, W, W from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 XWW => new UInt3(X, W, W);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of R, A, A from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 RAA => new UInt3(R, A, A);

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
		/// Gets or sets a <see cref="UInt3"/> comprised of Y, X, W on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 YXW
		{
			get => new UInt3(Y, X, W); 	
			set
			{
				Y = value.X;
				X = value.Y;
				W = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of G, R, A on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 GRA
		{
			get => new UInt3(G, R, A);	
			set
			{
				G = value.R;
				R = value.G;
				A = value.B;
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
		/// Gets a new <see cref="UInt3"/> comprised of Y, Y, W from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 YYW => new UInt3(Y, Y, W);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of G, G, A from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 GGA => new UInt3(G, G, A);

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
		/// Gets or sets a <see cref="UInt3"/> comprised of Y, Z, W on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 YZW
		{
			get => new UInt3(Y, Z, W); 	
			set
			{
				Y = value.X;
				Z = value.Y;
				W = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of G, B, A on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 GBA
		{
			get => new UInt3(G, B, A);	
			set
			{
				G = value.R;
				B = value.G;
				A = value.B;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of Y, W, X on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 YWX
		{
			get => new UInt3(Y, W, X); 	
			set
			{
				Y = value.X;
				W = value.Y;
				X = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of G, A, R on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 GAR
		{
			get => new UInt3(G, A, R);	
			set
			{
				G = value.R;
				A = value.G;
				R = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of Y, W, Y from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 YWY => new UInt3(Y, W, Y);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of G, A, G from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 GAG => new UInt3(G, A, G);

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of Y, W, Z on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 YWZ
		{
			get => new UInt3(Y, W, Z); 	
			set
			{
				Y = value.X;
				W = value.Y;
				Z = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of G, A, B on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 GAB
		{
			get => new UInt3(G, A, B);	
			set
			{
				G = value.R;
				A = value.G;
				B = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of Y, W, W from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 YWW => new UInt3(Y, W, W);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of G, A, A from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 GAA => new UInt3(G, A, A);

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
		/// Gets or sets a <see cref="UInt3"/> comprised of Z, X, W on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 ZXW
		{
			get => new UInt3(Z, X, W); 	
			set
			{
				Z = value.X;
				X = value.Y;
				W = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of B, R, A on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 BRA
		{
			get => new UInt3(B, R, A);	
			set
			{
				B = value.R;
				R = value.G;
				A = value.B;
			}
		}

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
		/// Gets or sets a <see cref="UInt3"/> comprised of Z, Y, W on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 ZYW
		{
			get => new UInt3(Z, Y, W); 	
			set
			{
				Z = value.X;
				Y = value.Y;
				W = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of B, G, A on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 BGA
		{
			get => new UInt3(B, G, A);	
			set
			{
				B = value.R;
				G = value.G;
				A = value.B;
			}
		}

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
		/// Gets a new <see cref="UInt3"/> comprised of Z, Z, W from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 ZZW => new UInt3(Z, Z, W);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of B, B, A from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 BBA => new UInt3(B, B, A);

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of Z, W, X on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 ZWX
		{
			get => new UInt3(Z, W, X); 	
			set
			{
				Z = value.X;
				W = value.Y;
				X = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of B, A, R on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 BAR
		{
			get => new UInt3(B, A, R);	
			set
			{
				B = value.R;
				A = value.G;
				R = value.B;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of Z, W, Y on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 ZWY
		{
			get => new UInt3(Z, W, Y); 	
			set
			{
				Z = value.X;
				W = value.Y;
				Y = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of B, A, G on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 BAG
		{
			get => new UInt3(B, A, G);	
			set
			{
				B = value.R;
				A = value.G;
				G = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of Z, W, Z from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 ZWZ => new UInt3(Z, W, Z);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of B, A, B from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 BAB => new UInt3(B, A, B);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of Z, W, W from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 ZWW => new UInt3(Z, W, W);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of B, A, A from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 BAA => new UInt3(B, A, A);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of W, X, X from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 WXX => new UInt3(W, X, X);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of A, R, R from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 ARR => new UInt3(A, R, R);

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of W, X, Y on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 WXY
		{
			get => new UInt3(W, X, Y); 	
			set
			{
				W = value.X;
				X = value.Y;
				Y = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of A, R, G on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 ARG
		{
			get => new UInt3(A, R, G);	
			set
			{
				A = value.R;
				R = value.G;
				G = value.B;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of W, X, Z on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 WXZ
		{
			get => new UInt3(W, X, Z); 	
			set
			{
				W = value.X;
				X = value.Y;
				Z = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of A, R, B on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 ARB
		{
			get => new UInt3(A, R, B);	
			set
			{
				A = value.R;
				R = value.G;
				B = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of W, X, W from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 WXW => new UInt3(W, X, W);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of A, R, A from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 ARA => new UInt3(A, R, A);

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of W, Y, X on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 WYX
		{
			get => new UInt3(W, Y, X); 	
			set
			{
				W = value.X;
				Y = value.Y;
				X = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of A, G, R on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 AGR
		{
			get => new UInt3(A, G, R);	
			set
			{
				A = value.R;
				G = value.G;
				R = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of W, Y, Y from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 WYY => new UInt3(W, Y, Y);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of A, G, G from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 AGG => new UInt3(A, G, G);

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of W, Y, Z on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 WYZ
		{
			get => new UInt3(W, Y, Z); 	
			set
			{
				W = value.X;
				Y = value.Y;
				Z = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of A, G, B on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 AGB
		{
			get => new UInt3(A, G, B);	
			set
			{
				A = value.R;
				G = value.G;
				B = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of W, Y, W from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 WYW => new UInt3(W, Y, W);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of A, G, A from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 AGA => new UInt3(A, G, A);

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of W, Z, X on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 WZX
		{
			get => new UInt3(W, Z, X); 	
			set
			{
				W = value.X;
				Z = value.Y;
				X = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of A, B, R on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 ABR
		{
			get => new UInt3(A, B, R);	
			set
			{
				A = value.R;
				B = value.G;
				R = value.B;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of W, Z, Y on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 WZY
		{
			get => new UInt3(W, Z, Y); 	
			set
			{
				W = value.X;
				Z = value.Y;
				Y = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt3"/> comprised of A, B, G on the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 ABG
		{
			get => new UInt3(A, B, G);	
			set
			{
				A = value.R;
				B = value.G;
				G = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of W, Z, Z from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 WZZ => new UInt3(W, Z, Z);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of A, B, B from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 ABB => new UInt3(A, B, B);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of W, Z, W from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 WZW => new UInt3(W, Z, W);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of A, B, A from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 ABA => new UInt3(A, B, A);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of W, W, X from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 WWX => new UInt3(W, W, X);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of A, A, R from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 AAR => new UInt3(A, A, R);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of W, W, Y from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 WWY => new UInt3(W, W, Y);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of A, A, G from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 AAG => new UInt3(A, A, G);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of W, W, Z from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 WWZ => new UInt3(W, W, Z);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of A, A, B from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 AAB => new UInt3(A, A, B);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of W, W, W from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 WWW => new UInt3(W, W, W);

		/// <summary>
		/// Gets a new <see cref="UInt3"/> comprised of A, A, A from the current <see cref="UInt3"/>.
		/// </summary>
		public UInt3 AAA => new UInt3(A, A, A);

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
		/// Gets a new <see cref="UInt4"/> comprised of X, X, X, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XXXW => new UInt4(X, X, X, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, R, R, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RRRA => new UInt4(R, R, R, A);

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
		/// Gets a new <see cref="UInt4"/> comprised of X, X, Y, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XXYW => new UInt4(X, X, Y, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, R, G, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RRGA => new UInt4(R, R, G, A);

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
		/// Gets a new <see cref="UInt4"/> comprised of X, X, Z, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XXZW => new UInt4(X, X, Z, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, R, B, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RRBA => new UInt4(R, R, B, A);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, X, W, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XXWX => new UInt4(X, X, W, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, R, A, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RRAR => new UInt4(R, R, A, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, X, W, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XXWY => new UInt4(X, X, W, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, R, A, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RRAG => new UInt4(R, R, A, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, X, W, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XXWZ => new UInt4(X, X, W, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, R, A, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RRAB => new UInt4(R, R, A, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, X, W, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XXWW => new UInt4(X, X, W, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, R, A, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RRAA => new UInt4(R, R, A, A);

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
		/// Gets a new <see cref="UInt4"/> comprised of X, Y, X, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XYXW => new UInt4(X, Y, X, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, G, R, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RGRA => new UInt4(R, G, R, A);

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
		/// Gets a new <see cref="UInt4"/> comprised of X, Y, Y, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XYYW => new UInt4(X, Y, Y, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, G, G, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RGGA => new UInt4(R, G, G, A);

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
		/// Gets or sets a <see cref="UInt4"/> comprised of X, Y, Z, W on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XYZW
		{
			get => new UInt4(X, Y, Z, W); 	
			set
			{
				X = value.X;
				Y = value.Y;
				Z = value.Z;
				W = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of R, G, B, A on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RGBA
		{
			get => new UInt4(R, G, B, A);	
			set
			{
				R = value.R;
				G = value.G;
				B = value.B;
				A = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, Y, W, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XYWX => new UInt4(X, Y, W, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, G, A, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RGAR => new UInt4(R, G, A, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, Y, W, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XYWY => new UInt4(X, Y, W, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, G, A, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RGAG => new UInt4(R, G, A, G);

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of X, Y, W, Z on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XYWZ
		{
			get => new UInt4(X, Y, W, Z); 	
			set
			{
				X = value.X;
				Y = value.Y;
				W = value.Z;
				Z = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of R, G, A, B on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RGAB
		{
			get => new UInt4(R, G, A, B);	
			set
			{
				R = value.R;
				G = value.G;
				A = value.B;
				B = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, Y, W, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XYWW => new UInt4(X, Y, W, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, G, A, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RGAA => new UInt4(R, G, A, A);

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
		/// Gets a new <see cref="UInt4"/> comprised of X, Z, X, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XZXW => new UInt4(X, Z, X, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, B, R, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RBRA => new UInt4(R, B, R, A);

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
		/// Gets or sets a <see cref="UInt4"/> comprised of X, Z, Y, W on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XZYW
		{
			get => new UInt4(X, Z, Y, W); 	
			set
			{
				X = value.X;
				Z = value.Y;
				Y = value.Z;
				W = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of R, B, G, A on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RBGA
		{
			get => new UInt4(R, B, G, A);	
			set
			{
				R = value.R;
				B = value.G;
				G = value.B;
				A = value.A;
			}
		}

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
		/// Gets a new <see cref="UInt4"/> comprised of X, Z, Z, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XZZW => new UInt4(X, Z, Z, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, B, B, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RBBA => new UInt4(R, B, B, A);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, Z, W, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XZWX => new UInt4(X, Z, W, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, B, A, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RBAR => new UInt4(R, B, A, R);

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of X, Z, W, Y on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XZWY
		{
			get => new UInt4(X, Z, W, Y); 	
			set
			{
				X = value.X;
				Z = value.Y;
				W = value.Z;
				Y = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of R, B, A, G on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RBAG
		{
			get => new UInt4(R, B, A, G);	
			set
			{
				R = value.R;
				B = value.G;
				A = value.B;
				G = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, Z, W, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XZWZ => new UInt4(X, Z, W, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, B, A, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RBAB => new UInt4(R, B, A, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, Z, W, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XZWW => new UInt4(X, Z, W, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, B, A, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RBAA => new UInt4(R, B, A, A);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, W, X, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XWXX => new UInt4(X, W, X, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, A, R, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RARR => new UInt4(R, A, R, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, W, X, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XWXY => new UInt4(X, W, X, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, A, R, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RARG => new UInt4(R, A, R, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, W, X, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XWXZ => new UInt4(X, W, X, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, A, R, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RARB => new UInt4(R, A, R, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, W, X, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XWXW => new UInt4(X, W, X, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, A, R, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RARA => new UInt4(R, A, R, A);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, W, Y, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XWYX => new UInt4(X, W, Y, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, A, G, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RAGR => new UInt4(R, A, G, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, W, Y, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XWYY => new UInt4(X, W, Y, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, A, G, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RAGG => new UInt4(R, A, G, G);

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of X, W, Y, Z on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XWYZ
		{
			get => new UInt4(X, W, Y, Z); 	
			set
			{
				X = value.X;
				W = value.Y;
				Y = value.Z;
				Z = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of R, A, G, B on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RAGB
		{
			get => new UInt4(R, A, G, B);	
			set
			{
				R = value.R;
				A = value.G;
				G = value.B;
				B = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, W, Y, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XWYW => new UInt4(X, W, Y, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, A, G, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RAGA => new UInt4(R, A, G, A);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, W, Z, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XWZX => new UInt4(X, W, Z, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, A, B, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RABR => new UInt4(R, A, B, R);

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of X, W, Z, Y on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XWZY
		{
			get => new UInt4(X, W, Z, Y); 	
			set
			{
				X = value.X;
				W = value.Y;
				Z = value.Z;
				Y = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of R, A, B, G on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RABG
		{
			get => new UInt4(R, A, B, G);	
			set
			{
				R = value.R;
				A = value.G;
				B = value.B;
				G = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, W, Z, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XWZZ => new UInt4(X, W, Z, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, A, B, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RABB => new UInt4(R, A, B, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, W, Z, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XWZW => new UInt4(X, W, Z, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, A, B, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RABA => new UInt4(R, A, B, A);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, W, W, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XWWX => new UInt4(X, W, W, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, A, A, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RAAR => new UInt4(R, A, A, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, W, W, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XWWY => new UInt4(X, W, W, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, A, A, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RAAG => new UInt4(R, A, A, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, W, W, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XWWZ => new UInt4(X, W, W, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, A, A, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RAAB => new UInt4(R, A, A, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of X, W, W, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 XWWW => new UInt4(X, W, W, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of R, A, A, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 RAAA => new UInt4(R, A, A, A);

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
		/// Gets a new <see cref="UInt4"/> comprised of Y, X, X, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YXXW => new UInt4(Y, X, X, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, R, R, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GRRA => new UInt4(G, R, R, A);

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
		/// Gets a new <see cref="UInt4"/> comprised of Y, X, Y, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YXYW => new UInt4(Y, X, Y, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, R, G, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GRGA => new UInt4(G, R, G, A);

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
		/// Gets or sets a <see cref="UInt4"/> comprised of Y, X, Z, W on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YXZW
		{
			get => new UInt4(Y, X, Z, W); 	
			set
			{
				Y = value.X;
				X = value.Y;
				Z = value.Z;
				W = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of G, R, B, A on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GRBA
		{
			get => new UInt4(G, R, B, A);	
			set
			{
				G = value.R;
				R = value.G;
				B = value.B;
				A = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, X, W, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YXWX => new UInt4(Y, X, W, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, R, A, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GRAR => new UInt4(G, R, A, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, X, W, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YXWY => new UInt4(Y, X, W, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, R, A, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GRAG => new UInt4(G, R, A, G);

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of Y, X, W, Z on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YXWZ
		{
			get => new UInt4(Y, X, W, Z); 	
			set
			{
				Y = value.X;
				X = value.Y;
				W = value.Z;
				Z = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of G, R, A, B on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GRAB
		{
			get => new UInt4(G, R, A, B);	
			set
			{
				G = value.R;
				R = value.G;
				A = value.B;
				B = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, X, W, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YXWW => new UInt4(Y, X, W, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, R, A, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GRAA => new UInt4(G, R, A, A);

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
		/// Gets a new <see cref="UInt4"/> comprised of Y, Y, X, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YYXW => new UInt4(Y, Y, X, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, G, R, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GGRA => new UInt4(G, G, R, A);

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
		/// Gets a new <see cref="UInt4"/> comprised of Y, Y, Y, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YYYW => new UInt4(Y, Y, Y, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, G, G, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GGGA => new UInt4(G, G, G, A);

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
		/// Gets a new <see cref="UInt4"/> comprised of Y, Y, Z, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YYZW => new UInt4(Y, Y, Z, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, G, B, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GGBA => new UInt4(G, G, B, A);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, Y, W, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YYWX => new UInt4(Y, Y, W, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, G, A, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GGAR => new UInt4(G, G, A, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, Y, W, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YYWY => new UInt4(Y, Y, W, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, G, A, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GGAG => new UInt4(G, G, A, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, Y, W, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YYWZ => new UInt4(Y, Y, W, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, G, A, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GGAB => new UInt4(G, G, A, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, Y, W, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YYWW => new UInt4(Y, Y, W, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, G, A, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GGAA => new UInt4(G, G, A, A);

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
		/// Gets or sets a <see cref="UInt4"/> comprised of Y, Z, X, W on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YZXW
		{
			get => new UInt4(Y, Z, X, W); 	
			set
			{
				Y = value.X;
				Z = value.Y;
				X = value.Z;
				W = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of G, B, R, A on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GBRA
		{
			get => new UInt4(G, B, R, A);	
			set
			{
				G = value.R;
				B = value.G;
				R = value.B;
				A = value.A;
			}
		}

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
		/// Gets a new <see cref="UInt4"/> comprised of Y, Z, Y, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YZYW => new UInt4(Y, Z, Y, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, B, G, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GBGA => new UInt4(G, B, G, A);

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
		/// Gets a new <see cref="UInt4"/> comprised of Y, Z, Z, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YZZW => new UInt4(Y, Z, Z, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, B, B, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GBBA => new UInt4(G, B, B, A);

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of Y, Z, W, X on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YZWX
		{
			get => new UInt4(Y, Z, W, X); 	
			set
			{
				Y = value.X;
				Z = value.Y;
				W = value.Z;
				X = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of G, B, A, R on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GBAR
		{
			get => new UInt4(G, B, A, R);	
			set
			{
				G = value.R;
				B = value.G;
				A = value.B;
				R = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, Z, W, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YZWY => new UInt4(Y, Z, W, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, B, A, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GBAG => new UInt4(G, B, A, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, Z, W, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YZWZ => new UInt4(Y, Z, W, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, B, A, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GBAB => new UInt4(G, B, A, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, Z, W, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YZWW => new UInt4(Y, Z, W, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, B, A, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GBAA => new UInt4(G, B, A, A);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, W, X, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YWXX => new UInt4(Y, W, X, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, A, R, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GARR => new UInt4(G, A, R, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, W, X, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YWXY => new UInt4(Y, W, X, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, A, R, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GARG => new UInt4(G, A, R, G);

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of Y, W, X, Z on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YWXZ
		{
			get => new UInt4(Y, W, X, Z); 	
			set
			{
				Y = value.X;
				W = value.Y;
				X = value.Z;
				Z = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of G, A, R, B on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GARB
		{
			get => new UInt4(G, A, R, B);	
			set
			{
				G = value.R;
				A = value.G;
				R = value.B;
				B = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, W, X, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YWXW => new UInt4(Y, W, X, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, A, R, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GARA => new UInt4(G, A, R, A);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, W, Y, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YWYX => new UInt4(Y, W, Y, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, A, G, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GAGR => new UInt4(G, A, G, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, W, Y, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YWYY => new UInt4(Y, W, Y, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, A, G, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GAGG => new UInt4(G, A, G, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, W, Y, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YWYZ => new UInt4(Y, W, Y, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, A, G, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GAGB => new UInt4(G, A, G, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, W, Y, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YWYW => new UInt4(Y, W, Y, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, A, G, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GAGA => new UInt4(G, A, G, A);

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of Y, W, Z, X on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YWZX
		{
			get => new UInt4(Y, W, Z, X); 	
			set
			{
				Y = value.X;
				W = value.Y;
				Z = value.Z;
				X = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of G, A, B, R on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GABR
		{
			get => new UInt4(G, A, B, R);	
			set
			{
				G = value.R;
				A = value.G;
				B = value.B;
				R = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, W, Z, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YWZY => new UInt4(Y, W, Z, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, A, B, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GABG => new UInt4(G, A, B, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, W, Z, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YWZZ => new UInt4(Y, W, Z, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, A, B, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GABB => new UInt4(G, A, B, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, W, Z, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YWZW => new UInt4(Y, W, Z, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, A, B, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GABA => new UInt4(G, A, B, A);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, W, W, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YWWX => new UInt4(Y, W, W, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, A, A, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GAAR => new UInt4(G, A, A, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, W, W, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YWWY => new UInt4(Y, W, W, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, A, A, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GAAG => new UInt4(G, A, A, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, W, W, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YWWZ => new UInt4(Y, W, W, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, A, A, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GAAB => new UInt4(G, A, A, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Y, W, W, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 YWWW => new UInt4(Y, W, W, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of G, A, A, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 GAAA => new UInt4(G, A, A, A);

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
		/// Gets a new <see cref="UInt4"/> comprised of Z, X, X, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZXXW => new UInt4(Z, X, X, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, R, R, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BRRA => new UInt4(B, R, R, A);

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
		/// Gets or sets a <see cref="UInt4"/> comprised of Z, X, Y, W on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZXYW
		{
			get => new UInt4(Z, X, Y, W); 	
			set
			{
				Z = value.X;
				X = value.Y;
				Y = value.Z;
				W = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of B, R, G, A on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BRGA
		{
			get => new UInt4(B, R, G, A);	
			set
			{
				B = value.R;
				R = value.G;
				G = value.B;
				A = value.A;
			}
		}

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
		/// Gets a new <see cref="UInt4"/> comprised of Z, X, Z, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZXZW => new UInt4(Z, X, Z, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, R, B, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BRBA => new UInt4(B, R, B, A);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, X, W, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZXWX => new UInt4(Z, X, W, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, R, A, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BRAR => new UInt4(B, R, A, R);

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of Z, X, W, Y on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZXWY
		{
			get => new UInt4(Z, X, W, Y); 	
			set
			{
				Z = value.X;
				X = value.Y;
				W = value.Z;
				Y = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of B, R, A, G on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BRAG
		{
			get => new UInt4(B, R, A, G);	
			set
			{
				B = value.R;
				R = value.G;
				A = value.B;
				G = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, X, W, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZXWZ => new UInt4(Z, X, W, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, R, A, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BRAB => new UInt4(B, R, A, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, X, W, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZXWW => new UInt4(Z, X, W, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, R, A, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BRAA => new UInt4(B, R, A, A);

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
		/// Gets or sets a <see cref="UInt4"/> comprised of Z, Y, X, W on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZYXW
		{
			get => new UInt4(Z, Y, X, W); 	
			set
			{
				Z = value.X;
				Y = value.Y;
				X = value.Z;
				W = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of B, G, R, A on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BGRA
		{
			get => new UInt4(B, G, R, A);	
			set
			{
				B = value.R;
				G = value.G;
				R = value.B;
				A = value.A;
			}
		}

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
		/// Gets a new <see cref="UInt4"/> comprised of Z, Y, Y, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZYYW => new UInt4(Z, Y, Y, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, G, G, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BGGA => new UInt4(B, G, G, A);

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
		/// Gets a new <see cref="UInt4"/> comprised of Z, Y, Z, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZYZW => new UInt4(Z, Y, Z, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, G, B, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BGBA => new UInt4(B, G, B, A);

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of Z, Y, W, X on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZYWX
		{
			get => new UInt4(Z, Y, W, X); 	
			set
			{
				Z = value.X;
				Y = value.Y;
				W = value.Z;
				X = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of B, G, A, R on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BGAR
		{
			get => new UInt4(B, G, A, R);	
			set
			{
				B = value.R;
				G = value.G;
				A = value.B;
				R = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, Y, W, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZYWY => new UInt4(Z, Y, W, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, G, A, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BGAG => new UInt4(B, G, A, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, Y, W, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZYWZ => new UInt4(Z, Y, W, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, G, A, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BGAB => new UInt4(B, G, A, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, Y, W, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZYWW => new UInt4(Z, Y, W, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, G, A, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BGAA => new UInt4(B, G, A, A);

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
		/// Gets a new <see cref="UInt4"/> comprised of Z, Z, X, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZZXW => new UInt4(Z, Z, X, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, B, R, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BBRA => new UInt4(B, B, R, A);

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
		/// Gets a new <see cref="UInt4"/> comprised of Z, Z, Y, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZZYW => new UInt4(Z, Z, Y, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, B, G, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BBGA => new UInt4(B, B, G, A);

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

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, Z, Z, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZZZW => new UInt4(Z, Z, Z, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, B, B, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BBBA => new UInt4(B, B, B, A);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, Z, W, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZZWX => new UInt4(Z, Z, W, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, B, A, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BBAR => new UInt4(B, B, A, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, Z, W, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZZWY => new UInt4(Z, Z, W, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, B, A, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BBAG => new UInt4(B, B, A, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, Z, W, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZZWZ => new UInt4(Z, Z, W, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, B, A, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BBAB => new UInt4(B, B, A, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, Z, W, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZZWW => new UInt4(Z, Z, W, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, B, A, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BBAA => new UInt4(B, B, A, A);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, W, X, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZWXX => new UInt4(Z, W, X, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, A, R, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BARR => new UInt4(B, A, R, R);

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of Z, W, X, Y on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZWXY
		{
			get => new UInt4(Z, W, X, Y); 	
			set
			{
				Z = value.X;
				W = value.Y;
				X = value.Z;
				Y = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of B, A, R, G on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BARG
		{
			get => new UInt4(B, A, R, G);	
			set
			{
				B = value.R;
				A = value.G;
				R = value.B;
				G = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, W, X, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZWXZ => new UInt4(Z, W, X, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, A, R, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BARB => new UInt4(B, A, R, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, W, X, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZWXW => new UInt4(Z, W, X, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, A, R, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BARA => new UInt4(B, A, R, A);

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of Z, W, Y, X on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZWYX
		{
			get => new UInt4(Z, W, Y, X); 	
			set
			{
				Z = value.X;
				W = value.Y;
				Y = value.Z;
				X = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of B, A, G, R on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BAGR
		{
			get => new UInt4(B, A, G, R);	
			set
			{
				B = value.R;
				A = value.G;
				G = value.B;
				R = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, W, Y, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZWYY => new UInt4(Z, W, Y, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, A, G, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BAGG => new UInt4(B, A, G, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, W, Y, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZWYZ => new UInt4(Z, W, Y, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, A, G, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BAGB => new UInt4(B, A, G, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, W, Y, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZWYW => new UInt4(Z, W, Y, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, A, G, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BAGA => new UInt4(B, A, G, A);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, W, Z, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZWZX => new UInt4(Z, W, Z, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, A, B, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BABR => new UInt4(B, A, B, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, W, Z, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZWZY => new UInt4(Z, W, Z, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, A, B, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BABG => new UInt4(B, A, B, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, W, Z, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZWZZ => new UInt4(Z, W, Z, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, A, B, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BABB => new UInt4(B, A, B, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, W, Z, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZWZW => new UInt4(Z, W, Z, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, A, B, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BABA => new UInt4(B, A, B, A);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, W, W, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZWWX => new UInt4(Z, W, W, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, A, A, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BAAR => new UInt4(B, A, A, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, W, W, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZWWY => new UInt4(Z, W, W, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, A, A, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BAAG => new UInt4(B, A, A, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, W, W, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZWWZ => new UInt4(Z, W, W, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, A, A, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BAAB => new UInt4(B, A, A, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of Z, W, W, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ZWWW => new UInt4(Z, W, W, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of B, A, A, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 BAAA => new UInt4(B, A, A, A);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, X, X, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WXXX => new UInt4(W, X, X, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, R, R, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ARRR => new UInt4(A, R, R, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, X, X, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WXXY => new UInt4(W, X, X, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, R, R, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ARRG => new UInt4(A, R, R, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, X, X, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WXXZ => new UInt4(W, X, X, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, R, R, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ARRB => new UInt4(A, R, R, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, X, X, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WXXW => new UInt4(W, X, X, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, R, R, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ARRA => new UInt4(A, R, R, A);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, X, Y, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WXYX => new UInt4(W, X, Y, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, R, G, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ARGR => new UInt4(A, R, G, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, X, Y, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WXYY => new UInt4(W, X, Y, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, R, G, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ARGG => new UInt4(A, R, G, G);

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of W, X, Y, Z on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WXYZ
		{
			get => new UInt4(W, X, Y, Z); 	
			set
			{
				W = value.X;
				X = value.Y;
				Y = value.Z;
				Z = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of A, R, G, B on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ARGB
		{
			get => new UInt4(A, R, G, B);	
			set
			{
				A = value.R;
				R = value.G;
				G = value.B;
				B = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, X, Y, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WXYW => new UInt4(W, X, Y, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, R, G, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ARGA => new UInt4(A, R, G, A);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, X, Z, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WXZX => new UInt4(W, X, Z, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, R, B, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ARBR => new UInt4(A, R, B, R);

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of W, X, Z, Y on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WXZY
		{
			get => new UInt4(W, X, Z, Y); 	
			set
			{
				W = value.X;
				X = value.Y;
				Z = value.Z;
				Y = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of A, R, B, G on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ARBG
		{
			get => new UInt4(A, R, B, G);	
			set
			{
				A = value.R;
				R = value.G;
				B = value.B;
				G = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, X, Z, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WXZZ => new UInt4(W, X, Z, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, R, B, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ARBB => new UInt4(A, R, B, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, X, Z, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WXZW => new UInt4(W, X, Z, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, R, B, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ARBA => new UInt4(A, R, B, A);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, X, W, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WXWX => new UInt4(W, X, W, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, R, A, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ARAR => new UInt4(A, R, A, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, X, W, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WXWY => new UInt4(W, X, W, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, R, A, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ARAG => new UInt4(A, R, A, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, X, W, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WXWZ => new UInt4(W, X, W, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, R, A, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ARAB => new UInt4(A, R, A, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, X, W, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WXWW => new UInt4(W, X, W, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, R, A, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ARAA => new UInt4(A, R, A, A);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, Y, X, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WYXX => new UInt4(W, Y, X, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, G, R, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 AGRR => new UInt4(A, G, R, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, Y, X, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WYXY => new UInt4(W, Y, X, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, G, R, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 AGRG => new UInt4(A, G, R, G);

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of W, Y, X, Z on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WYXZ
		{
			get => new UInt4(W, Y, X, Z); 	
			set
			{
				W = value.X;
				Y = value.Y;
				X = value.Z;
				Z = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of A, G, R, B on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 AGRB
		{
			get => new UInt4(A, G, R, B);	
			set
			{
				A = value.R;
				G = value.G;
				R = value.B;
				B = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, Y, X, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WYXW => new UInt4(W, Y, X, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, G, R, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 AGRA => new UInt4(A, G, R, A);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, Y, Y, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WYYX => new UInt4(W, Y, Y, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, G, G, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 AGGR => new UInt4(A, G, G, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, Y, Y, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WYYY => new UInt4(W, Y, Y, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, G, G, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 AGGG => new UInt4(A, G, G, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, Y, Y, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WYYZ => new UInt4(W, Y, Y, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, G, G, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 AGGB => new UInt4(A, G, G, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, Y, Y, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WYYW => new UInt4(W, Y, Y, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, G, G, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 AGGA => new UInt4(A, G, G, A);

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of W, Y, Z, X on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WYZX
		{
			get => new UInt4(W, Y, Z, X); 	
			set
			{
				W = value.X;
				Y = value.Y;
				Z = value.Z;
				X = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of A, G, B, R on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 AGBR
		{
			get => new UInt4(A, G, B, R);	
			set
			{
				A = value.R;
				G = value.G;
				B = value.B;
				R = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, Y, Z, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WYZY => new UInt4(W, Y, Z, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, G, B, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 AGBG => new UInt4(A, G, B, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, Y, Z, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WYZZ => new UInt4(W, Y, Z, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, G, B, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 AGBB => new UInt4(A, G, B, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, Y, Z, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WYZW => new UInt4(W, Y, Z, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, G, B, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 AGBA => new UInt4(A, G, B, A);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, Y, W, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WYWX => new UInt4(W, Y, W, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, G, A, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 AGAR => new UInt4(A, G, A, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, Y, W, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WYWY => new UInt4(W, Y, W, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, G, A, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 AGAG => new UInt4(A, G, A, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, Y, W, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WYWZ => new UInt4(W, Y, W, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, G, A, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 AGAB => new UInt4(A, G, A, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, Y, W, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WYWW => new UInt4(W, Y, W, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, G, A, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 AGAA => new UInt4(A, G, A, A);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, Z, X, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WZXX => new UInt4(W, Z, X, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, B, R, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ABRR => new UInt4(A, B, R, R);

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of W, Z, X, Y on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WZXY
		{
			get => new UInt4(W, Z, X, Y); 	
			set
			{
				W = value.X;
				Z = value.Y;
				X = value.Z;
				Y = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of A, B, R, G on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ABRG
		{
			get => new UInt4(A, B, R, G);	
			set
			{
				A = value.R;
				B = value.G;
				R = value.B;
				G = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, Z, X, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WZXZ => new UInt4(W, Z, X, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, B, R, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ABRB => new UInt4(A, B, R, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, Z, X, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WZXW => new UInt4(W, Z, X, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, B, R, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ABRA => new UInt4(A, B, R, A);

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of W, Z, Y, X on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WZYX
		{
			get => new UInt4(W, Z, Y, X); 	
			set
			{
				W = value.X;
				Z = value.Y;
				Y = value.Z;
				X = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="UInt4"/> comprised of A, B, G, R on the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ABGR
		{
			get => new UInt4(A, B, G, R);	
			set
			{
				A = value.R;
				B = value.G;
				G = value.B;
				R = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, Z, Y, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WZYY => new UInt4(W, Z, Y, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, B, G, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ABGG => new UInt4(A, B, G, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, Z, Y, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WZYZ => new UInt4(W, Z, Y, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, B, G, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ABGB => new UInt4(A, B, G, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, Z, Y, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WZYW => new UInt4(W, Z, Y, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, B, G, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ABGA => new UInt4(A, B, G, A);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, Z, Z, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WZZX => new UInt4(W, Z, Z, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, B, B, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ABBR => new UInt4(A, B, B, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, Z, Z, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WZZY => new UInt4(W, Z, Z, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, B, B, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ABBG => new UInt4(A, B, B, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, Z, Z, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WZZZ => new UInt4(W, Z, Z, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, B, B, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ABBB => new UInt4(A, B, B, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, Z, Z, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WZZW => new UInt4(W, Z, Z, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, B, B, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ABBA => new UInt4(A, B, B, A);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, Z, W, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WZWX => new UInt4(W, Z, W, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, B, A, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ABAR => new UInt4(A, B, A, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, Z, W, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WZWY => new UInt4(W, Z, W, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, B, A, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ABAG => new UInt4(A, B, A, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, Z, W, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WZWZ => new UInt4(W, Z, W, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, B, A, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ABAB => new UInt4(A, B, A, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, Z, W, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WZWW => new UInt4(W, Z, W, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, B, A, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 ABAA => new UInt4(A, B, A, A);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, W, X, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WWXX => new UInt4(W, W, X, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, A, R, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 AARR => new UInt4(A, A, R, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, W, X, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WWXY => new UInt4(W, W, X, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, A, R, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 AARG => new UInt4(A, A, R, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, W, X, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WWXZ => new UInt4(W, W, X, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, A, R, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 AARB => new UInt4(A, A, R, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, W, X, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WWXW => new UInt4(W, W, X, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, A, R, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 AARA => new UInt4(A, A, R, A);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, W, Y, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WWYX => new UInt4(W, W, Y, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, A, G, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 AAGR => new UInt4(A, A, G, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, W, Y, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WWYY => new UInt4(W, W, Y, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, A, G, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 AAGG => new UInt4(A, A, G, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, W, Y, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WWYZ => new UInt4(W, W, Y, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, A, G, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 AAGB => new UInt4(A, A, G, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, W, Y, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WWYW => new UInt4(W, W, Y, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, A, G, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 AAGA => new UInt4(A, A, G, A);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, W, Z, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WWZX => new UInt4(W, W, Z, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, A, B, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 AABR => new UInt4(A, A, B, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, W, Z, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WWZY => new UInt4(W, W, Z, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, A, B, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 AABG => new UInt4(A, A, B, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, W, Z, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WWZZ => new UInt4(W, W, Z, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, A, B, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 AABB => new UInt4(A, A, B, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, W, Z, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WWZW => new UInt4(W, W, Z, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, A, B, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 AABA => new UInt4(A, A, B, A);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, W, W, X from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WWWX => new UInt4(W, W, W, X);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, A, A, R from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 AAAR => new UInt4(A, A, A, R);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, W, W, Y from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WWWY => new UInt4(W, W, W, Y);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, A, A, G from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 AAAG => new UInt4(A, A, A, G);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, W, W, Z from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WWWZ => new UInt4(W, W, W, Z);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, A, A, B from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 AAAB => new UInt4(A, A, A, B);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of W, W, W, W from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 WWWW => new UInt4(W, W, W, W);

		/// <summary>
		/// Gets a new <see cref="UInt4"/> comprised of A, A, A, A from the current <see cref="UInt4"/>.
		/// </summary>
		public UInt4 AAAA => new UInt4(A, A, A, A);

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

		public uint A
		{
			get => W;
			set => W = value;
		}

		public static UInt4 operator +(UInt4 a, UInt4 b)
		{
			return new UInt4()
			{
				X = a.X + b.X,
				Y = a.Y + b.Y,
				Z = a.Z + b.Z,
				W = a.W + b.W,
			};
		}
		public static UInt4 operator +(UInt4 a, int b)
		{
			return new UInt4()
			{
				X = (uint)(a.X + b),
				Y = (uint)(a.Y + b),
				Z = (uint)(a.Z + b),
				W = (uint)(a.W + b),
			};
		}

		public static UInt4 operator +(int a, UInt4 b)
		{
			return new UInt4()
			{
				X = (uint)(a + b.X),
				Y = (uint)(a + b.Y),
				Z = (uint)(a + b.Z),
				W = (uint)(a + b.W),
			};
		}
		public static UInt4 operator +(UInt4 a, float b)
		{
			return new UInt4()
			{
				X = (uint)(a.X + b),
				Y = (uint)(a.Y + b),
				Z = (uint)(a.Z + b),
				W = (uint)(a.W + b),
			};
		}

		public static UInt4 operator +(float a, UInt4 b)
		{
			return new UInt4()
			{
				X = (uint)(a + b.X),
				Y = (uint)(a + b.Y),
				Z = (uint)(a + b.Z),
				W = (uint)(a + b.W),
			};
		}
		public static UInt4 operator +(UInt4 a, double b)
		{
			return new UInt4()
			{
				X = (uint)(a.X + b),
				Y = (uint)(a.Y + b),
				Z = (uint)(a.Z + b),
				W = (uint)(a.W + b),
			};
		}

		public static UInt4 operator +(double a, UInt4 b)
		{
			return new UInt4()
			{
				X = (uint)(a + b.X),
				Y = (uint)(a + b.Y),
				Z = (uint)(a + b.Z),
				W = (uint)(a + b.W),
			};
		}
		public static UInt4 operator -(UInt4 a, UInt4 b)
		{
			return new UInt4()
			{
				X = a.X - b.X,
				Y = a.Y - b.Y,
				Z = a.Z - b.Z,
				W = a.W - b.W,
			};
		}
		public static UInt4 operator -(UInt4 a, int b)
		{
			return new UInt4()
			{
				X = (uint)(a.X - b),
				Y = (uint)(a.Y - b),
				Z = (uint)(a.Z - b),
				W = (uint)(a.W - b),
			};
		}

		public static UInt4 operator -(int a, UInt4 b)
		{
			return new UInt4()
			{
				X = (uint)(a - b.X),
				Y = (uint)(a - b.Y),
				Z = (uint)(a - b.Z),
				W = (uint)(a - b.W),
			};
		}
		public static UInt4 operator -(UInt4 a, float b)
		{
			return new UInt4()
			{
				X = (uint)(a.X - b),
				Y = (uint)(a.Y - b),
				Z = (uint)(a.Z - b),
				W = (uint)(a.W - b),
			};
		}

		public static UInt4 operator -(float a, UInt4 b)
		{
			return new UInt4()
			{
				X = (uint)(a - b.X),
				Y = (uint)(a - b.Y),
				Z = (uint)(a - b.Z),
				W = (uint)(a - b.W),
			};
		}
		public static UInt4 operator -(UInt4 a, double b)
		{
			return new UInt4()
			{
				X = (uint)(a.X - b),
				Y = (uint)(a.Y - b),
				Z = (uint)(a.Z - b),
				W = (uint)(a.W - b),
			};
		}

		public static UInt4 operator -(double a, UInt4 b)
		{
			return new UInt4()
			{
				X = (uint)(a - b.X),
				Y = (uint)(a - b.Y),
				Z = (uint)(a - b.Z),
				W = (uint)(a - b.W),
			};
		}
		public static UInt4 operator *(UInt4 a, UInt4 b)
		{
			return new UInt4()
			{
				X = a.X * b.X,
				Y = a.Y * b.Y,
				Z = a.Z * b.Z,
				W = a.W * b.W,
			};
		}
		public static UInt4 operator *(UInt4 a, int b)
		{
			return new UInt4()
			{
				X = (uint)(a.X * b),
				Y = (uint)(a.Y * b),
				Z = (uint)(a.Z * b),
				W = (uint)(a.W * b),
			};
		}

		public static UInt4 operator *(int a, UInt4 b)
		{
			return new UInt4()
			{
				X = (uint)(a * b.X),
				Y = (uint)(a * b.Y),
				Z = (uint)(a * b.Z),
				W = (uint)(a * b.W),
			};
		}
		public static UInt4 operator *(UInt4 a, float b)
		{
			return new UInt4()
			{
				X = (uint)(a.X * b),
				Y = (uint)(a.Y * b),
				Z = (uint)(a.Z * b),
				W = (uint)(a.W * b),
			};
		}

		public static UInt4 operator *(float a, UInt4 b)
		{
			return new UInt4()
			{
				X = (uint)(a * b.X),
				Y = (uint)(a * b.Y),
				Z = (uint)(a * b.Z),
				W = (uint)(a * b.W),
			};
		}
		public static UInt4 operator *(UInt4 a, double b)
		{
			return new UInt4()
			{
				X = (uint)(a.X * b),
				Y = (uint)(a.Y * b),
				Z = (uint)(a.Z * b),
				W = (uint)(a.W * b),
			};
		}

		public static UInt4 operator *(double a, UInt4 b)
		{
			return new UInt4()
			{
				X = (uint)(a * b.X),
				Y = (uint)(a * b.Y),
				Z = (uint)(a * b.Z),
				W = (uint)(a * b.W),
			};
		}
		public static UInt4 operator /(UInt4 a, UInt4 b)
		{
			return new UInt4()
			{
				X = a.X / b.X,
				Y = a.Y / b.Y,
				Z = a.Z / b.Z,
				W = a.W / b.W,
			};
		}
		public static UInt4 operator /(UInt4 a, int b)
		{
			return new UInt4()
			{
				X = (uint)(a.X / b),
				Y = (uint)(a.Y / b),
				Z = (uint)(a.Z / b),
				W = (uint)(a.W / b),
			};
		}

		public static UInt4 operator /(int a, UInt4 b)
		{
			return new UInt4()
			{
				X = (uint)(a / b.X),
				Y = (uint)(a / b.Y),
				Z = (uint)(a / b.Z),
				W = (uint)(a / b.W),
			};
		}
		public static UInt4 operator /(UInt4 a, float b)
		{
			return new UInt4()
			{
				X = (uint)(a.X / b),
				Y = (uint)(a.Y / b),
				Z = (uint)(a.Z / b),
				W = (uint)(a.W / b),
			};
		}

		public static UInt4 operator /(float a, UInt4 b)
		{
			return new UInt4()
			{
				X = (uint)(a / b.X),
				Y = (uint)(a / b.Y),
				Z = (uint)(a / b.Z),
				W = (uint)(a / b.W),
			};
		}
		public static UInt4 operator /(UInt4 a, double b)
		{
			return new UInt4()
			{
				X = (uint)(a.X / b),
				Y = (uint)(a.Y / b),
				Z = (uint)(a.Z / b),
				W = (uint)(a.W / b),
			};
		}

		public static UInt4 operator /(double a, UInt4 b)
		{
			return new UInt4()
			{
				X = (uint)(a / b.X),
				Y = (uint)(a / b.Y),
				Z = (uint)(a / b.Z),
				W = (uint)(a / b.W),
			};
		}
		public static explicit operator Vector4(UInt4 val)
		{
			return new Vector4()
			{
				X = (float)val.X,
				Y = (float)val.Y,
				Z = (float)val.Z,
				W = (float)val.W,
			};
		}

		public static explicit operator Int4(UInt4 val)
		{
			return new Int4()
			{
				X = (int)val.X,
				Y = (int)val.Y,
				Z = (int)val.Z,
				W = (int)val.W,
			};
		}

		public static explicit operator Double4(UInt4 val)
		{
			return new Double4()
			{
				X = (double)val.X,
				Y = (double)val.Y,
				Z = (double)val.Z,
				W = (double)val.W,
			};
		}

	}
}
