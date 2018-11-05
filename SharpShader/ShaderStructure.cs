using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class ShaderStructure
    {
        public StructDeclarationSyntax Syntax;

        public override string ToString()
        {
            return Syntax.Identifier.ToString();
        }
    }
}
