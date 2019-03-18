using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// Flags a read-write buffer as globally coherent, which causes memory barriers and syncs to flush data across the entire GPU such that other groups can see writes. 
    /// Without this specifier, a memory barrier or sync will flush a UAV only within the current group.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class GloballyCoherentAttribute : SharpShaderAttribute
    {
    }
}
