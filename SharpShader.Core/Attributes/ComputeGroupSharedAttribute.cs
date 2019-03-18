using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// Mark a variable for thread-group-shared memory for compute shaders. 
    /// In D3D10 the maximum total size of all variables with the groupshared storage class is 16kb, in D3D11 the maximum size is 32kb. See examples.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class ComputeGroupSharedAttribute : SharpShaderAttribute
    {
    }
}
