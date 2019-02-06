using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader.Result
{
    public class TranslationResult : IEnumerable<KeyValuePair<string, ShaderTranslationResult>>
    {
        internal TranslationResult(TranslationContext context, ConversionFlags flags)
        {
            Messages = new List<ConversionMessage>(context.Messages);
            Output = new Dictionary<string, ShaderTranslationResult>();

            foreach (ShaderTranslationContext sc in context.Shaders)
            {
                ShaderTranslationResult shader = new ShaderTranslationResult(sc);
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

        public Dictionary<string, ShaderTranslationResult> Output { get; }

        public List<ConversionMessage> Messages { get; }

        public IEnumerator<KeyValuePair<string, ShaderTranslationResult>> GetEnumerator()
        {
            return Output.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Output.GetEnumerator();
        }
    }
}
