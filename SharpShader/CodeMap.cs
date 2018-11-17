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

        internal Dictionary<string, VariableDeclarationSyntax> Variables = new Dictionary<string, VariableDeclarationSyntax>();

        internal Dictionary<string, List<InvocationExpressionSyntax>> MethodCalls = new Dictionary<string, List<InvocationExpressionSyntax>>();

        internal List<ShaderStructure> Structures = new List<ShaderStructure>();

        internal Dictionary<string, ConstantBufferStructure> ConstantBuffers = new Dictionary<string, ConstantBufferStructure>();

        internal void AddEntryPoint(EntryPoint ep)
        {
            EntryPoints.Add(ep);
        }

        internal void AddVariable(VariableDeclarationSyntax syntax)
        {
            Variables.Add(syntax.Variables[0].Identifier.ToString(), syntax);
        }

        internal void AddMethod(MethodDeclarationSyntax method)
        {
            Methods.Add(method.Identifier.ToString(), method);
        }

        internal void AddMethodCall(InvocationExpressionSyntax call)
        {
            List<InvocationExpressionSyntax> invocationList = null;
            string expression = call.Expression.ToString();
            if (!MethodCalls.TryGetValue(expression, out invocationList))
            {
                invocationList = new List<InvocationExpressionSyntax>();
                MethodCalls.Add(expression, invocationList);
            }

            invocationList.Add(call);
        }

        internal void AddStructure(ShaderStructure structure)
        {
            Structures.Add(structure);
        }

        internal void AddConstantBuffer(ConstantBufferStructure cb)
        {
            ConstantBuffers.Add(cb.Name, cb);
        }
    }
}
