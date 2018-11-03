using System.Runtime.InteropServices;

namespace SharpShader
{
	public struct Int4
	{
		public int X;
		public int Y;
		public int Z;
		public int W;

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

		public int A
		{
			get => W;
			set => W = value;
		}

	}
}
