using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    public class ConversionResult : IEnumerable<KeyValuePair<string, ShaderResult>>
    {
        internal ConversionResult()
        {
            Messages = new List<ConversionMessage>();
            Output = new Dictionary<string, ShaderResult>();
        }

        public Dictionary<string, ShaderResult> Output { get; }

        public List<ConversionMessage> Messages { get; }

        public IEnumerator<KeyValuePair<string, ShaderResult>> GetEnumerator()
        {
            return Output.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Output.GetEnumerator();
        }
    }
}
