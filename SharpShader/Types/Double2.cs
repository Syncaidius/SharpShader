using System.Runtime.InteropServices;

namespace SharpShader
{
	public struct Double2
	{
		public double X;
		public double Y;
		public double Z;
		public double W;

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

	}
}
