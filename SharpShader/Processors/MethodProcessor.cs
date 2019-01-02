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
        protected override void OnPreprocess(ShaderContext context, MethodDeclarationSyntax syntax, StringBuilder source)
        {
            // Expand arrow expression bodies into full bodies. This simplifies processing later.
            // This is done first to avoid invalidating the spans of the method parameters and types.
            if(syntax.ExpressionBody != null)
            {
                string replacement = $"{syntax.Modifiers} {syntax.ReturnType} {syntax.Identifier}{syntax.TypeParameterList}{syntax.ParameterList} {syntax.ConstraintClauses}{Environment.NewLine}";
                replacement += "{" + Environment.NewLine;
                replacement += $"return {syntax.ExpressionBody.Expression};{Environment.NewLine}";
                replacement += "}";
                source.Replace(syntax.ToString(), replacement, syntax.SpanStart, syntax.Span.Length);
            }

            SeparatedSyntaxList<ParameterSyntax> paramList = syntax.ParameterList.Parameters;
            for (int i = paramList.Count - 1; i >= 0; i--)
                TranslationHelper.TranslateTypeSyntax(context, paramList[i].Type, source);

            TranslationHelper.TranslateTypeSyntax(context, syntax.ReturnType, source);
        }

        protected override void OnMap(ShaderContext context, MethodDeclarationSyntax syntax)
        {
            foreach (AttributeListSyntax list in syntax.AttributeLists)
            {
                foreach (AttributeSyntax attSyntax in list.Attributes)
                {
                    string name = attSyntax.Name.ToString();
                    if (!name.EndsWith("Attribute"))
                        name += "Attribute";

                    Type attType = ShaderReflection.ResolveType(name);
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
                            context.Map.AddEntryPoint(new EntryPoint(attType, attSyntax, syntax, ep));
                    }
                }
            }
        }

        protected override void OnTranslate(ShaderContext context, MethodDeclarationSyntax syntax, StringBuilder source)
        {
            int translationLength = syntax.Span.Length;
            if (context.Map.EntryPoints.ContainsKey(syntax.Identifier.ValueText))
            {
                SyntaxNode bodyNode = syntax.Body ?? syntax.ExpressionBody as SyntaxNode;
                int methodHeaderLength = bodyNode.SpanStart - syntax.SpanStart;
                string toReplace = syntax.ToString().Substring(0, methodHeaderLength);
                string methodHeader = toReplace;
                string methodName = syntax.Identifier.ToString();

                EntryPoint ep = context.Map.EntryPoints[methodName];
                IEntryPointTranslator epTranslator = context.Parent.Foundation.GetEntryPointTranslator(ep.EntryType);
                if (epTranslator != null)
                {
                    string translation = epTranslator.Translate(context, ep, ref methodHeader);
                    translationLength = translation.Length;
                    source.Replace(toReplace, translation);
                }
            }

            TranslationHelper.TranslateModifiers(context, translationLength, syntax, syntax.Modifiers, source);
        }
    }
}
