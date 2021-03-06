﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SharpShader.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    [Serializable]
    internal partial class ShaderTranslationContext : IPoolable
    {
        internal ShaderLanguage Language => Parent.Language;

        internal TranslationRunner Runner => Parent.Runner;

        [field: NonSerialized]
        internal SyntaxNode RootNode { get; private set; }

        /// <summary>
        /// The <see cref="Type"/> for the shader's own class.
        /// </summary>
        [field: NonSerialized]
        internal Type ShaderType { get; private set; }

        [field: NonSerialized]
        internal TranslationContext Parent { get; private set; }

        [NonSerialized]
        internal readonly Dictionary<MethodInfo, MappedEntryPoint> EntryPointsByMethod;

        internal readonly Dictionary<string, MappedEntryPoint> EntryPointsByName;

        /// <summary>
        /// All C#-based fields contained within the shader class.
        /// </summary>
        [NonSerialized]
        internal readonly Dictionary<string, FieldInfo> Fields;

        /// <summary>
        /// A list of mapped shader fields. These are not struct members.
        /// </summary>
        internal readonly List<MappedField> MappedFields;

        [NonSerialized]
        internal readonly Dictionary<string, Type> Structures;

        internal readonly Dictionary<string, MappedConstantBuffer> ConstantBuffers;

        /// <summary>
        /// A hashset containing all nodes that have or will be skipped during translation. The children of skipped nodes are also recursively skipped.
        /// </summary>
        [NonSerialized]
        readonly HashSet<SyntaxNode> _completedNodes;

        [NonSerialized]
        readonly Dictionary<string, MethodBucket> _methods;

        internal string Name { get; private set; }

        [field:NonSerialized]
        internal OutputSource Source { get; }

        internal string FinalSource { get; set; }

        public ShaderTranslationContext()
        {
            _completedNodes = new HashSet<SyntaxNode>();
            Source = new OutputSource();

            EntryPointsByMethod = new Dictionary<MethodInfo, MappedEntryPoint>();
            EntryPointsByName = new Dictionary<string, MappedEntryPoint>();
            _methods = new Dictionary<string, MethodBucket>();
            Fields = new Dictionary<string, FieldInfo>();
            MappedFields = new List<MappedField>();
            Structures = new Dictionary<string, Type>();
            ConstantBuffers = new Dictionary<string, MappedConstantBuffer>();
        }

        internal void Initialize(TranslationContext parent, ClassDeclarationSyntax syntax, Type shaderType)
        {
            Parent = parent;
            Name = $"{shaderType.Namespace}.{syntax.Identifier.ValueText}";
            ShaderType = shaderType;
            SyntaxTree tree = CSharpSyntaxTree.ParseText(syntax.ToString(), Parent.ParseOptions);
            RootNode = tree.GetRoot();
            Source.Initialize(this, parent.Flags);

            BindingFlags bFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.DeclaredOnly;

            // Traverse inheritance chain until we hit the CSharpShader base class.
            // We do not need members of the base shader class.
            Type sType = ShaderType;
            while (sType != typeof(CSharpShader))
            {
                PopulateStructInfo(sType, bFlags);
                PopulateMethodInfo(sType, bFlags);
                PopulateFieldInfo(sType, bFlags);

                sType = sType.BaseType;
            }
        }

        void IPoolable.Clear()
        {
            Source.Clear();
            FinalSource = null;
            Parent = null;
            Name = null;
            ShaderType = null;
            RootNode = null;

            foreach (KeyValuePair<string, MethodBucket> p in _methods)
                Pooling.MethodBuckets.Put(p.Value);

            foreach (KeyValuePair<string, MappedConstantBuffer> p in ConstantBuffers)
                Pooling.MappedConstBuffers.Put(p.Value);

            _methods.Clear();
            _completedNodes.Clear();
            EntryPointsByMethod.Clear();
            EntryPointsByName.Clear();
            Fields.Clear();
            MappedFields.Clear();
            Structures.Clear();
            ConstantBuffers.Clear();
        }

        private void PopulateMethodInfo(Type classType, BindingFlags bFlags)
        {
            MethodInfo[] mInfo = classType.GetMethods(bFlags);
            foreach (MethodInfo mi in mInfo)
            {
                IEnumerable<EntryPointAttribute> eps = mi.GetCustomAttributes<EntryPointAttribute>(true);
                EntryPointAttribute epAttribute = eps.FirstOrDefault();
                if (epAttribute != null)
                {
                    if (eps.Count() > 1)
                        Parent.AddMessage($"Method '{mi.Name}' has multiple entry-point attributes. Using '{epAttribute.GetType().Name}'.", 0, 0, TranslationMessageType.Warning);

                    IEntryPointTranslator epTranslator = Language.GetEntryPoinTranslator(epAttribute.EntryType);
                    MappedEntryPoint ep = new MappedEntryPoint(mi.Name, epTranslator, epAttribute);

                    EntryPointsByMethod.Add(mi, ep);
                    EntryPointsByName.Add(mi.Name, ep);
                }

                MethodBucket bucket;
                if (!_methods.TryGetValue(mi.Name, out bucket))
                {
                    bucket = Pooling.MethodBuckets.Get();
                    _methods.Add(mi.Name, bucket);
                }

                bucket.Add(mi);
            }
        }

        private void PopulateFieldInfo(Type classType, BindingFlags bFlags)
        {
            FieldInfo[] fInfo = classType.GetFields(bFlags);
            foreach (FieldInfo fi in fInfo)
                Fields.Add(fi.Name, fi);
        }

        private void PopulateStructInfo(Type classType, BindingFlags bFlags)
        {
            Type[] nestedTypes = classType.GetNestedTypes(bFlags);
            foreach(Type t in nestedTypes)
            {
                if (!t.IsValueType)
                    continue;

                ConstantBufferAttribute cbAttribute = t.GetCustomAttribute<ConstantBufferAttribute>();
                if (cbAttribute != null)
                {
                    RegisterAttribute[] regAttributes = t.GetCustomAttributes<RegisterAttribute>().ToArray();
                    MappedConstantBuffer cbm = new MappedConstantBuffer()
                    {
                        TypeInfo = t,
                    };
                    ConstantBuffers.Add(t.Name, cbm);
                }
                else
                {
                    Structures.Add(t.Name, t);
                }
            }
        }

        internal MethodInfo GetMethodInfo(MethodDeclarationSyntax syntax)
        {
            if (_methods.TryGetValue(syntax.Identifier.ValueText, out MethodBucket bucket))
                return bucket.Find(this, syntax);

            return null;
        }

        internal (ParameterInfo info, int index) GetParameterInfo(MethodInfo mInfo, string parameterName)
        {
            if (_methods.TryGetValue(mInfo.Name, out MethodBucket bucket))
                return bucket.GetParameterInfo(mInfo, parameterName);
            else
                return (null, 0);
        }

        internal void AddMessage(string text, SyntaxNode node, TranslationMessageType type = TranslationMessageType.Error)
        {
            Location loc = node.GetLocation();
            FileLinePositionSpan span = loc.GetLineSpan();
            AddMessage(text, span.StartLinePosition.Line, span.StartLinePosition.Character, type);
        }

        internal void AddMessage(string text, int lineNumber, int linePos, TranslationMessageType type = TranslationMessageType.Error)
        {
            Parent.AddMessage($"{Name}: {text}", lineNumber, linePos, type);
        }

        /// <summary>
        /// Marks the child nodes of the specified <see cref="SyntaxNode"/> as completed.
        /// </summary>
        /// <param name="node">The node who's children will be marked as completed.</param>
        internal void CompleteChildren(SyntaxNode node)
        {
            IEnumerable<SyntaxNode> children = node.ChildNodes();
            foreach (SyntaxNode n in children)
                _completedNodes.Add(n);
        }

        /// <summary>
        /// Marks a <see cref="SyntaxNode"/> as completed. This means that it will be skipped if it comes up again later in the translation process.
        /// </summary>
        /// <param name="node">The node to be completed.</param>
        internal void Complete(SyntaxNode node)
        {
            _completedNodes.Add(node);
        }

        internal void Complete<T>(SyntaxList<T> nodeList) where T : SyntaxNode
        {
            foreach (T node in nodeList)
                _completedNodes.Add(node);
        }

        /// <summary>
        /// Marks a <see cref="SyntaxNode"/> and it's child nodes as completed. This means that it will be skipped if it comes up again later in the translation process.
        /// </summary>
        /// <param name="node">The node to be completed.</param>
        internal void CompleteSelfAndChildren(SyntaxNode node)
        {
            _completedNodes.Add(node);
            CompleteChildren(node);
        }

        internal bool IsCompleted(SyntaxNode node)
        {
            return _completedNodes.Contains(node);
        }

        internal void CompleteSelfAndChildren<T>(SyntaxList<T> nodeList) where T : SyntaxNode
        {
            foreach (T node in nodeList)
                CompleteSelfAndChildren(node);
        }

        public override string ToString()
        {
            return $"{Name} - {base.ToString()}";
        }
    }
}
