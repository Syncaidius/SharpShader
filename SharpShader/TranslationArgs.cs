using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class TranslationArgs : MarshalByRefObject
    {
        /// <summary>
        /// C# source strings, indexed by friendly name or file name.
        /// </summary>
        public Dictionary<string, string> CSharpSources;

        public List<string> PreprocessorSymbols;

        /// <summary>
        /// The output language.
        /// </summary>
        public OutputLanguage Language;

        /// <summary>
        /// The flags to apply to the conversion.
        /// </summary>
        public TranslationFlags Flags;
    }
}
