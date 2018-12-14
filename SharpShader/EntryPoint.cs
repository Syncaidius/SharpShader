using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class EntryPoint
    {
        public Type AttributeType;
        public AttributeSyntax AttributeSyntax;
        public MethodDeclarationSyntax MethodSyntax;
        public EntryPointType EntryType;

        public override string ToString()
        {
            return $"{AttributeSyntax.Name} - {EntryType}";
        }
    }

    public enum EntryPointType
    {
        Invalid = 0,

        VertexShader = 1,

        FragmentShader = 2,

        GeometryShader = 3,

        HullShader = 4,

        DomainShader = 5,

        ComputeShader = 6,
    }
}
