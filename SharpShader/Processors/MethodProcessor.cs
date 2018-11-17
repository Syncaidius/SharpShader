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
    internal class MethodProcessor : NodeProcessor<MethodDeclarationSyntax>
    {
        internal override NodeProcessStageFlags Stages => NodeProcessStageFlags.PreProcess | NodeProcessStageFlags.Mapping;

        protected override void OnpPreprocess(ConversionContext context, MethodDeclarationSyntax syntax, StringBuilder source)
        {
            // Translate (if any) types of every parameter of the method.
            SeparatedSyntaxList<ParameterSyntax> paramList = syntax.ParameterList.Parameters;
            for (int i = paramList.Count - 1; i >= 0; i--)
                TranslateTypeSyntax(context, paramList[i].Type, source);

            //syntax.TypeParameterList
            // Update the type first, this comes after the modifiers.
            TranslateTypeSyntax(context, syntax.ReturnType, source);

            // Remove field modifiers (i.e. public, protected, etc).
            RemoveTokens(syntax.Modifiers, source);
        }

        protected override void OnMap(ConversionContext context, MethodDeclarationSyntax syntax)
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
                                MethodSyntax = syntax,
                                AttributeSyntax = attSyntax,
                            });
                            attributed = true;
                        }
                    }
                }
            }

            if (!attributed)
                context.Map.AddMethod(syntax);
        }
    }
}
