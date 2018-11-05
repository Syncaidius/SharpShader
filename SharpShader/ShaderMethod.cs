using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class ShaderMethod
    {
        public MethodDeclarationSyntax MethodSyntax;

        public override string ToString()
        {
            return MethodSyntax.Identifier.ToString();
        }
    }
}
