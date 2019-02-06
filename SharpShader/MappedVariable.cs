using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class MappedVariable
    {
        internal List<int> Dimensions = new List<int>();

        internal ShaderDataType DataType = ShaderDataType.Boolean;

        internal ShaderStructureType StructureType = ShaderStructureType.Unknown;

        internal int ElementCount;

        internal int ElementStride;

        internal int StartOffset;

        internal FieldInfo Info;
    }
}
