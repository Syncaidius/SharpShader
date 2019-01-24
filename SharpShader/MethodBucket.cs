using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class MethodBucket
    {
        class MethodEntry
        {
            internal ParameterInfo[] Parameters;

            internal MethodInfo Info;
        }

        List<MethodEntry> _methods;

        internal MethodBucket()
        {
            _methods = new List<MethodEntry>();
        }

        internal void Add(MethodInfo info)
        {
            _methods.Add(new MethodEntry()
            {
                Info = info,
                Parameters = info.GetParameters(),
            });
        }

        internal MethodInfo Find(ShaderContext sc, MethodDeclarationSyntax syntax)
        {
            foreach(MethodEntry entry in _methods)
            {
                if (entry.Parameters.Length != syntax.ParameterList.Parameters.Count)
                    continue;

                bool success = true;
                for (int i = 0; i < entry.Parameters.Length; i++)
                {
                    ParameterSyntax ps = syntax.ParameterList.Parameters[i];
                    Type pType = ReflectionHelper.ResolveType(sc, ps.Type.ToString(), ps.Modifiers);
                    if(pType != entry.Parameters[i].ParameterType || ps.Identifier.ValueText != entry.Parameters[i].Name)
                    {
                        success = false;
                        break;
                    }
                }

                if (success)
                    return entry.Info;
            }

            return null;
        }
    }
}
