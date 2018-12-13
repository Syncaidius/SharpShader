﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class ConversionContext
    {
        internal LanguageFoundation Foundation { get; }
        internal CSharpParseOptions ParseOptions { get; private set; }
        internal List<ShaderContext> Shaders { get; }
        internal List<ConversionMessage> Messages { get; }

        int _nextVariable = 0;

        internal ConversionContext(LanguageFoundation foundatation)
        {
            Foundation = foundatation;
            Shaders = new List<ShaderContext>();
            Messages = new List<ConversionMessage>();
            ParseOptions = new CSharpParseOptions(LanguageVersion.CSharp7_3, DocumentationMode.Parse, SourceCodeKind.Regular);
        }

        internal void AddMessage(string text, int lineNumber, int linePos, ConversionMessageType type = ConversionMessageType.Error)
        {
            Messages.Add(new ConversionMessage()
            {
                Text = text,
                LineNumber = lineNumber,
                LinePosition = linePos,
                MessageType = type,
            });
        }

        internal string GetNewVariableName(string prefix = null)
        {
            return $"ss_{($"{prefix}_" ?? "val_")}{_nextVariable++}";
        }

        internal ShaderContext AddShader(string name)
        {
            ShaderContext context = new ShaderContext(this, name);
            Shaders.Add(context);
            return context;
        }

        internal ConversionResult ToResult()
        {
            ConversionResult result = new ConversionResult();
            result.Messages.AddRange(Messages);
            foreach (ShaderContext sc in Shaders)
            {
                ShaderResult shader = new ShaderResult();
                shader.SourceCode = sc.Source;
                result.Output.Add(sc.Name, shader);
            }

            return result;
        }
    }
}
