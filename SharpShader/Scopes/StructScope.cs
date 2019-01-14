using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class StructScope : BlockScope
    {
        internal override OpenCloseSyntax ClosingSyntax => new OpenCloseSyntax("};", NewLineLocation.Before | NewLineLocation.After);

        internal StructScopeType StructType;
    }

    internal enum StructScopeType
    {
        Struct = 0,

        ConstantBuffer = 1,
    }
}
