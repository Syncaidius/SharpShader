using System;
using System.Runtime.InteropServices;

namespace SharpShader
{
	[StructLayout(LayoutKind.Sequential)]
	[Serializable]
	public struct Double4 : IVector<double>
	{
		/// <summary>
		///	The number of elements (components) in a <see cref="Double4"/>.
		/// </summary>
		public const int ELEMENT_COUNT = 4;
		
		/// <summary>
		///	The size of a <see cref="Double4"/>, in bytes.
		/// </summary>
		public const int ELEMENT_SIZE = sizeof(double);

		/// <summary>
		///	The size of a single element (component) within a <see cref="Double4"/>, in bytes.
		/// </summary>
		public const int SIZE_OF = ELEMENT_COUNT * ELEMENT_SIZE;

		/// <summary>
		///	Gets the <see cref="Type"/> of each element in a <see cref="Double4"/>.
		/// </summary>
		public static readonly Type ElementType = typeof(double);

        /// <summary>
        /// The X component.
        /// </summary>
		public double X;

        /// <summary>
        /// The Y component.
        /// </summary>
		public double Y;

        /// <summary>
        /// The Z component.
        /// </summary>
		public double Z;

        /// <summary>
        /// The W component.
        /// </summary>
		public double W;

        /// <summary>
        /// Creates a new instance of <see cref="Double4"/>.
        /// </summary>
		public Double4(double x, double y, double z, double w)
		{
			X = x;
			Y = y;
			Z = z;
			W = w;
		}

        /// <summary>
        /// Creates a new instance of <see cref="Double4"/>.
        /// </summary>
		public Double4(Double3 p, double w)
		{
			X = p.X;
			Y = p.Y;
			Z = p.Z;
			W = w;
		}

        /// <summary>
        /// Creates a new instance of <see cref="Double4"/>.
        /// </summary>
		public Double4(double x, Double3 p)
		{
			X = x;
			Y = p.X;
			Z = p.Y;
			W = p.Z;
		}

        /// <summary>
        /// Creates a new instance of <see cref="Double4"/>.
        /// </summary>
		public Double4(Double2 p, double z, double w)
		{
			X = p.X;
			Y = p.Y;
			Z = z;
			W = w;
		}

        /// <summary>
        /// Creates a new instance of <see cref="Double4"/>.
        /// </summary>
		public Double4(double x, Double2 p, double w)
		{
			X = x;
			Y = p.X;
			Z = p.Y;
			W = w;
		}

        /// <summary>
        /// Creates a new instance of <see cref="Double4"/>.
        /// </summary>
		public Double4(double x, double y, Double2 p)
		{
			X = x;
			Y = y;
			Z = p.X;
			W = p.Y;
		}

		/// <summary>
		/// Gets or sets a component at the specified index for the current <see cref="Double4"/> .
		/// </summary>
		public double this[int index]
		{
			get
			{
				switch(index)
				{
					case 0: return X;
					case 1: return Y;
					case 2: return Z;
					case 3: return W;
					default: throw new IndexOutOfRangeException("The maximum index of a Double4 is 3.");
				}
			}
		}
		/// <summary>
		/// Gets a new <see cref="Double2"/> comprised of X, X from the current <see cref="Double2"/>.
		/// </summary>
		public Double2 XX => new Double2(X, X);

		/// <summary>
		/// Gets a new <see cref="Double2"/> comprised of R, R from the current <see cref="Double2"/>.
		/// </summary>
		public Double2 RR => new Double2(R, R);

