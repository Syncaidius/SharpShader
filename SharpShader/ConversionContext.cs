using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class ConversionContext
    {
        internal List<EntryPoint> EntryPoints = new List<EntryPoint>();

        internal List<ShaderMethod> Methods = new List<ShaderMethod>();

        internal List<ShaderStructure> Structures = new List<ShaderStructure>();

        internal Dictionary<string, ConstantBufferStructure> ConstantBuffers = new Dictionary<string, ConstantBufferStructure>();

        List<string> _lines = new List<string>();

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

        internal void Write(string text)
        {
            _lines[_lines.Count - 1] += text;
        }

        internal void WriteLine(string text)
        {
            _lines[_lines.Count - 1] += text;
            _lines.Add("");
        }

        internal void WriteLine()
        {
            _lines.Add("");
        }

        internal void ReplaceInResult(Regex regex, string replacement)
        {
            for (int i = 0; i < _lines.Count; i++)
                _lines[i] = regex.Replace(_lines[i], replacement);
        }

        internal void ReplaceInResult(string pattern, string replacement)
        {
            for (int i = 0; i < _lines.Count; i++)
                _lines[i] = Regex.Replace(_lines[i], pattern, replacement);
        }

        internal string GetResult()
        {
            return string.Join(Environment.NewLine, _lines);
        }
    }
}
