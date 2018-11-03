using System.Runtime.InteropServices;

namespace SharpShader
{
	public struct Vector3
	{
		public float X;

		public float Y;

		public float Z;

		public Vector3(float x, float y, float z)
		{
			X = x;
			Y = y;
			Z = z;
		}

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

	}
}
