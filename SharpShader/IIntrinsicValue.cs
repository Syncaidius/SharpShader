using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// Represents a value which is accepted into an intrinsic shader function.
    /// </summary>
    public interface IIntrinsicValue { }

    /// <summary>
    /// Represents a value which is accepted into an intrinsic shader function.
    /// </summary>
    public interface IIntrinsicValue<T> : IIntrinsicValue where T : struct { }
}
