using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// A <see cref="ScopeInfo"/> which does nothing but contain child syntax.
    /// </summary>
    internal class InitializerScope : ScopeInfo
    {
        internal override OpenCloseSyntax OpeningSyntax => new OpenCloseSyntax(NewLineLocation.None);

        internal override OpenCloseSyntax ClosingSyntax => new OpenCloseSyntax(NewLineLocation.None);

        /// <summary>
        /// The name of the variable that initialized member belongs to.
        /// </summary>
        internal string VariableName;
    }
}
