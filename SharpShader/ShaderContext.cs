using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    [Serializable]
    internal class ShaderContext
    {
        [field: NonSerialized]
        internal SyntaxNode Root { get; private set; }

        [field: NonSerialized]
        internal SyntaxTree Tree { get; private set; }

        [NonSerialized]
        internal Dictionary<string, EntryPoint> EntryPoints = new Dictionary<string, EntryPoint>();

        [NonSerialized]
        internal Dictionary<string, FieldDeclarationSyntax> MainFields = new Dictionary<string, FieldDeclarationSyntax>();

        [NonSerialized]
        internal Dictionary<string, StructDeclarationSyntax> Structures = new Dictionary<string, StructDeclarationSyntax>();

        [NonSerialized]
        internal Dictionary<string, RegisteredObject> ConstantBuffers = new Dictionary<string, RegisteredObject>();

        [NonSerialized]
        internal Dictionary<string, RegisteredObject> Textures = new Dictionary<string, RegisteredObject>();

        [NonSerialized]
        internal Dictionary<string, RegisteredObject> Samplers = new Dictionary<string, RegisteredObject>();

        [NonSerialized]
        internal Dictionary<string, RegisteredObject> UAVs = new Dictionary<string, RegisteredObject>();

        [NonSerialized]
        internal Dictionary<string, Type> TranslatedTypes = new Dictionary<string, Type>();


        [NonSerialized]
        /// <summary>
        /// A dictionary of properties which have been translated into get/set methods, with their original name as a key.
        /// </summary>
        internal Dictionary<string, PropertyTranslation> TranslatedProperties = new Dictionary<string, PropertyTranslation>();

        [field: NonSerialized]
        internal ConversionContext Parent { get; }

        internal string Name { get; }
        internal string SanitizedName { get; }

        StringBuilder _source;
        bool _treeDirty = true;

        internal ShaderContext(ConversionContext parent, string name, ref string source)
        {
            Parent = parent;
            Name = name;
            _source = new StringBuilder(source);
            SanitizedName = TranslationHelper.SanitizeString(name);
            RegenerateTree();
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

        internal void RegenerateTree()
        {
            if (_treeDirty)
            {
                Tree = CSharpSyntaxTree.ParseText(_source.ToString(), Parent.ParseOptions);
                Root = Tree.GetRoot();
                _treeDirty = false;
            }
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
            MainFields.Clear();
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

        internal void AddEntryPoint(EntryPoint ep)
        {
            string name = ep.MethodSyntax.Identifier.ToString();
            EntryPoints.Add(name, ep);
        }

        internal void AddField(FieldDeclarationSyntax syntax, bool isChild = false)
        {
            string name = syntax.Declaration.Variables[0].Identifier.ToString();

            if (!isChild)
                MainFields.Add(name, syntax);
        }

        internal void AddProperty(string propertyName, PropertyTranslation translation)
        {
            TranslatedProperties.Add(propertyName, translation);
        }

        internal bool IsStructInstance(VariableDeclarationSyntax syntax)
        {
            return MainFields.ContainsKey(syntax.Variables[0].Identifier.ToString());
        }

        internal void AddStructure(StructDeclarationSyntax syntax)
        {
            Structures.Add(syntax.Identifier.ToString(), syntax);
        }

        internal void AddConstantBuffer(StructDeclarationSyntax syntax, AttributeSyntax regAttribute)
        {
            string name = syntax.Identifier.ToString();

            ConstantBuffers.Add(name, new RegisteredObject(regAttribute));
        }

        internal void AddSampler(VariableDeclaratorSyntax syntax, AttributeSyntax attSyntax)
        {
            string name = syntax.ToString();
            Samplers.Add(name, new RegisteredObject(attSyntax));
        }
    }
}
