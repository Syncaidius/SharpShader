using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader.Result
{
    public class ShaderResult
    {
        /// <summary>
        /// Gets a dictionary containing pairs of included shader names and results.
        /// </summary>
        public ReadOnlyDictionary<string, ShaderResult> Includes { get; }

        public ReadOnlyDictionary<string, ConstantBufferInfo> ConstantBuffers { get; }

        public IReadOnlyList<ShaderInputOutput> Inputs { get; } 

        public ShaderInputOutput Output { get; }

        /// <summary>
        /// The translated shader-language source code.
        /// </summary>
        public string SourceCode { get; internal set; }

        Dictionary<string, ShaderResult> _includes;
        Dictionary<string, ConstantBufferInfo> _constBuffers;
        List<ShaderInputOutput> _inputs;

        internal ShaderResult(ShaderContext context)
        {
            _includes = new Dictionary<string, ShaderResult>();
            Includes = new ReadOnlyDictionary<string, ShaderResult>(_includes);

            _constBuffers = new Dictionary<string, ConstantBufferInfo>();
            ConstantBuffers = new ReadOnlyDictionary<string, ConstantBufferInfo>(_constBuffers);

            _inputs = new List<ShaderInputOutput>();
            Inputs = _inputs.AsReadOnly();

            /* TODO:
             *  - Produce constant buffer information.
             *  - Produce info for a SINGLE entry point
             *  - Produce resource variable information (textures, samplers, UAVs, etc)
             *  - If a ShaderResult is used as an include, flag a boolean property as such (e.g. IsInclude).
             *  - Produce input and output layout information (ShaderInputOuput).
             */
        }
    }
}
