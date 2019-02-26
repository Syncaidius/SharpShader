using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    [Serializable]
    public class ScopeException : Exception
    {
        internal ScopeException(string msg) : base(msg) { }

        protected ScopeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            
        }
    }
}
