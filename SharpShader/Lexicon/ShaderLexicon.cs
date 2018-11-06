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
            public string WordText;

            /// <summary>
            /// A dictionary containing shader language translations for sub-types of a word in C# source. For example, Vector
            /// </summary>
            public Dictionary<Type, string> TypeNames = new Dictionary<Type, string>();
        }

        Dictionary<Type, Word> _words = new Dictionary<Type, Word>();

        static Dictionary<ShaderOutput, ShaderLexicon> _lexicons = new Dictionary<ShaderOutput, ShaderLexicon>();

        static ShaderLexicon()
        {
            LoadeEmbeddedLexicon("SharpShader.Lexicon.hlsl.xml");
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

                if (Enum.TryParse(langNode.InnerText, out ShaderOutput language))
                {
                    ShaderLexicon lex = new ShaderLexicon();

                    foreach (XmlNode wordNode in rootNode)
                    {
                        if (wordNode.Name == "Word")
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
            foreach (XmlNode subTypeNode in wordNode)
            {
                if (subTypeNode.Name != "SubType")
                    continue;
            }
        }
    }
}
