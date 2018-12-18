using Microsoft.CodeAnalysis;
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
        /// <summary>
        /// The name of the Sharp Shader namespace.
        /// </summary>
        public const string NAMESPACE = "SharpShader";

        /// <summary>
        /// The full namespace prefix that is usually found attached to the start of types in declarations.
        /// </summary>
        public const string NAMESPACE_PREFIX = NAMESPACE + ".";

        class LanguageMethodInfo
        {
            public string NativeName;

            public List<MethodInfo> Methods = new List<MethodInfo>();
        }

        class LanguageInfo
        {
            public Dictionary<string, LanguageMethodInfo> Intrinsics = new Dictionary<string, LanguageMethodInfo>();
        }

        static Dictionary<ShaderLanguage, LanguageInfo> _intrinsicMethods;
        static HashSet<Type> _registerTypes;

        static ShaderReflection()
        {
            _intrinsicMethods = new Dictionary<ShaderLanguage, LanguageInfo>();
            _registerTypes = new HashSet<Type>();
            Type t = typeof(CSharpShader);

            // Find all of the types that are compatible with RegisteredTypeAttribute.
            IEnumerable<Type> allTypes = t.Assembly.GetTypes();
            foreach(Type type in allTypes)
            {
                RegisteredTypeAttribute rta = type.GetCustomAttribute<RegisteredTypeAttribute>();
                if (rta != null)
                    _registerTypes.Add(type);
            }

            // Run through all intrinsic methods in CSharpShader class.
            MethodInfo[] methods = t.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach(MethodInfo mi in methods)
            {
                IEnumerable<ShaderIntrinsicAttribute> attributes = mi.GetCustomAttributes<ShaderIntrinsicAttribute>();
                foreach(ShaderIntrinsicAttribute att in attributes)
                {
                    LanguageInfo info = null;
                    if (!_intrinsicMethods.TryGetValue(att.Language, out info))
                    {
                        info = new LanguageInfo();
                        _intrinsicMethods.Add(att.Language, info);
                    }

                    LanguageMethodInfo methodInfo = null;
                    if (!info.Intrinsics.TryGetValue(mi.Name, out methodInfo))
                    {
                        methodInfo = new LanguageMethodInfo();
                        methodInfo.NativeName = att.NativeName;
                        info.Intrinsics.Add(mi.Name, methodInfo);
                    }

                    methodInfo.Methods.Add(mi);
                }
            }
        }

        internal static bool IsRegisteredType(Type type)
        {
            return _registerTypes.Contains(type);
        }

        internal static bool IsIntrinsicFunction(ShaderContext context, string cSharpName)
        {
            if(_intrinsicMethods.TryGetValue(context.Parent.Foundation.Language, out LanguageInfo info))
                return info.Intrinsics.ContainsKey(cSharpName);
            else
                return false;
        }

        internal static string GetIntrinsicTranslation(ShaderContext context, string cSharpName)
        {
            if (_intrinsicMethods.TryGetValue(context.Parent.Foundation.Language, out LanguageInfo info))
            {
                if(info.Intrinsics.TryGetValue(cSharpName, out LanguageMethodInfo methodInfo))
                    return methodInfo.NativeName;
            }

            return null;
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

                    Type attType = Type.GetType($"{NAMESPACE_PREFIX}{name}");
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

                    Type attType = Type.GetType($"{NAMESPACE_PREFIX}{name}");
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

                    Type attType = Type.GetType($"{NAMESPACE_PREFIX}{name}");
                    if (attType != null)
                        callback(attType);
                }
            }
        }
    }
}
