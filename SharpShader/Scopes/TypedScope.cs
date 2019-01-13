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
    internal class TypedScope : ScopeInfo
    {
        internal override OpenCloseSyntax OpeningSyntax => new OpenCloseSyntax(NewLineLocation.None);

        internal override OpenCloseSyntax ClosingSyntax => new OpenCloseSyntax(NewLineLocation.None);

        /// <summary>
        /// The translated version of the original type.
        /// </summary>
        internal string TranslatedTypeName;

        /// <summary>
        /// The original type.
        /// </summary>
        internal Type OriginalType;
    }
}
