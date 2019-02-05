using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader.Result
{
    public class ShaderLayoutElement : ShaderElement
    {
        internal ShaderLayoutElement(List<int> dimensions = null) : base(dimensions)
        {

        }

        /// <summary>
        /// Gets the expected shader semantic.
        /// </summary>
        public SemanticType Semantic { get; internal set; }

        public int SemanticIndex { get; internal set; }

    }
}
