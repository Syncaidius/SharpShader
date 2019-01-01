using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class PropertyTranslation
    {
        public string GetterMethod = null;

        public string SetterMethod = null;

        public string TypeName = null;

        public Type OriginalType = null;

        internal string GetGetterHeader(SeparatedSyntaxList<ParameterSyntax> extraParameters = default)
        {
            if (extraParameters != null && extraParameters.Count > 0)
                return $"{TypeName} {GetterMethod}({extraParameters})";
            else
                return $"{TypeName} {GetterMethod}()";
        }

        internal string GetSetterHeader(SeparatedSyntaxList<ParameterSyntax> extraParameters = default)
        {
            if (extraParameters != null && extraParameters.Count > 0)
                return $"void {SetterMethod}({TypeName} value, {extraParameters})";
            else
                return $"void {SetterMethod}({TypeName} value)";
        }

        internal string TranslateArrowGetter(ArrowExpressionClauseSyntax arrowSyntax, SeparatedSyntaxList<ParameterSyntax> extraParameters = default)
        {
            string getterTranslation = GetGetterHeader(extraParameters) + Environment.NewLine;
            getterTranslation += "{" + Environment.NewLine;
            getterTranslation += $"return {arrowSyntax.Expression.ToString()};{Environment.NewLine}";
            getterTranslation += "}";

            return getterTranslation;
        }

        internal string TranslateArrowSetter(ArrowExpressionClauseSyntax arrowSyntax, SeparatedSyntaxList<ParameterSyntax> extraParameters = default)
        {
            string setterTranslation = $"{GetSetterHeader(extraParameters)}{Environment.NewLine}";
            setterTranslation += "{" + Environment.NewLine;
            setterTranslation += $"{arrowSyntax.Expression.ToString()};{Environment.NewLine}";
            setterTranslation += "}";
            return setterTranslation;
        }
    }
}
