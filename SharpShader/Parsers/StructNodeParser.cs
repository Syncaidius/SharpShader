using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class StructNodeParser : NodeParser<StructDeclarationSyntax>
    {
        internal override void Parse(ConversionContext context, SyntaxNode node)
        {
            StructDeclarationSyntax structSyntax = node as StructDeclarationSyntax;
            bool attributed = false;

            foreach (AttributeListSyntax list in structSyntax.AttributeLists)
            {
                foreach (AttributeSyntax attSyntax in list.Attributes)
                {
                    string name = attSyntax.Name.ToString();
                    if (!name.EndsWith("Attribute"))
                        name += "Attribute";

                    Type attType = Type.GetType($"SharpShader.{name}");
                    if (attType != null)
                    {
                        if (attType == typeof(ConstantBufferAttribute))
                        {
                            SeparatedSyntaxList<AttributeArgumentSyntax> argList = attSyntax.ArgumentList.Arguments;
                            int slot = -1;
                            if (argList.Count > 0)
                            {
                                int.TryParse(argList[0].ToString(), out slot);
                            }

                            string cbName = structSyntax.Identifier.ToString();
                            context.AddConstantBuffer(new ConstantBufferStructure()
                            {
                                Syntax = structSyntax,
                                Slot = slot,
                                Name = cbName,
                            });

                            attributed = true;
                        }
                    }
                }
            }

            if (!attributed)
            {
                context.AddStructure(new ShaderStructure()
                {
                    Syntax = structSyntax,
                });
            }
        }
    }
}
