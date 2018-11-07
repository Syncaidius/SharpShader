using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// Contains important information for translating C# code to shader language.
    /// </summary>
    internal class CodeMap
    {
        internal List<EntryPoint> EntryPoints = new List<EntryPoint>();

        internal List<ShaderMethod> Methods = new List<ShaderMethod>();

        internal List<ShaderStructure> Structures = new List<ShaderStructure>();

        internal Dictionary<string, ConstantBufferStructure> ConstantBuffers = new Dictionary<string, ConstantBufferStructure>();

        internal void AddEntryPoint(EntryPoint ep)
        {
            EntryPoints.Add(ep);
        }

        internal void AddMethod(ShaderMethod method)
        {
            Methods.Add(method);
        }

        internal void AddStructure(ShaderStructure structure)
        {
            Structures.Add(structure);
        }

        internal void AddConstantBuffer(ConstantBufferStructure cb)
        {
            ConstantBuffers.Add(cb.Name, cb);
        }
    }
}
