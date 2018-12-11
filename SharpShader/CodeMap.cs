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

        internal Dictionary<string, MethodDeclarationSyntax> Methods = new Dictionary<string, MethodDeclarationSyntax>();

        internal Dictionary<string, FieldDeclarationSyntax> Fields = new Dictionary<string, FieldDeclarationSyntax>();

        internal List<StructDeclarationSyntax> Structures = new List<StructDeclarationSyntax>();

        internal List<ShaderComponent> Components = new List<ShaderComponent>();

        internal Dictionary<string, StructDeclarationSyntax> ConstantBuffers = new Dictionary<string, StructDeclarationSyntax>();

        internal Dictionary<string, FieldDeclarationSyntax> Textures = new Dictionary<string, FieldDeclarationSyntax>();

        internal Dictionary<string, FieldDeclarationSyntax> TextureSampler = new Dictionary<string, FieldDeclarationSyntax>();

        internal void Clear()
        {
            EntryPoints.Clear();
            Methods.Clear();
            Fields.Clear();
            Structures.Clear();
            Components.Clear();
            ConstantBuffers.Clear();
        }

        internal void AddEntryPoint(EntryPoint ep)
        {
            string name = ep.MethodSyntax.Identifier.ToString();
            EntryPoints.Add(name, ep);
            Components.Add(new ShaderComponent()
            {
                Node = ep.MethodSyntax,
                Type = ShaderComponentType.EntryPoint,
                Name = name,
            });
        }

        internal void AddMemberAccess(MemberAccessExpressionSyntax syntax)
        {
            Components.Add(new ShaderComponent()
            {
                Node = syntax,
                Type = ShaderComponentType.MemberAccess,
                Name = syntax.Expression.ToString(),
            });
        }

        internal void AddField(FieldDeclarationSyntax syntax)
        {
            string name = syntax.Declaration.Variables[0].Identifier.ToString();
            Fields.Add(name, syntax);
            Components.Add(new ShaderComponent()
            {
                Node = syntax,
                Type = ShaderComponentType.CSharpField,
                Name = name,
            });
        }

        internal bool IsStructInstance(VariableDeclarationSyntax syntax)
        {
            return Fields.ContainsKey(syntax.Variables[0].Identifier.ToString());
        }

        internal void AddMethod(MethodDeclarationSyntax method)
        {
            Methods.Add(method.Identifier.ToString(), method);
        }

        internal void AddStructure(StructDeclarationSyntax syntax)
        {
            Structures.Add(syntax);
            Components.Add(new ShaderComponent()
            {
                Node = syntax,
                Type = ShaderComponentType.Struct,
                Name = syntax.Identifier.ToString(),
            });
        }

        internal void AddConstantBuffer(StructDeclarationSyntax syntax)
        {
            string name = syntax.Identifier.ToString();
            ConstantBuffers.Add(name, syntax);
            Components.Add(new ShaderComponent()
            {
                Name = name,
                Node = syntax,
                Type = ShaderComponentType.ConstantBuffer,
            });
        }
    }
}
