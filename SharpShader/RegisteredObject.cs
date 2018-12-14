using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class RegisteredObject
    {
        /// <summary>
        /// Gets or sets the <see cref="RegisterAttribute"/> syntax node.
        /// </summary>
        internal AttributeSyntax Attribute { get; set; }

        internal uint? RegisterID { get; set; }

        internal RegisteredObject(AttributeSyntax regAttribute)
        {
            Attribute = regAttribute;
            if (regAttribute != null)
            {
                SeparatedSyntaxList<AttributeArgumentSyntax> registerArgs = regAttribute.ArgumentList.Arguments;
                if (uint.TryParse(registerArgs[0].ToString(), out uint parsedID))
                    RegisterID = parsedID;
            }
        }
    }
}
