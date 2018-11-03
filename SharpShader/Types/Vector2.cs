

using System.Runtime.InteropServices;

namespace SharpShader
{
	public struct Vector2
	{
		public float X;

		public float Y;

		public Vector2(float x, float y)
		{
			X = x;
			Y = y;
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

	}
}
