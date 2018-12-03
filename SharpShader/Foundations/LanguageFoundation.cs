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
        internal abstract string TranslateConstantBuffer(ConversionContext context, StructDeclarationSyntax syntax, int slot);

        internal abstract string TranslateStruct(ConversionContext context, StructDeclarationSyntax syntax);

        internal abstract string TranslateStructField(ConversionContext context, FieldDeclarationSyntax syntax);

        /// <summary>
        /// Occurs when the first line of an entry point method/function declaration requires translating. The content of the method should not be translated.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="ep"></param>
        /// <returns></returns>
        internal abstract string TranslateEntryPointHeader(ConversionContext context, EntryPoint ep, ref string header);

        internal abstract string TranslateNumber(ConversionContext context, string number);

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

        /// <summary>
        /// Gets whether or not constant buffers are referred to as if they are instanced objects in their respective shader language.
        /// </summary>
        internal abstract bool InstancedConstantBuffers { get; }

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

        internal LanguageFoundation(ShaderLanguage language)
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
        static Dictionary<ShaderLanguage, LanguageFoundation> _foundations = new Dictionary<ShaderLanguage, LanguageFoundation>();

        internal static LanguageFoundation Get(ShaderLanguage outputLanguage)
        {
            return _foundations[outputLanguage];
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

                            case "Intrinsic":
                                ParseIntrinsic(foundation, node);
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
            Type translatedType = Type.GetType(wordNode.Attributes["t"].InnerText);
            bool uniformDimensionSingular = false;

            if (wordNode.Attributes["uniformSizeIsSingular"] != null)
                bool.TryParse(wordNode.Attributes["uniformSizeIsSingular"].InnerText, out uniformDimensionSingular);

            foreach (XmlNode subTypeNode in wordNode)
            {
                if (subTypeNode.Name != "Generic")
                    continue;

                string generic = subTypeNode.Attributes["type"]?.InnerText;
                string toWord = subTypeNode.Attributes["to"]?.InnerText;

                if (!string.IsNullOrWhiteSpace(generic))
                {
                    Type genericType = Type.GetType(generic) ?? throw new TypeAccessException($"The type {generic} is not valid in {foundation.Language} lexicon.");
                    Type translatedGeneric = translatedType.MakeGenericType(genericType);
                    foundation._words.Add(translatedGeneric, new Word()
                    {
                        Text = toWord,
                        UniformSizeIsSingular = uniformDimensionSingular,
                    });
                }
            }
        }

        private static void ParseIntrinsic(LanguageFoundation foundation, XmlNode node)
        {
            XmlAttribute attName = node.Attributes["name"];
            if (attName == null)
                return;

            List<Intrinsic> intrinsicList = null;
            if (!foundation._intrinsics.TryGetValue(attName.InnerText, out intrinsicList))
            {
                intrinsicList = new List<Intrinsic>();
                foundation._intrinsics.Add(attName.InnerText, intrinsicList);
            }

            Intrinsic i = new Intrinsic();
            i.Name = attName.InnerText;
            intrinsicList.Add(i);

        }
        #endregion
    }
}
