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

        internal void AddMessage(string text, SyntaxNode syntax, ConversionMessageType type = ConversionMessageType.Error)
        {
            Location loc = syntax.GetLocation();
            FileLinePositionSpan linePos = loc.GetLineSpan();
            AddMessage(text, linePos.StartLinePosition.Line, linePos.StartLinePosition.Character, type);
        }

        internal void AddMessage(string text, Location location, ConversionMessageType type = ConversionMessageType.Error)
        {
            FileLinePositionSpan linePos = location.GetLineSpan();
            AddMessage(text, linePos.StartLinePosition.Line, linePos.StartLinePosition.Character, type);
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
            return $"{($"{prefix}_" ?? "val_")}SS_{_nextVariable++}";
        }

        internal ShaderContext AddShader(string name, string source)
        {
            ShaderContext context = new ShaderContext(this, name, ref source);
            Shaders.Add(context);
            return context;
        }

        internal ConversionResult ToResult(ConversionFlags flags)
        {
            ConversionResult result = new ConversionResult();
            result.Messages.AddRange(Messages);
            foreach (ShaderContext sc in Shaders)
            {
                ShaderResult shader = new ShaderResult();
                string strSourceResult = sc.ToString();


                if ((flags & ConversionFlags.SkipFormatting) != ConversionFlags.SkipFormatting)
                {
                    if ((flags & ConversionFlags.RemoveWhitespace) == ConversionFlags.RemoveWhitespace)
                        FormattingHelper.RemoveWhitespace(ref strSourceResult, flags);
                    else
                        FormattingHelper.CorrectIndents(ref strSourceResult, flags);
                }

                shader.SourceCode = strSourceResult;
                result.Output.Add(sc.Name, shader);


            }

            return result;
        }
    }
}
