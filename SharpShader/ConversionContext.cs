using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class ConversionContext
    {
        public List<EntryPointSyntax> EntryPoints = new List<EntryPointSyntax>();
    }
}
