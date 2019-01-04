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
        protected override void OnPreprocess(ShaderContext context, StructDeclarationSyntax syntax)
        {
            //TranslateModifiers(context, syntax.Modifiers, source);
        }

        protected override void OnMap(ShaderContext context, StructDeclarationSyntax syntax)
        {
            AttributeSyntax cbAttribute = ShaderReflection.GetAttribute<ConstantBufferAttribute>(syntax.AttributeLists);
            if (cbAttribute != null)
            {
 
                AttributeSyntax regAttribute = ShaderReflection.GetAttribute<RegisterAttribute>(syntax.AttributeLists);
                context.AddConstantBuffer(syntax, regAttribute);
            }
            else
            {
                context.AddStructure(syntax);
            }
        }

        protected override void OnTranslate(ShaderContext context, StructDeclarationSyntax syntax)
        {
            string translation = "";
            if(context.ConstantBuffers.ContainsKey(syntax.Identifier.ValueText))
            {
                uint? registerID = null;
                AttributeSyntax regAttribute = ShaderReflection.GetAttribute<RegisterAttribute>(syntax.AttributeLists);
                if (regAttribute != null)
                    registerID = RegisterAttribute.Parse(regAttribute);

                translation = context.Parent.Foundation.TranslateConstantBuffer(context, syntax, registerID);
            }
            else
            {
                translation = context.Parent.Foundation.TranslateStruct(context, syntax);
            }

            context.ReplaceSource(syntax, translation);
        }
    }
}
