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
        internal List<EntryPoint> EntryPoints = new List<EntryPoint>();

        internal Dictionary<string, MethodDeclarationSyntax> Methods = new Dictionary<string, MethodDeclarationSyntax>();

        internal Dictionary<string, VariableDeclarationSyntax> Fields = new Dictionary<string, VariableDeclarationSyntax>();

        internal List<StructDeclarationSyntax> Structures = new List<StructDeclarationSyntax>();

        internal List<ShaderComponent> Components = new List<ShaderComponent>();

        internal Dictionary<string, StructDeclarationSyntax> ConstantBuffers = new Dictionary<string, StructDeclarationSyntax>();

        internal void AddEntryPoint(EntryPoint ep)
        {
            EntryPoints.Add(ep);
        }

        internal void AddField(VariableDeclarationSyntax syntax)
        {
            Fields.Add(syntax.Variables[0].Identifier.ToString(), syntax);
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
