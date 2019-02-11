using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class MethodBucket : IPoolable
    {
        Dictionary<MethodInfo, ParameterInfo[]> _methods = new Dictionary<MethodInfo, ParameterInfo[]>();

        internal void Add(MethodInfo info)
        {
            _methods.Add(info, info.GetParameters());
        }

        internal (ParameterInfo info, int index) GetParameterInfo(MethodInfo method, string parameterName)
        {
            if(_methods.TryGetValue(method, out ParameterInfo[] parameters))
            {
                for(int i = 0; i < parameters.Length; i++)
                {
                    if (parameters[i].Name == parameterName)
                        return (parameters[i], i);
                }
            }

            return (null, 0);
        }

        internal MethodInfo Find(ShaderTranslationContext sc, MethodDeclarationSyntax syntax)
        {
            foreach(KeyValuePair<MethodInfo, ParameterInfo[]> p in _methods)
            {
                if (p.Value.Length != syntax.ParameterList.Parameters.Count)
                    continue;

                bool success = true;
                for (int i = 0; i < p.Value.Length; i++)
                {
                    ParameterSyntax ps = syntax.ParameterList.Parameters[i];
                    Type pType = ShaderType.Resolve(sc, ps.Type.ToString(), ps.Modifiers);
                    if(pType != p.Value[i].ParameterType || ps.Identifier.ValueText != p.Value[i].Name)
                    {
                        success = false;
                        break;
                    }
                }

                if (success)
                    return p.Key;
            }

            return null;
        }

        public void Clear()
        {
            _methods.Clear();
        }
    }
}
