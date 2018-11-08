using Microsoft.CodeAnalysis;
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
    /// <summary>
    /// A lexicon to aid translation of certain words and types.
    /// </summary>
    public class ShaderLexicon
    {
        public class Word
        {
            public bool UniformSizeIsSingular;
            public string Text;
        }
        Dictionary<Type, Word> _words = new Dictionary<Type, Word>();

        public ShaderLanguage Language { get; }

        internal ShaderLexicon(ShaderLanguage language)
        {
            Language = language;
        }

        /// <summary>
        /// Returns the translated string for a type, or null if no translation is found.
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        internal Word GetWord(Type t)
        {
            if (_words.TryGetValue(t, out Word word))
                return word;
            else
                return null;
        }

        #region Static
        static Dictionary<ShaderLanguage, ShaderLexicon> _lexicons = new Dictionary<ShaderLanguage, ShaderLexicon>();

        internal static ShaderLexicon GetLexicon(ShaderLanguage outputLanguage)
        {
            return _lexicons[outputLanguage];
        }

        internal static void LoadeEmbeddedLexicon(string embeddedName)
        {
            using (Stream stream = EmbeddedResource.GetStream(embeddedName))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(stream);

                XmlNode rootNode = doc["Lexicon"];
                XmlNode langNode = rootNode["Language"];
                XmlNode words = rootNode["Words"];

                if (Enum.TryParse(langNode.InnerText, out ShaderLanguage language))
                {
                    ShaderLexicon lex = new ShaderLexicon(language);

                    foreach (XmlNode wordNode in words)
                    {
                        if (wordNode.Name == "Type")
                            ParseWordNode(lex, wordNode);
                    }

                    _lexicons.Add(language, lex);
                }
                else
                {
                    throw new XmlException("The specified shader language is invalid, or was missing.");
                }
            }
        }

        private static void ParseWordNode(ShaderLexicon lex, XmlNode wordNode)
        {
            Type translatedType = Type.GetType(wordNode.Attributes["t"].InnerText);
            bool uniformDimensionSingular = false;

            if(wordNode.Attributes["uniformSizeIsSingular"] != null)
                bool.TryParse(wordNode.Attributes["uniformSizeIsSingular"].InnerText, out uniformDimensionSingular);

            foreach (XmlNode subTypeNode in wordNode)
            {
                if (subTypeNode.Name != "Word")
                    continue;

                string generic = subTypeNode.Attributes["generic"]?.InnerText;
                string toWord = subTypeNode.Attributes["to"]?.InnerText;

                if (!string.IsNullOrWhiteSpace(generic))
                {
                    Type genericType = Type.GetType(generic) ?? throw new TypeAccessException($"The type {generic} is not valid in {lex.Language} lexicon.");
                    Type translatedGeneric = translatedType.MakeGenericType(genericType);
                    lex._words.Add(translatedGeneric, new Word()
                    {
                        Text = toWord,
                        UniformSizeIsSingular = uniformDimensionSingular,
                    });
                }
            }
        }
        #endregion
    }
}
