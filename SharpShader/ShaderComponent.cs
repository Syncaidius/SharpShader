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
        public SyntaxNode Node;

        public ShaderComponentType Type;

        internal ShaderComponent(SyntaxNode node, ShaderComponentType type)
        {
            Node = node;
            Type = type;
        }

        public override string ToString()
        {
            return $"{Type} - {Node.GetType().Name}";
        }
    }

    public enum ShaderComponentType
    {
        EntryPoint = 0,

        ConstantBuffer = 1,

        Sampler = 2,

        Texture = 2,

        Buffer = 3,

        Struct = 4,

        CSharpField = 5,

        MemberAccess = 6,
    }
}
