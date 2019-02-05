using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader.Result
{
    public class ShaderInputOutput
    {
        /// <summary>
        /// The total size of the input or output structure. This is equivilent to the sum of all <see cref="ShaderLayoutElement.SizeOf"/> in <see cref="Elements"/>.
        /// </summary>
        public readonly int SizeOf;

        public IReadOnlyList<ShaderLayoutElement> Elements { get; }

        List<ShaderLayoutElement> _elements;

        internal ShaderInputOutput(List<ShaderLayoutElement> elements)
        {
            _elements = elements;
            Elements = elements.AsReadOnly();
        }
    }
}
