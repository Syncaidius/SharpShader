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
    internal class ShaderLexicon
    {
        #region Instance members
        internal class Intrinsic
        {
            internal string Name { get; set; }
            internal List<string> Parameters = new List<string>();
        }

        internal class Word
        {
            public bool UniformSizeIsSingular;
            public string Text;
        }
        Dictionary<Type, Word> _words = new Dictionary<Type, Word>();
        Dictionary<string, List<Intrinsic>> _intrinsics = new Dictionary<string, List<Intrinsic>>();

        public ShaderLanguage Language { get; }

        public LanguageFoundation Foundation { get; private set; }

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

        internal bool IsIntrinsic(string name)
        {
            return _intrinsics.ContainsKey(name);
        }
        #endregion

        #region Static members
        static Dictionary<ShaderLanguage, ShaderLexicon> _lexicons = new Dictionary<ShaderLanguage, ShaderLexicon>();

        internal static ShaderLexicon GetLexicon(ShaderLanguage outputLanguage)
        {
            return _lexicons[outputLanguage];
        }

        internal static void LoadeEmbeddedLexicon<T>(string embeddedName) where T : LanguageFoundation
        {
            using (Stream stream = EmbeddedResource.GetStream(embeddedName))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(stream);

                XmlNode rootNode = doc["Lexicon"];
                XmlNode langNode = rootNode["Language"];

                if (Enum.TryParse(langNode.InnerText, out ShaderLanguage language))
                {
                    ShaderLexicon lex = new ShaderLexicon(language);
                    lex.Foundation = Activator.CreateInstance(typeof(T),
                        BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance,
                        null, null, null) as LanguageFoundation;

                    foreach (XmlNode node in rootNode)
                    {
                        switch (node.Name)
                        {
                            case "Word":
                                ParseWord(lex, node);
                                break;

                            case "Intrinsic":
                                ParseIntrinsic(lex, node);
                                break;
                        }                         
                    }

                    _lexicons.Add(language, lex);
                }
                else
                {
                    throw new XmlException("The specified shader language is invalid, or was missing.");
                }
            }
        }

        private static void ParseWord(ShaderLexicon lex, XmlNode wordNode)
        {
            Type translatedType = Type.GetType(wordNode.Attributes["t"].InnerText);
            bool uniformDimensionSingular = false;

            if(wordNode.Attributes["uniformSizeIsSingular"] != null)
                bool.TryParse(wordNode.Attributes["uniformSizeIsSingular"].InnerText, out uniformDimensionSingular);

            foreach (XmlNode subTypeNode in wordNode)
            {
                if (subTypeNode.Name != "Generic")
                    continue;

                string generic = subTypeNode.Attributes["type"]?.InnerText;
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

        private static void ParseIntrinsic(ShaderLexicon lex, XmlNode node)
        {
            XmlAttribute attName = node.Attributes["name"];
            if (attName == null)
                return;

            List<Intrinsic> intrinsicList = null;
            if (!lex._intrinsics.TryGetValue(attName.InnerText, out intrinsicList))
            {
                intrinsicList = new List<Intrinsic>();
                lex._intrinsics.Add(attName.InnerText, intrinsicList);
            }

            Intrinsic i = new Intrinsic();
            i.Name = attName.InnerText;
            intrinsicList.Add(i);

        }
        #endregion
    }
}
