using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader.Core
{
    public static class TypeHelper
    {
        public static bool IsRegisteredType(Type t)
        {
            object[] attributes = t.GetCustomAttributes(typeof(RegisteredTypeAttribute), false);
            return attributes.Length > 0;
        }

        public static bool IsUnorderedAccessType(Type t)
        {
            object[] attributes = t.GetCustomAttributes(typeof(UnorderedAccessTypeAttribute), false);
            return attributes.Length > 0;
        }
    }
}
