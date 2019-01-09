using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class MethodInformation
    {
        public readonly TypeSyntax ReturnType;

        public readonly SyntaxToken Identifier;

        public readonly MethodDeclarationSyntax Syntax;

        public readonly AttributeLookup Attributes;

        public readonly Dictionary<string, MethodParameterInformation> Parameters;

        public readonly List<string> OrderedParameterNames;

        internal MethodInformation(MethodDeclarationSyntax syntax)
        {
            Syntax = syntax;
            ReturnType = syntax.ReturnType;
            Identifier = syntax.Identifier;
            Attributes = new AttributeLookup(syntax.AttributeLists);
            Parameters = new Dictionary<string, MethodParameterInformation>();
            OrderedParameterNames = new List<string>();

            foreach (ParameterSyntax p in syntax.ParameterList.Parameters)
            {
                Parameters.Add(p.Identifier.ValueText, new MethodParameterInformation(p));
                OrderedParameterNames.Add(p.Identifier.ValueText);
            }
        }

        /// <summary>
        /// Returns the method's full parameter string, including parentheses.
        /// </summary>
        /// <returns></returns>
        public string GetParameterString()
        {
            return Syntax.ParameterList.ToString();
        }
    }

    internal class MethodParameterInformation
    {
        public readonly AttributeLookup Attributes;

        public readonly ParameterSyntax Syntax;

        public readonly TypeSyntax Type;

        public readonly SyntaxToken Identifier;

        internal MethodParameterInformation(ParameterSyntax syntax)
        {
            Attributes = new AttributeLookup(syntax.AttributeLists);
            Syntax = syntax;
            Type = syntax.Type;
            Identifier = syntax.Identifier;
        }
    }
}
