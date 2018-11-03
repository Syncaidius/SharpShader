using System.Runtime.InteropServices;

namespace SharpShader
{
	public struct Double3
	{
		public double X;

		public double Y;

		public double Z;

		public Double3(double x, double y, double z)
		{
			X = x;
			Y = y;
			Z = z;
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

		public double B
		{
			get => Z;
			set => Z = value;
		}

	}
}
