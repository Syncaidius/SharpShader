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
        Dictionary<Type, string> _words = new Dictionary<Type, string>();

        public ShaderLanguage Language { get; }

        internal ShaderLexicon(ShaderLanguage language)
        {
            Language = language;
        }

        internal string Translate(Type t)
        {
            return _words[t] ?? t.Name;
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

            foreach (XmlNode subTypeNode in wordNode)
            {
                if (subTypeNode.Name != "Word")
                    continue;

                string generic = subTypeNode.Attributes["generic"]?.InnerText;
                string toType = subTypeNode.Attributes["to"]?.InnerText;

                if (!string.IsNullOrWhiteSpace(generic))
                {
                    Type genericType = Type.GetType(generic) ?? throw new TypeAccessException($"The type {generic} is not valid in {lex.Language} lexicon.");
                    Type translatedGeneric = translatedType.MakeGenericType(genericType);
                    lex._words.Add(translatedGeneric, toType);
                }
            }
        }
        #endregion
    }
}
