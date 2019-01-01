using SharpShader;
using System;

namespace SharpShaderSample
{
    /// <summary>
    /// A nonsensical shader for testing various translation capabilities during development. A playground. A sandbox. A scratchpad. Call it what you want!
    /// </summary>
    public class FunctionalityTestShader : CSharpShader
    {
        #region Constants
        public const int LAPS = 5;
        public const float RADIUS = 0.5f;
        public const double PI = Math.PI;
        #endregion

        #region Variables
        static Vector3 CameraPos;

        readonly static Vector4 Color = new Vector4(0.5f, 0.2f, 0.1f, 1.0f);

        readonly static Vector2[] testArray = {
            new Vector2(0,-1),
            new Vector2(0, 0),
            new Vector2(1,-1),
            new Vector2(1,0),
        }, testArray2 =
{
            new Vector2(5,0),
            new Vector2(0, 4),
            new Vector2(2,3),
        };
        #endregion

        #region Methods
        int IAmALambdaMethod() => 9;

        int AnotherLamdaMethod(int increment) => 9 + increment;

        T GenericLamdaMethod<T>(int increment) where T : struct => default(T);

        public void AnonymousAnons(Action<int, float> test)
        {
            test(LAPS, RADIUS);
        }

        private float TotalLappedDistance(int laps, float trackRadius)
        {
            double circumference = 2 * PI * trackRadius;
            return (float)(circumference * laps);
        }
        #endregion

        #region Properties
        // Lamda property
        public bool AmIAShader => true;

        // Property with lambda getter
        public bool AreBananasAVegetable
        {
            get => false;
        }

        // Another property with a lambda getter.
        public static float FortyTwo
        {
            get => 42.0f;
        }

        // Property with two lambda accessors
        public static Vector2 WaveOffset
        {
            get => new Vector2(8 * 4.2f, 8 * 4.0f);
            set => new Vector2(value.X, value.Y);
        }

        // Fully-defined property
        public static Vector2 WaveOffsetNumberTwo
        {
            get
            {
                return new Vector2(8 * 2.2f, 8 * 2.0f);
            }
            set
            {
                Vector2 test = new Vector2()
                {
                    X = value.X,
                    Y = value.Y
                };
            }
        }

        // Plain ol' property
        public float NumberOfWaves { get; set; }

        // Read-only property
        public float WaveHeight { get; } = 2.9f;

        #endregion

        #region Indexers
        public float this[int index]
        {
            get => 0;
            set { }
        }

        public float this[int x, int y, int z]
        {
            get => 0;
            set { }
        }
        #endregion
    }
}
