using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SharpShader
{
    internal delegate string TranslateCallbackDelegate(ref string source, ref string nodeSource);

    internal abstract class NodePreprocessor
    {
        internal abstract void Process(ConversionContext context, SyntaxNode node);

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

        protected void TranslateType(ConversionContext context, SyntaxNode node, TypeSyntax type)
        {
            Type t = Type.GetType($"SharpShader.{type}") ?? Type.GetType($"System.{type}");
            if (t != null)
            {
                Type[] iTypes = t.GetInterfaces();
                foreach (Type implemented in iTypes)
                {
                    ShaderLexicon.Word translation = context.Lexicon.GetWord(implemented);
                    if (translation != null)
                    {
                        string strRegex = null;
                        string toReplace = null;

                        // TODO These should be defined in a lexicon-esque XML file, 
                        //      along with information for automatically generating SharpShader types.
                        if (typeof(IVector).IsAssignableFrom(implemented))
                        {
                            strRegex = @"(;|\b|\w)Vector[0-9](\b|\w)";
                            toReplace = "Vector";
                        }
                        else if (typeof(IMatrix).IsAssignableFrom(implemented))
                        {
                            strRegex = @"(;|\b|\w)Matrix[0-9]x[0-9](\b|\w)";
                            toReplace = "Matrix";
                        }

                        if (strRegex == null)
                            continue;

                        Translate(context, node, (ref string source, ref string nodeSource) =>
                        {
                            Match m = Regex.Match(nodeSource, strRegex);
                            if (m.Success)
                            {
                                string replacement = m.Value.Replace(toReplace, translation.Text);

                                if (translation.UniformSizeIsSingular)
                                {
                                    if (typeof(UniformDimensions).IsAssignableFrom(t))
                                        replacement = replacement.Substring(0, replacement.Length - 2);
                                }

                                // Replace the type across the whole source. This saves regenerating the syntax tree for each individual field declaration.
                                return source.Replace(m.Value, replacement);
                            }
                            else
                            {
                                return source;
                            }
                        });

                        break;
                    }
                }
            }
        }

        internal abstract Type ParsedType { get; }
    }

    internal abstract class NodePreprocessor<T> : NodePreprocessor
        where T : SyntaxNode
    {
        internal override sealed Type ParsedType => typeof(T);
    }
}