		/// <summary>
		/// Gets or sets a <see cref="Double2"/> comprised of X, Y on the current <see cref="Double2"/>.
		/// </summary>
		public Double2 XY
		{
			get => new Double2(X, Y); 	
			set
			{
				X = value.X;
				Y = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double2"/> comprised of R, G on the current <see cref="Double2"/>.
		/// </summary>
		public Double2 RG
		{
			get => new Double2(R, G);	
			set
			{
				R = value.R;
				G = value.G;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double2"/> comprised of X, Z on the current <see cref="Double2"/>.
		/// </summary>
		public Double2 XZ
		{
			get => new Double2(X, Z); 	
			set
			{
				X = value.X;
				Z = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double2"/> comprised of R, B on the current <see cref="Double2"/>.
		/// </summary>
		public Double2 RB
		{
			get => new Double2(R, B);	
			set
			{
				R = value.R;
				B = value.G;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double2"/> comprised of X, W on the current <see cref="Double2"/>.
		/// </summary>
		public Double2 XW
		{
			get => new Double2(X, W); 	
			set
			{
				X = value.X;
				W = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double2"/> comprised of R, A on the current <see cref="Double2"/>.
		/// </summary>
		public Double2 RA
		{
			get => new Double2(R, A);	
			set
			{
				R = value.R;
				A = value.G;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double2"/> comprised of Y, X on the current <see cref="Double2"/>.
		/// </summary>
		public Double2 YX
		{
			get => new Double2(Y, X); 	
			set
			{
				Y = value.X;
				X = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double2"/> comprised of G, R on the current <see cref="Double2"/>.
		/// </summary>
		public Double2 GR
		{
			get => new Double2(G, R);	
			set
			{
				G = value.R;
				R = value.G;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double2"/> comprised of Y, Y from the current <see cref="Double2"/>.
		/// </summary>
		public Double2 YY => new Double2(Y, Y);

		/// <summary>
		/// Gets a new <see cref="Double2"/> comprised of G, G from the current <see cref="Double2"/>.
		/// </summary>
		public Double2 GG => new Double2(G, G);

		/// <summary>
		/// Gets or sets a <see cref="Double2"/> comprised of Y, Z on the current <see cref="Double2"/>.
		/// </summary>
		public Double2 YZ
		{
			get => new Double2(Y, Z); 	
			set
			{
				Y = value.X;
				Z = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double2"/> comprised of G, B on the current <see cref="Double2"/>.
		/// </summary>
		public Double2 GB
		{
			get => new Double2(G, B);	
			set
			{
				G = value.R;
				B = value.G;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double2"/> comprised of Y, W on the current <see cref="Double2"/>.
		/// </summary>
		public Double2 YW
		{
			get => new Double2(Y, W); 	
			set
			{
				Y = value.X;
				W = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double2"/> comprised of G, A on the current <see cref="Double2"/>.
		/// </summary>
		public Double2 GA
		{
			get => new Double2(G, A);	
			set
			{
				G = value.R;
				A = value.G;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double2"/> comprised of Z, X on the current <see cref="Double2"/>.
		/// </summary>
		public Double2 ZX
		{
			get => new Double2(Z, X); 	
			set
			{
				Z = value.X;
				X = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double2"/> comprised of B, R on the current <see cref="Double2"/>.
		/// </summary>
		public Double2 BR
		{
			get => new Double2(B, R);	
			set
			{
				B = value.R;
				R = value.G;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double2"/> comprised of Z, Y on the current <see cref="Double2"/>.
		/// </summary>
		public Double2 ZY
		{
			get => new Double2(Z, Y); 	
			set
			{
				Z = value.X;
				Y = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double2"/> comprised of B, G on the current <see cref="Double2"/>.
		/// </summary>
		public Double2 BG
		{
			get => new Double2(B, G);	
			set
			{
				B = value.R;
				G = value.G;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double2"/> comprised of Z, Z from the current <see cref="Double2"/>.
		/// </summary>
		public Double2 ZZ => new Double2(Z, Z);

		/// <summary>
		/// Gets a new <see cref="Double2"/> comprised of B, B from the current <see cref="Double2"/>.
		/// </summary>
		public Double2 BB => new Double2(B, B);

		/// <summary>
		/// Gets or sets a <see cref="Double2"/> comprised of Z, W on the current <see cref="Double2"/>.
		/// </summary>
		public Double2 ZW
		{
			get => new Double2(Z, W); 	
			set
			{
				Z = value.X;
				W = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double2"/> comprised of B, A on the current <see cref="Double2"/>.
		/// </summary>
		public Double2 BA
		{
			get => new Double2(B, A);	
			set
			{
				B = value.R;
				A = value.G;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double2"/> comprised of W, X on the current <see cref="Double2"/>.
		/// </summary>
		public Double2 WX
		{
			get => new Double2(W, X); 	
			set
			{
				W = value.X;
				X = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double2"/> comprised of A, R on the current <see cref="Double2"/>.
		/// </summary>
		public Double2 AR
		{
			get => new Double2(A, R);	
			set
			{
				A = value.R;
				R = value.G;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double2"/> comprised of W, Y on the current <see cref="Double2"/>.
		/// </summary>
		public Double2 WY
		{
			get => new Double2(W, Y); 	
			set
			{
				W = value.X;
				Y = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double2"/> comprised of A, G on the current <see cref="Double2"/>.
		/// </summary>
		public Double2 AG
		{
			get => new Double2(A, G);	
			set
			{
				A = value.R;
				G = value.G;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double2"/> comprised of W, Z on the current <see cref="Double2"/>.
		/// </summary>
		public Double2 WZ
		{
			get => new Double2(W, Z); 	
			set
			{
				W = value.X;
				Z = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double2"/> comprised of A, B on the current <see cref="Double2"/>.
		/// </summary>
		public Double2 AB
		{
			get => new Double2(A, B);	
			set
			{
				A = value.R;
				B = value.G;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double2"/> comprised of W, W from the current <see cref="Double2"/>.
		/// </summary>
		public Double2 WW => new Double2(W, W);

		/// <summary>
		/// Gets a new <see cref="Double2"/> comprised of A, A from the current <see cref="Double2"/>.
		/// </summary>
		public Double2 AA => new Double2(A, A);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of X, X, X from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 XXX => new Double3(X, X, X);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of R, R, R from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 RRR => new Double3(R, R, R);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of X, X, Y from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 XXY => new Double3(X, X, Y);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of R, R, G from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 RRG => new Double3(R, R, G);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of X, X, Z from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 XXZ => new Double3(X, X, Z);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of R, R, B from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 RRB => new Double3(R, R, B);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of X, X, W from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 XXW => new Double3(X, X, W);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of R, R, A from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 RRA => new Double3(R, R, A);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of X, Y, X from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 XYX => new Double3(X, Y, X);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of R, G, R from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 RGR => new Double3(R, G, R);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of X, Y, Y from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 XYY => new Double3(X, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of R, G, G from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 RGG => new Double3(R, G, G);

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of X, Y, Z on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 XYZ
		{
			get => new Double3(X, Y, Z); 	
			set
			{
				X = value.X;
				Y = value.Y;
				Z = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of R, G, B on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 RGB
		{
			get => new Double3(R, G, B);	
			set
			{
				R = value.R;
				G = value.G;
				B = value.B;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of X, Y, W on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 XYW
		{
			get => new Double3(X, Y, W); 	
			set
			{
				X = value.X;
				Y = value.Y;
				W = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of R, G, A on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 RGA
		{
			get => new Double3(R, G, A);	
			set
			{
				R = value.R;
				G = value.G;
				A = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of X, Z, X from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 XZX => new Double3(X, Z, X);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of R, B, R from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 RBR => new Double3(R, B, R);

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of X, Z, Y on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 XZY
		{
			get => new Double3(X, Z, Y); 	
			set
			{
				X = value.X;
				Z = value.Y;
				Y = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of R, B, G on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 RBG
		{
			get => new Double3(R, B, G);	
			set
			{
				R = value.R;
				B = value.G;
				G = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of X, Z, Z from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 XZZ => new Double3(X, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of R, B, B from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 RBB => new Double3(R, B, B);

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of X, Z, W on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 XZW
		{
			get => new Double3(X, Z, W); 	
			set
			{
				X = value.X;
				Z = value.Y;
				W = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of R, B, A on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 RBA
		{
			get => new Double3(R, B, A);	
			set
			{
				R = value.R;
				B = value.G;
				A = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of X, W, X from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 XWX => new Double3(X, W, X);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of R, A, R from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 RAR => new Double3(R, A, R);

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of X, W, Y on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 XWY
		{
			get => new Double3(X, W, Y); 	
			set
			{
				X = value.X;
				W = value.Y;
				Y = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of R, A, G on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 RAG
		{
			get => new Double3(R, A, G);	
			set
			{
				R = value.R;
				A = value.G;
				G = value.B;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of X, W, Z on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 XWZ
		{
			get => new Double3(X, W, Z); 	
			set
			{
				X = value.X;
				W = value.Y;
				Z = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of R, A, B on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 RAB
		{
			get => new Double3(R, A, B);	
			set
			{
				R = value.R;
				A = value.G;
				B = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of X, W, W from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 XWW => new Double3(X, W, W);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of R, A, A from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 RAA => new Double3(R, A, A);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of Y, X, X from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 YXX => new Double3(Y, X, X);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of G, R, R from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 GRR => new Double3(G, R, R);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of Y, X, Y from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 YXY => new Double3(Y, X, Y);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of G, R, G from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 GRG => new Double3(G, R, G);

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of Y, X, Z on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 YXZ
		{
			get => new Double3(Y, X, Z); 	
			set
			{
				Y = value.X;
				X = value.Y;
				Z = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of G, R, B on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 GRB
		{
			get => new Double3(G, R, B);	
			set
			{
				G = value.R;
				R = value.G;
				B = value.B;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of Y, X, W on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 YXW
		{
			get => new Double3(Y, X, W); 	
			set
			{
				Y = value.X;
				X = value.Y;
				W = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of G, R, A on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 GRA
		{
			get => new Double3(G, R, A);	
			set
			{
				G = value.R;
				R = value.G;
				A = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of Y, Y, X from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 YYX => new Double3(Y, Y, X);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of G, G, R from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 GGR => new Double3(G, G, R);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of Y, Y, Y from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 YYY => new Double3(Y, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of G, G, G from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 GGG => new Double3(G, G, G);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of Y, Y, Z from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 YYZ => new Double3(Y, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of G, G, B from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 GGB => new Double3(G, G, B);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of Y, Y, W from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 YYW => new Double3(Y, Y, W);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of G, G, A from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 GGA => new Double3(G, G, A);

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of Y, Z, X on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 YZX
		{
			get => new Double3(Y, Z, X); 	
			set
			{
				Y = value.X;
				Z = value.Y;
				X = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of G, B, R on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 GBR
		{
			get => new Double3(G, B, R);	
			set
			{
				G = value.R;
				B = value.G;
				R = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of Y, Z, Y from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 YZY => new Double3(Y, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of G, B, G from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 GBG => new Double3(G, B, G);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of Y, Z, Z from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 YZZ => new Double3(Y, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of G, B, B from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 GBB => new Double3(G, B, B);

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of Y, Z, W on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 YZW
		{
			get => new Double3(Y, Z, W); 	
			set
			{
				Y = value.X;
				Z = value.Y;
				W = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of G, B, A on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 GBA
		{
			get => new Double3(G, B, A);	
			set
			{
				G = value.R;
				B = value.G;
				A = value.B;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of Y, W, X on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 YWX
		{
			get => new Double3(Y, W, X); 	
			set
			{
				Y = value.X;
				W = value.Y;
				X = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of G, A, R on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 GAR
		{
			get => new Double3(G, A, R);	
			set
			{
				G = value.R;
				A = value.G;
				R = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of Y, W, Y from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 YWY => new Double3(Y, W, Y);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of G, A, G from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 GAG => new Double3(G, A, G);

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of Y, W, Z on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 YWZ
		{
			get => new Double3(Y, W, Z); 	
			set
			{
				Y = value.X;
				W = value.Y;
				Z = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of G, A, B on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 GAB
		{
			get => new Double3(G, A, B);	
			set
			{
				G = value.R;
				A = value.G;
				B = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of Y, W, W from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 YWW => new Double3(Y, W, W);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of G, A, A from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 GAA => new Double3(G, A, A);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of Z, X, X from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 ZXX => new Double3(Z, X, X);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of B, R, R from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 BRR => new Double3(B, R, R);

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of Z, X, Y on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 ZXY
		{
			get => new Double3(Z, X, Y); 	
			set
			{
				Z = value.X;
				X = value.Y;
				Y = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of B, R, G on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 BRG
		{
			get => new Double3(B, R, G);	
			set
			{
				B = value.R;
				R = value.G;
				G = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of Z, X, Z from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 ZXZ => new Double3(Z, X, Z);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of B, R, B from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 BRB => new Double3(B, R, B);

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of Z, X, W on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 ZXW
		{
			get => new Double3(Z, X, W); 	
			set
			{
				Z = value.X;
				X = value.Y;
				W = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of B, R, A on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 BRA
		{
			get => new Double3(B, R, A);	
			set
			{
				B = value.R;
				R = value.G;
				A = value.B;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of Z, Y, X on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 ZYX
		{
			get => new Double3(Z, Y, X); 	
			set
			{
				Z = value.X;
				Y = value.Y;
				X = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of B, G, R on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 BGR
		{
			get => new Double3(B, G, R);	
			set
			{
				B = value.R;
				G = value.G;
				R = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of Z, Y, Y from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 ZYY => new Double3(Z, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of B, G, G from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 BGG => new Double3(B, G, G);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of Z, Y, Z from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 ZYZ => new Double3(Z, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of B, G, B from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 BGB => new Double3(B, G, B);

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of Z, Y, W on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 ZYW
		{
			get => new Double3(Z, Y, W); 	
			set
			{
				Z = value.X;
				Y = value.Y;
				W = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of B, G, A on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 BGA
		{
			get => new Double3(B, G, A);	
			set
			{
				B = value.R;
				G = value.G;
				A = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of Z, Z, X from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 ZZX => new Double3(Z, Z, X);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of B, B, R from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 BBR => new Double3(B, B, R);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of Z, Z, Y from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 ZZY => new Double3(Z, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of B, B, G from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 BBG => new Double3(B, B, G);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of Z, Z, Z from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 ZZZ => new Double3(Z, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of B, B, B from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 BBB => new Double3(B, B, B);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of Z, Z, W from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 ZZW => new Double3(Z, Z, W);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of B, B, A from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 BBA => new Double3(B, B, A);

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of Z, W, X on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 ZWX
		{
			get => new Double3(Z, W, X); 	
			set
			{
				Z = value.X;
				W = value.Y;
				X = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of B, A, R on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 BAR
		{
			get => new Double3(B, A, R);	
			set
			{
				B = value.R;
				A = value.G;
				R = value.B;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of Z, W, Y on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 ZWY
		{
			get => new Double3(Z, W, Y); 	
			set
			{
				Z = value.X;
				W = value.Y;
				Y = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of B, A, G on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 BAG
		{
			get => new Double3(B, A, G);	
			set
			{
				B = value.R;
				A = value.G;
				G = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of Z, W, Z from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 ZWZ => new Double3(Z, W, Z);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of B, A, B from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 BAB => new Double3(B, A, B);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of Z, W, W from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 ZWW => new Double3(Z, W, W);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of B, A, A from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 BAA => new Double3(B, A, A);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of W, X, X from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 WXX => new Double3(W, X, X);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of A, R, R from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 ARR => new Double3(A, R, R);

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of W, X, Y on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 WXY
		{
			get => new Double3(W, X, Y); 	
			set
			{
				W = value.X;
				X = value.Y;
				Y = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of A, R, G on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 ARG
		{
			get => new Double3(A, R, G);	
			set
			{
				A = value.R;
				R = value.G;
				G = value.B;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of W, X, Z on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 WXZ
		{
			get => new Double3(W, X, Z); 	
			set
			{
				W = value.X;
				X = value.Y;
				Z = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of A, R, B on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 ARB
		{
			get => new Double3(A, R, B);	
			set
			{
				A = value.R;
				R = value.G;
				B = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of W, X, W from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 WXW => new Double3(W, X, W);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of A, R, A from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 ARA => new Double3(A, R, A);

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of W, Y, X on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 WYX
		{
			get => new Double3(W, Y, X); 	
			set
			{
				W = value.X;
				Y = value.Y;
				X = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of A, G, R on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 AGR
		{
			get => new Double3(A, G, R);	
			set
			{
				A = value.R;
				G = value.G;
				R = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of W, Y, Y from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 WYY => new Double3(W, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of A, G, G from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 AGG => new Double3(A, G, G);

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of W, Y, Z on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 WYZ
		{
			get => new Double3(W, Y, Z); 	
			set
			{
				W = value.X;
				Y = value.Y;
				Z = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of A, G, B on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 AGB
		{
			get => new Double3(A, G, B);	
			set
			{
				A = value.R;
				G = value.G;
				B = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of W, Y, W from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 WYW => new Double3(W, Y, W);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of A, G, A from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 AGA => new Double3(A, G, A);

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of W, Z, X on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 WZX
		{
			get => new Double3(W, Z, X); 	
			set
			{
				W = value.X;
				Z = value.Y;
				X = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of A, B, R on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 ABR
		{
			get => new Double3(A, B, R);	
			set
			{
				A = value.R;
				B = value.G;
				R = value.B;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of W, Z, Y on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 WZY
		{
			get => new Double3(W, Z, Y); 	
			set
			{
				W = value.X;
				Z = value.Y;
				Y = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double3"/> comprised of A, B, G on the current <see cref="Double3"/>.
		/// </summary>
		public Double3 ABG
		{
			get => new Double3(A, B, G);	
			set
			{
				A = value.R;
				B = value.G;
				G = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of W, Z, Z from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 WZZ => new Double3(W, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of A, B, B from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 ABB => new Double3(A, B, B);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of W, Z, W from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 WZW => new Double3(W, Z, W);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of A, B, A from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 ABA => new Double3(A, B, A);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of W, W, X from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 WWX => new Double3(W, W, X);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of A, A, R from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 AAR => new Double3(A, A, R);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of W, W, Y from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 WWY => new Double3(W, W, Y);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of A, A, G from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 AAG => new Double3(A, A, G);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of W, W, Z from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 WWZ => new Double3(W, W, Z);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of A, A, B from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 AAB => new Double3(A, A, B);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of W, W, W from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 WWW => new Double3(W, W, W);

		/// <summary>
		/// Gets a new <see cref="Double3"/> comprised of A, A, A from the current <see cref="Double3"/>.
		/// </summary>
		public Double3 AAA => new Double3(A, A, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, X, X, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XXXX => new Double4(X, X, X, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, R, R, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RRRR => new Double4(R, R, R, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, X, X, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XXXY => new Double4(X, X, X, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, R, R, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RRRG => new Double4(R, R, R, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, X, X, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XXXZ => new Double4(X, X, X, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, R, R, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RRRB => new Double4(R, R, R, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, X, X, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XXXW => new Double4(X, X, X, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, R, R, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RRRA => new Double4(R, R, R, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, X, Y, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XXYX => new Double4(X, X, Y, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, R, G, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RRGR => new Double4(R, R, G, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, X, Y, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XXYY => new Double4(X, X, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, R, G, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RRGG => new Double4(R, R, G, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, X, Y, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XXYZ => new Double4(X, X, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, R, G, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RRGB => new Double4(R, R, G, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, X, Y, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XXYW => new Double4(X, X, Y, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, R, G, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RRGA => new Double4(R, R, G, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, X, Z, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XXZX => new Double4(X, X, Z, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, R, B, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RRBR => new Double4(R, R, B, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, X, Z, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XXZY => new Double4(X, X, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, R, B, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RRBG => new Double4(R, R, B, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, X, Z, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XXZZ => new Double4(X, X, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, R, B, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RRBB => new Double4(R, R, B, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, X, Z, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XXZW => new Double4(X, X, Z, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, R, B, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RRBA => new Double4(R, R, B, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, X, W, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XXWX => new Double4(X, X, W, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, R, A, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RRAR => new Double4(R, R, A, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, X, W, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XXWY => new Double4(X, X, W, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, R, A, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RRAG => new Double4(R, R, A, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, X, W, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XXWZ => new Double4(X, X, W, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, R, A, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RRAB => new Double4(R, R, A, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, X, W, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XXWW => new Double4(X, X, W, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, R, A, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RRAA => new Double4(R, R, A, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, Y, X, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XYXX => new Double4(X, Y, X, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, G, R, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RGRR => new Double4(R, G, R, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, Y, X, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XYXY => new Double4(X, Y, X, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, G, R, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RGRG => new Double4(R, G, R, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, Y, X, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XYXZ => new Double4(X, Y, X, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, G, R, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RGRB => new Double4(R, G, R, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, Y, X, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XYXW => new Double4(X, Y, X, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, G, R, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RGRA => new Double4(R, G, R, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, Y, Y, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XYYX => new Double4(X, Y, Y, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, G, G, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RGGR => new Double4(R, G, G, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, Y, Y, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XYYY => new Double4(X, Y, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, G, G, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RGGG => new Double4(R, G, G, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, Y, Y, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XYYZ => new Double4(X, Y, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, G, G, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RGGB => new Double4(R, G, G, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, Y, Y, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XYYW => new Double4(X, Y, Y, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, G, G, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RGGA => new Double4(R, G, G, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, Y, Z, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XYZX => new Double4(X, Y, Z, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, G, B, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RGBR => new Double4(R, G, B, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, Y, Z, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XYZY => new Double4(X, Y, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, G, B, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RGBG => new Double4(R, G, B, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, Y, Z, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XYZZ => new Double4(X, Y, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, G, B, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RGBB => new Double4(R, G, B, B);

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of X, Y, Z, W on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XYZW
		{
			get => new Double4(X, Y, Z, W); 	
			set
			{
				X = value.X;
				Y = value.Y;
				Z = value.Z;
				W = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of R, G, B, A on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RGBA
		{
			get => new Double4(R, G, B, A);	
			set
			{
				R = value.R;
				G = value.G;
				B = value.B;
				A = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, Y, W, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XYWX => new Double4(X, Y, W, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, G, A, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RGAR => new Double4(R, G, A, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, Y, W, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XYWY => new Double4(X, Y, W, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, G, A, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RGAG => new Double4(R, G, A, G);

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of X, Y, W, Z on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XYWZ
		{
			get => new Double4(X, Y, W, Z); 	
			set
			{
				X = value.X;
				Y = value.Y;
				W = value.Z;
				Z = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of R, G, A, B on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RGAB
		{
			get => new Double4(R, G, A, B);	
			set
			{
				R = value.R;
				G = value.G;
				A = value.B;
				B = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, Y, W, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XYWW => new Double4(X, Y, W, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, G, A, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RGAA => new Double4(R, G, A, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, Z, X, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XZXX => new Double4(X, Z, X, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, B, R, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RBRR => new Double4(R, B, R, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, Z, X, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XZXY => new Double4(X, Z, X, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, B, R, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RBRG => new Double4(R, B, R, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, Z, X, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XZXZ => new Double4(X, Z, X, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, B, R, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RBRB => new Double4(R, B, R, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, Z, X, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XZXW => new Double4(X, Z, X, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, B, R, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RBRA => new Double4(R, B, R, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, Z, Y, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XZYX => new Double4(X, Z, Y, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, B, G, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RBGR => new Double4(R, B, G, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, Z, Y, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XZYY => new Double4(X, Z, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, B, G, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RBGG => new Double4(R, B, G, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, Z, Y, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XZYZ => new Double4(X, Z, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, B, G, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RBGB => new Double4(R, B, G, B);

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of X, Z, Y, W on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XZYW
		{
			get => new Double4(X, Z, Y, W); 	
			set
			{
				X = value.X;
				Z = value.Y;
				Y = value.Z;
				W = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of R, B, G, A on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RBGA
		{
			get => new Double4(R, B, G, A);	
			set
			{
				R = value.R;
				B = value.G;
				G = value.B;
				A = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, Z, Z, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XZZX => new Double4(X, Z, Z, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, B, B, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RBBR => new Double4(R, B, B, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, Z, Z, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XZZY => new Double4(X, Z, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, B, B, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RBBG => new Double4(R, B, B, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, Z, Z, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XZZZ => new Double4(X, Z, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, B, B, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RBBB => new Double4(R, B, B, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, Z, Z, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XZZW => new Double4(X, Z, Z, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, B, B, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RBBA => new Double4(R, B, B, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, Z, W, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XZWX => new Double4(X, Z, W, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, B, A, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RBAR => new Double4(R, B, A, R);

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of X, Z, W, Y on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XZWY
		{
			get => new Double4(X, Z, W, Y); 	
			set
			{
				X = value.X;
				Z = value.Y;
				W = value.Z;
				Y = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of R, B, A, G on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RBAG
		{
			get => new Double4(R, B, A, G);	
			set
			{
				R = value.R;
				B = value.G;
				A = value.B;
				G = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, Z, W, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XZWZ => new Double4(X, Z, W, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, B, A, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RBAB => new Double4(R, B, A, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, Z, W, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XZWW => new Double4(X, Z, W, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, B, A, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RBAA => new Double4(R, B, A, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, W, X, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XWXX => new Double4(X, W, X, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, A, R, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RARR => new Double4(R, A, R, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, W, X, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XWXY => new Double4(X, W, X, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, A, R, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RARG => new Double4(R, A, R, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, W, X, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XWXZ => new Double4(X, W, X, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, A, R, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RARB => new Double4(R, A, R, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, W, X, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XWXW => new Double4(X, W, X, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, A, R, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RARA => new Double4(R, A, R, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, W, Y, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XWYX => new Double4(X, W, Y, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, A, G, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RAGR => new Double4(R, A, G, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, W, Y, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XWYY => new Double4(X, W, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, A, G, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RAGG => new Double4(R, A, G, G);

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of X, W, Y, Z on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XWYZ
		{
			get => new Double4(X, W, Y, Z); 	
			set
			{
				X = value.X;
				W = value.Y;
				Y = value.Z;
				Z = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of R, A, G, B on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RAGB
		{
			get => new Double4(R, A, G, B);	
			set
			{
				R = value.R;
				A = value.G;
				G = value.B;
				B = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, W, Y, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XWYW => new Double4(X, W, Y, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, A, G, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RAGA => new Double4(R, A, G, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, W, Z, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XWZX => new Double4(X, W, Z, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, A, B, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RABR => new Double4(R, A, B, R);

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of X, W, Z, Y on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XWZY
		{
			get => new Double4(X, W, Z, Y); 	
			set
			{
				X = value.X;
				W = value.Y;
				Z = value.Z;
				Y = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of R, A, B, G on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RABG
		{
			get => new Double4(R, A, B, G);	
			set
			{
				R = value.R;
				A = value.G;
				B = value.B;
				G = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, W, Z, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XWZZ => new Double4(X, W, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, A, B, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RABB => new Double4(R, A, B, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, W, Z, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XWZW => new Double4(X, W, Z, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, A, B, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RABA => new Double4(R, A, B, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, W, W, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XWWX => new Double4(X, W, W, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, A, A, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RAAR => new Double4(R, A, A, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, W, W, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XWWY => new Double4(X, W, W, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, A, A, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RAAG => new Double4(R, A, A, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, W, W, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XWWZ => new Double4(X, W, W, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, A, A, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RAAB => new Double4(R, A, A, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of X, W, W, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 XWWW => new Double4(X, W, W, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of R, A, A, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 RAAA => new Double4(R, A, A, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, X, X, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YXXX => new Double4(Y, X, X, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, R, R, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GRRR => new Double4(G, R, R, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, X, X, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YXXY => new Double4(Y, X, X, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, R, R, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GRRG => new Double4(G, R, R, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, X, X, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YXXZ => new Double4(Y, X, X, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, R, R, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GRRB => new Double4(G, R, R, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, X, X, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YXXW => new Double4(Y, X, X, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, R, R, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GRRA => new Double4(G, R, R, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, X, Y, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YXYX => new Double4(Y, X, Y, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, R, G, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GRGR => new Double4(G, R, G, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, X, Y, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YXYY => new Double4(Y, X, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, R, G, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GRGG => new Double4(G, R, G, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, X, Y, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YXYZ => new Double4(Y, X, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, R, G, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GRGB => new Double4(G, R, G, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, X, Y, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YXYW => new Double4(Y, X, Y, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, R, G, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GRGA => new Double4(G, R, G, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, X, Z, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YXZX => new Double4(Y, X, Z, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, R, B, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GRBR => new Double4(G, R, B, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, X, Z, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YXZY => new Double4(Y, X, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, R, B, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GRBG => new Double4(G, R, B, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, X, Z, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YXZZ => new Double4(Y, X, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, R, B, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GRBB => new Double4(G, R, B, B);

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of Y, X, Z, W on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YXZW
		{
			get => new Double4(Y, X, Z, W); 	
			set
			{
				Y = value.X;
				X = value.Y;
				Z = value.Z;
				W = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of G, R, B, A on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GRBA
		{
			get => new Double4(G, R, B, A);	
			set
			{
				G = value.R;
				R = value.G;
				B = value.B;
				A = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, X, W, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YXWX => new Double4(Y, X, W, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, R, A, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GRAR => new Double4(G, R, A, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, X, W, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YXWY => new Double4(Y, X, W, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, R, A, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GRAG => new Double4(G, R, A, G);

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of Y, X, W, Z on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YXWZ
		{
			get => new Double4(Y, X, W, Z); 	
			set
			{
				Y = value.X;
				X = value.Y;
				W = value.Z;
				Z = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of G, R, A, B on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GRAB
		{
			get => new Double4(G, R, A, B);	
			set
			{
				G = value.R;
				R = value.G;
				A = value.B;
				B = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, X, W, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YXWW => new Double4(Y, X, W, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, R, A, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GRAA => new Double4(G, R, A, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, Y, X, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YYXX => new Double4(Y, Y, X, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, G, R, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GGRR => new Double4(G, G, R, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, Y, X, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YYXY => new Double4(Y, Y, X, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, G, R, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GGRG => new Double4(G, G, R, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, Y, X, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YYXZ => new Double4(Y, Y, X, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, G, R, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GGRB => new Double4(G, G, R, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, Y, X, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YYXW => new Double4(Y, Y, X, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, G, R, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GGRA => new Double4(G, G, R, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, Y, Y, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YYYX => new Double4(Y, Y, Y, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, G, G, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GGGR => new Double4(G, G, G, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, Y, Y, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YYYY => new Double4(Y, Y, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, G, G, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GGGG => new Double4(G, G, G, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, Y, Y, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YYYZ => new Double4(Y, Y, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, G, G, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GGGB => new Double4(G, G, G, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, Y, Y, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YYYW => new Double4(Y, Y, Y, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, G, G, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GGGA => new Double4(G, G, G, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, Y, Z, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YYZX => new Double4(Y, Y, Z, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, G, B, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GGBR => new Double4(G, G, B, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, Y, Z, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YYZY => new Double4(Y, Y, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, G, B, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GGBG => new Double4(G, G, B, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, Y, Z, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YYZZ => new Double4(Y, Y, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, G, B, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GGBB => new Double4(G, G, B, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, Y, Z, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YYZW => new Double4(Y, Y, Z, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, G, B, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GGBA => new Double4(G, G, B, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, Y, W, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YYWX => new Double4(Y, Y, W, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, G, A, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GGAR => new Double4(G, G, A, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, Y, W, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YYWY => new Double4(Y, Y, W, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, G, A, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GGAG => new Double4(G, G, A, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, Y, W, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YYWZ => new Double4(Y, Y, W, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, G, A, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GGAB => new Double4(G, G, A, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, Y, W, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YYWW => new Double4(Y, Y, W, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, G, A, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GGAA => new Double4(G, G, A, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, Z, X, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YZXX => new Double4(Y, Z, X, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, B, R, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GBRR => new Double4(G, B, R, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, Z, X, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YZXY => new Double4(Y, Z, X, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, B, R, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GBRG => new Double4(G, B, R, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, Z, X, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YZXZ => new Double4(Y, Z, X, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, B, R, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GBRB => new Double4(G, B, R, B);

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of Y, Z, X, W on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YZXW
		{
			get => new Double4(Y, Z, X, W); 	
			set
			{
				Y = value.X;
				Z = value.Y;
				X = value.Z;
				W = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of G, B, R, A on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GBRA
		{
			get => new Double4(G, B, R, A);	
			set
			{
				G = value.R;
				B = value.G;
				R = value.B;
				A = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, Z, Y, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YZYX => new Double4(Y, Z, Y, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, B, G, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GBGR => new Double4(G, B, G, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, Z, Y, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YZYY => new Double4(Y, Z, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, B, G, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GBGG => new Double4(G, B, G, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, Z, Y, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YZYZ => new Double4(Y, Z, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, B, G, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GBGB => new Double4(G, B, G, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, Z, Y, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YZYW => new Double4(Y, Z, Y, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, B, G, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GBGA => new Double4(G, B, G, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, Z, Z, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YZZX => new Double4(Y, Z, Z, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, B, B, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GBBR => new Double4(G, B, B, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, Z, Z, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YZZY => new Double4(Y, Z, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, B, B, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GBBG => new Double4(G, B, B, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, Z, Z, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YZZZ => new Double4(Y, Z, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, B, B, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GBBB => new Double4(G, B, B, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, Z, Z, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YZZW => new Double4(Y, Z, Z, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, B, B, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GBBA => new Double4(G, B, B, A);

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of Y, Z, W, X on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YZWX
		{
			get => new Double4(Y, Z, W, X); 	
			set
			{
				Y = value.X;
				Z = value.Y;
				W = value.Z;
				X = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of G, B, A, R on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GBAR
		{
			get => new Double4(G, B, A, R);	
			set
			{
				G = value.R;
				B = value.G;
				A = value.B;
				R = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, Z, W, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YZWY => new Double4(Y, Z, W, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, B, A, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GBAG => new Double4(G, B, A, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, Z, W, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YZWZ => new Double4(Y, Z, W, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, B, A, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GBAB => new Double4(G, B, A, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, Z, W, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YZWW => new Double4(Y, Z, W, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, B, A, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GBAA => new Double4(G, B, A, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, W, X, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YWXX => new Double4(Y, W, X, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, A, R, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GARR => new Double4(G, A, R, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, W, X, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YWXY => new Double4(Y, W, X, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, A, R, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GARG => new Double4(G, A, R, G);

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of Y, W, X, Z on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YWXZ
		{
			get => new Double4(Y, W, X, Z); 	
			set
			{
				Y = value.X;
				W = value.Y;
				X = value.Z;
				Z = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of G, A, R, B on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GARB
		{
			get => new Double4(G, A, R, B);	
			set
			{
				G = value.R;
				A = value.G;
				R = value.B;
				B = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, W, X, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YWXW => new Double4(Y, W, X, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, A, R, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GARA => new Double4(G, A, R, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, W, Y, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YWYX => new Double4(Y, W, Y, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, A, G, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GAGR => new Double4(G, A, G, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, W, Y, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YWYY => new Double4(Y, W, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, A, G, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GAGG => new Double4(G, A, G, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, W, Y, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YWYZ => new Double4(Y, W, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, A, G, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GAGB => new Double4(G, A, G, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, W, Y, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YWYW => new Double4(Y, W, Y, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, A, G, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GAGA => new Double4(G, A, G, A);

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of Y, W, Z, X on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YWZX
		{
			get => new Double4(Y, W, Z, X); 	
			set
			{
				Y = value.X;
				W = value.Y;
				Z = value.Z;
				X = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of G, A, B, R on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GABR
		{
			get => new Double4(G, A, B, R);	
			set
			{
				G = value.R;
				A = value.G;
				B = value.B;
				R = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, W, Z, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YWZY => new Double4(Y, W, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, A, B, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GABG => new Double4(G, A, B, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, W, Z, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YWZZ => new Double4(Y, W, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, A, B, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GABB => new Double4(G, A, B, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, W, Z, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YWZW => new Double4(Y, W, Z, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, A, B, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GABA => new Double4(G, A, B, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, W, W, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YWWX => new Double4(Y, W, W, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, A, A, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GAAR => new Double4(G, A, A, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, W, W, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YWWY => new Double4(Y, W, W, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, A, A, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GAAG => new Double4(G, A, A, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, W, W, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YWWZ => new Double4(Y, W, W, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, A, A, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GAAB => new Double4(G, A, A, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Y, W, W, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 YWWW => new Double4(Y, W, W, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of G, A, A, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 GAAA => new Double4(G, A, A, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, X, X, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZXXX => new Double4(Z, X, X, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, R, R, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BRRR => new Double4(B, R, R, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, X, X, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZXXY => new Double4(Z, X, X, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, R, R, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BRRG => new Double4(B, R, R, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, X, X, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZXXZ => new Double4(Z, X, X, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, R, R, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BRRB => new Double4(B, R, R, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, X, X, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZXXW => new Double4(Z, X, X, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, R, R, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BRRA => new Double4(B, R, R, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, X, Y, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZXYX => new Double4(Z, X, Y, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, R, G, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BRGR => new Double4(B, R, G, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, X, Y, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZXYY => new Double4(Z, X, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, R, G, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BRGG => new Double4(B, R, G, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, X, Y, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZXYZ => new Double4(Z, X, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, R, G, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BRGB => new Double4(B, R, G, B);

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of Z, X, Y, W on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZXYW
		{
			get => new Double4(Z, X, Y, W); 	
			set
			{
				Z = value.X;
				X = value.Y;
				Y = value.Z;
				W = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of B, R, G, A on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BRGA
		{
			get => new Double4(B, R, G, A);	
			set
			{
				B = value.R;
				R = value.G;
				G = value.B;
				A = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, X, Z, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZXZX => new Double4(Z, X, Z, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, R, B, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BRBR => new Double4(B, R, B, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, X, Z, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZXZY => new Double4(Z, X, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, R, B, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BRBG => new Double4(B, R, B, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, X, Z, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZXZZ => new Double4(Z, X, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, R, B, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BRBB => new Double4(B, R, B, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, X, Z, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZXZW => new Double4(Z, X, Z, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, R, B, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BRBA => new Double4(B, R, B, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, X, W, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZXWX => new Double4(Z, X, W, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, R, A, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BRAR => new Double4(B, R, A, R);

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of Z, X, W, Y on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZXWY
		{
			get => new Double4(Z, X, W, Y); 	
			set
			{
				Z = value.X;
				X = value.Y;
				W = value.Z;
				Y = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of B, R, A, G on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BRAG
		{
			get => new Double4(B, R, A, G);	
			set
			{
				B = value.R;
				R = value.G;
				A = value.B;
				G = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, X, W, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZXWZ => new Double4(Z, X, W, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, R, A, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BRAB => new Double4(B, R, A, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, X, W, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZXWW => new Double4(Z, X, W, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, R, A, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BRAA => new Double4(B, R, A, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, Y, X, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZYXX => new Double4(Z, Y, X, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, G, R, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BGRR => new Double4(B, G, R, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, Y, X, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZYXY => new Double4(Z, Y, X, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, G, R, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BGRG => new Double4(B, G, R, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, Y, X, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZYXZ => new Double4(Z, Y, X, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, G, R, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BGRB => new Double4(B, G, R, B);

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of Z, Y, X, W on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZYXW
		{
			get => new Double4(Z, Y, X, W); 	
			set
			{
				Z = value.X;
				Y = value.Y;
				X = value.Z;
				W = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of B, G, R, A on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BGRA
		{
			get => new Double4(B, G, R, A);	
			set
			{
				B = value.R;
				G = value.G;
				R = value.B;
				A = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, Y, Y, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZYYX => new Double4(Z, Y, Y, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, G, G, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BGGR => new Double4(B, G, G, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, Y, Y, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZYYY => new Double4(Z, Y, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, G, G, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BGGG => new Double4(B, G, G, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, Y, Y, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZYYZ => new Double4(Z, Y, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, G, G, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BGGB => new Double4(B, G, G, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, Y, Y, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZYYW => new Double4(Z, Y, Y, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, G, G, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BGGA => new Double4(B, G, G, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, Y, Z, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZYZX => new Double4(Z, Y, Z, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, G, B, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BGBR => new Double4(B, G, B, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, Y, Z, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZYZY => new Double4(Z, Y, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, G, B, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BGBG => new Double4(B, G, B, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, Y, Z, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZYZZ => new Double4(Z, Y, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, G, B, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BGBB => new Double4(B, G, B, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, Y, Z, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZYZW => new Double4(Z, Y, Z, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, G, B, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BGBA => new Double4(B, G, B, A);

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of Z, Y, W, X on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZYWX
		{
			get => new Double4(Z, Y, W, X); 	
			set
			{
				Z = value.X;
				Y = value.Y;
				W = value.Z;
				X = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of B, G, A, R on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BGAR
		{
			get => new Double4(B, G, A, R);	
			set
			{
				B = value.R;
				G = value.G;
				A = value.B;
				R = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, Y, W, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZYWY => new Double4(Z, Y, W, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, G, A, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BGAG => new Double4(B, G, A, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, Y, W, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZYWZ => new Double4(Z, Y, W, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, G, A, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BGAB => new Double4(B, G, A, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, Y, W, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZYWW => new Double4(Z, Y, W, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, G, A, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BGAA => new Double4(B, G, A, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, Z, X, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZZXX => new Double4(Z, Z, X, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, B, R, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BBRR => new Double4(B, B, R, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, Z, X, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZZXY => new Double4(Z, Z, X, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, B, R, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BBRG => new Double4(B, B, R, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, Z, X, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZZXZ => new Double4(Z, Z, X, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, B, R, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BBRB => new Double4(B, B, R, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, Z, X, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZZXW => new Double4(Z, Z, X, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, B, R, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BBRA => new Double4(B, B, R, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, Z, Y, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZZYX => new Double4(Z, Z, Y, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, B, G, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BBGR => new Double4(B, B, G, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, Z, Y, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZZYY => new Double4(Z, Z, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, B, G, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BBGG => new Double4(B, B, G, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, Z, Y, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZZYZ => new Double4(Z, Z, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, B, G, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BBGB => new Double4(B, B, G, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, Z, Y, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZZYW => new Double4(Z, Z, Y, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, B, G, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BBGA => new Double4(B, B, G, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, Z, Z, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZZZX => new Double4(Z, Z, Z, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, B, B, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BBBR => new Double4(B, B, B, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, Z, Z, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZZZY => new Double4(Z, Z, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, B, B, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BBBG => new Double4(B, B, B, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, Z, Z, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZZZZ => new Double4(Z, Z, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, B, B, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BBBB => new Double4(B, B, B, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, Z, Z, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZZZW => new Double4(Z, Z, Z, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, B, B, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BBBA => new Double4(B, B, B, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, Z, W, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZZWX => new Double4(Z, Z, W, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, B, A, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BBAR => new Double4(B, B, A, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, Z, W, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZZWY => new Double4(Z, Z, W, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, B, A, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BBAG => new Double4(B, B, A, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, Z, W, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZZWZ => new Double4(Z, Z, W, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, B, A, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BBAB => new Double4(B, B, A, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, Z, W, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZZWW => new Double4(Z, Z, W, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, B, A, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BBAA => new Double4(B, B, A, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, W, X, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZWXX => new Double4(Z, W, X, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, A, R, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BARR => new Double4(B, A, R, R);

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of Z, W, X, Y on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZWXY
		{
			get => new Double4(Z, W, X, Y); 	
			set
			{
				Z = value.X;
				W = value.Y;
				X = value.Z;
				Y = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of B, A, R, G on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BARG
		{
			get => new Double4(B, A, R, G);	
			set
			{
				B = value.R;
				A = value.G;
				R = value.B;
				G = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, W, X, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZWXZ => new Double4(Z, W, X, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, A, R, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BARB => new Double4(B, A, R, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, W, X, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZWXW => new Double4(Z, W, X, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, A, R, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BARA => new Double4(B, A, R, A);

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of Z, W, Y, X on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZWYX
		{
			get => new Double4(Z, W, Y, X); 	
			set
			{
				Z = value.X;
				W = value.Y;
				Y = value.Z;
				X = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of B, A, G, R on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BAGR
		{
			get => new Double4(B, A, G, R);	
			set
			{
				B = value.R;
				A = value.G;
				G = value.B;
				R = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, W, Y, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZWYY => new Double4(Z, W, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, A, G, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BAGG => new Double4(B, A, G, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, W, Y, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZWYZ => new Double4(Z, W, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, A, G, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BAGB => new Double4(B, A, G, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, W, Y, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZWYW => new Double4(Z, W, Y, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, A, G, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BAGA => new Double4(B, A, G, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, W, Z, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZWZX => new Double4(Z, W, Z, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, A, B, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BABR => new Double4(B, A, B, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, W, Z, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZWZY => new Double4(Z, W, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, A, B, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BABG => new Double4(B, A, B, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, W, Z, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZWZZ => new Double4(Z, W, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, A, B, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BABB => new Double4(B, A, B, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, W, Z, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZWZW => new Double4(Z, W, Z, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, A, B, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BABA => new Double4(B, A, B, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, W, W, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZWWX => new Double4(Z, W, W, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, A, A, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BAAR => new Double4(B, A, A, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, W, W, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZWWY => new Double4(Z, W, W, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, A, A, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BAAG => new Double4(B, A, A, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, W, W, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZWWZ => new Double4(Z, W, W, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, A, A, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BAAB => new Double4(B, A, A, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of Z, W, W, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ZWWW => new Double4(Z, W, W, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of B, A, A, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 BAAA => new Double4(B, A, A, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, X, X, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WXXX => new Double4(W, X, X, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, R, R, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ARRR => new Double4(A, R, R, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, X, X, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WXXY => new Double4(W, X, X, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, R, R, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ARRG => new Double4(A, R, R, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, X, X, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WXXZ => new Double4(W, X, X, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, R, R, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ARRB => new Double4(A, R, R, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, X, X, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WXXW => new Double4(W, X, X, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, R, R, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ARRA => new Double4(A, R, R, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, X, Y, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WXYX => new Double4(W, X, Y, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, R, G, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ARGR => new Double4(A, R, G, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, X, Y, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WXYY => new Double4(W, X, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, R, G, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ARGG => new Double4(A, R, G, G);

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of W, X, Y, Z on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WXYZ
		{
			get => new Double4(W, X, Y, Z); 	
			set
			{
				W = value.X;
				X = value.Y;
				Y = value.Z;
				Z = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of A, R, G, B on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ARGB
		{
			get => new Double4(A, R, G, B);	
			set
			{
				A = value.R;
				R = value.G;
				G = value.B;
				B = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, X, Y, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WXYW => new Double4(W, X, Y, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, R, G, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ARGA => new Double4(A, R, G, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, X, Z, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WXZX => new Double4(W, X, Z, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, R, B, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ARBR => new Double4(A, R, B, R);

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of W, X, Z, Y on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WXZY
		{
			get => new Double4(W, X, Z, Y); 	
			set
			{
				W = value.X;
				X = value.Y;
				Z = value.Z;
				Y = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of A, R, B, G on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ARBG
		{
			get => new Double4(A, R, B, G);	
			set
			{
				A = value.R;
				R = value.G;
				B = value.B;
				G = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, X, Z, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WXZZ => new Double4(W, X, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, R, B, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ARBB => new Double4(A, R, B, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, X, Z, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WXZW => new Double4(W, X, Z, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, R, B, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ARBA => new Double4(A, R, B, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, X, W, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WXWX => new Double4(W, X, W, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, R, A, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ARAR => new Double4(A, R, A, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, X, W, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WXWY => new Double4(W, X, W, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, R, A, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ARAG => new Double4(A, R, A, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, X, W, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WXWZ => new Double4(W, X, W, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, R, A, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ARAB => new Double4(A, R, A, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, X, W, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WXWW => new Double4(W, X, W, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, R, A, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ARAA => new Double4(A, R, A, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, Y, X, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WYXX => new Double4(W, Y, X, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, G, R, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 AGRR => new Double4(A, G, R, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, Y, X, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WYXY => new Double4(W, Y, X, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, G, R, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 AGRG => new Double4(A, G, R, G);

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of W, Y, X, Z on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WYXZ
		{
			get => new Double4(W, Y, X, Z); 	
			set
			{
				W = value.X;
				Y = value.Y;
				X = value.Z;
				Z = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of A, G, R, B on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 AGRB
		{
			get => new Double4(A, G, R, B);	
			set
			{
				A = value.R;
				G = value.G;
				R = value.B;
				B = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, Y, X, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WYXW => new Double4(W, Y, X, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, G, R, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 AGRA => new Double4(A, G, R, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, Y, Y, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WYYX => new Double4(W, Y, Y, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, G, G, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 AGGR => new Double4(A, G, G, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, Y, Y, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WYYY => new Double4(W, Y, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, G, G, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 AGGG => new Double4(A, G, G, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, Y, Y, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WYYZ => new Double4(W, Y, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, G, G, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 AGGB => new Double4(A, G, G, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, Y, Y, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WYYW => new Double4(W, Y, Y, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, G, G, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 AGGA => new Double4(A, G, G, A);

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of W, Y, Z, X on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WYZX
		{
			get => new Double4(W, Y, Z, X); 	
			set
			{
				W = value.X;
				Y = value.Y;
				Z = value.Z;
				X = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of A, G, B, R on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 AGBR
		{
			get => new Double4(A, G, B, R);	
			set
			{
				A = value.R;
				G = value.G;
				B = value.B;
				R = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, Y, Z, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WYZY => new Double4(W, Y, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, G, B, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 AGBG => new Double4(A, G, B, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, Y, Z, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WYZZ => new Double4(W, Y, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, G, B, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 AGBB => new Double4(A, G, B, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, Y, Z, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WYZW => new Double4(W, Y, Z, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, G, B, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 AGBA => new Double4(A, G, B, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, Y, W, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WYWX => new Double4(W, Y, W, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, G, A, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 AGAR => new Double4(A, G, A, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, Y, W, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WYWY => new Double4(W, Y, W, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, G, A, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 AGAG => new Double4(A, G, A, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, Y, W, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WYWZ => new Double4(W, Y, W, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, G, A, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 AGAB => new Double4(A, G, A, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, Y, W, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WYWW => new Double4(W, Y, W, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, G, A, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 AGAA => new Double4(A, G, A, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, Z, X, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WZXX => new Double4(W, Z, X, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, B, R, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ABRR => new Double4(A, B, R, R);

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of W, Z, X, Y on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WZXY
		{
			get => new Double4(W, Z, X, Y); 	
			set
			{
				W = value.X;
				Z = value.Y;
				X = value.Z;
				Y = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of A, B, R, G on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ABRG
		{
			get => new Double4(A, B, R, G);	
			set
			{
				A = value.R;
				B = value.G;
				R = value.B;
				G = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, Z, X, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WZXZ => new Double4(W, Z, X, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, B, R, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ABRB => new Double4(A, B, R, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, Z, X, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WZXW => new Double4(W, Z, X, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, B, R, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ABRA => new Double4(A, B, R, A);

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of W, Z, Y, X on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WZYX
		{
			get => new Double4(W, Z, Y, X); 	
			set
			{
				W = value.X;
				Z = value.Y;
				Y = value.Z;
				X = value.W;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Double4"/> comprised of A, B, G, R on the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ABGR
		{
			get => new Double4(A, B, G, R);	
			set
			{
				A = value.R;
				B = value.G;
				G = value.B;
				R = value.A;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, Z, Y, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WZYY => new Double4(W, Z, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, B, G, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ABGG => new Double4(A, B, G, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, Z, Y, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WZYZ => new Double4(W, Z, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, B, G, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ABGB => new Double4(A, B, G, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, Z, Y, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WZYW => new Double4(W, Z, Y, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, B, G, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ABGA => new Double4(A, B, G, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, Z, Z, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WZZX => new Double4(W, Z, Z, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, B, B, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ABBR => new Double4(A, B, B, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, Z, Z, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WZZY => new Double4(W, Z, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, B, B, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ABBG => new Double4(A, B, B, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, Z, Z, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WZZZ => new Double4(W, Z, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, B, B, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ABBB => new Double4(A, B, B, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, Z, Z, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WZZW => new Double4(W, Z, Z, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, B, B, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ABBA => new Double4(A, B, B, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, Z, W, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WZWX => new Double4(W, Z, W, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, B, A, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ABAR => new Double4(A, B, A, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, Z, W, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WZWY => new Double4(W, Z, W, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, B, A, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ABAG => new Double4(A, B, A, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, Z, W, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WZWZ => new Double4(W, Z, W, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, B, A, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ABAB => new Double4(A, B, A, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, Z, W, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WZWW => new Double4(W, Z, W, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, B, A, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 ABAA => new Double4(A, B, A, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, W, X, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WWXX => new Double4(W, W, X, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, A, R, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 AARR => new Double4(A, A, R, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, W, X, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WWXY => new Double4(W, W, X, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, A, R, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 AARG => new Double4(A, A, R, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, W, X, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WWXZ => new Double4(W, W, X, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, A, R, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 AARB => new Double4(A, A, R, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, W, X, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WWXW => new Double4(W, W, X, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, A, R, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 AARA => new Double4(A, A, R, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, W, Y, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WWYX => new Double4(W, W, Y, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, A, G, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 AAGR => new Double4(A, A, G, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, W, Y, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WWYY => new Double4(W, W, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, A, G, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 AAGG => new Double4(A, A, G, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, W, Y, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WWYZ => new Double4(W, W, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, A, G, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 AAGB => new Double4(A, A, G, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, W, Y, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WWYW => new Double4(W, W, Y, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, A, G, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 AAGA => new Double4(A, A, G, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, W, Z, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WWZX => new Double4(W, W, Z, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, A, B, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 AABR => new Double4(A, A, B, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, W, Z, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WWZY => new Double4(W, W, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, A, B, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 AABG => new Double4(A, A, B, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, W, Z, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WWZZ => new Double4(W, W, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, A, B, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 AABB => new Double4(A, A, B, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, W, Z, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WWZW => new Double4(W, W, Z, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, A, B, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 AABA => new Double4(A, A, B, A);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, W, W, X from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WWWX => new Double4(W, W, W, X);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, A, A, R from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 AAAR => new Double4(A, A, A, R);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, W, W, Y from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WWWY => new Double4(W, W, W, Y);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, A, A, G from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 AAAG => new Double4(A, A, A, G);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, W, W, Z from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WWWZ => new Double4(W, W, W, Z);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, A, A, B from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 AAAB => new Double4(A, A, A, B);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of W, W, W, W from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 WWWW => new Double4(W, W, W, W);

		/// <summary>
		/// Gets a new <see cref="Double4"/> comprised of A, A, A, A from the current <see cref="Double4"/>.
		/// </summary>
		public Double4 AAAA => new Double4(A, A, A, A);


		public double R
		{
			get => X;
			set => X = value;
		}


		public double G
		{
			get => Y;
			set => Y = value;
		}


		public double B
		{
			get => Z;
			set => Z = value;
		}


		public double A
		{
			get => W;
			set => W = value;
		}

		public static Double4 operator +(Double4 a, Double4 b)
		{
			return new Double4()
			{
				X = a.X + b.X,
				Y = a.Y + b.Y,
				Z = a.Z + b.Z,
				W = a.W + b.W,
			};
		}
		public static Double4 operator +(Double4 a, int b)
		{
			return new Double4()
			{
				X = (double)(a.X + b),
				Y = (double)(a.Y + b),
				Z = (double)(a.Z + b),
				W = (double)(a.W + b),
			};
		}

		public static Double4 operator +(int a, Double4 b)
		{
			return new Double4()
			{
				X = (double)(a + b.X),
				Y = (double)(a + b.Y),
				Z = (double)(a + b.Z),
				W = (double)(a + b.W),
			};
		}
		public static Double4 operator +(Double4 a, float b)
		{
			return new Double4()
			{
				X = (double)(a.X + b),
				Y = (double)(a.Y + b),
				Z = (double)(a.Z + b),
				W = (double)(a.W + b),
			};
		}

		public static Double4 operator +(float a, Double4 b)
		{
			return new Double4()
			{
				X = (double)(a + b.X),
				Y = (double)(a + b.Y),
				Z = (double)(a + b.Z),
				W = (double)(a + b.W),
			};
		}
		public static Double4 operator +(Double4 a, double b)
		{
			return new Double4()
			{
				X = (double)(a.X + b),
				Y = (double)(a.Y + b),
				Z = (double)(a.Z + b),
				W = (double)(a.W + b),
			};
		}

		public static Double4 operator +(double a, Double4 b)
		{
			return new Double4()
			{
				X = (a + b.X),
				Y = (a + b.Y),
				Z = (a + b.Z),
				W = (a + b.W),
			};
		}
		public static Double4 operator -(Double4 a, Double4 b)
		{
			return new Double4()
			{
				X = a.X - b.X,
				Y = a.Y - b.Y,
				Z = a.Z - b.Z,
				W = a.W - b.W,
			};
		}
		public static Double4 operator -(Double4 a, int b)
		{
			return new Double4()
			{
				X = (double)(a.X - b),
				Y = (double)(a.Y - b),
				Z = (double)(a.Z - b),
				W = (double)(a.W - b),
			};
		}

		public static Double4 operator -(int a, Double4 b)
		{
			return new Double4()
			{
				X = (double)(a - b.X),
				Y = (double)(a - b.Y),
				Z = (double)(a - b.Z),
				W = (double)(a - b.W),
			};
		}
		public static Double4 operator -(Double4 a, float b)
		{
			return new Double4()
			{
				X = (double)(a.X - b),
				Y = (double)(a.Y - b),
				Z = (double)(a.Z - b),
				W = (double)(a.W - b),
			};
		}

		public static Double4 operator -(float a, Double4 b)
		{
			return new Double4()
			{
				X = (double)(a - b.X),
				Y = (double)(a - b.Y),
				Z = (double)(a - b.Z),
				W = (double)(a - b.W),
			};
		}
		public static Double4 operator -(Double4 a, double b)
		{
			return new Double4()
			{
				X = (double)(a.X - b),
				Y = (double)(a.Y - b),
				Z = (double)(a.Z - b),
				W = (double)(a.W - b),
			};
		}

		public static Double4 operator -(double a, Double4 b)
		{
			return new Double4()
			{
				X = (a - b.X),
				Y = (a - b.Y),
				Z = (a - b.Z),
				W = (a - b.W),
			};
		}
		public static Double4 operator *(Double4 a, Double4 b)
		{
			return new Double4()
			{
				X = a.X * b.X,
				Y = a.Y * b.Y,
				Z = a.Z * b.Z,
				W = a.W * b.W,
			};
		}
		public static Double4 operator *(Double4 a, int b)
		{
			return new Double4()
			{
				X = (double)(a.X * b),
				Y = (double)(a.Y * b),
				Z = (double)(a.Z * b),
				W = (double)(a.W * b),
			};
		}

		public static Double4 operator *(int a, Double4 b)
		{
			return new Double4()
			{
				X = (double)(a * b.X),
				Y = (double)(a * b.Y),
				Z = (double)(a * b.Z),
				W = (double)(a * b.W),
			};
		}
		public static Double4 operator *(Double4 a, float b)
		{
			return new Double4()
			{
				X = (double)(a.X * b),
				Y = (double)(a.Y * b),
				Z = (double)(a.Z * b),
				W = (double)(a.W * b),
			};
		}

		public static Double4 operator *(float a, Double4 b)
		{
			return new Double4()
			{
				X = (double)(a * b.X),
				Y = (double)(a * b.Y),
				Z = (double)(a * b.Z),
				W = (double)(a * b.W),
			};
		}
		public static Double4 operator *(Double4 a, double b)
		{
			return new Double4()
			{
				X = (double)(a.X * b),
				Y = (double)(a.Y * b),
				Z = (double)(a.Z * b),
				W = (double)(a.W * b),
			};
		}

		public static Double4 operator *(double a, Double4 b)
		{
			return new Double4()
			{
				X = (a * b.X),
				Y = (a * b.Y),
				Z = (a * b.Z),
				W = (a * b.W),
			};
		}
		public static Double4 operator /(Double4 a, Double4 b)
		{
			return new Double4()
			{
				X = a.X / b.X,
				Y = a.Y / b.Y,
				Z = a.Z / b.Z,
				W = a.W / b.W,
			};
		}
		public static Double4 operator /(Double4 a, int b)
		{
			return new Double4()
			{
				X = (double)(a.X / b),
				Y = (double)(a.Y / b),
				Z = (double)(a.Z / b),
				W = (double)(a.W / b),
			};
		}

		public static Double4 operator /(int a, Double4 b)
		{
			return new Double4()
			{
				X = (double)(a / b.X),
				Y = (double)(a / b.Y),
				Z = (double)(a / b.Z),
				W = (double)(a / b.W),
			};
		}
		public static Double4 operator /(Double4 a, float b)
		{
			return new Double4()
			{
				X = (double)(a.X / b),
				Y = (double)(a.Y / b),
				Z = (double)(a.Z / b),
				W = (double)(a.W / b),
			};
		}

		public static Double4 operator /(float a, Double4 b)
		{
			return new Double4()
			{
				X = (double)(a / b.X),
				Y = (double)(a / b.Y),
				Z = (double)(a / b.Z),
				W = (double)(a / b.W),
			};
		}
		public static Double4 operator /(Double4 a, double b)
		{
			return new Double4()
			{
				X = (double)(a.X / b),
				Y = (double)(a.Y / b),
				Z = (double)(a.Z / b),
				W = (double)(a.W / b),
			};
		}

		public static Double4 operator /(double a, Double4 b)
		{
			return new Double4()
			{
				X = (a / b.X),
				Y = (a / b.Y),
				Z = (a / b.Z),
				W = (a / b.W),
			};
		}
		public static explicit operator Vector4(Double4 val)
		{
			return new Vector4()
			{
				X = (float)val.X,
				Y = (float)val.Y,
				Z = (float)val.Z,
				W = (float)val.W,
			};
		}

		public static explicit operator UInt4(Double4 val)
		{
			return new UInt4()
			{
				X = (uint)val.X,
				Y = (uint)val.Y,
				Z = (uint)val.Z,
				W = (uint)val.W,
			};
		}

		public static explicit operator Int4(Double4 val)
		{
			return new Int4()
			{
				X = (int)val.X,
				Y = (int)val.Y,
				Z = (int)val.Z,
				W = (int)val.W,
			};
		}

	}
}
