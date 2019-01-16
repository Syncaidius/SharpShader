﻿using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class ParenthesesScope : ScopeInfo
    {
        internal override OpenCloseSyntax OpeningSyntax => new OpenCloseSyntax("(", NewLineLocation.None);

        internal override OpenCloseSyntax ClosingSyntax => new OpenCloseSyntax(")", NewLineLocation.None);
    }

    internal class ParenthesesScope<T> : ParenthesesScope where T: SyntaxNode
    {
        internal SeparatedSyntaxList<T> Items;
    }
}
