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
        protected override void OnPreprocess(ShaderContext context, MethodDeclarationSyntax syntax)
        {
            // Expand arrow expression bodies into full bodies. This simplifies processing later.
            // This is done first to avoid invalidating the spans of the method parameters and types.
            if(syntax.ExpressionBody != null)
            {
                string replacement = $"{syntax.Modifiers} {syntax.ReturnType} {syntax.Identifier}{syntax.TypeParameterList}{syntax.ParameterList} {syntax.ConstraintClauses}{Environment.NewLine}";
                replacement += "{" + Environment.NewLine;
                replacement += $"return {syntax.ExpressionBody.Expression};{Environment.NewLine}";
                replacement += "}";
                context.ReplaceSource(syntax, replacement);
            }

            SeparatedSyntaxList<ParameterSyntax> paramList = syntax.ParameterList.Parameters;
            for (int i = paramList.Count - 1; i >= 0; i--)
                TranslationHelper.TranslateTypeSyntax(context, paramList[i].Type);

            TranslationHelper.TranslateTypeSyntax(context, syntax.ReturnType);
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
                            context.AddEntryPoint(new EntryPoint(attType, attSyntax, syntax, ep));
                    }
                }
            }
        }

        protected override void OnTranslate(ShaderContext context, MethodDeclarationSyntax syntax)
        {
            MethodInformation info = new MethodInformation(syntax);

            string methodHeader = "";
            if (context.EntryPoints.ContainsKey(syntax.Identifier.ValueText))
            {
                string methodName = syntax.Identifier.ToString();
                EntryPoint ep = context.EntryPoints[methodName];

                IEntryPointTranslator epTranslator = context.Parent.Foundation.GetEntryPointTranslator(ep.EntryType);
                if (epTranslator != null)
                    methodHeader = epTranslator.TranslateHeader(context, ep, info);
            }

            // Build a replacement method header which includes the necessary translations.
            if (string.IsNullOrWhiteSpace(methodHeader))
            {
                string mModifiers = context.Parent.Foundation.TranslateModifiers(syntax.Modifiers);
                methodHeader += $"{mModifiers} {syntax.ReturnType} {syntax.Identifier}{syntax.TypeParameterList}(";

                bool firstParam = true;
                foreach (KeyValuePair<string, MethodParameterInformation> p in info.Parameters)
                {
                    if (!firstParam)
                        methodHeader += ", ";

                    string pModifiers = context.Parent.Foundation.TranslateModifiers(p.Value.Syntax.Modifiers);
                    if (pModifiers.Length > 0)
                        methodHeader += $"{pModifiers} ";

                    methodHeader += $"{p.Value.Syntax.Type} {p.Value.Syntax.Identifier}";
                    firstParam = false;
                }

                methodHeader += $") {syntax.ConstraintClauses}";
            }

            methodHeader += Environment.NewLine;
            string strMethod = syntax.ToString();
            int firstBracket = strMethod.IndexOf('{');
            strMethod = strMethod.Substring(0, firstBracket);

            context.ReplaceSource(strMethod, methodHeader, syntax.SpanStart, firstBracket);
        }
    }
}
