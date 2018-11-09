﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class UsingNodeParser : NodePreprocessor<UsingDirectiveSyntax>
    {
        protected override void OnProcess(ConversionContext context, UsingDirectiveSyntax node, StringBuilder source)
        {
            RemoveSyntax(node, source);
        }
    }
}
