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
        EntryPoint = 0,

        ConstantBuffer = 1,

        TextureSampler = 2,

        Buffer = 3,

        Struct = 4,

        CSharpField = 5,

        MemberAccess = 6,
    }
}
