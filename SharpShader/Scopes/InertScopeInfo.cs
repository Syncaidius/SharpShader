﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// A <see cref="ScopeInfo"/> which does nothing but contain child syntax.
    /// </summary>
    internal class InertScopeInfo : ScopeInfo
    {
        internal override OpenCloseSyntax OpeningSyntax => new OpenCloseSyntax(NewLineLocation.None);

        internal override OpenCloseSyntax ClosingSyntax => new OpenCloseSyntax(NewLineLocation.None);
    }
}
