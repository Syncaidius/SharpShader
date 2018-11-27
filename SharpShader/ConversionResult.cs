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
        public class Error
        {
            /// <summary>
            /// The error message.
            /// </summary>
            public string Message { get; internal set; }

            /// <summary>
            /// The line number of the error.
            /// </summary>
            public int LineNumber { get; internal set; }

            /// <summary>
            /// The character position along the <see cref="LineNumber"/> at which the error is located.
            /// </summary>
            public int LinePosition { get; internal set; }
        }

        public class Shader
        {
            /// <summary>
            /// The names of other shader results which were translated as shared or include files. 
            /// </summary>
            public IReadOnlyList<string> Includes { get; }

            public IReadOnlyList<Error> Errors { get; }

            /// <summary>
            /// The translated shader-language source code.
            /// </summary>
            public string SourceCode { get; internal set; }

            List<string> _includes;
            List<Error> _errors;

            internal Shader()
            {
                _includes = new List<string>();
                Includes = _includes.AsReadOnly();
                _errors = new List<Error>();
                Errors = _errors.AsReadOnly();
            }

            internal void AddError(string msg, int lineNumber, int linePosition)
            {
                _errors.Add(new Error()
                {
                    Message = msg,
                    LineNumber = lineNumber,
                    LinePosition = linePosition,
                });
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
