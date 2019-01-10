using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class AnalysisInfo
    {
        internal List<SyntaxTree> Trees;

        internal bool HasError;
    }
}