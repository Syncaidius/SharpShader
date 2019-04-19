using System;
using System.Runtime.InteropServices;

namespace SharpShader
{
	[StructLayout(LayoutKind.Sequential)]
	[Serializable]
	public struct Double3 : IVector<double>
	{
		/// <summary>
		///	The number of elements (components) in a <see cref="Double3"/>.
		/// </summary>
		public const int ELEMENT_COUNT = 3;
		
		/// <summary>
		///	The size of a <see cref="Double3"/>, in bytes.
		/// </summary>
		public const int ELEMENT_SIZE = sizeof(double);

		/// <summary>
		///	The size of a single element (component) within a <see cref="Double3"/>, in bytes.
		/// </summary>
		public const int SIZE_OF = ELEMENT_COUNT * ELEMENT_SIZE;

		/// <summary>
		///	Gets the <see cref="Type"/> of each element in a <see cref="Double3"/>.
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
        /// Creates a new instance of <see cref="Double3"/>.
        /// </summary>
		public Double3(double x, double y, double z)
		{
			X = x;
			Y = y;
			Z = z;
		}

        /// <summary>
        /// Creates a new instance of <see cref="Double3"/>.
        /// </summary>
		public Double3(Double2 p, double z)
		{
			X = p.X;
			Y = p.Y;
			Z = z;
		}

        /// <summary>
        /// Creates a new instance of <see cref="Double3"/>.
        /// </summary>
		public Double3(double x, Double2 p)
		{
			X = x;
			Y = p.X;
			Z = p.Y;
		}

		/// <summary>
		/// Gets or sets a component at the specified index for the current <see cref="Double3"/> .
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
					default: throw new IndexOutOfRangeException("The maximum index of a Double3 is 2.");
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

		public static Double3 operator +(Double3 a, Double3 b)
		{
			return new Double3()
			{
				X = a.X + b.X,
				Y = a.Y + b.Y,
				Z = a.Z + b.Z,
			};
		}
		public static Double3 operator +(Double3 a, int b)
		{
			return new Double3()
			{
				X = (double)(a.X + b),
				Y = (double)(a.Y + b),
				Z = (double)(a.Z + b),
			};
		}

		public static Double3 operator +(int a, Double3 b)
		{
			return new Double3()
			{
				X = (double)(a + b.X),
				Y = (double)(a + b.Y),
				Z = (double)(a + b.Z),
			};
		}
		public static Double3 operator +(Double3 a, float b)
		{
			return new Double3()
			{
				X = (double)(a.X + b),
				Y = (double)(a.Y + b),
				Z = (double)(a.Z + b),
			};
		}

		public static Double3 operator +(float a, Double3 b)
		{
			return new Double3()
			{
				X = (double)(a + b.X),
				Y = (double)(a + b.Y),
				Z = (double)(a + b.Z),
			};
		}
		public static Double3 operator +(Double3 a, double b)
		{
			return new Double3()
			{
				X = (double)(a.X + b),
				Y = (double)(a.Y + b),
				Z = (double)(a.Z + b),
			};
		}

		public static Double3 operator +(double a, Double3 b)
		{
			return new Double3()
			{
				X = (a + b.X),
				Y = (a + b.Y),
				Z = (a + b.Z),
			};
		}
		public static Double3 operator -(Double3 a, Double3 b)
		{
			return new Double3()
			{
				X = a.X - b.X,
				Y = a.Y - b.Y,
				Z = a.Z - b.Z,
			};
		}
		public static Double3 operator -(Double3 a, int b)
		{
			return new Double3()
			{
				X = (double)(a.X - b),
				Y = (double)(a.Y - b),
				Z = (double)(a.Z - b),
			};
		}

		public static Double3 operator -(int a, Double3 b)
		{
			return new Double3()
			{
				X = (double)(a - b.X),
				Y = (double)(a - b.Y),
				Z = (double)(a - b.Z),
			};
		}
		public static Double3 operator -(Double3 a, float b)
		{
			return new Double3()
			{
				X = (double)(a.X - b),
				Y = (double)(a.Y - b),
				Z = (double)(a.Z - b),
			};
		}

