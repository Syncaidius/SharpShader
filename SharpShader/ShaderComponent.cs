using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class ShaderComponent
    {
        public string Name;

        public SyntaxNode Node;

        public ShaderComponentType Type;

        public override string ToString()
        {
            return $"{Type} - {Node.GetType().Name} - {Name}";
        }
    }

    public enum ShaderComponentType
    {
        VertexEntryPoint = 0,

        FragmentEntryPoint = 1,

        GeometryEntryPoint = 2,

        HullEntryPoint = 3,

        DomainEntryPoint = 4,

        ComputeEntryPoint = 5,

        ConstantBuffer = 6,

        TextureSampler = 7,

        Buffer = 8,

        Struct = 9,

        CSharpField = 10,
    }
}
