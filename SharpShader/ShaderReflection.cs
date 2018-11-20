﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    public class ShaderReflection
    {
        static Dictionary<string, List<MethodInfo>> _intrinsicMethods;

        static ShaderReflection()
        {
            _intrinsicMethods = new Dictionary<string, List<MethodInfo>>();
            Type t = typeof(CSharpShader);
            MethodInfo[] methods = t.GetMethods();
            foreach(MethodInfo mi in methods)
            {
                if (mi.GetCustomAttribute<ShaderIntrinsicAttribute>() != null)
                {
                    List<MethodInfo> methodList = null;
                    if(!_intrinsicMethods.TryGetValue(mi.Name, out methodList))
                    {
                        methodList = new List<MethodInfo>();
                        _intrinsicMethods.Add(mi.Name, methodList);
                    }

                    methodList.Add(mi);
                }
            }
        }

        internal static bool IsIntrinsicFunction(string name)
        {
            return false;
        }

        internal static bool HasAttribute<T>(SyntaxList<AttributeListSyntax> attLists) where T : SharpShaderAttribute
        {
            foreach (AttributeListSyntax list in attLists)
            {
                foreach (AttributeSyntax attSyntax in list.Attributes)
                {
                    string name = attSyntax.Name.ToString();
                    if (!name.EndsWith("Attribute"))
                        name += "Attribute";

                    Type attType = Type.GetType($"SharpShader.{name}");
                    if (attType != null)
                    {
                        if (attType == typeof(T))
                            return true;
                    }
                }
            }

            return false;
        }

        internal static AttributeSyntax GetAttribute<T>(SyntaxList<AttributeListSyntax> attLists) where T : SharpShaderAttribute
        {
            foreach (AttributeListSyntax list in attLists)
            {
                foreach (AttributeSyntax attSyntax in list.Attributes)
                {
                    string name = attSyntax.Name.ToString();
                    if (!name.EndsWith("Attribute"))
                        name += "Attribute";

                    Type attType = Type.GetType($"SharpShader.{name}");
                    if (attType != null)
                    {
                        if (attType == typeof(T))
                            return attSyntax;
                    }
                }
            }

            return null;
        }

        internal static void IterateAttributes(SyntaxList<AttributeListSyntax> attLists, Action<Type> callback)
        {
            foreach (AttributeListSyntax list in attLists)
            {
                foreach (AttributeSyntax attSyntax in list.Attributes)
                {
                    string name = attSyntax.Name.ToString();
                    if (!name.EndsWith("Attribute"))
                        name += "Attribute";

                    Type attType = Type.GetType($"SharpShader.{name}");
                    if (attType != null)
                        callback(attType);
                }
            }
        }
    }
}
