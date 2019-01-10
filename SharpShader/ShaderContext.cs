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

        [ NonSerialized]
        internal readonly SyntaxNode RootNode;

        [field: NonSerialized]
        internal Type ShaderType { get; }

        [NonSerialized]
        internal readonly ConversionContext Parent;

        [NonSerialized]
        internal readonly Dictionary<string, EntryPoint> EntryPoints;

        [NonSerialized]
        internal readonly Dictionary<string, FieldInfo> Fields;

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

        [NonSerialized]
        internal readonly Dictionary<string, Type> TranslatedTypes;


        [NonSerialized]
        /// <summary>
        /// A dictionary of properties which have been translated into get/set methods, with their original name as a key.
        /// </summary>
        internal Dictionary<string, PropertyTranslation> TranslatedProperties = new Dictionary<string, PropertyTranslation>();

        internal string Name { get; }

        StringBuilder _source;

        [NonSerialized]
        bool _treeDirty = true;

        internal ShaderContext(ConversionContext parent, ClassDeclarationSyntax syntax, Type shaderType)
        {
            Parent = parent;
            Name = syntax.Identifier.ValueText;
            ShaderType = shaderType;
            SyntaxTree tree = CSharpSyntaxTree.ParseText(syntax.ToString(), Parent.ParseOptions);
            RootNode = tree.GetRoot();
            _source = new StringBuilder(RootNode.ToString());

            EntryPoints = new Dictionary<string, EntryPoint>();
            Fields = new Dictionary<string, FieldInfo>();
            Structures = new Dictionary<string, Type>();
            ConstantBuffers = new Dictionary<string, RegisteredMember<Type>>();
            Textures = new Dictionary<string, RegisteredMember<FieldInfo>>();
            Samplers = new Dictionary<string, RegisteredMember<FieldInfo>>();
            UAVs = new Dictionary<string, RegisteredMember<FieldInfo>>();
            TranslatedTypes = new Dictionary<string, Type>();

            BindingFlags bFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;
            PopulateMethodInfo(bFlags);
            PopulateFieldInfo(bFlags);
            PopulateStructInfo(bFlags);
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
                    if (eps.Count() > 0)
                        Parent.AddMessage($"Method '{mi.Name}' has multiple entry-point attributes. Using '{epAttribute.GetType().Name}'.", 0, 0);

                    EntryPoints.Add(mi.Name, new EntryPoint(mi, epAttribute, epAttribute.EntryType));
                }
            }
        }

        private void PopulateFieldInfo(BindingFlags bFlags)
        {
            FieldInfo[] fInfo = ShaderType.GetFields(bFlags);
            foreach (FieldInfo fi in fInfo)
            {
                // TODO If the field type is that of a constant buffer struct, check if the language allows instance-based access to constant buffer members.
                //      If not, skip the field. If it's not present in the field dictionary when a field node processor hits it, it should be removed from the source code.

                Fields.Add(fi.Name, fi);

                RegisterAttribute[] regAttributes = fi.GetCustomAttributes<RegisterAttribute>().ToArray();
                RegisteredTypeAttribute regTypeAttribute = fi.GetCustomAttribute<RegisteredTypeAttribute>();

                if (regTypeAttribute != null)
                {
                    UnorderedAccessAttribute uav = fi.GetCustomAttribute<UnorderedAccessAttribute>();
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
            }
        }

        private void PopulateStructInfo(BindingFlags bFlags)
        {
            Type[] nestedTypes = ShaderType.GetNestedTypes();
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
            AddMessage(text, span.StartLinePosition.Line, span.StartLinePosition.Character);
        }

        internal void AddMessage(string text, int lineNumber, int linePos, ConversionMessageType type = ConversionMessageType.Error)
        {
            Parent.AddMessage($"{Name}: {text}", lineNumber, linePos, type);
        }

        internal void ReplaceSource(string original, string replacement, int startIndex, int length)
        {
            if (replacement.Length == 0)
                return;

            _source.Replace(original, replacement, startIndex, length);
            _treeDirty = true;
        }

        internal void ReplaceSource(SyntaxNode syntax, string replacement)
        {
            if (string.IsNullOrWhiteSpace(replacement))
                return;

            _source.Replace(syntax.ToString(), replacement, syntax.SpanStart, syntax.Span.Length);
            _treeDirty = true;
        }

        internal void RemoveSource(int startIndex, int length)
        {
            _source.Remove(startIndex, length);
        }

        internal void RemoveSource(SyntaxNode syntax)
        {
            _source.Remove(syntax.SpanStart, syntax.Span.Length);
        }

        /// <summary>Returns the current state of the translated source code for the current <see cref="ShaderContext"/>.</summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _source.ToString();
        }

        internal void Clear()
        {
            EntryPoints.Clear();
            Fields.Clear();
            Structures.Clear();
            ConstantBuffers.Clear();
            UAVs.Clear();
            TranslatedTypes.Clear();
            TranslatedProperties.Clear();
        }

        /// <summary>
        /// Attempts to retrieve the C# type of a translated shader type (by name). If it fails, the type name will be tested against supported namespaces. </para>
        /// Null is returned if the type cannot be resolved.
        /// </summary>
        /// <param name="translatedName">The name of the translated shader type.</param>
        /// <returns></returns>
        internal Type GetOriginalType(TypeSyntax typeSyntax)
        {
            string translatedName = typeSyntax.ToString();
            Type originalType = null;
            if (!TranslatedTypes.TryGetValue(translatedName, out originalType))
            {
                for (int i = 0; i < ShaderReflection.SupportedNamespaces.Length; i++)
                {
                    string ns = ShaderReflection.SupportedNamespaces[i];

                    string fullName = translatedName;
                    if (!fullName.StartsWith($"{ns}."))
                        fullName = $"{ns}.{fullName}";

                    originalType = Type.GetType(fullName);
                    if (originalType != null)
                        break;
                }
            }

            return originalType;
        }
    }
}
