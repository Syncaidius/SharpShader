﻿using Microsoft.CodeAnalysis;
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
    internal class ProjectCreationProcessor : NodePreprocessor<ObjectCreationExpressionSyntax>
    {
        protected override void OnProcess(ConversionContext context, ObjectCreationExpressionSyntax syntax, StringBuilder source)
        {
            /* Considerations:
             *  - If the parent node is ReturnStatementSyntax, reformat to return by variable, if needed.
             *  - If we have an initializer block, reformat to setting each member  via member access operator (.)
             *  - If we only have a 'new' constructor call, simply strip the 'new' keyword.
             */

            string typeTranslation = GetTypeTranslation(context, syntax.Type);
            string varName = null;

            if (syntax.Parent is AssignmentExpressionSyntax assignment)
                varName = assignment.Left.ToString();
            else
                varName = context.GetNewVariableName("ret");

            // Translate initializer block
            if(syntax.Initializer != null)
            {
                string initializer = "";
                IEnumerable<SyntaxNode> nodes = syntax.Initializer.ChildNodes();
                foreach (SyntaxNode node in nodes)
                    initializer += $"{varName}.{node.ToString()};{Environment.NewLine}";

                // Check if the return syntax needs translating.
                if (syntax.Parent is ReturnStatementSyntax)
                {
                    // Get a name for our temporary variable.
                    string result = $"{typeTranslation} {varName};{Environment.NewLine}";
                    result += initializer;
                    result += $"return {varName};";

                    source.Replace(syntax.Parent.ToString(), result, syntax.Parent.SpanStart, syntax.Parent.Span.Length);
                }
            }
            else
            {
                string initializer = syntax.ToString().Replace(syntax.Type.ToString(), typeTranslation).Replace("new ", "");

                // Check if the return syntax needs translating.
                if (syntax.Parent is ReturnStatementSyntax)
                {
                    // Get a name for our temporary variable.
                    string result = $"return {initializer};";

                    source.Replace(syntax.Parent.ToString(), result, syntax.Parent.SpanStart, syntax.Parent.Span.Length);
                }                
            }
        }
    }
}
