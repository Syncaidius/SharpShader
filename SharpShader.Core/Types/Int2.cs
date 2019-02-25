using System;
using System.Runtime.InteropServices;

namespace SharpShader
{
	[StructLayout(LayoutKind.Sequential)]
	public struct Int2 : IVector<int>, IIntrinsicValue<int>
	{
		/// <summary>
		///	The number of elements (components) in a <see cref="Int2"/>.
		/// </summary>
		public const int ELEMENT_COUNT = 2;
		
		/// <summary>
		///	The size of a <see cref="Int2"/>, in bytes.
		/// </summary>
		public const int ELEMENT_SIZE = sizeof(int);

		/// <summary>
		///	The size of a single element (component) within a <see cref="Int2"/>, in bytes.
		/// </summary>
		public const int SIZE_OF = ELEMENT_COUNT * ELEMENT_SIZE;

		/// <summary>
		///	Gets the <see cref="Type"/> of each element in a <see cref="Int2"/>.
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
        /// Creates a new instance of <see cref="Int2"/>.
        /// </summary>
		public Int2(int x, int y)
		{
			X = x;
			Y = y;
		}

		/// <summary>
		/// Gets or sets a component at the specified index for the current <see cref="Int2"/> .
		/// </summary>
		public int this[int index]
		{
			get
			{
				switch(index)
				{
					case 0: return X;
					case 1: return Y;
					default: throw new IndexOutOfRangeException("The maximum index of a Int2 is 1.");
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

		public static Int2 operator +(Int2 a, Int2 b)
		{
			return new Int2()
			{
				X = a.X + b.X,
				Y = a.Y + b.Y,
			};
		}
		public static Int2 operator +(Int2 a, int b)
		{
			return new Int2()
			{
				X = (int)(a.X + b),
				Y = (int)(a.Y + b),
			};
		}

		public static Int2 operator +(int a, Int2 b)
		{
			return new Int2()
			{
				X = (a + b.X),
				Y = (a + b.Y),
			};
		}
		public static Int2 operator +(Int2 a, float b)
		{
			return new Int2()
			{
				X = (int)(a.X + b),
				Y = (int)(a.Y + b),
			};
		}

		public static Int2 operator +(float a, Int2 b)
		{
			return new Int2()
			{
				X = (int)(a + b.X),
				Y = (int)(a + b.Y),
			};
		}
		public static Int2 operator +(Int2 a, double b)
		{
			return new Int2()
			{
				X = (int)(a.X + b),
				Y = (int)(a.Y + b),
			};
		}

		public static Int2 operator +(double a, Int2 b)
		{
			return new Int2()
			{
				X = (int)(a + b.X),
				Y = (int)(a + b.Y),
			};
		}
		public static Int2 operator -(Int2 a, Int2 b)
		{
			return new Int2()
			{
				X = a.X - b.X,
				Y = a.Y - b.Y,
			};
		}
		public static Int2 operator -(Int2 a, int b)
		{
			return new Int2()
			{
				X = (int)(a.X - b),
				Y = (int)(a.Y - b),
			};
		}

		public static Int2 operator -(int a, Int2 b)
		{
			return new Int2()
			{
				X = (a - b.X),
				Y = (a - b.Y),
			};
		}
		public static Int2 operator -(Int2 a, float b)
		{
			return new Int2()
			{
				X = (int)(a.X - b),
				Y = (int)(a.Y - b),
			};
		}

		public static Int2 operator -(float a, Int2 b)
		{
			return new Int2()
			{
				X = (int)(a - b.X),
				Y = (int)(a - b.Y),
			};
		}
		public static Int2 operator -(Int2 a, double b)
		{
			return new Int2()
			{
				X = (int)(a.X - b),
				Y = (int)(a.Y - b),
			};
		}

		public static Int2 operator -(double a, Int2 b)
		{
			return new Int2()
			{
				X = (int)(a - b.X),
				Y = (int)(a - b.Y),
			};
		}
		public static Int2 operator *(Int2 a, Int2 b)
		{
			return new Int2()
			{
				X = a.X * b.X,
				Y = a.Y * b.Y,
			};
		}
		public static Int2 operator *(Int2 a, int b)
		{
			return new Int2()
			{
				X = (int)(a.X * b),
				Y = (int)(a.Y * b),
			};
		}

		public static Int2 operator *(int a, Int2 b)
		{
			return new Int2()
			{
				X = (a * b.X),
				Y = (a * b.Y),
			};
		}
		public static Int2 operator *(Int2 a, float b)
		{
			return new Int2()
			{
				X = (int)(a.X * b),
				Y = (int)(a.Y * b),
			};
		}

		public static Int2 operator *(float a, Int2 b)
		{
			return new Int2()
			{
				X = (int)(a * b.X),
				Y = (int)(a * b.Y),
			};
		}
		public static Int2 operator *(Int2 a, double b)
		{
			return new Int2()
			{
				X = (int)(a.X * b),
				Y = (int)(a.Y * b),
			};
		}

		public static Int2 operator *(double a, Int2 b)
		{
			return new Int2()
			{
				X = (int)(a * b.X),
				Y = (int)(a * b.Y),
			};
		}
		public static Int2 operator /(Int2 a, Int2 b)
		{
			return new Int2()
			{
				X = a.X / b.X,
				Y = a.Y / b.Y,
			};
		}
		public static Int2 operator /(Int2 a, int b)
		{
			return new Int2()
			{
				X = (int)(a.X / b),
				Y = (int)(a.Y / b),
			};
		}

		public static Int2 operator /(int a, Int2 b)
		{
			return new Int2()
			{
				X = (a / b.X),
				Y = (a / b.Y),
			};
		}
		public static Int2 operator /(Int2 a, float b)
		{
			return new Int2()
			{
				X = (int)(a.X / b),
				Y = (int)(a.Y / b),
			};
		}

		public static Int2 operator /(float a, Int2 b)
		{
			return new Int2()
			{
				X = (int)(a / b.X),
				Y = (int)(a / b.Y),
			};
		}
		public static Int2 operator /(Int2 a, double b)
		{
			return new Int2()
			{
				X = (int)(a.X / b),
				Y = (int)(a.Y / b),
			};
		}

		public static Int2 operator /(double a, Int2 b)
		{
			return new Int2()
			{
				X = (int)(a / b.X),
				Y = (int)(a / b.Y),
			};
		}
	}
}