		public static Double3 operator -(float a, Double3 b)
		{
			return new Double3()
			{
				X = (double)(a - b.X),
				Y = (double)(a - b.Y),
				Z = (double)(a - b.Z),
			};
		}
		public static Double3 operator -(Double3 a, double b)
		{
			return new Double3()
			{
				X = (double)(a.X - b),
				Y = (double)(a.Y - b),
				Z = (double)(a.Z - b),
			};
		}

		public static Double3 operator -(double a, Double3 b)
		{
			return new Double3()
			{
				X = (a - b.X),
				Y = (a - b.Y),
				Z = (a - b.Z),
			};
		}
		public static Double3 operator *(Double3 a, Double3 b)
		{
			return new Double3()
			{
				X = a.X * b.X,
				Y = a.Y * b.Y,
				Z = a.Z * b.Z,
			};
		}
		public static Double3 operator *(Double3 a, int b)
		{
			return new Double3()
			{
				X = (double)(a.X * b),
				Y = (double)(a.Y * b),
				Z = (double)(a.Z * b),
			};
		}

		public static Double3 operator *(int a, Double3 b)
		{
			return new Double3()
			{
				X = (double)(a * b.X),
				Y = (double)(a * b.Y),
				Z = (double)(a * b.Z),
			};
		}
		public static Double3 operator *(Double3 a, float b)
		{
			return new Double3()
			{
				X = (double)(a.X * b),
				Y = (double)(a.Y * b),
				Z = (double)(a.Z * b),
			};
		}

		public static Double3 operator *(float a, Double3 b)
		{
			return new Double3()
			{
				X = (double)(a * b.X),
				Y = (double)(a * b.Y),
				Z = (double)(a * b.Z),
			};
		}
		public static Double3 operator *(Double3 a, double b)
		{
			return new Double3()
			{
				X = (double)(a.X * b),
				Y = (double)(a.Y * b),
				Z = (double)(a.Z * b),
			};
		}

		public static Double3 operator *(double a, Double3 b)
		{
			return new Double3()
			{
				X = (a * b.X),
				Y = (a * b.Y),
				Z = (a * b.Z),
			};
		}
		public static Double3 operator /(Double3 a, Double3 b)
		{
			return new Double3()
			{
				X = a.X / b.X,
				Y = a.Y / b.Y,
				Z = a.Z / b.Z,
			};
		}
		public static Double3 operator /(Double3 a, int b)
		{
			return new Double3()
			{
				X = (double)(a.X / b),
				Y = (double)(a.Y / b),
				Z = (double)(a.Z / b),
			};
		}

		public static Double3 operator /(int a, Double3 b)
		{
			return new Double3()
			{
				X = (double)(a / b.X),
				Y = (double)(a / b.Y),
				Z = (double)(a / b.Z),
			};
		}
		public static Double3 operator /(Double3 a, float b)
		{
			return new Double3()
			{
				X = (double)(a.X / b),
				Y = (double)(a.Y / b),
				Z = (double)(a.Z / b),
			};
		}

		public static Double3 operator /(float a, Double3 b)
		{
			return new Double3()
			{
				X = (double)(a / b.X),
				Y = (double)(a / b.Y),
				Z = (double)(a / b.Z),
			};
		}
		public static Double3 operator /(Double3 a, double b)
		{
			return new Double3()
			{
				X = (double)(a.X / b),
				Y = (double)(a.Y / b),
				Z = (double)(a.Z / b),
			};
		}

		public static Double3 operator /(double a, Double3 b)
		{
			return new Double3()
			{
				X = (a / b.X),
				Y = (a / b.Y),
				Z = (a / b.Z),
			};
		}
		public static explicit operator Vector3(Double3 val)
		{
			return new Vector3()
			{
				X = (float)val.X,
				Y = (float)val.Y,
				Z = (float)val.Z,
			};
		}

		public static explicit operator UInt3(Double3 val)
		{
			return new UInt3()
			{
				X = (uint)val.X,
				Y = (uint)val.Y,
				Z = (uint)val.Z,
			};
		}

		public static explicit operator Int3(Double3 val)
		{
			return new Int3()
			{
				X = (int)val.X,
				Y = (int)val.Y,
				Z = (int)val.Z,
			};
		}

	}
}
