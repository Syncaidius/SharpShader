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
        internal SyntaxNode Root { get; private set; }
        internal SyntaxTree Tree { get; private set; }
        internal CodeMap Map { get; private set; }
        internal LanguageFoundation Foundation { get; }
        internal ConversionResult Result { get; }
        internal ConversionResult.Shader CurrentShader { get; private set; }

        int _nextVariable = 0;

        internal ConversionContext(LanguageFoundation foundatation)
        {
            Foundation = foundatation;
            Map = new CodeMap();
            Result = new ConversionResult();
        }

        internal void StartNewShader(string name)
        {
            CurrentShader = new ConversionResult.Shader();
            Result.Translated.Add(name, CurrentShader);
        }

        internal void Clear()
        {
            Tree = null;
            Root = null;
            Map.Clear();
        }

        internal void RegenerateTree(string source)
        {
            CSharpParseOptions parseOptions = new CSharpParseOptions(LanguageVersion.CSharp7_3, DocumentationMode.Parse, SourceCodeKind.Regular);
            Tree = CSharpSyntaxTree.ParseText(source, parseOptions);
            Root = Tree.GetRoot();
        }

        internal string GetNewVariableName(string prefix = null)
        {
            return $"ss_{($"{prefix}_" ?? "val_")}{_nextVariable++}";
        }

        internal string GetResult()
        {
            return Tree.ToString();
        }
    }
}
