using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    public abstract class CSharpShader
    {
        [ShaderIntrinsic]
        public T Mul<T>(IIntrinsicValue a, IIntrinsicValue b) where T : struct, IIntrinsicValue => new T();

        [ShaderIntrinsic]
        public T Mul<T>(float a, T b) where T : struct, IIntrinsicValue<float> => new T();

        [ShaderIntrinsic]
        public T Mul<T>(int a, T b) where T : struct, IIntrinsicValue<int> => new T();
    }
}
