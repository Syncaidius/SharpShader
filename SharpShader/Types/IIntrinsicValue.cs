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

    public interface IVector<T> : IIntrinsicValue 
        where T : struct { }

    public interface IMatrix<T> : IIntrinsicValue
        where T : struct { }
}
