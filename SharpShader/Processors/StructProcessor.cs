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
    internal class StructProcessor : NodeProcessor<StructDeclarationSyntax>
    {
        internal override NodeProcessStageFlags Stages => NodeProcessStageFlags.PreProcess | NodeProcessStageFlags.Mapping;

        protected override void OnpPreprocess(ConversionContext context, StructDeclarationSyntax node, StringBuilder source)
        {
            RemoveTokens(node.Modifiers, source);
        }

        protected override void OnMap(ConversionContext context, StructDeclarationSyntax syntax)
        {
            bool attributed = false;

            foreach (AttributeListSyntax list in syntax.AttributeLists)
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

                            string cbName = syntax.Identifier.ToString();
                            context.Map.AddConstantBuffer(new ConstantBufferStructure()
                            {
                                Syntax = syntax,
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
                context.Map.AddStructure(new ShaderStructure()
                {
                    Syntax = syntax,
                });
            }
        }
    }
}
