using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class MethodNodeMapper : NodeMapper<MethodDeclarationSyntax>
    {
        internal override void Map(ConversionContext context, SyntaxNode node)
        {
            MethodDeclarationSyntax methodSyntax = node as MethodDeclarationSyntax;
            bool attributed = false;
            foreach (AttributeListSyntax list in methodSyntax.AttributeLists)
            {
                foreach (AttributeSyntax attSyntax in list.Attributes)
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
                        else if (attType == typeof(FragmentShaderAttribute))
                            ep = EntryPointType.FragmentShader;
                        else if (attType == typeof(GeometryShaderAttribute))
                            ep = EntryPointType.GeometryShader;
                        else if (attType == typeof(HullShaderAttribute))
                            ep = EntryPointType.HullShader;
                        else if (attType == typeof(DomainShaderAttribute))
                            ep = EntryPointType.DomainShader;
                        else if (attType == typeof(ComputeShaderAttribute))
                            ep = EntryPointType.ComputeShader;

                        if (ep != EntryPointType.Invalid)
                        {
                            context.Map.AddEntryPoint(new EntryPoint()
                            {
                                AttributeType = attType,
                                EntryType = ep,
                                MethodSyntax = methodSyntax,
                                AttributeSyntax = attSyntax,
                            });
                            attributed = true;
                        }
                    }
                }
            }

            if (!attributed)
            {
                context.Map.AddMethod(new ShaderMethod()
                {
                    MethodSyntax = methodSyntax,
                });
            }
        }
    }
}
