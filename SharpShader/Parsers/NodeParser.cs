using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal abstract class NodeParser
    {
        internal abstract void Parse(ConversionContext context, SyntaxNode node);

        internal abstract Type ParsedType { get; }
    }

    internal abstract class NodeParser<T> : NodeParser 
        where T : SyntaxNode
    {
        internal override sealed Type ParsedType => typeof(T);
    }
}
