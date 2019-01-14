using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class ArrayBlockScope : BlockScope
    {
        internal override OpenCloseSyntax ClosingSyntax => new OpenCloseSyntax("}", NewLineLocation.Before);
    }
}
