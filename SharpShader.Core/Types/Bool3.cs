using System;
using System.Runtime.InteropServices;

namespace SharpShader
{
	[StructLayout(LayoutKind.Sequential)]
	[Serializable]
	public struct Bool3 : IVector<bool>
	{
		/// <summary>
		///	The number of elements (components) in a <see cref="Bool3"/>.
		/// </summary>
		public const int ELEMENT_COUNT = 3;
		
		/// <summary>
		///	The size of a <see cref="Bool3"/>, in bytes.
		/// </summary>
		public const int ELEMENT_SIZE = sizeof(bool);

		/// <summary>
		///	The size of a single element (component) within a <see cref="Bool3"/>, in bytes.
		/// </summary>
		public const int SIZE_OF = ELEMENT_COUNT * ELEMENT_SIZE;

		/// <summary>
		///	Gets the <see cref="Type"/> of each element in a <see cref="Bool3"/>.
		/// </summary>
		public static readonly Type ElementType = typeof(bool);

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
        /// Creates a new instance of <see cref="Bool3"/>.
        /// </summary>
		public Bool3(bool x, bool y, bool z)
		{
			X = x;
			Y = y;
			Z = z;
		}

        /// <summary>
        /// Creates a new instance of <see cref="Bool3"/>.
        /// </summary>
		public Bool3(Bool2 p, bool z)
		{
			X = p.X;
			Y = p.Y;
			Z = z;
		}

        /// <summary>
        /// Creates a new instance of <see cref="Bool3"/>.
        /// </summary>
		public Bool3(bool x, Bool2 p)
		{
			X = x;
			Y = p.X;
			Z = p.Y;
		}

		/// <summary>
		/// Gets or sets a component at the specified index for the current <see cref="Bool3"/> .
		/// </summary>
		public bool this[int index]
		{
			get
			{
				switch(index)
				{
					case 0: return X;
					case 1: return Y;
					case 2: return Z;
					default: throw new IndexOutOfRangeException("The maximum index of a Bool3 is 2.");
				}
			}
		}
		/// <summary>
		/// Gets a new <see cref="Bool2"/> comprised of X, X from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 XX => new Bool2(X, X);

		/// <summary>
		/// Gets a new <see cref="Bool2"/> comprised of R, R from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 RR => new Bool2(R, R);

