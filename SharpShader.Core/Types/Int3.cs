using System;
using System.Runtime.InteropServices;

namespace SharpShader
{
	[StructLayout(LayoutKind.Sequential)]
	[Serializable]
	public struct Int3 : IVector<int>, IIntrinsicValue<int>
	{
		/// <summary>
		///	The number of elements (components) in a <see cref="Int3"/>.
		/// </summary>
		public const int ELEMENT_COUNT = 3;
		
		/// <summary>
		///	The size of a <see cref="Int3"/>, in bytes.
		/// </summary>
		public const int ELEMENT_SIZE = sizeof(int);

		/// <summary>
		///	The size of a single element (component) within a <see cref="Int3"/>, in bytes.
		/// </summary>
		public const int SIZE_OF = ELEMENT_COUNT * ELEMENT_SIZE;

		/// <summary>
		///	Gets the <see cref="Type"/> of each element in a <see cref="Int3"/>.
		/// </summary>
		public static readonly Type ElementType = typeof(int);

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
        /// Creates a new instance of <see cref="Int3"/>.
        /// </summary>
		public Int3(int x, int y, int z)
		{
			X = x;
			Y = y;
			Z = z;
		}

        /// <summary>
        /// Creates a new instance of <see cref="Int3"/>.
        /// </summary>
		public Int3(Int2 p, int z)
		{
			X = p.X;
			Y = p.Y;
			Z = z;
		}

        /// <summary>
        /// Creates a new instance of <see cref="Int3"/>.
        /// </summary>
		public Int3(int x, Int2 p)
		{
			X = x;
			Y = p.X;
			Z = p.Y;
		}

