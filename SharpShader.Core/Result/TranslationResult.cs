using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// A container for the results of shader translations.
    /// </summary>
    public class TranslationResult : IEnumerable<KeyValuePair<string, ShaderTranslationResult>>
    {
        /// <summary>
        /// Creates a new instance of <see cref="TranslationResult"/>.
        /// </summary>
        /// <param name="messages">The messages to be associated with the current <see cref="TranslationResult"/>.</param>
        /// <param name="output">The translation output to be associated with the current <see cref="TranslationResult"/>.</param>
        public TranslationResult(List<TranslationMessage> messages, Dictionary<string, ShaderTranslationResult> output)
        {
            Messages = messages.AsReadOnly();
            Output = new ReadOnlyDictionary<string, ShaderTranslationResult>(output);
        }

        /// <summary>
        /// Gets a dictionary containing the translation results for each shader, with their name as a key.
        /// </summary>
        public ReadOnlyDictionary<string, ShaderTranslationResult> Output { get; }

        /// <summary>
        /// Gets a list of messages that occurred during translation.
        /// </summary>
        public IReadOnlyList<TranslationMessage> Messages { get; }

        /// <summary>
        /// Gets an enumerator for the current <see cref="TranslationResult"/> instance.
        /// </summary>
        /// <returns>An enumerator.</returns>
        public IEnumerator<KeyValuePair<string, ShaderTranslationResult>> GetEnumerator()
        {
            return Output.GetEnumerator();
        }

        /// <summary>
        /// Gets an enumerator for the current <see cref="TranslationResult"/> instance.
        /// </summary>
        /// <returns>An enumerator.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return Output.GetEnumerator();
        }
    }
}
