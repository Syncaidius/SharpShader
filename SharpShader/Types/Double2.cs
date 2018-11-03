using System.Runtime.InteropServices;

namespace SharpShader
{
	public struct Double2
	{
		public double X;

		public double Y;

		public Double2(double x, double y)
		{
			X = x;
			Y = y;
		}

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

	}
}
