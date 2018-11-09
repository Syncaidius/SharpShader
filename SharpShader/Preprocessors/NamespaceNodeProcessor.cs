//using Microsoft.CodeAnalysis;
//using Microsoft.CodeAnalysis.CSharp;
//using Microsoft.CodeAnalysis.CSharp.Syntax;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SharpShader
//{
//    internal class NamespaceNodeParser : NodePreprocessor<NamespaceDeclarationSyntax>
//    {
//        internal override void Process(ConversionContext context, SyntaxNode node)
//        {
//            NamespaceDeclarationSyntax namespaceSyntax = node as NamespaceDeclarationSyntax;

//            Translate(context, node, (ref string source, ref string nodeSource) =>
//            {
//                string srcChildren = GetChildNodeSource(node, namespaceSyntax.Name);
//                return source.Replace(nodeSource, srcChildren);
//            });
//        }
//    }
//}
