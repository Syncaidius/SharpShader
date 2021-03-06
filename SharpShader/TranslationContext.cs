﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SharpShader
{
    [Serializable]
    internal partial class TranslationContext : MarshalByRefObject, IPoolable
    {
        [field: NonSerialized]
        internal ShaderLanguage Language { get; private set; }

        [field: NonSerialized]
        internal CSharpParseOptions ParseOptions { get; private set; }

        internal List<TranslationMessage> Messages { get; } = new List<TranslationMessage>();

        [field: NonSerialized]
        internal ReflectionInfo Reflection { get; } = new ReflectionInfo();

        [field: NonSerialized]
        internal TranslationRunner Runner { get; private set; }

        [field: NonSerialized]
        internal TranslationFlags Flags { get; private set; }

        internal List<ShaderTranslationContext> Shaders { get; } = new List<ShaderTranslationContext>();

        [NonSerialized]
        int _nextVariable = 0;

        internal void Initialize(TranslationRunner runner, ShaderLanguage language, List<string> preprocessorSymbols, TranslationFlags flags)
        {
            Flags = flags;
            Runner = runner;
            Language = language;
            ParseOptions = new CSharpParseOptions(LanguageVersion.CSharp7_3, DocumentationMode.Parse, SourceCodeKind.Regular, preprocessorSymbols);
        }

        internal void AddMessage(string text, SyntaxNode syntax, TranslationMessageType type = TranslationMessageType.Error)
        {
            Location loc = syntax.GetLocation();
            FileLinePositionSpan linePos = loc.GetLineSpan();
            AddMessage(text, linePos.StartLinePosition.Line, linePos.StartLinePosition.Character, type);
        }

        internal void AddMessage(string text, Location location, TranslationMessageType type = TranslationMessageType.Error)
        {
            FileLinePositionSpan linePos = location.GetLineSpan();
            AddMessage(text, linePos.StartLinePosition.Line, linePos.StartLinePosition.Character, type);
        }

        internal void AddMessage(string text, int lineNumber, int linePos, TranslationMessageType type = TranslationMessageType.Error)
        {
            Messages.Add(new TranslationMessage()
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

        void IPoolable.Clear()
        {
            foreach (ShaderTranslationContext sc in Shaders)
                Pooling.ShaderContexts.Put(sc);

            Shaders.Clear();
            Messages.Clear();
            ParseOptions = null;
            Language = null;
            Runner = null;
            Flags = TranslationFlags.None;
            _nextVariable = 0;
        }

        /// <summary>
        /// Recycles the current <see cref="TranslationContext"/>, pooling it for reuse later. This also recycles any other poolable resources the context was using.
        /// </summary>
        internal void Recycle()
        {
            Pooling.Contexts.Put(this);
        }
    }
}
