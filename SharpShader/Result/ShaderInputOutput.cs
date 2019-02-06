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
        /// The total size of the input or output structure. This is equivilent to the sum of all <see cref="ShaderLayoutMember.SizeOf"/> in <see cref="Elements"/>.
        /// </summary>
        public readonly int SizeOf;

        public IReadOnlyList<ShaderLayoutMember> Elements { get; }

        List<ShaderLayoutMember> _elements;

        internal ShaderInputOutput(List<ShaderLayoutMember> elements)
        {
            _elements = elements;
            Elements = elements.AsReadOnly();
        }
    }
}
