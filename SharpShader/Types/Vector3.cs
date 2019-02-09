using System;
using System.Runtime.InteropServices;

namespace SharpShader
{
	[StructLayout(LayoutKind.Sequential)]
	public struct Vector3 : IVector<float>, IIntrinsicValue<float>
	{
		/// <summary>
		///	The number of elements (components) in a <see cref="Vector3"/>.
		/// </summary>
		public const int ELEMENT_COUNT = 3;
		
		/// <summary>
		///	The size of a <see cref="Vector3"/>, in bytes.
		/// </summary>
		public const int ELEMENT_SIZE = sizeof(float);

		/// <summary>
		///	The size of a single element (component) within a <see cref="Vector3"/>, in bytes.
		/// </summary>
		public const int SIZE_OF = ELEMENT_COUNT * ELEMENT_SIZE;

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
        /// Creates a new instance of <see cref="Vector3"/>.
        /// </summary>
		public Vector3(float x, float y, float z)
		{
			X = x;
			Y = y;
			Z = z;
		}

        /// <summary>
        /// Creates a new instance of <see cref="Vector3"/>.
        /// </summary>
		public Vector3(Vector2 p, float z)
		{
			X = p.X;
			Y = p.Y;
			Z = z;
		}

        /// <summary>
        /// Creates a new instance of <see cref="Vector3"/>.
        /// </summary>
		public Vector3(float x, Vector2 p)
		{
			X = x;
			Y = p.X;
			Z = p.Y;
		}

		/// <summary>
		/// Gets or sets a component at the specified index for the current <see cref="Vector3"/> .
		/// </summary>
		public float this[int index]
		{
			get
			{
				switch(index)
				{
					case 0: return X;
					case 1: return Y;
					case 2: return Z;
					default: throw new IndexOutOfRangeException("The maximum index of a Vector3 is 2.");
				}
			}
		}
		/// <summary>
		/// Gets a new <see cref="Vector2"/> comprised of X, X from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 XX => new Vector2(X, X);

		/// <summary>
		/// Gets a new <see cref="Vector2"/> comprised of R, R from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 RR => new Vector2(R, R);

