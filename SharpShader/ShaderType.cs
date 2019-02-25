using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// Provides type information for a shader language-specific type.
    /// </summary>
    [Serializable]
    internal class ShaderType
    {
        internal class SupportedNamespace
        {
            internal AssemblyName[] Assemblies { get; }
            internal string Name { get; }

            internal SupportedNamespace(string name, params Type[] typesFromAssemblies)
            {
                Name = name;
                Assemblies = new AssemblyName[typesFromAssemblies.Length];
                for (int i = 0; i < Assemblies.Length; i++)
                    Assemblies[i] = typesFromAssemblies[i].Assembly.GetName();
            }
        }

        #region Static Members
        /// <summary>
        /// The name of the Sharp Shader namespace.
        /// </summary>
        internal const string NAMESPACE = "SharpShader";

        static readonly char[] _namespaceDelimiters = { '.', ',' };
        static readonly char[] _genericTypeDelimiter = { ',' };
        internal static readonly string[] IntrinsicPrefixes = { "Matrix", "Vector", "UInt", "Double", "Int", "Bool" };
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

        internal static readonly Dictionary<Type, ShaderDataType> _dataTypes = new Dictionary<Type, ShaderDataType>()
        {
            [typeof(long)] = ShaderDataType.Int64,
            [typeof(ulong)] = ShaderDataType.UInt64,
            [typeof(int)] = ShaderDataType.Int32,
            [typeof(uint)] = ShaderDataType.UInt32,
            [typeof(short)] = ShaderDataType.Int16,
            [typeof(ushort)] = ShaderDataType.UInt16,
            [typeof(byte)] = ShaderDataType.UInt8,
            [typeof(sbyte)] = ShaderDataType.Int8,
            [typeof(float)] = ShaderDataType.Float,
            [typeof(double)] = ShaderDataType.Double,
            [typeof(decimal)] = ShaderDataType.Decimal,
            [typeof(bool)] = ShaderDataType.Boolean,
        };

        internal static readonly SupportedNamespace[] SupportedNamespaces =
        {
            new SupportedNamespace(NAMESPACE, typeof(IIntrinsicValue), typeof(CSharpShader)),
            new SupportedNamespace("System", typeof(float)),
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

        static ShaderType()
        {
            _intrinsicMethods = new Dictionary<OutputLanguage, LanguageInfo>();
            _registerTypes = new HashSet<Type>();
            Type t = typeof(CSharpShader);

            // Find all of the types that are compatible with RegisteredTypeAttribute.
            IEnumerable<Type> allTypes = t.Assembly.GetTypes();
            foreach (Type type in allTypes)
            {
                RegisteredTypeAttribute rta = type.GetCustomAttribute<RegisteredTypeAttribute>();
                if (rta != null)
                    _registerTypes.Add(type);
            }

            // Run through all intrinsic methods in CSharpShader class.
            MethodInfo[] methods = t.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (MethodInfo mi in methods)
            {
                IEnumerable<ShaderIntrinsicAttribute> attributes = mi.GetCustomAttributes<ShaderIntrinsicAttribute>();
                foreach (ShaderIntrinsicAttribute att in attributes)
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

        internal static string GetIntrinsicTranslation(ShaderTranslationContext context, string cSharpName)
        {
            if (_intrinsicMethods.TryGetValue(context.Parent.Language.Language, out LanguageInfo info))
            {
                if (info.Intrinsics.TryGetValue(cSharpName, out LanguageMethodInfo methodInfo))
                    return methodInfo.NativeName;
            }

            return cSharpName;
        }

        internal static Type Resolve(ShaderTranslationContext sc, string typeName, SyntaxTokenList modifiers = default)
        {
            Type t = null;

            foreach (SyntaxToken m in modifiers)
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
                t = RetrieveType(typeName);

            if (t == null)
            {
                Type sType = sc.ShaderType;
                t = sc.Parent.Reflection.Assembly.GetType($"{sc.ShaderType.Namespace}.{sc.ShaderType.Name}+{typeName}");

                if (t == null)
                    t = ResolveGeneric(sc, typeName);
            }

            return t;
        }

        internal static Type RetrieveType(string typeName)
        {
            Type t = null;
            string[] parts = typeName.Split(_namespaceDelimiters, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length > 0)
            {
                foreach (SupportedNamespace sn in SupportedNamespaces)
                {
                    foreach (AssemblyName aName in sn.Assemblies)
                    {
                        t = Type.GetType($"{sn.Name}.{parts[parts.Length - 1]}, {aName.FullName}");
                        if (t != null)
                            return t;
                    }
                }
            }

            return t;
        }

        private static Type ResolveGeneric(ShaderTranslationContext sc, string typeName)
        {
            int bIndex = typeName.IndexOf('<');
            Type t = null;
            if (bIndex > -1)
            {
                // TODO garbage generation from arrays?
                string typeParams = typeName.Substring(bIndex, typeName.Length - bIndex);
                string[] inners = typeParams.Substring(1, typeParams.Length - 2).Split(_genericTypeDelimiter, StringSplitOptions.None);
                string outer = typeName.Substring(0, bIndex);
                Type[] innerTypes = new Type[inners.Length];

                for (int i = 0; i < inners.Length; i++)
                {
                    inners[i] = inners[i].Trim();
                    innerTypes[i] = Resolve(sc, inners[i]);
                }

                string outerTypeName = $"{outer}`{inners.Length}";
                Type outerType = Resolve(sc, outerTypeName);
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

        internal static ShaderType TranslateType(ShaderTranslationContext sc, string typeName)
        {
            ShaderType type = null;
            if (sc.Language.TranslatedTypes.TryGetValue(typeName, out type))
            {
                return type;
            }
            else
            {
                Type originalType = Resolve(sc, typeName);
                if (originalType != null)
                {
                    ShaderLanguage.Translation translation = sc.Parent.Language.GetTranslation(originalType);
                    if (translation != null)
                    {
                        type = new ShaderType(sc.Language, translation.NativeText, originalType);
                        sc.Language.TranslatedTypes.TryAdd(typeName, type);
                        return type;
                    }
                    else // Attempt to find any interfaces on the type which can be translated instead.
                    {
                        Type elementType = originalType.GetElementType();
                        Type[] iTypes;
                        if (elementType != null)
                            iTypes = elementType.GetInterfaces();
                        else
                            iTypes = originalType.GetInterfaces();

                        foreach (Type implemented in iTypes)
                        {
                            translation = sc.Parent.Language.GetTranslation(implemented);
                            if (translation != null)
                            {
                                string replacement = elementType?.Name ?? originalType.Name;

                                // TODO Does this need optimizing? Benchmark before changing.
                                for (int i = 0; i < IntrinsicPrefixes.Length; i++)
                                    replacement = replacement.Replace(IntrinsicPrefixes[i], "");

                                if (translation.UniformSizeIsSingular)
                                {
                                    if (typeof(UniformDimensions).IsAssignableFrom(originalType))
                                        replacement = replacement.Substring(0, replacement.Length - 2);
                                }

                                replacement = translation.NativeText + replacement;
                                type = new ShaderType(sc.Language, replacement, originalType);
                                sc.Language.TranslatedTypes.TryAdd(typeName, type);
                                return type;
                            }
                        }

                        // Create a placeholder type instead.
                        type = new ShaderType(sc.Language, typeName, originalType);
                        sc.Language.TranslatedTypes.TryAdd(typeName, type);
                        return type;
                    }
                }

                // We have no known Type instance to use, so try to figure out if it's an array or not, manually.
                int openIndex = typeName.IndexOf("[");
                if (openIndex > -1 && typeName.EndsWith("]"))
                {
                    typeName = typeName.Substring(0, openIndex);
                    int endLen = typeName.Length - openIndex;
                    string reflectiveName = $"System.Object{typeName.Substring(openIndex, endLen)}";
                    type = new ShaderType(sc.Language, typeName, Type.GetType(reflectiveName));
                }
                else
                {
                    type = new ShaderType(sc.Language, typeName, typeof(object));
                }

                // Create a placeholder type using object base class instead.
                sc.Language.TranslatedTypes.TryAdd(typeName, type);
                return type;
            }
        }
        #endregion

        #region Instance Members
        /// <summary>
        /// Gets the translated name of the current <see cref="ShaderType"/>
        /// </summary>
        internal string Translation { get; }

        /// <summary>
        /// Gets the original <see cref="Type"/> from which the current <see cref="ShaderType"/> was translated.
        /// </summary>
        [field: NonSerialized]
        internal Type OriginalType { get; }

        /// <summary>
        /// Gets the C# type of the underlying elements or components of the current <see cref="ShaderType"/>.
        /// </summary>
        [field: NonSerialized]
        internal Type ElementType { get; }

        /// <summary>
        /// Gets the total size of the current <see cref="ShaderType"/>, in bytes.
        /// </summary>
        internal int SizeOf { get; }

        /// <summary>
        /// Gets the size of an underlying component or element of the current <see cref="ShaderType"/>, in bytes.
        /// </summary>
        internal int SubElementSizeOf { get; }

        /// <summary>
        /// Gets the total number of elements which make up the current <see cref="ShaderType"/>.
        /// </summary>
        internal int SubElementCount { get; }

        /// <summary>
        /// Gets the underlying data type of the current <see cref="ShaderType"/>. 
        /// </summary>
        internal ShaderDataType DataType => _dataType;

        /// <summary>
        /// Gets a read-only list containing the dimensions of the type.<para/>
        /// For vectors, this contains only the number of components.<para/>
        /// For matrices, this contains the number of rows followed by the number of columns.<para/>
        /// For arrays, this contains the length of each dimension in the order they were originally declared.
        /// </summary>
        internal IReadOnlyList<int> Dimensions { get; }

        /// <summary>
        /// Gets whether or not the original type was an array type.
        /// </summary>
        public bool WasArrayType { get; }

        /// <summary>
        /// Gets whether or not the current type can be used with shader registers, such as those in HLSL syntax.
        /// </summary>
        public bool IsRegisteredType { get; }

        /// <summary>
        /// Gets whether or not the current type is an unordered-access type.
        /// </summary>
        public bool IsUnorderedAccessType { get; }

        /// <summary>
        /// Gets whether or not the current <see cref="ShaderType"/> represents a vector.
        /// </summary>
        public bool IsVector { get; }

        /// <summary>
        /// Gets whether or not the current <see cref="ShaderType"/> represents a matrix.
        /// </summary>
        public bool IsMatrix { get; }

        /// <summary>
        /// Gets the shader language of which the current <see cref="ShaderType"/> belongs to.
        /// </summary>
        [field: NonSerialized]
        public ShaderLanguage Language { get; }

        ShaderDataType _dataType;
        List<int> _dimensions;

        /// <summary>
        /// Creates a new instance of <see cref="ShaderType"/>.
        /// </summary>
        /// <param name="translation">The language-specific translation of the original type.</param>
        /// <param name="originalType">The original type.</param>
        /// <param name="lang">The shader language which the type belongs to.</param>
        internal ShaderType(ShaderLanguage lang, string translation, Type originalType)
        {
            object[] attributes = originalType.GetCustomAttributes(typeof(RegisteredTypeAttribute), false);
            IsRegisteredType = attributes.Length > 0;

            attributes = originalType.GetCustomAttributes(typeof(UnorderedAccessTypeAttribute), false);
            IsUnorderedAccessType = attributes.Length > 0;

            _dimensions = new List<int>();
            Dimensions = _dimensions.AsReadOnly();
            Language = lang;
            OriginalType = originalType;
            Translation = translation;
            ElementType = originalType.IsArray ? originalType.GetElementType() : originalType;
            WasArrayType = originalType.IsArray;

            if (ElementType.IsValueType)
            {
                if (typeof(IVector).IsAssignableFrom(ElementType))
                {
                    IsVector = true;
                    int elementCount = (int)ElementType.GetField("ELEMENT_COUNT").GetValue(null);
                    SubElementSizeOf = (int)ElementType.GetField("ELEMENT_SIZE").GetValue(null);
                    SizeOf = (int)ElementType.GetField("SIZE_OF").GetValue(null);
                    Type eType = (Type)ElementType.GetField("ElementType").GetValue(null);

                    _dataTypes.TryGetValue(eType, out _dataType);
                    _dimensions.Add(elementCount);
                }
                else if (typeof(IMatrix).IsAssignableFrom(ElementType))
                {
                    IsMatrix = true;
                    int rowCount = (int)ElementType.GetField("ROW_COUNT").GetValue(null);
                    int colCount = (int)ElementType.GetField("COLUMN_COUNT").GetValue(null);
                    SubElementSizeOf = (int)ElementType.GetField("ELEMENT_SIZE").GetValue(null);
                    SizeOf = (int)ElementType.GetField("SIZE_OF").GetValue(null);
                    Type eType = (Type)ElementType.GetField("ElementType").GetValue(null);

                    _dataTypes.TryGetValue(eType, out _dataType);
                    _dimensions.Add(rowCount);
                    _dimensions.Add(colCount);
                }
                else
                {
                    SubElementSizeOf = Marshal.SizeOf(ElementType);
                    SizeOf = SubElementSizeOf;
                    _dataTypes.TryGetValue(ElementType, out _dataType);
                    _dimensions.Add(1);
                }
            }

            SubElementCount = GetTotalElements();
        }

        private int GetTotalElements()
        {
            int elements = 1;
            for (int i = 0; i < Dimensions.Count; i++)
                elements *= Dimensions[i];

            return elements;
        }
        #endregion
    }
}
