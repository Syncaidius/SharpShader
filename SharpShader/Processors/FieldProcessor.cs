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
            TranslateTypeSyntax(context, syntax.Declaration.Type, source);
        }

        protected override void OnMap(ShaderContext context, FieldDeclarationSyntax syntax)
        {
            if (syntax.Parent == context.Root)
                context.Map.AddField(syntax);
        }

        protected override void OnTranslate(ShaderContext context, FieldDeclarationSyntax syntax, StringBuilder source, ShaderElement component)
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
            int translationLength = syntax.Span.Length;
            if (t != null)
            {
                AttributeSyntax regAttribute = ShaderReflection.GetAttribute<RegisterAttribute>(syntax.AttributeLists);
                if (regAttribute != null)
                {
                    if (ShaderReflection.IsRegisteredType(t))
                    {
                        uint? registerID = RegisterAttribute.Parse(regAttribute);
                        if (registerID != null)
                        {
                            string translation = context.Parent.Foundation.TranslateRegisterField(context, syntax, t, registerID.Value);
                            translationLength = translation.Length;
                            source.Replace(syntax.ToString(), translation, syntax.SpanStart, syntax.Span.Length);
                        }
                    }
                    else
                    {
                        context.Parent.AddMessage($"Attribute: {regAttribute.ToString()} cannot be used on type '{typeName}'.", syntax);
                    }
                }
            }

            TranslateModifiers(context, translationLength, syntax, syntax.Modifiers, source);
        }
    }
}
