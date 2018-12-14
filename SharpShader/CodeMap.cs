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

        internal Dictionary<string, FieldDeclarationSyntax> Fields = new Dictionary<string, FieldDeclarationSyntax>();

        internal List<StructDeclarationSyntax> Structures = new List<StructDeclarationSyntax>();

        internal List<ShaderComponent> Components = new List<ShaderComponent>();

        internal List<string> ConstantBuffers = new List<string>();

        internal List<string> Textures = new List<string>();

        internal List<string> Samplers = new List<string>();

        internal List<string> UAVs = new List<string>();

        internal void Clear()
        {
            EntryPoints.Clear();
            Fields.Clear();
            Structures.Clear();
            Components.Clear();
            ConstantBuffers.Clear();
            UAVs.Clear();
        }

        internal void AddEntryPoint(EntryPoint ep)
        {
            string name = ep.MethodSyntax.Identifier.ToString();
            EntryPoints.Add(name, ep);
            Components.Add(new ShaderComponent()
            {
                Node = ep.MethodSyntax,
                Type = ShaderComponentType.EntryPoint,
            });
        }

        internal void AddMemberAccess(MemberAccessExpressionSyntax syntax)
        {
            Components.Add(new ShaderComponent()
            {
                Node = syntax,
                Type = ShaderComponentType.MemberAccess,
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
            });
        }

        internal bool IsStructInstance(VariableDeclarationSyntax syntax)
        {
            return Fields.ContainsKey(syntax.Variables[0].Identifier.ToString());
        }

        internal void AddStructure(StructDeclarationSyntax syntax)
        {
            Structures.Add(syntax);
            Components.Add(new ShaderComponent()
            {
                Node = syntax,
                Type = ShaderComponentType.Struct,
            });
        }

        internal void AddConstantBuffer(StructDeclarationSyntax syntax)
        {
            string name = syntax.Identifier.ToString();
            ConstantBuffers.Add(name);
            Components.Add(new ShaderComponent()
            {
                Node = syntax,
                Type = ShaderComponentType.ConstantBuffer,
            });
        }

        internal void AddSampler(VariableDeclarationSyntax syntax)
        {
            foreach (VariableDeclaratorSyntax variable in syntax.Variables)
            {
                string name = variable.ToString();
                ConstantBuffers.Add(name);
            }

            Components.Add(new ShaderComponent()
            {
                Node = syntax,
                Type = ShaderComponentType.Sampler,
            });
        }
    }
}
