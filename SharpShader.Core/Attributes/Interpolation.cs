using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    [AttributeUsage(AttributeTargets.Field)]
    public class InterpolationAttribute : SharpShaderAttribute
    {
        public static readonly InterpolationMode[] ModeValues;

        static InterpolationAttribute()
        {
            ModeValues = (InterpolationMode[])Enum.GetValues(typeof(InterpolationMode));
        }

        public InterpolationAttribute(InterpolationMode mode = InterpolationMode.Linear)
        {
            Flags = mode;
        }

        public InterpolationMode Flags { get; }
    }

    [Flags]
    public enum InterpolationMode
    {
        None = 0,

        Linear = 1,

        Centroid = 2,

        NoInterpolation = 4,

        NoPerspective = 8,

        Sample = 16,
    }
}
