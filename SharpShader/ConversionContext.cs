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
    public partial class ConversionContext : MarshalByRefObject
    {
        [field: NonSerialized]
        internal ShaderLanguage Language { get; }

        [field: NonSerialized]
        internal CSharpParseOptions ParseOptions { get; private set; }

        internal List<ShaderContext> Shaders { get; }

        internal List<ConversionMessage> Messages { get; }

        [NonSerialized]
        internal readonly ReflectionInfo Reflection;

        [field: NonSerialized]
        internal Dictionary<string, Type> TranslatedTypes { get; }

        [NonSerialized]
        int _nextVariable = 0;

        internal ConversionContext(ShaderLanguage foundatation)
        {
            Reflection = new ReflectionInfo();
            TranslatedTypes = new Dictionary<string, Type>();
            Language = foundatation;
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
    }
}
