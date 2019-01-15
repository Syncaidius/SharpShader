using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class InitializerScope : BlockScope
    {
        internal override OpenCloseSyntax ClosingSyntax => new OpenCloseSyntax("}", NewLineLocation.Before);

        internal SeparatedSyntaxList<ExpressionSyntax> Items;
    }
}
