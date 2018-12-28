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

        protected override void OnPreprocess(ShaderContext context, StructDeclarationSyntax syntax, StringBuilder source)
        {
            //TranslateModifiers(context, syntax.Modifiers, source);
        }

        protected override void OnMap(ShaderContext context, StructDeclarationSyntax syntax)
        {
            AttributeSyntax cbAttribute = ShaderReflection.GetAttribute<ConstantBufferAttribute>(syntax.AttributeLists);
            if (cbAttribute != null)
            {
 
                AttributeSyntax regAttribute = ShaderReflection.GetAttribute<RegisterAttribute>(syntax.AttributeLists);
                context.Map.AddConstantBuffer(syntax, regAttribute);
            }
            else
            {
                context.Map.AddStructure(syntax);
            }
        }

        protected override void OnTranslate(ShaderContext context, StructDeclarationSyntax syntax, StringBuilder source, ShaderElement component)
        {
            string translation = "";
            if(component.Type == ShaderComponentType.ConstantBuffer)
            {
                uint? registerID = null;
                AttributeSyntax regAttribute = ShaderReflection.GetAttribute<RegisterAttribute>(syntax.AttributeLists);
                if (regAttribute != null)
                    registerID = RegisterAttribute.Parse(regAttribute);

                translation = context.Parent.Foundation.TranslateConstantBuffer(context, syntax, registerID);
                source.Replace(syntax.ToString(), translation);
            }
            else
            {
                translation = context.Parent.Foundation.TranslateStruct(context, syntax);
                source.Replace(syntax.ToString(), translation);
            }

            TranslateModifiers(context, translation.Length, syntax, syntax.Modifiers, source);
        }
    }
}