		/// <summary>
		/// Gets or sets a <see cref="Vector2"/> comprised of X, Y on the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 XY
		{
			get => new Vector2(X, Y); 	
			set
			{
				X = value.X;
				Y = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Vector2"/> comprised of R, G on the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 RG
		{
			get => new Vector2(R, G);	
			set
			{
				R = value.R;
				G = value.G;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Vector2"/> comprised of X, Z on the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 XZ
		{
			get => new Vector2(X, Z); 	
			set
			{
				X = value.X;
				Z = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Vector2"/> comprised of R, B on the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 RB
		{
			get => new Vector2(R, B);	
			set
			{
				R = value.R;
				B = value.G;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Vector2"/> comprised of Y, X on the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 YX
		{
			get => new Vector2(Y, X); 	
			set
			{
				Y = value.X;
				X = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Vector2"/> comprised of G, R on the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 GR
		{
			get => new Vector2(G, R);	
			set
			{
				G = value.R;
				R = value.G;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Vector2"/> comprised of Y, Y from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 YY => new Vector2(Y, Y);

		/// <summary>
		/// Gets a new <see cref="Vector2"/> comprised of G, G from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 GG => new Vector2(G, G);

		/// <summary>
		/// Gets or sets a <see cref="Vector2"/> comprised of Y, Z on the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 YZ
		{
			get => new Vector2(Y, Z); 	
			set
			{
				Y = value.X;
				Z = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Vector2"/> comprised of G, B on the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 GB
		{
			get => new Vector2(G, B);	
			set
			{
				G = value.R;
				B = value.G;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Vector2"/> comprised of Z, X on the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 ZX
		{
			get => new Vector2(Z, X); 	
			set
			{
				Z = value.X;
				X = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Vector2"/> comprised of B, R on the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 BR
		{
			get => new Vector2(B, R);	
			set
			{
				B = value.R;
				R = value.G;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Vector2"/> comprised of Z, Y on the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 ZY
		{
			get => new Vector2(Z, Y); 	
			set
			{
				Z = value.X;
				Y = value.Y;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Vector2"/> comprised of B, G on the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 BG
		{
			get => new Vector2(B, G);	
			set
			{
				B = value.R;
				G = value.G;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Vector2"/> comprised of Z, Z from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 ZZ => new Vector2(Z, Z);

		/// <summary>
		/// Gets a new <see cref="Vector2"/> comprised of B, B from the current <see cref="Vector2"/>.
		/// </summary>
		public Vector2 BB => new Vector2(B, B);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of X, X, X from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 XXX => new Vector3(X, X, X);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of R, R, R from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 RRR => new Vector3(R, R, R);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of X, X, Y from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 XXY => new Vector3(X, X, Y);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of R, R, G from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 RRG => new Vector3(R, R, G);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of X, X, Z from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 XXZ => new Vector3(X, X, Z);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of R, R, B from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 RRB => new Vector3(R, R, B);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of X, Y, X from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 XYX => new Vector3(X, Y, X);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of R, G, R from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 RGR => new Vector3(R, G, R);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of X, Y, Y from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 XYY => new Vector3(X, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of R, G, G from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 RGG => new Vector3(R, G, G);

		/// <summary>
		/// Gets or sets a <see cref="Vector3"/> comprised of X, Y, Z on the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 XYZ
		{
			get => new Vector3(X, Y, Z); 	
			set
			{
				X = value.X;
				Y = value.Y;
				Z = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Vector3"/> comprised of R, G, B on the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 RGB
		{
			get => new Vector3(R, G, B);	
			set
			{
				R = value.R;
				G = value.G;
				B = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of X, Z, X from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 XZX => new Vector3(X, Z, X);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of R, B, R from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 RBR => new Vector3(R, B, R);

		/// <summary>
		/// Gets or sets a <see cref="Vector3"/> comprised of X, Z, Y on the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 XZY
		{
			get => new Vector3(X, Z, Y); 	
			set
			{
				X = value.X;
				Z = value.Y;
				Y = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Vector3"/> comprised of R, B, G on the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 RBG
		{
			get => new Vector3(R, B, G);	
			set
			{
				R = value.R;
				B = value.G;
				G = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of X, Z, Z from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 XZZ => new Vector3(X, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of R, B, B from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 RBB => new Vector3(R, B, B);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of Y, X, X from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 YXX => new Vector3(Y, X, X);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of G, R, R from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 GRR => new Vector3(G, R, R);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of Y, X, Y from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 YXY => new Vector3(Y, X, Y);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of G, R, G from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 GRG => new Vector3(G, R, G);

		/// <summary>
		/// Gets or sets a <see cref="Vector3"/> comprised of Y, X, Z on the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 YXZ
		{
			get => new Vector3(Y, X, Z); 	
			set
			{
				Y = value.X;
				X = value.Y;
				Z = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Vector3"/> comprised of G, R, B on the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 GRB
		{
			get => new Vector3(G, R, B);	
			set
			{
				G = value.R;
				R = value.G;
				B = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of Y, Y, X from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 YYX => new Vector3(Y, Y, X);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of G, G, R from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 GGR => new Vector3(G, G, R);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of Y, Y, Y from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 YYY => new Vector3(Y, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of G, G, G from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 GGG => new Vector3(G, G, G);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of Y, Y, Z from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 YYZ => new Vector3(Y, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of G, G, B from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 GGB => new Vector3(G, G, B);

		/// <summary>
		/// Gets or sets a <see cref="Vector3"/> comprised of Y, Z, X on the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 YZX
		{
			get => new Vector3(Y, Z, X); 	
			set
			{
				Y = value.X;
				Z = value.Y;
				X = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Vector3"/> comprised of G, B, R on the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 GBR
		{
			get => new Vector3(G, B, R);	
			set
			{
				G = value.R;
				B = value.G;
				R = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of Y, Z, Y from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 YZY => new Vector3(Y, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of G, B, G from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 GBG => new Vector3(G, B, G);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of Y, Z, Z from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 YZZ => new Vector3(Y, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of G, B, B from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 GBB => new Vector3(G, B, B);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of Z, X, X from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 ZXX => new Vector3(Z, X, X);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of B, R, R from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 BRR => new Vector3(B, R, R);

		/// <summary>
		/// Gets or sets a <see cref="Vector3"/> comprised of Z, X, Y on the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 ZXY
		{
			get => new Vector3(Z, X, Y); 	
			set
			{
				Z = value.X;
				X = value.Y;
				Y = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Vector3"/> comprised of B, R, G on the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 BRG
		{
			get => new Vector3(B, R, G);	
			set
			{
				B = value.R;
				R = value.G;
				G = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of Z, X, Z from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 ZXZ => new Vector3(Z, X, Z);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of B, R, B from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 BRB => new Vector3(B, R, B);

		/// <summary>
		/// Gets or sets a <see cref="Vector3"/> comprised of Z, Y, X on the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 ZYX
		{
			get => new Vector3(Z, Y, X); 	
			set
			{
				Z = value.X;
				Y = value.Y;
				X = value.Z;
			}
		}

		/// <summary>
		/// Gets or sets a <see cref="Vector3"/> comprised of B, G, R on the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 BGR
		{
			get => new Vector3(B, G, R);	
			set
			{
				B = value.R;
				G = value.G;
				R = value.B;
			}
		}

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of Z, Y, Y from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 ZYY => new Vector3(Z, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of B, G, G from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 BGG => new Vector3(B, G, G);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of Z, Y, Z from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 ZYZ => new Vector3(Z, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of B, G, B from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 BGB => new Vector3(B, G, B);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of Z, Z, X from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 ZZX => new Vector3(Z, Z, X);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of B, B, R from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 BBR => new Vector3(B, B, R);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of Z, Z, Y from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 ZZY => new Vector3(Z, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of B, B, G from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 BBG => new Vector3(B, B, G);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of Z, Z, Z from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 ZZZ => new Vector3(Z, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Vector3"/> comprised of B, B, B from the current <see cref="Vector3"/>.
		/// </summary>
		public Vector3 BBB => new Vector3(B, B, B);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of X, X, X, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XXXX => new Vector4(X, X, X, X);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of R, R, R, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RRRR => new Vector4(R, R, R, R);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of X, X, X, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XXXY => new Vector4(X, X, X, Y);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of R, R, R, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RRRG => new Vector4(R, R, R, G);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of X, X, X, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XXXZ => new Vector4(X, X, X, Z);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of R, R, R, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RRRB => new Vector4(R, R, R, B);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of X, X, Y, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XXYX => new Vector4(X, X, Y, X);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of R, R, G, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RRGR => new Vector4(R, R, G, R);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of X, X, Y, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XXYY => new Vector4(X, X, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of R, R, G, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RRGG => new Vector4(R, R, G, G);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of X, X, Y, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XXYZ => new Vector4(X, X, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of R, R, G, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RRGB => new Vector4(R, R, G, B);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of X, X, Z, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XXZX => new Vector4(X, X, Z, X);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of R, R, B, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RRBR => new Vector4(R, R, B, R);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of X, X, Z, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XXZY => new Vector4(X, X, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of R, R, B, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RRBG => new Vector4(R, R, B, G);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of X, X, Z, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XXZZ => new Vector4(X, X, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of R, R, B, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RRBB => new Vector4(R, R, B, B);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of X, Y, X, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XYXX => new Vector4(X, Y, X, X);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of R, G, R, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RGRR => new Vector4(R, G, R, R);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of X, Y, X, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XYXY => new Vector4(X, Y, X, Y);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of R, G, R, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RGRG => new Vector4(R, G, R, G);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of X, Y, X, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XYXZ => new Vector4(X, Y, X, Z);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of R, G, R, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RGRB => new Vector4(R, G, R, B);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of X, Y, Y, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XYYX => new Vector4(X, Y, Y, X);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of R, G, G, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RGGR => new Vector4(R, G, G, R);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of X, Y, Y, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XYYY => new Vector4(X, Y, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of R, G, G, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RGGG => new Vector4(R, G, G, G);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of X, Y, Y, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XYYZ => new Vector4(X, Y, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of R, G, G, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RGGB => new Vector4(R, G, G, B);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of X, Y, Z, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XYZX => new Vector4(X, Y, Z, X);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of R, G, B, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RGBR => new Vector4(R, G, B, R);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of X, Y, Z, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XYZY => new Vector4(X, Y, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of R, G, B, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RGBG => new Vector4(R, G, B, G);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of X, Y, Z, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XYZZ => new Vector4(X, Y, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of R, G, B, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RGBB => new Vector4(R, G, B, B);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of X, Z, X, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XZXX => new Vector4(X, Z, X, X);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of R, B, R, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RBRR => new Vector4(R, B, R, R);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of X, Z, X, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XZXY => new Vector4(X, Z, X, Y);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of R, B, R, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RBRG => new Vector4(R, B, R, G);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of X, Z, X, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XZXZ => new Vector4(X, Z, X, Z);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of R, B, R, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RBRB => new Vector4(R, B, R, B);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of X, Z, Y, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XZYX => new Vector4(X, Z, Y, X);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of R, B, G, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RBGR => new Vector4(R, B, G, R);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of X, Z, Y, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XZYY => new Vector4(X, Z, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of R, B, G, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RBGG => new Vector4(R, B, G, G);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of X, Z, Y, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XZYZ => new Vector4(X, Z, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of R, B, G, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RBGB => new Vector4(R, B, G, B);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of X, Z, Z, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XZZX => new Vector4(X, Z, Z, X);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of R, B, B, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RBBR => new Vector4(R, B, B, R);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of X, Z, Z, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XZZY => new Vector4(X, Z, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of R, B, B, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RBBG => new Vector4(R, B, B, G);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of X, Z, Z, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 XZZZ => new Vector4(X, Z, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of R, B, B, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 RBBB => new Vector4(R, B, B, B);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Y, X, X, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YXXX => new Vector4(Y, X, X, X);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of G, R, R, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GRRR => new Vector4(G, R, R, R);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Y, X, X, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YXXY => new Vector4(Y, X, X, Y);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of G, R, R, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GRRG => new Vector4(G, R, R, G);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Y, X, X, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YXXZ => new Vector4(Y, X, X, Z);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of G, R, R, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GRRB => new Vector4(G, R, R, B);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Y, X, Y, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YXYX => new Vector4(Y, X, Y, X);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of G, R, G, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GRGR => new Vector4(G, R, G, R);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Y, X, Y, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YXYY => new Vector4(Y, X, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of G, R, G, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GRGG => new Vector4(G, R, G, G);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Y, X, Y, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YXYZ => new Vector4(Y, X, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of G, R, G, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GRGB => new Vector4(G, R, G, B);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Y, X, Z, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YXZX => new Vector4(Y, X, Z, X);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of G, R, B, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GRBR => new Vector4(G, R, B, R);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Y, X, Z, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YXZY => new Vector4(Y, X, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of G, R, B, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GRBG => new Vector4(G, R, B, G);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Y, X, Z, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YXZZ => new Vector4(Y, X, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of G, R, B, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GRBB => new Vector4(G, R, B, B);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Y, Y, X, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YYXX => new Vector4(Y, Y, X, X);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of G, G, R, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GGRR => new Vector4(G, G, R, R);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Y, Y, X, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YYXY => new Vector4(Y, Y, X, Y);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of G, G, R, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GGRG => new Vector4(G, G, R, G);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Y, Y, X, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YYXZ => new Vector4(Y, Y, X, Z);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of G, G, R, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GGRB => new Vector4(G, G, R, B);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Y, Y, Y, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YYYX => new Vector4(Y, Y, Y, X);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of G, G, G, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GGGR => new Vector4(G, G, G, R);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Y, Y, Y, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YYYY => new Vector4(Y, Y, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of G, G, G, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GGGG => new Vector4(G, G, G, G);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Y, Y, Y, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YYYZ => new Vector4(Y, Y, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of G, G, G, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GGGB => new Vector4(G, G, G, B);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Y, Y, Z, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YYZX => new Vector4(Y, Y, Z, X);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of G, G, B, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GGBR => new Vector4(G, G, B, R);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Y, Y, Z, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YYZY => new Vector4(Y, Y, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of G, G, B, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GGBG => new Vector4(G, G, B, G);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Y, Y, Z, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YYZZ => new Vector4(Y, Y, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of G, G, B, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GGBB => new Vector4(G, G, B, B);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Y, Z, X, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YZXX => new Vector4(Y, Z, X, X);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of G, B, R, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GBRR => new Vector4(G, B, R, R);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Y, Z, X, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YZXY => new Vector4(Y, Z, X, Y);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of G, B, R, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GBRG => new Vector4(G, B, R, G);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Y, Z, X, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YZXZ => new Vector4(Y, Z, X, Z);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of G, B, R, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GBRB => new Vector4(G, B, R, B);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Y, Z, Y, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YZYX => new Vector4(Y, Z, Y, X);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of G, B, G, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GBGR => new Vector4(G, B, G, R);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Y, Z, Y, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YZYY => new Vector4(Y, Z, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of G, B, G, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GBGG => new Vector4(G, B, G, G);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Y, Z, Y, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YZYZ => new Vector4(Y, Z, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of G, B, G, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GBGB => new Vector4(G, B, G, B);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Y, Z, Z, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YZZX => new Vector4(Y, Z, Z, X);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of G, B, B, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GBBR => new Vector4(G, B, B, R);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Y, Z, Z, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YZZY => new Vector4(Y, Z, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of G, B, B, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GBBG => new Vector4(G, B, B, G);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Y, Z, Z, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 YZZZ => new Vector4(Y, Z, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of G, B, B, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 GBBB => new Vector4(G, B, B, B);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Z, X, X, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZXXX => new Vector4(Z, X, X, X);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of B, R, R, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BRRR => new Vector4(B, R, R, R);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Z, X, X, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZXXY => new Vector4(Z, X, X, Y);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of B, R, R, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BRRG => new Vector4(B, R, R, G);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Z, X, X, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZXXZ => new Vector4(Z, X, X, Z);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of B, R, R, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BRRB => new Vector4(B, R, R, B);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Z, X, Y, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZXYX => new Vector4(Z, X, Y, X);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of B, R, G, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BRGR => new Vector4(B, R, G, R);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Z, X, Y, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZXYY => new Vector4(Z, X, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of B, R, G, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BRGG => new Vector4(B, R, G, G);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Z, X, Y, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZXYZ => new Vector4(Z, X, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of B, R, G, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BRGB => new Vector4(B, R, G, B);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Z, X, Z, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZXZX => new Vector4(Z, X, Z, X);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of B, R, B, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BRBR => new Vector4(B, R, B, R);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Z, X, Z, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZXZY => new Vector4(Z, X, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of B, R, B, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BRBG => new Vector4(B, R, B, G);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Z, X, Z, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZXZZ => new Vector4(Z, X, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of B, R, B, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BRBB => new Vector4(B, R, B, B);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Z, Y, X, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZYXX => new Vector4(Z, Y, X, X);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of B, G, R, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BGRR => new Vector4(B, G, R, R);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Z, Y, X, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZYXY => new Vector4(Z, Y, X, Y);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of B, G, R, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BGRG => new Vector4(B, G, R, G);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Z, Y, X, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZYXZ => new Vector4(Z, Y, X, Z);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of B, G, R, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BGRB => new Vector4(B, G, R, B);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Z, Y, Y, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZYYX => new Vector4(Z, Y, Y, X);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of B, G, G, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BGGR => new Vector4(B, G, G, R);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Z, Y, Y, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZYYY => new Vector4(Z, Y, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of B, G, G, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BGGG => new Vector4(B, G, G, G);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Z, Y, Y, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZYYZ => new Vector4(Z, Y, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of B, G, G, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BGGB => new Vector4(B, G, G, B);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Z, Y, Z, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZYZX => new Vector4(Z, Y, Z, X);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of B, G, B, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BGBR => new Vector4(B, G, B, R);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Z, Y, Z, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZYZY => new Vector4(Z, Y, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of B, G, B, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BGBG => new Vector4(B, G, B, G);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Z, Y, Z, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZYZZ => new Vector4(Z, Y, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of B, G, B, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BGBB => new Vector4(B, G, B, B);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Z, Z, X, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZZXX => new Vector4(Z, Z, X, X);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of B, B, R, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BBRR => new Vector4(B, B, R, R);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Z, Z, X, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZZXY => new Vector4(Z, Z, X, Y);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of B, B, R, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BBRG => new Vector4(B, B, R, G);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Z, Z, X, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZZXZ => new Vector4(Z, Z, X, Z);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of B, B, R, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BBRB => new Vector4(B, B, R, B);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Z, Z, Y, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZZYX => new Vector4(Z, Z, Y, X);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of B, B, G, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BBGR => new Vector4(B, B, G, R);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Z, Z, Y, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZZYY => new Vector4(Z, Z, Y, Y);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of B, B, G, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BBGG => new Vector4(B, B, G, G);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Z, Z, Y, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZZYZ => new Vector4(Z, Z, Y, Z);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of B, B, G, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BBGB => new Vector4(B, B, G, B);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Z, Z, Z, X from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZZZX => new Vector4(Z, Z, Z, X);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of B, B, B, R from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BBBR => new Vector4(B, B, B, R);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Z, Z, Z, Y from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZZZY => new Vector4(Z, Z, Z, Y);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of B, B, B, G from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BBBG => new Vector4(B, B, B, G);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of Z, Z, Z, Z from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 ZZZZ => new Vector4(Z, Z, Z, Z);

		/// <summary>
		/// Gets a new <see cref="Vector4"/> comprised of B, B, B, B from the current <see cref="Vector4"/>.
		/// </summary>
		public Vector4 BBBB => new Vector4(B, B, B, B);

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

		public static Vector3 operator +(Vector3 a, Vector3 b)
		{
			return new Vector3()
			{
				X = a.X + b.X,
				Y = a.Y + b.Y,
				Z = a.Z + b.Z,
			};
		}
		public static Vector3 operator +(Vector3 a, int b)
		{
			return new Vector3()
			{
				X = (float)(a.X + b),
				Y = (float)(a.Y + b),
				Z = (float)(a.Z + b),
			};
		}

		public static Vector3 operator +(int a, Vector3 b)
		{
			return new Vector3()
			{
				X = (float)(a + b.X),
				Y = (float)(a + b.Y),
				Z = (float)(a + b.Z),
			};
		}
		public static Vector3 operator +(Vector3 a, float b)
		{
			return new Vector3()
			{
				X = (float)(a.X + b),
				Y = (float)(a.Y + b),
				Z = (float)(a.Z + b),
			};
		}

		public static Vector3 operator +(float a, Vector3 b)
		{
			return new Vector3()
			{
				X = (a + b.X),
				Y = (a + b.Y),
				Z = (a + b.Z),
			};
		}
		public static Vector3 operator +(Vector3 a, double b)
		{
			return new Vector3()
			{
				X = (float)(a.X + b),
				Y = (float)(a.Y + b),
				Z = (float)(a.Z + b),
			};
		}

		public static Vector3 operator +(double a, Vector3 b)
		{
			return new Vector3()
			{
				X = (float)(a + b.X),
				Y = (float)(a + b.Y),
				Z = (float)(a + b.Z),
			};
		}
		public static Vector3 operator -(Vector3 a, Vector3 b)
		{
			return new Vector3()
			{
				X = a.X - b.X,
				Y = a.Y - b.Y,
				Z = a.Z - b.Z,
			};
		}
		public static Vector3 operator -(Vector3 a, int b)
		{
			return new Vector3()
			{
				X = (float)(a.X - b),
				Y = (float)(a.Y - b),
				Z = (float)(a.Z - b),
			};
		}

		public static Vector3 operator -(int a, Vector3 b)
		{
			return new Vector3()
			{
				X = (float)(a - b.X),
				Y = (float)(a - b.Y),
				Z = (float)(a - b.Z),
			};
		}
		public static Vector3 operator -(Vector3 a, float b)
		{
			return new Vector3()
			{
				X = (float)(a.X - b),
				Y = (float)(a.Y - b),
				Z = (float)(a.Z - b),
			};
		}

		public static Vector3 operator -(float a, Vector3 b)
		{
			return new Vector3()
			{
				X = (a - b.X),
				Y = (a - b.Y),
				Z = (a - b.Z),
			};
		}
		public static Vector3 operator -(Vector3 a, double b)
		{
			return new Vector3()
			{
				X = (float)(a.X - b),
				Y = (float)(a.Y - b),
				Z = (float)(a.Z - b),
			};
		}

		public static Vector3 operator -(double a, Vector3 b)
		{
			return new Vector3()
			{
				X = (float)(a - b.X),
				Y = (float)(a - b.Y),
				Z = (float)(a - b.Z),
			};
		}
		public static Vector3 operator *(Vector3 a, Vector3 b)
		{
			return new Vector3()
			{
				X = a.X * b.X,
				Y = a.Y * b.Y,
				Z = a.Z * b.Z,
			};
		}
		public static Vector3 operator *(Vector3 a, int b)
		{
			return new Vector3()
			{
				X = (float)(a.X * b),
				Y = (float)(a.Y * b),
				Z = (float)(a.Z * b),
			};
		}

		public static Vector3 operator *(int a, Vector3 b)
		{
			return new Vector3()
			{
				X = (float)(a * b.X),
				Y = (float)(a * b.Y),
				Z = (float)(a * b.Z),
			};
		}
		public static Vector3 operator *(Vector3 a, float b)
		{
			return new Vector3()
			{
				X = (float)(a.X * b),
				Y = (float)(a.Y * b),
				Z = (float)(a.Z * b),
			};
		}

		public static Vector3 operator *(float a, Vector3 b)
		{
			return new Vector3()
			{
				X = (a * b.X),
				Y = (a * b.Y),
				Z = (a * b.Z),
			};
		}
		public static Vector3 operator *(Vector3 a, double b)
		{
			return new Vector3()
			{
				X = (float)(a.X * b),
				Y = (float)(a.Y * b),
				Z = (float)(a.Z * b),
			};
		}

		public static Vector3 operator *(double a, Vector3 b)
		{
			return new Vector3()
			{
				X = (float)(a * b.X),
				Y = (float)(a * b.Y),
				Z = (float)(a * b.Z),
			};
		}
		public static Vector3 operator /(Vector3 a, Vector3 b)
		{
			return new Vector3()
			{
				X = a.X / b.X,
				Y = a.Y / b.Y,
				Z = a.Z / b.Z,
			};
		}
		public static Vector3 operator /(Vector3 a, int b)
		{
			return new Vector3()
			{
				X = (float)(a.X / b),
				Y = (float)(a.Y / b),
				Z = (float)(a.Z / b),
			};
		}

		public static Vector3 operator /(int a, Vector3 b)
		{
			return new Vector3()
			{
				X = (float)(a / b.X),
				Y = (float)(a / b.Y),
				Z = (float)(a / b.Z),
			};
		}
		public static Vector3 operator /(Vector3 a, float b)
		{
			return new Vector3()
			{
				X = (float)(a.X / b),
				Y = (float)(a.Y / b),
				Z = (float)(a.Z / b),
			};
		}

		public static Vector3 operator /(float a, Vector3 b)
		{
			return new Vector3()
			{
				X = (a / b.X),
				Y = (a / b.Y),
				Z = (a / b.Z),
			};
		}
		public static Vector3 operator /(Vector3 a, double b)
		{
			return new Vector3()
			{
				X = (float)(a.X / b),
				Y = (float)(a.Y / b),
				Z = (float)(a.Z / b),
			};
		}

		public static Vector3 operator /(double a, Vector3 b)
		{
			return new Vector3()
			{
				X = (float)(a / b.X),
				Y = (float)(a / b.Y),
				Z = (float)(a / b.Z),
			};
		}
	}
}
