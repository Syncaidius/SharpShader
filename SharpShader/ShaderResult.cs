using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    public class ShaderResult
    {
        /// <summary>
        /// The names of other shader results which were translated as shared or include files. 
        /// </summary>
        public IReadOnlyList<string> Includes { get; }

        /// <summary>
        /// The translated shader-language source code.
        /// </summary>
        public string SourceCode { get; internal set; }

        List<string> _includes;

        internal ShaderResult()
        {
            _includes = new List<string>();
            Includes = _includes.AsReadOnly();
        }

        internal void AddInclude(string includeName)
        {
            _includes.Add(includeName);
        }
    }
}
