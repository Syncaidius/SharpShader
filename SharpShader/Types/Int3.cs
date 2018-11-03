using System.Runtime.InteropServices;

namespace SharpShader
{
	public struct Int3
	{
		public int X;

		public int Y;

		public int Z;

		public Int3(int x, int y, int z)
		{
			X = x;
			Y = y;
			Z = z;
		}

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

	}
}
