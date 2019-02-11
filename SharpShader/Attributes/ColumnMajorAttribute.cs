using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// Flags a matrix field as column-major.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class ColumnMajorAttribute : SharpShaderAttribute
    {
    }
}
