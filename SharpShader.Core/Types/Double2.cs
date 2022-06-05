using System;
using System.Runtime.InteropServices;

namespace SharpShader
{
	[StructLayout(LayoutKind.Sequential)]
	[Serializable]
	public struct Double2 : IVector<double>
	{
		/// <summary>
		///	The number of elements (components) in a <see cref="Double2"/>.
		/// </summary>
		public const int ELEMENT_COUNT = 2;
		
		/// <summary>
		///	The size of a <see cref="Double2"/>, in bytes.
		/// </summary>
		public const int ELEMENT_SIZE = sizeof(double);

		/// <summary>
		///	The size of a single element (component) within a <see cref="Double2"/>, in bytes.
		/// </summary>
		public const int SIZE_OF = ELEMENT_COUNT * ELEMENT_SIZE;

		/// <summary>
		///	Gets the <see cref="Type"/> of each element in a <see cref="Double2"/>.
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
        /// Creates a new instance of <see cref="Double2"/>.
        /// </summary>
		public Double2(double x, double y)
		{
			X = x;
			Y = y;
		}

		/// <summary>
		/// Gets or sets a component at the specified index for the current <see cref="Double2"/> .
		/// </summary>
		public double this[int index]
		{
			get
			{
				switch(index)
				{
					case 0: return X;
					case 1: return Y;
					default: throw new IndexOutOfRangeException("The maximum index of a Double2 is 1.");
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

		public static Double2 operator +(Double2 a, Double2 b)
		{
			return new Double2()
			{
				X = a.X + b.X,
				Y = a.Y + b.Y,
			};
		}
		public static Double2 operator +(Double2 a, int b)
		{
			return new Double2()
			{
				X = (double)(a.X + b),
				Y = (double)(a.Y + b),
			};
		}

		public static Double2 operator +(int a, Double2 b)
		{
			return new Double2()
			{
				X = (double)(a + b.X),
				Y = (double)(a + b.Y),
			};
		}
		public static Double2 operator +(Double2 a, float b)
		{
			return new Double2()
			{
				X = (double)(a.X + b),
				Y = (double)(a.Y + b),
			};
		}

		public static Double2 operator +(float a, Double2 b)
		{
			return new Double2()
			{
				X = (double)(a + b.X),
				Y = (double)(a + b.Y),
			};
		}
		public static Double2 operator +(Double2 a, double b)
		{
			return new Double2()
			{
				X = (double)(a.X + b),
				Y = (double)(a.Y + b),
			};
		}

		public static Double2 operator +(double a, Double2 b)
		{
			return new Double2()
			{
				X = (a + b.X),
				Y = (a + b.Y),
			};
		}
		public static Double2 operator -(Double2 a, Double2 b)
		{
			return new Double2()
			{
				X = a.X - b.X,
				Y = a.Y - b.Y,
			};
		}
		public static Double2 operator -(Double2 a, int b)
		{
			return new Double2()
			{
				X = (double)(a.X - b),
				Y = (double)(a.Y - b),
			};
		}

		public static Double2 operator -(int a, Double2 b)
		{
			return new Double2()
			{
				X = (double)(a - b.X),
				Y = (double)(a - b.Y),
			};
		}
		public static Double2 operator -(Double2 a, float b)
		{
			return new Double2()
			{
				X = (double)(a.X - b),
				Y = (double)(a.Y - b),
			};
		}

		public static Double2 operator -(float a, Double2 b)
		{
			return new Double2()
			{
				X = (double)(a - b.X),
				Y = (double)(a - b.Y),
			};
		}
		public static Double2 operator -(Double2 a, double b)
		{
			return new Double2()
			{
				X = (double)(a.X - b),
				Y = (double)(a.Y - b),
			};
		}

		public static Double2 operator -(double a, Double2 b)
		{
			return new Double2()
			{
				X = (a - b.X),
				Y = (a - b.Y),
			};
		}
		public static Double2 operator *(Double2 a, Double2 b)
		{
			return new Double2()
			{
				X = a.X * b.X,
				Y = a.Y * b.Y,
			};
		}
		public static Double2 operator *(Double2 a, int b)
		{
			return new Double2()
			{
				X = (double)(a.X * b),
				Y = (double)(a.Y * b),
			};
		}

		public static Double2 operator *(int a, Double2 b)
		{
			return new Double2()
			{
				X = (double)(a * b.X),
				Y = (double)(a * b.Y),
			};
		}
		public static Double2 operator *(Double2 a, float b)
		{
			return new Double2()
			{
				X = (double)(a.X * b),
				Y = (double)(a.Y * b),
			};
		}

		public static Double2 operator *(float a, Double2 b)
		{
			return new Double2()
			{
				X = (double)(a * b.X),
				Y = (double)(a * b.Y),
			};
		}
		public static Double2 operator *(Double2 a, double b)
		{
			return new Double2()
			{
				X = (double)(a.X * b),
				Y = (double)(a.Y * b),
			};
		}

		public static Double2 operator *(double a, Double2 b)
		{
			return new Double2()
			{
				X = (a * b.X),
				Y = (a * b.Y),
			};
		}
		public static Double2 operator /(Double2 a, Double2 b)
		{
			return new Double2()
			{
				X = a.X / b.X,
				Y = a.Y / b.Y,
			};
		}
		public static Double2 operator /(Double2 a, int b)
		{
			return new Double2()
			{
				X = (double)(a.X / b),
				Y = (double)(a.Y / b),
			};
		}

		public static Double2 operator /(int a, Double2 b)
		{
			return new Double2()
			{
				X = (double)(a / b.X),
				Y = (double)(a / b.Y),
			};
		}
		public static Double2 operator /(Double2 a, float b)
		{
			return new Double2()
			{
				X = (double)(a.X / b),
				Y = (double)(a.Y / b),
			};
		}

		public static Double2 operator /(float a, Double2 b)
		{
			return new Double2()
			{
				X = (double)(a / b.X),
				Y = (double)(a / b.Y),
			};
		}
		public static Double2 operator /(Double2 a, double b)
		{
			return new Double2()
			{
				X = (double)(a.X / b),
				Y = (double)(a.Y / b),
			};
		}

		public static Double2 operator /(double a, Double2 b)
		{
			return new Double2()
			{
				X = (a / b.X),
				Y = (a / b.Y),
			};
		}
		public static explicit operator Vector2(Double2 val)
		{
			return new Vector2()
			{
				X = (float)val.X,
				Y = (float)val.Y,
			};
		}

		public static explicit operator UInt2(Double2 val)
		{
			return new UInt2()
			{
				X = (uint)val.X,
				Y = (uint)val.Y,
			};
		}

		public static explicit operator Int2(Double2 val)
		{
			return new Int2()
			{
				X = (int)val.X,
				Y = (int)val.Y,
			};
		}

	}
}
