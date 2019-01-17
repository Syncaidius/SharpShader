using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class LocalVariableScope : VariableScope
    {
        internal override OpenCloseSyntax ClosingSyntax => new OpenCloseSyntax(";", NewLineLocation.None);
    }
}
