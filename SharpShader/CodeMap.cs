﻿using Microsoft.CodeAnalysis.CSharp.Syntax;
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

        internal Dictionary<string, RegisteredObject> ConstantBuffers = new Dictionary<string, RegisteredObject>();

        internal Dictionary<string, RegisteredObject> Textures = new Dictionary<string, RegisteredObject>();

        internal Dictionary<string, RegisteredObject> Samplers = new Dictionary<string, RegisteredObject>();

        internal Dictionary<string, RegisteredObject> UAVs = new Dictionary<string, RegisteredObject>();

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
            Components.Add(new ShaderComponent(ep.MethodSyntax, ShaderComponentType.EntryPoint));
        }

        internal void AddMemberAccess(MemberAccessExpressionSyntax syntax)
        {
            Components.Add(new ShaderComponent(syntax, ShaderComponentType.MemberAccess));
        }

        internal void AddField(FieldDeclarationSyntax syntax)
        {
            string name = syntax.Declaration.Variables[0].Identifier.ToString();
            Fields.Add(name, syntax);
            Components.Add(new ShaderComponent(syntax, ShaderComponentType.CSharpField));
        }

        internal bool IsStructInstance(VariableDeclarationSyntax syntax)
        {
            return Fields.ContainsKey(syntax.Variables[0].Identifier.ToString());
        }

        internal void AddStructure(StructDeclarationSyntax syntax)
        {
            Structures.Add(syntax);
            Components.Add(new ShaderComponent(syntax, ShaderComponentType.Struct));
        }

        internal void AddConstantBuffer(StructDeclarationSyntax syntax, AttributeSyntax regAttribute)
        {
            string name = syntax.Identifier.ToString();

            ConstantBuffers.Add(name, new RegisteredObject(regAttribute));
            Components.Add(new ShaderComponent(syntax, ShaderComponentType.ConstantBuffer));
        }

        internal void AddSampler(VariableDeclaratorSyntax syntax, AttributeSyntax attSyntax)
        {
            string name = syntax.ToString();
            Samplers.Add(name, new RegisteredObject(attSyntax));
            Components.Add(new ShaderComponent(syntax, ShaderComponentType.Sampler));
        }
    }
}
