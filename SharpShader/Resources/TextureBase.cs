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

    public class MipMapReadOnlyAccessor<T, LOC> where T : struct
        where LOC : struct
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pos">The index position. The first component contains the x-coordinate. The second component indicates the desired array slice.</param>
        /// <returns></returns>
        public T this[LOC pos] => default;
    }

    public class MipMapAccessor<T, LOC> 
        where T : struct
        where LOC : struct
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pos">The index position. The first component contains the x-coordinate. The second component indicates the desired array slice.</param>
        /// <returns></returns>
        public T this[LOC pos]
        {
            get => default;
            set { }
        }
    }
}
