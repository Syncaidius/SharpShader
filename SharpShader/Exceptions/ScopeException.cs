using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader.Exceptions
{
    public class ScopeException : Exception
    {
        internal ScopeException(string msg) : base(msg) { }
    }
}
