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
    internal class ScopeInfo : IPoolable
    {
        /// <summary>
        /// Finds an insertion point to declare local syntax, such as a local variable. This is generally used for expanding an initializer into full syntax.<para/>
        /// A callback is provided to output translated syntax at the correct location before returning to the end of the output source code.
        /// </summary>
        /// <param name="sc"></param>
        /// <param name="callback"></param>
        internal void DeclareLocal(ShaderTranslationContext sc, Action callback)
        {
            // The root scope implements IDeclarativeScope, so eventually we will hit that if no others are avaialble along the way.
            ScopeInfo si = this;
            while(si != null)
            {
                if(si.InsertionPoint > -1)
                {
                    sc.Source.SetPosition(si.InsertionPoint);
                    callback();
                    sc.Source.SetPositionToEnd();
                    return;
                }

                si = si.Parent;
            }
        }

        /// <summary>
        /// Finds an ancestral scope of the specified type, or itself if it is a match.
        /// </summary>
        /// <param name="type">The type of scope to find.</param>
        /// <returns></returns>
        internal ScopeInfo FindOfType(ScopeType type)
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
            TranslatedModifiers = "";
            Namespace = "";
            IsLocal = false;
            InsertionPoint = -1;
            StructType = StructScopeType.None;
            Tracker = null;
        }

        internal ScopeInfo Parent;

        internal int IndentationDepth;

        /// <summary>
        /// The location at which any declarations are inserted. This is ignored if <see cref="IsDeclarative"/> is false.
        /// </summary>
        internal int InsertionPoint;

        internal ScopeSettings Settings;

        internal MethodInfo Method;

        internal ScopeType Type;

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
        internal ShaderType TypeInfo;

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

        /// <summary>
        /// An optional scope tracker to be updated when the scope is opened and closed.
        /// </summary>
        internal IScopeTracker Tracker;
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

    internal interface IScopeTracker
    {
        int StartIndex { get; set; }

        int EndIndex { get; set; }
    }
}
