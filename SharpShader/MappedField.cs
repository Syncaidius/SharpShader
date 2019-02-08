using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class MappedField
    {
        internal List<int> Dimensions = new List<int>();

        internal ShaderDataType DataType = ShaderDataType.Boolean;

        internal ShaderStructureType StructureType = ShaderStructureType.Unknown;

        internal ShaderType Type;

        internal int ElementCount;

        internal int? PackOffsetBytes;

        internal FieldInfo Info;

        internal IEnumerable<Attribute> Attributes;
    }
}
