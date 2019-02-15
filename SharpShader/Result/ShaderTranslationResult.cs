﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader.Result
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
        /// The translated shader-language source code.
        /// </summary>
        public string SourceCode { get; internal set; }

        Dictionary<string, ShaderTranslationResult> _includes;
        List<ConstantBufferInfo> _constBuffers;
        List<ShaderInputOutput> _inputs;

        internal ShaderTranslationResult(ShaderTranslationContext context)
        {
            _includes = new Dictionary<string, ShaderTranslationResult>();
            Includes = new ReadOnlyDictionary<string, ShaderTranslationResult>(_includes);

            _constBuffers = new List<ConstantBufferInfo>();
            ConstantBuffers = _constBuffers.AsReadOnly();

            foreach (KeyValuePair<string, ConstantBufferMap> p in context.ConstantBuffers)
                _constBuffers.Add(new ConstantBufferInfo(p.Key, p.Value));

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