		/// <summary>
		/// Gets or sets a <see cref="Bool2"/> comprised of X, Y on the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 XY
		{
			get => new Bool2(X, Y); 	
			set
			{
				X = value.X;
				Y = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Bool2"/> comprised of R, G on the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 RG
		{
			get => new Bool2(R, G);	
			set
			{
				R = value.R;
				G = value.G;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Bool2"/> comprised of X, Z on the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 XZ
		{
			get => new Bool2(X, Z); 	
			set
			{
				X = value.X;
				Z = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Bool2"/> comprised of R, B on the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 RB
		{
			get => new Bool2(R, B);	
			set
			{
				R = value.R;
				B = value.G;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Bool2"/> comprised of Y, X on the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 YX
		{
			get => new Bool2(Y, X); 	
			set
			{
				Y = value.X;
				X = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Bool2"/> comprised of G, R on the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 GR
		{
			get => new Bool2(G, R);	
			set
			{
				G = value.R;
				R = value.G;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Bool2"/> comprised of Y, Y from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 YY => new Bool2(Y, Y);

		/// <summary>
		/// Gets a new <see cref="Bool2"/> comprised of G, G from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 GG => new Bool2(G, G);

		/// <summary>
		/// Gets or sets a <see cref="Bool2"/> comprised of Y, Z on the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 YZ
		{
			get => new Bool2(Y, Z); 	
			set
			{
				Y = value.X;
				Z = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Bool2"/> comprised of G, B on the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 GB
		{
			get => new Bool2(G, B);	
			set
			{
				G = value.R;
				B = value.G;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Bool2"/> comprised of Z, X on the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 ZX
		{
			get => new Bool2(Z, X); 	
			set
			{
				Z = value.X;
				X = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Bool2"/> comprised of B, R on the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 BR
		{
			get => new Bool2(B, R);	
			set
			{
				B = value.R;
				R = value.G;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Bool2"/> comprised of Z, Y on the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 ZY
		{
			get => new Bool2(Z, Y); 	
			set
			{
				Z = value.X;
				Y = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Bool2"/> comprised of B, G on the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 BG
		{
			get => new Bool2(B, G);	
			set
			{
				B = value.R;
				G = value.G;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Bool2"/> comprised of Z, Z from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 ZZ => new Bool2(Z, Z);

		/// <summary>
		/// Gets a new <see cref="Bool2"/> comprised of B, B from the current <see cref="Bool2"/>.
		/// </summary>
		public Bool2 BB => new Bool2(B, B);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of X, X, X from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 XXX => new Bool3(X, X, X);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of R, R, R from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 RRR => new Bool3(R, R, R);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of X, X, Y from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 XXY => new Bool3(X, X, Y);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of R, R, G from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 RRG => new Bool3(R, R, G);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of X, X, Z from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 XXZ => new Bool3(X, X, Z);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of R, R, B from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 RRB => new Bool3(R, R, B);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of X, Y, X from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 XYX => new Bool3(X, Y, X);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of R, G, R from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 RGR => new Bool3(R, G, R);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of X, Y, Y from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 XYY => new Bool3(X, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of R, G, G from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 RGG => new Bool3(R, G, G);

		/// <summary>
		/// Gets or sets a <see cref="Bool3"/> comprised of X, Y, Z on the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 XYZ
		{
			get => new Bool3(X, Y, Z); 	
			set
			{
				X = value.X;
				Y = value.Y;
				Z = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Bool3"/> comprised of R, G, B on the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 RGB
		{
			get => new Bool3(R, G, B);	
			set
			{
				R = value.R;
				G = value.G;
				B = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of X, Z, X from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 XZX => new Bool3(X, Z, X);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of R, B, R from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 RBR => new Bool3(R, B, R);

		/// <summary>
		/// Gets or sets a <see cref="Bool3"/> comprised of X, Z, Y on the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 XZY
		{
			get => new Bool3(X, Z, Y); 	
			set
			{
				X = value.X;
				Z = value.Y;
				Y = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Bool3"/> comprised of R, B, G on the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 RBG
		{
			get => new Bool3(R, B, G);	
			set
			{
				R = value.R;
				B = value.G;
				G = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of X, Z, Z from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 XZZ => new Bool3(X, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of R, B, B from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 RBB => new Bool3(R, B, B);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of Y, X, X from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 YXX => new Bool3(Y, X, X);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of G, R, R from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 GRR => new Bool3(G, R, R);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of Y, X, Y from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 YXY => new Bool3(Y, X, Y);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of G, R, G from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 GRG => new Bool3(G, R, G);

		/// <summary>
		/// Gets or sets a <see cref="Bool3"/> comprised of Y, X, Z on the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 YXZ
		{
			get => new Bool3(Y, X, Z); 	
			set
			{
				Y = value.X;
				X = value.Y;
				Z = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Bool3"/> comprised of G, R, B on the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 GRB
		{
			get => new Bool3(G, R, B);	
			set
			{
				G = value.R;
				R = value.G;
				B = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of Y, Y, X from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 YYX => new Bool3(Y, Y, X);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of G, G, R from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 GGR => new Bool3(G, G, R);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of Y, Y, Y from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 YYY => new Bool3(Y, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of G, G, G from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 GGG => new Bool3(G, G, G);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of Y, Y, Z from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 YYZ => new Bool3(Y, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of G, G, B from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 GGB => new Bool3(G, G, B);

		/// <summary>
		/// Gets or sets a <see cref="Bool3"/> comprised of Y, Z, X on the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 YZX
		{
			get => new Bool3(Y, Z, X); 	
			set
			{
				Y = value.X;
				Z = value.Y;
				X = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Bool3"/> comprised of G, B, R on the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 GBR
		{
			get => new Bool3(G, B, R);	
			set
			{
				G = value.R;
				B = value.G;
				R = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of Y, Z, Y from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 YZY => new Bool3(Y, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of G, B, G from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 GBG => new Bool3(G, B, G);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of Y, Z, Z from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 YZZ => new Bool3(Y, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of G, B, B from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 GBB => new Bool3(G, B, B);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of Z, X, X from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 ZXX => new Bool3(Z, X, X);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of B, R, R from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 BRR => new Bool3(B, R, R);

		/// <summary>
		/// Gets or sets a <see cref="Bool3"/> comprised of Z, X, Y on the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 ZXY
		{
			get => new Bool3(Z, X, Y); 	
			set
			{
				Z = value.X;
				X = value.Y;
				Y = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Bool3"/> comprised of B, R, G on the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 BRG
		{
			get => new Bool3(B, R, G);	
			set
			{
				B = value.R;
				R = value.G;
				G = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of Z, X, Z from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 ZXZ => new Bool3(Z, X, Z);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of B, R, B from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 BRB => new Bool3(B, R, B);

		/// <summary>
		/// Gets or sets a <see cref="Bool3"/> comprised of Z, Y, X on the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 ZYX
		{
			get => new Bool3(Z, Y, X); 	
			set
			{
				Z = value.X;
				Y = value.Y;
				X = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Bool3"/> comprised of B, G, R on the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 BGR
		{
			get => new Bool3(B, G, R);	
			set
			{
				B = value.R;
				G = value.G;
				R = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of Z, Y, Y from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 ZYY => new Bool3(Z, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of B, G, G from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 BGG => new Bool3(B, G, G);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of Z, Y, Z from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 ZYZ => new Bool3(Z, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of B, G, B from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 BGB => new Bool3(B, G, B);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of Z, Z, X from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 ZZX => new Bool3(Z, Z, X);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of B, B, R from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 BBR => new Bool3(B, B, R);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of Z, Z, Y from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 ZZY => new Bool3(Z, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of B, B, G from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 BBG => new Bool3(B, B, G);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of Z, Z, Z from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 ZZZ => new Bool3(Z, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Bool3"/> comprised of B, B, B from the current <see cref="Bool3"/>.
		/// </summary>
		public Bool3 BBB => new Bool3(B, B, B);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of X, X, X, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XXXX => new Bool4(X, X, X, X);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of R, R, R, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RRRR => new Bool4(R, R, R, R);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of X, X, X, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XXXY => new Bool4(X, X, X, Y);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of R, R, R, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RRRG => new Bool4(R, R, R, G);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of X, X, X, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XXXZ => new Bool4(X, X, X, Z);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of R, R, R, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RRRB => new Bool4(R, R, R, B);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of X, X, Y, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XXYX => new Bool4(X, X, Y, X);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of R, R, G, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RRGR => new Bool4(R, R, G, R);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of X, X, Y, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XXYY => new Bool4(X, X, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of R, R, G, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RRGG => new Bool4(R, R, G, G);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of X, X, Y, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XXYZ => new Bool4(X, X, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of R, R, G, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RRGB => new Bool4(R, R, G, B);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of X, X, Z, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XXZX => new Bool4(X, X, Z, X);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of R, R, B, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RRBR => new Bool4(R, R, B, R);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of X, X, Z, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XXZY => new Bool4(X, X, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of R, R, B, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RRBG => new Bool4(R, R, B, G);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of X, X, Z, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XXZZ => new Bool4(X, X, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of R, R, B, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RRBB => new Bool4(R, R, B, B);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of X, Y, X, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XYXX => new Bool4(X, Y, X, X);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of R, G, R, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RGRR => new Bool4(R, G, R, R);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of X, Y, X, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XYXY => new Bool4(X, Y, X, Y);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of R, G, R, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RGRG => new Bool4(R, G, R, G);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of X, Y, X, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XYXZ => new Bool4(X, Y, X, Z);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of R, G, R, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RGRB => new Bool4(R, G, R, B);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of X, Y, Y, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XYYX => new Bool4(X, Y, Y, X);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of R, G, G, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RGGR => new Bool4(R, G, G, R);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of X, Y, Y, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XYYY => new Bool4(X, Y, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of R, G, G, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RGGG => new Bool4(R, G, G, G);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of X, Y, Y, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XYYZ => new Bool4(X, Y, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of R, G, G, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RGGB => new Bool4(R, G, G, B);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of X, Y, Z, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XYZX => new Bool4(X, Y, Z, X);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of R, G, B, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RGBR => new Bool4(R, G, B, R);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of X, Y, Z, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XYZY => new Bool4(X, Y, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of R, G, B, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RGBG => new Bool4(R, G, B, G);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of X, Y, Z, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XYZZ => new Bool4(X, Y, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of R, G, B, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RGBB => new Bool4(R, G, B, B);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of X, Z, X, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XZXX => new Bool4(X, Z, X, X);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of R, B, R, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RBRR => new Bool4(R, B, R, R);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of X, Z, X, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XZXY => new Bool4(X, Z, X, Y);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of R, B, R, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RBRG => new Bool4(R, B, R, G);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of X, Z, X, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XZXZ => new Bool4(X, Z, X, Z);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of R, B, R, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RBRB => new Bool4(R, B, R, B);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of X, Z, Y, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XZYX => new Bool4(X, Z, Y, X);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of R, B, G, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RBGR => new Bool4(R, B, G, R);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of X, Z, Y, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XZYY => new Bool4(X, Z, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of R, B, G, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RBGG => new Bool4(R, B, G, G);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of X, Z, Y, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XZYZ => new Bool4(X, Z, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of R, B, G, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RBGB => new Bool4(R, B, G, B);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of X, Z, Z, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XZZX => new Bool4(X, Z, Z, X);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of R, B, B, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RBBR => new Bool4(R, B, B, R);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of X, Z, Z, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XZZY => new Bool4(X, Z, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of R, B, B, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RBBG => new Bool4(R, B, B, G);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of X, Z, Z, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 XZZZ => new Bool4(X, Z, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of R, B, B, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 RBBB => new Bool4(R, B, B, B);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Y, X, X, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YXXX => new Bool4(Y, X, X, X);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of G, R, R, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GRRR => new Bool4(G, R, R, R);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Y, X, X, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YXXY => new Bool4(Y, X, X, Y);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of G, R, R, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GRRG => new Bool4(G, R, R, G);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Y, X, X, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YXXZ => new Bool4(Y, X, X, Z);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of G, R, R, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GRRB => new Bool4(G, R, R, B);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Y, X, Y, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YXYX => new Bool4(Y, X, Y, X);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of G, R, G, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GRGR => new Bool4(G, R, G, R);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Y, X, Y, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YXYY => new Bool4(Y, X, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of G, R, G, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GRGG => new Bool4(G, R, G, G);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Y, X, Y, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YXYZ => new Bool4(Y, X, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of G, R, G, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GRGB => new Bool4(G, R, G, B);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Y, X, Z, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YXZX => new Bool4(Y, X, Z, X);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of G, R, B, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GRBR => new Bool4(G, R, B, R);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Y, X, Z, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YXZY => new Bool4(Y, X, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of G, R, B, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GRBG => new Bool4(G, R, B, G);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Y, X, Z, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YXZZ => new Bool4(Y, X, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of G, R, B, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GRBB => new Bool4(G, R, B, B);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Y, Y, X, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YYXX => new Bool4(Y, Y, X, X);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of G, G, R, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GGRR => new Bool4(G, G, R, R);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Y, Y, X, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YYXY => new Bool4(Y, Y, X, Y);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of G, G, R, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GGRG => new Bool4(G, G, R, G);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Y, Y, X, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YYXZ => new Bool4(Y, Y, X, Z);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of G, G, R, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GGRB => new Bool4(G, G, R, B);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Y, Y, Y, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YYYX => new Bool4(Y, Y, Y, X);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of G, G, G, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GGGR => new Bool4(G, G, G, R);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Y, Y, Y, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YYYY => new Bool4(Y, Y, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of G, G, G, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GGGG => new Bool4(G, G, G, G);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Y, Y, Y, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YYYZ => new Bool4(Y, Y, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of G, G, G, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GGGB => new Bool4(G, G, G, B);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Y, Y, Z, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YYZX => new Bool4(Y, Y, Z, X);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of G, G, B, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GGBR => new Bool4(G, G, B, R);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Y, Y, Z, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YYZY => new Bool4(Y, Y, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of G, G, B, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GGBG => new Bool4(G, G, B, G);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Y, Y, Z, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YYZZ => new Bool4(Y, Y, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of G, G, B, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GGBB => new Bool4(G, G, B, B);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Y, Z, X, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YZXX => new Bool4(Y, Z, X, X);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of G, B, R, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GBRR => new Bool4(G, B, R, R);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Y, Z, X, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YZXY => new Bool4(Y, Z, X, Y);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of G, B, R, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GBRG => new Bool4(G, B, R, G);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Y, Z, X, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YZXZ => new Bool4(Y, Z, X, Z);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of G, B, R, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GBRB => new Bool4(G, B, R, B);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Y, Z, Y, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YZYX => new Bool4(Y, Z, Y, X);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of G, B, G, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GBGR => new Bool4(G, B, G, R);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Y, Z, Y, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YZYY => new Bool4(Y, Z, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of G, B, G, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GBGG => new Bool4(G, B, G, G);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Y, Z, Y, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YZYZ => new Bool4(Y, Z, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of G, B, G, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GBGB => new Bool4(G, B, G, B);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Y, Z, Z, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YZZX => new Bool4(Y, Z, Z, X);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of G, B, B, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GBBR => new Bool4(G, B, B, R);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Y, Z, Z, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YZZY => new Bool4(Y, Z, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of G, B, B, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GBBG => new Bool4(G, B, B, G);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Y, Z, Z, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 YZZZ => new Bool4(Y, Z, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of G, B, B, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 GBBB => new Bool4(G, B, B, B);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Z, X, X, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZXXX => new Bool4(Z, X, X, X);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of B, R, R, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BRRR => new Bool4(B, R, R, R);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Z, X, X, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZXXY => new Bool4(Z, X, X, Y);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of B, R, R, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BRRG => new Bool4(B, R, R, G);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Z, X, X, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZXXZ => new Bool4(Z, X, X, Z);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of B, R, R, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BRRB => new Bool4(B, R, R, B);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Z, X, Y, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZXYX => new Bool4(Z, X, Y, X);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of B, R, G, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BRGR => new Bool4(B, R, G, R);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Z, X, Y, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZXYY => new Bool4(Z, X, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of B, R, G, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BRGG => new Bool4(B, R, G, G);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Z, X, Y, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZXYZ => new Bool4(Z, X, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of B, R, G, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BRGB => new Bool4(B, R, G, B);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Z, X, Z, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZXZX => new Bool4(Z, X, Z, X);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of B, R, B, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BRBR => new Bool4(B, R, B, R);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Z, X, Z, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZXZY => new Bool4(Z, X, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of B, R, B, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BRBG => new Bool4(B, R, B, G);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Z, X, Z, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZXZZ => new Bool4(Z, X, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of B, R, B, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BRBB => new Bool4(B, R, B, B);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Z, Y, X, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZYXX => new Bool4(Z, Y, X, X);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of B, G, R, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BGRR => new Bool4(B, G, R, R);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Z, Y, X, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZYXY => new Bool4(Z, Y, X, Y);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of B, G, R, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BGRG => new Bool4(B, G, R, G);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Z, Y, X, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZYXZ => new Bool4(Z, Y, X, Z);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of B, G, R, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BGRB => new Bool4(B, G, R, B);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Z, Y, Y, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZYYX => new Bool4(Z, Y, Y, X);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of B, G, G, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BGGR => new Bool4(B, G, G, R);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Z, Y, Y, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZYYY => new Bool4(Z, Y, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of B, G, G, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BGGG => new Bool4(B, G, G, G);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Z, Y, Y, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZYYZ => new Bool4(Z, Y, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of B, G, G, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BGGB => new Bool4(B, G, G, B);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Z, Y, Z, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZYZX => new Bool4(Z, Y, Z, X);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of B, G, B, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BGBR => new Bool4(B, G, B, R);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Z, Y, Z, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZYZY => new Bool4(Z, Y, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of B, G, B, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BGBG => new Bool4(B, G, B, G);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Z, Y, Z, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZYZZ => new Bool4(Z, Y, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of B, G, B, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BGBB => new Bool4(B, G, B, B);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Z, Z, X, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZZXX => new Bool4(Z, Z, X, X);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of B, B, R, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BBRR => new Bool4(B, B, R, R);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Z, Z, X, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZZXY => new Bool4(Z, Z, X, Y);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of B, B, R, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BBRG => new Bool4(B, B, R, G);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Z, Z, X, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZZXZ => new Bool4(Z, Z, X, Z);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of B, B, R, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BBRB => new Bool4(B, B, R, B);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Z, Z, Y, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZZYX => new Bool4(Z, Z, Y, X);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of B, B, G, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BBGR => new Bool4(B, B, G, R);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Z, Z, Y, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZZYY => new Bool4(Z, Z, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of B, B, G, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BBGG => new Bool4(B, B, G, G);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Z, Z, Y, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZZYZ => new Bool4(Z, Z, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of B, B, G, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BBGB => new Bool4(B, B, G, B);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Z, Z, Z, X from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZZZX => new Bool4(Z, Z, Z, X);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of B, B, B, R from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BBBR => new Bool4(B, B, B, R);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Z, Z, Z, Y from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZZZY => new Bool4(Z, Z, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of B, B, B, G from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BBBG => new Bool4(B, B, B, G);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of Z, Z, Z, Z from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 ZZZZ => new Bool4(Z, Z, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Bool4"/> comprised of B, B, B, B from the current <see cref="Bool4"/>.
		/// </summary>
		public Bool4 BBBB => new Bool4(B, B, B, B);


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

	}
}
