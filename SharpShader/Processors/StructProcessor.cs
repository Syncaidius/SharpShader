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
        internal override NodeProcessStageFlags Stages => NodeProcessStageFlags.PreProcess | NodeProcessStageFlags.Mapping | NodeProcessStageFlags.PostProcess;

        protected override void OnPreprocess(ConversionContext context, StructDeclarationSyntax node, StringBuilder source)
        {
            RemoveTokens(node.Modifiers, source);
        }

        protected override void OnMap(ConversionContext context, StructDeclarationSyntax syntax)
        {
            if (ShaderReflection.HasAttribute<ConstantBufferAttribute>(syntax.AttributeLists))
                context.Map.AddConstantBuffer(syntax);
            else
                context.Map.AddStructure(syntax);
        }

        protected override void OnPostprocess(ConversionContext context, StructDeclarationSyntax syntax, StringBuilder source, ShaderComponent component)
        {
            AttributeSyntax cbAttribute = ShaderReflection.GetAttribute<ConstantBufferAttribute>(syntax.AttributeLists);
            if(cbAttribute != null)
            {
                SeparatedSyntaxList<AttributeArgumentSyntax> argList = cbAttribute.ArgumentList.Arguments;
                int slot = -1;
                if (argList.Count > 0)
                    int.TryParse(argList[0].ToString(), out slot);

                string translated = context.Lexicon.Foundation.TranslateConstantBuffer(context, syntax, slot);
                source.Replace(syntax.ToString(), translated);
            }
            else
            {
                string translated = context.Lexicon.Foundation.TranslateStruct(context, syntax);
                source.Replace(syntax.ToString(), translated);
            }
        }
    }
}
