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
        public bool AmIAShader => true;

        public bool AreBananasAVegetable
        {
            get => false;
        }

        public static float FortyTwo
        {
            get => 42;
        }
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
