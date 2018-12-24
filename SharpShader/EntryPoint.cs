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
        internal Type EntryPointAttributeType { get; }
        internal AttributeSyntax AttributeSyntax { get; }
        internal MethodDeclarationSyntax MethodSyntax;
        internal EntryPointType EntryType;

        internal EntryPoint(Type epAttributeType, AttributeSyntax epAttributeSyntax, MethodDeclarationSyntax syntax, EntryPointType type)
        {
            MethodSyntax = syntax;
            EntryPointAttributeType = epAttributeType;
            AttributeSyntax = epAttributeSyntax;
            EntryType = type;
        }

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
