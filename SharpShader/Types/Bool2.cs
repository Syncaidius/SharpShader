using System.Runtime.InteropServices;

namespace SharpShader
{
	public struct Bool2
	{
		public bool X;

		public bool Y;

		public Bool2(bool x, bool y)
		{
			X = x;
			Y = y;
		}

		public bool R
		{
			get => X;
			set => X = value;
		}

		public bool G
		{
			get => Y;
			set => Y = value;
		}

	}
}
