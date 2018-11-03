﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    public enum ShaderOutput
    {
        /// <summary>
        /// The input C# code will be output to DirectX high-level shader language (HLSL).
        /// </summary>
        HLSL = 0,

        /// <summary>
        /// The input C# code will be output to GL shader language (GLSL).
        /// </summary>
        GLSL = 1,
    }
}
