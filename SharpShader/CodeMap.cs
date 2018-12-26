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

        internal List<StructDeclarationSyntax> Structures = new List<StructDeclarationSyntax>();

        internal List<ShaderElement> Components = new List<ShaderElement>();

        internal Dictionary<string, RegisteredObject> ConstantBuffers = new Dictionary<string, RegisteredObject>();

        internal Dictionary<string, RegisteredObject> Textures = new Dictionary<string, RegisteredObject>();

        internal Dictionary<string, RegisteredObject> Samplers = new Dictionary<string, RegisteredObject>();

        internal Dictionary<string, RegisteredObject> UAVs = new Dictionary<string, RegisteredObject>();

        internal Dictionary<string, Type> TranslatedTypes = new Dictionary<string, Type>();

        internal void Clear()
        {
            EntryPoints.Clear();
            MainFields.Clear();
            Structures.Clear();
            Components.Clear();
            ConstantBuffers.Clear();
            UAVs.Clear();
        }

        /// <summary>
        /// Attempts to retrieve the C# type of a translated shader type (by name). If it fails, the type name will be tested against supported namespaces. </para>
        /// Null is returned if the type cannot be resolved.
        /// </summary>
        /// <param name="translatedName">The name of the translated shader type.</param>
        /// <returns></returns>
        internal Type GetOriginalType(string translatedName)
        {
            Type originalType = null;
            if (!TranslatedTypes.TryGetValue(translatedName, out originalType))
            {
                for(int i = 0; i < ShaderReflection.SupportedNamespaces.Length; i++)
                {
                    string ns = ShaderReflection.SupportedNamespaces[i];

                    string fullName = translatedName;
                    if (!fullName.StartsWith($"{ns}."))
                        fullName = $"{ns}.{fullName}";

                    originalType = Type.GetType(translatedName);
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
            Components.Add(new ShaderElement(ep.MethodSyntax, ShaderComponentType.EntryPoint));
        }

        internal void AddMemberAccess(MemberAccessExpressionSyntax syntax)
        {
            Components.Add(new ShaderElement(syntax, ShaderComponentType.MemberAccess));
        }

        internal void AddField(FieldDeclarationSyntax syntax, bool isChild = false)
        {
            string name = syntax.Declaration.Variables[0].Identifier.ToString();

            if (!isChild)
                MainFields.Add(name, syntax);

            Components.Add(new ShaderElement(syntax, isChild ? ShaderComponentType.ChildField : ShaderComponentType.MainField));
        }

        internal bool IsStructInstance(VariableDeclarationSyntax syntax)
        {
            return MainFields.ContainsKey(syntax.Variables[0].Identifier.ToString());
        }

        internal void AddStructure(StructDeclarationSyntax syntax)
        {
            Structures.Add(syntax);
            Components.Add(new ShaderElement(syntax, ShaderComponentType.Struct));
        }

        internal void AddConstantBuffer(StructDeclarationSyntax syntax, AttributeSyntax regAttribute)
        {
            string name = syntax.Identifier.ToString();

            ConstantBuffers.Add(name, new RegisteredObject(regAttribute));
            Components.Add(new ShaderElement(syntax, ShaderComponentType.ConstantBuffer));
        }

        internal void AddSampler(VariableDeclaratorSyntax syntax, AttributeSyntax attSyntax)
        {
            string name = syntax.ToString();
            Samplers.Add(name, new RegisteredObject(attSyntax));
            Components.Add(new ShaderElement(syntax, ShaderComponentType.Sampler));
        }
    }
}
