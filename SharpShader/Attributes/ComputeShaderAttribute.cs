using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    [AttributeUsage(AttributeTargets.Method)]
    public class ComputeShaderAttribute : EntryPointAttribute
    {
        public ComputeShaderAttribute(int threadsX, int threadsY, int threadsZ)
        {
            ThreadsX = threadsX;
            ThreadsY = threadsY;
            ThreadsZ = threadsZ;
        }

        public override EntryPointType EntryType => EntryPointType.ComputeShader;

        public int ThreadsX { get; }

        public int ThreadsY { get; }

        public int ThreadsZ { get; }
    }
}
