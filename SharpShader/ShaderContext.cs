using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class ShaderContext
    {
        internal SyntaxNode Root { get; private set; }
        internal SyntaxTree Tree { get; private set; }
        internal CodeMap Map { get; private set; }

        internal ConversionContext Parent { get; }

        internal string Source { get; set; }
        internal string Name { get; }
        internal string SanitizedName { get; }

        internal ShaderContext(ConversionContext parent, string name)
        {
            Parent = parent;
            Map = new CodeMap();
            Name = name;
            SanitizedName = TranslationHelper.SanitizeString(name);
        }

        internal void AddMessage(string text, int lineNumber, int linePos, ConversionMessageType type = ConversionMessageType.Error)
        {
            Parent.AddMessage($"{Name}: {text}", lineNumber, linePos, type);
        }

        internal void RegenerateTree(string source)
        {
            Tree = CSharpSyntaxTree.ParseText(source, Parent.ParseOptions);
            Root = Tree.GetRoot();
        }

        internal string GetResult()
        {
            return Tree.ToString();
        }
    }
}
