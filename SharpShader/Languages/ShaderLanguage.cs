using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SharpShader.Languages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SharpShader
{
    internal abstract partial class ShaderLanguage
    { 
        #region Instance members
        /// <summary>
        /// Gets whether or not constant buffers are referred to as if they are instanced objects in their respective shader language.
        /// </summary>
        internal abstract bool InstancedConstantBuffers { get; }

        public OutputLanguage Language { get; }

        /// <summary>
        /// Gets whether or not the shader language has column-major matrices by default. If false, they will be considered as row-major.
        /// </summary>
        public abstract bool HasColumnMajorMatrices { get; }

        Dictionary<Type, Translation> _keywords;
        List<Modifier> _modifiers;
        internal Dictionary<string, ShaderType> TranslatedTypes;

        internal ShaderLanguage(OutputLanguage language)
        {
            Language = language;
            _keywords = new Dictionary<Type, Translation>();
            _modifiers = new List<Modifier>();
            TranslatedTypes = new Dictionary<string, ShaderType>();
        }

        internal string TranslateModifiers(SyntaxTokenList modifiers)
        {
            foreach (Modifier m in _modifiers)
            {
                if (m.IsMatch(modifiers))
                    return m.NativeText;
            }

            return "";
        }

        internal abstract void TranslateConstBufferHeader(ShaderTranslationContext sc, StructDeclarationSyntax syntax, ConstantBufferMap cBufferMap, IEnumerable<Attribute> attributes);

        internal abstract void TranslateFieldPrefix(ShaderTranslationContext sc, VariableDeclaratorSyntax syntax, MappedField field, int fieldIndex, ConstantBufferMap cBufferMap);

        internal abstract void TranslateFieldPostfix(ShaderTranslationContext sc, VariableDeclaratorSyntax syntax, MappedField field, int fieldIndex, ConstantBufferMap cBufferMap);

        internal abstract string TranslateNumber(ShaderTranslationContext sc, string number);

        internal abstract void TranslateForLoopPrefix(ShaderTranslationContext sc, ForStatementSyntax syntax);

        /// <summary>
        /// Returns a <see cref="Translation"/> instance containing useful information about a type for translation purposes.
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        internal Translation GetTranslation(Type t)
        {
            if (t.IsArray)
                t = t.GetElementType();

            if (_keywords.TryGetValue(t, out Translation word))
                return word;
            else
                return null;
        }

        internal abstract IEntryPointTranslator GetEntryPoinTranslator(EntryPointType type);

        #endregion

        #region Static members
        static Dictionary<OutputLanguage, ShaderLanguage> _foundations = new Dictionary<OutputLanguage, ShaderLanguage>();

        internal static ShaderLanguage Get(OutputLanguage outputLanguage)
        {
            return _foundations[outputLanguage];
        }

        protected static string TranslateBinaryLiteral(string number)
        {
            number = number.Substring(2);
            int result = 0;
            number = string.Concat(number.Reverse()).Replace("_", "");
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == '1')
                    result |= 1 << i;
            }

            return result.ToString();
        }

        internal static void LoadEmbedded<T>(string embeddedName) where T : ShaderLanguage
        {
            using (Stream stream = EmbeddedResource.GetStream(embeddedName))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(stream);

                foreach (XmlNode rootNode in doc)
                {
                    if (rootNode.Name.ToLower() != "lexicon")
                        continue;

                    XmlAttribute attLanguage = rootNode.Attributes["language"];
                    if (attLanguage != null && Enum.TryParse(attLanguage.InnerText, out OutputLanguage language))
                    {
                        ShaderLanguage foundation = Activator.CreateInstance(typeof(T),
                            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance,
                            null, new object[] { language }, null) as ShaderLanguage;

                        foreach (XmlNode node in rootNode)
                        {
                            switch (node.Name.ToLower())
                            {
                                case "word":
                                    ParseWord(foundation, node);
                                    break;

                                case "modifier":
                                    ParseModifier(foundation, node);
                                    break;
                            }
                        }

                        _foundations.Add(language, foundation);
                    }
                    else
                    {
                        throw new XmlException("The specified shader language is invalid or missing.");
                    }
                }
            }
        }

        private static void ParseWord(ShaderLanguage foundation, XmlNode wordNode)
        {
            Type translatedType = Type.GetType(wordNode.Attributes["type"].InnerText);
            if (translatedType == null)
                return;

            bool uniformDimensionSingular = false;
            if (wordNode.Attributes["uniformSizeIsSingular"] != null)
                bool.TryParse(wordNode.Attributes["uniformSizeIsSingular"].InnerText, out uniformDimensionSingular);

            if (translatedType.IsGenericType)
            {
                foreach (XmlNode subTypeNode in wordNode)
                {
                    if (subTypeNode.Name.ToLower() != "generic")
                        continue;

                    string generic = subTypeNode.Attributes["type"]?.InnerText;
                    string nativeName = subTypeNode.Attributes["name"]?.InnerText;

                    if (!string.IsNullOrWhiteSpace(generic) && !string.IsNullOrWhiteSpace(nativeName))
                    {
                        Type genericType = Type.GetType(generic) ?? throw new TypeAccessException($"The type {generic} is not valid in {foundation.Language} lexicon.");
                        Type finalType = translatedType.MakeGenericType(genericType);

                        foundation._keywords.Add(finalType, new Translation()
                        {
                            NativeText = nativeName,
                            UniformSizeIsSingular = uniformDimensionSingular,
                        });
                    }
                }
            }
            else
            {
                string generic = wordNode.Attributes["type"]?.InnerText;
                string nativeName = wordNode.Attributes["name"]?.InnerText;

                if (!string.IsNullOrWhiteSpace(generic) && !string.IsNullOrWhiteSpace(nativeName))
                {
                    foundation._keywords.Add(translatedType, new Translation()
                    {
                        NativeText = nativeName,
                        UniformSizeIsSingular = uniformDimensionSingular,
                    });
                }
            }
        }

        private static void ParseModifier(ShaderLanguage foundation, XmlNode modifierNode)
        {
            XmlAttribute attName = modifierNode.Attributes["name"];
            if (attName == null)
                return;

            Modifier modifier = new Modifier();
            modifier.NativeText = attName.InnerText;
            foreach (XmlNode child in modifierNode)
            {
                if (child.Name.ToLower() != "requirement")
                    continue;

                XmlAttribute attCSharp = child.Attributes["csharp"];
                if (attCSharp != null && !string.IsNullOrWhiteSpace(attCSharp.InnerText))
                    modifier.Requirements.Add(attCSharp.InnerText.ToLower());
            }

            if (modifier.Requirements.Count > 0 && !string.IsNullOrWhiteSpace(modifier.NativeText))
                foundation._modifiers.Add(modifier);
        }        
        #endregion
    }
}
