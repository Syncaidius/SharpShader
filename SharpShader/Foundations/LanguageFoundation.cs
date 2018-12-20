using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
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
    internal abstract class LanguageFoundation
    {
        internal class Keyword
        {
            /// <summary>
            /// If true, uniform, multi-dimensional type names will be translated to single-dimension names. For example, Matrix4x4 will translate into Matrix4, Mat4 or Float4.
            /// </summary>
            public bool UniformSizeIsSingular;

            /// <summary>
            /// The word in it's native language.
            /// </summary>
            public string NativeText;
        }

        #region Instance members
        /// <summary>
        /// Gets whether or not constant buffers are referred to as if they are instanced objects in their respective shader language.
        /// </summary>
        internal abstract bool InstancedConstantBuffers { get; }

        public ShaderLanguage Language { get; }

        Dictionary<Type, Keyword> _keywords;
        Dictionary<EntryPointType, IEntryPointTranslator> _epTranslators;

        internal LanguageFoundation(ShaderLanguage language)
        {
            Language = language;
            _keywords = new Dictionary<Type, Keyword>();
            _epTranslators = new Dictionary<EntryPointType, IEntryPointTranslator>();
        }

        internal abstract string TranslateConstantBuffer(ShaderContext context, StructDeclarationSyntax syntax, uint? registerID);

        internal abstract string TranslateStruct(ShaderContext context, StructDeclarationSyntax syntax);

        internal abstract string TranslateStructField(ShaderContext context, FieldDeclarationSyntax syntax);

        internal abstract string TranslateRegisterField(ShaderContext context, FieldDeclarationSyntax syntax, Type fieldType, uint registerID);

        internal IEntryPointTranslator GetEntryPointTranslator(EntryPointType type)
        {
            return _epTranslators[type];
        }

        internal abstract string TranslateNumber(ShaderContext context, string number);

        /// <summary>
        /// Returns the translated string for a type, or null if no translation is found.
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        internal Keyword GetKeyword(Type t)
        {
            if (_keywords.TryGetValue(t, out Keyword word))
                return word;
            else
                return null;
        }

        protected void AddEntryPointTranslator<T>(EntryPointType type) where T : class, IEntryPointTranslator, new()
        {
            T translator = new T();
            _epTranslators.Add(type, translator);
        }
        #endregion

        #region Static members
        static Dictionary<ShaderLanguage, LanguageFoundation> _foundations = new Dictionary<ShaderLanguage, LanguageFoundation>();

        internal static LanguageFoundation Get(ShaderLanguage outputLanguage)
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

        internal static void LoadEmbedded<T>(string embeddedName) where T : LanguageFoundation
        {
            using (Stream stream = EmbeddedResource.GetStream(embeddedName))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(stream);

                XmlNode rootNode = doc["Lexicon"];
                XmlNode langNode = rootNode["Language"];

                if (Enum.TryParse(langNode.InnerText, out ShaderLanguage language))
                {
                    LanguageFoundation foundation = Activator.CreateInstance(typeof(T),
                        BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance,
                        null, new object[] { language }, null) as LanguageFoundation;

                    foreach (XmlNode node in rootNode)
                    {
                        switch (node.Name)
                        {
                            case "Word":
                                ParseWord(foundation, node);
                                break;
                        }
                    }

                    _foundations.Add(language, foundation);
                }
                else
                {
                    throw new XmlException("The specified shader language is invalid, or was missing.");
                }
            }
        }

        private static void ParseWord(LanguageFoundation foundation, XmlNode wordNode)
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
                    if (subTypeNode.Name != "Generic")
                        continue;

                    string generic = subTypeNode.Attributes["type"]?.InnerText;
                    string nativeName = subTypeNode.Attributes["name"]?.InnerText;

                    if (!string.IsNullOrWhiteSpace(generic) && !string.IsNullOrWhiteSpace(nativeName))
                    {
                        Type genericType = Type.GetType(generic) ?? throw new TypeAccessException($"The type {generic} is not valid in {foundation.Language} lexicon.");
                        Type translatedGeneric = translatedType.MakeGenericType(genericType);
                        foundation._keywords.Add(translatedGeneric, new Keyword()
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
                    foundation._keywords.Add(translatedType, new Keyword()
                    {
                        NativeText = nativeName,
                        UniformSizeIsSingular = uniformDimensionSingular,
                    });
                }
            }
        }
        #endregion
    }
}
