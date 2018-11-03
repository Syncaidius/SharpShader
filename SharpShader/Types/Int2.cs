using System.Runtime.InteropServices;

namespace SharpShader
{
	public struct Int2
	{
		public int X;

		public int Y;

		public Int2(int x, int y)
		{
			X = x;
			Y = y;
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

	}
}
