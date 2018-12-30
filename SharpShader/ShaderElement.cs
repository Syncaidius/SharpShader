using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class ShaderElement
    {
        public SyntaxNode Node;

        public ShaderComponentType Type;

        internal ShaderElement(SyntaxNode node, ShaderComponentType type)
        {
            Node = node;
            Type = type;
        }

        public override string ToString()
        {
            return $"{Type} - {Node.GetType().Name} - {Node}";
        }
    }

    public enum ShaderComponentType
    {
        EntryPoint = 0,

        ConstantBuffer = 1,

        Sampler = 2,

        Texture = 3,

        Buffer = 4,

        Struct = 5,

        Method = 6,

        Variable = 7,

        MemberAccess = 8,
    }
}
