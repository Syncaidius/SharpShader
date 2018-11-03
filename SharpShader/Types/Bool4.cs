using System.Runtime.InteropServices;

namespace SharpShader
{
	public struct Bool4
	{
		public bool X;
		public bool Y;
		public bool Z;
		public bool W;

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

		public bool B
		{
			get => Z;
			set => Z = value;
		}

		public bool A
		{
			get => W;
			set => W = value;
		}

	}
}
