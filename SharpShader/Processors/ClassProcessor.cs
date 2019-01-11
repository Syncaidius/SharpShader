﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SharpShader.Processors
{
    internal class ClassProcessor : NodeProcessor<ClassDeclarationSyntax>
    {
        protected override bool OnTranslate(ShaderContext sc, ClassDeclarationSyntax syntax)
        {
            if (syntax.Identifier.ValueText != sc.Name)
            {
                // TODO translate non-root class.
            }
            else
            {
                sc.SkippedNodes.Add(syntax.BaseList);
            }

            return false;
        }
    }
}
