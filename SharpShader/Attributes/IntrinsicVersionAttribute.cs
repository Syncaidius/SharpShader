using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class IntrinsicVersionAttribute : SharpShaderAttribute
    {
        public IntrinsicPipelineType Piepline { get; }
        public float MinVersion { get; }
        public float MaxVersion { get; }

        public IntrinsicVersionAttribute(IntrinsicPipelineType pipeline, float minVersion = float.MinValue, float maxVersion = float.MaxValue)
        {
            Piepline = pipeline;
            MinVersion = minVersion;
            MaxVersion = maxVersion;
        }
    }

    public enum IntrinsicPipelineType
    {
        Vertex = 0,

        Geometry = 1,

        Hull = 2,

        Domain = 3,

        Fragment = 4,

        Compute = 5,
    }
}
