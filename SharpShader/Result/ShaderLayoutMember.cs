using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader.Result
{
    public class ShaderLayoutMember : ShaderMember
    {
        internal ShaderLayoutMember() : base() { }

        /// <summary>
        /// Gets the expected shader semantic.
        /// </summary>
        public SemanticType Semantic { get; internal set; }

        /// <summary>
        /// Gets the semantic binding index, usually accompanying the semantic name (e.g. POSITION0, POSITION1, etc).
        /// </summary>
        public int SemanticIndex { get; internal set; }
    }
}
