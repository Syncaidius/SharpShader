using System;
using System.Runtime.InteropServices;

namespace SharpShader
{
	[StructLayout(LayoutKind.Sequential)]
	public struct UInt2 : IVector<uint>
	{
		/// <summary>
		///	The number of elements (components) in a <see cref="UInt2"/>.
		/// </summary>
		public const int ELEMENT_COUNT = 2;
		
		/// <summary>
		///	The size of a <see cref="UInt2"/>, in bytes.
		/// </summary>
		public const int ELEMENT_SIZE = sizeof(uint);

		/// <summary>
		///	The size of a single element (component) within a <see cref="UInt2"/>, in bytes.
		/// </summary>
		public const int SIZE_OF = ELEMENT_COUNT * ELEMENT_SIZE;

		/// <summary>
		///	Gets the <see cref="Type"/> of each element in a <see cref="UInt2"/>.
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
        /// Creates a new instance of <see cref="UInt2"/>.
        /// </summary>
		public UInt2(uint x, uint y)
		{
			X = x;
			Y = y;
		}

		/// <summary>
		/// Gets or sets a component at the specified index for the current <see cref="UInt2"/> .
		/// </summary>
		public uint this[int index]
		{
			get
			{
				switch(index)
				{
					case 0: return X;
					case 1: return Y;
					default: throw new IndexOutOfRangeException("The maximum index of a UInt2 is 1.");
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

		public static UInt2 operator +(UInt2 a, UInt2 b)
		{
			return new UInt2()
			{
				X = a.X + b.X,
				Y = a.Y + b.Y,
			};
		}
		public static UInt2 operator +(UInt2 a, int b)
		{
			return new UInt2()
			{
				X = (uint)(a.X + b),
				Y = (uint)(a.Y + b),
			};
		}

		public static UInt2 operator +(int a, UInt2 b)
		{
			return new UInt2()
			{
				X = (uint)(a + b.X),
				Y = (uint)(a + b.Y),
			};
		}
		public static UInt2 operator +(UInt2 a, float b)
		{
			return new UInt2()
			{
				X = (uint)(a.X + b),
				Y = (uint)(a.Y + b),
			};
		}

		public static UInt2 operator +(float a, UInt2 b)
		{
			return new UInt2()
			{
				X = (uint)(a + b.X),
				Y = (uint)(a + b.Y),
			};
		}
		public static UInt2 operator +(UInt2 a, double b)
		{
			return new UInt2()
			{
				X = (uint)(a.X + b),
				Y = (uint)(a.Y + b),
			};
		}

		public static UInt2 operator +(double a, UInt2 b)
		{
			return new UInt2()
			{
				X = (uint)(a + b.X),
				Y = (uint)(a + b.Y),
			};
		}
		public static UInt2 operator -(UInt2 a, UInt2 b)
		{
			return new UInt2()
			{
				X = a.X - b.X,
				Y = a.Y - b.Y,
			};
		}
		public static UInt2 operator -(UInt2 a, int b)
		{
			return new UInt2()
			{
				X = (uint)(a.X - b),
				Y = (uint)(a.Y - b),
			};
		}

		public static UInt2 operator -(int a, UInt2 b)
		{
			return new UInt2()
			{
				X = (uint)(a - b.X),
				Y = (uint)(a - b.Y),
			};
		}
		public static UInt2 operator -(UInt2 a, float b)
		{
			return new UInt2()
			{
				X = (uint)(a.X - b),
				Y = (uint)(a.Y - b),
			};
		}

		public static UInt2 operator -(float a, UInt2 b)
		{
			return new UInt2()
			{
				X = (uint)(a - b.X),
				Y = (uint)(a - b.Y),
			};
		}
		public static UInt2 operator -(UInt2 a, double b)
		{
			return new UInt2()
			{
				X = (uint)(a.X - b),
				Y = (uint)(a.Y - b),
			};
		}

		public static UInt2 operator -(double a, UInt2 b)
		{
			return new UInt2()
			{
				X = (uint)(a - b.X),
				Y = (uint)(a - b.Y),
			};
		}
		public static UInt2 operator *(UInt2 a, UInt2 b)
		{
			return new UInt2()
			{
				X = a.X * b.X,
				Y = a.Y * b.Y,
			};
		}
		public static UInt2 operator *(UInt2 a, int b)
		{
			return new UInt2()
			{
				X = (uint)(a.X * b),
				Y = (uint)(a.Y * b),
			};
		}

		public static UInt2 operator *(int a, UInt2 b)
		{
			return new UInt2()
			{
				X = (uint)(a * b.X),
				Y = (uint)(a * b.Y),
			};
		}
		public static UInt2 operator *(UInt2 a, float b)
		{
			return new UInt2()
			{
				X = (uint)(a.X * b),
				Y = (uint)(a.Y * b),
			};
		}

		public static UInt2 operator *(float a, UInt2 b)
		{
			return new UInt2()
			{
				X = (uint)(a * b.X),
				Y = (uint)(a * b.Y),
			};
		}
		public static UInt2 operator *(UInt2 a, double b)
		{
			return new UInt2()
			{
				X = (uint)(a.X * b),
				Y = (uint)(a.Y * b),
			};
		}

		public static UInt2 operator *(double a, UInt2 b)
		{
			return new UInt2()
			{
				X = (uint)(a * b.X),
				Y = (uint)(a * b.Y),
			};
		}
		public static UInt2 operator /(UInt2 a, UInt2 b)
		{
			return new UInt2()
			{
				X = a.X / b.X,
				Y = a.Y / b.Y,
			};
		}
		public static UInt2 operator /(UInt2 a, int b)
		{
			return new UInt2()
			{
				X = (uint)(a.X / b),
				Y = (uint)(a.Y / b),
			};
		}

		public static UInt2 operator /(int a, UInt2 b)
		{
			return new UInt2()
			{
				X = (uint)(a / b.X),
				Y = (uint)(a / b.Y),
			};
		}
		public static UInt2 operator /(UInt2 a, float b)
		{
			return new UInt2()
			{
				X = (uint)(a.X / b),
				Y = (uint)(a.Y / b),
			};
		}

		public static UInt2 operator /(float a, UInt2 b)
		{
			return new UInt2()
			{
				X = (uint)(a / b.X),
				Y = (uint)(a / b.Y),
			};
		}
		public static UInt2 operator /(UInt2 a, double b)
		{
			return new UInt2()
			{
				X = (uint)(a.X / b),
				Y = (uint)(a.Y / b),
			};
		}

		public static UInt2 operator /(double a, UInt2 b)
		{
			return new UInt2()
			{
				X = (uint)(a / b.X),
				Y = (uint)(a / b.Y),
			};
		}
		public static explicit operator Vector2(UInt2 val)
		{
			return new Vector2()
			{
				X = (float)val.X,
				Y = (float)val.Y,
			};
		}

		public static explicit operator Int2(UInt2 val)
		{
			return new Int2()
			{
				X = (int)val.X,
				Y = (int)val.Y,
			};
		}

		public static explicit operator Double2(UInt2 val)
		{
			return new Double2()
			{
				X = (double)val.X,
				Y = (double)val.Y,
			};
		}

	}
}
