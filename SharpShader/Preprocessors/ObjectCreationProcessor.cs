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
    internal class ProjectCreationProcessor : NodePreprocessor<ObjectCreationExpressionSyntax>
    {
        protected override void OnProcess(ConversionContext context, ObjectCreationExpressionSyntax syntax, StringBuilder source)
        {
            /* Considerations:
             *  - If the parent node is ReturnStatementSyntax, reformat
             *  - If we have an initializer, reformat to setting each member access via member operator (.)
             * 
             */

            string varName = null;
            if (syntax.Parent is AssignmentExpressionSyntax assignment)
                varName = assignment.Left.ToString();
            else
                varName = context.GetNewVariableName("ret");

            // Translate initializer 
            string initializer = "";
            if(syntax.Initializer != null)
            {
                IEnumerable<SyntaxNode> nodes = syntax.Initializer.ChildNodes();
                foreach (SyntaxNode node in nodes)
                    initializer += $"{varName}.{node.ToString()};{Environment.NewLine}";
            }
            else
            {
                initializer = syntax.ToString();
            }

            // Check if the return syntax needs translating.
            if(syntax.Parent is ReturnStatementSyntax)
            {
                // Get a name for our temporary variable.
                string result = $"{syntax.Type} {varName};{Environment.NewLine}";
                result += initializer + Environment.NewLine;
                result += $"return {varName};";

                source.Replace(syntax.Parent.ToString(), result);
            }
        }
    }
}
