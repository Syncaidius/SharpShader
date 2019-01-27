using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SharpShader
{
    internal static class ReflectionHelper
    {
        /// <summary>
        /// The name of the Sharp Shader namespace.
        /// </summary>
        internal const string NAMESPACE = "SharpShader";

        static readonly char[] _namespaceDelimiters = { '.', ',' };
        static readonly char[] _genericTypeDelimiter = { ',' };
        internal static readonly string[] IntrinsicPrefixes = { "Matrix", "Vector", "Int", "Double", "UInt", "Bool" };
        internal static readonly string[] PointerModifiers = { "in", "out", "ref" };

        internal static readonly Dictionary<string, Type> _baseTypeAliases = new Dictionary<string, Type>()
        {
            ["long"] = typeof(long),
            ["ulong"] = typeof(ulong),
            ["int"] = typeof(int),
            ["uint"] = typeof(uint),
            ["short"] = typeof(short),
            ["ushort"] = typeof(ushort),
            ["byte"] = typeof(byte),
            ["sbyte"] = typeof(sbyte),
            ["float"] = typeof(float),
            ["double"] = typeof(double),
            ["decimal"] = typeof(decimal),
            ["bool"] = typeof(bool),
        };

        internal static readonly string[] SupportedNamespaces = { NAMESPACE, "System" };
        internal static readonly AssemblyName[] SupportedAssemblies = {
            typeof(CSharpShader).Assembly.GetName(),
            typeof(float).Assembly.GetName(),
        };

        class LanguageMethodInfo
        {
            public string NativeName;

            public List<MethodInfo> Methods = new List<MethodInfo>();
        }

        class LanguageInfo
        {
            public Dictionary<string, LanguageMethodInfo> Intrinsics = new Dictionary<string, LanguageMethodInfo>();
        }

        static Dictionary<OutputLanguage, LanguageInfo> _intrinsicMethods;
        static HashSet<Type> _registerTypes;

        static ReflectionHelper()
        {
            _intrinsicMethods = new Dictionary<OutputLanguage, LanguageInfo>();
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

        internal static IEnumerable<Type> FindOfType<T>() where T : class
        {
            Type pType = typeof(T);
            Assembly assembly = pType.Assembly;
            return assembly.GetTypes().Where(t => t.IsSubclassOf(pType) && !t.IsAbstract);
        }

        internal static bool IsIntrinsicFunction(ShaderContext context, string cSharpName)
        {
            if(_intrinsicMethods.TryGetValue(context.Parent.Language.Language, out LanguageInfo info))
                return info.Intrinsics.ContainsKey(cSharpName);
            else
                return false;
        }

        internal static string GetIntrinsicTranslation(ShaderContext context, string cSharpName)
        {
            if (_intrinsicMethods.TryGetValue(context.Parent.Language.Language, out LanguageInfo info))
            {
                if(info.Intrinsics.TryGetValue(cSharpName, out LanguageMethodInfo methodInfo))
                    return methodInfo.NativeName;
            }

            return cSharpName;
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

                    Type attType = Type.GetType($"{NAMESPACE}.{name}");
                    if (attType != null)
                    {
                        if (attType == typeof(T))
                            return attSyntax;
                    }
                }
            }

            return null;
        }

        internal static Type ResolveType(ShaderContext sc, string typeName, SyntaxTokenList modifiers = default)
        {
            Type t = null;

            foreach(SyntaxToken m in modifiers)
            {
                for (int i = 0; i < PointerModifiers.Length; i++)
                {
                    if (m.ValueText == PointerModifiers[i])
                    {
                        typeName += "&";
                        goto PostModifierCheck; // Yes, it's a goto! It's also a nested loop ;)
                    }
                }
            }

            PostModifierCheck:
            if (!_baseTypeAliases.TryGetValue(typeName, out t))
            {
                string[] parts = typeName.Split(_namespaceDelimiters, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length > 0)
                {
                    for (int i = 0; i < SupportedNamespaces.Length; i++)
                    {
                        t = Type.GetType($"{SupportedNamespaces[i]}.{parts[parts.Length - 1]}");
                        if (t != null)
                            return t;
                    }
                }
            }

            if (t == null)
            {
                Type sType = sc.ShaderType;
                t = sc.Parent.Reflection.Assembly.GetType($"{sc.ShaderType.Namespace}.{sc.ShaderType.Name}+{typeName}");

                if (t == null)
                    t = ResolveGeneric(sc, typeName);
            }

            return t;
        }

        private static Type ResolveGeneric(ShaderContext sc, string typeName)
        {
            int bIndex = typeName.IndexOf('<');
            Type t = null;
            if(bIndex > -1)
            {
                // TODO garbage generation from arrays?
                string[] inners = typeName.Substring(bIndex, typeName.Length - bIndex).Split(_genericTypeDelimiter, StringSplitOptions.None);
                string outer = typeName.Substring(0, bIndex);
                Type[] innerTypes = new Type[inners.Length];

                for(int i = 0; i < inners.Length; i++)
                    innerTypes[i] = ResolveType(sc, inners[i].Substring(1, inners[i].Length - 2));


                string outerTypeName = $"{outer}`{inners.Length}";
                Type outerType = ResolveType(sc, outerTypeName);
                t = outerType?.MakeGenericType(innerTypes);
            }

            return t;
        }

        internal static bool ParseEnum<T>(string input, out T value) where T : struct
        {
            value = default;
            Type t = typeof(T);
            if (!t.IsEnum)
                return false;

            string enumName = t.Name;
            if (input.StartsWith($"{enumName}."))
                input = input.Substring(enumName.Length + 1);

            return Enum.TryParse<T>(input, out value);
        }

        internal static (string translation, Type originalType, bool isArray) TranslateType(ShaderContext sc, string typeName)
        {
            Type type = ResolveType(sc, typeName);
            if (type != null)
            {
                Type elementType = type.GetElementType();
                ShaderLanguage.Keyword translation = sc.Parent.Language.GetKeyword(type);
                if (translation != null)
                {
                    return (translation.NativeText, type, type.IsArray);
                }
                else // Attempt to find any interfaces on the type which can be translated instead.
                {
                    Type[] iTypes;
                    if (elementType != null)
                        iTypes = elementType.GetInterfaces();
                    else
                        iTypes = type.GetInterfaces();


                    foreach (Type implemented in iTypes)
                    {
                        translation = sc.Parent.Language.GetKeyword(implemented);
                        if (translation != null)
                        {
                            string replacement = elementType?.Name ?? type.Name;

                            // TODO Does this need optimizing? Benchmark before changing.
                            for (int i = 0; i < ReflectionHelper.IntrinsicPrefixes.Length; i++)
                                replacement = replacement.Replace(ReflectionHelper.IntrinsicPrefixes[i], "");

                            if (translation.UniformSizeIsSingular)
                            {
                                if (typeof(UniformDimensions).IsAssignableFrom(type))
                                    replacement = replacement.Substring(0, replacement.Length - 2);
                            }

                            replacement = translation.NativeText + replacement;
                            return (replacement, type, type.IsArray);
                        }
                    }
                }
            }

            // We have no known Type instance to use, so try to figure out if it's an array or not, manually.
            int openIndex = typeName.IndexOf("[");
            bool isArray = false;

            if (openIndex > -1 && typeName.EndsWith("]"))
            {
                typeName = typeName.Substring(0, openIndex);
                isArray = true;
            }

            return (typeName, type, isArray);
        }
    }
}
