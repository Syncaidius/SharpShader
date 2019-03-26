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
        /// Gets a dictioanry of <see cref="EntryPointInfo"/>, with their name as the key.
        /// </summary>
        public ReadOnlyDictionary<string, EntryPointInfo> EntryPoints { get; }

        /// <summary>
        /// Gets the friendly name or file path that was assigned to the original source code.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the translated shader-language source code.
        /// </summary>
        public string SourceCode { get; }
        
        /// <summary>Creates a new instance of <see cref="ShaderTranslationResult"/>.</summary>
        /// <param name="name">The friendly name or file path assigned to the original source code.</param>
        /// <param name="src">The translated sourcecode.</param>
        /// <param name="entryPoints">A dictionary of entry points within the shader class, with their name as the key.</param>
        /// <param name="includes">A list of #include shader translations.</param>
        /// <param name="cBuffers">A list of constant buffers.</param>
        /// <param name="variables">A list of variables.</param>
        public ShaderTranslationResult(string name, string src, Dictionary<string, EntryPointInfo> entryPoints, Dictionary<string, ShaderTranslationResult> includes, List<ConstantBufferInfo> cBuffers, List<ShaderMember> variables)
        {
            Name = name;
            SourceCode = src;
            EntryPoints = new ReadOnlyDictionary<string, EntryPointInfo>(entryPoints);
            Includes = new ReadOnlyDictionary<string, ShaderTranslationResult>(includes);
            ConstantBuffers = cBuffers.AsReadOnly();
            Variables = variables.AsReadOnly();
        }
    }
}
