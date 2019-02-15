using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>A base class for SharpShader's texture types.</summary>
    [RegisteredType]
    public abstract class TextureBase : ShaderResource
    {
        internal TextureBase() { }
    }
}
