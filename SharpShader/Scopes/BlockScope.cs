using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class BlockScope : ScopeInfo
    {
        internal override OpenCloseSyntax OpeningSyntax => new OpenCloseSyntax("{", NewLineLocation.Before);

        internal override OpenCloseSyntax ClosingSyntax => new OpenCloseSyntax("}", NewLineLocation.Before);
    }
}
