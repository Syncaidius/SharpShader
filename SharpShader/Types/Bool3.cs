using System.Runtime.InteropServices;

namespace SharpShader
{
	public struct Bool3
	{
		public bool X;

		public bool Y;

		public bool Z;

		public Bool3(bool x, bool y, bool z)
		{
			X = x;
			Y = y;
			Z = z;
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

		public bool B
		{
			get => Z;
			set => Z = value;
		}

	}
}
