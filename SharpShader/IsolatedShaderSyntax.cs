using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class IsolatedShaderSyntax
    {
        internal ClassDeclarationSyntax Syntax;

        internal string Namespace;

        internal Type ShaderType;
    }
}
