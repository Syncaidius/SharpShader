using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal interface IEntryPointTranslator
    {
        string TranslateHeader(ShaderContext context, EntryPoint ep, MethodInformation info);
    }
}
