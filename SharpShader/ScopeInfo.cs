using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class ScopeInfo
    {
        public readonly OpenBlockType Type;

        public readonly ScopeInfo Parent;

        public readonly int IndentationDepth;

        internal ScopeInfo(ScopeInfo parent, OpenBlockType type, int indentDepth)
        {
            Parent = parent;
            Type = type;
            IndentationDepth = indentDepth;
        }
    }

    internal enum OpenBlockType
    {
        None = 0,

        Struct = 1,

        Method = 2,

        Initializer = 3,

        ArgumentParentheses = 4,

        InvocationParentheses = 5,

        ForLoop = 6,

        ForeachLoop = 7,

        WhileLoop = 8,

        DoWhileLoop = 9,

        /// <summary>
        /// A member within an initializer field.
        /// </summary>
        InitializerMember = 10,

        ObjectCreation = 11,

        /// <summary>
        /// An assignment inside an initializer.
        /// </summary>
        InitializerAssignment = 12,

        /// <summary>
        /// An assignment inside a class or member (e.g. field, property, local variable) and not inside an initializer.
        /// </summary>
        MemberAssignment = 13,

        /// <summary>
        /// The assignment of a default parameter value.
        /// </summary>
        ParameterDefaultAssignment = 14,

        FieldDeclaration = 15,

    }
}
