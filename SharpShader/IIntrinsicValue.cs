using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    public interface IIntrinsicValue { }

    public interface IIntrinsicValue<T> : IIntrinsicValue 
        where T : struct { }

    public interface UniformDimensions { }

    public interface IVector : IIntrinsicValue { }

    public interface IVector<T> : IVector
        where T : struct { }

    public interface IMatrix : IIntrinsicValue { }

    public interface IMatrix<T> : IMatrix
        where T : struct { }
}
