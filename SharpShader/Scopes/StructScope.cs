using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class StructScope : BlockScope
    {
        internal override OpenCloseSyntax ClosingSyntax => new OpenCloseSyntax("};", NewLineLocation.After);

        internal StructScopeType StructType;

        internal Type TypeInfo;
    }

    internal enum StructScopeType
    {
        None = 0,

        ConstantBuffer = 1,

        Struct = 2,
    }
}
