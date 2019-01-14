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
        internal readonly Dictionary<string, RegisteredMember<Type>> ConstantBuffers;

        [NonSerialized]
        internal readonly Dictionary<string, RegisteredMember<FieldInfo>> Textures;

        [NonSerialized]
        internal readonly Dictionary<string, RegisteredMember<FieldInfo>> Samplers;

        [NonSerialized]
        internal readonly Dictionary<string, RegisteredMember<FieldInfo>> UAVs;

        /// <summary>
        /// A hashset containing all nodes that have or will be skipped during translation. The children of skipped nodes are also recursively skipped.
        /// </summary>
        [NonSerialized]
        internal readonly HashSet<SyntaxNode> CompletedNodes;

        internal string Name { get; }

        internal OutputSource Source { get; }

        internal ShaderContext(ConversionContext parent, ClassDeclarationSyntax syntax, Type shaderType)
        {
            Parent = parent;
            Name = syntax.Identifier.ValueText;
            ShaderType = shaderType;
            SyntaxTree tree = CSharpSyntaxTree.ParseText(syntax.ToString(), Parent.ParseOptions);
            RootNode = tree.GetRoot();
            CompletedNodes = new HashSet<SyntaxNode>();
            Source = new OutputSource();

            EntryPoints = new Dictionary<string, EntryPoint>();
            ShaderFields = new Dictionary<string, FieldInfo>();
            AllFields = new Dictionary<string, FieldInfo>();
            Structures = new Dictionary<string, Type>();
            ConstantBuffers = new Dictionary<string, RegisteredMember<Type>>();
            Textures = new Dictionary<string, RegisteredMember<FieldInfo>>();
            Samplers = new Dictionary<string, RegisteredMember<FieldInfo>>();
            UAVs = new Dictionary<string, RegisteredMember<FieldInfo>>();

            BindingFlags bFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;
            PopulateStructInfo(bFlags);
            PopulateMethodInfo(bFlags);
            PopulateFieldInfo(bFlags);
        }

        private void PopulateMethodInfo(BindingFlags bFlags)
        {
            MethodInfo[] mInfo = ShaderType.GetMethods(bFlags);
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
            }
        }

        private void PopulateFieldInfo(BindingFlags bFlags)
        {
            FieldInfo[] fInfo = ShaderType.GetFields(bFlags);
            foreach (FieldInfo fi in fInfo)
            {
                AllFields.Add(fi.Name, fi);

                RegisterAttribute[] regAttributes = fi.GetCustomAttributes<RegisterAttribute>().ToArray();
                RegisteredTypeAttribute regTypeAttribute = fi.GetCustomAttribute<RegisteredTypeAttribute>();

                if (regTypeAttribute != null)
                {
                    UnorderedAccessTypeAttribute uav = fi.GetCustomAttribute<UnorderedAccessTypeAttribute>();
                    RegisteredMember<FieldInfo> regInfo = new RegisteredMember<FieldInfo>(fi, regAttributes);

                    if (uav != null)
                    {
                        UAVs.Add(fi.Name, regInfo);
                    }
                    else
                    {
                        if (typeof(TextureBase).IsAssignableFrom(fi.FieldType) )
                            Textures.Add(fi.Name, regInfo);
                        else if (typeof(TextureSampler).IsAssignableFrom(fi.FieldType))
                            Samplers.Add(fi.Name, regInfo);
                    }
                }
                else
                {
                    ShaderFields.Add(fi.Name, fi);
                }
            }
        }

        private void PopulateStructInfo(BindingFlags bFlags)
        {
            Type[] nestedTypes = ShaderType.GetNestedTypes(bFlags);
            foreach(Type t in nestedTypes)
            {
                if (!t.IsValueType)
                    continue;

                ConstantBufferAttribute cbAttribute = t.GetCustomAttribute<ConstantBufferAttribute>();
                if (cbAttribute != null)
                {
                    RegisterAttribute[] regAttributes = t.GetCustomAttributes<RegisterAttribute>().ToArray();
                    RegisteredMember<Type> regInfo = new RegisteredMember<Type>(t, regAttributes);
                    ConstantBuffers.Add(t.Name, regInfo);
                }
                else
                {
                    Structures.Add(t.Name, t);
                }
            }
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

        internal void SkipChildren(SyntaxNode node)
        {
            IEnumerable<SyntaxNode> children = node.ChildNodes();
            foreach (SyntaxNode n in children)
                CompletedNodes.Add(node);
        }

        internal void Skip(SyntaxNode node)
        {
            CompletedNodes.Add(node);
        }

        internal void SkipSelfAndChildren(SyntaxNode node)
        {
            CompletedNodes.Add(node);
            SkipChildren(node);
        }

        public override string ToString()
        {
            return $"{Name} - {base.ToString()}";
        }
    }
}
