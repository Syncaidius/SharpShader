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
        protected override void OnMap(ShaderContext context, FieldDeclarationSyntax syntax)
        {
            if (syntax.Parent == context.Root)
                context.AddField(syntax);
        }

        protected override void OnTranslate(ShaderContext context, FieldDeclarationSyntax syntax)
        {
            string typeName = syntax.Declaration.Type.ToString(); 

            // If we're removing the field, we can skip translating it.
            if (!context.Parent.Foundation.InstancedConstantBuffers)
            {
                if (context.ConstantBuffers.ContainsKey(typeName))
                {
                    context.RemoveSource(syntax);
                    return;
                }
            }

            Type t = context.GetOriginalType(syntax.Declaration.Type);
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
                            context.ReplaceSource(syntax, translation);
                        }
                    }
                    else
                    {
                        context.Parent.AddMessage($"Attribute: {regAttribute.ToString()} cannot be used on type '{typeName}'.", syntax);
                    }
                }
            }

            TranslationHelper.TranslateModifiers(context, syntax.Modifiers);
        }
    }
}
