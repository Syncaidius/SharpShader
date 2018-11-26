using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    public class ConversionResult : IEnumerable<KeyValuePair<string, ConversionResult.Shader>>
    {
        public class Shader
        {
            /// <summary>
            /// The names of other shader results which were translated as shared or include files. 
            /// </summary>
            public IReadOnlyList<string> Includes { get; }

            /// <summary>
            /// The translated shader-language source code.
            /// </summary>
            public string SourceCode { get; }

            List<string> _includes;

            internal Shader(string code)
            {
                _includes = new List<string>();
                Includes = _includes.AsReadOnly();
                SourceCode = code;
            }

            internal void AddInclude(string includeName)
            {
                _includes.Add(includeName);
            }
        }

        public Dictionary<string, Shader> Translated { get; private set; } = new Dictionary<string, Shader>();

        public IEnumerator<KeyValuePair<string, Shader>> GetEnumerator()
        {
            return Translated.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Translated.GetEnumerator();
        }
    }
}
