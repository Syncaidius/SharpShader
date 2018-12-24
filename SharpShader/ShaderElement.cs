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

        MainField = 5,

        ChildField = 6,

        MemberAccess = 7,

        Method = 8,
    }
}
