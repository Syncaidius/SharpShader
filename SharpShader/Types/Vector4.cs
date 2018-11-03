using System.Runtime.InteropServices;

namespace SharpShader
{
	public struct Vector4
	{
		public float X;
		public float Y;
		public float Z;
		public float W;

		public float R
		{
			get => X;
			set => X = value;
		}

		public float G
		{
			get => Y;
			set => Y = value;
		}

		public float B
		{
			get => Z;
			set => Z = value;
		}

		public float A
		{
			get => W;
			set => W = value;
		}

	}
}
