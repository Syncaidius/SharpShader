using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    public class ShaderTranslationResult
    {
        /// <summary>
        /// Gets a dictionary containing included shader files, with their name as a key.
        /// </summary>
        public ReadOnlyDictionary<string, ShaderTranslationResult> Includes { get; }

        /// <summary>
        /// Gets a list of <see cref="ConstantBufferInfo"/>, which contain the details of each constant buffer found in the shader.
        /// </summary>
        public IReadOnlyList<ConstantBufferInfo> ConstantBuffers { get; }

        /// <summary>
        /// Gets a list of <see cref="ShaderMember"/>
        /// </summary>
        public IReadOnlyList<ShaderMember> Variables { get; }

        /// <summary>
        /// Gets the translated shader-language source code.
        /// </summary>
        public string SourceCode { get; }
        
        public ShaderTranslationResult(string src, Dictionary<string, ShaderTranslationResult> includes, List<ConstantBufferInfo> cBuffers, List<ShaderMember> variables)
        {
            SourceCode = src;
            Includes = new ReadOnlyDictionary<string, ShaderTranslationResult>(includes);
            ConstantBuffers = cBuffers.AsReadOnly();
            Variables = variables.AsReadOnly();
        }
    }
}
