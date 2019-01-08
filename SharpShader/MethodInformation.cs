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
        public TypeSyntax ReturnType { get; }

        public SyntaxToken Identifier { get; }

        public MethodDeclarationSyntax Syntax { get; }

        public AttributeLookup Attributes { get; }

        public Dictionary<string, MethodParameterInformation> Parameters { get; }

        internal MethodInformation(MethodDeclarationSyntax syntax)
        {
            Syntax = syntax;
            ReturnType = syntax.ReturnType;
            Identifier = syntax.Identifier;
            Attributes = new AttributeLookup(syntax.AttributeLists);
            Parameters = new Dictionary<string, MethodParameterInformation>();
            foreach(ParameterSyntax p in syntax.ParameterList.Parameters)
                Parameters.Add(p.Identifier.ValueText, new MethodParameterInformation(p));
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
        public AttributeLookup Attributes { get; }

        public ParameterSyntax Syntax { get; }

        internal MethodParameterInformation(ParameterSyntax syntax)
        {
            Attributes = new AttributeLookup(syntax.AttributeLists);
            Syntax = syntax;
        }
    }
}
