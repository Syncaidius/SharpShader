using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SharpShader
{
    [Serializable]
    public partial class TranslationContext : MarshalByRefObject
    {
        [field: NonSerialized]
        internal ShaderLanguage Language { get; }

        [field: NonSerialized]
        internal CSharpParseOptions ParseOptions { get; private set; }

        internal List<ShaderTranslationContext> Shaders { get; }

        internal List<ConversionMessage> Messages { get; }

        [NonSerialized]
        internal readonly ReflectionInfo Reflection;

        [NonSerialized]
        int _nextVariable = 0;

        [NonSerialized]
        internal readonly ObjectPool<ScopeInfo> ScopePool;

        internal TranslationContext(ShaderLanguage foundatation, List<string> preprocessorSymbols)
        {
            ScopePool = new ObjectPool<ScopeInfo>(() => new ScopeInfo());
            Reflection = new ReflectionInfo();
            Language = foundatation;
            Shaders = new List<ShaderTranslationContext>();
            Messages = new List<ConversionMessage>();
            ParseOptions = new CSharpParseOptions(LanguageVersion.CSharp7_3, DocumentationMode.Parse, SourceCodeKind.Regular, preprocessorSymbols);
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
    }
}
