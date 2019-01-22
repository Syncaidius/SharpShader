using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class ScopeInfo : IPoolable
    {
        Dictionary<string, string> _declarations = new Dictionary<string, string>();

        internal string DeclareLocalVariable(ShaderContext sc, string typeName, string initializer = null)
        {
            string varName = sc.Parent.GetNewVariableName();
            string syntax = $"{typeName} {varName}";
            if (string.IsNullOrWhiteSpace(initializer))
                syntax += ";";
            else
                syntax += $" = {initializer};";

            // The root scope implements IDeclarativeScope, so eventually we will hit that if no others are avaialble along the way.
            ScopeInfo si = this;
            while(si != null)
            {
                if(si.IsDeclarative)
                {
                    si._declarations.Add(varName, syntax);
                    break;
                }

                si = si.Parent;
            }

            return varName;
        }

        internal ScopeInfo FindParentOfType(ScopeType type)
        {
            ScopeInfo si = Parent;
            while(si != null)
            {
                if (si.Type == type)
                    return si;
                else
                    si = si.Parent;
            }

            return null;
        }

        public void Clear()
        {
            Parent = null;
            Settings = null;
            Method = null;
            Items = default;
            TypeInfo = null;
            TranslatedTypeName = null;
            TranslatedModifiers = "";
            Namespace = "";
            IsLocal = false;
            IsDeclarative = false;
            StructType = StructScopeType.None;
            _declarations.Clear();
        }

        internal ScopeInfo Parent;

        internal int IndentationDepth;

        /// <summary>
        /// The location at which any declarations are inserted. This is ignored if <see cref="IsDeclarative"/> is false.
        /// </summary>
        internal int DeclarativeEntryPosition;

        internal ScopeSettings Settings;

        internal MethodInfo Method;

        internal ScopeType Type;

        /// <summary>
        /// Does the scope accept new declarations to be inserted once it's closed?
        /// </summary>
        internal bool IsDeclarative;

        /// <summary>
        /// The scope's namespace. This is only applicable if the scope is for a class or struct.
        /// </summary>
        internal string Namespace = "";

        /// <summary>
        /// If the scope is <see cref="ScopeType.Struct"/>, this value will be greater than <see cref="StructScopeType.None"/>.
        /// </summary>
        internal StructScopeType StructType;

        internal SeparatedSyntaxList<SyntaxNode> Items;

        /// <summary>
        /// The type info to provide scope information. e.g. Struct or variable type info.
        /// </summary>
        internal Type TypeInfo;

        /// <summary>
        /// The translated version of the original type.
        /// </summary>
        internal string TranslatedTypeName;

        /// <summary>
        /// The translated version of the original modifiers, if any.
        /// </summary>
        internal string TranslatedModifiers = "";

        /// <summary>
        /// The scope is for a local type or variable.
        /// </summary>
        internal bool IsLocal;

        /// <summary>
        /// The identifier/name of a scope object.
        /// </summary>
        internal string Identifier;
    }

    internal enum StructScopeType
    {
        None = 0,

        ConstantBuffer = 1,

        Struct = 2,
    }

    internal enum AcceptedDeclarations
    {
        None = 0,

        Types = 1,

        LocalVariables = 2,

        Fields = 3,
    }
}
