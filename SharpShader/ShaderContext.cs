using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    [Serializable]
    internal partial class ShaderContext
    {
        internal ShaderLanguage Language => Parent.Language;

        [NonSerialized]
        internal readonly SyntaxNode RootNode;

        [field: NonSerialized]
        internal Type ShaderType { get; }

        [NonSerialized]
        internal readonly ConversionContext Parent;

        [NonSerialized]
        internal readonly Dictionary<string, EntryPoint> EntryPoints;

        /// <summary>
        /// All fields that are to be treated as standard 'fields' in the output source.
        /// </summary>
        [NonSerialized]
        internal readonly Dictionary<string, FieldInfo> ShaderFields;

        /// <summary>
        /// All C#-based fields contained within the shader class.
        /// </summary>
        [NonSerialized]
        internal readonly Dictionary<string, FieldInfo> AllFields;

        [NonSerialized]
        internal readonly Dictionary<string, Type> Structures;

        [NonSerialized]
        internal readonly Dictionary<string, Type> ConstantBuffers;

        [NonSerialized]
        internal readonly Dictionary<string, FieldInfo> Textures;

        [NonSerialized]
        internal readonly Dictionary<string, FieldInfo> Samplers;

        [NonSerialized]
        internal readonly Dictionary<string, FieldInfo> Buffers;

        [NonSerialized]
        internal readonly Dictionary<string, FieldInfo> UAVs;

        /// <summary>
        /// A hashset containing all nodes that have or will be skipped during translation. The children of skipped nodes are also recursively skipped.
        /// </summary>
        [NonSerialized]
        readonly HashSet<SyntaxNode> _completedNodes;

        [NonSerialized]
        readonly Dictionary<string, MethodBucket> _methods;

        internal string Name { get; }

        internal OutputSource Source { get; }

        internal ShaderContext(ConversionContext parent, ClassDeclarationSyntax syntax, Type shaderType)
        {
            Parent = parent;
            Name = syntax.Identifier.ValueText;
            ShaderType = shaderType;
            SyntaxTree tree = CSharpSyntaxTree.ParseText(syntax.ToString(), Parent.ParseOptions);
            RootNode = tree.GetRoot();
            _completedNodes = new HashSet<SyntaxNode>();
            Source = new OutputSource();

            EntryPoints = new Dictionary<string, EntryPoint>();
            _methods = new Dictionary<string, MethodBucket>();
            ShaderFields = new Dictionary<string, FieldInfo>();
            AllFields = new Dictionary<string, FieldInfo>();
            Structures = new Dictionary<string, Type>();
            ConstantBuffers = new Dictionary<string, Type>();
            Textures = new Dictionary<string, FieldInfo>();
            Samplers = new Dictionary<string, FieldInfo>();
            Buffers = new Dictionary<string, FieldInfo>();
            UAVs = new Dictionary<string, FieldInfo>();

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
                        Parent.AddMessage($"Method '{mi.Name}' has multiple entry-point attributes. Using '{epAttribute.GetType().Name}'.", 0, 0, ConversionMessageType.Warning);

                    EntryPoints.Add(mi.Name, new EntryPoint(mi, epAttribute, epAttribute.EntryType));
                }
                else
                {
                    MethodBucket bucket;
                    if (!_methods.TryGetValue(mi.Name, out bucket))
                    {
                        bucket = new MethodBucket();
                        _methods.Add(mi.Name, bucket);
                    }

                    bucket.Add(mi);
                }
            }
        }

        private void PopulateFieldInfo(Type classType, BindingFlags bFlags)
        {
            FieldInfo[] fInfo = classType.GetFields(bFlags | BindingFlags.DeclaredOnly);
            foreach (FieldInfo fi in fInfo)
            {
                AllFields.Add(fi.Name, fi);

                RegisteredTypeAttribute regTypeAttribute = fi.FieldType.GetCustomAttribute<RegisteredTypeAttribute>();

                if (regTypeAttribute != null)
                {
                    UnorderedAccessTypeAttribute uav = fi.FieldType.GetCustomAttribute<UnorderedAccessTypeAttribute>();

                    if (uav != null)
                    {
                        UAVs.Add(fi.Name, fi);
                    }
                    else
                    {
                        if (typeof(TextureBase).IsAssignableFrom(fi.FieldType))
                            Textures.Add(fi.Name, fi);
                        else if (typeof(TextureSampler).IsAssignableFrom(fi.FieldType))
                            Samplers.Add(fi.Name, fi);
                        else if (typeof(IStructureBuffer).IsAssignableFrom(fi.FieldType))
                            Buffers.Add(fi.Name, fi);
                    }
                }
                else
                {
                    ShaderFields.Add(fi.Name, fi);
                }
            }
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
                    ConstantBuffers.Add(t.Name, t);
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
                return bucket.Find(syntax);

            return null;
        }

        internal void AddMessage(string text, SyntaxNode node, ConversionMessageType type = ConversionMessageType.Error)
        {
            Location loc = node.GetLocation();
            FileLinePositionSpan span = loc.GetLineSpan();
            AddMessage(text, span.StartLinePosition.Line, span.StartLinePosition.Character, type);
        }

        internal void AddMessage(string text, int lineNumber, int linePos, ConversionMessageType type = ConversionMessageType.Error)
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
