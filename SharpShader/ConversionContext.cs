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
        public List<EntryPoint> EntryPoints = new List<EntryPoint>();

        public List<ShaderMethod> Methods = new List<ShaderMethod>();

        public List<ShaderStructure> Structures = new List<ShaderStructure>();

        public Dictionary<string, ConstantBufferStructure> ConstantBuffers = new Dictionary<string, ConstantBufferStructure>();
    }
}
