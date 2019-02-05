using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader.Result
{
    public class ConversionResult : IEnumerable<KeyValuePair<string, ShaderResult>>
    {
        internal ConversionResult(ConversionContext context, ConversionFlags flags)
        {
            Messages = new List<ConversionMessage>(context.Messages);
            Output = new Dictionary<string, ShaderResult>();

            foreach (ShaderContext sc in context.Shaders)
            {
                ShaderResult shader = new ShaderResult(sc);
                string strSourceResult = sc.Source.ToString();

                if ((flags & ConversionFlags.SkipFormatting) != ConversionFlags.SkipFormatting)
                {
                    if ((flags & ConversionFlags.RemoveWhitespace) == ConversionFlags.RemoveWhitespace)
                        FormattingHelper.RemoveWhitespace(ref strSourceResult, flags);
                    else
                        FormattingHelper.CorrectIndents(ref strSourceResult, flags);
                }

                shader.SourceCode = strSourceResult;
                Output.Add(sc.Name, shader);
            }
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
