using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
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

        //List<string> _lines = new List<string>();

        internal SyntaxNode Root { get; private set; }
        internal SyntaxTree Tree { get; private set; }

        internal readonly ShaderLexicon Lexicon;

        internal ConversionContext(ShaderLexicon lexicon)
        {
            Lexicon = lexicon;
        }

        internal void RegenerateTree(string source)
        {
            CSharpParseOptions parseOptions = new CSharpParseOptions(LanguageVersion.CSharp7_3, DocumentationMode.Parse, SourceCodeKind.Regular);
            Tree = CSharpSyntaxTree.ParseText(source, parseOptions);
            Root = Tree.GetRoot();
        }

        internal void ReplaceTree(SyntaxTree tree)
        {
            Tree = tree;
            Root = tree.GetRoot();
        }

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

        internal string GetResult()
        {
            return Tree.ToString();
        }

        //internal void Write(string text)
        //{
        //    if (_lines.Count == 0)
        //        _lines.Add(text);
        //    else
        //        _lines[_lines.Count - 1] += text;
        //}

        //internal void WriteLine(string text)
        //{
        //    if (_lines.Count == 0)
        //        _lines.Add(text);
        //    else
        //        _lines[_lines.Count - 1] += text;

        //    _lines.Add("");
        //}

        //internal void WriteLine()
        //{
        //    _lines.Add("");
        //}

        //internal void ReplaceInResult(Regex regex, string replacement)
        //{
        //    for (int i = 0; i < _lines.Count; i++)
        //        _lines[i] = regex.Replace(_lines[i], replacement);
        //}

        //internal void ReplaceInResult(string pattern, string replacement)
        //{
        //    for (int i = 0; i < _lines.Count; i++)
        //        _lines[i] = Regex.Replace(_lines[i], pattern, replacement);
        //}

        //internal string GetResult()
        //{
        //    return string.Join(Environment.NewLine, _lines);
        //}
    }
}
