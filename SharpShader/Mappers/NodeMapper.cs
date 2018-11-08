using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal abstract class NodeMapper
    {
        internal abstract void Map(ConversionContext context, SyntaxNode node);

        internal abstract Type ParsedType { get; }
    }

    internal abstract class NodeMapper<T> : NodeMapper 
        where T : SyntaxNode
    {
        internal override sealed Type ParsedType => typeof(T);
    }
}
