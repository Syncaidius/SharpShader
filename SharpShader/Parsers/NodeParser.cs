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
    internal abstract class NodeParser
    {
        internal abstract void Parse(ConversionContext context, SyntaxNode node);

        /// <summary>
        /// Removes a node from the syntax tree.
        /// </summary>
        /// <param name="context">The conversion context.</param>
        /// <param name="node">The node to be removed.</param>
        /// <param name="migrateChildren">If true, the node's children are transferred to the node's parent.</param>
        protected void RemoveNode(ConversionContext context, SyntaxNode node)
        {
            SyntaxNode newParent = node.Parent.RemoveNode(node, SyntaxRemoveOptions.KeepNoTrivia);
            context.ReplaceTree(newParent.SyntaxTree);
        }

        protected void ReplaceWithChildren(ConversionContext context, SyntaxNode node, NameSyntax name = null)
        {
            IEnumerable<SyntaxNode> children = node.ChildNodes();

            string source = context.Tree.ToString();
            string nodeSource = node.ToString();

            int start = source.IndexOf(node.ToString());

            if (start > -1)
            {
                string childSource = "";
                foreach (SyntaxNode child in children)
                {
                    if (child == name)
                        continue;
                    childSource += child.ToString();
                }

                source = source.Replace(nodeSource, childSource);
                context.RegenerateTree(source);
            }
        }

        internal abstract Type ParsedType { get; }
    }

    internal abstract class NodeParser<T> : NodeParser 
        where T : SyntaxNode
    {
        internal override sealed Type ParsedType => typeof(T);
    }
}
