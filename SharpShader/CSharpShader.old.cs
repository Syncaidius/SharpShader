//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SharpShader
//{
//    public abstract class CSharpShader
//    {
//        #region Intrinsic - mul()
//        [ShaderIntrinsic] // Version 1 - Scalar, scalar
//        public float Mul(float a, float b) => a * b;

//        [ShaderIntrinsic] // Version 1 - [Scalar, scalar]
//        public int Mul(int a, int b) => a * b;

//        [ShaderIntrinsic] // Version 2 + 3 - [Scalar, vector] or  [scalar, matrix]
//        public V Mul<V>(float a, V b) where V : struct, IIntrinsicValue => new V();

//        [ShaderIntrinsic] // Version 2 + 3 - [Scalar, vector] or [scalar, matrix]
//        public V Mul<V>(int a, V b) where V : struct, IIntrinsicValue => new V();

//        [ShaderIntrinsic] // Version 4 - [Vector, scalar]
//        public V Mul<V>(V a, float b) where V : struct, IIntrinsicValue => new V();

//        [ShaderIntrinsic] // Version 4 - [Vector, scalar]
//        public V Mul<V>(V a, int b) where V : struct, IIntrinsicValue => new V();

//        [ShaderIntrinsic] // Version 5 + 9 - [vector, vector] or [matrix, matrix] or [Vector, Matrix] or [Matrix, Vector]
//        public V1 Mul<V1, V2>(V1 a, V2 b)
//            where V1 : struct, IIntrinsicValue
//            where V2 : struct, IIntrinsicValue
//            => new V1();
//        #endregion
//    }
//}
