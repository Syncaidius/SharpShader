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
    internal delegate string TranslateCallbackDelegate(ref string source, ref string nodeSource);

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="node"></param>
        /// <param name="callback">A callback which takes the the main source and node source as input and returns the translated shader source result as output.</param>
        protected void Translate(ConversionContext context, SyntaxNode node, TranslateCallbackDelegate callback)
        {
            string source = context.Tree.ToString();
            string nodeSource = node.ToString();
            int start = source.IndexOf(node.ToString());

            if (start > -1)
            {
                source = callback(ref source, ref nodeSource);
                context.RegenerateTree(source);
            }
        }

        /// <summary>
        /// Returns the source code of a node's child nodes, while leaving out the excluded ones.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="exludedChildren"></param>
        /// <returns></returns>
        protected static string GetChildNodeSource(SyntaxNode node, params SyntaxNode[] exludedChildren)
        {
            IEnumerable<SyntaxNode> children = node.ChildNodes();
            string childSource = "";
            foreach (SyntaxNode child in children)
            {
                if (exludedChildren.Contains(child))
                    continue;

                childSource += child.ToString();
            }

            return childSource;
        }

        internal abstract Type ParsedType { get; }
    }

    internal abstract class NodeParser<T> : NodeParser 
        where T : SyntaxNode
    {
        internal override sealed Type ParsedType => typeof(T);
    }
}