		/// <summary>
		/// Gets or sets a component at the specified index for the current <see cref="Int3"/> .
		/// </summary>
		public int this[int index]
		{
			get
			{
				switch(index)
				{
					case 0: return X;
					case 1: return Y;
					case 2: return Z;
					default: throw new IndexOutOfRangeException("The maximum index of a Int3 is 2.");
				}
			}
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

		public static Int3 operator +(Int3 a, Int3 b)
		{
			return new Int3()
			{
				X = a.X + b.X,
				Y = a.Y + b.Y,
				Z = a.Z + b.Z,
			};
		}
		public static Int3 operator +(Int3 a, int b)
		{
			return new Int3()
			{
				X = (int)(a.X + b),
				Y = (int)(a.Y + b),
				Z = (int)(a.Z + b),
			};
		}

		public static Int3 operator +(int a, Int3 b)
		{
			return new Int3()
			{
				X = (a + b.X),
				Y = (a + b.Y),
				Z = (a + b.Z),
			};
		}
		public static Int3 operator +(Int3 a, float b)
		{
			return new Int3()
			{
				X = (int)(a.X + b),
				Y = (int)(a.Y + b),
				Z = (int)(a.Z + b),
			};
		}

		public static Int3 operator +(float a, Int3 b)
		{
			return new Int3()
			{
				X = (int)(a + b.X),
				Y = (int)(a + b.Y),
				Z = (int)(a + b.Z),
			};
		}
		public static Int3 operator +(Int3 a, double b)
		{
			return new Int3()
			{
				X = (int)(a.X + b),
				Y = (int)(a.Y + b),
				Z = (int)(a.Z + b),
			};
		}

		public static Int3 operator +(double a, Int3 b)
		{
			return new Int3()
			{
				X = (int)(a + b.X),
				Y = (int)(a + b.Y),
				Z = (int)(a + b.Z),
			};
		}
		public static Int3 operator -(Int3 a, Int3 b)
		{
			return new Int3()
			{
				X = a.X - b.X,
				Y = a.Y - b.Y,
				Z = a.Z - b.Z,
			};
		}
		public static Int3 operator -(Int3 a, int b)
		{
			return new Int3()
			{
				X = (int)(a.X - b),
				Y = (int)(a.Y - b),
				Z = (int)(a.Z - b),
			};
		}

		public static Int3 operator -(int a, Int3 b)
		{
			return new Int3()
			{
				X = (a - b.X),
				Y = (a - b.Y),
				Z = (a - b.Z),
			};
		}
		public static Int3 operator -(Int3 a, float b)
		{
			return new Int3()
			{
				X = (int)(a.X - b),
				Y = (int)(a.Y - b),
				Z = (int)(a.Z - b),
			};
		}

		public static Int3 operator -(float a, Int3 b)
		{
			return new Int3()
			{
				X = (int)(a - b.X),
				Y = (int)(a - b.Y),
				Z = (int)(a - b.Z),
			};
		}
		public static Int3 operator -(Int3 a, double b)
		{
			return new Int3()
			{
				X = (int)(a.X - b),
				Y = (int)(a.Y - b),
				Z = (int)(a.Z - b),
			};
		}

		public static Int3 operator -(double a, Int3 b)
		{
			return new Int3()
			{
				X = (int)(a - b.X),
				Y = (int)(a - b.Y),
				Z = (int)(a - b.Z),
			};
		}
		public static Int3 operator *(Int3 a, Int3 b)
		{
			return new Int3()
			{
				X = a.X * b.X,
				Y = a.Y * b.Y,
				Z = a.Z * b.Z,
			};
		}
		public static Int3 operator *(Int3 a, int b)
		{
			return new Int3()
			{
				X = (int)(a.X * b),
				Y = (int)(a.Y * b),
				Z = (int)(a.Z * b),
			};
		}

		public static Int3 operator *(int a, Int3 b)
		{
			return new Int3()
			{
				X = (a * b.X),
				Y = (a * b.Y),
				Z = (a * b.Z),
			};
		}
		public static Int3 operator *(Int3 a, float b)
		{
			return new Int3()
			{
				X = (int)(a.X * b),
				Y = (int)(a.Y * b),
				Z = (int)(a.Z * b),
			};
		}

		public static Int3 operator *(float a, Int3 b)
		{
			return new Int3()
			{
				X = (int)(a * b.X),
				Y = (int)(a * b.Y),
				Z = (int)(a * b.Z),
			};
		}
		public static Int3 operator *(Int3 a, double b)
		{
			return new Int3()
			{
				X = (int)(a.X * b),
				Y = (int)(a.Y * b),
				Z = (int)(a.Z * b),
			};
		}

		public static Int3 operator *(double a, Int3 b)
		{
			return new Int3()
			{
				X = (int)(a * b.X),
				Y = (int)(a * b.Y),
				Z = (int)(a * b.Z),
			};
		}
		public static Int3 operator /(Int3 a, Int3 b)
		{
			return new Int3()
			{
				X = a.X / b.X,
				Y = a.Y / b.Y,
				Z = a.Z / b.Z,
			};
		}
		public static Int3 operator /(Int3 a, int b)
		{
			return new Int3()
			{
				X = (int)(a.X / b),
				Y = (int)(a.Y / b),
				Z = (int)(a.Z / b),
			};
		}

		public static Int3 operator /(int a, Int3 b)
		{
			return new Int3()
			{
				X = (a / b.X),
				Y = (a / b.Y),
				Z = (a / b.Z),
			};
		}
		public static Int3 operator /(Int3 a, float b)
		{
			return new Int3()
			{
				X = (int)(a.X / b),
				Y = (int)(a.Y / b),
				Z = (int)(a.Z / b),
			};
		}

		public static Int3 operator /(float a, Int3 b)
		{
			return new Int3()
			{
				X = (int)(a / b.X),
				Y = (int)(a / b.Y),
				Z = (int)(a / b.Z),
			};
		}
		public static Int3 operator /(Int3 a, double b)
		{
			return new Int3()
			{
				X = (int)(a.X / b),
				Y = (int)(a.Y / b),
				Z = (int)(a.Z / b),
			};
		}

		public static Int3 operator /(double a, Int3 b)
		{
			return new Int3()
			{
				X = (int)(a / b.X),
				Y = (int)(a / b.Y),
				Z = (int)(a / b.Z),
			};
		}
		public static explicit operator Vector3(Int3 val)
		{
			return new Vector3()
			{
				X = (float)val.X,
				Y = (float)val.Y,
				Z = (float)val.Z,
			};
		}

		public static explicit operator UInt3(Int3 val)
		{
			return new UInt3()
			{
				X = (uint)val.X,
				Y = (uint)val.Y,
				Z = (uint)val.Z,
			};
		}

		public static explicit operator Double3(Int3 val)
		{
			return new Double3()
			{
				X = (double)val.X,
				Y = (double)val.Y,
				Z = (double)val.Z,
			};
		}

	}
}
