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
    internal class FieldProcessor : NodeProcessor<FieldDeclarationSyntax>
    {
        internal override NodeProcessStageFlags Stages => NodeProcessStageFlags.PreProcess | NodeProcessStageFlags.Mapping | NodeProcessStageFlags.PostProcess;

        protected override void OnPreprocess(ShaderContext context, FieldDeclarationSyntax syntax, StringBuilder source)
        {
            // Update the type first, this comes after the modifiers.
            TranslateTypeSyntax(context, syntax.Declaration.Type, source);

            // Remove field modifiers (i.e. public, protected, etc).
            RemoveTokens(syntax.Modifiers, source);
        }

        protected override void OnMap(ShaderContext context, FieldDeclarationSyntax syntax)
        {
            AttributeSyntax regAttribute = ShaderReflection.GetAttribute<RegisterAttribute>(syntax.AttributeLists);
            if (regAttribute != null)
            {
                // TODO determine whether or not the field declaration is for a shader construct (sampler, texture, const buffer, etc) by it's type name.
            }

            if (syntax.Parent == context.Root)
                context.Map.AddField(syntax);
        }

        protected override void OnTranslate(ShaderContext context, FieldDeclarationSyntax syntax, StringBuilder source, ShaderComponent component)
        {
            string typeName = syntax.Declaration.Type.ToString(); 

            // If we're removing the field, we can skip translating it.
            if (!context.Parent.Foundation.InstancedConstantBuffers)
            {
                if (context.Map.ConstantBuffers.ContainsKey(typeName))
                {
                    source.Remove(syntax.SpanStart, syntax.Span.Length);
                    return;
                }
            }

            Type t = context.Map.GetOriginalType(typeName);
            if (t != null)
            {
                AttributeSyntax regAttribute = ShaderReflection.GetAttribute<RegisterAttribute>(syntax.AttributeLists);

                if (regAttribute != null)
                {
                    if (ShaderReflection.IsRegisteredType(t))
                    {
                        if (uint.TryParse(regAttribute.ArgumentList.Arguments[0].ToString(), out uint registerID))
                        {
                            string translation = context.Parent.Foundation.TranslateRegisterField(context, syntax, t, registerID);
                            source.Replace(syntax.ToString(), translation, syntax.SpanStart, syntax.Span.Length);
                        }
                    }
                }
            }
        }
    }
}
