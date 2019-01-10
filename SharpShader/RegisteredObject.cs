using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// A member 
    /// </summary>
    internal class RegisteredMember<T>
        where T : class
    {
        internal readonly T Info;

        /// <summary>
        /// The <see cref="RegisterAttribute"/> syntax node, or null if not present.
        /// </summary>
        internal readonly RegisterAttribute[] Attributes;

        internal RegisteredMember(T memberInfo, RegisterAttribute[] regAttributes)
        {
            Info = memberInfo;
            Attributes = regAttributes;
        }
    }
}
