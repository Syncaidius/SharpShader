using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class PropertyTranslation
    {
        public string GetterMethod = null;

        public string SetterMethod = null;

        public string TypeName = null;

        public Type OriginalType = null;

        internal string GetGetterHeader()
        {
            return $"{TypeName} {GetterMethod}()";
        }

        internal string GetSetterHeader()
        {
            return $"void {SetterMethod}({TypeName} value)";
        }
    }
}
