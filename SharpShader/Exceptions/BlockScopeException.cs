using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader.Exceptions
{
    public class BlockScopeException : Exception
    {
        internal BlockScopeException(string msg) : base(msg) { }
    }
}
