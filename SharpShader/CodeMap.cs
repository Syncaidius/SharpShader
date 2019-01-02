using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// Contains important information for translating C# code to shader language.
    /// </summary>
    internal class CodeMap
    {
        internal Dictionary<string, EntryPoint> EntryPoints = new Dictionary<string, EntryPoint>();

        internal Dictionary<string, FieldDeclarationSyntax> MainFields = new Dictionary<string, FieldDeclarationSyntax>();

        internal Dictionary<string, StructDeclarationSyntax> Structures = new Dictionary<string, StructDeclarationSyntax>();

        internal Dictionary<string, RegisteredObject> ConstantBuffers = new Dictionary<string, RegisteredObject>();

        internal Dictionary<string, RegisteredObject> Textures = new Dictionary<string, RegisteredObject>();

        internal Dictionary<string, RegisteredObject> Samplers = new Dictionary<string, RegisteredObject>();

        internal Dictionary<string, RegisteredObject> UAVs = new Dictionary<string, RegisteredObject>();

        internal Dictionary<string, Type> TranslatedTypes = new Dictionary<string, Type>();

        /// <summary>
        /// A dictionary of properties which have been translated into get/set methods, with their original name as a key.
        /// </summary>
        internal Dictionary<string, PropertyTranslation> TranslatedProperties = new Dictionary<string, PropertyTranslation>();

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
                for(int i = 0; i < ShaderReflection.SupportedNamespaces.Length; i++)
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
