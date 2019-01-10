using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    [Serializable]
    internal class EntryPoint
    {
        internal EntryPointType EntryType;

        internal MethodInfo Method;

        internal EntryPointAttribute Attribute;

        internal EntryPoint(MethodInfo info, EntryPointAttribute attribute, EntryPointType type)
        {
            Method = info;
            Attribute = attribute;
            EntryType = type;
        }

        public override string ToString()
        {
            return $"{Method} - {EntryType}";
        }
    }

    public enum EntryPointType
    {
        AnyOrNone = 0,

        VertexShader = 1,

        FragmentShader = 2,

        GeometryShader = 3,

        HullShader = 4,

        DomainShader = 5,

        ComputeShader = 6,
    }
}
