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
    /// <summary>
    /// Converts C# source code into shader language code.
    /// </summary>
    public class Converter
    {
        static int test = 0;
        public string Convert(string input, ShaderOutput output)
        {
            ConversionContext context = new ConversionContext();
            CSharpParseOptions parseOptions = new CSharpParseOptions(LanguageVersion.CSharp7_3, DocumentationMode.Parse, SourceCodeKind.Regular);

            SyntaxTree tree = CSharpSyntaxTree.ParseText(input, parseOptions);
            SyntaxNode node = tree.GetRoot();
            //CompilationUnitSyntax comUnit = node as CompilationUnitSyntax;
            GatherEntryPoints(context, node, 0);
            return "";
        }

        private void GatherEntryPoints(ConversionContext context, SyntaxNode node, int depth)
        {
            IEnumerable<SyntaxNode> stuff = node.ChildNodes();
            foreach (SyntaxNode child in stuff)
            {
                Type t = child.GetType();

                switch (child)
                {
                    case MethodDeclarationSyntax methodSyntax:
                        foreach(AttributeListSyntax list in methodSyntax.AttributeLists)
                        {
                            foreach(AttributeSyntax attSyntax in list.Attributes)
                            {
                                string name = attSyntax.Name.ToString();
                                if (!name.EndsWith("Attribute"))
                                    name += "Attribute";

                                Type attType = Type.GetType($"SharpShader.{name}");
                                if (attType != null)
                                {
                                    EntryPointType ep = EntryPointType.Invalid;

                                    if (attType == typeof(VertexShaderAttribute))
                                        ep = EntryPointType.VertexShader;
                                    if (attType == typeof(FragmentShaderAttribute))
                                        ep = EntryPointType.FragmentShader;
                                    if (attType == typeof(GeometryShaderAttribute))
                                        ep = EntryPointType.GeometryShader;
                                    if (attType == typeof(HullShaderAttribute))
                                        ep = EntryPointType.HullShader;
                                    if (attType == typeof(DomainShaderAttribute))
                                        ep = EntryPointType.DomainShader;
                                    if (attType == typeof(ComputeShaderAttribute))
                                        ep = EntryPointType.ComputeShader;

                                    context.EntryPoints.Add(new EntryPointSyntax()
                                    {
                                        AttributeType = attType,
                                        EntryType = ep,
                                        MethodSyntax = methodSyntax,
                                        AttributeSyntax = attSyntax,
                                    });
                                }
                            }
                        }
                        break;

                    default:
                        //Console.WriteLine($"{new string(' ', depth)}Unhandled syntax node type: " + t.Name);
                        GatherEntryPoints(context, child, depth + 1);
                        break;
                }
            }
        }
    }
}
