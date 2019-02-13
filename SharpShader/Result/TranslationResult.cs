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
        internal TranslationResult(TranslationContext context, TranslationFlags flags)
        {
            Messages = new List<TranslationMessage>(context.Messages);
            Output = new Dictionary<string, ShaderTranslationResult>();

            foreach (ShaderTranslationContext sc in context.Shaders)
            {
                ShaderTranslationResult shader = new ShaderTranslationResult(sc);
                string strSourceResult = sc.Source.ToString();

                if ((flags & TranslationFlags.SkipFormatting) != TranslationFlags.SkipFormatting)
                {
                    if ((flags & TranslationFlags.RemoveWhitespace) == TranslationFlags.RemoveWhitespace)
                        FormattingHelper.RemoveWhitespace(ref strSourceResult, flags);
                    else
                        FormattingHelper.CorrectIndents(ref strSourceResult, flags);
                }

                shader.SourceCode = strSourceResult;
                Output.Add(sc.Name, shader);
            }
        }

        public Dictionary<string, ShaderTranslationResult> Output { get; }

        public List<TranslationMessage> Messages { get; }

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
